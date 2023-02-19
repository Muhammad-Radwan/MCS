Public Class FrmPatientProfile

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim ss As String = "insert into main(namex,age,address,fnumber,husbend,phone,idcard,datex,city,genedr)values(xx1,xx2,xx3,xx4,xx5,xx6,xx7,xx8,xx9,xx10)"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim T As Boolean
        T = False
        Dim RegXsalm As Microsoft.Win32.RegistryKey
        RegXsalm = Microsoft.Win32.Registry.CurrentUser
        Dim SS As String() = RegXsalm.GetSubKeyNames
        For Each A As String In SS
            If A = "sal1" Then
                T = True
            End If
        Next
        If T = True Then
            RegXsalm = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("sal1", True)
            Dim x As Integer = RegXsalm.GetValue("val")
            x = x + 1
            RegXsalm.SetValue("val", x)
            TextBox1.Text = x
        Else
            RegXsalm = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("sal1")
            RegXsalm.SetValue("val", 1000)
        End If
    End Sub

    Private Sub TextBox1_KeyPress_1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.TextBox1.Text = "" Then
                Dim k As Integer = 1
                Do While k < 100
                    Dim i As Integer
                    i = Me.Label3.Text
                    Dim s As String = "select * from MAIN where fnumber=xx1 "
                    Dim cm As New SqlClient.SqlCommand(s, cn)
                    cm.Parameters.AddWithValue("xx1", i)
                    Dim rd As SqlClient.SqlDataReader
                    rd = cm.ExecuteReader
                    Do While rd.Read = True
                        i = i + 1
                        Dim ss As String = "select * from MAIN where fnumber=xx1 "
                        Dim cmm As New SqlClient.SqlCommand(ss, cn)
                        cmm.Parameters.AddWithValue("xx1", i)
                        rd = cmm.ExecuteReader
                        Me.Label3.Text = i
                    Loop
                    rd.Close()
                    k = k + 1
                Loop
                Me.TextBox1.Text = Me.Label3.Text
                Me.TextBox2.Focus()
                Me.Button3.Visible = True
                Me.Button6.Visible = False
            Else
                Dim s3 As String = "select * from main where fnumber=xx1"
                Dim cm3 As New SqlClient.SqlCommand(s3, cn)
                cm3.Parameters.AddWithValue("xx1", TextBox1.Text)
                Dim rd3 As SqlClient.SqlDataReader = cm3.ExecuteReader
                If rd3.Read = True Then
                    Me.TextBox2.Text = rd3!namex
                    Me.ComboBox1.Text = rd3!city
                    Me.TextBox3.Text = rd3!address
                    Me.TextBox8.Text = rd3!gender
                    Me.TextBox4.Text = rd3!husbend
                    Me.TextBox5.Text = rd3!age
                    Me.TextBox6.Text = rd3!phone
                    Me.TextBox7.Text = rd3!idcard
                    Me.DateTimePicker1.Text = rd3!datex
                    If TextBox8.Text = "male" Then
                        Me.RadioButton1.Checked = True
                    Else
                        Me.RadioButton2.Checked = True
                    End If
                End If
                Me.Button6.Visible = True
                Me.Button3.Visible = False
                Me.TextBox2.Focus()
            End If

        End If



        'Dim T As Boolean
        'T = False
        'Dim RegXsalm As Microsoft.Win32.RegistryKey
        'RegXsalm = Microsoft.Win32.Registry.CurrentUser
        'Dim SS As String() = RegXsalm.GetSubKeyNames
        'For Each A As String In SS
        '    If A = "sal1" Then
        '        T = True
        '    End If
        'Next
        'If T = True Then
        '    RegXsalm = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("sal1", True)
        '    Dim x As Integer = RegXsalm.GetValue("val")
        '    x = x + 1
        '    RegXsalm.SetValue("val", x)
        '    TextBox1.Text = x
        'Else
        '    RegXsalm = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("sal1")
        '    RegXsalm.SetValue("val", 1000)
        'End If
        'TextBox2.Focus()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If TextBox2.Text = "" Then
                MsgBox("Insert the Name")
                Me.TextBox2.Focus()
            Else
                ComboBox1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.ComboBox1.Text = "" Then
                Me.ComboBox1.Text = "Non"
            End If
            TextBox3.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If TextBox3.Text = "" Then
                Me.TextBox3.Text = "Non"
            End If
            Me.RadioButton1.Focus()

        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If TextBox5.Text = "" Then
                MsgBox("Insert the age")
                Me.TextBox5.Focus()
            Else
                TextBox6.Focus()
            End If

        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        Me.ComboBox1.Text = ""
        Me.TextBox1.Focus()
        Me.Button6.Visible = False
    End Sub

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.TextBox1.Text = "" Then
                Dim k As Integer = 1
                Do While k < 100
                    Dim i As Integer
                    i = Me.Label3.Text
                    Dim s As String = "select * from MAIN where fnumber=@xx1 "
                    Dim cm As New SqlClient.SqlCommand(s, cn)
                    cm.Parameters.AddWithValue("@xx1", i)
                    Dim rd As SqlClient.SqlDataReader
                    rd = cm.ExecuteReader
                    Do While rd.Read = True
                        i = i + 1
                        Dim ss As String = "select * from MAIN where fnumber=@xx1 "
                        Dim cmm As New SqlClient.SqlCommand(ss, cn)
                        cmm.Parameters.AddWithValue("@xx1", i)
                        rd = cmm.ExecuteReader
                        Me.Label3.Text = i
                    Loop
                    rd.Close()
                    k = k + 1
                Loop
                Me.TextBox1.Text = Me.Label3.Text
                Me.TextBox2.Focus()
                Me.Button3.Visible = True
                Me.Button6.Visible = False
            Else
                Dim s3 As String = "select * from main where fnumber=@xx1"
                Dim cm3 As New SqlClient.SqlCommand(s3, cn)
                cm3.Parameters.AddWithValue("@xx1", TextBox1.Text)
                Dim rd3 As SqlClient.SqlDataReader = cm3.ExecuteReader
                If rd3.Read = True Then
                    Me.TextBox2.Text = rd3!namex
                    Me.ComboBox1.Text = rd3!city
                    Me.TextBox3.Text = rd3!address
                    Me.TextBox8.Text = rd3!gender
                    Me.TextBox4.Text = rd3!husbend
                    Me.TextBox5.Text = rd3!age
                    Me.TextBox6.Text = rd3!phone
                    Me.TextBox7.Text = rd3!idcard
                    Me.DateTimePicker1.Text = rd3!datex
                    If TextBox8.Text = "male" Then
                        Me.RadioButton1.Checked = True
                    Else
                        Me.RadioButton2.Checked = True
                    End If
                End If
                Me.Button6.Visible = True
                Me.Button3.Visible = False
                Me.TextBox2.Focus()
            End If

        End If

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox2.Text = "" Then
                MsgBox("Insert the Name")
                Me.TextBox2.Focus()
            Else
                ComboBox1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.ComboBox1.Text = "" Then
                Me.ComboBox1.Text = "Non"
            End If
            TextBox3.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox3.Text = "" Then
                Me.TextBox3.Text = "Non"
            End If
            Me.RadioButton1.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub



    Private Sub RadioButton1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton1.KeyPress
        TextBox4.Focus()

    End Sub
    Private Sub RadioButton1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub RadioButton2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub



    Private Sub TextBox4_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox4.Text = "" Then
                If Me.GroupBox6.Text = "husband name" Then
                    MsgBox("Insert Husband Name")
                Else
                    MsgBox("Insert Wife Name")
                End If
            Else
                TextBox5.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox5.Text = "" Then
                MsgBox("Insert the age")
                Me.TextBox5.Focus()
            Else
                TextBox6.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox6.Text = "" Then
                Me.TextBox6.Text = "Non"
            End If
            TextBox7.Focus()
        End If
    End Sub

    Private Sub TextBox6_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub

    Private Sub TextBox7_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox7.Text = "" Then
                Me.TextBox7.Text = "Non"
            End If
            Me.DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub TextBox7_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub DateTimePicker1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.Button3.Visible = True Then
                Me.Button3.Focus()
            Else
                Me.Button6.Focus()
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ss As String = "insert into main(namex,age,address,husbend,phone,idcard,datex,CITY,gender)values(@xx1,@xx3,@xx4,@xx5,@xx6,@xx7,@xx8,@xx9,@gender)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("@xx1", TextBox2.Text)
        'cmm.Parameters.AddWithValue("@xx2", TextBox1.Text)
        cmm.Parameters.AddWithValue("@xx3", TextBox5.Text)
        cmm.Parameters.AddWithValue("@xx4", TextBox3.Text)
        cmm.Parameters.AddWithValue("@xx5", "NONE")
        cmm.Parameters.AddWithValue("@xx6", TextBox6.Text)
        cmm.Parameters.AddWithValue("@xx7", TextBox7.Text)
        cmm.Parameters.AddWithValue("@xx8", Date.Today.Date)
        cmm.Parameters.AddWithValue("@xx9", Me.ComboBox1.Text)
        cmm.Parameters.AddWithValue("@gender", TextBox8.Text)
        'Try
        cmm.ExecuteNonQuery()
        'Me.Button2.Visible = False

        MsgBox("file is create successful")
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        Me.ComboBox1.Text = ""
        Me.TextBox1.Focus()


        'Catch ex As Exception
        '    MsgBox("ERROR")
        'End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        vv1 = Me.TextBox1.Text
        Dim f As New FrmPatientInfoPrint
        f.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim s As String = "update  main set namex=@xx1,age=@xx2,address=@xx3,husbend=@xx4,phone=@xx5,idcard=@xx6,datex=@xx7,city=@xx8,gender=@xx9 where fnumber=@xxx"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@xx1", TextBox2.Text)
        cm.Parameters.AddWithValue("@xx2", TextBox5.Text)
        cm.Parameters.AddWithValue("@xx3", TextBox3.Text)
        cm.Parameters.AddWithValue("@xx4", TextBox4.Text)
        cm.Parameters.AddWithValue("@xx5", TextBox6.Text)
        cm.Parameters.AddWithValue("@xx6", TextBox7.Text)
        cm.Parameters.AddWithValue("@xx7", DateTimePicker1.Value.Date)
        cm.Parameters.AddWithValue("@xx8", ComboBox1.Text)
        cm.Parameters.AddWithValue("@xx9", TextBox8.Text)
        cm.Parameters.AddWithValue("@xxx", TextBox1.Text)
        Try
            cm.ExecuteNonQuery()
            MsgBox("ÊãÊ ÚãáíÉ ÇáÊÚÏíá")
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""
            Me.TextBox6.Text = ""
            Me.TextBox7.Text = ""
            Me.TextBox8.Text = ""
            Me.ComboBox1.Text = ""
            Me.TextBox1.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dgx = Me.TextBox1.Text
        Dim f As New FrmPatientDocs
        Hide()
        f.ShowDialog()
        Show()
    End Sub

    Private Sub RadioButton2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton2.KeyPress
        TextBox4.Focus()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox8.Text = "male"
        Me.GroupBox6.Text = "WIFE NAME"
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox8.Text = "female"
        Me.GroupBox6.Text = "HUSBAND NAME"
    End Sub
End Class