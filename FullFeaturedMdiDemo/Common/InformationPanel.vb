'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports ActiveQueryBuilder.View

Public Class InformationPanel 
    Inherits UserControl
    Implements IInformationPanel

     Private Const LineWidthLimit As Integer = 50
        Private _iconLocation As InfoIconLocation = InfoIconLocation.Right

        Public Property IconLocation As InfoIconLocation Implements IInformationPanel.IconLocation
            Get
                Return _iconLocation
            End Get
            Set
                _iconLocation = value

                If _iconLocation = InfoIconLocation.Right Then
                    pictureBox1.Left = pnlMain.Width - pictureBox1.Width - Common.Helpers.ScaleByCurrentDPI(3)
                    lbText.Left = Common.Helpers.ScaleByCurrentDPI(3)
                    pictureBox1.Anchor = AnchorStyles.Right
                ElseIf _iconLocation = InfoIconLocation.Left Then
                    pictureBox1.Left = Common.Helpers.ScaleByCurrentDPI(3)
                    lbText.Left = pnlMain.Width - lbText.Width - Common.Helpers.ScaleByCurrentDPI(3)
                    pictureBox1.Anchor = AnchorStyles.Left
                End If
            End Set
        End Property

        Private stringTooltip As String = String.Empty

        Public Property Tooltip As String Implements IInformationPanel.Tooltip
            Get
                Return stringTooltip
            End Get
            Set
                stringTooltip = value
                Dim caption As string = If(Not String.IsNullOrEmpty(stringTooltip), WrapText(stringTooltip), _tooltip)
                _toolTip.SetToolTip(pnlMain, caption)
                _toolTip.SetToolTip(lbText, caption)
            End Set
        End Property

        Public Property InfoText As String Implements IInformationPanel.InfoText
            Get
                Return lbText.Text
            End Get
            Set(value As String)
                lbText.Text = value
                UpdateHeight(value)
                UpdateIconLocation()
            End Set
        End Property

        Public Property IconTooltip As String Implements IInformationPanel.IconTooltip
            Get
                Return _iconTooltip
            End Get
            Set(value As String)
                _iconTooltip = value
                _toolTip.SetToolTip(pictureBox1, If(Not String.IsNullOrEmpty(_iconTooltip), WrapText(_iconTooltip), _iconTooltip))
            End Set
        End Property

        Public Property ShowIcon As Boolean Implements IInformationPanel.ShowIcon
            Get
                Return pictureBox1.Visible
            End Get
            Set(value As Boolean)
                pictureBox1.Visible = value

                If value Then
                    lbText.Width = Width - Common.Helpers.ScaleByCurrentDPI(26)
                Else
                    lbText.Width = Width
                End If
            End Set
        End Property

        Private _iconTooltip As String = String.Empty
        Private ReadOnly _toolTip As ToolTip = New ToolTip()
        Private ReadOnly _iconSubscription As IDisposable

        Public Sub New()
            InitializeComponent()

            _iconSubscription = WinForms.Images.Common.Info.Subscribe(CType(DirectCast(Function(x as Image)
                pictureBox1.Image = x
                Return x
            End Function, [Delegate]), IObserver(Of Image)))

            UpdateHeight(lbText.Text)
            UpdateIconLocation()
        End Sub

        Public Sub New(text As String, iconTooltip As String)
            Me.New()
            InfoText = text
            IconTooltip = iconTooltip
        End Sub

        'Protected Overrides Sub Dispose()
        '    If disposing Then
        '        _iconSubscription.Dispose()
        '        components?.Dispose()
        '    End If

        '    MyBase.Dispose(disposing)
        'End Sub

        Protected Overrides Sub OnResize(e As EventArgs)
            UpdateHeight(lbText.Text)
            UpdateIconLocation()
            MyBase.OnResize(e)
        End Sub

        Private Sub UpdateHeight(text As String)
            Using g As Graphics = CreateGraphics()
                Dim size As SizeF = g.MeasureString(text, lbText.Font, lbText.Width)
                Height = CInt(Math.Ceiling(size.Height)) + 7
            End Using
        End Sub

        Private Sub UpdateIconLocation()
            pictureBox1.Top = Height / 2 - pictureBox1.Height / 2
        End Sub

        Private Function WrapText(text As String) As String
            Dim words As String() = text.Split(" "c)
            Dim newSentence As StringBuilder = New StringBuilder()
            Dim line As String = ""

            For Each word As String In words

                If (line & word).Length > LineWidthLimit Then
                    newSentence.AppendLine(line)
                    line = ""
                End If

                line += $"{word} "
            Next

            If line.Length > 0 Then newSentence.AppendLine(line)
            Return newSentence.ToString()
        End Function
    End Class
