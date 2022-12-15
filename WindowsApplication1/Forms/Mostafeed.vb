Public Class Mostafeed

    Private Sub Mostafeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsbhDataSet8.Mostafeed' table. You can move, or remove it, as needed.
        'Me.MostafeedTableAdapter1.Fill(Me.DbsbhDataSet8.Mostafeed)
        'TODO: This line of code loads data into the 'DbsbhDataSet7.Mostafeed' table. You can move, or remove it, as needed.
        'Me.MostafeedTableAdapter.Fill(Me.DbsbhDataSet7.Mostafeed)
        Dim skk As String
        skk = "select * from mostafeed"
        Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
        Dim dskk As New DataSet
        adkk.Fill(dskk, "mostafeed")
        ComboBox1.DataSource = dskk.Tables(0)
        ComboBox1.DisplayMember = "namem"
        ComboBox1.SelectedIndex = -1
        Dim skkj As String
        skkj = "select * from jehat"
        Dim adkkj As New SqlClient.SqlDataAdapter(skkj, cn)
        Dim dskkj As New DataSet
        adkkj.Fill(dskkj, "jehat")
        ComboBox2.DataSource = dskkj.Tables(0)
        ComboBox2.DisplayMember = "jeham"
        ComboBox2.SelectedIndex = -1
        DataGridView1.DataSource = ""
        If Most = True Then
            ComboBox1.Text = dgx
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'If Asc(e.KeyChar) = Keys.Enter Then
        '    If Me.TextBox1.Text = "" Then
        '        Dim k As Integer = 1
        '        Do While k < 100
        '            Dim i As Integer
        '            i = 1
        '            m5 = i
        '            Dim s As String = "select * from Mostafeed where IDM=@xx1 "
        '            Dim cm As New SqlClient.SqlCommand(s, cn)
        '            cm.Parameters.AddWithValue("@xx1", i)
        '            Dim rd As SqlClient.SqlDataReader
        '            rd = cm.ExecuteReader
        '            Do While rd.Read = True
        '                i = i + 1
        '                Dim ss As String = "select * from Mostafeed where IDM=@xx1"
        '                Dim cmm As New SqlClient.SqlCommand(ss, cn)
        '                cmm.Parameters.AddWithValue("@xx1", i)

        '                rd = cmm.ExecuteReader
        '                m5 = i
        '            Loop
        '            rd.Close()
        '            k = k + 1
        '        Loop
        '        Me.TextBox1.Text = m5
        '        Me.ComboBox1.Focus()
        '    End If
        'End If
        If Asc(e.KeyChar) = Keys.Enter Then
            If Trim(TextBox1.Text) = Trim("") Then
                TextBox1.Text = "لايوجد"
            End If
            Button1.Focus()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox1.Text = "" Then
                MsgBox("يرجى ادخال اسم المستفيد")
            Else
                ComboBox2.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "" Then
            GroupBox3.Text = "اسم المستفيد"
            GroupBox3.ForeColor = Color.Black
        Else
            Dim r1 As String = Replace(ComboBox1.Text, "أ", "ا")
            Dim r2 As String = Replace(r1, "ى", "ي")
            Dim r3 As String = Replace(r2, "ة", "ه")
            Me.ComboBox1.Text = r3
            Dim s As String = "select * from Mostafeed where NAMEM=@NAMEM "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@NAMEM", Trim(ComboBox1.Text))
            Dim rd As SqlClient.SqlDataReader
            rd = cm.ExecuteReader
            If rd.Read = True Then
                Label1.Text = CInt(rd!IDM)
                GroupBox3.Text = "أنقر هنا لتعديل اسم المستفيد"
                GroupBox3.ForeColor = Color.Blue
                ComboBox2.Text = rd!JehaM
                TextBox1.Text = rd!mno
                Dim s1 As String = "select * from Mostafeed "
                Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "Mostafeed")
                Dim vd As New DataView(dss.Tables("Mostafeed"))
                vd.RowFilter = "JehaM=" & "'" & Me.ComboBox2.Text & "'" & ""
                Me.DataGridView1.DataMember = ""
                DataGridView1.DataSource = vd
            Else
                GroupBox3.Text = "اسم المستفيد"
                GroupBox3.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox2.Text = "" Then
                MsgBox("يرجى ادخال الجهة")
            Else
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim r1 As String = Replace(ComboBox2.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox2.Text = r3
        Dim s1 As String = "select * from Mostafeed "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "Mostafeed")
        Dim vd As New DataView(dss.Tables("Mostafeed"))
        vd.RowFilter = "JehaM=" & "'" & Me.ComboBox2.Text & "'" & ""
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = "select * from Mostafeed where NAMEM=@NAMEM "
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@NAMEM", Trim(ComboBox1.Text))
        Dim rd As SqlClient.SqlDataReader
        rd = cm.ExecuteReader
        If rd.Read = True Then
            Label1.Text = CInt(rd!IDM)
            Dim ss2 As String = "UPDATE Mostafeed SET NameM=@NameM,JehaM=@JehaM,MNO=@MNO,CNO=@CNO WHERE IDM=@IDM"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("@NameM", Trim(ComboBox1.Text))
            cmm2.Parameters.AddWithValue("@JehaM", Trim(ComboBox2.Text))
            cmm2.Parameters.AddWithValue("@MNO", TextBox1.Text)
            cmm2.Parameters.AddWithValue("@CNO", ComboBox2.Text)
            cmm2.Parameters.AddWithValue("@IDM", CInt(Label1.Text))
            Try
                cmm2.ExecuteNonQuery()
                MsgBox("تم التعديل ")
            Catch ex As Exception
            End Try
        Else
            Dim ss2 As String = "insert into Mostafeed(NameM,JehaM,MNO,CNO)VALUES(@NameM,@JehaM,@MNO,@CNO)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("@NameM", ComboBox1.Text)
            cmm2.Parameters.AddWithValue("@JehaM", ComboBox2.Text)
            cmm2.Parameters.AddWithValue("@MNO", TextBox1.Text)
            cmm2.Parameters.AddWithValue("@CNO", ComboBox2.Text)
            Try
                cmm2.ExecuteNonQuery()
                MsgBox("تم الحفظ ")
                'Me.MaskedTextBox1.Text = ""
                'Me.MaskedTextBox2.Text = ""
                'Me.MaskedTextBox3.Text = ""
                Me.DataGridView1.DataSource = ""
                ' Me.ComboBox2.Enabled = False
                Dim s1 As String = "select * from Mostafeed "
                Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "Mostafeed")
                Dim vd As New DataView(dss.Tables("Mostafeed"))
                vd.RowFilter = "JehaM=" & "'" & Me.ComboBox2.Text & "'" & ""
                Me.DataGridView1.DataMember = ""
                DataGridView1.DataSource = vd
                namemx = Trim(ComboBox1.Text)
                jehamx = Trim(ComboBox2.Text)
                Me.ComboBox1.Text = ""
                Me.ComboBox2.Text = ""
                Me.TextBox1.Text = ""
                Dim skk As String
                skk = "select * from mostafeed"
                Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
                Dim dskk As New DataSet
                adkk.Fill(dskk, "mostafeed")
                ComboBox1.DataSource = dskk.Tables(0)
                ComboBox1.DisplayMember = "namem"
                ComboBox1.SelectedIndex = -1
                Dim skkj As String
                skkj = "select * from jehat"
                Dim adkkj As New SqlClient.SqlDataAdapter(skkj, cn)
                Dim dskkj As New DataSet
                adkkj.Fill(dskkj, "jehat")
                ComboBox2.DataSource = dskkj.Tables(0)
                ComboBox2.DisplayMember = "jeham"
                ComboBox2.SelectedIndex = -1

            Catch ex As Exception
                MsgBox(" لايمكن الحفظ ")
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        dgx = DataGridView1.Item(0, e.RowIndex).Value
        Dim s As String = "select * from Mostafeed where idm=@idm "
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@idm", CInt(dgx))
        Dim rd As SqlClient.SqlDataReader
        rd = cm.ExecuteReader
        If rd.Read = True Then
            ComboBox2.Text = rd!jeham
            ComboBox1.Text = rd!namem
            TextBox1.Text = rd!mno
        End If
    End Sub

    Private Sub GroupBox3_Click(sender As Object, e As EventArgs) Handles GroupBox3.Click
        If GroupBox3.Text = "أنقر هنا لتعديل اسم المستفيد" Then
            dgxx = CInt(Label1.Text)
            Dim F As New TADEELM
            F.ShowDialog()
            Mostafeed_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "" Then
            GroupBox3.Text = "اسم المستفيد"
            GroupBox3.ForeColor = Color.Black
        Else
            Dim s As String = "select * from Mostafeed where NAMEM=@NAMEM "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@NAMEM", Trim(ComboBox1.Text))
            Dim rd As SqlClient.SqlDataReader
            rd = cm.ExecuteReader
            If rd.Read = True Then
                Label1.Text = CInt(rd!IDM)
                GroupBox3.Text = "أنقر هنا لتعديل اسم المستفيد"
                GroupBox3.ForeColor = Color.Blue
                ComboBox2.Text = rd!JehaM
                TextBox1.Text = rd!mno
                Dim s1 As String = "select * from Mostafeed "
                Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "Mostafeed")
                Dim vd As New DataView(dss.Tables("Mostafeed"))
                vd.RowFilter = "JehaM=" & "'" & Me.ComboBox2.Text & "'" & ""
                Me.DataGridView1.DataMember = ""
                DataGridView1.DataSource = vd
            Else
                GroupBox3.Text = "اسم المستفيد"
                GroupBox3.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        Dim s1 As String = "select * from Mostafeed "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "Mostafeed")
        Dim vd As New DataView(dss.Tables("Mostafeed"))
        vd.RowFilter = "JehaM=" & "'" & Me.ComboBox2.Text & "'" & ""
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd
    End Sub

    Private Sub ComboBox2_Validated(sender As Object, e As EventArgs) Handles ComboBox2.Validated
        Dim r1 As String = Replace(ComboBox2.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox2.Text = r3
    End Sub

    Private Sub ComboBox1_Validated(sender As Object, e As EventArgs) Handles ComboBox1.Validated
        Dim r1 As String = Replace(ComboBox1.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox1.Text = r3

    End Sub
End Class