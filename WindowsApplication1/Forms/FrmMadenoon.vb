Imports System.Math
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

Public Class FrmMadenoon
    Friend namexx As String
    Friend KESEM_P As String
    Friend NAMEC As String
    Friend Ejno As String
    Friend phonex As String
    Friend kemaxxx As String
    Friend kemaxx As String
    Friend chnoxx As String
    Friend dateaxx As String
    Friend userxx As String
    Friend esalnox As String

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Madenon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsbhDataSet8.SADAD' table. You can move, or remove it, as needed.
        'Me.SADADTableAdapter.Fill(Me.DbsbhDataSet8.SADAD)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.kashef' table. You can move, or remove it, as needed.
        'Me.KashefTableAdapter.Fill(Me.DbsbhDataSet8.kashef)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.MOSTAFEED_VIEW' table. You can move, or remove it, as needed.
        'Me.MOSTAFEED_VIEWTableAdapter.Fill(Me.DbsbhDataSet8.MOSTAFEED_VIEW)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.MADENON' table. You can move, or remove it, as needed.
        'Me.MADENONTableAdapter.Fill(Me.DbsbhDataSet8.MADENON)
        Dim sk1X As String
        sk1X = "select * from MADENON where MADFOO<>KEMAT"
        Dim adk1X As New SqlClient.SqlDataAdapter(sk1X, cn)
        Dim dsk1X As New DataSet
        adk1X.Fill(dsk1X, "MADENON")
        ComboBox5.DataSource = dsk1X.Tables(0)
        ComboBox5.DisplayMember = "NAMEX"
        ComboBox5.SelectedIndex = -1

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If String.IsNullOrWhiteSpace(ComboBox5.Text) Then
            Return
        End If
        Call Class1.CONNIC()
        Dim sB As String = "select * from MAIN where NAMEX=@NAMEX "
        Dim cmB As New SqlClient.SqlCommand(sB, cn)
        cmB.Parameters.AddWithValue("@NAMEX", Trim(ComboBox5.Text))
        Dim rdB As SqlClient.SqlDataReader
        rdB = cmB.ExecuteReader
        If rdB.Read = True Then
            Label15.Text = rdB!FNUMBER
        Else
            Label15.Text = 0
        End If
        rdB.Close()
        Dim skK As String
        skK = "select * from KASHEF WHERE FNUMBER='" & CInt(Label15.Text) & "' "
        Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
        Dim dskK As New DataSet
        adkK.Fill(dskK, "KASHEF")
        ComboBox6.DataSource = dskK.Tables(0)
        ComboBox6.DisplayMember = "ESALNO"
        'ComboBox6.SelectedIndex = -1

        Dim s1 As String = "select * from KASHEF"
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "KASHEF")
        Dim vd As New DataView(dss.Tables("KASHEF"))
        vd.RowFilter = "FNUMBER=" & "'" & Me.Label15.Text & "'" & ""
        Me.DataGridView8.DataMember = ""
        DataGridView8.DataSource = vd
        If DataGridView8.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView8.Rows.Count - 1
                tot += DataGridView8.Item(4, i).Value
            Next
            TextBox27.Text = tot
        Else
            TextBox27.Text = 0
        End If
        Call Class4.CONNIC()
        TextBox28.Focus()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Call Class1.CONNIC()
        Dim sB As String = "select * from KASHEF where FNUMBER=@FNUMBER AND BAKY<>@BAKY"
        Dim cmB As New SqlClient.SqlCommand(sB, cn)
        cmB.Parameters.AddWithValue("@FNUMBER", CInt(Label15.Text))
        cmB.Parameters.AddWithValue("@BAKY", 0)
        Dim rdB As SqlClient.SqlDataReader
        rdB = cmB.ExecuteReader
        Do While rdB.Read = True
            If Val(TextBox28.Text) <> 0 Then
                Esal_no.Text = CInt(rdB!esalno)
                Madfoo_v.Text = CDbl(rdB!madfoo) '0
                Baky_v.Text = CDbl(rdB!baky) '30
                Dim s222 As String = "insert into SADAD(ESALNO,DATEXX,SADAD) values(@ESALNO,@DATEXX,@SADAD)"
                Dim cm222 As New SqlClient.SqlCommand(s222, cn)
                cm222.Parameters.AddWithValue("@ESALNO", Esal_no.Text)
                cm222.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
                cm222.Parameters.AddWithValue("@SADAD", CDbl(Me.TextBox28.Text))
                Try
                    cm222.ExecuteNonQuery()
                Catch ex As Exception

                End Try

                If Val(Baky_v.Text) <> 0 Then
                    Dim ss21 As String = "update kashef set MADFOO=@madfoo,BAKY=@baky where esalno=@esalno"
                    Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
                    If Val(TextBox28.Text) <= Val(Baky_v.Text) Then
                        Madfoo_v.Text = CDbl(TextBox28.Text) + CDbl(Madfoo_v.Text)
                        cmm21.Parameters.AddWithValue("@MADFOO", CDbl(Madfoo_v.Text))
                        Baky_v.Text = Abs(Val(Baky_v.Text) - Val(TextBox28.Text))
                        If Val(Baky_v.Text) <> 0 Then
                            TextBox28.Text = TextBox28.Text
                        Else
                            TextBox28.Text = Abs(CDbl(TextBox28.Text) - CDbl(Madfoo_v.Text))
                        End If

                    Else
                        Madfoo_v.Text = Abs(CDbl(Baky_v.Text) + CDbl(Madfoo_v.Text))
                        cmm21.Parameters.AddWithValue("@MADFOO", CDbl(Madfoo_v.Text))
                        TextBox28.Text = Abs(CDbl(TextBox28.Text) - CDbl(Baky_v.Text))
                        Baky_v.Text = 0
                    End If
                    cmm21.Parameters.AddWithValue("@BAKY", CDbl(Baky_v.Text))
                    cmm21.Parameters.AddWithValue("@esalno", CInt(Esal_no.Text))
                    Try
                        cmm21.ExecuteNonQuery()
                        'MsgBox("تم السداد")
                    Catch ex As Exception

                    End Try
                    'End Using
                    'If Val(TextBox28.Text) <= Val(Baky_v.Text) Then
                    If Val(TextBox28.Text) = 0 Then
                        'TextBox28.Text = CDbl(Baky_v.Text) - CDbl(TextBox28.Text)
                        Exit Do
                        'Else
                        '    TextBox28.Text = Abs(CDbl(TextBox28.Text) - CDbl(Baky_v.Text))
                    End If
                End If
            End If
        Loop
        Dim s1 As String = "select * from KASHEF "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "KASHEF")
        Dim vd As New DataView(dss.Tables("KASHEF"))
        vd.RowFilter = "FNUMBER=" & "'" & Me.Label15.Text & "'" & ""
        Me.DataGridView8.DataMember = ""
        DataGridView8.DataSource = vd
        If DataGridView8.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView8.Rows.Count - 1
                tot += DataGridView8.Item(4, i).Value
            Next
            TextBox27.Text = tot
        Else
            TextBox27.Text = 0
        End If
        'Dim sk1X As String
        'sk1X = "select * from MADENON"
        'Dim adk1X As New SqlClient.SqlDataAdapter(sk1X, cn)
        'Dim dsk1X As New DataSet
        'adk1X.Fill(dsk1X, "MADENON")
        'ComboBox5.DataSource = dsk1X.Tables(0)
        'ComboBox5.DisplayMember = "NAMEX"
        'ComboBox5.SelectedIndex = -1
        Dim s10 As String = "select * from sadad "
        Dim aad0 As New SqlClient.SqlDataAdapter(s10, cn)
        Dim dss0 As New DataSet
        dss0.Clear()
        aad0.Fill(dss0, "sadad")
        Dim vd0 As New DataView(dss0.Tables("sadad"))
        vd0.RowFilter = "Esalno=" & "'" & ComboBox6.Text & "'" & ""
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd0
        TextBox28.Focus()
        Call Class1.CONNIC()
        Dim sBm As String = "select * from main where FNUMBER=@FNUMBER"
        Dim cmBm As New SqlClient.SqlCommand(sBm, cn)
        cmBm.Parameters.AddWithValue("@FNUMBER", CInt(Label15.Text))
        Dim rdBm As SqlClient.SqlDataReader
        rdBm = cmBm.ExecuteReader
        If rdBm.Read = True Then
            phonex = rdBm!phone
        End If
        Call Class4.CONNIC()
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
        Dim crReportDocument As New Esalmaly(), cri2 As String
        crReportDocument.Load("Esalmaly.rpt")
        namexx = Trim(ComboBox5.Text)
        KESEM_P = Label23.Text
        NAMEC = My.Settings.CLIN
        kemaxxx = HANY(TextBox28.Text, "IRAQ")
        esalnox = ComboBox6.Text
        kemaxx = TextBox28.Text
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
        crReportDocument.SetParameterValue(2, Me.namexx)
        crReportDocument.SetParameterValue(3, Me.phonex)
        crReportDocument.SetParameterValue(4, Me.kemaxxx)
        crReportDocument.SetParameterValue(5, Me.esalnox)
        crReportDocument.SetParameterValue(6, Me.kemaxx)
        'crReportDocument.RecordSelectionFormula = cri2
        crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
        crReportDocument.PrintToPrinter(1, True, 0, 0)
        crReportDocument.Close()
        crReportDocument.Dispose()

        'Dim cr1 As New Esalmaly, cri As String
        'namexx = Trim(ComboBox5.Text)
        'KESEM_P = Label23.Text
        'NAMEC = My.Settings.CLIN
        'kemaxxx = HANY(TextBox28.Text, "IRAQ")
        'esalnox = ComboBox6.Text
        'kemaxx = TextBox28.Text
        'cr1.SetParameterValue(0, Me.KESEM_P)
        'cr1.SetParameterValue(1, Me.NAMEC)
        'cr1.SetParameterValue(2, Me.namexx)
        'cr1.SetParameterValue(3, Me.phonex)
        'cr1.SetParameterValue(4, Me.kemaxxx)
        'cr1.SetParameterValue(5, Me.esalnox)
        'cr1.SetParameterValue(6, Me.kemaxx)
        'cr1.RecordSelectionFormula = cri
        'cr1.PrintOptions.PrinterName = "PR"
        'cr1.PrintToPrinter(1, True, 0, 0)
        'cr1.Close()
        'cr1.Dispose()

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sBMA As String = "select * from KASHEF_AM where ESALNO=@ESALNO "
        Dim cmBMA As New SqlClient.SqlCommand(sBMA, cn)
        cmBMA.Parameters.AddWithValue("@ESALNO", CInt(Val(ComboBox6.Text)))
        Dim rdBMA As SqlClient.SqlDataReader
        rdBMA = cmBMA.ExecuteReader
        If rdBMA.Read = True Then
            Label23.Text = rdBMA!AML_NAME
            TextBox37.Text = rdBMA!BAKY
        Else
            Dim sBM As String = "select * from KASHEF where ESALNO=@ESALNO "
            Dim cmBM As New SqlClient.SqlCommand(sBM, cn)
            cmBM.Parameters.AddWithValue("@ESALNO", CInt(Val(ComboBox6.Text)))
            Dim rdBM As SqlClient.SqlDataReader
            rdBM = cmBM.ExecuteReader
            If rdBM.Read = True Then
                Label23.Text = rdBM!EJRAA
                TextBox37.Text = rdBM!BAKY
                'If Label24.Text = 1 Then
                'Else
                '    'Dim sBMAJ As String = "select * from EJRAA where IDJ=@IDJ "
                '    'Dim cmBMAJ As New SqlClient.SqlCommand(sBMAJ, cn)
                '    'cmBMAJ.Parameters.AddWithValue("@IDJ", CInt(Label24.Text))
                '    'Dim rdBMAJ As SqlClient.SqlDataReader
                '    'rdBMAJ = cmBMAJ.ExecuteReader
                '    'If rdBMAJ.Read = True Then
                '    '    Label23.Text = rdBMAJ!EJRAA
                '    '    TextBox37.Text = rdBMA!BAKY
                '    'End If
                'End If
            End If
        End If
        Call Class4.CONNIC()

    End Sub

    Private Sub TextBox28_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox28.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox28.Text = "" Then
                MsgBox("يرجى ادخال القيمة المدفوعة")
                ComboBox5.Focus()
            Else
                DateTimePicker5.Focus()
            End If
        End If
    End Sub
    Private Sub DateTimePicker5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button12.Focus()
        End If
    End Sub

    Private Sub DataGridView8_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView8.CellMouseDown
        dgx = DataGridView8.Item(0, e.RowIndex).Value
        Call Class1.CONNIC()
        Dim sB As String = "select * from KASHEF where Esalno=@Esalno"
        Dim cmB As New SqlClient.SqlCommand(sB, cn)
        cmB.Parameters.AddWithValue("@Esalno", CInt(dgx))
        Dim rdB As SqlClient.SqlDataReader
        rdB = cmB.ExecuteReader
        If rdB.Read = True Then

        End If

        Dim s1 As String = "select * from sadad "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "sadad")
        Dim vd As New DataView(dss.Tables("sadad"))
        vd.RowFilter = "Esalno=" & "'" & dgx & "'" & ""
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd
        'If DataGridView1.Rows.Count <> 0 Then
        '    Dim xc As Integer = 0
        '    Dim tot As Integer = 0
        '    Dim i As Integer = 0
        '    For i = 0 To DataGridView1.Rows.Count - 1
        '        tot += DataGridView1.Item(2, i).Value
        '    Next
        '    TextBox27.Text = tot
        'Else
        '    TextBox27.Text = 0
        'End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim sk1X As String
            sk1X = "select * from MADENON"
            Dim adk1X As New SqlClient.SqlDataAdapter(sk1X, cn)
            Dim dsk1X As New DataSet
            adk1X.Fill(dsk1X, "MADENON")
            ComboBox5.DataSource = dsk1X.Tables(0)
            ComboBox5.DisplayMember = "NAMEX"
            ComboBox5.SelectedIndex = -1
        Else
            Dim sk1X As String
            sk1X = "select * from MADENON where Expr1<>0"
            Dim adk1X As New SqlClient.SqlDataAdapter(sk1X, cn)
            Dim dsk1X As New DataSet
            adk1X.Fill(dsk1X, "MADENON")
            ComboBox5.DataSource = dsk1X.Tables(0)
            ComboBox5.DisplayMember = "NAMEX"
            ComboBox5.SelectedIndex = -1
        End If
    End Sub

    Private Sub Madenon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If IsInputKey(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub Madenon_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
    End Sub

    Private Sub طباعةإيصالToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةإيصالToolStripMenuItem.Click
        Dim cr1 As New Esalmaly, cri As String
        namexx = Trim(ComboBox5.Text)
        KESEM_P = Label23.Text
        NAMEC = My.Settings.CLIN
        kemaxxx = HANY(TextBox28.Text, "IRAQ")
        esalnox = ComboBox6.Text
        kemaxx = TextBox28.Text
        cr1.SetParameterValue(0, Me.KESEM_P)
        cr1.SetParameterValue(1, Me.NAMEC)
        cr1.SetParameterValue(2, Me.namexx)
        cr1.SetParameterValue(3, Me.phonex)
        cr1.SetParameterValue(4, Me.kemaxxx)
        cr1.SetParameterValue(5, Me.esalnox)
        cr1.SetParameterValue(6, Me.kemaxx)
        cr1.RecordSelectionFormula = cri
        cr1.PrintOptions.PrinterName = "PR"
        cr1.PrintToPrinter(1, True, 0, 0)
        cr1.Close()
        cr1.Dispose()
    End Sub

    Private Sub TextBox28_Enter(sender As Object, e As EventArgs) Handles TextBox28.Enter
        If TextBox28.Text = 0 Then
            TextBox28.Text = ""
        End If
    End Sub
    Private Sub TextBox28_Validated(sender As Object, e As EventArgs) Handles TextBox28.Validated
        If String.IsNullOrWhiteSpace(TextBox28.Text) Then
            TextBox28.Text = 0
        End If
    End Sub
End Class