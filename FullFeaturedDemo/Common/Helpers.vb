'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Linq
Imports ActiveQueryBuilder.Core

Namespace Common
    Friend Module Helpers

        Public Function CreateSqlCommand(sqlCommand As String, sqlQuery As SQLQuery) As DbCommand
            Dim command As DbCommand = DirectCast(sqlQuery.SQLContext.MetadataProvider.Connection.CreateCommand(), DbCommand)
            command.CommandText = sqlCommand

            ' handle the query parameters
            If sqlQuery.QueryParameters.Count <= 0 Then
                Return command
            End If

            For Each p As Parameter In sqlQuery.QueryParameters.Where(Function(item) Not command.Parameters.Contains(item.FullName))
                Dim parameter As New SqlParameter() With {
                    .ParameterName = p.FullName,
                    .DbType = p.DataType
                }
                command.Parameters.Add(parameter)
            Next
            Dim qpf As QueryParametersForm = New QueryParametersForm(command)
            qpf.ShowDialog()
            Return command
        End Function

        Public Function ExecuteSql(sqlCommand As String, sqlQuery As SQLQuery) As DataTable
            If String.IsNullOrEmpty(sqlCommand) Then
                Return Nothing
            End If

            If sqlQuery.SQLContext.MetadataProvider Is Nothing Then
                Return Nothing
            End If

            If Not sqlQuery.SQLContext.MetadataProvider.Connected Then
                sqlQuery.SQLContext.MetadataProvider.Connect()
            End If

            If String.IsNullOrEmpty(sqlCommand) Then
                Return Nothing
            End If

            If Not sqlQuery.SQLContext.MetadataProvider.Connected Then
                sqlQuery.SQLContext.MetadataProvider.Connect()
            End If

            Dim command As DbCommand = CreateSqlCommand(sqlCommand, sqlQuery)

            Dim table As New DataTable("result")

            Using dbReader As DbDataReader = command.ExecuteReader()

                For i As Integer = 0 To dbReader.FieldCount - 1
                    table.Columns.Add(dbReader.GetName(i))
                Next

                While dbReader.Read()
                    Dim values As Object() = New Object(dbReader.FieldCount - 1) {}
                    dbReader.GetValues(values)
                    table.Rows.Add(values)
                End While

                Return table
            End Using
        End Function

        Private Const DesignTimeDpi As Integer = 96
        Private _currentDPI As Integer = -1

        Private Function MulDiv(ByVal number As Integer, numerator As Integer, denominator As Integer) As Integer
            Return (CLng(number) * numerator / denominator)
        End Function

        Function GetCurrentDPI() As Integer
            Try
                Dim graphics As Graphics = Graphics.FromHwnd(IntPtr.Zero)
                Dim result As Int32 = CInt(graphics.DpiX)
                graphics.Dispose()
                Return result
            Catch
                Return DesignTimeDpi
            End Try
        End Function

        Function ScaleByCurrentDPI(ByVal value As Integer) As Integer
            If _currentDPI = -1 Then
                _currentDPI = GetCurrentDPI()
            End If

            Return MulDiv(value, _currentDPI, DesignTimeDpi)
        End Function

        Function ScaleByCurrentDPI(ByVal bounds As Rectangle) As Rectangle
            If _currentDPI = -1 Then
                _currentDPI = GetCurrentDPI()
            End If

            Return New Rectangle(MulDiv(bounds.X, _currentDPI, DesignTimeDpi), MulDiv(bounds.Y, _currentDPI, DesignTimeDpi), MulDiv(bounds.Width, _currentDPI, DesignTimeDpi), MulDiv(bounds.Height, _currentDPI, DesignTimeDpi))
        End Function
    End Module
End Namespace
