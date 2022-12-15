Public Class Form4

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sh As String = "select * from main where fnumber=xxx1 "
        Dim cmh As New SqlClient.SqlCommand(sh, cn)
        cmh.Parameters.AddWithValue("xxx1", TextBox1.Text)
        Dim rdh As SqlClient.SqlDataReader = cmh.ExecuteReader
        If rdh.Read = True Then
            TextBox2.Text = rdh!namex
            ComboBox1.Text = rdh!city
            TextBox3.Text = rdh!address
            TextBox4.Text = rdh!husbend
            TextBox5.Text = rdh!age
            TextBox6.Text = rdh!phone
            TextBox7.Text = rdh!idcard
            Me.DateTimePicker1.Value = rdh!datex
            TextBox8.Text = rdh!gender
            'pinm = TextBox6.Text


        Else
            'Me.Button2.Visible = True
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "male" Then
            Me.RadioButton1.Checked = True
        Else
            Me.RadioButton2.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        vv1 = Me.TextBox1.Text
        Dim f As New Form11
        f.ShowDialog()
    End Sub
End Class