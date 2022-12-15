Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Public Class Form22

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        OpenFileDialog1.Filter = "Images|*.BMP;*.GIF;*.TIF;*.JPG"
        OpenFileDialog1.ShowDialog()
        Try
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Me.PictureBox1.Enabled = True
        Catch ex As Exception
            MsgBox("Ì—ÃÏ «Œ Ì«— „·› «··ÊÕ… «·„—«œ Õ›ŸÂ«")
        End Try
        pinm = (System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName) + (TextBox1.Text))
        TextBox2.Text = pinm
        Me.PictureBox28.Enabled = True
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        Dim k As Bitmap = PictureBox1.Image
        k.Save(Application.StartupPath & "\pic\" & pinm & ".bmp")
        Dim fs As FileStream
        Dim br As BinaryReader
        Dim ggg As String
        ggg = TextBox2.Text
        fs = New FileStream(Application.StartupPath & "\pic\" & TextBox2.Text & ".bmp", FileMode.Open)
        'fs = New FileStream(Application.StartupPath & "pic\" & ggg &, FileMode.Open)
        br = New BinaryReader(fs)
        Dim imgbyte(fs.Length) As Byte
        imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)))
        If Me.ComboBox1.Text = "" Then
            Me.ComboBox1.Text = "Non"
        End If
        Dim ss As String = "insert into DOCUMENT(FNUMBER,ANALYSIS,XRAY,PHOTOGRAPH,MXPORTS,PATHPIC,IMG,DATED,notex,others)VALUES(@FNUMBER,@ANALYSIS,@XRAY,@PHOTOGRAPH,@MXPORTS,@PATHPIC,@IMG,@DATED,@notex,@others)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("@FNUMBER", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("@ANALYSIS", Me.CheckBox1.Checked)
        cmm.Parameters.AddWithValue("@XRAY", Me.CheckBox2.Checked)
        cmm.Parameters.AddWithValue("@PHOTOGRAPH", Me.CheckBox3.Checked)
        cmm.Parameters.AddWithValue("@MXPORTS", Me.CheckBox4.Checked)
        cmm.Parameters.AddWithValue("@PATHPIC", Me.TextBox2.Text)
        cmm.Parameters.AddWithValue("@IMG", imgbyte)
        cmm.Parameters.AddWithValue("@DATED", Date.Today)
        cmm.Parameters.AddWithValue("@notex", Me.ComboBox1.Text)
        cmm.Parameters.AddWithValue("@others", Me.CheckBox5.Checked)

        Try
            cmm.ExecuteNonQuery()
            MsgBox(" „ «·Õ›Ÿ ")
        Catch ex As Exception
            MsgBox(" ·«Ì„ﬂ‰ «·Õ›Ÿ ")
        End Try
    End Sub

    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        'Select Case e.ColumnIndex
        '    Case 0
        '        dgxx = Val(Me.DataGridView5.CurrentCell.Value.ToString)
        '        If dgxx <> 0 Then
        '            dgx = dgxx
        '        End If
        '        TextBox12.Text = dgx
        '        Dim ss As String = "select * from document where id=@id"
        '        Dim cmmmm As New SqlClient.SqlCommand(ss, cn)
        '        cmmmm.Parameters.AddWithValue("@id", TextBox12.Text)
        '        Dim rd As SqlClient.SqlDataReader = cmmmm.ExecuteReader
        '        If rd.Read = True Then
        '            Me.TextBox17.Text = rd!pathpic
        '        End If
        '        Try
        '            pinm = Me.TextBox17.Text

        '            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic\" & pinm & ".bmp")
        '            Me.ComboBox1.Text = rd!notex
        '        Catch ex As Exception

        '        End Try


        'End Select
    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = dgx
        Dim s As String = "select * from main where fnumber=@xxx"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@xxx", Me.TextBox1.Text)
        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        If rd.Read = True Then
            Me.ComboBox4.Text = rd!namex
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND ANALYSIS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox1.Checked = True
            End If

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked = True Then
            Dim sdX As String = "select * from DOCUMENT "
            Dim aaddX As New SqlClient.SqlDataAdapter(sdX, cn)
            Dim dssdX As New DataSet
            dssdX.Clear()
            aaddX.Fill(dssdX, "DOCUMENT")
            Dim vddX As New DataView(dssdX.Tables("DOCUMENT"))
            vddX.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND XRAY=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddX

            Me.CheckBox1.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox2.Checked = True
            End If
            ' Me.CheckBox1.Checked = True
        End If


    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If Me.CheckBox3.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND PHOTOGRAPH=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox3.Checked = True
            End If
            'Me.CheckBox1.Checked = True
        End If


    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If Me.CheckBox4.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND MXPORTS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox5.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox4.Checked = True
            End If
            'Me.CheckBox1.Checked = True

        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If Me.CheckBox5.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND others=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox5.Checked = True
            End If
        End If


    End Sub

    Private Sub DataGridView5_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView5.CellMouseDown

       Select e.ColumnIndex
            Case Is >= 0
                Select Case e.RowIndex
                    Case Is >= 0
                        dgxx = Me.DataGridView5.Item(0, e.RowIndex).Value.ToString
                        If dgxx <> 0 Then
                            dgx = dgxx
                        End If
                        TextBox12.Text = dgx
                        Dim ss As String = "select * from document where id=@id"
                        Dim cmmmm As New SqlClient.SqlCommand(ss, cn)
                        cmmmm.Parameters.AddWithValue("@id", TextBox12.Text)
                        Dim rd As SqlClient.SqlDataReader = cmmmm.ExecuteReader
                        If rd.Read = True Then
                            Me.TextBox17.Text = rd!pathpic
                        End If
                        Try
                            pinm = Me.TextBox17.Text

                            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic\" & pinm & ".bmp")
                            Me.ComboBox1.Text = rd!notex
                        Catch ex As Exception

                        End Try


                End Select
        End Select

    End Sub

    Private Sub DataGridView5_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.RowValidated
        Select Case num
            Case Is >= 0
                dgxx = Me.DataGridView5.Item(0, num).Value.ToString
                If dgxx <> 0 Then
                    dgx = dgxx
                End If
                TextBox12.Text = dgx
                Dim ss As String = "select * from document where id=@id"
                Dim cmmmm As New SqlClient.SqlCommand(ss, cn)
                cmmmm.Parameters.AddWithValue("@id", TextBox12.Text)
                Dim rd As SqlClient.SqlDataReader = cmmmm.ExecuteReader
                If rd.Read = True Then
                    Me.TextBox17.Text = rd!pathpic
                End If
                Try
                    pinm = Me.TextBox17.Text

                    PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic\" & pinm & ".bmp")
                    Me.ComboBox1.Text = rd!notex
                Catch ex As Exception

                End Try


        End Select

    End Sub

    Private Sub DataGridView5_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView5.RowValidating
        Select Case num
            Case Is >= 0
                dgxx = Me.DataGridView5.Item(0, num).Value.ToString
                If dgxx <> 0 Then
                    dgx = dgxx
                End If
                TextBox12.Text = dgx
                Dim ss As String = "select * from document where id=@id"
                Dim cmmmm As New SqlClient.SqlCommand(ss, cn)
                cmmmm.Parameters.AddWithValue("@id", TextBox12.Text)
                Dim rd As SqlClient.SqlDataReader = cmmmm.ExecuteReader
                If rd.Read = True Then
                    Me.TextBox17.Text = rd!pathpic
                End If
                Try
                    pinm = Me.TextBox17.Text

                    PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic\" & pinm & ".bmp")
                    Me.ComboBox1.Text = rd!notex
                Catch ex As Exception

                End Try


        End Select

    End Sub

    Private Sub DataGridView5_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView5.SelectionChanged
       
        'Select Case num
        '    Case Is >= 0
        '        dgxx = Me.DataGridView5.Item(0, num).Value.ToString
        '        If dgxx <> 0 Then
        '            dgx = dgxx
        '        End If
        '        TextBox12.Text = dgx
        '        Dim ss As String = "select * from document where id=@id"
        '        Dim cmmmm As New SqlClient.SqlCommand(ss, cn)
        '        cmmmm.Parameters.AddWithValue("@id", TextBox12.Text)
        '        Dim rd As SqlClient.SqlDataReader = cmmmm.ExecuteReader
        '        If rd.Read = True Then
        '            Me.TextBox17.Text = rd!pathpic
        '        End If
        '        Try
        '            pinm = Me.TextBox17.Text

        '            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic\" & pinm & ".bmp")
        '            Me.ComboBox1.Text = rd!notex
        '        Catch ex As Exception

        '        End Try


        'End Select


    End Sub
End Class