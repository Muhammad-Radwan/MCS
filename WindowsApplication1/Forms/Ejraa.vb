Public Class Ejraa

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim ss232 As String = "insert into KESEM(KESEM) VALUES(@KESEM)"
        'Dim cmm232 As New SqlClient.SqlCommand(ss232, cn)
        'cmm232.Parameters.AddWithValue("@KESEM", ComboBox3.Text)
        'Try
        '    cmm232.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox("KESEM")
        'End Try
        'Dim Str As String = "SELECT MAX(IDK) FROM KESEM "
        'Dim cmd As New SqlClient.SqlCommand(Str, cn)
        'M6 = cmd.ExecuteScalar
        Dim st As String = "select count(idk) from kesem"
        Dim cmt As New SqlClient.SqlCommand(st, cn)
        Dim a As Integer = cmt.ExecuteScalar
        Label1.Text = a + 1
        Dim ss2F As String = "insert into KESEM(idk,kesem)VALUES(@idk,@kesem)"
        Dim cmm2F As New SqlClient.SqlCommand(ss2F, cn)
        cmm2F.Parameters.AddWithValue("@idk", Label1.Text)
        cmm2F.Parameters.AddWithValue("@kesem", ComboBox3.Text)
        Try
            cmm2F.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Dim sK As String = "select * from KESEM where KESEM=@KESEM"
        Dim cmK As New SqlClient.SqlCommand(sK, cn)
        cmK.Parameters.AddWithValue("@KESEM", ComboBox3.Text)
        Dim rdK As SqlClient.SqlDataReader
        rdK = cmK.ExecuteReader
        If rdK.Read = True Then
            Label1.Text = rdK!idK
        End If
        rdK.Close()
        Dim ss23 As String = "insert into Ejraa(Ejraa,IDK) VALUES(@Ejraa,@IDK)"
        ' Dim cmm23 As New OleDb.OleDbCommand(ss23, cn)
        Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
        cmm23.Parameters.AddWithValue("@Ejraa", ComboBox1.Text)
        cmm23.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
        Try
            cmm23.ExecuteNonQuery()
            MsgBox("تم الحفظ ")
            Me.DataGridView1.DataSource = ""
            Dim s1 As String = "select * from Ejraa "
            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "Ejraa")
            Dim vd As New DataView(dss.Tables("Ejraa"))
            vd.RowFilter = "Ejraa=" & "'" & Me.ComboBox1.Text & "'" & ""
            Me.DataGridView1.DataMember = ""
            DataGridView1.DataSource = vd
            Me.ComboBox3.Text = ""
            Me.TextBox3.Text = ""
        Catch ex As Exception
            MsgBox(" لايمكن الحفظ ")
        End Try
    End Sub

    Private Sub Ejraa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sk2 As String
        sk2 = "select * from KESEM"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "KESEM")
        ComboBox3.DataSource = dsk2.Tables(0)
        ComboBox3.DisplayMember = "KESEM"
        ComboBox3.SelectedIndex = -1


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim B As String
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Dim sk21 As String
                sk21 = "select * from Ejraa where IDK=" & B
                Using adk21 As New SqlClient.SqlDataAdapter(sk21, cn)
                    Dim dsk21 As New DataSet
                    adk21.Fill(dsk21, "Ejraa")
                    ComboBox1.DataSource = dsk21.Tables(0)
                    ComboBox1.DisplayMember = "Ejraa"
                    ComboBox1.SelectedIndex = -1
                End Using
            End If
            rdG.Close()
            'end using
        End Using


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
       
    End Sub

    Private Sub ComboBox1_Validated(sender As Object, e As EventArgs) Handles ComboBox1.Validated
        Dim r1 As String = Replace(ComboBox1.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox1.Text = r3
    End Sub

    Private Sub ComboBox3_Validated(sender As Object, e As EventArgs) Handles ComboBox3.Validated
        Dim r1 As String = Replace(ComboBox3.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox3.Text = r3
    End Sub
End Class