Public Class Form26

    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBNDataSet1.MAIN' table. You can move, or remove it, as needed.
        'Me.MAINTableAdapter.Fill(Me.DBNDataSet1.MAIN)
        Dim s As String
        s = "select * from main"
        Dim ad7 As New SqlClient.SqlDataAdapter(s, cn)
        Dim ds7 As New DataSet
        ad7.Fill(ds7, "main")
        ComboBox1.DataSource = ds7.Tables(0)
        ComboBox1.DisplayMember = "mona"
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.DataGridView1.Focus()
        End If
        If Asc(e.KeyChar) = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        Dim s As String = "select * from main "
        Dim aad As New SqlClient.SqlDataAdapter(s, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "main")
        Dim vd As New DataView(dss.Tables("main"))
        vd.RowFilter = " mona LIKE '%" & ComboBox1.Text & "%'" & ""
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Select Case e.ColumnIndex
            Case 0
                dgx = DataGridView1.CurrentCell.Value
                Me.Label1.Text = dgx
                ' f6 = 1
                Me.Hide()

        End Select
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Close()
        End If

    End Sub
End Class