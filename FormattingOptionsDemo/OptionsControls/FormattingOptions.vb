''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.ComponentModel
Imports ActiveQueryBuilder.Core

Namespace OptionsControls
    Partial Public Class FormattingOptions
        Inherits UserControl
        Private ReadOnly _tabsContainer As New Dictionary(Of Integer, Object)()
        Private ReadOnly _query As IQueryController = New SQLQuery()

        Private _builder As FormattedSQLBuilder
        Private _sqlFormattingOptions As New SQLFormattingOptions()
        Private _sqlContext As New SQLContext()
        Private _currentOptionsControl As UserControl

        Private ReadOnly _mainQueryTab As MainQueryTab
        Private ReadOnly _mCommonTab As CommonTab
        Private ReadOnly _mExpressionsTab As ExpressionsTab

        Private ReadOnly _subQueryInExprTab As SubQueryTab
        Private ReadOnly _sCommonTab As CommonTab
        Private ReadOnly _sExpressionsTab As ExpressionsTab

        Private ReadOnly _derivedTab As SubQueryTab
        Private ReadOnly _dCommonTab As CommonTab
        Private ReadOnly _dExpressionsTab As ExpressionsTab

        Private ReadOnly _cteTab As SubQueryTab
        Private ReadOnly _cCommonTab As CommonTab
        Private ReadOnly _cExpressionsTab As ExpressionsTab

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property SqlFormattingOptions() As SQLFormattingOptions
            Get
                Return _sqlFormattingOptions
            End Get
            Set(value As SQLFormattingOptions)
                SetOptions(value)
            End Set
        End Property
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property SqlContext() As SQLContext
            Get
                Return _sqlContext
            End Get
            Set(value As SQLContext)
                SetSqlContext(value)
            End Set
        End Property

        Public Event OptionsUpdated As EventHandler

        Public Sub New()
            InitializeComponent()

            _sqlContext.SyntaxProvider = New MSSQLSyntaxProvider()
            _builder = New FormattedSQLBuilder(_sqlFormattingOptions)
            _query.SQLContext = _sqlContext

            AddHandler _sqlFormattingOptions.Updated, AddressOf OnPropertyChanged
            AddHandler _query.SQLUpdated, AddressOf sqlQuery1_SQLUpdated

            _query.SQL = "With CTE1 As (Select first, second, third From Orders, Products)" & "SELECT" & vbCrLf & "  customer.first_name," & vbCrLf & "  customer.last_name," & vbCrLf & "  rental.return_date" & vbCrLf & "FROM" & vbCrLf & "  customer" & vbCrLf & "  " & "INNER JOIN rental ON rental.customer_id = customer.customer_id" & vbCrLf & "  INNER JOIN (SELECT" & vbCrLf & "      address.*" & vbCrLf & "   " & " FROM" & vbCrLf & "      address" & vbCrLf & "      INNER JOIN city ON address.city_id = city.city_id" & vbCrLf & "    WHERE" & vbCrLf & "      city.country_id = 5)" & " addr ON customer.address_id = addr.address_id" & vbCrLf & "WHERE" & vbCrLf & "  customer.store_id IN (SELECT" & vbCrLf & "      store.store_id" & vbCrLf & "    FROM" & vbCrLf & "     " & " store" & vbCrLf & "    WHERE" & vbCrLf & "      (store.manager_staff_id = 10 AND" & vbCrLf & "      store.store_id < 11) OR" & vbCrLf & "      (((store.manager_staff_id = TRUE) OR" & vbCrLf & "      " & "  (store.manager_staff_id BETWEEN 10 AND 20))))" & vbCrLf & "ORDER BY" & vbCrLf & "  rental.return_date"

            ' MainQuery options
            _mainQueryTab = New MainQueryTab(_builder) With {.Dock = DockStyle.Fill}
            _mCommonTab = New CommonTab(_sqlFormattingOptions, _sqlFormattingOptions.MainQueryFormat) With {.Dock = DockStyle.Fill}
            _mExpressionsTab = New ExpressionsTab(_sqlFormattingOptions, _sqlFormattingOptions.MainQueryFormat) With {.Dock = DockStyle.Fill}
            _tabsContainer.Add(0, _mainQueryTab)
            _tabsContainer.Add(1, _mCommonTab)
            _tabsContainer.Add(2, _mExpressionsTab)
            ' SubQuery in expression options
            _subQueryInExprTab = New SubQueryTab(_sqlFormattingOptions) With {.Dock = DockStyle.Fill}
            _sCommonTab = New CommonTab(_sqlFormattingOptions, _sqlFormattingOptions.ExpressionSubQueryFormat) With {.Dock = DockStyle.Fill}
            _sExpressionsTab = New ExpressionsTab(_sqlFormattingOptions, _sqlFormattingOptions.ExpressionSubQueryFormat) With {.Dock = DockStyle.Fill}
            _tabsContainer.Add(3, _subQueryInExprTab)
            _tabsContainer.Add(4, _sCommonTab)
            _tabsContainer.Add(5, _sExpressionsTab)
            ' Derived tables options
            _derivedTab = New SubQueryTab(_sqlFormattingOptions, "Derived Tables") With {.Dock = DockStyle.Fill}
            _dCommonTab = New CommonTab(_sqlFormattingOptions, _sqlFormattingOptions.DerivedQueryFormat) With {.Dock = DockStyle.Fill}
            _dExpressionsTab = New ExpressionsTab(_sqlFormattingOptions, _sqlFormattingOptions.ExpressionSubQueryFormat) With {.Dock = DockStyle.Fill}
            _tabsContainer.Add(6, _derivedTab)
            _tabsContainer.Add(7, _dCommonTab)
            _tabsContainer.Add(8, _dExpressionsTab)
            ' Common table expression options
            _cteTab = New SubQueryTab(_sqlFormattingOptions, "CTE") With {.Dock = DockStyle.Fill}
            _cCommonTab = New CommonTab(_sqlFormattingOptions, _sqlFormattingOptions.CTESubQueryFormat) With {.Dock = DockStyle.Fill}
            _cExpressionsTab = New ExpressionsTab(_sqlFormattingOptions, _sqlFormattingOptions.ExpressionSubQueryFormat) With {.Dock = DockStyle.Fill}
            _tabsContainer.Add(9, _cteTab)
            _tabsContainer.Add(10, _cCommonTab)
            _tabsContainer.Add(11, _cExpressionsTab)

            SetCurrentOptionsControl(CType(_tabsContainer(0), UserControl))
        End Sub

        Public Sub UpdateOptions()
            For Each control In _tabsContainer.Values
                Dim loader = TryCast(control, IOptionsLoader)
                If loader IsNot Nothing Then
                    loader.LoadOptionsOnForm()
                End If
            Next control
            sqlTextEditor1.Text = _builder.GetSQL(_query.QueryRoot)
        End Sub

        Private Sub SetSqlContext(value As SQLContext)
            If _sqlContext IsNot Nothing AndAlso _sqlContext IsNot value Then
                _sqlContext = value
            End If
        End Sub

        Private Sub SetOptions(value As SQLFormattingOptions)
            If _sqlFormattingOptions Is value Then
                Return
            End If

            RemoveHandler _sqlFormattingOptions.Updated, AddressOf OnPropertyChanged
            _sqlFormattingOptions.Dispose()
            _builder.Dispose()

            _sqlFormattingOptions = value
            _builder = New FormattedSQLBuilder(_sqlFormattingOptions)
            SetOptionsOnChildControls()

            AddHandler _sqlFormattingOptions.Updated, AddressOf OnPropertyChanged
            UpdateOptions()
        End Sub

        Private Sub SetOptionsOnChildControls()
            ' Main
            _mainQueryTab.Builder = _builder
            _mainQueryTab.Options = SqlFormattingOptions

            _mCommonTab.FormattingOptions = _sqlFormattingOptions
            _mCommonTab.SelectFormat = _sqlFormattingOptions.MainQueryFormat

            _mExpressionsTab.FormattingOptions = _sqlFormattingOptions
            _mExpressionsTab.SelectFormat = _sqlFormattingOptions.MainQueryFormat
            ' SubQuery
            _subQueryInExprTab.FormattingOptions = _sqlFormattingOptions
            _subQueryInExprTab.SelectFormat = _sqlFormattingOptions.ExpressionSubQueryFormat

            _sCommonTab.FormattingOptions = _sqlFormattingOptions
            _sCommonTab.SelectFormat = _sqlFormattingOptions.ExpressionSubQueryFormat

            _sExpressionsTab.FormattingOptions = _sqlFormattingOptions
            _sExpressionsTab.SelectFormat = _sqlFormattingOptions.ExpressionSubQueryFormat
            ' Derived
            _derivedTab.FormattingOptions = _sqlFormattingOptions
            _derivedTab.SelectFormat = _sqlFormattingOptions.DerivedQueryFormat

            _dCommonTab.FormattingOptions = _sqlFormattingOptions
            _dCommonTab.SelectFormat = _sqlFormattingOptions.DerivedQueryFormat

            _dExpressionsTab.FormattingOptions = _sqlFormattingOptions
            _dExpressionsTab.SelectFormat = _sqlFormattingOptions.DerivedQueryFormat
            ' Cte
            _cteTab.FormattingOptions = _sqlFormattingOptions
            _cteTab.SelectFormat = _sqlFormattingOptions.CTESubQueryFormat

            _cCommonTab.FormattingOptions = _sqlFormattingOptions
            _cCommonTab.SelectFormat = _sqlFormattingOptions.CTESubQueryFormat

            _cExpressionsTab.FormattingOptions = _sqlFormattingOptions
            _cExpressionsTab.SelectFormat = _sqlFormattingOptions.CTESubQueryFormat
        End Sub

        Private Sub SetCurrentOptionsControl(control As UserControl)
            _currentOptionsControl = control

            currentTabPanel.Controls.Clear()

            currentTabPanel.Controls.Add(_currentOptionsControl)

            CType(_currentOptionsControl, IOptionsLoader).LoadOptionsOnForm()

            Invalidate()
        End Sub

        Private Sub sqlQuery1_SQLUpdated(sender As Object, e As EventArgs)
            sqlTextEditor1.Text = _builder.GetSQL(_query.QueryRoot)
        End Sub

        Private Sub sqlTextEditor1_Validating(sender As Object, e As CancelEventArgs) Handles sqlTextEditor1.Validating
            Try
                ' Update the query builder with manually edited query text:
                _query.SQL = sqlTextEditor1.Text

                ' Hide error banner if any
                ShowErrorBanner(sqlTextEditor1, "")
            Catch ex As SQLParsingException
                ' Set caret to error position
                sqlTextEditor1.SelectionStart = ex.ErrorPos.pos

                ' Show banner with error text
                ShowErrorBanner(sqlTextEditor1, ex.Message)
                'MessageBox.Show(ex.Message);
            End Try
        End Sub

        Public Sub ShowErrorBanner(control As Control, text As String)
            ' Destory banner if already showing
            Dim banners() As Control = control.Controls.Find("ErrorBanner", True)

            If banners.Length > 0 Then
                For Each banner As Control In banners
                    banner.Dispose()
                Next banner
            End If

            ' Show new banner if text is not empty
            If Not String.IsNullOrEmpty(text) Then
                Dim label As Label = New Label With {.Name = "ErrorBanner", .Text = text, .BorderStyle = BorderStyle.FixedSingle, .BackColor = Color.LightPink, .AutoSize = True, .Visible = True}

                control.Controls.Add(label)
                label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
                label.BringToFront()
                control.Focus()
            End If
        End Sub

        Private Sub OnPropertyChanged(sender As Object, e As EventArgs)
            sqlTextEditor1.Text = _builder.GetSQL(_query.QueryRoot)
            RaiseEvent OptionsUpdated(Me, EventArgs.Empty)
        End Sub

        Private Sub listBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles listBox1.DrawItem
            e.DrawBackground()
            Dim font As Font
            If e.Index = 0 OrElse e.Index = 3 OrElse e.Index = 6 OrElse e.Index = 9 Then
                font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            Else
                font = New Font("Microsoft Sans Serif", 10)
            End If

            e.Graphics.DrawString(listBox1.Items(e.Index).ToString(), font, Brushes.Black, e.Bounds)
            e.DrawFocusRectangle()
        End Sub

        Private Sub listBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles listBox1.SelectedValueChanged
            If listBox1.SelectedIndex < 0 Then
                Return
            End If

            _currentOptionsControl = CType(_tabsContainer(listBox1.SelectedIndex), UserControl)

            SetCurrentOptionsControl(_currentOptionsControl)
        End Sub
    End Class
End Namespace
