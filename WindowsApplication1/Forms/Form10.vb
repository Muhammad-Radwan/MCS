Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Data
Imports System.Linq

Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form10
    Private Shared FormSimulator As Form10
    Private Shared InitializingSimulator As Boolean
    Friend KESEM_P As String
    Friend NAMEC As String
    Friend datexx1 As Date
    Friend datexx2 As Date
    Friend namexx As String
    Friend Ejno As String
    Friend phonex As String
    Friend kemaxxx As String
    Friend kemaxx As String
    Friend chnoxx As String
    Friend dateaxx As String
    Friend userxx As String
    Friend esalnox As String

    Public Shared Property Simulator() As Form10
        Get
            If FormSimulator Is Nothing OrElse FormSimulator.IsDisposed Then
                InitializingSimulator = True
                FormSimulator = New Form10
                InitializingSimulator = False
            End If
            Simulator = FormSimulator
        End Get
        Set(ByVal Value As Form10)
            FormSimulator = Value
        End Set
    End Property
    'Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: This line of code loads data into the 'DBASEDataSet.APPOINTMENT' table. You can move, or remove it, as needed.
    '    'Me.APPOINTMENTTableAdapter.Fill(Me.DBASEDataSet.APPOINTMENT)
    '    'Dim xdt As String

    '    'Dim s As String
    '    's = "select * from main_table"
    '    'Dim ad7 As New SqlClient.SqlDataAdapter(s, cn)
    '    'Dim ds7 As New DataSet
    '    'ad7.Fill(ds7, "main_table")
    '    'ComboBox1.DataSource = ds7.Tables(0)
    '    'ComboBox1.DisplayMember = "patname"
    '    'ComboBox1.SelectedIndex = -1
    '    'Me.ComboBox1.Focus()
    '    'Me.MaskedTextBox1.Text = Format(Now, "dd/MM/yyyy")
    '    'Me.MaskedTextBox2.Text = Format(Now, "HH:mm")
    '    'Me.MaskedTextBox3.Text = Format(Now, "HH:mm")

    'End Sub

    'Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        Dim s As String = "select * from main_table where patname=@xx1 "
    '        Dim cm As New SqlClient.SqlCommand(s, cn)
    '        cm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
    '        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
    '        If rd.Read = True Then
    '            Me.TextBox2.Text = rd!idpat
    '        End If

    '        Dim s1 As String = "select * from appointment "
    '        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
    '        Dim dss As New DataSet
    '        dss.Clear()
    '        aad.Fill(dss, "appointment")
    '        Dim vd As New DataView(dss.Tables("appointment"))
    '        vd.RowFilter = "IDPAT=" & "'" & TextBox2.Text & "'" & ""
    '        Me.DataGridView1.DataMember = ""
    '        DataGridView1.DataSource = vd
    '        Me.NumericUpDown1.Focus()
    '    End If
    'End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    'End Sub

    'Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged

    'End Sub
    'Private Sub MaskedTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        If Me.MaskedTextBox1.Text = "" Then
    '            Me.MaskedTextBox1.Text = Format(Now, "dd/MM/yyyy")
    '        End If
    '        Me.MaskedTextBox2.Focus()
    '    End If
    'End Sub

    'Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    'End Sub

    'Private Sub MaskedTextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MaskedTextBox2.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        Me.MaskedTextBox2.Text = Format(Now, "HH:mm")
    '        Me.MaskedTextBox3.Focus()

    '    End If
    'End Sub

    'Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    'End Sub

    'Private Sub MaskedTextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MaskedTextBox3.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        Me.MaskedTextBox3.Text = Format(Now, "HH:mm")

    '        Me.Button2.Focus()

    '    End If
    'End Sub

    'Private Sub MaskedTextBox3_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    '  Dim ss2 As String = "insert into appointment(IDPAT,chno,Datea,from,to)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5)"
    '    Dim ss2 As String = "insert into appointment(IDPAT,CHNO,DATEA,FROMA,TOA)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5)"
    '    Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
    '    cmm2.Parameters.AddWithValue("xx@xx1", Me.TextBox2.Text)
    '    cmm2.Parameters.AddWithValue("xxxx2", Me.NumericUpDown1.Value)
    '    cmm2.Parameters.AddWithValue("xxxx3", Me.MaskedTextBox1.Text)
    '    cmm2.Parameters.AddWithValue("xxxx4", Me.MaskedTextBox2.Text)
    '    cmm2.Parameters.AddWithValue("xxxx5", Me.MaskedTextBox3.Text)
    '    Try
    '        cmm2.ExecuteNonQuery()
    '        MsgBox("تم الحفظ ")
    '        Me.ComboBox1.Text = ""
    '        Me.NumericUpDown1.Value = 0
    '        Me.TextBox2.Text = ""
    '        'Me.MaskedTextBox1.Text = ""
    '        'Me.MaskedTextBox2.Text = ""
    '        'Me.MaskedTextBox3.Text = ""
    '        Me.DataGridView1.DataSource = ""
    '        Me.ComboBox1.Focus()
    '    Catch ex As Exception
    '        MsgBox(" لايمكن الحفظ ")
    '    End Try
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Me.ComboBox1.Text = ""
    '    Me.NumericUpDown1.Value = 0
    '    Me.TextBox2.Text = ""
    '    Me.MaskedTextBox1.Text = ""
    '    Me.MaskedTextBox2.Text = ""
    '    Me.MaskedTextBox3.Text = ""
    '    Me.DataGridView1.DataSource = ""
    '    Me.ComboBox1.Focus()
    'End Sub

    'Private Sub NumericUpDown1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumericUpDown1.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        Me.MaskedTextBox1.Focus()
    '    End If
    'End Sub

    'Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    'End Sub

    'Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    Dim dgx As Integer
    '    dgx = Me.DataGridView1.CurrentCell.Value
    '    TextBox1.Text = dgx
    '    Dim s As String = "delete * from appointment where id=dgx"
    '    Dim cm As New SqlClient.SqlCommand(s, cn)
    '    cm.Parameters.AddWithValue("dgx", TextBox1.Text)
    '    If MsgBox("هــل تـريد الحــــذف ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        cm.ExecuteNonQuery()
    '        MsgBox("تمـــت عمـــلـــية الحـــذف")
    '    End If

    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.TextBox3.Text = "" Then
            MsgBox("Insert Chair number")
            Me.TextBox3.Focus()
        ElseIf Me.ComboBox1.Text = "" Then
            MsgBox("Insert Name")
            Me.ComboBox1.Focus()
        ElseIf Me.ComboBox2.Text = "" Then
            Me.ComboBox2.Focus()
            MsgBox("Insert The Doctor Name")

        Else
            '  Dim ss2 As String = "insert into appointment(IDPAT,chno,Datea,from,to)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5)"
            Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,doctorname)VALUES(XX@xx1,XXXX2,xxxx3,xxxx6)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("xx@xx1", Me.TextBox2.Text)
            cmm2.Parameters.AddWithValue("xxxx2", Me.NumericUpDown1.Value)
            cmm2.Parameters.AddWithValue("xxxx3", Me.DateTimePicker3.Text)
            'cmm2.Parameters.AddWithValue("xxxx4", Me.MaskedTextBox2.Text)
            'cmm2.Parameters.AddWithValue("xxxx5", Me.MaskedTextBox3.Text)
            cmm2.Parameters.AddWithValue("xxxx6", Me.ComboBox2.Text)
            Try
                cmm2.ExecuteNonQuery()

                MsgBox("تم الحفظ ")
                Me.ComboBox1.Text = ""
                Me.ComboBox2.Text = ""
                Me.NumericUpDown1.Value = 0
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                'Me.MaskedTextBox1.Text = ""
                'Me.MaskedTextBox2.Text = ""
                'Me.MaskedTextBox3.Text = ""
                DataGridView1.Rows.Clear()
                Me.TextBox3.Focus()
                Me.ComboBox1.Enabled = False
                Me.DateTimePicker3.Enabled = False
                'Me.ComboBox2.Enabled = False
            Catch ex As Exception
                MsgBox(" لايمكن الحفظ ")
            End Try
            'end using

        End If
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_AlternatingRowsDefaultCellStyleChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Select Case e.ColumnIndex
            Case Is >= 0
                Select Case e.RowIndex
                    Case Is >= 0
                        ContextMenuStrip2.Enabled = True
                        Call Class1.CONNIC()

                        'Label20.Text = DataGridView1.Item(1, e.RowIndex).Value()
                        dgx = DataGridView1.Item(1, e.RowIndex).Value()
                        Dim i As Integer
                        i = e.RowIndex
                        num = e.RowIndex
                        If Val(i) >= 0 Then
                            Dim dgx As Integer
                            dgx = DataGridView1.Item(1, e.RowIndex).Value()
                            Label20.Text = DataGridView1.Item(1, e.RowIndex).Value()
                            dgxx = DataGridView1.Item(2, e.RowIndex).Value()
                            'Label17.Text = DataGridView1.Item(0, i).Value()
                            'dgx = Me.DataGridView1.CurrentCell.Value
                            'Label8.Text = dgx
                            Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno and chno=@chno"
                            Dim cm As New SqlClient.SqlCommand(s, cn)
                            cm.Parameters.AddWithValue("@Esalno", dgx)
                            cm.Parameters.AddWithValue("@chno", dgxx)
                            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                            If rd.Read = True Then
                                Me.ComboBox2.Text = rd!DN
                                Me.ComboBox3.Text = rd!Ejraa
                                Me.ComboBox2.Enabled = True
                                Me.ComboBox3.Enabled = True
                                Me.ComboBox4.Enabled = True
                                Me.TextBox3.Text = rd!chno
                                Me.TextBox2.Text = rd!fnumber
                                Me.Label5.Text = rd!chno
                                Me.Label16.Text = rd!chno
                                M7 = rd!CHNO
                                Me.Label10.Text = rd!Esalno
                                Me.ComboBox4.Text = rd!NAMEM
                                Me.TextBox4.Text = rd!JEHAM
                                Me.Label9.Text = rd!JEHAM
                                Me.ComboBox1.Text = rd!namex
                                Me.DateTimePicker3.Text = rd!datea
                                Me.TextBox3.Enabled = True
                                Me.ComboBox1.Enabled = True
                                'Me.ComboBox3.Enabled = False
                                'Me.ComboBox4.Enabled = True
                                Me.DateTimePicker3.Enabled = True
                                Button2.Enabled = False
                                rd.Close()
                                'Call Class1.CONNIC()
                                'Dim sk As String = "select * from KASHEF where Esalno=@Esalno"
                                'Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                'cmk.Parameters.AddWithValue("@Esalno", dgx)
                                'Dim rdk As SqlClient.SqlDataReader = cm.ExecuteReader
                                'If rdk.Read = True Then
                                '    'TextBox10.Text = rdk!MADFOO
                                '    TextBox11.Text = rdk!baky
                                'End If

                                rd.Close()
                                Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
                                Dim cm11 As New SqlClient.SqlCommand(s11, cn)
                                cm11.Parameters.AddWithValue("@conf", True)
                                cm11.Parameters.AddWithValue("@Esalno", dgx)
                                'cm11.Parameters.AddWithValue("@BAKY", CDbl(0))
                                Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
                                If rd11.Read = True Then
                                    Button2.Visible = False
                                    Button4.Visible = True
                                    Button6.Visible = False
                                    Me.ComboBox1.Enabled = False
                                    Me.ComboBox2.Enabled = False
                                    Me.ComboBox3.Enabled = False
                                    Me.ComboBox4.Enabled = False
                                    'ContextMenuStrip2.Enabled = False
                                    Label13.ContextMenuStrip = ContextMenuStrip3
                                    rd11.Close()
                                    Dim sk As String = "select * from KASHEF where fnumber=@fnumber AND ESALNO=@ESALNO"
                                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                    cmk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                                    cmk.Parameters.AddWithValue("@ESALNO", dgx)
                                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                                    If rdK.Read = True Then
                                        TextBox10.Text = CDbl(rdK!MADFOO)
                                        TextBox12.Text = CDbl(rdK!MADFOO)
                                        TextBox16.Text = CDbl(rdK!MADFOO)
                                        TextBox11.Text = CDbl(rdK!BAKY)
                                        TextBox15.Text = ""
                                        Label13.Text = CDbl(rdK!kemat)
                                        rdK.Close()
                                    End If
                                    If TextBox10.Text = 0 Then
                                        Button5.Visible = False
                                    Else
                                        Button5.Visible = True
                                    End If
                                    'end using
                                    'end using

                                    'TextBox10.Text = rd11!MADFOO
                                    'TextBox12.Text = rd11!MADFOO
                                    'TextBox11.Text = rd11!baky
                                    'If Label8.Text <> 0 Then

                                    'Else
                                    '    TextBox15.ReadOnly = False
                                    'End If
                                Else
                                    Button4.Visible = True
                                    Button2.Visible = False
                                    Button5.Visible = False
                                    Button6.Visible = True
                                    Me.ComboBox1.Enabled = True
                                    Me.ComboBox2.Enabled = True
                                    Me.ComboBox3.Enabled = True
                                    Me.ComboBox4.Enabled = True
                                    ContextMenuStrip2.Enabled = True
                                    Label13.ContextMenuStrip = ContextMenuStrip2
                                    If Label8.Text = 0 Then
                                        If Trim(TextBox15.Text) = "" Or Val(TextBox15.Text) = 0 Then
                                            Button6.Enabled = False
                                        Else
                                            Button6.Enabled = True
                                        End If
                                    End If

                                    'If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("أدوية") Then
                                    '    If ComboBox4.Text = Trim("نقدا") Then

                                    '    End If
                                    'End If
                                    rd11.Close()
                                    rd.Close()
                                    Dim sk As String = "select * from KASHEF where fnumber=@fnumber AND ESALNO=@ESALNO"
                                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                    cmk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                                    cmk.Parameters.AddWithValue("@ESALNO", dgx)
                                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                                    If rdK.Read = True Then
                                        TextBox10.Text = CDbl(rdK!MADFOO)
                                        TextBox12.Text = CDbl(rdK!MADFOO)
                                        TextBox16.Text = CDbl(rdK!MADFOO)
                                        TextBox11.Text = CDbl(rdK!BAKY)
                                        TextBox15.Text = ""
                                        Label13.Text = CDbl(rdK!kemat)
                                        TextBox15.Focus()
                                        'If Label8.Text <> 0 Then
                                        '    If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("أدوية") Then
                                        '        TextBox15.ReadOnly = False
                                        '        Label19.Visible = True
                                        '    Else
                                        '        TextBox15.ReadOnly = True
                                        '        Label19.Visible = False
                                        '    End If
                                        '    'TextBox15.ReadOnly = True
                                        'Else
                                        '    TextBox15.ReadOnly = False
                                        'End If

                                        rdK.Close()
                                    End If

                                    'TextBox10.Text = rd11!MADFOO
                                    'TextBox11.Text = rd11!baky
                                End If
                                rd11.Close()
                                'end using
                                'end using

                            End If


                            'end using
                            'end using

                            'Dim s As String = "delete * from appointment where fnumber=dgx"
                            'Dim cm As New SqlClient.SqlCommand(s, cn)
                            'cm.Parameters.AddWithValue("dgx", TextBox1.Text)
                            'If MsgBox("هــل تـريد الحــــذف ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            '    cm.ExecuteNonQuery()
                            '    MsgBox("تمـــت عمـــلـــية الحـــذف")
                            'End If

                            'End Select
                            TextBox15.Focus()
                            Dim s1 As String = "select * from SADAD "
                            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                            Dim dss As New DataSet
                            dss.Clear()
                            aad.Fill(dss, "SADAD")
                            Dim vd As New DataView(dss.Tables("SADAD"))
                            vd.RowFilter = "DATEXX>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEXX<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND ESALNO=" & "'" & dgx & "'" & ""
                            Me.DataGridView2.DataMember = ""
                            DataGridView2.DataSource = vd
                            'If DataGridView2.Rows.Count <> 0 Then
                            '    GroupBox1.Width = 879
                            '    GroupBox1.Location.X.Equals(454)
                            'Else
                            '    GroupBox1.Width = 1328
                            'End If


                            rd.Close()
                        End If
                        Call Class4.CONNIC()

                End Select
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Select Case e.ColumnIndex
            Case Is >= 0
                Select Case e.RowIndex
                    Case Is >= 0
                        ContextMenuStrip2.Enabled = True
                        Call Class1.CONNIC()
                        'Label20.Text = DataGridView1.Item(1, e.RowIndex).Value()
                        dgx = DataGridView1.Item(1, e.RowIndex).Value()
                        Dim i As Integer
                        i = e.RowIndex
                        num = e.RowIndex
                        If Val(i) >= 0 Then
                            Dim dgx As Integer
                            dgx = DataGridView1.Item(1, e.RowIndex).Value()
                            Label20.Text = DataGridView1.Item(1, e.RowIndex).Value()
                            dgxx = DataGridView1.Item(2, e.RowIndex).Value()
                            'Label17.Text = DataGridView1.Item(0, i).Value()
                            'dgx = Me.DataGridView1.CurrentCell.Value
                            'Label8.Text = dgx
                            Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno and chno=@chno"
                            Dim cm As New SqlClient.SqlCommand(s, cn)
                            cm.Parameters.AddWithValue("@Esalno", dgx)
                            cm.Parameters.AddWithValue("@chno", dgxx)
                            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                            If rd.Read = True Then
                                Me.ComboBox2.Text = rd!DN
                                Me.ComboBox3.Text = rd!Ejraa
                                Me.ComboBox2.Enabled = True
                                Me.ComboBox3.Enabled = True
                                Me.ComboBox4.Enabled = True
                                Me.TextBox3.Text = rd!chno
                                Me.TextBox2.Text = rd!fnumber
                                Me.Label5.Text = rd!chno
                                Me.Label16.Text = rd!chno
                                M7 = rd!CHNO
                                Me.Label10.Text = rd!Esalno
                                Me.ComboBox4.Text = rd!NAMEM
                                Me.TextBox4.Text = rd!JEHAM
                                Me.Label9.Text = rd!JEHAM
                                Me.ComboBox1.Text = rd!namex
                                Me.DateTimePicker3.Text = rd!datea
                                Me.TextBox3.Enabled = True
                                Me.ComboBox1.Enabled = True
                                'Me.ComboBox3.Enabled = False
                                'Me.ComboBox4.Enabled = True
                                Me.DateTimePicker3.Enabled = True
                                Button2.Enabled = False
                                rd.Close()
                                'Call Class1.CONNIC()
                                'Dim sk As String = "select * from KASHEF where Esalno=@Esalno"
                                'Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                'cmk.Parameters.AddWithValue("@Esalno", dgx)
                                'Dim rdk As SqlClient.SqlDataReader = cm.ExecuteReader
                                'If rdk.Read = True Then
                                '    'TextBox10.Text = rdk!MADFOO
                                '    TextBox11.Text = rdk!baky
                                'End If

                                rd.Close()
                                Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
                                Dim cm11 As New SqlClient.SqlCommand(s11, cn)
                                cm11.Parameters.AddWithValue("@conf", True)
                                cm11.Parameters.AddWithValue("@Esalno", dgx)
                                'cm11.Parameters.AddWithValue("@BAKY", CDbl(0))
                                Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
                                If rd11.Read = True Then
                                    Button2.Visible = False
                                    Button4.Visible = True
                                    Button6.Visible = False
                                    'ContextMenuStrip2.Enabled = False
                                    Label13.ContextMenuStrip = ContextMenuStrip3
                                    Me.ComboBox1.Enabled = False
                                    Me.ComboBox2.Enabled = False
                                    Me.ComboBox3.Enabled = False
                                    Me.ComboBox4.Enabled = False
                                    rd11.Close()
                                    Dim sk As String = "select * from KASHEF where fnumber=@fnumber AND ESALNO=@ESALNO"
                                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                    cmk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                                    cmk.Parameters.AddWithValue("@ESALNO", dgx)
                                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                                    If rdK.Read = True Then
                                        TextBox10.Text = CDbl(rdK!MADFOO)
                                        TextBox12.Text = CDbl(rdK!MADFOO)
                                        TextBox16.Text = CDbl(rdK!MADFOO)
                                        TextBox11.Text = CDbl(rdK!BAKY)
                                        TextBox15.Text = ""
                                        Label13.Text = CDbl(rdK!kemat)
                                        rdK.Close()
                                    End If
                                    If TextBox10.Text = 0 Then
                                        Button5.Visible = False
                                    Else
                                        Button5.Visible = True
                                    End If
                                    'end using
                                    'end using

                                    'TextBox10.Text = rd11!MADFOO
                                    'TextBox12.Text = rd11!MADFOO
                                    'TextBox11.Text = rd11!baky
                                    'If Label8.Text <> 0 Then

                                    'Else
                                    '    TextBox15.ReadOnly = False
                                    'End If
                                    rd11.Close()
                                Else
                                    Button4.Visible = True
                                    Button6.Visible = True
                                    Me.ComboBox1.Enabled = True
                                    Me.ComboBox2.Enabled = True
                                    Me.ComboBox3.Enabled = True
                                    Me.ComboBox4.Enabled = True
                                    ContextMenuStrip2.Enabled = True
                                    Label13.ContextMenuStrip = ContextMenuStrip2
                                    'Button4.Visible = False
                                    Button2.Visible = False
                                    Button5.Visible = False
                                    'Button6.Visible = True
                                    If Label8.Text = 0 Then
                                        If Trim(TextBox15.Text) = "" Or Val(TextBox15.Text) = 0 Then
                                            Button6.Enabled = False
                                        Else
                                            Button6.Enabled = True
                                        End If
                                    End If

                                    'If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("أدوية") Then
                                    '    If ComboBox4.Text = Trim("نقدا") Then

                                    '    End If
                                    'End If
                                    rd11.Close()
                                    rd.Close()
                                    Dim sk As String = "select * from KASHEF where fnumber=@fnumber AND ESALNO=@ESALNO"
                                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                    cmk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                                    cmk.Parameters.AddWithValue("@ESALNO", dgx)
                                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                                    If rdK.Read = True Then
                                        TextBox10.Text = CDbl(rdK!MADFOO)
                                        TextBox12.Text = CDbl(rdK!MADFOO)
                                        TextBox16.Text = CDbl(rdK!MADFOO)
                                        TextBox11.Text = CDbl(rdK!BAKY)
                                        TextBox15.Text = ""
                                        Label13.Text = CDbl(rdK!kemat)
                                        TextBox15.Focus()
                                        'If Label8.Text <> 0 Then
                                        '    If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("أدوية") Then
                                        '        TextBox15.ReadOnly = False
                                        '        Label19.Visible = True
                                        '    Else
                                        '        TextBox15.ReadOnly = True
                                        '        Label19.Visible = False
                                        '    End If
                                        '    'TextBox15.ReadOnly = True
                                        'Else
                                        '    TextBox15.ReadOnly = False
                                        'End If

                                        rdK.Close()
                                    End If

                                    'TextBox10.Text = rd11!MADFOO
                                    'TextBox11.Text = rd11!baky
                                End If
                                rd11.Close()
                                'end using
                                'end using

                            End If
                            rd.Close()

                            'end using
                            'end using

                            'Dim s As String = "delete * from appointment where fnumber=dgx"
                            'Dim cm As New SqlClient.SqlCommand(s, cn)
                            'cm.Parameters.AddWithValue("dgx", TextBox1.Text)
                            'If MsgBox("هــل تـريد الحــــذف ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            '    cm.ExecuteNonQuery()
                            '    MsgBox("تمـــت عمـــلـــية الحـــذف")
                            'End If

                            'End Select
                            TextBox15.Focus()
                            Dim s1 As String = "select * from SADAD "
                            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                            Dim dss As New DataSet
                            dss.Clear()
                            aad.Fill(dss, "SADAD")
                            Dim vd As New DataView(dss.Tables("SADAD"))
                            vd.RowFilter = "DATEXX>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEXX<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND ESALNO=" & "'" & dgx & "'" & ""
                            Me.DataGridView2.DataMember = ""
                            DataGridView2.DataSource = vd
                            'If DataGridView2.Rows.Count <> 0 Then
                            '    GroupBox1.Width = 879
                            '    GroupBox1.Location.X.Equals(454)
                            'Else
                            '    GroupBox1.Width = 1328
                            'End If

                            rd.Close()

                        End If
                        Call Class4.CONNIC()
                End Select

        End Select
    End Sub


    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Class1.CONNIC()
            Dim s As String = "select * from main where namex=@xx1 "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                Me.TextBox2.Text = rd!fnumber
            End If
            'end using
            'end using
            DGV1()
            'Dim s1 As String = "select * from appointment "
            'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            'Dim dss As New DataSet
            'dss.Clear()
            'aad.Fill(dss, "appointment")
            'Dim vd As New DataView(dss.Tables("appointment"))
            'vd.RowFilter = "fnumber=" & "'" & TextBox2.Text & "'" & ""
            'Me.DataGridView1.DataMember = ""
            'DataGridView1.DataSource = vd
            Me.DateTimePicker3.Focus()
            'end using
            'end using
            'end using
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Class1.CONNIC()
        Dim s As String = "select * from main where namex=@xx1 "
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
        'Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        If rd.Read = True Then
            Me.TextBox2.Text = rd!fnumber
        Else
            Me.TextBox2.Text = ""
        End If
        'end using
        'end using
        'rd.Close()
        DGV1()
        'Dim s1 As String = "select * from appointment "
        'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        'Dim dss As New DataSet
        'dss.Clear()
        'aad.Fill(dss, "appointment")
        'Dim vd As New DataView(dss.Tables("appointment"))
        'vd.RowFilter = "fnumber=" & "'" & TextBox2.Text & "'" & ""
        'Me.DataGridView1.DataMember = ""
        'DataGridView1.DataSource = vd
        'Me.DateTimePicker3.Focus()
        'end using
        'end using
        'end using
        Call Class4.CONNIC()
    End Sub

    Private Sub NumericUpDown1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.DateTimePicker3.Focus()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Form10_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'MDIParent1.Panel1.Visible = True
        Call Class4.CONNIC()
    End Sub

    Private Sub Form10_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'MDIParent1.Panel1.Visible = True
        Call Class4.CONNIC()
    End Sub
    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CLINICSQLhDataSet.APPOINTMENTVIEW' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEWTableAdapter.Fill(Me.CLINICSQLhDataSet.APPOINTMENTVIEW)
        Call Class1.CONNIC()

        'ContextMenuStrip2.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = 0
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        Me.Label1.Text = ""
        Me.Label2.Text = 0
        Me.Label3.Text = ""
        Me.Label4.Text = 0
        Me.Label5.Text = ""
        'Me.Label6.Text = ""
        'Me.Label7.Text = ""
        Me.Label8.Text = 0
        Me.Label9.Text = ""
        Me.Label10.Text = 0
        'Me.Label11.Text = 0
        Me.Label12.Text = 0
        Me.Label13.Text = 0

        Me.Label14.Text = ""
        Me.Label15.Text = 0
        Me.Label16.Text = ""
        Me.Label17.Text = ""
        Me.Label18.Text = ""
        Me.Label19.Text = ""
        Me.Label20.Text = ""
        Me.Label21.Text = ""
        Me.Label22.Text = ""
        Me.Label23.Text = 0
        Timer2.Stop()
        'TODO: This line of code loads data into the 'DbsbhDataSet8.SADAD' table. You can move, or remove it, as needed.
        'Me.SADADTableAdapter.Fill(Me.DbsbhDataSet8.SADAD)
        'Label14.Text = user
        Timer1.Start()
        'TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENTVIEW1' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEW1TableAdapter.Fill(Me.DbsbhDataSet8.APPOINTMENTVIEW1)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENTVIEW' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEWTableAdapter1.Fill(Me.DbsbhDataSet8.APPOINTMENTVIEW)

        ''TODO: This line of code loads data into the 'DbsbhDataSet7.dn' table. You can move, or remove it, as needed.
        'Me.DnTableAdapter.Fill(Me.DbsbhDataSet7.dn)
        'TODO: This line of code loads data into the 'DbsbhDataSet7.APPOINTMENTVIEW' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEWTableAdapter.Fill(Me.DbsbhDataSet7.APPOINTMENTVIEW)
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        'Me.ComboBox3.Enabled = False
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        Me.Label5.Text = ""
        Me.Label16.Text = ""
        Me.Label13.Text = ""
        Me.Label21.Text = ""
        ComboBox3.Text = "كشف"
        Label21.BackColor = Color.Transparent
        Dim sk1 As String
        sk1 = "select * from MAIN"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "MAIN")
        ComboBox1.DataSource = dsk1.Tables(0)
        ComboBox1.DisplayMember = "NAMEX"
        ComboBox1.SelectedIndex = -1
        'end using
        'end using

        Dim sk2 As String
        sk2 = "select * from dn"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        ComboBox2.SelectedIndex = -1
        'end using
        'end using

        Dim sk4 As String
        sk4 = "select * from Mostafeed"
        Dim adk4 As New SqlClient.SqlDataAdapter(sk4, cn)
        Dim dsk4 As New DataSet
        adk4.Fill(dsk4, "Mostafeed")
        ComboBox4.DataSource = dsk4.Tables(0)
        ComboBox4.DisplayMember = "NameM"
        ComboBox4.SelectedIndex = -1
        'end using
        'end using

        'Dim sk3 As String
        'sk3 = "select * from Ejraa"
        'Dim adk3 As New SqlClient.SqlDataAdapter(sk3, cn)
        'Dim dsk3 As New DataSet
        'adk3.Fill(dsk3, "Ejraa")
        'ComboBox3.DataSource = dsk3.Tables(0)
        'ComboBox3.DisplayMember = "Ejraa"
        ''ComboBox3.SelectedIndex = -1
        ComboBox3.Text = "كشف"
        'end using
        'end using

        Me.TextBox3.Focus()
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        DataGridView1.Rows.Clear()
        DataGridView2.DataSource = ""
        If ewaa = True Then
            Label12.Text = sano
            GroupBox10.Visible = True
            ComboBox3.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox3.Text = "إيواء"
            ComboBox3.Enabled = False
            ewaa = False
        End If
        Dim k As Integer = 1
        Dim i As Integer
        i = 0
        'Do While k < 100
        If Tkesem = True Then
            B0.Visible = True
            B0.Text = KESEM_NAME.ToString
        Else
            Do While i < 1000
                Call Class1.CONNIC()
                Dim sB As String = "select * from KESEM where IDK=@xx1 "
                Dim cmB As New SqlClient.SqlCommand(sB, cn)
                cmB.Parameters.AddWithValue("@xx1", i)
                Dim rdB As SqlClient.SqlDataReader
                rdB = cmB.ExecuteReader
                If rdB.Read = True Then
                    If B0.Visible = False Then
                        B0.Visible = True
                        B0.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = False Then
                        B1.Visible = True
                        B1.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = False Then
                        B2.Visible = True
                        B2.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = False Then
                        B3.Visible = True
                        B3.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = False Then
                        B4.Visible = True
                        B4.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = False Then
                        B5.Visible = True
                        B5.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = False Then
                        B6.Visible = True
                        B6.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = False Then
                        B7.Visible = True
                        B7.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = False Then
                        B8.Visible = True
                        B8.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = False Then
                        B9.Visible = True
                        B9.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = False Then
                        B10.Visible = True
                        B10.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = False Then
                        B11.Visible = True
                        B11.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = False Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = False Then
                        B13.Visible = True
                        B13.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = False Then
                        B14.Visible = True
                        B14.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = False Then
                        B15.Visible = True
                        B15.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = False Then
                        B16.Visible = True
                        B16.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = False Then
                        B17.Visible = True
                        B17.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = False Then
                        B18.Visible = True
                        B18.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = False Then
                        B19.Visible = True
                        B19.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = False Then
                        B20.Visible = True
                        B20.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = False Then
                        B21.Visible = True
                        B21.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = False Then
                        B22.Visible = True
                        B22.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = True And B23.Visible = False Then
                        B23.Visible = True
                        B23.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = True And B23.Visible = True And B24.Visible = False Then
                        B24.Visible = True
                        B24.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = True And B23.Visible = True And B24.Visible = True And B25.Visible = False Then
                        B25.Visible = True
                        B25.Text = rdB!KESEM
                    ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And B13.Visible = True And B14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = True And B23.Visible = True And B24.Visible = True And B25.Visible = True And B26.Visible = False Then
                        B26.Visible = True
                        B26.Text = rdB!KESEM
                    End If
                    'Dim bi As New Button
                    'bi.Name = "B" + i
                    'bi.visible = True
                    'bi.Text = rdB!kesem
                End If
                i = i + 1
                rdB.Close()
            Loop
        End If
        'i = i + 1
        'k = k + 1
        'Loop
        'i = i + 1

        'Dim k As Integer = 1
        'Dim i As Integer = 0
        'Do While k < 100
        '    Call Class1.CONNIC()
        '    Dim sB As String = "select * from KESEM where IDK=@IDK "
        '    Dim cmB As New SqlClient.SqlCommand(sB, cn)
        '    cmB.Parameters.AddWithValue("@IDK", i)
        '    Dim rdB As SqlClient.SqlDataReader
        '    rdB = cmB.ExecuteReader
        '    Do While rdB.Read = True
        '        If i = 0 Then
        '            B0.Visible = True
        '            B0.Text = rdB!KESEM
        '        ElseIf i = 1 Then
        '            B1.Visible = True
        '            B1.Text = rdB!KESEM
        '        ElseIf i = 2 Then
        '            B2.Visible = True
        '            B2.Text = rdB!KESEM
        '        ElseIf i = 3 Then
        '            B3.Visible = True
        '            B3.Text = rdB!KESEM
        '        ElseIf i = 4 Then
        '            B4.Visible = True
        '            B4.Text = rdB!KESEM
        '        ElseIf i = 5 Then
        '            B5.Visible = True
        '            B5.Text = rdB!KESEM
        '        ElseIf i = 6 Then
        '            B6.Visible = True
        '            B6.Text = rdB!KESEM
        '        ElseIf i = 7 Then
        '            B7.Visible = True
        '            B7.Text = rdB!KESEM
        '        ElseIf i = 8 Then
        '            B8.Visible = True
        '            B8.Text = rdB!KESEM
        '        ElseIf i = 9 Then
        '            B9.Visible = True
        '            B9.Text = rdB!KESEM
        '        ElseIf i = 10 Then
        '            B10.Visible = True
        '            B10.Text = rdB!KESEM
        '        ElseIf i = 11 Then
        '            B11.Visible = True
        '            B11.Text = rdB!KESEM
        '        ElseIf i = 12 Then
        '            B12.Visible = True
        '            B12.Text = rdB!KESEM
        '        ElseIf i = 13 Then
        '            B13.Visible = True
        '            B13.Text = rdB!KESEM
        '        ElseIf i = 14 Then
        '            B14.Visible = True
        '            B14.Text = rdB!KESEM
        '        ElseIf i = 15 Then
        '            B15.Visible = True
        '            B15.Text = rdB!KESEM
        '        ElseIf i = 16 Then
        '            B16.Visible = True
        '            B16.Text = rdB!KESEM
        '        ElseIf i = 17 Then
        '            B17.Visible = True
        '            B17.Text = rdB!KESEM
        '        ElseIf i = 18 Then
        '            B18.Visible = True
        '            B18.Text = rdB!KESEM
        '        ElseIf i = 19 Then
        '            B19.Visible = True
        '            B19.Text = rdB!KESEM
        '        ElseIf i = 20 Then
        '            B20.Visible = True
        '            B20.Text = rdB!KESEM
        '        End If
        '        i = i + 1
        '    Loop
        '    rdB.Close()
        '    k = k + 1
        'Loop

        'Do While k < 100
        '    Dim sB As String = "select * from KESEM where IDK=@xx1 "
        '    Dim cmB As New SqlClient.SqlCommand(sB, cn)
        '    cmB.Parameters.AddWithValue("@xx1", i)
        '    dim rdB As SqlClient.SqlDataReader = cmB.ExecuteReader
        '        Do While rdB.Read = True
        '            If i = 1 Then
        '                B1.Visible = True
        '                B1.Text = rdB!KESEM
        '            ElseIf i = 2 Then
        '                B2.Visible = True
        '                B2.Text = rdB!KESEM
        '            ElseIf i = 3 Then
        '                B3.Visible = True
        '                B3.Text = rdB!KESEM
        '            ElseIf i = 4 Then
        '                B4.Visible = True
        '                B4.Text = rdB!KESEM
        '            ElseIf i = 5 Then
        '                B5.Visible = True
        '                B5.Text = rdB!KESEM
        '            ElseIf i = 6 Then
        '                B6.Visible = True
        '                B6.Text = rdB!KESEM
        '            ElseIf i = 7 Then
        '                B7.Visible = True
        '                B7.Text = rdB!KESEM
        '            ElseIf i = 8 Then
        '                B8.Visible = True
        '                B8.Text = rdB!KESEM
        '            ElseIf i = 9 Then
        '                B9.Visible = True
        '                B9.Text = rdB!KESEM
        '            ElseIf i = 10 Then
        '                B10.Visible = True
        '                B10.Text = rdB!KESEM
        '            ElseIf i = 11 Then
        '                B11.Visible = True
        '                B11.Text = rdB!KESEM
        '            ElseIf i = 12 Then
        '                B12.Visible = True
        '                B12.Text = rdB!KESEM
        '                'ElseIf i = 13 Then
        '                '    B13.Visible = True
        '                '    B13.Text = rdB!KESEM
        '                'ElseIf i = 14 Then
        '                B12.Visible = True
        '                B12.Text = rdB!KESEM
        '                'ElseIf i = 15 Then
        '                '    B12.Visible = True
        '                '    B12.Text = rdB!KESEM
        '                'ElseIf i = 16 Then
        '                '    B12.Visible = True
        '                '    B12.Text = rdB!KESEM
        '                'ElseIf i = 17 Then
        '                '    B12.Visible = True
        '                '    B12.Text = rdB!KESEM
        '                'ElseIf i = 18 Then
        '                '    B12.Visible = True
        '                '    B12.Text = rdB!KESEM
        '                'ElseIf i = 19 Then
        '                '    B12.Visible = True
        '                '    B12.Text = rdB!KESEM
        '                'ElseIf i = 20 Then
        '                '    B12.Visible = True
        '                '    B12.Text = rdB!KESEM
        '            End If
        '            i = i + 1
        '            'rdB.Close()
        '        Loop
        '        'rdB.Close()
        '    'end using   'k = k + 1
        'Loop

        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        'Me.ComboBox3.Enabled = False
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        Me.Label5.Text = ""
        Me.Label16.Text = ""
        Me.Label13.Text = ""
        Me.Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox2.Text = ""
        TextBox10.Text = 0
        TextBox16.Text = 0
        TextBox11.Text = 0
        ComboBox3.Text = "كشف"
        'TextBox15.ReadOnly = True
        TextBox1.Text = ""
        TextBox2.Text = 0
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        Me.Label1.Text = ""
        Me.Label2.Text = 0
        Me.Label3.Text = ""
        Me.Label4.Text = 0
        Me.Label5.Text = ""
        'Me.Label6.Text = ""
        'Me.Label7.Text = ""
        Me.Label8.Text = 0
        Me.Label9.Text = ""
        Me.Label10.Text = 0
        'Me.Label11.Text = 0
        Me.Label12.Text = 0
        Me.Label13.Text = 0
        Me.Label14.Text = ""
        Me.Label15.Text = 0
        Me.Label16.Text = ""
        Me.Label17.Text = ""
        Me.Label18.Text = ""
        Me.Label19.Text = ""
        Me.Label20.Text = ""
        Me.Label21.Text = ""
        Me.Label22.Text = ""
        Me.Label23.Text = 0
        Timer2.Stop()
        Label21.BackColor = Color.Transparent
        Call Class4.CONNIC()
    End Sub



    Private Sub DateTimePicker3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.ComboBox2.Focus()
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = Keys.Enter Then

        '    If Me.TextBox3.Text = "" Then
        '        Dim k As Integer = 1
        '        Do While k < 100
        '            Dim i As Integer
        '            i = Me.Label1.Text
        '            Dim s As String = "select * from appointment where chno=@xx1 and datea=xx2 "
        '            dim cm As New SqlClient.SqlCommand(s, cn)
        '                cm.Parameters.AddWithValue("@xx1", i)
        '                cm.Parameters.AddWithValue("xx2", Date.Today)
        '                dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        '                    Do While rd.Read = True
        '                        i = i + 1
        '                        Dim ss As String = "select * from appointment where chno=@xx1 and datea=xx2 "
        '                        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        '                        cmm.Parameters.AddWithValue("@xx1", i)
        '                        cmm.Parameters.AddWithValue("xx2", Date.Today)
        '                        rd = cmm.ExecuteReader
        '                        Me.Label1.Text = i

        '                    Loop
        '                    rd.Close()
        '                    k = k + 1
        '                'end using
        '            'end using

        '        Loop
        '        Me.TextBox3.Text = Me.Label1.Text
        '        Me.Label5.Text = Me.Label1.Text
        '        Me.NumericUpDown1.Text = Me.TextBox3.Text
        '        Me.ComboBox1.Focus()
        '    End If
        'End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub DGV1()
        Try
            Call Class1.CONNIC()
            Dim DAA As New SqlClient.SqlDataAdapter("select ID,ESALNO,CHNO,DATEA,NAMEX,EJRAA from APPOINTMENTVIEW 
                         WHERE (format(DATEA,'yyyy-MM-dd') >='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "') and (format(DATEA,'yyyy-MM-dd') <='" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "')" & "AND IDD=" & "'" & Me.Label4.Text & "'" & "", cn)
            Dim DTA As New DataTable
            DAA.Fill(DTA)
            DataGridView1.Rows.Clear()
            For Each ITEM As DataRow In DTA.Rows
                Dim n As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(n).Cells(0).Value = ITEM(0).ToString()
                DataGridView1.Rows(n).Cells(1).Value = ITEM(1).ToString()
                DataGridView1.Rows(n).Cells(2).Value = ITEM(2).ToString()
                DataGridView1.Rows(n).Cells(3).Value = Format(CDate(ITEM(3)), "yyyy-MM-dd").ToString
                DataGridView1.Rows(n).Cells(4).Value = ITEM(4).ToString()
                DataGridView1.Rows(n).Cells(5).Value = ITEM(5).ToString()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Class4.CONNIC()
    End Sub
    'Public Sub DGV3()
    '    Try
    '        Call Class1.CONNIC()
    '        Dim DAA As New SqlClient.SqlDataAdapter("select ID,ESALNO,CHNO,DATEA,NAMEX,EJRAA from APPOINTMENTVIEW 
    '                     WHERE (format(DATEA,'yyyy-MM-dd') >='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "') and (format(DATEA,'yyyy-MM-dd') <='" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "')" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & "", cn)
    '        Dim DTA As New DataTable
    '        DAA.Fill(DTA)
    '        DataGridView3.Rows.Clear()
    '        For Each ITEM As DataRow In DTA.Rows
    '            Dim n As Integer = DataGridView3.Rows.Add()
    '            DataGridView3.Rows(n).Cells(0).Value = ITEM(0).ToString()
    '            DataGridView3.Rows(n).Cells(1).Value = ITEM(1).ToString()
    '            DataGridView3.Rows(n).Cells(2).Value = ITEM(2).ToString()
    '            DataGridView3.Rows(n).Cells(3).Value = Format(CDate(ITEM(3)), "yyyy-MM-dd").ToString
    '            DataGridView3.Rows(n).Cells(4).Value = ITEM(4).ToString()
    '            DataGridView3.Rows(n).Cells(5).Value = ITEM(5).ToString()
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Call Class4.CONNIC()
    'End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If ComboBox2.Text = "" Then
            MsgBox("يرجة تحديد اسم الطبيب")
        Else
            DGV1()


            'Call Class1.CONNIC()
            'Dim s1 As String = "select * from APPOINTMENTVIEW "
            'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            'Dim dss As New DataSet
            'dss.Clear()
            'aad.Fill(dss, "APPOINTMENTVIEW")
            'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
            'vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
            'Me.DataGridView1.DataMember = ""
            'DataGridView1.DataSource = vd
            'end using
            'end using
            'end using
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Call Class1.CONNIC()
        Dim s As String = "select * from main where namex=@xx1 "
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        If rd.Read = True Then
            Me.TextBox2.Text = rd!fnumber
        Else
            Me.TextBox2.Text = ""
        End If
        'end using
        'end using
        DGV1()

        'Dim s1 As String = "select * from appointment "
        'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        'Dim dss As New DataSet
        'dss.Clear()
        'aad.Fill(dss, "appointment")
        'Dim vd As New DataView(dss.Tables("appointment"))
        'vd.RowFilter = "fnumber=" & "'" & TextBox2.Text & "'" & ""
        'Me.DataGridView1.DataMember = ""
        'DataGridView1.DataSource = vd
        '' Me.DateTimePicker3.Focus()
        ''end using
        ''end using
        ''end using
        'Call CLASS4.CONNIC()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.TextBox3.Text = "" Then
            MsgBox("Insert Chair number")
            Me.TextBox3.Focus()
        ElseIf Me.ComboBox1.Text = "" Then
            MsgBox("Insert Name")
            Me.ComboBox1.Focus()
        ElseIf Me.ComboBox2.Text = "" Then
            Me.ComboBox2.Focus()
            MsgBox("Insert The Doctor Name")
            'ElseIf Me.Label13.Text = 0 Then
            '    '    MsgBox("أدخل قيمة الإجراء")
            '    '    TextBox15.Focus()
            '    confx = False
        Else
            'Call Class1.CONNIC()
            'Dim skkA As String = "select * from APPOINTMENT where fnumber=@fnumber and DATEA<>@DATEA "
            'Using cmkkA As New SqlClient.SqlCommand(skkA, cn)
            '    cmkkA.Parameters.AddWithValue("@fnumber", Trim(TextBox2.Text))
            '    cmkkA.Parameters.AddWithValue("@DATEA", DateTimePicker3.Value.Date)
            '    Using rdkkA As SqlClient.SqlDataReader = cmkkA.ExecuteReader
            '        If rdkkA.Read = True Then
            '            MsgBox("هذا الحجز موجود مسبقا", "منظومة العيادة")
            '            ComboBox1.Focus()
            '            Return
            '        End If

            '    End Using
            'End Using

            'm5 = 1
            'Dim k As Integer = 0
            'Do While k < 100
            '    Dim i As Integer
            '    i = m5
            '    Dim s1 As String = "select * from main where fnumber=@xx1"
            '    Dim cm1 As New SqlClient.SqlCommand(s1, cn)
            '    cm1.Parameters.AddWithValue("@xx1", i)
            '    Dim rd1 As SqlClient.SqlDataReader
            '    rd1 = cm1.ExecuteReader
            '    Do While rd1.Read = True
            '        i = i + 1
            '        Dim ss1 As String = "select * from main where fnumber=@xx1"
            '        Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
            '        cmm1.Parameters.AddWithValue("@xx1", i)
            '        rd1 = cmm1.ExecuteReader
            '        m5 = i
            '    Loop
            '    rd1.Close()
            '    k = k + 1
            'Loop
            ' Label6.Text = m5
            Call Class1.CONNIC()
            If TextBox2.Text = Trim("") Then
                Dim ss As String = "insert into main(namex,age,address,husbend,phone,idcard,datex,CITY,gender)values(@xx1,@xx3,@xx4,@xx5,@xx6,@xx7,@xx8,@xx9,@XX10)"
                Using cmm As New SqlClient.SqlCommand(ss, cn)
                    cmm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
                    'cmm.Parameters.AddWithValue("@xx2", TextBox2.Text)
                    cmm.Parameters.AddWithValue("@xx3", "0")
                    cmm.Parameters.AddWithValue("@xx4", "لايوجد")
                    cmm.Parameters.AddWithValue("@xx5", "لايوجد")
                    cmm.Parameters.AddWithValue("@xx6", TextBox24.Text)
                    cmm.Parameters.AddWithValue("@xx7", "لايوجد")
                    cmm.Parameters.AddWithValue("@xx8", Date.Now.Date)
                    cmm.Parameters.AddWithValue("@xx9", "لايوجد")
                    cmm.Parameters.AddWithValue("@xx10", "لايوجد")
                    Try
                        cmm.ExecuteNonQuery()

                    Catch ex As Exception
                    End Try
                End Using
            End If
            Dim s As String = "select * from main where namex=@xx1 "
            Using cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
                Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                    If rd.Read = True Then
                        Me.TextBox2.Text = rd!fnumber
                    End If
                    rd.Close()
                End Using
            End Using
            'Dim skk As String = "select * from kashef where fnumber=@fnumber and doctorname=@doctorname and baky<>@baky "
            'Using cmkk As New SqlClient.SqlCommand(skk, cn)
            '    cmkk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
            '    cmkk.Parameters.AddWithValue("@doctorname", ComboBox2.Text)
            '    cmkk.Parameters.AddWithValue("@baky", CDbl(0))
            '    Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
            '        If rdkk.Read = True Then
            '            Label18.Text = rdkk!Esalno
            '            M6 = rdkk!Esalno
            'Dim ss21k As String = "update kashef set fnumber=@fnumber,CHNO=@CHNO,DATEX=@DATEX,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME,idm=@idm,EJRAA=@EJRAA where Esalno=@Esalno"
            ''    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            'Using cmm21 As New SqlClient.SqlCommand(ss21k, cn)
            '    cmm21.Parameters.AddWithValue("@fnumber", TextBox2.Text)
            '    cmm21.Parameters.AddWithValue("@CHNO", Me.Label1.Text)
            '    cmm21.Parameters.AddWithValue("@DATEX", Me.DateTimePicker3.Text)
            '    cmm21.Parameters.AddWithValue("@doctorname", Me.ComboBox2.Text)
            '    'cmm21.Parameters.AddWithValue("@X5", M6)
            '    cmm21.Parameters.AddWithValue("@KEMA", TextBox6.Text)
            '    cmm21.Parameters.AddWithValue("@KEMAT", TextBox5.Text)
            '    cmm21.Parameters.AddWithValue("@MADFOO", TextBox10.Text)
            '    cmm21.Parameters.AddWithValue("@BAKY", TextBox11.Text)
            '    If Label8.Text = 0 Then
            '        cmm21.Parameters.AddWithValue("@conf", False)
            '    Else
            '        cmm21.Parameters.AddWithValue("@conf", True)
            '    End If
            '    cmm21.Parameters.AddWithValue("@USER_NAME", user)
            '    cmm21.Parameters.AddWithValue("@idm", Label8.Text)
            '    cmm21.Parameters.AddWithValue("@Ejraa", ComboBox3.Text)
            '    cmm21.Parameters.AddWithValue("@Esalno", Label18.Text)

            '    'Try
            '    cmm21.ExecuteNonQuery()
            '    M6 = CInt(Label18.Text)
            'End Using
            'Else
            Dim ss21 As String = "insert into kashef(fnumber,CHNO,DATEX,doctorname,KEMA,KEMAT,MADFOO,BAKY,conf,USER_NAME,idm,EJRAA) VALUES(@fnumber,@CHNO,@DATEX,@doctorname,@KEMA,@KEMAT,@MADFOO,@BAKY,@conf,@USER_NAME,@idm,@EJRAA)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Using cmm21 As New SqlClient.SqlCommand(ss21, cn)
                cmm21.Parameters.AddWithValue("@fnumber", CInt(TextBox2.Text))
                cmm21.Parameters.AddWithValue("@CHNO", CInt(Me.Label1.Text))
                cmm21.Parameters.AddWithValue("@DATEX", Me.DateTimePicker3.Value.Date)
                cmm21.Parameters.AddWithValue("@doctorname", Me.Label4.Text)
                'cmm21.Parameters.AddWithValue("@X5", M6)
                'If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
                cmm21.Parameters.AddWithValue("@KEMA", CDec(TextBox6.Text))
                'Else
                '    cmm21.Parameters.AddWithValue("@KEMA", CDec(TextBox6.Text))
                'End If
                cmm21.Parameters.AddWithValue("@KEMAT", Me.Label13.Text)
                If KHAZENAXX = False Then
                    cmm21.Parameters.AddWithValue("@MADFOO", CDbl(0))
                    cmm21.Parameters.AddWithValue("@conf", False)
                    cmm21.Parameters.AddWithValue("@BAKY", CDbl(Me.Label13.Text))
                Else
                    If Me.Label13.Text = 0 Then
                        confx = False
                    Else
                        confx = True
                    End If
                    cmm21.Parameters.AddWithValue("@MADFOO", CDbl(Me.TextBox10.Text))
                    cmm21.Parameters.AddWithValue("@conf", confx)
                    cmm21.Parameters.AddWithValue("@BAKY", CDbl(Me.TextBox11.Text))
                End If
                cmm21.Parameters.AddWithValue("@USER_NAME", user)
                cmm21.Parameters.AddWithValue("@idm", Label8.Text)
                cmm21.Parameters.AddWithValue("@Ejraa", ComboBox3.Text)

                'Try
                cmm21.ExecuteNonQuery()

                Dim Str As String = "SELECT MAX(ESALNO) FROM KASHEF "
                Dim cmd As New SqlClient.SqlCommand(Str, cn)
                M6 = cmd.ExecuteScalar
            End Using
            'End If
            'rdkk.Close()
            '        End Using
            '    End Using
            'M6 = 1
            'Dim k1 As Integer = 0
            'Do While k1 < 100
            '    Dim i As Integer
            '    i = M6
            '    Dim s1 As String = "select * from appointment where ESALNO=@xx1"
            '    Dim cm1 As New SqlClient.SqlCommand(s1, cn)
            '    cm1.Parameters.AddWithValue("@xx1", i)
            '    Dim rd1 As SqlClient.SqlDataReader
            '    rd1 = cm1.ExecuteReader
            '    Do While rd1.Read = True
            '        i = i + 1
            '        Dim ss1 As String = "select * from appointment where ESALNO=@xx1"
            '        Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
            '        cmm1.Parameters.AddWithValue("@xx1", i)
            '        rd1 = cmm1.ExecuteReader
            '        M6 = i
            '    Loop
            '    rd1.Close()
            '    k1 = k1 + 1
            'Loop
            If KHAZENAXX = True Then
                Dim s222 As String = "insert into SADAD(ESALNO,DATEXX,SADAD) values(@ESALNO,@DATEXX,@SADAD)"
                Dim cm222 As New SqlClient.SqlCommand(s222, cn)
                cm222.Parameters.AddWithValue("@ESALNO", M6)
                cm222.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
                cm222.Parameters.AddWithValue("@SADAD", CDbl(Me.Label13.Text))
                Try
                    cm222.ExecuteNonQuery()
                Catch ex As Exception

                End Try
            End If


            Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,doctorname,IDM,EJRAA,Esalno,USER_NAME)VALUES(@fnumber,@CHNO,@DATEA,@doctorname,@IDM,@EJRAA,@Esalno,@USER_NAME)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
                cmm2.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                cmm2.Parameters.AddWithValue("@CHNO", CInt(Me.Label1.Text))
                cmm2.Parameters.AddWithValue("@DATEA", Me.DateTimePicker3.Value.Date)
                cmm2.Parameters.AddWithValue("@doctorname", Me.Label4.Text)
                cmm2.Parameters.AddWithValue("@IDM", Me.Label8.Text)
                cmm2.Parameters.AddWithValue("@EJRAA", Me.ComboBox3.Text)
                cmm2.Parameters.AddWithValue("@Esalno", M6)
                cmm2.Parameters.AddWithValue("@USER_NAME", user)
                'Try
                ' cmm.ExecuteNonQuery()
                cmm2.ExecuteNonQuery()
                Dim ssD As String = "insert into Amaleat_M(IDA,docn,dock,tdocn,tdock,mdocn,mdock,fdocn,fdock,ftdocn,ftdock,tahn,tahk,kabn,kabk,cdocn,cdock,aml_kema,C_KEMA,DATEX,ESALNO)values(@IDA,@docn,@dock,@tdocn,@tdock,@mdocn,@mdock,@fdocn,@fdock,@ftdocn,@ftdock,@tahn,@tahk,@kabn,@kabk,@cdocn,@cdock,@aml_kema,@C_KEMA,@DATEX,@ESALNO)"
                Using cmmD As New SqlClient.SqlCommand(ssD, cn)
                    cmmD.Parameters.AddWithValue("@IDA", CInt(Label15.Text))
                    cmmD.Parameters.AddWithValue("@docn", CInt(Label4.Text))
                    cmmD.Parameters.AddWithValue("@dock", CDbl(TextBox6.Text))
                    cmmD.Parameters.AddWithValue("@tdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@tdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@mdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@mdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@fdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@fdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@ftdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@ftdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@tahn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@tahk", CDbl(0))
                    cmmD.Parameters.AddWithValue("@kabn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@kabk", CDbl(0))
                    cmmD.Parameters.AddWithValue("@cdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@cdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@aml_kema", CDbl(TextBox5.Text))
                    cmmD.Parameters.AddWithValue("@C_KEMA", CDbl(0))
                    cmmD.Parameters.AddWithValue("@DATEX", Date.Today.Date)
                    cmmD.Parameters.AddWithValue("@ESALNO", M6)
                    'TextBox9.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
                    Try
                        If Trim(ComboBox3.Text) = Trim("عمليات") Then
                            cmmD.ExecuteNonQuery()
                        End If
                    Catch ex As Exception

                    End Try
                End Using

                Dim Str1 As String = "SELECT MAX(ESALNO) FROM KASHEF "
                Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
                M6 = cmd1.ExecuteScalar
                If KHAZENAXX = False Then

                    '==========================================================================
                    '            Dim crtableLogoninfos As New TableLogOnInfos()
                    '            Dim crtableLogoninfo As New TableLogOnInfo()
                    '            Dim crConnectionInfo As New ConnectionInfo()
                    '            Dim CrTables As Tables
                    '            Dim CrTable As Table
                    '            Dim TableCounter
                    '            Dim reader As New System.IO.StreamReader("server.txt")
                    '            Dim allLines As List(Of String) = New List(Of String)
                    '            Do While Not reader.EndOfStream
                    '                allLines.Add(reader.ReadLine())
                    '            Loop
                    '            reader.Close()
                    '            Dim crReportDocument As New CrystalReport30(), cri2 As String
                    '            crReportDocument.Load("CrystalReport30.rpt")
                    '            cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
                    '            KESEM_P = TextBox8.Text
                    '            NAMEC = My.Settings.CLIN
                    '            With crConnectionInfo
                    '                .ServerName = ReadLine(2, allLines)
                    '                .DatabaseName = ReadLine(1, allLines)
                    '                .UserID = "AH"
                    '                .Password = "123456"
                    '            End With
                    '            CrTables = crReportDocument.Database.Tables
                    '            For Each CrTable In CrTables
                    '                crtableLogoninfo = CrTable.LogOnInfo
                    '                crtableLogoninfo.ConnectionInfo =
                    'crConnectionInfo
                    '                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                    '                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
                    'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
                    '            Next
                    '            crReportDocument.SetParameterValue(0, Me.KESEM_P)
                    '            crReportDocument.SetParameterValue(1, Me.NAMEC)
                    '            crReportDocument.RecordSelectionFormula = cri2
                    '            crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
                    '            crReportDocument.PrintToPrinter(1, True, 0, 0)
                    '            crReportDocument.Close()
                    '            crReportDocument.Dispose()
                    '            Call Class4.CONNIC()
                    '            Dim crtableLogoninfos As New TableLogOnInfos()
                    '            Dim crtableLogoninfo As New TableLogOnInfo()
                    '            Dim crConnectionInfo As New ConnectionInfo()
                    '            Dim CrTables As Tables
                    '            Dim CrTable As Table
                    '            Dim TableCounter
                    '            Dim reader As New System.IO.StreamReader("server.txt")
                    '            Dim allLines As List(Of String) = New List(Of String)
                    '            Do While Not reader.EndOfStream
                    '                allLines.Add(reader.ReadLine())
                    '            Loop
                    '            reader.Close()
                    '            Dim crReportDocument As New Esalmaly(), cri2 As String
                    '            crReportDocument.Load("Esalmaly.rpt")
                    '            namexx = Trim(ComboBox5.Text)
                    '            KESEM_P = Label23.Text
                    '            NAMEC = My.Settings.CLIN
                    '            kemaxxx = HANY(TextBox28.Text, "IRAQ")
                    '            esalnox = M6
                    '            kemaxx = TextBox28.Text
                    '            With crConnectionInfo
                    '                .ServerName = ReadLine(2, allLines)
                    '                .DatabaseName = ReadLine(1, allLines)
                    '                .UserID = "AH"
                    '                .Password = "123456"
                    '            End With
                    '            CrTables = crReportDocument.Database.Tables
                    '            For Each CrTable In CrTables
                    '                crtableLogoninfo = CrTable.LogOnInfo
                    '                crtableLogoninfo.ConnectionInfo =
                    'crConnectionInfo
                    '                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                    '                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
                    'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
                    '            Next
                    '            crReportDocument.SetParameterValue(0, Me.KESEM_P)
                    '            crReportDocument.SetParameterValue(1, Me.NAMEC)
                    '            crReportDocument.SetParameterValue(2, Me.namexx)
                    '            crReportDocument.SetParameterValue(3, Me.phonex)
                    '            crReportDocument.SetParameterValue(4, Me.kemaxxx)
                    '            crReportDocument.SetParameterValue(5, Me.esalnox)
                    '            crReportDocument.SetParameterValue(6, Me.kemaxx)
                    '            'crReportDocument.RecordSelectionFormula = cri2
                    '            crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
                    '            crReportDocument.PrintToPrinter(1, True, 0, 0)
                    '            crReportDocument.Close()
                    '            crReportDocument.Dispose()
                    Dim crtableLogoninfos As New TableLogOnInfos()
                    Dim crtableLogoninfo As New TableLogOnInfo()
                    Dim crConnectionInfo As New ConnectionInfo()
                    Dim CrTables As Tables
                    Dim CrTable As Table
                    Dim TableCounter
                    Dim reader As New System.IO.StreamReader("server.txt")
                    Dim allLines As List(Of String) = New List(Of String)
                    Do While Not reader.EndOfStream
                        allLines.Add(reader.ReadLine())
                    Loop
                    reader.Close()
                    Dim crReportDocument As New CrystalReport31(), cri2 As String
                    crReportDocument.Load("CrystalReport31.rpt")
                    cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
                    KESEM_P = TextBox8.Text
                    NAMEC = My.Settings.CLIN
                    With crConnectionInfo
                        .ServerName = ReadLine(2, allLines)
                        .DatabaseName = ReadLine(1, allLines)
                        .UserID = "AH"
                        .Password = "123456"
                    End With
                    CrTables = crReportDocument.Database.Tables
                    For Each CrTable In CrTables
                        crtableLogoninfo = CrTable.LogOnInfo
                        crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                        CrTable.ApplyLogOnInfo(crtableLogoninfo)
                        CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
                    Next
                    crReportDocument.SetParameterValue(0, Me.KESEM_P)
                    crReportDocument.SetParameterValue(1, Me.NAMEC)
                    crReportDocument.RecordSelectionFormula = cri2
                    crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
                    crReportDocument.PrintToPrinter(1, True, 0, 0)
                    crReportDocument.Close()
                    crReportDocument.Dispose()

                    '-----------------------------------------------------------------------------------
                    reader.Close()

                    '==========================================================================

                    'Dim cr2 As New CrystalReport30, cri2 As String
                    'cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
                    'KESEM_P = TextBox8.Text
                    ''Dim RM As Resources.ResourceManager
                    ''RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                    ''NAMEC = RM.GetString("NAMECLINIC")
                    'NAMEC = My.Settings.CLIN
                    'cr2.SetParameterValue(0, Me.KESEM_P)
                    'cr2.SetParameterValue(1, Me.NAMEC)
                    'cr2.SetDatabaseLogon("ah", "123456", "server\SQLEXPRESS", "clinicsql")
                    'cr2.RecordSelectionFormula = cri2
                    ''cr2.PrintOptions.PrinterName = "PR"
                    ''cr2.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "c:\customer_status.pdf")
                    'cr2.PrintToPrinter(1, True, 0, 0)
                    'cr2.Close()
                    'cr2.Dispose()
                Else
                    '-----------------------------------------------------------------------------------
                    Dim crtableLogoninfos As New TableLogOnInfos()
                    Dim crtableLogoninfo As New TableLogOnInfo()
                    Dim crConnectionInfo As New ConnectionInfo()
                    Dim CrTables As Tables
                    Dim CrTable As Table
                    Dim TableCounter
                    Dim reader As New System.IO.StreamReader("server.txt")
                    Dim allLines As List(Of String) = New List(Of String)
                    Do While Not reader.EndOfStream
                        allLines.Add(reader.ReadLine())
                    Loop
                    reader.Close()
                    Dim crReportDocument As New CrystalReport31(), cri2 As String
                    crReportDocument.Load("CrystalReport31.rpt")
                    cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
                    KESEM_P = TextBox8.Text
                    NAMEC = My.Settings.CLIN
                    With crConnectionInfo
                        .ServerName = ReadLine(2, allLines)
                        .DatabaseName = ReadLine(1, allLines)
                        .UserID = "AH"
                        .Password = "123456"
                    End With
                    CrTables = crReportDocument.Database.Tables
                    For Each CrTable In CrTables
                        crtableLogoninfo = CrTable.LogOnInfo
                        crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                        CrTable.ApplyLogOnInfo(crtableLogoninfo)
                        CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
                    Next
                    crReportDocument.SetParameterValue(0, Me.KESEM_P)
                    crReportDocument.SetParameterValue(1, Me.NAMEC)
                    crReportDocument.RecordSelectionFormula = cri2
                    crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
                    crReportDocument.PrintToPrinter(1, True, 0, 0)
                    crReportDocument.Close()
                    crReportDocument.Dispose()

                    '-----------------------------------------------------------------------------------
                    reader.Close()
                    '            Dim crReportDocument1 As New CrystalReport30(), cri1 As String
                    '            crReportDocument1.Load("CrystalReport30.rpt")
                    '            cri1 = "{KASHEF.ESALNO}=" & "" & M6 & ""
                    '            KESEM_P = TextBox8.Text
                    '            NAMEC = My.Settings.CLIN
                    '            With crConnectionInfo
                    '                .ServerName = ReadLine(2, allLines)
                    '                .DatabaseName = ReadLine(1, allLines)
                    '                .UserID = "AH"
                    '                .Password = "123456"
                    '            End With
                    '            CrTables = crReportDocument1.Database.Tables
                    '            For Each CrTable In CrTables
                    '                crtableLogoninfo = CrTable.LogOnInfo
                    '                crtableLogoninfo.ConnectionInfo =
                    'crConnectionInfo
                    '                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                    '                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
                    'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
                    '            Next
                    '            crReportDocument1.SetParameterValue(0, Me.KESEM_P)
                    '            crReportDocument1.SetParameterValue(1, Me.NAMEC)
                    '            crReportDocument1.RecordSelectionFormula = cri1
                    '            crReportDocument1.PrintOptions.PrinterName = My.Settings.printerx2
                    '            crReportDocument1.PrintToPrinter(1, True, 0, 0)
                    '            crReportDocument1.Close()
                    '            crReportDocument1.Dispose()
                    Dim crReportDocument1 As New Esalmaly(), cri1 As String
                    crReportDocument1.Load("Esalmaly.rpt")
                    namexx = Trim(ComboBox1.Text)
                    KESEM_P = ComboBox3.Text
                    NAMEC = My.Settings.CLIN
                    kemaxxx = HANY(TextBox10.Text, "IRAQ")
                    esalnox = M6
                    If String.IsNullOrWhiteSpace(TextBox24.Text) Then
                        phonex = "لا يوجد"
                    Else
                        phonex = TextBox24.Text
                    End If
                    kemaxx = TextBox10.Text
                    With crConnectionInfo
                        .ServerName = ReadLine(2, allLines)
                        .DatabaseName = ReadLine(1, allLines)
                        .UserID = "AH"
                        .Password = "123456"
                    End With
                    CrTables = crReportDocument1.Database.Tables
                    For Each CrTable In CrTables
                        crtableLogoninfo = CrTable.LogOnInfo
                        crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                        CrTable.ApplyLogOnInfo(crtableLogoninfo)
                        CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
                    Next
                    crReportDocument1.SetParameterValue(0, Me.KESEM_P)
                    crReportDocument1.SetParameterValue(1, Me.NAMEC)
                    crReportDocument1.SetParameterValue(2, Me.namexx)
                    crReportDocument1.SetParameterValue(3, Me.phonex)
                    crReportDocument1.SetParameterValue(4, Me.kemaxxx)
                    crReportDocument1.SetParameterValue(5, Me.esalnox)
                    crReportDocument1.SetParameterValue(6, Me.kemaxx)
                    'crReportDocument1.RecordSelectionFormula = cri2
                    crReportDocument1.PrintOptions.PrinterName = My.Settings.printerx2
                    crReportDocument1.PrintToPrinter(2, True, 0, 0)
                    crReportDocument1.Close()
                    crReportDocument1.Dispose()

                    '------------------------------------------------------------------------------------

                    'Dim cr1 As New CrystalReport31, cri As String
                    'cri = "{KASHEF.ESALNO}=" & "" & M6 & ""
                    'KESEM_P = TextBox8.Text
                    'NAMEC = My.Settings.CLIN
                    'cr1.SetParameterValue(0, Me.KESEM_P)
                    'cr1.SetParameterValue(1, Me.NAMEC)
                    'cr1.RecordSelectionFormula = cri
                    'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
                    'cr1.PrintOptions.PrinterName = "PR"
                    'cr1.PrintToPrinter(1, True, 0, 0)
                    'cr1.Close()
                    'cr1.Dispose()
                    'Dim cr2 As New CrystalReport30, cri2 As String
                    'cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
                    'KESEM_P = TextBox8.Text
                    ''Dim RM As Resources.ResourceManager
                    ''RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                    ''NAMEC = RM.GetString("NAMECLINIC")
                    'NAMEC = My.Settings.CLIN
                    'cr2.SetParameterValue(0, Me.KESEM_P)
                    'cr2.SetParameterValue(1, Me.NAMEC)
                    'cr2.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
                    'cr2.RecordSelectionFormula = cri2
                    'cr2.PrintOptions.PrinterName = "PR"
                    ''cr2.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "c:\customer_status.pdf")
                    'cr2.PrintToPrinter(1, True, 0, 0)
                    'cr2.Close()
                    'cr2.Dispose()

                End If
                Me.Label13.Text = ""
                Me.TextBox15.Text = ""

                'MsgBox("تم الحفظ ")
                Me.TextBox3.Enabled = False
                Me.ComboBox1.Enabled = False
                'Me.ComboBox3.Enabled = False
                Me.ComboBox4.Enabled = False
                Me.DateTimePicker3.Enabled = False
                Me.DateTimePicker3.Value = Date.Today
                Me.DateTimePicker1.Value = Date.Today
                Me.DateTimePicker2.Value = Date.Today
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.Label5.Text = ""
                Me.Label16.Text = ""
                Me.Label9.Text = ""
                Me.ComboBox1.Text = ""
                Me.ComboBox3.Text = ""
                Me.ComboBox4.Text = ""
                Me.ComboBox2.Text = ""
                Me.ComboBox1.Text = ""
                Me.ComboBox2.Text = ""
                Me.NumericUpDown1.Value = 0
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                'Me.MaskedTextBox1.Text = ""
                'Me.MaskedTextBox2.Text = ""
                'Me.MaskedTextBox3.Text = ""
                DataGridView1.Rows.Clear()
                Me.TextBox3.Focus()
                Me.ComboBox1.Enabled = False
                Me.DateTimePicker3.Enabled = False
                ' Me.ComboBox2.Enabled = False
                DGV1()



                'Dim s16 As String = "select * from APPOINTMENTVIEW "
                'Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                'Dim dss As New DataSet
                'dss.Clear()
                'aad.Fill(dss, "APPOINTMENTVIEW")
                'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
                'vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
                ''vd.RowFilter = "doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
                'Me.DataGridView1.DataMember = ""
                'DataGridView1.DataSource = vd


                '    Catch ex As Exception
                '    MsgBox(" لايمكن الحفظ ")
                'End Try
                'Try

                'Catch ex As Exception
                '    MessageBox.Show(ex.Message)
                '    'Throw ex
                '    'MsgBox("no print")
                'End Try

            End Using

            'Catch ex As Exception
            '    MsgBox(" لايمكن الحفظ ")
            'End Try
            GroupBox15.Visible = False
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox2_DisplayMemberChanged(sender As Object, e As EventArgs) Handles ComboBox2.DisplayMemberChanged

    End Sub

    Private Sub ComboBox2_Disposed(sender As Object, e As EventArgs) Handles ComboBox2.Disposed
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!id
            End If
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=x@xx1 and dn=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("x@xx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
        End Using
        'end using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.Button2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_Leave(sender As Object, e As EventArgs) Handles ComboBox2.Leave
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = CInt(rdn20!idD)
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'Dim sn2 As String = "select * from dn where dn=@xx1 "
        'Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
        '    cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
        '    Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
        '    If rdn2.Read = True Then
        '        Me.Label4.Text = rdn2!idd
        '        M7 = rdn2!IDD
        '        Dim sk18 As String
        '        sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
        '        Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
        '        Dim dsk18 As New DataSet
        '        adk18.Fill(dsk18, "Amaleat")
        '        ComboBox5.DataSource = dsk18.Tables(0)
        '        ComboBox5.DisplayMember = "AML_NAME"
        '    End If
        'End Using
        'end using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox2_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles ComboBox2.PreviewKeyDown

    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text <> "" Then
            Call Class1.CONNIC()
            'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
            'Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            '    cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            '    cmn0.Parameters.AddWithValue("@idk", B)
            '    Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            '    If rdn0.Read = True Then
            '        Me.Label2.Text = rdn0!idJ
            '    End If
            '    rdn0.Close()
            'End Using

            'Dim sn2 As String = "select * from DOCTORK where dn=@xxx1 "
            'Using cmn2z As New SqlClient.SqlCommand(sn2, cn)
            '    cmn2z.Parameters.AddWithValue("@xxx1", ComboBox2.Text)
            '    Dim rdn2z As SqlClient.SqlDataReader = cmn2z.ExecuteReader
            '    If rdn2z.Read = True Then
            '        Me.Label4.Text = rdn2z!IDD
            '        M7 = rdn2z!IDD
            '        Me.Label14.Text = rdn2z!KESEM
            '        Dim sk18 As String
            '        sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
            '        Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            '        Dim dsk18 As New DataSet
            '        adk18.Fill(dsk18, "Amaleat")
            '        ComboBox5.DataSource = dsk18.Tables(0)
            '        ComboBox5.DisplayMember = "AML_NAME"
            '    End If
            '    rdn2z.Close()
            'End Using
            'Dim sk18 As String
            'sk18 = "select * from Amaleat" ' where DOCN=" & 895
            'Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            'Dim dsk18 As New DataSet
            'adk18.Fill(dsk18, "Amaleat")
            'ComboBox5.DataSource = dsk18.Tables(0)
            'ComboBox5.DisplayMember = "AML_NAME"
            Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
            Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
                cmn10.Parameters.AddWithValue("@Xxx1", Label2.Text)
                cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
                Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
                If rdn10.Read = True Then
                    Me.TextBox6.Text = CDbl(rdn10!kema)
                    Me.TextBox5.Text = CDbl(rdn10!kemaej)
                    Me.Label13.Text = CDbl(rdn10!kemaej)
                    Me.TextBox11.Text = CDbl(rdn10!kemaej)
                    Me.TextBox10.Text = CDbl(0)
                End If
                rdn10.Close()
            End Using
            DGV1()

            'Dim s1 As String = "select * from APPOINTMENTVIEW "
            'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            'Dim dss As New DataSet
            'dss.Clear()
            'aad.Fill(dss, "APPOINTMENTVIEW")
            'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
            'vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
            'Me.DataGridView1.DataMember = ""
            'DataGridView1.DataSource = vd
            'Dim sn2 As String = "select * from DOCTORK where dn=@xxx1 "
            'Using cmn2z As New SqlClient.SqlCommand(sn2, cn)
            '    cmn2z.Parameters.AddWithValue("@xxx1", ComboBox2.Text)
            '    Dim rdn2z As SqlClient.SqlDataReader = cmn2z.ExecuteReader
            '    If rdn2z.Read = True Then
            '        Me.Label4.Text = rdn2z!IDD
            '        M7 = rdn2z!IDD
            '        Me.Label14.Text = rdn2z!KESEM
            '        Dim sk18 As String
            '        sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
            '        Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            '        Dim dsk18 As New DataSet
            '        adk18.Fill(dsk18, "Amaleat")
            '        ComboBox5.DataSource = dsk18.Tables(0)
            '        ComboBox5.DisplayMember = "AML_NAME"
            '    End If
            '    rdn2z.Close()
            'End Using
            Dim sn2 As String = "select * from dn where dn=@xx1 "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label4.Text = rdn2!idd
                    M7 = rdn2!IDD
                    rdn2.Close()
                    Dim sk18 As String
                    sk18 = "select * from AM_VIEW where IDD='" & CInt(Label4.Text) & "' "
                    Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
                    Dim dsk18 As New DataSet
                    adk18.Fill(dsk18, "AM_VIEW")
                    ComboBox5.DataSource = dsk18.Tables(0)
                    ComboBox5.DisplayMember = "AMl_NAME"
                End If
                rdn2.Close()
            End Using
            Dim a As Integer
            Call Class1.CONNIC()
            Dim sG As String = "select * from KESEM where KESEM=@xx1 "
            Using cmG As New SqlClient.SqlCommand(sG, cn)
                cmG.Parameters.AddWithValue("@xx1", TextBox8.Text)
                Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
                If rdG.Read = True Then
                    a = rdG!IDK
                End If
                rdG.Close()
            End Using
            Dim sk23 As String
            sk23 = "select * from Ejraa where IDK=" & a
            Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
                Dim dsk23 As New DataSet
                adk23.Fill(dsk23, "Ejraa")
                ComboBox3.DataSource = dsk23.Tables(0)
                ComboBox3.DisplayMember = "Ejraa"
                'ComboBox3.SelectedIndex = -1
            End Using
            Call Class4.CONNIC()
        End If

    End Sub

    Private Sub ComboBox4_GotFocus(sender As Object, e As EventArgs) Handles ComboBox4.GotFocus
        'الكتابه بالعربيه
        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            If Lng.Culture.DisplayName.ToUpper.StartsWith("AR") Then
                InputLanguage.CurrentInputLanguage = Lng
                Exit For
            End If
        Next
    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Class1.CONNIC()
            Dim s1 As String = "select * from Mostafeed where namem=@namem"
            Using cm1 As New SqlClient.SqlCommand(s1, cn)
                cm1.Parameters.AddWithValue("@namem", Trim(Me.ComboBox4.Text))
                Dim rd1 As SqlClient.SqlDataReader = cm1.ExecuteReader
                If rd1.Read = True Then
                    TextBox4.Text = rd1!JehaM
                    ComboBox4.Text = rd1!NameM
                    rd1.Close()
                Else
                    MsgBox("المستفيد غير موجود...سيتم نقلك إلى واجهة المستفيد")
                    Dim fn As New Mostafeed
                    dgx = Trim(ComboBox4.Text)
                    Most = True
                    fn.ShowDialog()
                    Most = False
                    Dim sk4 As String
                    sk4 = "select * from Mostafeed"
                    Dim adk4 As New SqlClient.SqlDataAdapter(sk4, cn)
                    Dim dsk4 As New DataSet
                    adk4.Fill(dsk4, "Mostafeed")
                    ComboBox4.DataSource = dsk4.Tables(0)
                    ComboBox4.DisplayMember = "NameM"
                    ComboBox4.SelectedIndex = -1
                    ComboBox4.Text = namemx
                    Label9.Text = jehamx
                    TextBox4.Text = jehamx
                End If
            End Using

            'Dim s As String = "select * from Mostafeed where NameM='" & "@namem" & "or idm='" & "@idm"
            'Using cm As New SqlClient.SqlCommand("select * from Mostafeed where NameM=@namem or idm=@idm", cn)
            '    cm.Parameters.AddWithValue("@namem", Me.ComboBox4.Text)
            '    cm.Parameters.AddWithValue("@idm", Me.ComboBox4.Text)
            '    Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            '    If rd.Read = True Then
            '        TextBox4.Text = rd!JehaM
            '        ComboBox4.Text = rd!NameM
            '        rd.Close()
            '    Else
            '        Dim s1 As String = "select * from Mostafeed where IDM=@xxxxx1"
            '        Using cm1 As New SqlClient.SqlCommand(s1, cn)
            '            cm1.Parameters.AddWithValue("@xxxxx1", Me.ComboBox4.Text)
            '            Dim rd1 As SqlClient.SqlDataReader = cm1.ExecuteReader
            '            If rd1.Read = True Then
            '                TextBox4.Text = rd1!JehaM
            '                ComboBox4.Text = rd1!NameM
            '                rd1.Close()
            '            Else
            '                MsgBox("المستفيد غير موجود...سيتم نقلك إلى واجهة المستفيد")
            '                Dim fn As New Mostafeed
            '                dgx = Trim(ComboBox4.Text)
            '                Most = True
            '                fn.ShowDialog()
            '                Most = False
            '            End If
            '        End Using
            '        MsgBox("المستفيد غير موجود...سيتم نقلك إلى واجهة المستفيد")
            '        Dim f As New Mostafeed
            '        dgx = Trim(ComboBox4.Text)
            '        Most = True
            '        f.ShowDialog()
            '        Most = False

            '        'end using
            '    End If
            'End Using
            '        'End Using
            '        ComboBox1.Focus()
            ComboBox1.Focus()
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub ComboBox4_Leave(sender As Object, e As EventArgs) Handles ComboBox4.Leave
        Call Class1.CONNIC()
        Dim s1 As String = "select * from Mostafeed where namem=@namem"
        Using cm1 As New SqlClient.SqlCommand(s1, cn)
            cm1.Parameters.AddWithValue("@namem", Trim(Me.ComboBox4.Text))
            Dim rd1 As SqlClient.SqlDataReader = cm1.ExecuteReader
            If rd1.Read = True Then
                TextBox4.Text = rd1!JehaM
                ComboBox4.Text = rd1!NameM
                rd1.Close()
            Else
                MsgBox("المستفيد غير موجود...سيتم نقلك إلى واجهة المستفيد")
                Dim fn As New Mostafeed
                dgx = Trim(ComboBox4.Text)
                Most = True
                fn.ShowDialog()
                Most = False
                Dim sk4 As String
                sk4 = "select * from Mostafeed"
                Dim adk4 As New SqlClient.SqlDataAdapter(sk4, cn)
                Dim dsk4 As New DataSet
                adk4.Fill(dsk4, "Mostafeed")
                ComboBox4.DataSource = dsk4.Tables(0)
                ComboBox4.DisplayMember = "NameM"
                ComboBox4.SelectedIndex = -1
                ComboBox4.Text = namemx
                Label9.Text = jehamx
                TextBox4.Text = jehamx
            End If
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

        If ComboBox4.Text = "" Then
            Label9.Text = ""
        Else
            Call Class1.CONNIC()
            Dim s As String = "select * from Mostafeed where NameM=@xx1"
            Using cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@xx1", Me.ComboBox4.Text)
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    TextBox4.Text = rd!JehaM
                    Label9.Text = rd!JehaM
                    Label8.Text = rd!IDM
                End If
                rd.Close()
            End Using
            'end using
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TextBox23.Text = B
        If ComboBox2.Text = "" Then
            MsgBox("يرجى تحديد اسم الطبيب")
        Else
            'Else
            'If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            If Double.Parse(Label13.Text) = 0 Then
                GroupBox15.Visible = True
            Else
                GroupBox15.Visible = False
            End If
            Label21.Text = ""
            Label21.BackColor = Color.Transparent
            Timer2.Stop()
            Me.ComboBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox16.Text = ""
            Me.NumericUpDown1.Value = 0
            'Me.TextBox2.Text = ""
            DataGridView1.Rows.Clear()
            Me.TextBox3.Text = ""
            Me.TextBox3.Focus()
            Me.ComboBox1.Enabled = True
            Me.ComboBox3.Enabled = True
            Me.ComboBox4.Enabled = True
            Me.DateTimePicker3.Enabled = True
            'Me.ComboBox2.Enabled = True
            'Me.Button2.Enabled = True
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button2.Visible = True
            Label5.Text = ""
            Label16.Text = ""
            Label9.Text = ""
            ComboBox4.Text = ""
            If ComboBox3.Text = "" Then
                ComboBox3.Text = "كشف"
            End If
            ComboBox4.Text = "نقدا"
            TextBox4.Text = "نقدا"
            Label9.Text = "نقدا"
            If Me.TextBox3.Text = "" Then
                Me.Label1.Text = 1
                Call Class1.CONNIC()
                Dim Str As String = "SELECT MAX(CHNO) FROM appointment WHERE datea=@xx2 and doctorname=@xx3"
                Using cmd As New SqlClient.SqlCommand(Str, cn)
                    cmd.Parameters.AddWithValue("@xx2", Date.Today)
                    cmd.Parameters.AddWithValue("@xx3", Me.Label4.Text)
                    If IsDBNull(cmd.ExecuteScalar) = True Then
                        Me.Label1.Text = 1
                    Else
                        Label1.Text = Val(cmd.ExecuteScalar) + 1
                    End If
                End Using

                'Dim k As Integer = 1
                'Do While k < 100
                '    Dim i As Integer
                '    i = 1
                '    Me.Label1.Text = i
                '    Dim s As String = "select * from appointment where chno=@xx1 and datea=@xx2 and doctorname=@xx3 "
                '    dim cm As New SqlClient.SqlCommand(s, cn)
                '        cm.Parameters.AddWithValue("@xx1", i)
                '        cm.Parameters.AddWithValue("@xx2", Date.Today)
                '        cm.Parameters.AddWithValue("@xx3", Me.ComboBox2.Text)
                '        dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                '            Do While rd.Read = True
                '                i = i + 1
                '                rd.Close()
                '                Dim ss As String = "select * from appointment where chno=@xx1 and datea=@xx2 and doctorname=@xx3 "
                '                dim cmm As New SqlClient.SqlCommand(ss, cn)
                '                    cmm.Parameters.AddWithValue("@xx1", i)
                '                    cmm.Parameters.AddWithValue("@xx2", Date.Today)
                '                    cmm.Parameters.AddWithValue("@xx3", Me.ComboBox2.Text)
                '                    rd = cmm.ExecuteReader
                '                    Me.Label1.Text = i
                '                'end using

                '            Loop


                '            rd.Close()
                '            k = k + 1
                '        'end using
                '    'end using
                'Loop
                Me.TextBox3.Text = Me.Label1.Text
                Me.Label5.Text = Me.Label1.Text
                'Me.Label16.Text = "| " & Me.Label1.Text & " |"
                Me.Label16.Text = Trim(Me.Label1.Text)
                Me.NumericUpDown1.Text = Me.TextBox3.Text
                Me.TextBox10.Text = CDbl(Label13.Text)
                'Me.TextBox10.Text = Val(TextBox15.Text)
                Me.ComboBox1.Focus()
                Call Class4.CONNIC()
            End If
        End If
        DataGridView2.DataSource = ""
        'GroupBox1.Width = 1328
        DateTimePicker1.Value = Date.Today.Date
        DateTimePicker2.Value = Date.Today.Date
        DateTimePicker3.Value = Date.Today.Date
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ComboBox1.Text = ""
        Me.NumericUpDown1.Value = 0
        Me.TextBox2.Text = ""
        DataGridView1.Rows.Clear()
        Me.TextBox3.Text = ""
        Me.TextBox3.Focus()
        Me.ComboBox1.Enabled = True
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = True
        Me.DateTimePicker3.Enabled = True
        Me.ComboBox2.Enabled = True
        Me.Button2.Enabled = True
        If Me.TextBox3.Text = "" Then
            Call Class1.CONNIC()
            Dim Str As String = "SELECT MAX(CHNO) FROM appointment WHERE datea=" & Date.Today.Date & " and doctorname=" & ComboBox2.Text
            Dim cmd As New SqlClient.SqlCommand(Str, cn)
            Label1.Text = cmd.ExecuteScalar
            'end using
            'Dim k As Integer = 1
            'Do While k < 100
            '    Dim i As Integer
            '    i = 1
            '    Me.Label1.Text = i
            '    Dim s As String = "select * from appointment where chno=@@xx1 and datea=@xx2 and doctorname=@xx3 "
            '    dim cm As New SqlClient.SqlCommand(s, cn)
            '        cm.Parameters.AddWithValue("@@xx1", i)
            '        cm.Parameters.AddWithValue("@xx2", Date.Today)
            '        cm.Parameters.AddWithValue("@xx3", Me.ComboBox2.Text)
            '        dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            '            Do While rd.Read = True
            '                i = i + 1
            '                Dim ss As String = "select * from appointment where chno=@@xx1 and datea=@xx2 and doctorname=@xx3 "
            '                dim cmm As New SqlClient.SqlCommand(ss, cn)
            '                    cmm.Parameters.AddWithValue("@@xx1", i)
            '                    cmm.Parameters.AddWithValue("@xx2", Date.Today)
            '                    cmm.Parameters.AddWithValue("@xx3", Me.ComboBox2.Text)
            '                    rd = cmm.ExecuteReader
            '                    Me.Label1.Text = i
            '                'end using
            '            Loop
            '            rd.Close()
            '            k = k + 1
            '        'end using
            '    'end using

            'Loop


            Me.TextBox3.Text = Me.Label1.Text
            'Me.Label5.Text = Me.Label1.Text
            'Me.Label16.Text = "( " & Me.Label1.Text & " )"
            Me.NumericUpDown1.Text = Me.TextBox3.Text
            Me.ComboBox1.Focus()
            Call Class4.CONNIC()
        End If

    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus
        'الكتابه بالعربيه
        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            If Lng.Culture.DisplayName.ToUpper.StartsWith("AR") Then
                InputLanguage.CurrentInputLanguage = Lng
                Exit For
            End If
        Next
        'الكتابه بالانجليزي
        'For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
        '    If Lng.Culture.DisplayName.ToUpper.StartsWith("EN") Then
        '        InputLanguage.CurrentInputLanguage = Lng
        '    End If
        '    Exit For
        'Next
    End Sub

    Private Sub ComboBox1_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        'Dim allowedChars As String = "0123456789"
        'If allowedChars.IndexOf(e.KeyChar) <> -1 Then
        '    ' Invalid NUMBER
        '    e.Handled = True
        'End If
        'If Char.IsDigit(e.KeyChar) = True And Char.IsControl(e.KeyChar) = False Then
        '    e.Handled = True
        'End If
        'If e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso e.KeyChar <> ControlChars.Back Then
        '    e.Handled = True
        'End If
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Class1.CONNIC()
            Dim s As String = "select * from main where namex=@xxx1 "
            Using cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@xxx1", ComboBox1.Text)
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    Me.TextBox2.Text = rd!fnumber
                    rd.Close()
                End If
                'end using
            End Using

            If Val(Me.ComboBox1.Text) = 0 Then

            End If
            Dim sn As String = "select * from main where fnumber=@xxx1 "
            Using cmn As New SqlClient.SqlCommand(sn, cn)
                cmn.Parameters.AddWithValue("@xxx1", Val(ComboBox1.Text))
                Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
                If rdn.Read = True Then
                    Me.ComboBox1.Text = rdn!namex
                    rdn.Close()
                    'Else
                    '    m5 = 1
                    '    Dim k As Integer = 0
                    '    Do While k < 100
                    '        Dim i As Integer
                    '        i = m5
                    '        Dim s2 As String = "select * from main where fnumber=@xxx1"
                    '        Dim cm1 As New SqlClient.SqlCommand(s2, cn)
                    '        cm1.Parameters.AddWithValue("@xxx1", i)
                    '        Dim rd1 As SqlClient.SqlDataReader
                    '        rd1 = cm1.ExecuteReader
                    '        Do While rd1.Read = True
                    '            i = i + 1
                    '            Dim ss1 As String = "select * from main where fnumber=@xx1"
                    '            Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
                    '            cmm1.Parameters.AddWithValue("@xx1", i)
                    '            rd1 = cmm1.ExecuteReader
                    '            m5 = i
                    '        Loop
                    '        rd1.Close()
                    '        k = k + 1
                    '    Loop
                    '    Me.TextBox2.Text = m5
                End If
                'End If
            End Using
            'end using
            DGV1()
            'Dim s1 As String = "select * from APPOINTMENTVIEW "
            'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            'Dim dss As New DataSet
            'dss.Clear()
            'aad.Fill(dss, "APPOINTMENTVIEW")
            'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
            'vd.RowFilter = "fnumber=" & "'" & TextBox2.Text & "'" & ""
            'Me.DataGridView1.DataMember = ""
            'DataGridView1.DataSource = vd
            TextBox24.Focus()
            'end using
            'end using
            'end using
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'If Trim(ComboBox1.Text) = Trim("") Then
        '    Button2.Enabled = False
        'Else
        '    Dim s As String = "select * from main where namex=@xx1"
        '    Using cm As New SqlClient.SqlCommand(s, cn)
        '        cm.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
        '        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        '        If rd.Read = True Then
        '            Me.TextBox2.Text = rd!fnumber
        '            Me.ComboBox1.Text = Trim(rd!namex)
        '            rd.Close()
        '        Else
        '            Me.TextBox2.Text = ""
        '        End If
        '        rd.Close()
        '    End Using
        '    'Dim skk As String = "select * from kashef where fnumber=@fnumber and doctorname=@doctorname and baky<>@baky AND CONF=@CONF "
        '    Dim skk As String = "select * from kashef where fnumber=@fnumber and baky<>@baky AND CONF=@CONF "
        '    Using cmkk As New SqlClient.SqlCommand(skk, cn)
        '        cmkk.Parameters.AddWithValue("@fnumber", Trim(TextBox2.Text))
        '        'cmkk.Parameters.AddWithValue("@doctorname", ComboBox2.Text)
        '        cmkk.Parameters.AddWithValue("@baky", CDbl(0))
        '        cmkk.Parameters.AddWithValue("@CONF", True)
        '        Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
        '            If rdkk.Read = True Then
        '                Label18.Text = CInt(rdkk!Esalno)
        '                'Label13.Text = CDbl(rdkk!kemat)
        '                'TextBox10.Text = CDbl(rdkk!madfoo)
        '                'TextBox16.Text = CDbl(rdkk!madfoo)
        '                'TextBox11.Text = CDbl(rdkk!baky)
        '                Label21.Text = CDbl(rdkk!baky)
        '                Timer2.Start()
        '            Else
        '                Label21.Text = ""
        '                Label21.BackColor = Color.Transparent
        '                Timer2.Stop()
        '            End If
        '            rdkk.Close()
        '        End Using
        '    End Using

        '    Button2.Enabled = True
        '    Button2.Visible = True
        'End If
        'If Trim(ComboBox1.Text) = Trim("") Then
        '    Button2.Enabled = False
        '    Timer2.Stop()
        '    TextBox2.Text = ""
        '    Label21.Text = ""
        '    Label21.BackColor = Color.Transparent
        'Else
        '    Call Class1.CONNIC()

        '    Dim s5 As String = "select * from main where namex=@xx1"
        '    Using cm5 As New SqlClient.SqlCommand(s5, cn)
        '        cm5.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
        '        Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
        '        If rd5.Read = True Then
        '            Me.TextBox2.Text = rd5!fnumber
        '            Me.ComboBox1.Text = Trim(rd5!namex)
        '            rd5.Close()
        '            Dim skk As String = "select * from kashef where fnumber=@fnumber and baky<>@baky AND CONF=@CONF "
        '            Using cmkk As New SqlClient.SqlCommand(skk, cn)
        '                cmkk.Parameters.AddWithValue("@fnumber", Trim(TextBox2.Text))
        '                'cmkk.Parameters.AddWithValue("@doctorname", ComboBox2.Text)
        '                cmkk.Parameters.AddWithValue("@baky", CDbl(0))
        '                cmkk.Parameters.AddWithValue("@CONF", True)
        '                Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
        '                    If rdkk.Read = True Then
        '                        Label18.Text = CInt(rdkk!Esalno)
        '                        'Label13.Text = CDbl(rdkk!kemat)
        '                        'TextBox10.Text = CDbl(rdkk!madfoo)
        '                        'TextBox16.Text = CDbl(rdkk!madfoo)
        '                        'TextBox11.Text = CDbl(rdkk!baky)
        '                        Label21.Text = CDbl(rdkk!baky)
        '                        Timer2.Start()
        '                    Else
        '                        Timer2.Stop()
        '                        Label21.Text = ""

        '                    End If
        '                    rdkk.Close()
        '                End Using
        '            End Using

        '        Else
        '            Me.TextBox2.Text = ""
        '            Timer2.Stop()
        '            Label21.Text = ""
        '            Label21.BackColor = Color.Transparent
        '        End If
        '        rd5.Close()
        '    End Using
        '    'Dim skk As String = "select * from kashef where fnumber=@fnumber and doctorname=@doctorname and baky<>@baky AND CONF=@CONF "

        '    Button2.Enabled = True
        '    Button2.Visible = True
        '    Call Class4.CONNIC()
        'End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Trim(ComboBox3.Text) <> "" Then


            ''rdn1.Close()
            'Dim sn2 As String = "select * from dn where dn=@xx1 "
            'Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
            '    cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            '    Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
            '    If rdn2.Read = True Then
            '        Me.Label4.Text = rdn2!idd
            '    End If
            '    rdn2.Close()
            'End Using
            ''end using
            'Label23.Text = B
            Call Class1.CONNIC()
            Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and IDK=@IDK"
            Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
                cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
                cmn0.Parameters.AddWithValue("@IDK", CInt(Label23.Text))
                Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
                If rdn0.Read = True Then
                    Me.Label2.Text = rdn0!idJ
                    'Label4.Text = rdn0!idd
                End If
                rdn0.Close()
            End Using

            'end using

            Dim sn12 As String = "select * from dnkema where Ejraa=@xxxx1 and IDD=@xxxx2 "
            Using cmn12 As New SqlClient.SqlCommand(sn12, cn)
                cmn12.Parameters.AddWithValue("@xxxx1", CInt(Label2.Text))
                cmn12.Parameters.AddWithValue("@xxxx2", CInt(Label4.Text))
                Dim rdn12 As SqlClient.SqlDataReader = cmn12.ExecuteReader
                If rdn12.Read = True Then
                    Me.TextBox6.Text = CDbl(rdn12!kema)
                    Me.TextBox5.Text = CDbl(rdn12!kemaej)
                    Me.Label13.Text = CDbl(rdn12!kemaej)
                    Me.TextBox11.Text = CDbl(rdn12!kemaej)
                End If
                rdn12.Close()
            End Using
            ''end using
            If ComboBox3.Text = "عمليات" Then
                GroupBox14.Visible = True
                ComboBox5.SelectedIndex = 0
                'Dim sn2 As String = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                '         FROM dbo.dn INNER JOIN
                '         dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD where dbo.dn.IDK=" & B
                'Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                '    cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                '    Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                '    If rdn2.Read = True Then
                '        Me.Label4.Text = rdn2!IDD
                '        M7 = rdn2!IDD
                '    End If
                'End Using
                'Dim sk18 As String
                'sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
                'Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
                'Dim dsk18 As New DataSet
                'adk18.Fill(dsk18, "Amaleat")
                'ComboBox5.DataSource = dsk18.Tables(0)
                'ComboBox5.DisplayMember = "AML_NAME"
                Call Class1.CONNIC()
                'Dim sk2 As String = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                '         FROM dbo.dn INNER JOIN
                '         dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD where dbo.dn.IDK=" & B
                'Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                '    Dim dsk2 As New DataSet
                '    adk2.Fill(dsk2, "dn")
                '    ComboBox2.DataSource = dsk2.Tables(0)
                '    ComboBox2.DisplayMember = "dn"
                '    ''ComboBox2.SelectedIndex = -1
                '    'end using
                'End Using
                Dim sn1 As String = "select * from dnkema where IDA=@xxxx2 "
                Using cmn1 As New SqlClient.SqlCommand(sn1, cn)
                    'cmn1.Parameters.AddWithValue("@xxxx1", CInt(Label2.Text))
                    cmn1.Parameters.AddWithValue("@xxxx2", CInt(Label15.Text))
                    Dim rdn1 As SqlClient.SqlDataReader = cmn1.ExecuteReader
                    If rdn1.Read = True Then
                        Me.TextBox6.Text = CDbl(rdn1!kema)
                        Me.TextBox5.Text = CDbl(rdn1!kemaej)
                        Me.Label13.Text = CDbl(rdn1!kemaej)
                        Me.TextBox11.Text = CDbl(rdn1!kemaej)
                        Me.TextBox10.Text = CDbl(0)
                    End If
                    rdn1.Close()
                End Using

                'End If
                'End Using
            Else
                GroupBox14.Visible = False
            End If

            'If ComboBox3.Text = "أسنان" Then
            '    GroupBox14.Visible = True
            '    Dim sn2 As String = "select * from dn where dn=@xx1 "
            '    Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
            '        cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            '        Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
            '        If rdn2.Read = True Then
            '            Me.Label4.Text = rdn2!idd
            '            M7 = rdn2!IDD
            '            Dim sk18 As String
            '            sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
            '            Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            '            Dim dsk18 As New DataSet
            '            adk18.Fill(dsk18, "Amaleat")
            '            ComboBox5.DataSource = dsk18.Tables(0)
            '            ComboBox5.DisplayMember = "AML_NAME"
            '            Dim sn1 As String = "select * from dnkema where Ejraa=@xxxx1 and IDD=@xxxx2 "
            '            Using cmn1 As New SqlClient.SqlCommand(sn1, cn)
            '                cmn1.Parameters.AddWithValue("@xxxx1", CInt(Label2.Text))
            '                cmn1.Parameters.AddWithValue("@xxxx2", CInt(Label4.Text))
            '                Dim rdn1 As SqlClient.SqlDataReader = cmn1.ExecuteReader
            '                If rdn1.Read = True Then
            '                    Me.TextBox6.Text = CDbl(rdn1!kema)
            '                    Me.TextBox5.Text = CDbl(rdn1!kemaej)
            '                    Me.Label13.Text = CDbl(rdn1!kemaej)
            '                    Me.TextBox11.Text = CDbl(rdn1!kemaej)
            '                    Me.TextBox10.Text = CDbl(0)
            '                End If
            '                rdn1.Close()
            '            End Using
            '        End If
            '    End Using
            'Else
            '    GroupBox14.Visible = False
            'End If
            ''M7 = CInt(Label4.Text)
            ''Dim sn20 As String = "select * from dn where dn=@xx1 "
            ''Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
            ''cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            ''Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            ''If rdn20.Read = True Then
            ''    Me.Label4.Text = rdn20!idd
            ''    M7 = rdn20!idd
            ''    'Dim sk18 As String
            ''    'sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
            ''    'Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            ''    'Dim dsk18 As New DataSet
            ''    'adk18.Fill(dsk18, "Amaleat")
            ''    'ComboBox5.DataSource = dsk18.Tables(0)
            ''    'ComboBox5.DisplayMember = "AML_NAME"
            ''End If
            ''rdn20.Close()


            ''ComboBox5.SelectedIndex = -1
            'Dim d As String
            'Dim sG As String = "select * from ejraa where ejraa=@xx1 "
            'Using cmG As New SqlClient.SqlCommand(sG, cn)
            '    cmG.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            '    Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            '    If rdG.Read = True Then
            '        d = rdG!IDj
            '    End If
            '    rdG.Close()
            'End Using
            'Dim sk23 As String
            'sk23 = "select * from Ejraa where IDj=" & d
            'Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            '    Dim dsk23 As New DataSet
            '    adk23.Fill(dsk23, "Ejraa")
            '    ComboBox3.DataSource = dsk23.Tables(0)
            '    ComboBox3.DisplayMember = "Ejraa"
            '    ComboBox3.SelectedIndex = -1
            'End Using
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub حذفالحجزToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفالحجزToolStripMenuItem.Click
        Select Case num
            Case Is >= 0
                Call Class1.CONNIC()
                Dim sG As String = "select * from kashef where esalno=@esalno "
                Using cmG As New SqlClient.SqlCommand(sG, cn)
                    cmG.Parameters.AddWithValue("@esalno", dgx)
                    Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
                    If rdG.Read = True Then
                        confx = rdG!conf
                    End If
                    rdG.Close()
                End Using

                'dgx = DataGridView1.CurrentCell.Value
                'dgx = DataGridView1.Item(4, num).Value()
                'dgx = DataGridView1.Item(0, num).Value()
                If confx = True Then
                    MsgBox("لا يمكن إلغاء الحجز")
                Else
                    Label17.Text = DataGridView1.Item(0, num).Value()

                    Dim sd As String = "delete from appointment where esalno=@esalno"
                    Using cd As New SqlClient.SqlCommand(sd, cn)
                        cd.Parameters.AddWithValue("@esalno", dgx)
                        Dim sdk As String = "delete from kashef where esalno=@esalno"
                        Using cdk As New SqlClient.SqlCommand(sdk, cn)
                            cdk.Parameters.AddWithValue("@esalno", dgx)
                            If MsgBox("هل تريد إلغاء الحجز", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Try
                                    Call Class4.CONNIC()
                                    Call Class1.CONNIC()
                                    cd.ExecuteNonQuery()
                                    cdk.ExecuteNonQuery()
                                    Dim Str As String = "SELECT MAX(ESALNO) FROM KASHEF "
                                    Dim cmd As New SqlClient.SqlCommand(Str, cn)
                                    If IsDBNull(cmd.ExecuteScalar) Then
                                        M6 = 0
                                    Else
                                        M6 = cmd.ExecuteScalar
                                    End If
                                    Dim cmKA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KASHEF', RESEED," & M6 & ")", cn)
                                    cmKA1.ExecuteNonQuery()
                                    MsgBox("تم إلغاء الحجز")
                                    DataGridView1.Rows.Clear()
                                    'Form10_Load(Nothing, Nothing)
                                Catch ex As Exception
                                    MsgBox("لم يتم الحذف")
                                End Try
                            End If
                        End Using
                    End Using
                End If
                Call Class4.CONNIC()
        End Select
    End Sub

    Private Sub DataGridView1_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs)

    End Sub

    Private Sub DataGridView1_CellErrorTextChanged(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    'Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
    'Select Case e.ColumnIndex
    '    Case Is >= 0
    '        Select Case e.RowIndex
    '            Case Is >= 0
    '                ContextMenuStrip2.Enabled = True

    '                'Label20.Text = DataGridView1.Item(1, e.RowIndex).Value()
    '                dgx = DataGridView1.Item(1, e.RowIndex).Value()
    '                Dim i As Integer
    '                i = e.RowIndex
    '                num = e.RowIndex
    '                If Val(i) >= 0 Then
    '                    Dim dgx As Integer
    '                    dgx = DataGridView1.Item(1, e.RowIndex).Value()
    '                    Label20.Text = DataGridView1.Item(1, e.RowIndex).Value()
    '                    dgxx = DataGridView1.Item(2, e.RowIndex).Value()
    '                    'Label17.Text = DataGridView1.Item(0, i).Value()
    '                    'dgx = Me.DataGridView1.CurrentCell.Value
    '                    'Label8.Text = dgx
    '                    Call Class1.CONNIC()
    '                    Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno and chno=@chno"
    '                    Dim cm As New SqlClient.SqlCommand(s, cn)
    '                    cm.Parameters.AddWithValue("@Esalno", dgx)
    '                    cm.Parameters.AddWithValue("@chno", dgxx)
    '                    Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
    '                    If rd.Read = True Then
    '                        Me.ComboBox2.Text = rd!DN
    '                        Me.ComboBox3.Text = rd!Ejraa
    '                        Me.ComboBox2.Enabled = True
    '                        Me.ComboBox3.Enabled = True
    '                        Me.ComboBox4.Enabled = True
    '                        Me.TextBox3.Text = rd!chno
    '                        Me.TextBox2.Text = rd!fnumber
    '                        Me.Label5.Text = rd!chno
    '                        Me.Label16.Text = rd!chno
    '                        M7 = rd!CHNO
    '                        Me.Label10.Text = rd!Esalno
    '                        Me.ComboBox4.Text = rd!NAMEM
    '                        Me.TextBox4.Text = rd!JEHAM
    '                        Me.Label9.Text = rd!JEHAM
    '                        Me.DateTimePicker3.Text = rd!datea
    '                        Me.TextBox3.Enabled = True
    '                        'Me.ComboBox3.Enabled = False
    '                        'Me.ComboBox4.Enabled = True
    '                        Me.DateTimePicker3.Enabled = True
    '                        Button2.Enabled = False
    '                        Me.ComboBox1.Text = rd!namex
    '                        Me.ComboBox1.Enabled = True
    '                        rd.Close()
    '                        'Me.ComboBox1.Text = Label22.Text
    '                        'Me.ComboBox1.Enabled = False
    '                        'Call Class1.CONNIC()
    '                        'Dim sk As String = "select * from KASHEF where Esalno=@Esalno"
    '                        'Dim cmk As New SqlClient.SqlCommand(sk, cn)
    '                        'cmk.Parameters.AddWithValue("@Esalno", dgx)
    '                        'Dim rdk As SqlClient.SqlDataReader = cm.ExecuteReader
    '                        'If rdk.Read = True Then
    '                        '    'TextBox10.Text = rdk!MADFOO
    '                        '    TextBox11.Text = rdk!baky
    '                        'End If

    '                        rd.Close()
    '                        Call Class4.CONNIC()
    '                        Call Class1.CONNIC()
    '                        Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
    '                        Dim cm11 As New SqlClient.SqlCommand(s11, cn)
    '                        cm11.Parameters.AddWithValue("@conf", True)
    '                        cm11.Parameters.AddWithValue("@Esalno", dgx)
    '                        'cm11.Parameters.AddWithValue("@BAKY", CDbl(0))
    '                        Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
    '                        If rd11.Read = True Then
    '                            Button2.Visible = False
    '                            Button4.Visible = True
    '                            Button6.Visible = False
    '                            Me.ComboBox1.Enabled = False
    '                            Me.ComboBox2.Enabled = False
    '                            Me.ComboBox3.Enabled = False
    '                            Me.ComboBox4.Enabled = False
    '                            'ContextMenuStrip2.Enabled = False
    '                            Label13.ContextMenuStrip = ContextMenuStrip3
    '                            rd11.Close()
    '                            Dim sk As String = "select * from KASHEF where fnumber=@fnumber AND ESALNO=@ESALNO"
    '                            Dim cmk As New SqlClient.SqlCommand(sk, cn)
    '                            cmk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
    '                            cmk.Parameters.AddWithValue("@ESALNO", dgx)
    '                            Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
    '                            If rdK.Read = True Then
    '                                TextBox10.Text = CDbl(rdK!MADFOO)
    '                                TextBox12.Text = CDbl(rdK!MADFOO)
    '                                TextBox16.Text = CDbl(rdK!MADFOO)
    '                                TextBox11.Text = CDbl(rdK!BAKY)
    '                                TextBox15.Text = ""
    '                                Label13.Text = CDbl(rdK!kemat)
    '                                rdK.Close()
    '                            End If
    '                            If TextBox10.Text = 0 Then
    '                                Button5.Visible = False
    '                            Else
    '                                Button5.Visible = True
    '                            End If
    '                            'end using
    '                            'end using

    '                            'TextBox10.Text = rd11!MADFOO
    '                            'TextBox12.Text = rd11!MADFOO
    '                            'TextBox11.Text = rd11!baky
    '                            'If Label8.Text <> 0 Then

    '                            'Else
    '                            '    TextBox15.ReadOnly = False
    '                            'End If
    '                            rd.Close()
    '                        Else
    '                            Button4.Visible = True
    '                            Button2.Visible = False
    '                            Button5.Visible = False
    '                            Button6.Visible = True
    '                            Me.ComboBox1.Enabled = True
    '                            Me.ComboBox2.Enabled = True
    '                            Me.ComboBox3.Enabled = True
    '                            Me.ComboBox4.Enabled = True
    '                            ContextMenuStrip2.Enabled = True
    '                            Label13.ContextMenuStrip = ContextMenuStrip2
    '                            If Label8.Text = 0 Then
    '                                If Trim(TextBox15.Text) = "" Or Val(TextBox15.Text) = 0 Then
    '                                    Button6.Enabled = False
    '                                Else
    '                                    Button6.Enabled = True
    '                                End If
    '                            End If

    '                            'If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("أدوية") Then
    '                            '    If ComboBox4.Text = Trim("نقدا") Then

    '                            '    End If
    '                            'End If
    '                            rd11.Close()
    '                            rd.Close()
    '                            Dim sk As String = "select * from KASHEF where fnumber=@fnumber AND ESALNO=@ESALNO"
    '                            Dim cmk As New SqlClient.SqlCommand(sk, cn)
    '                            cmk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
    '                            cmk.Parameters.AddWithValue("@ESALNO", dgx)
    '                            Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
    '                            If rdK.Read = True Then
    '                                TextBox10.Text = CDbl(rdK!MADFOO)
    '                                TextBox12.Text = CDbl(rdK!MADFOO)
    '                                TextBox16.Text = CDbl(rdK!MADFOO)
    '                                TextBox11.Text = CDbl(rdK!BAKY)
    '                                TextBox15.Text = ""
    '                                Label13.Text = CDbl(rdK!kemat)
    '                                TextBox15.Focus()
    '                                'If Label8.Text <> 0 Then
    '                                '    If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("أدوية") Then
    '                                '        TextBox15.ReadOnly = False
    '                                '        Label19.Visible = True
    '                                '    Else
    '                                '        TextBox15.ReadOnly = True
    '                                '        Label19.Visible = False
    '                                '    End If
    '                                '    'TextBox15.ReadOnly = True
    '                                'Else
    '                                '    TextBox15.ReadOnly = False
    '                                'End If

    '                                rdK.Close()
    '                            End If
    '                            rdK.Close()
    '                            'TextBox10.Text = rd11!MADFOO
    '                            'TextBox11.Text = rd11!baky
    '                        End If
    '                        rd11.Close()
    '                        'end using
    '                        'end using
    '                        rd.Close()

    '                    End If
    '                    rd.Close()

    '                    'end using
    '                    'end using

    '                    'Dim s As String = "delete * from appointment where fnumber=dgx"
    '                    'Dim cm As New SqlClient.SqlCommand(s, cn)
    '                    'cm.Parameters.AddWithValue("dgx", TextBox1.Text)
    '                    'If MsgBox("هــل تـريد الحــــذف ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    '    cm.ExecuteNonQuery()
    '                    '    MsgBox("تمـــت عمـــلـــية الحـــذف")
    '                    'End If

    '                    'End Select
    '                    TextBox15.Focus()
    '                    Dim s1 As String = "select * from SADAD "
    '                    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
    '                    Dim dss As New DataSet
    '                    dss.Clear()
    '                    aad.Fill(dss, "SADAD")
    '                    Dim vd As New DataView(dss.Tables("SADAD"))
    '                    vd.RowFilter = "DATEXX>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEXX<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND ESALNO=" & "'" & dgx & "'" & ""
    '                    Me.DataGridView2.DataMember = ""
    '                    DataGridView2.DataSource = vd
    '                    'If DataGridView2.Rows.Count <> 0 Then
    '                    '    GroupBox1.Width = 879
    '                    '    GroupBox1.Location.X.Equals(454)
    '                    'Else
    '                    '    GroupBox1.Width = 1328
    '                    'End If

    '                    rd.Close()
    '                    Call Class4.CONNIC()

    '                End If

    '        End Select

    'End Select
    'End Sub

    Private Sub DataGridView1_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_ForeColorChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_TextChanged1(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        ComboBox1.MaxLength = 32

        'If Trim(ComboBox1.Text) = Trim("") Then
        '    Button2.Enabled = False
        '    Timer2.Stop()
        '    TextBox2.Text = ""
        '    Label21.Text = ""
        '    Label21.BackColor = Color.Transparent
        'Else
        '    Call Class1.CONNIC()

        '    Dim s5 As String = "select * from main where namex=@xx1"
        '    Using cm5 As New SqlClient.SqlCommand(s5, cn)
        '        cm5.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
        '        Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
        '        If rd5.Read = True Then
        '            Me.TextBox2.Text = rd5!fnumber
        '            Me.ComboBox1.Text = Trim(rd5!namex)
        '            rd5.Close()
        '            Call Class1.CONNIC()
        '            Dim skk As String = "select * from kashef where fnumber=@fnumber and baky<>@baky AND CONF=@CONF "
        '            Using cmkk As New SqlClient.SqlCommand(skk, cn)
        '                cmkk.Parameters.AddWithValue("@fnumber", Trim(TextBox2.Text))
        '                'cmkk.Parameters.AddWithValue("@doctorname", ComboBox2.Text)
        '                cmkk.Parameters.AddWithValue("@baky", CDbl(0))
        '                cmkk.Parameters.AddWithValue("@CONF", True)
        '                Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
        '                    If rdkk.Read = True Then
        '                        Label18.Text = CInt(rdkk!Esalno)
        '                        'Label13.Text = CDbl(rdkk!kemat)
        '                        'TextBox10.Text = CDbl(rdkk!madfoo)
        '                        'TextBox16.Text = CDbl(rdkk!madfoo)
        '                        'TextBox11.Text = CDbl(rdkk!baky)
        '                        Label21.Text = CDbl(rdkk!baky)
        '                        Timer2.Start()
        '                    Else
        '                        Timer2.Stop()
        '                        Label21.Text = ""
        '                        Label21.BackColor = Color.Transparent
        '                    End If
        '                    rdkk.Close()
        '                End Using
        '            End Using

        '        Else
        '            Me.TextBox2.Text = ""
        '            Timer2.Stop()
        '            Label21.Text = ""
        '            Label21.BackColor = Color.Transparent
        '        End If
        '        rd5.Close()
        '    End Using
        'Dim skk As String = "select * from kashef where fnumber=@fnumber and doctorname=@doctorname and baky<>@baky AND CONF=@CONF "

        Button2.Enabled = True
            Button2.Visible = True
            Call Class4.CONNIC()
        'End If
    End Sub

    Private Sub ComboBox1_Validated(sender As Object, e As EventArgs) Handles ComboBox1.Validated
        Call Class1.CONNIC()
        Dim s As String = "select * from main where namex=@xx1"
        Using cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                Me.TextBox2.Text = rd!fnumber
                Me.ComboBox1.Text = Trim(rd!namex)
                rd.Close()
            Else
                Me.TextBox2.Text = ""
            End If
            rd.Close()
        End Using
        Call Class1.CONNIC()
        Dim skk As String = "select * from kashef where fnumber=@fnumber and doctorname=@doctorname and baky<>@baky "
        Using cmkk As New SqlClient.SqlCommand(skk, cn)
            cmkk.Parameters.AddWithValue("@fnumber", Trim(TextBox2.Text))
            cmkk.Parameters.AddWithValue("@doctorname", Label4.Text)
            cmkk.Parameters.AddWithValue("@baky", CDbl(0))
            Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                If rdkk.Read = True Then
                    Label18.Text = CInt(rdkk!Esalno)
                    'Label13.Text = CDbl(rdkk!kemat)
                    'TextBox10.Text = CDbl(rdkk!madfoo)
                    'TextBox16.Text = CDbl(rdkk!madfoo)
                    'TextBox11.Text = CDbl(rdkk!baky)
                    Label21.Text = CDbl(rdkk!baky)
                End If
                rdkk.Close()
            End Using
        End Using
        'Else
        'Dim snF As String = "select * from main where fnumber=@xx1 "
        'Dim cmnF As New SqlClient.SqlCommand(snF, cn)
        'cmnF.Parameters.AddWithValue("@xx1", CInt(ComboBox1.Text))
        'Dim rdnF As SqlClient.SqlDataReader = cmnF.ExecuteReader
        'If rdnF.Read = True Then
        '    Me.TextBox2.Text = rdnF!fnumber
        '    Me.ComboBox1.Text = rdnF!namex
        '    rdnF.Close()
        'End If
        '        'TODO: تغيير البحث عن رقم
        '        '        m5 = 1
        '        '        Dim k As Integer = 0
        '        '        Do While k < 100
        '        '            Dim i As Integer
        '        '            i = m5
        '        '            Dim s2 As String = "select * from main where fnumber=@xx1"
        '        '            Dim cm1 As New SqlClient.SqlCommand(s2, cn)
        '        '            cm1.Parameters.AddWithValue("@xx1", i)
        '        '            Dim rd1 As SqlClient.SqlDataReader
        '        '            rd1 = cm1.ExecuteReader
        '        '            Do While rd1.Read = True
        '        '                i = i + 1
        '        '                Dim ss1 As String = "select * from main where fnumber=@xx1"
        '        '                Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
        '        '                cmm1.Parameters.AddWithValue("@xx1", i)
        '        '                rd1 = cmm1.ExecuteReader
        '        '                m5 = i
        '        '            Loop
        '        '            rd1.Close()
        '        '            k = k + 1
        '        '        Loop
        '        '        'rd1.Close()
        '        '        Me.TextBox2.Text = m5
        '    End If
        '    rdnF.Close()
        'End If
        'rd.Close()
        DGV1()

        'Call Class1.CONNIC()
        'Dim s1 As String = "select * from APPOINTMENTVIEW "
        'Using aad As New SqlClient.SqlDataAdapter(s1, cn)
        '    Dim dss As New DataSet
        '    dss.Clear()
        '    aad.Fill(dss, "APPOINTMENTVIEW")
        '    Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
        '    vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
        '    Me.DataGridView1.DataMember = ""
        '    DataGridView1.DataSource = vd
        'Dim r1 As String = Replace(ComboBox1.Text, "أ", "ا")
        'Dim r2 As String = Replace(r1, "ى", "ي")
        'Dim r3 As String = Replace(r2, "ة", "ه")
        Call TXTEMLA.TXTEMLA(ComboBox1.Text)
        Me.ComboBox1.Text = RTXT
        Me.DateTimePicker3.Focus()
        'End Using
        'end using
        'end using
        Call Class4.CONNIC()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If Me.TextBox3.Text = "" Then
            MsgBox("Insert Chair number")
            Me.TextBox3.Focus()
        ElseIf Me.ComboBox1.Text = "" Then
            MsgBox("Insert Name")
            Me.ComboBox1.Focus()
        ElseIf Me.ComboBox2.Text = "" Then
            Me.ComboBox2.Focus()
            MsgBox("Insert The Doctor Name")

        Else
            Call Class1.CONNIC()
            Dim snF As String = "select * from kashef where esalno=@esalno "
            Dim cmnF As New SqlClient.SqlCommand(snF, cn)
            cmnF.Parameters.AddWithValue("@esalno", CInt(dgx))
            Dim rdnF As SqlClient.SqlDataReader = cmnF.ExecuteReader
            If rdnF.Read = True Then
                confx = rdnF!conf
            End If

            'm5 = 1
            'Dim k As Integer = 0
            'Do While k < 100
            '    Dim i As Integer
            '    i = m5
            '    Dim s1 As String = "select * from main where fnumber=@xx1"
            '    Dim cm1 As New SqlClient.SqlCommand(s1, cn)
            '    cm1.Parameters.AddWithValue("@xx1", i)
            '    Dim rd1 As SqlClient.SqlDataReader
            '    rd1 = cm1.ExecuteReader
            '    Do While rd1.Read = True
            '        i = i + 1
            '        Dim ss1 As String = "select * from main where fnumber=@xx1"
            '        Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
            '        cmm1.Parameters.AddWithValue("@xx1", i)
            '        rd1 = cmm1.ExecuteReader
            '        m5 = i
            '    Loop
            '    rd1.Close()
            '    k = k + 1
            'Loop
            ' Label6.Text = m5
            If confx = True Then
                Call Class1.CONNIC()
                Dim ss21 As String = "update kashef set DATEX=@Datex" & vbNewLine &
                                     "where Esalno = @Esalno"
                Using cmm21 As New SqlClient.SqlCommand(ss21, cn)
                    cmm21.Parameters.AddWithValue("@Datex", Me.DateTimePicker3.Value)
                    cmm21.Parameters.AddWithValue("@Esalno", CInt(Label10.Text))
                    Dim ss2 As String = "update appointment set DATEA=@DATEA" & vbNewLine &
                                         "where Esalno = @Esalno"
                    Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
                        cmm2.Parameters.AddWithValue("@DATEA", Me.DateTimePicker3.Value)
                        cmm2.Parameters.AddWithValue("@Esalno", CInt(Label10.Text))
                        cmm2.ExecuteNonQuery()
                        cmm21.ExecuteNonQuery()
                        MsgBox("تم تعديل تاريخ الحجز ")
                    End Using
                End Using
                Me.TextBox3.Enabled = False
                Me.ComboBox1.Enabled = False
                'Me.ComboBox3.Enabled = False
                Me.ComboBox4.Enabled = False
                Me.DateTimePicker3.Enabled = False
                Me.DateTimePicker3.Value = Date.Today
                Me.DateTimePicker1.Value = Date.Today
                Me.DateTimePicker2.Value = Date.Today
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.Label5.Text = ""
                Me.Label16.Text = ""
                Me.Label9.Text = ""
                Me.ComboBox1.Text = ""
                Me.ComboBox3.Text = ""
                Me.ComboBox4.Text = ""
                Me.ComboBox2.Text = ""
                Me.ComboBox1.Text = ""
                Me.ComboBox2.Text = ""
                Me.NumericUpDown1.Value = 0
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.Label13.Text = 0
                'Me.MaskedTextBox1.Text = ""
                'Me.MaskedTextBox2.Text = ""
                'Me.MaskedTextBox3.Text = ""
                DataGridView1.Rows.Clear()
                Me.TextBox3.Focus()
                Me.ComboBox1.Enabled = False
                Me.DateTimePicker3.Enabled = False
                ' Me.ComboBox2.Enabled = False
                DGV1()

                'Call Class1.CONNIC()
                'Dim s16 As String = "select * from APPOINTMENTVIEW "
                'Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                'Dim dss As New DataSet
                'dss.Clear()
                'aad.Fill(dss, "APPOINTMENTVIEW")
                'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
                'vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
                'Me.DataGridView1.DataMember = ""
                'DataGridView1.DataSource = vd
                'MsgBox("لا يمكن التعديل في الحجز")
            Else
                If TextBox2.Text = Trim("") Then
                    Call Class1.CONNIC()
                    Dim ss As String = "insert into main(namex,age,address,husbend,phone,idcard,datex,CITY,gender)values(@xx1,@xx3,@xx4,@xx5,@xx6,@xx7,@xx8,@xx9,@XX10)"
                    Using cmm As New SqlClient.SqlCommand(ss, cn)
                        cmm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
                        'cmm.Parameters.AddWithValue("@xx2", TextBox2.Text)
                        cmm.Parameters.AddWithValue("@xx3", "0")
                        cmm.Parameters.AddWithValue("@xx4", "لايوجد")
                        cmm.Parameters.AddWithValue("@xx5", "لايوجد")
                        cmm.Parameters.AddWithValue("@xx6", "لايوجد")
                        cmm.Parameters.AddWithValue("@xx7", "لايوجد")
                        cmm.Parameters.AddWithValue("@xx8", Date.Now.Date)
                        cmm.Parameters.AddWithValue("@xx9", "لايوجد")
                        cmm.Parameters.AddWithValue("@xx10", "لايوجد")
                        Try
                            cmm.ExecuteNonQuery()

                        Catch ex As Exception
                        End Try
                    End Using
                End If
                Call Class1.CONNIC()
                Dim s As String = "select * from main where namex=@xx1 "
                Using cm As New SqlClient.SqlCommand(s, cn)
                    cm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
                    Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                        If rd.Read = True Then
                            Me.TextBox2.Text = rd!fnumber
                        End If
                        rd.Close()
                    End Using
                End Using

                'Dim ss As String = "insert into main(namex,fnumber,age,address,husbend,phone,idcard,datex,CITY,gender)values(@xx1,@xx2,@xx3,@xx4,@xx5,@xx6,@xx7,@xx8,@xx9,@xx10)"
                'Using cmm As New SqlClient.SqlCommand(ss, cn)
                '    cmm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
                '    cmm.Parameters.AddWithValue("@xx2", TextBox2.Text)
                '    cmm.Parameters.AddWithValue("@xx3", "0")
                '    cmm.Parameters.AddWithValue("@xx4", "لايوجد")
                '    cmm.Parameters.AddWithValue("@xx5", "لايوجد")
                '    cmm.Parameters.AddWithValue("@xx6", "لايوجد")
                '    cmm.Parameters.AddWithValue("@xx7", "لايوجد")
                '    cmm.Parameters.AddWithValue("@xx8", Date.Now.Date)
                '    cmm.Parameters.AddWithValue("@xx9", "لايوجد")
                '    cmm.Parameters.AddWithValue("@xx10", "لايوجد")
                '    Try
                '        cmm.ExecuteNonQuery()
                '    Catch ex As Exception
                '    End Try
                'End Using
                'M6 = 1
                'Dim k1 As Integer = 0
                'Do While k1 < 100
                '    Dim i As Integer
                '    i = M6
                '    Dim s1 As String = "select * from KASHEF where ESALNO=@xx1"
                '    Dim cm1 As New SqlClient.SqlCommand(s1, cn)
                '    cm1.Parameters.AddWithValue("@xx1", i)
                '    Dim rd1 As SqlClient.SqlDataReader
                '    rd1 = cm1.ExecuteReader
                '    Do While rd1.Read = True
                '        i = i + 1
                '        Dim ss1 As String = "select * from KASHEF where ESALNO=@xx1"
                '        Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
                '        cmm1.Parameters.AddWithValue("@xx1", i)
                '        rd1 = cmm1.ExecuteReader
                '        M6 = i
                '    Loop
                '    rd1.Close()
                '    k1 = k1 + 1
                'Loop
                'End Try
                '  Dim ss2 As String = "insert into appointment(IDPAT,chno,Datea,from,to)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5)"

                'Dim sd As String = "delete * from kashef where Esalno=xx"
                'Dim cd As New SqlClient.SqlCommand(sd, cn)
                'cd.Parameters.AddWithValue("xx", Me.Label10.Text)
                'Try
                '    cd.ExecuteNonQuery()
                'Catch ex As Exception

                'End Try
                Call Class1.CONNIC()
                Dim ss21 As String = "update kashef set fnumber=@fnumber,CHNO=@CHNO,DATEX=@Datex,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY" & vbNewLine &
                                     "where Esalno = @Esalno"
                Using cmm21 As New SqlClient.SqlCommand(ss21, cn)
                    cmm21.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                    cmm21.Parameters.AddWithValue("@CHNO", M7)
                    cmm21.Parameters.AddWithValue("@Datex", Me.DateTimePicker3.Value)
                    cmm21.Parameters.AddWithValue("@doctorname", Me.Label4.Text)
                    'If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
                    '    cmm21.Parameters.AddWithValue("@KEMA", CDec(TextBox15.Text))
                    'Else
                    cmm21.Parameters.AddWithValue("@KEMA", CDec(Label13.Text))
                    'End If
                    cmm21.Parameters.AddWithValue("@KEMAT", CDec(Label13.Text))
                    cmm21.Parameters.AddWithValue("@MADFOO", CDec(0))
                    cmm21.Parameters.AddWithValue("@BAKY", CDec(Label13.Text))
                    cmm21.Parameters.AddWithValue("@Esalno", CInt(Label10.Text))
                    Call Class1.CONNIC()
                    Dim ss2 As String = "update appointment set fnumber=@fnumber,CHNO=@CHNO,DATEA=@DATEA,doctorname=@doctorname,IDM=@IDM,EJRAA=@EJRAA" & vbNewLine &
                                         "where Esalno = @Esalno"
                    Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
                        cmm2.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                        cmm2.Parameters.AddWithValue("@CHNO", M7)
                        cmm2.Parameters.AddWithValue("@DATEA", Me.DateTimePicker3.Value)
                        cmm2.Parameters.AddWithValue("@doctorname", Me.Label4.Text)
                        cmm2.Parameters.AddWithValue("@IDM", CInt(Me.Label8.Text))
                        cmm2.Parameters.AddWithValue("@EJRAA", Me.ComboBox3.Text)
                        cmm2.Parameters.AddWithValue("@Esalno", CInt(Label10.Text))
                        cmm2.ExecuteNonQuery()
                        cmm21.ExecuteNonQuery()
                        MsgBox("تم تعديل بيانات الحجز ")

                    End Using
                End Using
                Me.TextBox3.Enabled = False
                Me.ComboBox1.Enabled = False
                'Me.ComboBox3.Enabled = False
                Me.ComboBox4.Enabled = False
                Me.DateTimePicker3.Enabled = False
                Me.DateTimePicker3.Value = Date.Today
                Me.DateTimePicker1.Value = Date.Today
                Me.DateTimePicker2.Value = Date.Today
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.Label5.Text = ""
                Me.Label16.Text = ""
                Me.Label9.Text = ""
                Me.ComboBox1.Text = ""
                Me.ComboBox3.Text = ""
                Me.ComboBox4.Text = ""
                Me.ComboBox2.Text = ""
                Me.ComboBox1.Text = ""
                Me.ComboBox2.Text = ""
                Me.NumericUpDown1.Value = 0
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.Label13.Text = 0
                'Me.MaskedTextBox1.Text = ""
                'Me.MaskedTextBox2.Text = ""
                'Me.MaskedTextBox3.Text = ""
                DataGridView1.Rows.Clear()
                Me.TextBox3.Focus()
                Me.ComboBox1.Enabled = False
                Me.DateTimePicker3.Enabled = False
                ' Me.ComboBox2.Enabled = False
                DGV1()
                'Call Class1.CONNIC()
                'Dim s16 As String = "select * from APPOINTMENTVIEW "
                'Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                'Dim dss As New DataSet
                'dss.Clear()
                'aad.Fill(dss, "APPOINTMENTVIEW")
                'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
                'vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
                'Me.DataGridView1.DataMember = ""
                'DataGridView1.DataSource = vd
                GroupBox15.Visible = False
            End If
            'end using
            'end using
            'end using

            'Catch ex As Exception
            '    MsgBox(" لايمكن الحفظ ")
            'End Try
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call Class1.CONNIC()
        Dim ss21 As String = "update kashef set fnumber=@fnumber,DATEX=@DATEX,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME" & vbNewLine &
                     "where Esalno=@Esalno"
        'Dim ss21 As String = "insert into kashef(fnumber,CHNO,DATEX,doctorname,KEMA,KEMAT,MADFOO,BAKY,conf,USER_NAME,idm,EJRAA) VALUES(@fnumber,@CHNO,@DATEX,@doctorname,@KEMA,@KEMAT,@MADFOO,@BAKY,@conf,@USER_NAME,@idm,@EJRAA)"
        'Dim ss21 As String = "insert into kashef(fnumber,CHNO,DATEX,doctorname,KEMA,KEMAT,MADFOO,BAKY,conf) VALUES(@fnumber,@CHNO,@DATEX,@doctorname,@KEMA,@KEMAT,@MADFOO,@BAKY,@conf)"
        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        Using cmm21 As New SqlClient.SqlCommand(ss21, cn)
            cmm21.Parameters.AddWithValue("@fnumber", TextBox2.Text)
            cmm21.Parameters.AddWithValue("@CHNO", Me.Label5.Text)
            cmm21.Parameters.AddWithValue("@DATEX", Me.DateTimePicker3.Value)
            cmm21.Parameters.AddWithValue("@doctorname", Me.Label4.Text)
            'cmm21.Parameters.AddWithValue("@X5", M6)
            cmm21.Parameters.AddWithValue("@KEMA", CDbl(TextBox6.Text))
            cmm21.Parameters.AddWithValue("@KEMAT", CDbl(TextBox5.Text))
            TextBox10.Text = Val(TextBox12.Text) - Val(TextBox10.Text)
            cmm21.Parameters.AddWithValue("@MADFOO", CDbl(TextBox10.Text))
            'TextBox11.Text = Val(TextBox11.Text) + Val(TextBox15.Text)
            cmm21.Parameters.AddWithValue("@BAKY", CDbl(TextBox11.Text))
            cmm21.Parameters.AddWithValue("@conf", False)
            cmm21.Parameters.AddWithValue("@USER_NAME", user)
            cmm21.Parameters.AddWithValue("@idm", Label8.Text)
            cmm21.Parameters.AddWithValue("@Ejraa", ComboBox3.Text)
            cmm21.Parameters.AddWithValue("@Esalno", CDbl(Label10.Text))
            If MsgBox("هل تريد إرجاع القيمة", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    cmm21.ExecuteNonQuery()
                    MsgBox("تم ارجاع القيمة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                'Dim sd As String = "delete from kashef where Esalno=@Esalno"
                'Dim cd As New SqlClient.SqlCommand(sd, cn)
                'cd.Parameters.AddWithValue("@Esalno", CInt(Me.Label10.Text))
                'If MsgBox("هل تريد إرجاع القيمة", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '    'Try
                '    cd.ExecuteNonQuery()
                '    Dim sd1 As String = "delete * from appointment where Esalno=@Esalno"
                '    Dim cd1 As New SqlClient.SqlCommand(sd1, cn)
                '    cd1.Parameters.AddWithValue("@Esalno", Me.Label10.Text)
                '    If MsgBox("هل تريد إلغاء الحجز", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '        Try
                '            cd1.ExecuteNonQuery()
                '        Catch ex As Exception

                '        End Try
                '    End If

                'Catch ex As Exception
                DGV1()
                'End Try
                'Call Class1.CONNIC()
                'Dim s16 As String = "select * from APPOINTMENTVIEW "
                'Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                'Dim dss As New DataSet
                'dss.Clear()
                'aad.Fill(dss, "APPOINTMENTVIEW")
                'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
                'vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
                'Me.DataGridView1.DataMember = ""
                'DataGridView1.DataSource = vd
                'end using
                'end using
                'end using

            End If
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ComboBox2.Text = "" Then
            Label11.Visible = True
        Else
            Label11.Visible = False
        End If

    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = True
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B1.Text
        TextBox8.Text = B1.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B1.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using
        'sk2 = "select * from am_view "
        'Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        '    Dim dsk2 As New DataSet
        '    adk2.Fill(dsk2, "am_view")
        '    ComboBox2.DataSource = dsk2.Tables(0)
        '    ComboBox2.DisplayMember = "dn"
        '    ''ComboBox2.SelectedIndex = -1
        '    'end using
        'End Using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If
        If Trim(ComboBox2.Text) <> "" Then
            Call Class1.CONNIC()
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Call Class1.CONNIC()
        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        'Call Class1.CONNIC()
        'Dim sn As String = "select * from AMALEAT where AML_NAME=@AML_NAME "
        'Using cmn As New SqlClient.SqlCommand(sn, cn)
        '    cmn.Parameters.AddWithValue("@AML_NAME", ComboBox5.Text)
        '    Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
        '    If rdn.Read = True Then
        '        Me.Label15.Text = CInt(rdn!IDA)
        '    End If
        '    rdn.Close()
        'End Using
        'Call Class1.CONNIC()
        'Dim sn1 As String = "select * from DNKEMA where IDA=@IDA AND  IDD=@IDD"
        'Using cmn As New SqlClient.SqlCommand(sn1, cn)
        '    cmn.Parameters.AddWithValue("@IDA", CInt(Label15.Text))
        '    cmn.Parameters.AddWithValue("@IDD", CInt(Label4.Text))
        '    Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
        '    If rdn.Read = True Then
        '        Me.TextBox6.Text = CDbl(rdn!kema)
        '        Me.TextBox5.Text = CDbl(rdn!kemaej)
        '        Me.Label13.Text = CDbl(rdn!kemaej)
        '        Me.TextBox11.Text = CDbl(rdn!kemaej)
        '        Me.TextBox10.Text = CDbl(0)
        '    End If
        '    rdn.Close()
        'End Using
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = True
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B2.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B2.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
            'end using
        End Using
        Call Class1.CONNIC()
        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            'end using
        End Using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!IDD
                Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
                Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
                    cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
                    cmn0.Parameters.AddWithValue("@idk", CInt(B))
                    Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
                    If rdn0.Read = True Then
                        Me.Label2.Text = rdn0!idJ
                    End If
                    rdn0.Close()
                End Using
                Call Class1.CONNIC()
                Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
                Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
                    cmn10.Parameters.AddWithValue("@Xxx1", Label2.Text)
                    cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
                    Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
                    If rdn10.Read = True Then
                        Me.TextBox6.Text = CDbl(rdn10!kema)
                        Me.TextBox5.Text = CDbl(rdn10!kemaej)
                        Me.Label13.Text = CDbl(rdn10!kemaej)
                        Me.TextBox11.Text = CDbl(rdn10!kemaej)
                        Me.TextBox10.Text = CDbl(0)
                    End If
                    rdn10.Close()
                End Using
            End If
            rdn20.Close()
        End Using
        'end using


        'end using


        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        'TextBox15.Text = 0
        Call Class4.CONNIC()
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B3.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B3.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        'end using
        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B4.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B4.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Using dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            'end using
        End Using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk21 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk21.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        TextBox22.Text = B5.Name

        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B5.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B5.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 " 'and idk=@idk"
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            'cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        TextBox22.Text = B6.Name

        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B6.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B6.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and IDK=@IDK"
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@IDK", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using

        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B7.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B7.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Using dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk21 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk21.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B8.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B8.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B9.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B9.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B10.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B10.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B11.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B11.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B12_Click(sender As Object, e As EventArgs) Handles B12.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B12.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B12.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        'Dim sn2 As String = "select * from DOCTORK where dn=@xxx1 "
        'Using cmn2z As New SqlClient.SqlCommand(sn2, cn)
        '    cmn2z.Parameters.AddWithValue("@xxx1", ComboBox2.Text)
        '    Dim rdn2z As SqlClient.SqlDataReader = cmn2z.ExecuteReader
        '    If rdn2z.Read = True Then
        '        Me.Label4.Text = rdn2z!IDD
        '        M7 = rdn2z!IDD
        '        Me.Label14.Text = rdn2z!KESEM
        '        Dim sk18 As String
        '        sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
        '        Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
        '        Dim dsk18 As New DataSet
        '        adk18.Fill(dsk18, "Amaleat")
        '        ComboBox5.DataSource = dsk18.Tables(0)
        '        ComboBox5.DisplayMember = "AML_NAME"
        '    End If
        '    rdn2z.Close()
        'End Using

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idd
            End If
            rdn20.Close()
        End Using
        'end using
        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and idd=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        If ComboBox2.Text <> "" Then
            Call Class1.CONNIC()
            'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
            'Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            '    cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            '    cmn0.Parameters.AddWithValue("@idk", B)
            '    Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            '    If rdn0.Read = True Then
            '        Me.Label2.Text = rdn0!idJ
            '    End If
            '    rdn0.Close()
            'End Using

            'Dim sn2 As String = "select * from DOCTORK where dn=@xxx1 "
            'Using cmn2z As New SqlClient.SqlCommand(sn2, cn)
            '    cmn2z.Parameters.AddWithValue("@xxx1", ComboBox2.Text)
            '    Dim rdn2z As SqlClient.SqlDataReader = cmn2z.ExecuteReader
            '    If rdn2z.Read = True Then
            '        Me.Label4.Text = rdn2z!IDD
            '        M7 = rdn2z!IDD
            '        Me.Label14.Text = rdn2z!KESEM
            '        Dim sk18 As String
            '        sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
            '        Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            '        Dim dsk18 As New DataSet
            '        adk18.Fill(dsk18, "Amaleat")
            '        ComboBox5.DataSource = dsk18.Tables(0)
            '        ComboBox5.DisplayMember = "AML_NAME"
            '    End If
            '    rdn2z.Close()
            'End Using
            'Dim sk18 As String
            'sk18 = "select * from Amaleat" ' where DOCN=" & 895
            'Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            'Dim dsk18 As New DataSet
            'adk18.Fill(dsk18, "Amaleat")
            'ComboBox5.DataSource = dsk18.Tables(0)
            'ComboBox5.DisplayMember = "AML_NAME"
            Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
            Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
                cmn10.Parameters.AddWithValue("@Xxx1", Label2.Text)
                cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
                Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
                If rdn10.Read = True Then
                    Me.TextBox6.Text = CDbl(rdn10!kema)
                    Me.TextBox5.Text = CDbl(rdn10!kemaej)
                    Me.Label13.Text = CDbl(rdn10!kemaej)
                    Me.TextBox11.Text = CDbl(rdn10!kemaej)
                    Me.TextBox10.Text = CDbl(0)
                End If
                rdn10.Close()
            End Using
            DGV1()

            'Dim s1 As String = "select * from APPOINTMENTVIEW "
            'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            'Dim dss As New DataSet
            'dss.Clear()
            'aad.Fill(dss, "APPOINTMENTVIEW")
            'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
            'vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
            'Me.DataGridView1.DataMember = ""
            'DataGridView1.DataSource = vd
            'Dim sn2 As String = "select * from DOCTORK where dn=@xxx1 "
            'Using cmn2z As New SqlClient.SqlCommand(sn2, cn)
            '    cmn2z.Parameters.AddWithValue("@xxx1", ComboBox2.Text)
            '    Dim rdn2z As SqlClient.SqlDataReader = cmn2z.ExecuteReader
            '    If rdn2z.Read = True Then
            '        Me.Label4.Text = rdn2z!IDD
            '        M7 = rdn2z!IDD
            '        Me.Label14.Text = rdn2z!KESEM
            '        Dim sk18 As String
            '        sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
            '        Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            '        Dim dsk18 As New DataSet
            '        adk18.Fill(dsk18, "Amaleat")
            '        ComboBox5.DataSource = dsk18.Tables(0)
            '        ComboBox5.DisplayMember = "AML_NAME"
            '    End If
            '    rdn2z.Close()
            'End Using
            Dim sn2 As String = "select * from dn where dn=@xx1 "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label4.Text = rdn2!idd
                    M7 = rdn2!IDD
                    rdn2.Close()
                    Dim sk18 As String
                    sk18 = "select * from AM_VIEW where IDD='" & CInt(Label4.Text) & "' "
                    Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
                    Dim dsk18 As New DataSet
                    adk18.Fill(dsk18, "AM_VIEW")
                    ComboBox5.DataSource = dsk18.Tables(0)
                    ComboBox5.DisplayMember = "AMl_NAME"
                End If
                rdn2.Close()
            End Using
            Dim a As Integer
            Call Class1.CONNIC()
            Dim sG As String = "select * from KESEM where KESEM=@xx1 "
            Using cmG As New SqlClient.SqlCommand(sG, cn)
                cmG.Parameters.AddWithValue("@xx1", TextBox8.Text)
                Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
                If rdG.Read = True Then
                    a = rdG!IDK
                End If
                rdG.Close()
            End Using
            Dim sk23 As String
            sk23 = "select * from Ejraa where IDK=" & a
            Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
                Dim dsk23 As New DataSet
                adk23.Fill(dsk23, "Ejraa")
                ComboBox3.DataSource = dsk23.Tables(0)
                ComboBox3.DisplayMember = "Ejraa"
                'ComboBox3.SelectedIndex = -1
            End Using
            Call Class4.CONNIC()
        End If


    End Sub

    Private Sub ComboBox2_Validated(sender As Object, e As EventArgs) Handles ComboBox2.Validated
        Call Class1.CONNIC()
        Dim sn2 As String = "select * from DOCTORK where dn=@xxx1 "
        Using cmn2z As New SqlClient.SqlCommand(sn2, cn)
            cmn2z.Parameters.AddWithValue("@xxx1", ComboBox2.Text)
            Dim rdn2z As SqlClient.SqlDataReader = cmn2z.ExecuteReader
            If rdn2z.Read = True Then
                Me.Label4.Text = rdn2z!IDD
                M7 = rdn2z!IDD
                Me.Label14.Text = rdn2z!KESEM
                'Dim sk18 As String
                'sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
                'Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
                'Dim dsk18 As New DataSet
                'adk18.Fill(dsk18, "Amaleat")
                'ComboBox5.DataSource = dsk18.Tables(0)
                'ComboBox5.DisplayMember = "AML_NAME"
            End If
            rdn2z.Close()
        End Using
        'end using
        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and idd=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox2_Validating(sender As Object, e As CancelEventArgs) Handles ComboBox2.Validating
        'Dim sn2 As String = "select * from DOCTORK where dn=@xxx1 "
        'Using cmn2z As New SqlClient.SqlCommand(sn2, cn)
        '    cmn2z.Parameters.AddWithValue("@xxx1", ComboBox2.Text)
        '    Dim rdn2z As SqlClient.SqlDataReader = cmn2z.ExecuteReader
        '    If rdn2z.Read = True Then
        '        Me.Label4.Text = rdn2z!IDD
        '        M7 = rdn2z!IDD
        '        Me.Label14.Text = rdn2z!KESEM
        '        Dim sk18 As String
        '        sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
        '        Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
        '        Dim dsk18 As New DataSet
        '        adk18.Fill(dsk18, "Amaleat")
        '        ComboBox5.DataSource = dsk18.Tables(0)
        '        ComboBox5.DisplayMember = "AML_NAME"
        '    End If
        '    rdn2z.Close()
        'End Using
    End Sub

    Private Sub ComboBox2_ValueMemberChanged(sender As Object, e As EventArgs) Handles ComboBox2.ValueMemberChanged
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!id
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and dn=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        'Dim sn2 As String = "select * from DOCTORK where dn=@xxx1 "
        'Using cmn2z As New SqlClient.SqlCommand(sn2, cn)
        '    cmn2z.Parameters.AddWithValue("@xxx1", ComboBox2.Text)
        '    Dim rdn2z As SqlClient.SqlDataReader = cmn2z.ExecuteReader
        '    If rdn2z.Read = True Then
        '        Me.Label4.Text = rdn2z!IDD
        '        M7 = rdn2z!IDD
        '        Me.Label14.Text = rdn2z!KESEM
        '        Dim sk18 As String
        '        sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
        '        Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
        '        Dim dsk18 As New DataSet
        '        adk18.Fill(dsk18, "Amaleat")
        '        ComboBox5.DataSource = dsk18.Tables(0)
        '        ComboBox5.DisplayMember = "AML_NAME"
        '    End If
        '    rdn2z.Close()
        'End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        'If Label4.Text <> 0 Then
        TextBox11.Text = Val(Label13.Text) - Val(TextBox10.Text)
        'End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        If ComboBox4.Text = "نقدا" And ComboBox3.Text <> "تركيب" Then
            'TextBox10.Text = CDbl(Label13.Text)
            'TextBox16.Text = CDbl(Label13.Text)
            'If TextBox11.Text <> 0 Then
            '    MsgBox("ارجو ادخال القيمة المدفوعة")
            '    TextBox10.Focus()
            '    Exit Sub
            'End If
        End If
        M6 = Label10.Text
        'Dim k1 As Integer = 0
        'Do While k1 < 100
        '    Dim i As Integer
        '    i = M6
        '    Dim s1 As String = "select * from KASHEF where ESALNO=@xx1"
        '    Dim cm1 As New SqlClient.SqlCommand(s1, cn)
        '    cm1.Parameters.AddWithValue("@xx1", i)
        '    Dim rd1 As SqlClient.SqlDataReader
        '    rd1 = cm1.ExecuteReader
        '    Do While rd1.Read = True
        '        i = i + 1
        '        Dim ss1 As String = "select * from KASHEF where ESALNO=@xx1"
        '        Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
        '        cmm1.Parameters.AddWithValue("@xx1", i)
        '        rd1 = cmm1.ExecuteReader
        '        M6 = i
        '    Loop
        '    rd1.Close()
        '    k1 = k1 + 1
        'Loop
        'End Try
        '  Dim ss2 As String = "insert into appointment(IDPAT,chno,Datea,from,to)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5)"
        Call Class1.CONNIC()
        Dim ss21 As String = "update kashef set fnumber=@fnumber,DATEX=@DATEX,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME" & vbNewLine &
                             "where Esalno=@Esalno"
        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        Using cmm21 As New SqlClient.SqlCommand(ss21, cn)
            cmm21.Parameters.AddWithValue("@fnumber", TextBox2.Text)
            ' cmm21.Parameters.AddWithValue("@CHNO", Me.NumericUpDown1.Text)
            cmm21.Parameters.AddWithValue("@DATEX", Me.DateTimePicker3.Text)
            cmm21.Parameters.AddWithValue("@doctorname", Me.ComboBox2.Text)
            'cmm21.Parameters.AddWithValue("@KEMA", M6)
            cmm21.Parameters.AddWithValue("@KEMA", TextBox6.Text)
            cmm21.Parameters.AddWithValue("@KEMAT", Label13.Text)
            cmm21.Parameters.AddWithValue("@MADFOO", TextBox10.Text)
            cmm21.Parameters.AddWithValue("@BAKY", TextBox11.Text)
            cmm21.Parameters.AddWithValue("@conf", True)
            cmm21.Parameters.AddWithValue("@USER_NAME", user)
            cmm21.Parameters.AddWithValue("@Esalno", CDbl(Label10.Text))
            'Try
            'Dim sd1 As String = "delete * from appointment where Esalno=xx"
            'Dim cd1 As New SqlClient.SqlCommand(sd1, cn)
            'cd1.Parameters.AddWithValue("xx", Me.Label10.Text)
            'Try
            '    cd1.ExecuteNonQuery()
            'Catch ex As Exception

            'End Try
            'Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,doctorname,IDM,EJRAA,Esalno)VALUES(XX@xx1,XXXX2,xxxx3,xxxx6,xxxx7,xxxx8,xxxx9)"
            ''    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            'Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            ''cmm2.Parameters.AddWithValue("XX", Label10.Text)
            'cmm2.Parameters.AddWithValue("xx@xx1", TextBox2.Text)
            'cmm2.Parameters.AddWithValue("xxxx2", M7)
            'cmm2.Parameters.AddWithValue("xxxx3", Me.DateTimePicker3.Text)
            ''cmm2.Parameters.AddWithValue("xxxx4", Me.MaskedTextBox2.Text)
            ''cmm2.Parameters.AddWithValue("xxxx5", Me.MaskedTextBox3.Text)
            'cmm2.Parameters.AddWithValue("xxxx6", Me.ComboBox2.Text)
            'cmm2.Parameters.AddWithValue("xxxx7", 1)
            'cmm2.Parameters.AddWithValue("xxxx8", Me.ComboBox3.Text)
            'cmm2.Parameters.AddWithValue("xxxx9", Label10.Text)
            Try
                cmm21.ExecuteNonQuery()
                Dim ssD As String = "insert into Amaleat_M(IDA,docn,dock,tdocn,tdock,mdocn,mdock,fdocn,fdock,ftdocn,ftdock,tahn,tahk,kabn,kabk,cdocn,cdock,aml_kema,C_KEMA,DATEX,ESALNO)values(@IDA,@docn,@dock,@tdocn,@tdock,@mdocn,@mdock,@fdocn,@fdock,@ftdocn,@ftdock,@tahn,@tahk,@kabn,@kabk,@cdocn,@cdock,@aml_kema,@C_KEMA,@DATEX,@ESALNO)"
                Using cmmD As New SqlClient.SqlCommand(ssD, cn)
                    cmmD.Parameters.AddWithValue("@IDA", CInt(Label15.Text))
                    cmmD.Parameters.AddWithValue("@docn", CInt(Label4.Text))
                    cmmD.Parameters.AddWithValue("@dock", CDbl(TextBox6.Text))
                    cmmD.Parameters.AddWithValue("@tdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@tdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@mdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@mdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@fdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@fdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@ftdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@ftdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@tahn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@tahk", CDbl(0))
                    cmmD.Parameters.AddWithValue("@kabn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@kabk", CDbl(0))
                    cmmD.Parameters.AddWithValue("@cdocn", "لايوجد")
                    cmmD.Parameters.AddWithValue("@cdock", CDbl(0))
                    cmmD.Parameters.AddWithValue("@aml_kema", CDbl(TextBox5.Text))
                    cmmD.Parameters.AddWithValue("@C_KEMA", CDbl(0))
                    cmmD.Parameters.AddWithValue("@DATEX", Date.Today.Date)
                    cmmD.Parameters.AddWithValue("@ESALNO", CDbl(Label10.Text))
                    'TextBox9.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
                    Try
                        cmmD.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try
                End Using

                If Val(TextBox16.Text) <> 0 Then
                    Dim s222 As String = "insert into SADAD(ESALNO,DATEXX,SADAD) values(@ESALNO,@DATEXX,@SADAD)"
                    Dim cm222 As New SqlClient.SqlCommand(s222, cn)
                    cm222.Parameters.AddWithValue("@ESALNO", Label10.Text)
                    cm222.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
                    cm222.Parameters.AddWithValue("@SADAD", CDbl(Me.TextBox16.Text))
                    Try
                        cm222.ExecuteNonQuery()
                    Catch ex As Exception
                    End Try
                End If
                'MsgBox("تم تأكيد الحجز")
                'vv1 = CInt(Label10.Text)
                'Dim F As New ESALHAJEZ
                'F.KESEM_P = Label14.Text
                'F.ShowDialog()
                'Dim cr1 As New CrystalReport31, cri As String
                'cri = "{KASHEF.ESALNO}=" & "" & Label10.Text & ""
                'KESEM_P = Label14.Text
                'cr1.SetParameterValue(0, Me.KESEM_P)
                'cr1.RecordSelectionFormula = cri
                'cr1.PrintOptions.PrinterName = "PR"
                ''cr1.PrintOptions.PrinterName = "LK-TE212"
                'cr1.SetDatabaseLogon("adgh", "13061982", "syslc\sqlexpress", "clinicsql")
                'cr1.PrintToPrinter(1, False, 1, 1)
                '================================================================================
                Dim crtableLogoninfos As New TableLogOnInfos()
                Dim crtableLogoninfo As New TableLogOnInfo()
                Dim crConnectionInfo As New ConnectionInfo()
                Dim CrTables As Tables
                Dim CrTable As Table
                Dim TableCounter
                Dim reader As New System.IO.StreamReader("server.txt")
                Dim allLines As List(Of String) = New List(Of String)
                Do While Not reader.EndOfStream
                    allLines.Add(reader.ReadLine())
                Loop
                reader.Close()
                Dim crReportDocument As New CrystalReport31(), cri2 As String
                crReportDocument.Load("CrystalReport31.rpt")
                cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
                KESEM_P = TextBox8.Text
                NAMEC = My.Settings.CLIN
                With crConnectionInfo
                    .ServerName = ReadLine(2, allLines)
                    .DatabaseName = ReadLine(1, allLines)
                    .UserID = "AH"
                    .Password = "123456"
                End With
                CrTables = crReportDocument.Database.Tables
                For Each CrTable In CrTables
                    crtableLogoninfo = CrTable.LogOnInfo
                    crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                    CrTable.ApplyLogOnInfo(crtableLogoninfo)
                    CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
                Next
                crReportDocument.SetParameterValue(0, Me.KESEM_P)
                crReportDocument.SetParameterValue(1, Me.NAMEC)
                crReportDocument.RecordSelectionFormula = cri2
                crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
                crReportDocument.PrintToPrinter(1, True, 0, 0)
                crReportDocument.Close()
                crReportDocument.Dispose()

                '================================================================================
            Catch ex As Exception
                MsgBox("no print")
            End Try
            Me.TextBox3.Enabled = False
            Me.ComboBox1.Enabled = False
            'Me.ComboBox3.Enabled = False
            Me.ComboBox4.Enabled = False
            Me.DateTimePicker3.Enabled = False
            Me.DateTimePicker3.Value = Date.Today
            Me.DateTimePicker1.Value = Date.Today
            Me.DateTimePicker2.Value = Date.Today
            Me.TextBox3.Text = ""
            Me.ComboBox1.Text = ""
            Me.ComboBox3.Text = ""
            Me.ComboBox4.Text = ""
            Me.ComboBox2.Text = ""
            ComboBox3.Text = "كشف"

            'Catch ex As Exception

            'End Try
            '' cmm.ExecuteNonQuery()
            'cmm2.ExecuteNonQuery()


            Dim sk1 As String
            sk1 = "select * from MAIN"
            Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
            Dim dsk1 As New DataSet
            adk1.Fill(dsk1, "MAIN")
            ComboBox1.DataSource = dsk1.Tables(0)
            ComboBox1.DisplayMember = "NAMEX"
            ComboBox1.SelectedIndex = -1
            'end using
            'end using

            Dim sk2 As String
            sk2 = "select * from dn"
            Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ComboBox2.SelectedIndex = -1
            'end using
            'end using

            Dim sk4 As String
            sk4 = "select * from Mostafeed"
            Dim adk4 As New SqlClient.SqlDataAdapter(sk4, cn)
            Dim dsk4 As New DataSet
            adk4.Fill(dsk4, "Mostafeed")
            ComboBox4.DataSource = dsk4.Tables(0)
            ComboBox4.DisplayMember = "NameM"
            ComboBox4.SelectedIndex = -1
            'end using
            'end using

            Dim sk3 As String
            sk3 = "select * from Ejraa"
            Dim adk3 As New SqlClient.SqlDataAdapter(sk3, cn)
            Dim dsk3 As New DataSet
            adk3.Fill(dsk3, "Ejraa")
            ComboBox3.DataSource = dsk3.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.SelectedIndex = -1
            Me.TextBox3.Focus()
            ComboBox3.Text = "كشف"
            ComboBox4.Text = "نقدا"
            TextBox4.Text = "نقدا"
            Label9.Text = "نقدا"
            DataGridView1.Rows.Clear()
            If ewaa = True Then
                Label12.Text = sano
                GroupBox10.Visible = True
                ComboBox3.DropDownStyle = ComboBoxStyle.DropDown
                ComboBox3.Text = "إيواء"
                ComboBox3.Enabled = False
                ewaa = False
            End If
            'end using
            'end using

            Dim k As Integer = 1
            Dim i As Integer
            i = 1
            Do While k < 100
                Call Class1.CONNIC()
                Dim sB As String = "select * from KESEM where IDK=@xx1 "
                Dim cmB As New SqlClient.SqlCommand(sB, cn)
                cmB.Parameters.AddWithValue("@xx1", i)
                Dim rdB As SqlClient.SqlDataReader = cmB.ExecuteReader
                Do While rdB.Read = True
                    If i = 0 Then
                        B0.Visible = True
                        B0.Text = rdB!KESEM
                    ElseIf i = 1 Then
                        B1.Visible = True
                        B1.Text = rdB!KESEM
                    ElseIf i = 2 Then
                        B2.Visible = True
                        B2.Text = rdB!KESEM
                    ElseIf i = 3 Then
                        B3.Visible = True
                        B3.Text = rdB!KESEM
                    ElseIf i = 4 Then
                        B4.Visible = True
                        B4.Text = rdB!KESEM
                    ElseIf i = 5 Then
                        B5.Visible = True
                        B5.Text = rdB!KESEM
                    ElseIf i = 6 Then
                        B6.Visible = True
                        B6.Text = rdB!KESEM
                    ElseIf i = 7 Then
                        B7.Visible = True
                        B7.Text = rdB!KESEM
                    ElseIf i = 8 Then
                        B8.Visible = True
                        B8.Text = rdB!KESEM
                    ElseIf i = 9 Then
                        B9.Visible = True
                        B9.Text = rdB!KESEM
                    ElseIf i = 10 Then
                        B10.Visible = True
                        B10.Text = rdB!KESEM
                    ElseIf i = 11 Then
                        B11.Visible = True
                        B11.Text = rdB!KESEM
                    ElseIf i = 12 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf i = 13 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf i = 14 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf i = 15 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf i = 16 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf i = 17 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf i = 18 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf i = 19 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    ElseIf i = 20 Then
                        B12.Visible = True
                        B12.Text = rdB!KESEM
                    End If
                    i = i + 1
                Loop
                rdB.Close()
                k = k + 1
                'end using
                'end using

            Loop
            'Dim sM As String = "select * from amaleat_M where IDA=@xxx1 "
            'Using cmD As New SqlClient.SqlCommand(sM, cn)
            '    cmD.Parameters.AddWithValue("@xxx1", CInt(Label15.Text))
            '    Dim rdM As SqlClient.SqlDataReader = cmD.ExecuteReader
            '    If rdM.Read = True Then
            'Dim ssM As String = "update Amaleat_M set docn=@docn,dock=@dock,tdocn=@tdocn,tdock=@tdock,mdocn=@mdocn,mdock=@mdock,fdocn=@fdocn,fdock=@fdock,ftdocn=@ftdocn,ftdock=@ftdock,tahn=@tahn,tahk=@tahk,kabn=@kabn,kabk=@kabk,cdocn=@cdocn,cdock=@cdock,aml_kema=@aml_kema,C_KEMA=@C_KEMA where IDA=@IDA"
            'Using cmmM As New SqlClient.SqlCommand(ssM, cn)
            '    cmmM.Parameters.AddWithValue("@docn", CInt(Label4.Text))
            '    cmmM.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
            '    cmmM.Parameters.AddWithValue("@tdocn", "لايوجد")
            '    cmmM.Parameters.AddWithValue("@tdock", CDbl(0))
            '    cmmM.Parameters.AddWithValue("@mdocn", "لايوجد")
            '    cmmM.Parameters.AddWithValue("@mdock", CDbl(0))
            '    cmmM.Parameters.AddWithValue("@fdocn", "لايوجد")
            '    cmmM.Parameters.AddWithValue("@fdock", CDbl(0))
            '    cmmM.Parameters.AddWithValue("@ftdocn", "لايوجد")
            '    cmmM.Parameters.AddWithValue("@ftdock", CDbl(0))
            '    cmmM.Parameters.AddWithValue("@tahn", "لايوجد")
            '    cmmM.Parameters.AddWithValue("@tahk", CDbl(0))
            '    cmmM.Parameters.AddWithValue("@kabn", "لايوجد")
            '    cmmM.Parameters.AddWithValue("@kabk", CDbl(0))
            '    cmmM.Parameters.AddWithValue("@cdocn", "لايوجد")
            '    cmmM.Parameters.AddWithValue("@cdock", CDbl(0))
            '    cmmM.Parameters.AddWithValue("@aml_kema", CDbl(0))
            '    cmmM.Parameters.AddWithValue("@IDA", CInt(Label15.Text))
            '    cmmM.Parameters.AddWithValue("@C_KEMA", CDbl(0))
            '    Try
            '        cmmM.ExecuteNonQuery()
            '    Catch ex As Exception

            '    End Try
            'End Using
            'Else

            'End If
        End Using

        TextBox10.Text = 0
        TextBox16.Text = 0
        TextBox11.Text = 0
        Button6.Visible = False
        '    Catch ex As Exception

        'End Try
        'End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ComboBox2.Text = "" Then
            MsgBox("يرجة تحديد اسم الطبيب")
        Else
            Call DGV1()

            'Call Class1.CONNIC()
            'Dim s1 As String = "select * from APPOINTMENTVIEW "
            'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            'Dim dss As New DataSet
            'dss.Clear()
            'aad.Fill(dss, "APPOINTMENTVIEW")
            'Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
            'vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND DN=" & "'" & Me.ComboBox2.Text & "'" & ""
            'Me.DataGridView1.DataMember = ""
            'DataGridView1.DataSource = vd
            'end using
            'end using
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub ComboBox5_Leave(sender As Object, e As EventArgs) Handles ComboBox5.Leave
        Call Class1.CONNIC()
        Dim sn As String = "select * from AMALEAT where AML_NAME=@AML_NAME "
        Using cmn As New SqlClient.SqlCommand(sn, cn)
            cmn.Parameters.AddWithValue("@AML_NAME", ComboBox5.Text)
            Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
            If rdn.Read = True Then
                Me.Label15.Text = CInt(rdn!IDA)

            End If
            rdn.Close()
        End Using
        Call Class1.CONNIC()
        Dim sn1 As String = "select * from DNKEMA where IDA=@IDA AND  IDD=@IDD"
        Using cmn As New SqlClient.SqlCommand(sn1, cn)
            cmn.Parameters.AddWithValue("@IDA", CInt(Label15.Text))
            cmn.Parameters.AddWithValue("@IDD", CInt(Label4.Text))
            Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
            If rdn.Read = True Then
                Me.TextBox6.Text = CDbl(rdn!kema)
                Me.TextBox5.Text = CDbl(rdn!kemaej)
                Me.Label13.Text = CDbl(rdn!kemaej)
                Me.TextBox11.Text = CDbl(rdn!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn.Close()
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        'If ComboBox5.SelectedIndex <> -1 Then
        If GroupBox14.Visible = True Then
            Call Class1.CONNIC()
            Dim sn As String = "select * from AMALEAT where AML_NAME=@AML_NAME "
            Using cmn As New SqlClient.SqlCommand(sn, cn)
                cmn.Parameters.AddWithValue("@AML_NAME", Trim(ComboBox5.Text))
                Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
                If rdn.Read = True Then
                    Me.Label15.Text = CInt(rdn!IDA)
                    Dim sn1 As String = "select * from DNKEMA where IDA=@IDA "
                    Using cmn2 As New SqlClient.SqlCommand(sn1, cn)
                        cmn2.Parameters.AddWithValue("@IDA", CInt(Label15.Text))
                        'cmn2.Parameters.AddWithValue("@IDD", CInt(Label4.Text))
                        Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                        If rdn2.Read = True Then
                            Me.TextBox6.Text = CDbl(rdn2!kema)
                            Me.TextBox5.Text = CDbl(rdn2!kemaej)
                            Me.Label13.Text = CDbl(rdn2!kemaej)
                            Me.TextBox11.Text = CDbl(rdn2!kemaej)
                            Me.TextBox10.Text = CDbl(0)
                        End If
                        rdn2.Close()
                    End Using
                End If
                rdn.Close()
            End Using
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox3_TextChanged(sender As Object, e As EventArgs) Handles ComboBox3.TextChanged
        If ComboBox3.Text = "عمليات" Then
            GroupBox14.Visible = True
        Else
            GroupBox14.Visible = False
        End If
        If ComboBox3.Text = "عمليات" Then
            GroupBox14.Visible = True
            ComboBox5.SelectedIndex = 0
            'Dim sn2 As String = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
            '         FROM dbo.dn INNER JOIN
            '         dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD where dbo.dn.IDK=" & B
            'Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
            '    cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            '    Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
            '    If rdn2.Read = True Then
            '        Me.Label4.Text = rdn2!IDD
            '        M7 = rdn2!IDD
            '    End If
            'End Using
            'Dim sk18 As String
            'sk18 = "select * from Amaleat where DOCN='" & M7 & "' "
            'Dim adk18 As New SqlClient.SqlDataAdapter(sk18, cn)
            'Dim dsk18 As New DataSet
            'adk18.Fill(dsk18, "Amaleat")
            'ComboBox5.DataSource = dsk18.Tables(0)
            'ComboBox5.DisplayMember = "AML_NAME"
            Call Class1.CONNIC()
            'Dim sk2 As String = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
            '         FROM dbo.dn INNER JOIN
            '         dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD where dbo.dn.IDK=" & B
            'Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            '    Dim dsk2 As New DataSet
            '    adk2.Fill(dsk2, "dn")
            '    ComboBox2.DataSource = dsk2.Tables(0)
            '    ComboBox2.DisplayMember = "dn"
            '    ''ComboBox2.SelectedIndex = -1
            '    'end using
            'End Using
            Dim sn1 As String = "select * from dnkema where IDA=@xxxx2 "
            Using cmn1 As New SqlClient.SqlCommand(sn1, cn)
                'cmn1.Parameters.AddWithValue("@xxxx1", CInt(Label2.Text))
                cmn1.Parameters.AddWithValue("@xxxx2", CInt(Label15.Text))
                Dim rdn1 As SqlClient.SqlDataReader = cmn1.ExecuteReader
                If rdn1.Read = True Then
                    Me.TextBox6.Text = CDbl(rdn1!kema)
                    Me.TextBox5.Text = CDbl(rdn1!kemaej)
                    Me.Label13.Text = CDbl(rdn1!kemaej)
                    Me.TextBox11.Text = CDbl(rdn1!kemaej)
                    Me.TextBox10.Text = CDbl(0)
                End If
                rdn1.Close()
            End Using

            'End If
            'End Using
        Else
            GroupBox14.Visible = False

            If String.IsNullOrWhiteSpace(ComboBox3.Text) = False Then
                Call Class1.CONNIC()
                Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and IDK=@IDK"
                Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
                    cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
                    cmn0.Parameters.AddWithValue("@IDK", CInt(Label23.Text))
                    Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
                    If rdn0.Read = True Then
                        Me.Label2.Text = rdn0!idJ
                        'Label4.Text = rdn0!idd
                    End If
                    rdn0.Close()
                End Using

                'end using

                Dim sn12 As String = "select * from dnkema where Ejraa=@xxxx1 and IDD=@xxxx2 "
                Using cmn12 As New SqlClient.SqlCommand(sn12, cn)
                    cmn12.Parameters.AddWithValue("@xxxx1", CInt(Label2.Text))
                    cmn12.Parameters.AddWithValue("@xxxx2", CInt(Label4.Text))
                    Dim rdn12 As SqlClient.SqlDataReader = cmn12.ExecuteReader
                    If rdn12.Read = True Then
                        Me.TextBox6.Text = CDbl(rdn12!kema)
                        Me.TextBox5.Text = CDbl(rdn12!kemaej)
                        Me.Label13.Text = CDbl(rdn12!kemaej)
                        Me.TextBox11.Text = CDbl(rdn12!kemaej)
                    End If
                    rdn12.Close()
                End Using

            End If
        End If

    End Sub

    Private Sub ComboBox3_TextUpdate(sender As Object, e As EventArgs) Handles ComboBox3.TextUpdate
        If ComboBox3.Text = "عمليات" Then
            GroupBox14.Visible = True
        Else
            GroupBox14.Visible = False
        End If
    End Sub

    Private Sub ComboBox5_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedValueChanged
        'If ComboBox5.SelectedIndex <> -1 Then
        Call Class1.CONNIC()
        Dim sn As String = "select * from AMALEAT where AML_NAME=@AML_NAME "
        Using cmn As New SqlClient.SqlCommand(sn, cn)
            cmn.Parameters.AddWithValue("@AML_NAME", ComboBox5.Text)
            Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
            If rdn.Read = True Then
                Me.Label15.Text = CInt(rdn!IDA)
            End If
            rdn.Close()
        End Using
        Call Class1.CONNIC()
        Dim sn1 As String = "select * from DNKEMA where IDA=@IDA AND IDD=@IDD "
        Using cmn As New SqlClient.SqlCommand(sn1, cn)
            cmn.Parameters.AddWithValue("@IDA", CInt(Label15.Text))
            cmn.Parameters.AddWithValue("@IDD", CInt(Label4.Text))
            Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
            If rdn.Read = True Then
                Me.TextBox6.Text = CDbl(rdn!kema)
                Me.TextBox5.Text = CDbl(rdn!kemaej)
                Me.Label13.Text = CDbl(rdn!kemaej)
                Me.TextBox11.Text = CDbl(rdn!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn.Close()
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox5_TextChanged(sender As Object, e As EventArgs) Handles ComboBox5.TextChanged
        'If ComboBox5.SelectedIndex <> -1 Then
        Call Class1.CONNIC()
        Dim sn As String = "select * from AMALEAT where AML_NAME=@AML_NAME "
        Using cmn As New SqlClient.SqlCommand(sn, cn)
            cmn.Parameters.AddWithValue("@AML_NAME", ComboBox5.Text)
            Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
            If rdn.Read = True Then
                Me.Label15.Text = CInt(rdn!IDA)
            End If
            rdn.Close()
        End Using
        Call Class1.CONNIC()
        Dim sn1 As String = "select * from DNKEMA where IDA=@IDA "
        Using cmn As New SqlClient.SqlCommand(sn1, cn)
            cmn.Parameters.AddWithValue("@IDA", CInt(Label15.Text))
            'cmn.Parameters.AddWithValue("@IDD", CInt(Label4.Text))
            Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
            If rdn.Read = True Then
                Me.TextBox6.Text = CDbl(rdn!kema)
                Me.TextBox5.Text = CDbl(rdn!kemaej)
                Me.Label13.Text = CDbl(rdn!kemaej)
                Me.TextBox11.Text = CDbl(rdn!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn.Close()
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        If Trim(TextBox15.Text) = "" Or Val(TextBox15.Text) = 0 Then
            Button6.Enabled = False
        Else
            Button6.Enabled = True
        End If
        'If CDbl(Label13.Text) = CDbl(0) Then

        'If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("ادويه") Or ComboBox3.Text = Trim("تغذيه") Or ComboBox3.Text = Trim("خرم") Then
        If ComboBox4.Text = Trim("نقدا") Then
            TextBox10.Text = Val(TextBox15.Text)
            TextBox9.Text = Val(TextBox15.Text)
            Label13.Text = Val(TextBox15.Text)
            TextBox11.Text = 0
        Else
            TextBox10.Text = 0
            TextBox11.Text = Val(TextBox15.Text)
            TextBox9.Text = Val(TextBox15.Text)
            Label13.Text = Val(TextBox15.Text)
        End If
        'Else
        'TextBox10.Text = Val(TextBox16.Text) + Val(TextBox15.Text)
        'End If

    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox2.Enabled = True
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B0.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B0.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If
        If Trim(ComboBox2.Text) <> "" Then
            Call Class1.CONNIC()
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Call Class1.CONNIC()
        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        Call Class1.CONNIC()
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        Timer2.Stop()
        TextBox15.Text = ""
        DataGridView2.DataSource = ""
        If B - 0 Then
            TextBox15.ReadOnly = False
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label21.BackColor = Color.DarkRed Then
            Label21.BackColor = Color.Transparent
        Else
            Label21.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form10_Load(Nothing, Nothing)
    End Sub

    Private Sub B13_Click(sender As Object, e As EventArgs) Handles B13.Click
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B13.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B13.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B14_Click(sender As Object, e As EventArgs) Handles B14.Click
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B14.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B14.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B15_Click(sender As Object, e As EventArgs) Handles B15.Click
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B15.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B15.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B16_Click(sender As Object, e As EventArgs) Handles B16.Click
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B16.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B16.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B17_Click(sender As Object, e As EventArgs) Handles B17.Click
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B17.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B17.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Call Class1.CONNIC()

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using
        Call Class1.CONNIC()

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Call Class1.CONNIC()
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B18_Click(sender As Object, e As EventArgs) Handles B18.Click
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B18.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B18.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B19_Click(sender As Object, e As EventArgs) Handles B19.Click
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B19.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B19.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub B20_Click(sender As Object, e As EventArgs) Handles B20.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B20.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B20.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox4_TextChanged(sender As Object, e As EventArgs) Handles ComboBox4.TextChanged
        ComboBox4.MaxLength = 32

        'If ComboBox4.Text = "" Then
        '    Label9.Text = ""
        'Else
        '    Dim s As String = "select * from Mostafeed where NameM=@xx1"
        '    Using cm As New SqlClient.SqlCommand(s, cn)
        '        cm.Parameters.AddWithValue("@xx1", Me.ComboBox4.Text)
        '        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        '        If rd.Read = True Then
        '            TextBox4.Text = rd!JehaM
        '            Label9.Text = rd!JehaM
        '            Label8.Text = rd!IDM
        '        End If
        '        rd.Close()
        '    End Using
        '    'end using
        'End If

    End Sub

    Private Sub ComboBox4_Validated(sender As Object, e As EventArgs) Handles ComboBox4.Validated
        Call Class1.CONNIC()
        Dim s1 As String = "select * from Mostafeed where namem=@xxxxx1"
        Using cm1 As New SqlClient.SqlCommand(s1, cn)
            cm1.Parameters.AddWithValue("@xxxxx1", Me.ComboBox4.Text)
            Dim rd1 As SqlClient.SqlDataReader = cm1.ExecuteReader
            If rd1.Read = True Then
                TextBox4.Text = rd1!JehaM
                ComboBox4.Text = rd1!NameM
                rd1.Close()
            Else
                MsgBox("المستفيد غير موجود...سيتم نقلك إلى واجهة المستفيد")
                Dim fn As New Mostafeed
                dgx = Trim(ComboBox4.Text)
                Most = True
                fn.ShowDialog()
                Most = False
                Dim sk4 As String
                sk4 = "select * from Mostafeed"
                Dim adk4 As New SqlClient.SqlDataAdapter(sk4, cn)
                Dim dsk4 As New DataSet
                adk4.Fill(dsk4, "Mostafeed")
                ComboBox4.DataSource = dsk4.Tables(0)
                ComboBox4.DisplayMember = "NameM"
                ComboBox4.SelectedIndex = -1
                ComboBox4.Text = namemx
                Label9.Text = jehamx
                TextBox4.Text = jehamx
            End If
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Val(DataGridView1.Rows.Count) = 0 Then
            ContextMenuStrip1.Enabled = False
        Else
            ContextMenuStrip1.Enabled = True
        End If
    End Sub

    Private Sub DateTimePicker3_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If GroupBox15.Visible = True Then
                TextBox15.Focus()
            Else
                TextBox10.Focus()
            End If
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Call Class1.CONNIC()
        'Me.Label1.Text = 1
        Dim Str As String = "SELECT MAX(CHNO) FROM appointment WHERE datea=@xx2 and doctorname=@xx3"
        Using cmd As New SqlClient.SqlCommand(Str, cn)
            cmd.Parameters.AddWithValue("@xx2", DateTimePicker3.Value.Date)
            cmd.Parameters.AddWithValue("@xx3", Me.Label4.Text)
            If IsDBNull(cmd.ExecuteScalar) = True Then
                Me.Label1.Text = 1
                Me.Label16.Text = 1
                Me.Label5.Text = 1
            Else
                Label1.Text = Val(cmd.ExecuteScalar) + 1
                Label16.Text = Val(cmd.ExecuteScalar) + 1
                Label5.Text = Val(cmd.ExecuteScalar) + 1
            End If
        End Using
        Dim CurruntCulture = Globalization.CultureInfo.CurrentCulture
        Label25.Text = CurruntCulture.DateTimeFormat.GetDayName(DateTime.Parse(DateTimePicker3.Value).DayOfWeek)
        Call Class4.CONNIC()
    End Sub

    Private Sub DateTimePicker1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            Button7.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub تعديلالقيمةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلالقيمةToolStripMenuItem.Click
        GroupBox15.Visible = True
        TextBox15.Focus()
    End Sub

    Private Sub B21_Click(sender As Object, e As EventArgs) Handles B21.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B21.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B21.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B22_Click(sender As Object, e As EventArgs) Handles B22.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B22.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B22.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B23_Click(sender As Object, e As EventArgs) Handles B23.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B23.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B23.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using
        If TextBox8.Text = "العمليات" Or TextBox8.Text = "عمليات" Then
            sk2 = "SELECT dbo.dn.IDD, dbo.dn.dn, dbo.AM_DOC.IDA, dbo.dn.IDK
                   FROM dbo.dn INNER JOIN
                   dbo.AM_DOC ON dbo.dn.IDD = dbo.AM_DOC.IDD" ' where dbo.dn.IDK=" & B
            Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox2.DataSource = dsk2.Tables(0)
                ComboBox2.DisplayMember = "dn"
                ''ComboBox2.SelectedIndex = -1
                'end using
            End Using
        End If

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B24_Click(sender As Object, e As EventArgs) Handles B24.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B24.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B24.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B25_Click(sender As Object, e As EventArgs) Handles B25.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B25.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B25.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub B26_Click(sender As Object, e As EventArgs) Handles B26.Click
        Call Class1.CONNIC()
        GroupBox15.Visible = False
        Me.ComboBox2.Enabled = True
        Me.TextBox3.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ComboBox3.Enabled = True
        Me.ComboBox4.Enabled = False
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        TextBox8.Text = B26.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B26.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            With rdG.Read = True
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End With
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
        End Using
        'end using

        Dim sn20 As String = "select * from dn where dn=@xx1 "
        Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
            cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
            Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
            If rdn20.Read = True Then
                Me.Label4.Text = rdn20!idD
            End If
            rdn20.Close()
        End Using
        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            cmn0.Parameters.AddWithValue("@idk", B)
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label2.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
            cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label13.Text = CDbl(rdn10!kemaej)
                Me.TextBox11.Text = CDbl(rdn10!kemaej)
                Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using

        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        DataGridView2.DataSource = ""
        Label21.Text = ""
        Label21.BackColor = Color.Transparent
        TextBox15.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub DateTimePicker3_Validated(sender As Object, e As EventArgs) Handles DateTimePicker3.Validated
    End Sub

    Private Sub DateTimePicker3_Validating(sender As Object, e As CancelEventArgs) Handles DateTimePicker3.Validating

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub

    Private Sub TextBox10_Enter(sender As Object, e As EventArgs) Handles TextBox10.Enter
        If Val(TextBox10.Text) = CDbl(0) Then
            TextBox10.Text = ""
        End If
    End Sub

    Private Sub TextBox10_Validated(sender As Object, e As EventArgs) Handles TextBox10.Validated
        If String.IsNullOrWhiteSpace(TextBox10.Text) Then
            TextBox10.Text = "0"
        End If
    End Sub
    Private Sub TextBox15_Enter(sender As Object, e As EventArgs) Handles TextBox15.Enter
        If Val(TextBox15.Text) = CDbl(0) Then
            TextBox15.Text = ""
        End If
    End Sub

    Private Sub TextBox15_Validated(sender As Object, e As EventArgs) Handles TextBox15.Validated
        If String.IsNullOrWhiteSpace(TextBox15.Text) Then
            TextBox15.Text = "0"
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Select Case e.ColumnIndex
            Case Is >= 0
                Select Case e.RowIndex
                    Case Is >= 0
                        ContextMenuStrip2.Enabled = True

                        'Label20.Text = DataGridView1.Item(1, e.RowIndex).Value()
                        dgx = DataGridView1.Item(1, e.RowIndex).Value()
                        Dim i As Integer
                        i = e.RowIndex
                        num = e.RowIndex
                        If Val(i) >= 0 Then
                            Dim dgx As Integer
                            dgx = DataGridView1.Item(1, e.RowIndex).Value()
                            Label20.Text = DataGridView1.Item(1, e.RowIndex).Value()
                            dgxx = DataGridView1.Item(2, e.RowIndex).Value()
                            Me.Label5.Text = dgxx
                            Me.Label16.Text = dgxx
                            'Label17.Text = DataGridView1.Item(0, i).Value()
                            'dgx = Me.DataGridView1.CurrentCell.Value
                            'Label8.Text = dgx
                            Call Class1.CONNIC()
                            Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno and chno=@chno"
                            Dim cm As New SqlClient.SqlCommand(s, cn)
                            cm.Parameters.AddWithValue("@Esalno", dgx)
                            cm.Parameters.AddWithValue("@chno", dgxx)
                            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                            If rd.Read = True Then
                                Me.ComboBox2.Text = rd!DN
                                Me.ComboBox3.Text = rd!Ejraa
                                Me.ComboBox2.Enabled = True
                                Me.ComboBox3.Enabled = True
                                Me.ComboBox4.Enabled = True
                                Me.TextBox3.Text = rd!chno
                                Me.TextBox2.Text = rd!fnumber
                                M7 = rd!CHNO
                                Me.Label10.Text = rd!Esalno
                                Me.ComboBox4.Text = rd!NAMEM
                                Me.TextBox4.Text = rd!JEHAM
                                Me.Label9.Text = rd!JEHAM
                                Me.DateTimePicker3.Text = rd!datea
                                Me.TextBox3.Enabled = True
                                'Me.ComboBox3.Enabled = False
                                'Me.ComboBox4.Enabled = True
                                Me.DateTimePicker3.Enabled = True
                                Button2.Enabled = False
                                Me.ComboBox1.Text = rd!namex
                                Me.ComboBox1.Enabled = True
                                rd.Close()
                                'Me.ComboBox1.Text = Label22.Text
                                'Me.ComboBox1.Enabled = False
                                'Call Class1.CONNIC()
                                'Dim sk As String = "select * from KASHEF where Esalno=@Esalno"
                                'Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                'cmk.Parameters.AddWithValue("@Esalno", dgx)
                                'Dim rdk As SqlClient.SqlDataReader = cm.ExecuteReader
                                'If rdk.Read = True Then
                                '    'TextBox10.Text = rdk!MADFOO
                                '    TextBox11.Text = rdk!baky
                                'End If

                                rd.Close()
                                Call Class4.CONNIC()
                                Call Class1.CONNIC()
                                Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
                                Dim cm11 As New SqlClient.SqlCommand(s11, cn)
                                cm11.Parameters.AddWithValue("@conf", True)
                                cm11.Parameters.AddWithValue("@Esalno", dgx)
                                'cm11.Parameters.AddWithValue("@BAKY", CDbl(0))
                                Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
                                If rd11.Read = True Then
                                    Button2.Visible = False
                                    Button4.Visible = True
                                    Button6.Visible = False
                                    Me.ComboBox1.Enabled = False
                                    Me.ComboBox2.Enabled = False
                                    Me.ComboBox3.Enabled = False
                                    Me.ComboBox4.Enabled = False
                                    'ContextMenuStrip2.Enabled = False
                                    Label13.ContextMenuStrip = ContextMenuStrip3
                                    rd11.Close()
                                    Dim sk As String = "select * from KASHEF where fnumber=@fnumber AND ESALNO=@ESALNO"
                                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                    cmk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                                    cmk.Parameters.AddWithValue("@ESALNO", dgx)
                                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                                    If rdK.Read = True Then
                                        TextBox10.Text = CDbl(rdK!MADFOO)
                                        TextBox12.Text = CDbl(rdK!MADFOO)
                                        TextBox16.Text = CDbl(rdK!MADFOO)
                                        TextBox11.Text = CDbl(rdK!BAKY)
                                        TextBox15.Text = ""
                                        Label13.Text = CDbl(rdK!kemat)
                                        rdK.Close()
                                    End If
                                    If TextBox10.Text = 0 Then
                                        Button5.Visible = False
                                    Else
                                        Button5.Visible = True
                                    End If
                                    'end using
                                    'end using

                                    'TextBox10.Text = rd11!MADFOO
                                    'TextBox12.Text = rd11!MADFOO
                                    'TextBox11.Text = rd11!baky
                                    'If Label8.Text <> 0 Then

                                    'Else
                                    '    TextBox15.ReadOnly = False
                                    'End If
                                    rd.Close()
                                Else
                                    Button4.Visible = True
                                    Button2.Visible = False
                                    Button5.Visible = False
                                    Button6.Visible = True
                                    Me.ComboBox1.Enabled = True
                                    Me.ComboBox2.Enabled = True
                                    Me.ComboBox3.Enabled = True
                                    Me.ComboBox4.Enabled = True
                                    ContextMenuStrip2.Enabled = True
                                    Label13.ContextMenuStrip = ContextMenuStrip2
                                    If Label8.Text = 0 Then
                                        If Trim(TextBox15.Text) = "" Or Val(TextBox15.Text) = 0 Then
                                            Button6.Enabled = False
                                        Else
                                            Button6.Enabled = True
                                        End If
                                    End If

                                    'If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("أدوية") Then
                                    '    If ComboBox4.Text = Trim("نقدا") Then

                                    '    End If
                                    'End If
                                    rd11.Close()
                                    rd.Close()
                                    Dim sk As String = "select * from KASHEF where fnumber=@fnumber AND ESALNO=@ESALNO"
                                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                                    cmk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
                                    cmk.Parameters.AddWithValue("@ESALNO", dgx)
                                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                                    If rdK.Read = True Then
                                        TextBox10.Text = CDbl(rdK!MADFOO)
                                        TextBox12.Text = CDbl(rdK!MADFOO)
                                        TextBox16.Text = CDbl(rdK!MADFOO)
                                        TextBox11.Text = CDbl(rdK!BAKY)
                                        TextBox15.Text = ""
                                        Label13.Text = CDbl(rdK!kemat)
                                        TextBox15.Focus()
                                        'If Label8.Text <> 0 Then
                                        '    If ComboBox3.Text = Trim("تحاليل") Or ComboBox3.Text = Trim("أدوية") Then
                                        '        TextBox15.ReadOnly = False
                                        '        Label19.Visible = True
                                        '    Else
                                        '        TextBox15.ReadOnly = True
                                        '        Label19.Visible = False
                                        '    End If
                                        '    'TextBox15.ReadOnly = True
                                        'Else
                                        '    TextBox15.ReadOnly = False
                                        'End If

                                        rdK.Close()
                                    End If
                                    rdK.Close()
                                    'TextBox10.Text = rd11!MADFOO
                                    'TextBox11.Text = rd11!baky
                                End If
                                rd11.Close()
                                'end using
                                'end using
                                rd.Close()

                            End If
                            rd.Close()

                            'end using
                            'end using

                            'Dim s As String = "delete * from appointment where fnumber=dgx"
                            'Dim cm As New SqlClient.SqlCommand(s, cn)
                            'cm.Parameters.AddWithValue("dgx", TextBox1.Text)
                            'If MsgBox("هــل تـريد الحــــذف ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            '    cm.ExecuteNonQuery()
                            '    MsgBox("تمـــت عمـــلـــية الحـــذف")
                            'End If

                            'End Select
                            TextBox15.Focus()
                            Dim s1 As String = "select * from SADAD "
                            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                            Dim dss As New DataSet
                            dss.Clear()
                            aad.Fill(dss, "SADAD")
                            Dim vd As New DataView(dss.Tables("SADAD"))
                            vd.RowFilter = "DATEXX>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEXX<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND ESALNO=" & "'" & dgx & "'" & ""
                            Me.DataGridView2.DataMember = ""
                            DataGridView2.DataSource = vd
                            'If DataGridView2.Rows.Count <> 0 Then
                            '    GroupBox1.Width = 879
                            '    GroupBox1.Location.X.Equals(454)
                            'Else
                            '    GroupBox1.Width = 1328
                            'End If

                            rd.Close()
                            Call Class4.CONNIC()
                            M6 = dgx
                        End If

                End Select

        End Select

    End Sub

    Private Sub طباعةالإيصالToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةالإيصالToolStripMenuItem.Click
        If KHAZENAXX = False Then
            '==========================================================================
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim TableCounter
            Dim reader As New System.IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New CrystalReport30(), cri2 As String
            crReportDocument.Load("CrystalReport30.rpt")
            cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
            KESEM_P = TextBox8.Text
            NAMEC = My.Settings.CLIN
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument.SetParameterValue(0, Me.KESEM_P)
            crReportDocument.SetParameterValue(1, Me.NAMEC)
            crReportDocument.RecordSelectionFormula = cri2
            crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
            crReportDocument.PrintToPrinter(1, True, 0, 0)
            crReportDocument.Close()
            crReportDocument.Dispose()
            '==========================================================================
        Else
            '-----------------------------------------------------------------------------------
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim TableCounter
            Dim reader As New System.IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New CrystalReport31(), cri2 As String
            crReportDocument.Load("CrystalReport31.rpt")
            cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
            KESEM_P = TextBox8.Text
            NAMEC = My.Settings.CLIN
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument.SetParameterValue(0, Me.KESEM_P)
            crReportDocument.SetParameterValue(1, Me.NAMEC)
            crReportDocument.RecordSelectionFormula = cri2
            crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
            crReportDocument.PrintToPrinter(1, True, 0, 0)
            crReportDocument.Close()
            crReportDocument.Dispose()

            '-----------------------------------------------------------------------------------
            reader.Close()
            Dim crReportDocument1 As New CrystalReport30(), cri1 As String
            crReportDocument1.Load("CrystalReport30.rpt")
            cri1 = "{KASHEF.ESALNO}=" & "" & M6 & ""
            KESEM_P = TextBox8.Text
            NAMEC = My.Settings.CLIN
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument1.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument1.SetParameterValue(0, Me.KESEM_P)
            crReportDocument1.SetParameterValue(1, Me.NAMEC)
            crReportDocument1.RecordSelectionFormula = cri1
            crReportDocument1.PrintOptions.PrinterName = My.Settings.printerx2
            crReportDocument1.PrintToPrinter(1, True, 0, 0)
            crReportDocument1.Close()
            crReportDocument1.Dispose()

        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim F As New SEARCH
        F.ShowDialog()
        If dgx = "" Then
            Return
        End If
        TextBox2.Text = dgx
        Dim s33 As String = "select * from main where fnumber=@fnumber" ' and hajez<>1"
        Dim cm33 As New SqlClient.SqlCommand(s33, cn)
        cm33.Parameters.AddWithValue("@fnumber", dgx)
        Dim rd As SqlClient.SqlDataReader = cm33.ExecuteReader
        If rd.Read = True Then
            ComboBox1.Text = rd!namex
            TextBox24.Text = rd!phone
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            VV3 = Format(DateTimePicker1.Value, "yyyy/MM/dd")
            VV4 = Format(DateTimePicker2.Value, "yyyy/MM/dd")
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim TableCounter
            Dim reader As New System.IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument1 As New Eyradat(), cri1 As String
            crReportDocument1.Load("Eyradat.rpt")
            'cri1 = "{KASHEF.ESALNO}=" & "" & M6 & ""
            NAMEC = My.Settings.CLIN
            datexx1 = DateTimePicker1.Value
            datexx2 = DateTimePicker2.Value
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument1.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument1.SetParameterValue(0, Me.datexx1)
            crReportDocument1.SetParameterValue(1, Me.datexx2)
            crReportDocument1.SetParameterValue(2, Me.NAMEC)
            crReportDocument1.RecordSelectionFormula = cri1
            crReportDocument1.PrintOptions.PrinterName = My.Settings.printerx2
            crReportDocument1.PrintToPrinter(1, True, 0, 0)
            crReportDocument1.Close()
            crReportDocument1.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim f As New Madenon
        f.ShowDialog()
    End Sub

    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.DateTimePicker3.Focus()
        End If
    End Sub
End Class