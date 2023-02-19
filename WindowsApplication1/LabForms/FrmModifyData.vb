Public Class FrmModifyData

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

        End If
        If TextBox8.Text = "female" Then
            Me.RadioButton2.Checked = True

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim s As String = "update  main set namex=xx1,age=xx2,address=xx3,husbend=xx4,phone=xx5,idcard=xx6,datex=xx7,city=xx8,gender=xx9 where fnumber=xxx"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("xx1", TextBox2.Text)
        cm.Parameters.AddWithValue("xx2", TextBox5.Text)
        cm.Parameters.AddWithValue("xx3", TextBox3.Text)
        cm.Parameters.AddWithValue("xx4", TextBox4.Text)
        cm.Parameters.AddWithValue("xx5", TextBox6.Text)
        cm.Parameters.AddWithValue("xx6", TextBox7.Text)
        cm.Parameters.AddWithValue("xx7", DateTimePicker1.Value.Date)
        cm.Parameters.AddWithValue("xx8", ComboBox1.Text)
        cm.Parameters.AddWithValue("xx9", TextBox8.Text)
        cm.Parameters.AddWithValue("xxx", TextBox1.Text)
        Try
            cm.ExecuteNonQuery()
            MsgBox(" „  ⁄„·Ì… «· ⁄œÌ·")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox8.Text = "male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox8.Text = "female"
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class