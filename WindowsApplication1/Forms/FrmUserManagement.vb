Public Class FrmUserManagement
    Inherits System.Windows.Forms.Form
    Dim found As Boolean
    Sub confirm()
        Call Class1.CONNIC()
        Dim s As String = "select * from users where user_name=@x1"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@x1", ComboBox1.Text)
        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        If rd.Read = True Then
            found = True
        Else
            found = False
        End If
        rd.Close()
        Call Class4.CONNIC()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("يرجى إدخال اسم المستخدم", MsgBoxStyle.Information)
            ComboBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("يرجى إدخال كلمة المرور", MsgBoxStyle.Information)
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MsgBox("يرجى إدخال تأكيد كلمة المرور", MsgBoxStyle.Information)
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox3.Text <> TextBox2.Text Then
            MsgBox("كلمة المرور غير متطابقة", MsgBoxStyle.Information)
            TextBox3.Clear()
            TextBox3.Focus()
            Exit Sub
        End If
        confirm()
        If found = True Then
            MsgBox("هذا المستخدم موجود مسبقاً", MsgBoxStyle.Information)
            Exit Sub
        End If
        If RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButton4.Checked = True Or RadioButton5.Checked = True Then
            Call Class1.CONNIC()
            Dim s As String = "insert into users (user_name,user_pass,USER_TYPE,t1,t2,t3,t4,t5,t6,t7,t8,T9,T10,T11,T12,T13,T14)values (@user_name,@user_pass,@USER_TYPE,@t1,@t2,@t3,@t4,@t5,@t6,@t7,@t8,@T9,@T10,@T11,@T12,@T13,@T14)"
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@user_name", ComboBox1.Text) 'ÇÓã ÇáãÓÊÎÏã
            cm.Parameters.AddWithValue("@user_pass", TextBox2.Text)  'ßáãÉ ÇáãÑæÑ
            cm.Parameters.AddWithValue("@USER_TYPE", Me.Label4.Text)  'ßáãÉ ÇáãÑæÑ
            cm.Parameters.AddWithValue("@t1", CheckBox1.Checked) 'ÇáÇÖÇÝå
            cm.Parameters.AddWithValue("@t2", CheckBox2.Checked) 'ÇáÍÐÝ
            cm.Parameters.AddWithValue("@t3", CheckBox3.Checked) 'ÇáãÌãæÚÇÊ
            cm.Parameters.AddWithValue("@t4", CheckBox4.Checked) 'ÇáäÓÎ ÇáÇÍÊíÇØí
            cm.Parameters.AddWithValue("@t5", CheckBox5.Checked) 'ÇáÊÞÇÑíÑ æÇáÇÓÊÝÓÇÑÇÊ
            cm.Parameters.AddWithValue("@t6", CheckBox6.Checked) 'ÇáãÓÊÎÏãíä
            cm.Parameters.AddWithValue("@t7", CheckBox7.Checked) 'ÇÓÊÑÌÇÚ ÇáÈíÇäÇÊ
            cm.Parameters.AddWithValue("@t8", CheckBox8.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
            cm.Parameters.AddWithValue("@t9", CheckBox9.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
            cm.Parameters.AddWithValue("@t10", CheckBox10.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
            cm.Parameters.AddWithValue("@t11", CheckBox11.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
            cm.Parameters.AddWithValue("@t12", CheckBox12.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
            cm.Parameters.AddWithValue("@t13", CheckBox13.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
            cm.Parameters.AddWithValue("@t14", CheckBox14.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
            'If Label4.Text = 0 Then
            'cm.Parameters.AddWithValue("@T9", True) 'ÊÚÏíá ÇáÈíÇäÇÊ
            'Else
            'cm.Parameters.AddWithValue("@T9", False) 'ÊÚÏíá ÇáÈíÇäÇÊ
            'End If
            Try
                Call Class1.CONNIC()
                cm.ExecuteNonQuery()
                MsgBox("ÊãÊ ÅÏÎÇá ÈíÇäÇÊ ÇáãÓÊÎÏã", MsgBoxStyle.Information)
                If Me.RadioButton2.Checked = True Then
                    Dim s1 As String = "insert into dn(dn) values(@xxx1)"
                    Dim cm1 As New SqlClient.SqlCommand(s1, cn)
                    cm1.Parameters.AddWithValue("@xxx1", ComboBox1.Text) 'ÇÓã ÇáãÓÊÎÏã
                    Try
                        cm1.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("NO NO NO")
                    End Try
                End If
                Dim ds As String
                ds = "select * from users WHERE ID<>'" & 0 & "' "
                Dim ad7 As New SqlClient.SqlDataAdapter(ds, cn)
                Dim ds7 As New DataSet
                ad7.Fill(ds7, "users")
                ComboBox1.DataSource = ds7.Tables(0)
                ComboBox1.DisplayMember = "user_name"
                ComboBox1.SelectedIndex = -1
                Me.ComboBox1.Text = ""
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                RadioButton4.Checked = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'clear()
        Else
            MsgBox("ÃÑÌæ ÇÎÊíÇÑ ÕáÇÍíÉ ÇáãÓÊÎÏã")
        End If
    End Sub

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Class1.CONNIC()
        Dim ds As String
        ds = "select * from users WHERE ID<>'" & 0 & "' "
        Dim ad7 As New SqlClient.SqlDataAdapter(ds, cn)
        Dim ds7 As New DataSet
        ad7.Fill(ds7, "users")
        ComboBox1.DataSource = ds7.Tables(0)
        ComboBox1.DisplayMember = "user_name"
        ComboBox1.SelectedIndex = -1
        Me.ComboBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        RadioButton4.Checked = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Then
            MsgBox("ÇÏÎá ÇÓã ÇáãÓÊÎÏã", MsgBoxStyle.Information)
            ComboBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("ÇÏÎá ßáãÉ ÇáãÑæÑ", MsgBoxStyle.Information, My.Resources.warning)
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MsgBox("ÇÏÎá ÊÃßíÏ ßáãÉ ÇáãÑæÑ", MsgBoxStyle.Information)
            TextBox3.Focus()
            Exit Sub
        End If
        If TextBox3.Text <> TextBox2.Text Then
            MsgBox("ÚÏã ÊØÇÈÞ ßáãÉ ÇáãÑæÑ æ ÊÃßíÏ ßáãÉ ÇáãÑæÑ", MsgBoxStyle.Information)
            TextBox3.Clear()
            TextBox3.Focus()
            Exit Sub
        End If
        confirm()
        'If found = True Then
        '    MsgBox("ÇáãÓÊÎÏã ãæÌæÏ ãÓÈÞÇð", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        Call Class1.CONNIC()
        Dim s As String = "update users set user_name=@user_name,user_pass=@user_pass,USER_TYPE=@USER_TYPE,t1=@t1,t2=@t2,t3=@t3,t4=@t4,t5=@t5,t6=@t6,t7=@t7,t8=@t8,t9=@t9,t10=@t10,t11=@t11,t12=@t12,t13=@t13,t14=@t14 where ID=@ID"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@user_name", ComboBox1.Text) 'ÇÓã ÇáãÓÊÎÏã
        cm.Parameters.AddWithValue("@user_pass", TextBox2.Text)  'ßáãÉ ÇáãÑæÑ
        cm.Parameters.AddWithValue("@USER_TYPE", Me.Label4.Text)  'ßáãÉ ÇáãÑæÑ
        cm.Parameters.AddWithValue("@T1", CheckBox1.Checked) 'ÇáÇÖÇÝå
        cm.Parameters.AddWithValue("@T2", CheckBox2.Checked) 'ÇáÍÐÝ
        cm.Parameters.AddWithValue("@T3", CheckBox3.Checked) 'ÇáãÌãæÚÇÊ
        cm.Parameters.AddWithValue("@T4", CheckBox4.Checked) 'ÇáäÓÎ ÇáÇÍÊíÇØí
        cm.Parameters.AddWithValue("@T5", CheckBox5.Checked) 'ÇáÊÞÇÑíÑ æÇáÇÓÊÝÓÇÑÇÊ
        cm.Parameters.AddWithValue("@T6", CheckBox6.Checked) 'ÇáãÓÊÎÏãíä
        cm.Parameters.AddWithValue("@T7", CheckBox7.Checked) 'ÇÓÊÑÌÇÚ ÇáÈíÇäÇÊ
        cm.Parameters.AddWithValue("@T8", CheckBox8.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
        cm.Parameters.AddWithValue("@t9", CheckBox9.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
        cm.Parameters.AddWithValue("@t10", CheckBox10.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
        cm.Parameters.AddWithValue("@t11", CheckBox11.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
        cm.Parameters.AddWithValue("@t12", CheckBox12.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
        cm.Parameters.AddWithValue("@t13", CheckBox13.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
        cm.Parameters.AddWithValue("@t14", CheckBox14.Checked) 'ÊÚÏíá ÇáÈíÇäÇÊ
        cm.Parameters.AddWithValue("@ID", CInt(Label5.Text))

        Try
            Call Class1.CONNIC()
            cm.ExecuteNonQuery()
            MsgBox("Êã ÊÚÏíá ÈíÇäÇÊ ÇáãÓÊÎÏã", MsgBoxStyle.Information)
            Dim ds As String
            ds = "select * from users where id<>'" & 0 & "' "
            Dim ad7 As New SqlClient.SqlDataAdapter(ds, cn)
            Dim ds7 As New DataSet
            ad7.Fill(ds7, "users")
            ComboBox1.DataSource = ds7.Tables(0)
            ComboBox1.DisplayMember = "user_name"
            ComboBox1.SelectedIndex = -1
            Me.ComboBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.Text = "" Then
            MsgBox("ÇÏÎá ÇÓã ÇáãÓÊÎÏã", MsgBoxStyle.Information)
            ComboBox1.Focus()
            Exit Sub
        End If
        Call Class1.CONNIC()
        Dim s As String = "select * from users where user_name=@x1"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@x1", ComboBox1.Text)
        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        If rd.Read = True Then
            ComboBox1.Text = rd!user_name 'ÇÓã ÇáãÓÊÎÏã
            TextBox2.Text = rd!user_pass 'ßáãÉ ÇáãÑæÑ
            TextBox3.Text = rd!user_pass 'ÊÃßíÏ ßáãÉ ÇáãÑæÑ
            CheckBox1.Checked = rd!t1
            CheckBox2.Checked = rd!t2
            CheckBox3.Checked = rd!t3
            CheckBox4.Checked = rd!t4
            CheckBox5.Checked = rd!t5
            CheckBox6.Checked = rd!t6
            CheckBox7.Checked = rd!t7
            CheckBox8.Checked = rd!t8
            CheckBox9.Checked = rd!t9
            CheckBox10.Checked = rd!t10
            CheckBox11.Checked = rd!t11
            CheckBox12.Checked = rd!t12
            CheckBox13.Checked = rd!t13
            CheckBox14.Checked = rd!t14

        Else
            MsgBox("ÇáãÓÊÎÏã ÛíÑ ãæÌæÏ", MsgBoxStyle.Information)
        End If
        rd.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Class1.CONNIC()
        Dim del As String = "delete * from users where id=@xxx"
        Dim cm As New SqlClient.SqlCommand(del, cn)
        cm.Parameters.AddWithValue("@xxx", Me.Label5.Text)
        If MsgBox("Do you want to delete the user", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cm.ExecuteNonQuery()
            MsgBox("Deletion was successful")
            Dim ds As String
            ds = "select * from users WHERE ID<>'" & 0 & "' "
            Dim ad7 As New SqlClient.SqlDataAdapter(ds, cn)
            Dim ds7 As New DataSet
            ad7.Fill(ds7, "users")
            ComboBox1.DataSource = ds7.Tables(0)
            ComboBox1.DisplayMember = "user_name"
            ComboBox1.SelectedIndex = -1
            Me.ComboBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            RadioButton4.Checked = True
        End If

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox1.Text = "" Then
                MsgBox("ÃÏÎá ÇÓã ÇáãÓÊÎÏã")
                ComboBox1.Focus()
            Else
                TextBox2.Focus()
            End If
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim s As String = "select * from users where user_name=@x1"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@x1", ComboBox1.Text)
        Dim rd As SqlClient.SqlDataReader
        rd = cm.ExecuteReader
        If rd.Read = True Then
            Me.Label5.Text = rd!id
            ComboBox1.Text = rd!user_name 'ÇÓã ÇáãÓÊÎÏã
            TextBox2.Text = rd!user_pass 'ßáãÉ ÇáãÑæÑ
            TextBox3.Text = rd!user_pass 'ÊÃßíÏ ßáãÉ ÇáãÑæÑ
            Me.Label4.Text = rd!user_type
            If Me.Label4.Text = "1" Then
                Me.RadioButton1.Checked = True
            ElseIf Me.Label4.Text = "2" Then
                Me.RadioButton2.Checked = True
                'ElseIf Me.Label4.Text = "3" Then
                '    Me.RadioButton3.Checked = True
            ElseIf Me.Label4.Text = "0" Then
                Me.RadioButton4.Checked = True
            ElseIf Me.Label4.Text = "3" Then
                Me.RadioButton5.Checked = True
            End If
            CheckBox1.Checked = rd!t1
            CheckBox2.Checked = rd!t2
            CheckBox3.Checked = rd!t3
            CheckBox4.Checked = rd!t4
            CheckBox5.Checked = rd!t5
            CheckBox6.Checked = rd!t6
            CheckBox7.Checked = rd!t7
            CheckBox8.Checked = rd!t8
            CheckBox9.Checked = rd!t9
            CheckBox10.Checked = rd!t10
            CheckBox11.Checked = rd!t11
            CheckBox12.Checked = rd!t12
            CheckBox13.Checked = rd!t13
            CheckBox14.Checked = rd!t14
            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = True
        Else
            Button1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = False
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.Label4.Text = "1"
            Me.CheckBox1.Checked = True
            Me.CheckBox2.Checked = True
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
            Me.CheckBox6.Checked = False
            Me.CheckBox7.Checked = False
            Me.CheckBox8.Checked = False
            Me.CheckBox9.Checked = False
            Me.CheckBox10.Checked = False
            Me.CheckBox11.Checked = False
            Me.CheckBox12.Checked = False
            Me.CheckBox13.Checked = False
            Me.CheckBox14.Checked = False
            'Me.CheckBox1.Enabled = True
            'Me.CheckBox2.Enabled = True
            'Me.CheckBox3.Enabled = True
            'Me.CheckBox4.Enabled = True
            'Me.CheckBox5.Enabled = True
            'Me.CheckBox6.Enabled = True
            'Me.CheckBox7.Enabled = True
            'Me.CheckBox8.Enabled = True
            'Me.CheckBox9.Enabled = True
            'Me.CheckBox10.Enabled = True
            'Me.CheckBox11.Enabled = True
            'Me.CheckBox12.Enabled = True
            'Me.CheckBox13.Enabled = True
            'Me.CheckBox14.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            Me.Label4.Text = "2"
            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = True
            Me.CheckBox4.Checked = True
            Me.CheckBox5.Checked = True
            Me.CheckBox6.Checked = True
            Me.CheckBox7.Checked = True
            Me.CheckBox8.Checked = True
            Me.CheckBox9.Checked = True
            Me.CheckBox10.Checked = True
            Me.CheckBox11.Checked = False
            Me.CheckBox12.Checked = False
            Me.CheckBox13.Checked = False
            Me.CheckBox14.Checked = False
            'Me.CheckBox1.Enabled = True
            'Me.CheckBox2.Enabled = True
            'Me.CheckBox3.Enabled = True
            'Me.CheckBox4.Enabled = True
            'Me.CheckBox5.Enabled = True
            'Me.CheckBox6.Enabled = True
            'Me.CheckBox7.Enabled = True
            'Me.CheckBox8.Enabled = True
            'Me.CheckBox9.Enabled = True
            'Me.CheckBox10.Enabled = True
            'Me.CheckBox11.Enabled = True
            'Me.CheckBox12.Enabled = True
            'Me.CheckBox13.Enabled = True
            'Me.CheckBox14.Enabled = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If Me.RadioButton3.Checked = True Then
            Me.Label4.Text = "3"
            Me.CheckBox1.Checked = True
            Me.CheckBox2.Checked = True
            Me.CheckBox3.Checked = True
            Me.CheckBox4.Checked = True
            Me.CheckBox5.Checked = True
            Me.CheckBox6.Checked = True
            Me.CheckBox7.Checked = True
            Me.CheckBox8.Checked = True
            Me.CheckBox9.Checked = True
            Me.CheckBox10.Checked = True
            Me.CheckBox11.Checked = True
            Me.CheckBox12.Checked = True
            Me.CheckBox13.Checked = True
            Me.CheckBox14.Checked = True
            Me.CheckBox1.Enabled = True
            Me.CheckBox2.Enabled = True
            Me.CheckBox3.Enabled = True
            Me.CheckBox4.Enabled = True
            Me.CheckBox5.Enabled = True
            Me.CheckBox6.Enabled = True
            Me.CheckBox7.Enabled = True
            Me.CheckBox8.Enabled = True
            Me.CheckBox9.Enabled = True
            Me.CheckBox10.Enabled = True
            Me.CheckBox11.Enabled = True
            Me.CheckBox12.Enabled = True
            Me.CheckBox13.Enabled = True
            Me.CheckBox14.Enabled = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If Me.RadioButton4.Checked = True Then
            Me.Label4.Text = "0"
            Me.CheckBox1.Checked = True
            Me.CheckBox2.Checked = True
            Me.CheckBox3.Checked = True
            Me.CheckBox4.Checked = True
            Me.CheckBox5.Checked = True
            Me.CheckBox6.Checked = True
            Me.CheckBox7.Checked = True
            Me.CheckBox8.Checked = True
            Me.CheckBox9.Checked = True
            Me.CheckBox10.Checked = True
            Me.CheckBox11.Checked = True
            Me.CheckBox12.Checked = True
            Me.CheckBox13.Checked = True
            Me.CheckBox14.Checked = True
            'Me.CheckBox1.Enabled = False
            'Me.CheckBox2.Enabled = False
            'Me.CheckBox3.Enabled = False
            'Me.CheckBox4.Enabled = False
            'Me.CheckBox5.Enabled = False
            'Me.CheckBox6.Enabled = False
            'Me.CheckBox7.Enabled = False
            'Me.CheckBox8.Enabled = False
            'Me.CheckBox9.Enabled = False
            'Me.CheckBox10.Enabled = False
            'Me.CheckBox11.Enabled = False
            'Me.CheckBox12.Enabled = False
            'Me.CheckBox13.Enabled = False
            'Me.CheckBox14.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox2.Text = "" Then
                MsgBox("ÃÏÎá ßáãÉ ÇáãÑæÑ")
                TextBox2.Focus()
            Else
                TextBox3.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox3.Text = "" Then
                MsgBox("ÃÏÎá ßáãÉ ÇáãÑæÑ")
                TextBox3.Focus()
            Else
                If Button1.Enabled = True Then
                    Button1.Focus()
                Else
                    Button2.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If Me.RadioButton5.Checked = True Then
            Me.Label4.Text = "3"
            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = True
            Me.CheckBox4.Checked = True
            Me.CheckBox5.Checked = True
            Me.CheckBox6.Checked = False
            Me.CheckBox7.Checked = False
            Me.CheckBox8.Checked = True
            Me.CheckBox9.Checked = False
            Me.CheckBox10.Checked = False
            Me.CheckBox11.Checked = False
            Me.CheckBox12.Checked = False
            Me.CheckBox13.Checked = False
            Me.CheckBox14.Checked = False
            'Me.CheckBox1.Enabled = False
            'Me.CheckBox2.Enabled = False
            'Me.CheckBox3.Enabled = False
            'Me.CheckBox4.Enabled = False
            'Me.CheckBox5.Enabled = False
            'Me.CheckBox6.Enabled = False
            'Me.CheckBox7.Enabled = False
            'Me.CheckBox8.Enabled = False
            'Me.CheckBox9.Enabled = False
            'Me.CheckBox10.Enabled = False
            'Me.CheckBox11.Enabled = False
            'Me.CheckBox12.Enabled = False
            'Me.CheckBox13.Enabled = False
            'Me.CheckBox14.Enabled = False
        End If

    End Sub
End Class