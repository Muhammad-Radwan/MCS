Public Class TADEELDN

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        If String.IsNullOrWhiteSpace(ComboBox4.Text) = True Then
            MsgBox("اسف .. ارجو ادخال الاسم الجديد للطبيب ")
            ComboBox4.Focus()
            Return
        End If
        Call Class1.CONNIC()
        Dim ss2 As String = "update dn set DN=@DN where idd=@idd"
        Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
            'cmm2.Parameters.AddWithValue("@idd", TextBox1.Text)
            cmm2.Parameters.AddWithValue("@DN", Trim(ComboBox4.Text))
            cmm2.Parameters.AddWithValue("@idd", CInt(dgxx))
            Try
                cmm2.ExecuteNonQuery()
                MsgBox("تم تعديل اسم الطبيب")
                Me.Close()
            Catch ex As Exception
            End Try
        End Using
    End Sub

    Private Sub TADEELDN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TADEELDN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If String.IsNullOrWhiteSpace(ComboBox4.Text) = True Then
                MsgBox("اسف .. ارجو ادخال الاسم الجديد للطبيب ")
                ComboBox4.Focus()
                Return
            Else
                B11.Focus()
            End If
        End If
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub B11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles B11.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class