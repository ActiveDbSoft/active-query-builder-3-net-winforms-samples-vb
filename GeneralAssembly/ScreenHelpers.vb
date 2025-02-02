''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''


Public Class ScreenHelpers
    Private Const DesignTimeDpi As Integer = 96
    Private Shared _currentDPI As Integer = -1

    Private Shared Function MulDiv(number As Integer, numerator As Integer, denominator As Integer) As Integer
        Return CInt(Fix((CLng(Fix(number)) * numerator) / denominator))
    End Function

    Public Shared Function GetCurrentDPI() As Integer
        Try
            Dim graphics as Graphics = Graphics.FromHwnd(IntPtr.Zero)
            Dim result = CInt(Fix(graphics.DpiX))
            graphics.Dispose()

            Return result
        Catch
            Return DesignTimeDpi
        End Try
    End Function

    Public Shared Function ScaleByCurrentDPI(value As Integer) As Integer
        If _currentDPI = -1 Then
            _currentDPI = GetCurrentDPI()
        End If

        Return MulDiv(value, _currentDPI, DesignTimeDpi)
    End Function

    Public Shared Function ScaleByCurrentDPI(bounds As Rectangle) As Rectangle
        If _currentDPI = -1 Then
            _currentDPI = GetCurrentDPI()
        End If

        Return New Rectangle(MulDiv(bounds.X, _currentDPI, DesignTimeDpi), MulDiv(bounds.Y, _currentDPI, DesignTimeDpi), MulDiv(bounds.Width, _currentDPI, DesignTimeDpi), MulDiv(bounds.Height, _currentDPI, DesignTimeDpi))
    End Function
End Class
