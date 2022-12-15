Public Class Form14

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = Me.ComboBox1.Text
        d1 = Me.DateTimePicker1
        d2 = Me.DateTimePicker2
        Dim f As New Form15
        f.ShowDialog()
    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sk1 As String
        sk1 = "select * from DN"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "DN")
        ComboBox1.DataSource = dsk1.Tables(0)
        ComboBox1.DisplayMember = "DN"
        ComboBox1.SelectedIndex = -1
    End Sub
End Class