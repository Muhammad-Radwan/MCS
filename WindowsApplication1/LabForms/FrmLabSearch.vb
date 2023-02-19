Public Class FrmLabSearch

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As String = "select * from main"
        Dim aad As New SqlClient.SqlDataAdapter(s, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "main")
        Dim vd As New DataView(dss.Tables("main"))
        vd.RowFilter = " namex LIKE '%" & TextBox9.Text & "%'" & ""
        DataGrid1.DataMember = ""
        DataGrid1.DataSource = vd
    End Sub

    Private Sub DataGrid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid1.CellContentClick
        Select Case e.ColumnIndex
            Case 0
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

        End Select
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "male" Then
            Me.RadioButton1.Checked = True
        Else
            Me.RadioButton2.Checked = True
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Dim s As String = "select * from main"
        Dim aad As New SqlClient.SqlDataAdapter(s, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "main")
        Dim vd As New DataView(dss.Tables("main"))
        vd.RowFilter = " namex LIKE '%" & TextBox9.Text & "%'" & ""
        DataGrid1.DataMember = ""
        DataGrid1.DataSource = vd

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsbhDataSet6.main' table. You can move, or remove it, as needed.
        '  Me.MainTableAdapter.Fill(Me.DbsbhDataSet6.main)

    End Sub

    Private Sub DataGrid1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectionChanged
        Select Case e.ToString
            Case 0
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
        End Select
    End Sub
End Class