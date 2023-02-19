Public Class FrmSearchByDate

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As String = "select * from main "
        Dim aad As New SqlClient.SqlDataAdapter(s, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "main")
        Dim vd As New DataView(dss.Tables("main"))
        vd.RowFilter = " datex >=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "and  datex <=" & "'" & Me.DateTimePicker3.Value.Date & "'" & ""
        'vd.RowFilter = " indate =" & "#" & Me.DateTimePicker1.Value.Date & "#" & ""
        DataGrid1.DataMember = ""
        DataGrid1.DataSource = vd
        '"SELECT * FROM Ta
    End Sub

    Private Sub DataGrid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid1.CellContentClick
        dgxx = Val(DataGrid1.CurrentCell.Value.ToString)
        If dgxx <> 0 Then
            dgx = dgxx
        End If
        TextBox1.Text = dgx
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sh As String = "delete * from main where fnumber=xxx1 "
        Dim cmh As New SqlClient.SqlCommand(sh, cn)
        cmh.Parameters.AddWithValue("xxx1", TextBox1.Text)
        If MsgBox("Â‹‹·  ‹—Ìœ Õ‹‹‹‹–› «·ÿ·» ø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cmh.ExecuteNonQuery()
            MsgBox(" „‹‹‹  ⁄„‹‹‹·‹‹‹Ì… «·Õ‹‹‹–›")
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox6.Text = ""
            Me.TextBox7.Text = ""
            Me.TextBox8.Text = ""
            Me.ComboBox1.Text = ""
            Me.DataGrid1.DataSource = ""

        End If
    End Sub
End Class