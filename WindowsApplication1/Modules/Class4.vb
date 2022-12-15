Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Configuration
Imports System.Resources
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Drawing.Printing
Public Class Class4
    Shared Sub CONNIC()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        Else
            'CALL CLASS4.CONNIC()
        End If
    End Sub
End Class
