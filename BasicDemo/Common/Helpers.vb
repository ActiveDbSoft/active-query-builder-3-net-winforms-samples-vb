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

Namespace Common
    Friend Module Helpers
        Private Const DesignTimeDpi As Integer = 96
        Private _currentDPI As Integer = -1

        Private Function MulDiv(ByVal number As Integer, numerator As Integer, denominator As Integer) As Integer
            Return CType((CLng(number) * numerator / denominator), Integer)
        End Function

        Function GetCurrentDPI() As Integer
            Try
                Dim graphics As Graphics = Graphics.FromHwnd(IntPtr.Zero)
                Dim result As Int32 = CInt(graphics.DpiX)
                graphics.Dispose
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
