Public Class Form6

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
            If Me.TextBox8.Text = "male" Then
                Me.RadioButton1.Checked = True
            Else
                Me.RadioButton2.Checked = True
            End If


        Else
            'Me.Button2.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim s As String = "delete * from main where fnumber=xxx"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("xxx", TextBox1.Text)
        If MsgBox("ARE YOU SURE TO DELETE THIS FILE", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cm.ExecuteNonQuery()
            MsgBox("DELETE IS DONE..")
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox6.Text = ""
            Me.TextBox7.Text = ""
            Me.TextBox8.Text = ""
            Me.ComboBox1.Text = ""

        End If


    End Sub
End Class