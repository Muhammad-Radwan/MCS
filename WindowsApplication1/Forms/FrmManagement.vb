Public Class FrmManagement

    'Private Sub EDARA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    If Button1.Visible = False Then
    '        If MENUEX = 1 Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(ADMIN_G_NO) FROM ADMIN_G "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from ADMIN_G where ADMIN_G_NO=@ADMIN_G_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@ADMIN_G_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('ADMIN_G', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(ADMIN_G_NO) FROM ADMIN_G "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        ElseIf MENUEX = 2 Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(Section_NO) FROM Section "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from Section where Section_NO=@Section_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@Section_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Section', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(Section_NO) FROM Section "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        ElseIf MENUEX = 3 Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(PLACE_WORK_NO) FROM PLACE_WORK "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from PLACE_WORK where PLACE_WORK_NO=@PLACE_WORK_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@PLACE_WORK_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PLACE_WORK', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(PLACE_WORK_NO) FROM PLACE_WORK "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        ElseIf MENUEX = 4 Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(FUNICTION_NO) FROM FUNICTION "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from FUNICTION where FUNICTION_NO=@FUNICTION_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@FUNICTION_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('FUNICTION', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(FUNICTION_NO) FROM FUNICTION "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        ElseIf MENUEX = 5 Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(Branch_NO) FROM Branch "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from Branch where Branch_NO=@Branch_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@Branch_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Branch', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(Branch_NO) FROM Branch "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        ElseIf MENUEX = 6 Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(Unit_NO) FROM Unit "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from Unit where Unit_NO=@Unit_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@Unit_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Unit', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(Unit_NO) FROM Unit "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        ElseIf MENUEX = 7 Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(Scars_NO) FROM Scars "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from Scars where Scars_NO=@Scars_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@Scars_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Scars', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(Scars_NO) FROM Scars "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try


    '        End If
    '    End If

    'End Sub

    Private Sub EDARA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MENUEX = 1 Then
            Me.Text = "المرحلة الدراسية"
            GroupBox1.Text = "المرحلة الدراسية"
            Call Class1.CONNIC()
            Dim sk1 As String
            sk1 = "select * from MAR "
            Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
            Dim dsk1 As New DataSet
            adk1.Fill(dsk1, "MAR")
            ComboBox1.DataSource = dsk1.Tables(0)
            ComboBox1.DisplayMember = "MAR"
            ComboBox1.SelectedIndex = -1
            Label1.Text = CInt(0)
        ElseIf MENUEX = 2 Then
            Me.Text = "السنة الدراسية"
            GroupBox1.Text = "السنة الدراسية"
            Call Class1.CONNIC()
            Dim sk1 As String
            sk1 = "select * from SAN WHERE MAR='" & fnumberx & "'"
            Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
            Dim dsk1 As New DataSet
            adk1.Fill(dsk1, "SAN")
            ComboBox1.DataSource = dsk1.Tables(0)
            ComboBox1.DisplayMember = "SAN"
            ComboBox1.SelectedIndex = -1
            Label1.Text = CInt(0)
        ElseIf MENUEX = 3 Then
            Me.Text = "اسم المصرف"
            GroupBox1.Text = "اسم المصرف"
            Call Class1.CONNIC()
            Dim sk1 As String
            sk1 = "select * from MASRAFNAME "
            Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
            Dim dsk1 As New DataSet
            adk1.Fill(dsk1, "MASRAFNAME")
            ComboBox1.DataSource = dsk1.Tables(0)
            ComboBox1.DisplayMember = "MASRAFNAME"
            ComboBox1.SelectedIndex = -1
            Label1.Text = CInt(0)
        ElseIf MENUEX = 4 Then
            Me.Text = "اسم السائق"
            GroupBox1.Text = "اسم السائق"
            Call Class1.CONNIC()
            Dim sk1 As String
            sk1 = "select * from SAENAME "
            Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
            Dim dsk1 As New DataSet
            adk1.Fill(dsk1, "SAENAME")
            ComboBox1.DataSource = dsk1.Tables(0)
            ComboBox1.DisplayMember = "SAENAME"
            ComboBox1.SelectedIndex = -1
            Label1.Text = CInt(0)
        ElseIf MENUEX = 5 Then
            Me.Text = "اسم الصارف"
            GroupBox1.Text = "اسم الصارف"
            Call Class1.CONNIC()
            Dim sk1 As String
            sk1 = "select * from SAREFNAME "
            Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
            Dim dsk1 As New DataSet
            adk1.Fill(dsk1, "SAREFNAME")
            ComboBox1.DataSource = dsk1.Tables(0)
            ComboBox1.DisplayMember = "SAREFNAME"
            ComboBox1.SelectedIndex = -1
            Label1.Text = CInt(0)
        End If
    End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    '    If MENUEX = 1 Then
    '        If Button1.Visible = False Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(ADMIN_G_NO) FROM ADMIN_G "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from ADMIN_G where ADMIN_G_NO=@ADMIN_G_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@ADMIN_G_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('ADMIN_G', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(ADMIN_G_NO) FROM ADMIN_G "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        End If
    '        Button1.Visible = True
    '        Call Class1.CONNIC()
    '        Dim sH As String = "select * from ADMIN_G where ADMIN_G=@ADMIN_G "
    '        Dim cmH As New SqlClient.SqlCommand(sH, cn)
    '        cmH.Parameters.AddWithValue("@ADMIN_G", Me.ComboBox1.Text)
    '        Dim rdH As SqlClient.SqlDataReader
    '        rdH = cmH.ExecuteReader
    '        If rdH.Read = True Then
    '            Label1.Text = rdH!ADMIN_G_NO
    '        Else
    '            Label1.Text = CInt(0)
    '        End If
    '        rdH.Close()
    '    ElseIf MENUEX = 2 Then
    '        If Button1.Visible = False Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(Section_NO) FROM Section "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from Section where Section_NO=@Section_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@Section_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Section', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(Section_NO) FROM Section "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        End If
    '        Button1.Visible = True
    '        Call Class1.CONNIC()
    '        Dim sH As String = "select * from Section where Section=@Section "
    '        Dim cmH As New SqlClient.SqlCommand(sH, cn)
    '        cmH.Parameters.AddWithValue("@Section", Me.ComboBox1.Text)
    '        Dim rdH As SqlClient.SqlDataReader
    '        rdH = cmH.ExecuteReader
    '        If rdH.Read = True Then
    '            Label1.Text = rdH!Section_NO
    '        Else
    '            Label1.Text = CInt(0)
    '        End If
    '        rdH.Close()
    '    ElseIf MENUEX = 3 Then
    '        If Button1.Visible = False Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(PLACE_WORK_NO) FROM PLACE_WORK "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from PLACE_WORK where PLACE_WORK_NO=@PLACE_WORK_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@PLACE_WORK_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PLACE_WORK', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(PLACE_WORK_NO) FROM PLACE_WORK "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        End If
    '        Button1.Visible = True
    '        Call Class1.CONNIC()
    '        Dim sH As String = "select * from PLACE_WORK where PLACE_WORK=@PLACE_WORK "
    '        Dim cmH As New SqlClient.SqlCommand(sH, cn)
    '        cmH.Parameters.AddWithValue("@PLACE_WORK", Me.ComboBox1.Text)
    '        Dim rdH As SqlClient.SqlDataReader
    '        rdH = cmH.ExecuteReader
    '        If rdH.Read = True Then
    '            Label1.Text = rdH!PLACE_WORK_NO
    '        Else
    '            Label1.Text = CInt(0)
    '        End If
    '        rdH.Close()
    '    ElseIf MENUEX = 4 Then
    '        If Button1.Visible = False Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(FUNICTION_NO) FROM FUNICTION "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from FUNICTION where FUNICTION_NO=@FUNICTION_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@FUNICTION_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('FUNICTION', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(FUNICTION_NO) FROM FUNICTION "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        End If
    '        Button1.Visible = True
    '        Call Class1.CONNIC()
    '        Dim sH As String = "select * from FUNICTION where FUNICTION=@FUNICTION "
    '        Dim cmH As New SqlClient.SqlCommand(sH, cn)
    '        cmH.Parameters.AddWithValue("@FUNICTION", Me.ComboBox1.Text)
    '        Dim rdH As SqlClient.SqlDataReader
    '        rdH = cmH.ExecuteReader
    '        If rdH.Read = True Then
    '            Label1.Text = rdH!FUNICTION_NO
    '        Else
    '            Label1.Text = CInt(0)
    '        End If
    '        rdH.Close()
    '    ElseIf MENUEX = 5 Then
    '        If Button1.Visible = False Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(Branch_NO) FROM Branch "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from Branch where Branch_NO=@Branch_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@Branch_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Branch', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '                'End If
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(Branch_NO) FROM Branch "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        End If
    '        Button1.Visible = True
    '        Call Class1.CONNIC()
    '        Dim sH As String = "select * from Branch where Branch=@Branch "
    '        Dim cmH As New SqlClient.SqlCommand(sH, cn)
    '        cmH.Parameters.AddWithValue("@Branch", Me.ComboBox1.Text)
    '        Dim rdH As SqlClient.SqlDataReader
    '        rdH = cmH.ExecuteReader
    '        If rdH.Read = True Then
    '            Label1.Text = rdH!Branch_NO
    '        Else
    '            Label1.Text = CInt(0)
    '        End If
    '        rdH.Close()
    '    ElseIf MENUEX = 6 Then
    '        If Button1.Visible = False Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(Unit_NO) FROM Unit "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from Unit where Unit_NO=@Unit_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@Unit_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Unit', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(Unit_NO) FROM Unit "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        End If
    '        Button1.Visible = True
    '        Call Class1.CONNIC()
    '        Dim sH As String = "select * from Unit where Unit=@Unit "
    '        Dim cmH As New SqlClient.SqlCommand(sH, cn)
    '        cmH.Parameters.AddWithValue("@Unit", Me.ComboBox1.Text)
    '        Dim rdH As SqlClient.SqlDataReader
    '        rdH = cmH.ExecuteReader
    '        If rdH.Read = True Then
    '            Label1.Text = rdH!Unit_NO
    '        Else
    '            Label1.Text = CInt(0)
    '        End If
    '        rdH.Close()

    '    ElseIf MENUEX = 7 Then
    '        If Button1.Visible = False Then
    '            Call Class1.CONNIC()
    '            Dim Str As String = "SELECT MAX(Scars_NO) FROM Scars "
    '            Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '            If IsDBNull(cmd.ExecuteScalar) = True Then
    '                fnumberx = 0
    '            Else
    '                fnumberx = cmd.ExecuteScalar
    '            End If
    '            Dim sd As String = "delete from Scars where Scars_NO=@Scars_NO"
    '            Using cd As New SqlClient.SqlCommand(sd, cn)
    '                cd.Parameters.AddWithValue("@Scars_NO", fnumberx)
    '                Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Scars', RESEED," & fnumberx & ")", cn)
    '                Try
    '                    cd.ExecuteNonQuery()
    '                    cmk1.ExecuteNonQuery()
    '                Catch ex As Exception
    '                End Try
    '            End Using
    '            Dim Str1 As String = "SELECT MAX(Scars_NO) FROM Scars "
    '            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '            If IsDBNull(cmd1.ExecuteScalar) = True Then
    '                fnumberx = 1
    '            Else
    '                fnumberx = cmd1.ExecuteScalar + 1
    '            End If
    '            Try
    '                Call Class1.CONNIC()
    '                cn.Close()
    '            Catch ex As Exception

    '            End Try
    '        End If
    '        Button1.Visible = True
    '        Call Class1.CONNIC()
    '        Dim sH As String = "select * from Scars where Scars=@Scars "
    '        Dim cmH As New SqlClient.SqlCommand(sH, cn)
    '        cmH.Parameters.AddWithValue("@Scars", Me.ComboBox1.Text)
    '        Dim rdH As SqlClient.SqlDataReader
    '        rdH = cmH.ExecuteReader
    '        If rdH.Read = True Then
    '            Label1.Text = rdH!Scars_NO
    '        Else
    '            Label1.Text = CInt(0)
    '        End If
    '        rdH.Close()

    '    End If
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If MENUEX = 1 Then
    '        Call Class1.CONNIC()
    '        Dim s20 As String = "insert into DYANA(DYANA) values(@DYANA)"
    '        Dim cm20 As New SqlClient.SqlCommand(s20, cn)
    '        cm20.Parameters.AddWithValue("@DYANA", Me.ComboBox1.Text)
    '        cm20.ExecuteNonQuery()
    '        ComboBox1.Focus()
    '        Button1.Visible = False
    '    ElseIf MENUEX = 2 Then
    '        Call Class1.CONNIC()
    '        Dim Str As String = "SELECT MAX(Section_NO) FROM Section "
    '        Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '        If IsDBNull(cmd.ExecuteScalar) = True Then
    '            fnumberx = 0
    '        Else
    '            fnumberx = cmd.ExecuteScalar
    '        End If
    '        Using cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Section', RESEED," & fnumberx & ")", cn)
    '            Try
    '                cmk1.ExecuteNonQuery()
    '            Catch ex As Exception
    '            End Try
    '        End Using
    '        Dim s20 As String = "insert into Section(Section) values(@Section)"
    '        Dim cm20 As New SqlClient.SqlCommand(s20, cn)
    '        cm20.Parameters.AddWithValue("@Section", Me.ComboBox1.Text)
    '        cm20.ExecuteNonQuery()
    '        ComboBox1.Focus()
    '        Dim Str1 As String = "SELECT MAX(Section_NO) FROM Section "
    '        Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '        If IsDBNull(cmd1.ExecuteScalar) = True Then
    '            Label1.Text = CInt(1)
    '        Else
    '            Label1.Text = cmd1.ExecuteScalar
    '        End If
    '        Button1.Visible = False
    '    ElseIf MENUEX = 3 Then
    '        Call Class1.CONNIC()
    '        Dim Str As String = "SELECT MAX(PLACE_WORK_NO) FROM PLACE_WORK "
    '        Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '        If IsDBNull(cmd.ExecuteScalar) = True Then
    '            fnumberx = 0
    '        Else
    '            fnumberx = cmd.ExecuteScalar
    '        End If
    '        Using cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PLACE_WORK', RESEED," & fnumberx & ")", cn)
    '            Try
    '                cmk1.ExecuteNonQuery()
    '            Catch ex As Exception
    '            End Try
    '        End Using
    '        Dim s20 As String = "insert into PLACE_WORK(PLACE_WORK) values(@PLACE_WORK)"
    '        Dim cm20 As New SqlClient.SqlCommand(s20, cn)
    '        cm20.Parameters.AddWithValue("@PLACE_WORK", Me.ComboBox1.Text)
    '        cm20.ExecuteNonQuery()
    '        ComboBox1.Focus()
    '        Dim Str1 As String = "SELECT MAX(PLACE_WORK_NO) FROM PLACE_WORK "
    '        Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '        If IsDBNull(cmd1.ExecuteScalar) = True Then
    '            Label1.Text = CInt(1)
    '        Else
    '            Label1.Text = cmd1.ExecuteScalar
    '        End If
    '        Button1.Visible = False
    '    ElseIf MENUEX = 4 Then
    '        Call Class1.CONNIC()
    '        Dim Str As String = "SELECT MAX(FUNICTION_NO) FROM FUNICTION "
    '        Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '        If IsDBNull(cmd.ExecuteScalar) = True Then
    '            fnumberx = 0
    '        Else
    '            fnumberx = cmd.ExecuteScalar
    '        End If
    '        Using cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('FUNICTION', RESEED," & fnumberx & ")", cn)
    '            Try
    '                cmk1.ExecuteNonQuery()
    '            Catch ex As Exception
    '            End Try
    '        End Using
    '        Dim s20 As String = "insert into FUNICTION(FUNICTION) values(@FUNICTION)"
    '        Dim cm20 As New SqlClient.SqlCommand(s20, cn)
    '        cm20.Parameters.AddWithValue("@FUNICTION", Me.ComboBox1.Text)
    '        cm20.ExecuteNonQuery()
    '        ComboBox1.Focus()
    '        Dim Str1 As String = "SELECT MAX(FUNICTION_NO) FROM FUNICTION "
    '        Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '        If IsDBNull(cmd1.ExecuteScalar) = True Then
    '            Label1.Text = CInt(1)
    '        Else
    '            Label1.Text = cmd1.ExecuteScalar
    '        End If
    '        Button1.Visible = False
    '    ElseIf MENUEX = 5 Then
    '        Call Class1.CONNIC()
    '        Dim Str As String = "SELECT MAX(Branch_NO) FROM Branch "
    '        Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '        If IsDBNull(cmd.ExecuteScalar) = True Then
    '            fnumberx = 0
    '        Else
    '            fnumberx = cmd.ExecuteScalar
    '        End If
    '        Using cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Branch', RESEED," & fnumberx & ")", cn)
    '            Try
    '                cmk1.ExecuteNonQuery()
    '            Catch ex As Exception
    '            End Try
    '        End Using
    '        Dim s20 As String = "insert into Branch(Branch) values(@Branch)"
    '        Dim cm20 As New SqlClient.SqlCommand(s20, cn)
    '        cm20.Parameters.AddWithValue("@Branch", Me.ComboBox1.Text)
    '        cm20.ExecuteNonQuery()
    '        ComboBox1.Focus()
    '        Dim Str1 As String = "SELECT MAX(Branch_NO) FROM Branch "
    '        Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '        If IsDBNull(cmd1.ExecuteScalar) = True Then
    '            Label1.Text = CInt(1)
    '        Else
    '            Label1.Text = cmd1.ExecuteScalar
    '        End If
    '        Button1.Visible = False
    '    ElseIf MENUEX = 6 Then
    '        Call Class1.CONNIC()
    '        Dim Str As String = "SELECT MAX(Unit_NO) FROM Unit "
    '        Dim cmd As New SqlClient.SqlCommand(Str, cn)
    '        If IsDBNull(cmd.ExecuteScalar) = True Then
    '            fnumberx = 0
    '        Else
    '            fnumberx = cmd.ExecuteScalar
    '        End If
    '        Using cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Unit', RESEED," & fnumberx & ")", cn)
    '            Try
    '                cmk1.ExecuteNonQuery()
    '            Catch ex As Exception
    '            End Try
    '        End Using
    '        Dim s20 As String = "insert into Unit(Unit) values(@Unit)"
    '        Dim cm20 As New SqlClient.SqlCommand(s20, cn)
    '        cm20.Parameters.AddWithValue("@Unit", Me.ComboBox1.Text)
    '        cm20.ExecuteNonQuery()
    '        ComboBox1.Focus()
    '        Dim Str1 As String = "SELECT MAX(Unit_NO) FROM Unit "
    '        Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
    '        If IsDBNull(cmd1.ExecuteScalar) = True Then
    '            Label1.Text = CInt(1)
    '        Else
    '            Label1.Text = cmd1.ExecuteScalar
    '        End If
    '        Button1.Visible = False
    '    ElseIf MENUEX = 7 Then
    '        Call Class1.CONNIC()
    '        Dim s20 As String = "insert into GEN(GEN) values(@GEN)"
    '        Dim cm20 As New SqlClient.SqlCommand(s20, cn)
    '        cm20.Parameters.AddWithValue("@GEN", Me.ComboBox1.Text)
    '        cm20.ExecuteNonQuery()
    '        ComboBox1.Focus()
    '        Button1.Visible = False

    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) = False Then
            If Label1.Text = 0 Then
                If MENUEX = 1 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "INSERT INTO MAR(MAR) VALUES(@MAR)"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@MAR", Trim(Me.ComboBox1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        procedx = "إضافة المرحلة " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        MsgBox("تم الحفظ")
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from MAR "
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "MAR")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "MAR"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf MENUEX = 2 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "INSERT INTO SAN(MAR,SAN) VALUES(@MAR,@SAN)"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@MAR", CInt(fnumberx))
                    cm20.Parameters.AddWithValue("@SAN", Trim(Me.ComboBox1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        procedx = "إضافة السنة " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        MsgBox("تم الحفظ")
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from SAN "
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "SAN")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "SAN"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf MENUEX = 3 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "INSERT INTO MASRAFNAME(MASRAFNAME) VALUES(@MASRAFNAME)"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@MASRAFNAME", Trim(Me.ComboBox1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        procedx = "إضافة مصرف " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        MsgBox("تم الحفظ")
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from MASRAFNAME "
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "MASRAFNAME")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "SAN"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf MENUEX = 4 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "INSERT INTO SAENAME(SAENAME) VALUES(@SAENAME)"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@SAENAME", Trim(Me.ComboBox1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        procedx = "إضافة السائق " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        MsgBox("تم الحفظ")
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from SAENAME "
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "SAENAME")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "SAENAME"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf MENUEX = 5 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "INSERT INTO SAREFNAME(SAREFNAME) VALUES(@SAREFNAME)"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@SAREFNAME", Trim(Me.ComboBox1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        procedx = "إضافة اسم صارف " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        MsgBox("تم الحفظ")
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from SAREFNAME "
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "SAREFNAME")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "SAREFNAME"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                If MENUEX = 1 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "UPDATE MAR SET MAR=@MAR WHERE IDM=@IDM"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@MAR", Trim(Me.ComboBox1.Text))
                    cm20.Parameters.AddWithValue("@IDM", CInt(Me.Label1.Text))
                    'Call Class1.CONNIC()
                    'Dim s209 As String = "UPDATE main SET mader=@mader WHERE mader=@IDM"
                    'Dim cm209 As New SqlClient.SqlCommand(s209, cn)
                    'cm209.Parameters.AddWithValue("@mader", Trim(Me.ComboBox1.Text))
                    'cm209.Parameters.AddWithValue("@IDM", CInt(Me.Label1.Text))

                    Try
                        cm20.ExecuteNonQuery()
                        MsgBox("تم التعديل")
                        procedx = "تعديل المرحلة " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from MAR "
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "MAR")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "MAR"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf MENUEX = 2 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "UPDATE SAN SET SAN=@SAN WHERE IDS=@IDS"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@SAN", Trim(Me.ComboBox1.Text))
                    cm20.Parameters.AddWithValue("@IDS", CInt(Me.Label1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        procedx = "تعديل السنة " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        MsgBox("تم التعديل")
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from SAN "
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "SAN")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "SAN"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf MENUEX = 3 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "UPDATE SAN SET MASRAFNAME=@MASRAFNAME WHERE IDMASRAF=@IDMASRAF"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@MASRAFNAME", Trim(Me.ComboBox1.Text))
                    cm20.Parameters.AddWithValue("@IDMASRAF", CInt(Me.Label1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        MsgBox("تم التعديل")
                        procedx = "تعديل مصرف " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from MASRAFNAME"
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "MASRAFNAME")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "MASRAFNAME"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf MENUEX = 4 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "UPDATE SAN SET SAENAME=@SAENAME WHERE IDS=@IDS"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@SAENAME", Trim(Me.ComboBox1.Text))
                    cm20.Parameters.AddWithValue("@IDS", CInt(Me.Label1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        MsgBox("تم التعديل")
                        procedx = "تعديل اسم السائق " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from SAENAME"
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "SAENAME")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "SAENAME"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf MENUEX = 5 Then
                    Call Class1.CONNIC()
                    Dim s20 As String = "UPDATE SAREFNAME SET SAREFNAME=@SAREFNAME WHERE IDSAREF=@IDMASRAF"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@SAREFNAME", Trim(Me.ComboBox1.Text))
                    cm20.Parameters.AddWithValue("@IDMASRAF", CInt(Me.Label1.Text))
                    Try
                        cm20.ExecuteNonQuery()
                        MsgBox("تم التعديل")
                        procedx = "تعديل اسم صارف " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                        Button1.Visible = True
                        Label1.Text = CInt(0)
                        Call Class1.CONNIC()
                        Dim sk1 As String
                        sk1 = "select * from SAREFNAME"
                        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        Dim dsk1 As New DataSet
                        adk1.Fill(dsk1, "SAREFNAME")
                        ComboBox1.DataSource = dsk1.Tables(0)
                        ComboBox1.DisplayMember = "SAREFNAME"
                        ComboBox1.SelectedIndex = -1
                        Label1.Text = CInt(0)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MENUEX = 1 Then
            'If Label1.Text <> CInt(0) Then
            If MsgBox("هل تريد حذف المرحلة الدراسية ... سيتم حذف السنوات التابعة لها", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call Class1.CONNIC()
                Dim sd As String = "delete from SAN where MAR=@MAR"
                Using cd As New SqlClient.SqlCommand(sd, cn)
                    cd.Parameters.AddWithValue("@MAR", Label1.Text)
                    Dim sd0 As String = "delete from MAR where IDM=@IDM"
                    Using cd0 As New SqlClient.SqlCommand(sd0, cn)
                        cd0.Parameters.AddWithValue("@IDM", Label1.Text)
                        Try
                            cd.ExecuteNonQuery()
                            cd0.ExecuteNonQuery()
                            procedx = "حذف المرحلة " & " " & Trim(ComboBox1.Text)
                            Call Class1.proced()
                            MsgBox("تم الحذف")
                        Catch ex As Exception
                        End Try
                        'End If
                    End Using
                End Using
                Button1.Visible = True
                Call Class1.CONNIC()
                Dim sk1 As String
                sk1 = "select * from MAR"
                Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                Dim dsk1 As New DataSet
                adk1.Fill(dsk1, "MAR")
                ComboBox1.DataSource = dsk1.Tables(0)
                ComboBox1.DisplayMember = "MAR"
                ComboBox1.SelectedIndex = -1
                Label1.Text = CInt(0)
            Else
                MsgBox("تم إلغاء العملية")
            End If
            'End If
        ElseIf MENUEX = 2 Then
            If MsgBox("هل تريد حذف السنة الدراسية", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call Class1.CONNIC()
                Dim sd As String = "delete from SAN where IDS=@IDS"
                Using cd As New SqlClient.SqlCommand(sd, cn)
                    cd.Parameters.AddWithValue("@IDS", Label1.Text)
                    Try
                        cd.ExecuteNonQuery()
                        MsgBox("تم الحذف")
                        procedx = "حذف السنة " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                    Catch ex As Exception
                    End Try
                    'End If
                End Using
                Button1.Visible = True
                Call Class1.CONNIC()
                Dim sk1 As String
                sk1 = "select * from SAN WHERE IDS=" & CInt(Label1.Text)
                Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                Dim dsk1 As New DataSet
                adk1.Fill(dsk1, "SAN")
                ComboBox1.DataSource = dsk1.Tables(0)
                ComboBox1.DisplayMember = "SAN"
                ComboBox1.SelectedIndex = -1
                Label1.Text = CInt(0)
            Else
                MsgBox("تم إلغاء العملية")
            End If
        ElseIf MENUEX = 3 Then
            If MsgBox("هل تريد حذف المصرف", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call Class1.CONNIC()
                Dim sd As String = "delete from masrafname where IDmasraf=@IDS"
                Using cd As New SqlClient.SqlCommand(sd, cn)
                    cd.Parameters.AddWithValue("@IDS", Label1.Text)
                    Try
                        cd.ExecuteNonQuery()
                        MsgBox("تم الحذف")
                        procedx = "حذف مصرف " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                    Catch ex As Exception
                    End Try
                    'End If
                End Using
                Button1.Visible = True
                Call Class1.CONNIC()
                Dim sk1 As String
                sk1 = "select * from masrafname"
                Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                Dim dsk1 As New DataSet
                adk1.Fill(dsk1, "masrafname")
                ComboBox1.DataSource = dsk1.Tables(0)
                ComboBox1.DisplayMember = "masrafname"
                ComboBox1.SelectedIndex = -1
                Label1.Text = CInt(0)
            Else
                MsgBox("تم إلغاء العملية")
            End If
        ElseIf MENUEX = 4 Then
            If MsgBox("هل تريد حذف السائق", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call Class1.CONNIC()
                Dim sd As String = "delete from SAENAME where IDS=@IDS"
                Using cd As New SqlClient.SqlCommand(sd, cn)
                    cd.Parameters.AddWithValue("@IDS", Label1.Text)
                    Try
                        cd.ExecuteNonQuery()
                        MsgBox("تم الحذف")
                        procedx = "حذف السائق " & " " & Trim(ComboBox1.Text)
                        Call Class1.proced()
                    Catch ex As Exception
                    End Try
                    'End If
                End Using
                Button1.Visible = True
                Call Class1.CONNIC()
                Dim sk1 As String
                sk1 = "select * from SAENAME"
                Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                Dim dsk1 As New DataSet
                adk1.Fill(dsk1, "SAENAME")
                ComboBox1.DataSource = dsk1.Tables(0)
                ComboBox1.DisplayMember = "SAENAME"
                ComboBox1.SelectedIndex = -1
                Label1.Text = CInt(0)
            Else
                MsgBox("تم إلغاء العملية")
            End If
        ElseIf MENUEX = 5 Then
            If MsgBox("هل تريد حذف اسم الصارف", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call Class1.CONNIC()
                Dim sd As String = "delete from SAREFNAME where IDSAREF=@IDS"
                Using cd As New SqlClient.SqlCommand(sd, cn)
                    cd.Parameters.AddWithValue("@IDS", Label1.Text)
                    Try
                        Call Class1.CONNIC()
                        Dim sd5 As String = "SELECT * from LOSS where LOSSNA=@LOSSNA"
                        Using cd5 As New SqlClient.SqlCommand(sd5, cn)
                            cd5.Parameters.AddWithValue("@LOSSNA", Label1.Text)
                            Dim RDF As SqlClient.SqlDataReader = cd5.ExecuteReader
                            If RDF.Read = False Then
                                cd.ExecuteNonQuery()
                                MsgBox("تم الحذف")
                                procedx = "حذف اسم الصارف " & " " & Trim(ComboBox1.Text)
                                Call Class1.proced()
                            End If
                        End Using

                    Catch ex As Exception
                    End Try
                    'End If
                End Using
                Button1.Visible = True
                Call Class1.CONNIC()
                Dim sk1 As String
                sk1 = "select * from SAREFNAME"
                Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                Dim dsk1 As New DataSet
                adk1.Fill(dsk1, "SAREFNAME")
                ComboBox1.DataSource = dsk1.Tables(0)
                ComboBox1.DisplayMember = "SAREFNAME"
                ComboBox1.SelectedIndex = -1
                Label1.Text = CInt(0)
            Else
                MsgBox("تم إلغاء العملية")
            End If

        End If
    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus
        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            If Lng.Culture.DisplayName.ToUpper.StartsWith("AR") Then
                InputLanguage.CurrentInputLanguage = Lng
                Exit For
            End If
        Next
    End Sub

    Private Sub ComboBox1_Validated(sender As Object, e As EventArgs) Handles ComboBox1.Validated
        Call TXTEMLA.TXTEMLA(ComboBox1.Text)
        ComboBox1.Text = RTXT
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If MENUEX = 1 Then
            Call Class1.CONNIC()
            Dim sH As String = "select * from MAR where MAR=@xx1 "
            Dim cmH As New SqlClient.SqlCommand(sH, cn)
            cmH.Parameters.AddWithValue("@xx1", Me.ComboBox1.Text)
            Dim rdH As SqlClient.SqlDataReader
            rdH = cmH.ExecuteReader
            If rdH.Read = True Then
                Me.Label1.Text = CInt(rdH!IDM)
                TextBox1.Text = Trim(ComboBox1.Text)
            Else
                Me.Label1.Text = 0
            End If
        ElseIf MENUEX = 2 Then
            Call Class1.CONNIC()
            Dim sH As String = "select * from SAN where SAN=@xx1 and mar=" & fnumberx
            Dim cmH As New SqlClient.SqlCommand(sH, cn)
            cmH.Parameters.AddWithValue("@xx1", Me.ComboBox1.Text)
            Dim rdH As SqlClient.SqlDataReader
            rdH = cmH.ExecuteReader
            If rdH.Read = True Then
                Me.Label1.Text = CInt(rdH!IDS)
            Else
                Me.Label1.Text = 0
            End If
        ElseIf MENUEX = 3 Then
            Call Class1.CONNIC()
            Dim sH As String = "select * from MASRAFNAME where MASRAFNAME=@xx1 "
            Dim cmH As New SqlClient.SqlCommand(sH, cn)
            cmH.Parameters.AddWithValue("@xx1", Me.ComboBox1.Text)
            Dim rdH As SqlClient.SqlDataReader
            rdH = cmH.ExecuteReader
            If rdH.Read = True Then
                Me.Label1.Text = CInt(rdH!IDmasraf)
            Else
                Me.Label1.Text = 0
            End If
        ElseIf MENUEX = 4 Then
            Call Class1.CONNIC()
            Dim sH As String = "select * from SAENAME where SAENAME=@xx1 "
            Dim cmH As New SqlClient.SqlCommand(sH, cn)
            cmH.Parameters.AddWithValue("@xx1", Me.ComboBox1.Text)
            Dim rdH As SqlClient.SqlDataReader
            rdH = cmH.ExecuteReader
            If rdH.Read = True Then
                Me.Label1.Text = CInt(rdH!IDSA)
            Else
                Me.Label1.Text = 0
            End If
        ElseIf MENUEX = 5 Then
            Call Class1.CONNIC()
            Dim sH As String = "select * from SAREFNAME where SAREFNAME=@xx1 "
            Dim cmH As New SqlClient.SqlCommand(sH, cn)
            cmH.Parameters.AddWithValue("@xx1", Me.ComboBox1.Text)
            Dim rdH As SqlClient.SqlDataReader
            rdH = cmH.ExecuteReader
            If rdH.Read = True Then
                Me.Label1.Text = CInt(rdH!IDSAREF)
            Else
                Me.Label1.Text = 0
            End If
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If String.IsNullOrWhiteSpace(ComboBox1.Text) Then
            Label1.Text = CInt(0)
        End If
    End Sub
End Class