Public Class PHARMACY

    Private Sub PHARMACY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsbhDataSet1.pharmacymain' table. You can move, or remove it, as needed.
        'Me.PharmacymainTableAdapter.Fill(Me.DbsbhDataSet1.pharmacymain)
        Me.Timer1.Start()
        'TODO: This line of code loads data into the 'DbsbhDataSet.Pharmacy' table. You can move, or remove it, as needed.
        'Me.PharmacyTableAdapter.Fill(Me.DbsbhDataSet.Pharmacy)
        Dim s1 As String = "select * from pharmacymain "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "pharmacymain")
        Dim vd As New DataView(dss.Tables("pharmacymain"))
        vd.RowFilter = "state=" & "'" & "0" & "'" & ""
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label7.Text = Format(Now, "hh:mm:ss")
        'Dim da2 As New SqlClient.SqlDataAdapter
        'Dim ds2 As DataSet
        ''Dim dr2 As DataRow
        'Dim dt2 As DataTable
        'Dim x As String = "select * from MAIN_TABLE"
        'da2 = New SqlClient.SqlDataAdapter(x, cn)
        'ds2 = New DataSet
        'da2.Fill(ds2, x)
        'dt2 = ds2.Tables(x)
        ''TextBox1.Text = dt2.Rows.Count
        ''ToolStripStatusLabel9.Text = dt2.Rows.Count
        'ToolStripStatusLabel2.Text = user
        'ToolStripStatusLabel4.Text = log_date
        'ToolStripStatusLabel6.Text = log_time
        Me.Label8.Text = Format(Now, "dd/MM/yyyy")
        Dim ss As String = "select * from pharmacymain "
        Dim aadd As New SqlClient.SqlDataAdapter(ss, cn)
        Dim dsss As New DataSet
        dsss.Clear()
        aadd.Fill(dsss, "pharmacymain")
        Dim vdd As New DataView(dsss.Tables("pharmacymain"))

        vdd.RowFilter = " state= " & "'" & 0 & "'" & ""
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vdd
        Me.DataGridView1.Focus()
        If DataGridView1.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot2 As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView1.Rows.Count - 1
                xc = xc + 1
            Next
            Me.Label2.Text = xc
            Me.Label9.Text = xc
            Me.Label6.Text = user
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Select Case e.ColumnIndex
            Case 0
                Dim dgx As String = ""
                dgx = DataGridView1.CurrentCell.Value
                TextBox1.Text = dgx
                Dim sd As String = "select * from main where fnumber=xx1 "
                Dim cmd As New SqlClient.SqlCommand(sd, cn)
                cmd.Parameters.AddWithValue("xx1", TextBox1.Text)
                Dim rdd As SqlClient.SqlDataReader = cmd.ExecuteReader
                If rdd.Read = True Then
                    Me.Label4.Text = rdd!namex
                End If
            Case 1
                Timer1.Stop()
            Case 2
                Timer1.Stop()
            Case 3
                Timer1.Stop()
            Case 4
                Timer1.Stop()
            Case 5
                Timer1.Stop()
            Case 6
                Timer1.Stop()
        End Select
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = TextBox1.Text
        vv2 = 0
        Dim f As New Form9
        f.ShowDialog()

    End Sub
End Class