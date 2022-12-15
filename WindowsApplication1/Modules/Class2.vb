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
Public Class Class2
    Shared Sub BUTTON(ByVal B)
        Call Class1.CONNIC()
        Dim ser As String = "select * from KESEM where IDK=xs"
        Dim cmser As New SqlClient.SqlCommand(ser, cn)
        cmser.Parameters.AddWithValue("xs", B)
        Dim rdser As SqlClient.SqlDataReader = cmser.ExecuteReader
        If rdser.Read = True Then
            KESEM = rdser!KESEM
        End If
        rdser.Close()
        Call Class1.CONNIC()
    End Sub
End Class
