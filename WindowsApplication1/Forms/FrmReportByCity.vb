Public Class FrmReportByCity

    Private Sub Form1622_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sk1 As String
        sk1 = "select * from city"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "city")
        ComboBox1.DataSource = dsk1.Tables(0)
        ComboBox1.DisplayMember = "city"
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = Me.ComboBox1.Text
        Dim f As New FrmReportByCityViewer
        f.ShowDialog()
    End Sub
End Class