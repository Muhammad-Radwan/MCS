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
Public Class Class1
    Shared Sub CONNIC()
        If cn.State = ConnectionState.Closed Then
            CONN()
            cn.Open()
        Else
            'CALL CLASS4.CONNIC()
        End If
    End Sub
    Shared Sub proced()
        Call Class1.CONNIC()
        Dim s20m As String = "insert into procedure_t(user_name,procedure_name,pro_date) values(@user_name,@procedure_name,@pro_date)"
        Dim cm20m As New SqlClient.SqlCommand(s20m, cn)
        cm20m.Parameters.AddWithValue("@user_name", user)
        cm20m.Parameters.AddWithValue("@procedure_name", procedx)
        cm20m.Parameters.AddWithValue("@pro_date", Date.Now)
        Try
            cm20m.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox("procedur error")
        End Try
    End Sub

End Class
