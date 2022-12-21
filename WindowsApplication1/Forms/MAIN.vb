Public Class MAIN
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Panel3.Visible = False Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = False
        Call Class4.CONNIC()
        Dim f As New Form10
        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel3.Visible = False
        'Panel3.Location() = New Point(313, 173)
        Call Class4.CONNIC()
        Dim f As New Alkhazena
        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = False
        Dim f As New Form212
        f.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        procedx = "المصروفات"
        Call Class1.proced()
        Me.Hide()
        Dim F As New Form16
        F.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel3.Visible = False
        Dim f As New setting
        f.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel3.Visible = False
        Me.Hide()
        Call Class4.CONNIC()
        Dim f As New FRMLOGIN
        f.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel3.Visible = False
        MsgBox("*******Good luck*********")
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = user
        ToolStripStatusLabel4.Text = log_date
        ToolStripStatusLabel6.Text = log_time
        Me.Label4.Text = Format(Now, "hh:mm:ss")
        Me.Label2.Text = Format(Now, "yyyy/MM/dd")

    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Panel3.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        procedx = "تقرير الخلاصه اليوميه"
        Call Class1.proced()
        sakprint = 4
        Dim frm As New ByDate1
        frm.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FP = 2
        Dim F As New ByDate
        F.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call Class1.CONNIC()
        'TRUNCATE FROM USERS 
        'Dim sK As String = "DELETE FROM KESEM"
        'Dim cmK As New SqlClient.SqlCommand(sK, cn)
        'Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KESEM', RESEED, -1)", cn)
        Dim sY As String = "DELETE FROM EYWAA"
        Dim cmY As New SqlClient.SqlCommand(sY, cn)
        Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED, 0)", cn)
        'Dim sJ As String = "DELETE FROM EJRAA"
        'Dim cmJ As New SqlClient.SqlCommand(sJ, cn)
        'Dim cmj1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Ejraa', RESEED, -1)", cn)
        Dim sCDOC As String = "DELETE FROM AM_CDOC"
        Dim cmCDOC As New SqlClient.SqlCommand(sCDOC, cn)
        Dim cmCDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_CDOC', RESEED, 0)", cn)
        Dim sDOC As String = "DELETE FROM AM_DOC"
        Dim cmDOC As New SqlClient.SqlCommand(sDOC, cn)
        Dim cmDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_DOC', RESEED, 0)", cn)
        Dim sFDOC As String = "DELETE FROM AM_FDOC"
        Dim cmFDOC As New SqlClient.SqlCommand(sFDOC, cn)
        Dim cmfDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_fDOC', RESEED, 0)", cn)
        Dim sFTDOC As String = "DELETE FROM AM_FTDOC"
        Dim cmFTDOC As New SqlClient.SqlCommand(sFTDOC, cn)
        Dim cmftDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_ftDOC', RESEED, 0)", cn)
        Dim sKAB As String = "DELETE FROM AM_KAB"
        Dim cmKAB As New SqlClient.SqlCommand(sKAB, cn)
        Dim cmKAB1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_KAB', RESEED, 0)", cn)
        Dim sMDOC As String = "DELETE FROM AM_MDOC"
        Dim cmMDOC As New SqlClient.SqlCommand(sMDOC, cn)
        Dim cmMDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_MDOC', RESEED, 0)", cn)
        Dim sTAH As String = "DELETE FROM AM_TAH"
        Dim cmTAH As New SqlClient.SqlCommand(sTAH, cn)
        Dim cmTAH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_TAH', RESEED, 0)", cn)
        Dim sTDOC As String = "DELETE FROM AM_TDOC"
        Dim cmTDOC As New SqlClient.SqlCommand(sTDOC, cn)
        Dim cmTDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_TDOC', RESEED, 0)", cn)
        Dim sAMA As String = "DELETE FROM AMALEAT"
        Dim cmAMA As New SqlClient.SqlCommand(sAMA, cn)
        Dim cmAMA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AMALEAT', RESEED, 0)", cn)
        Dim sAMAM As String = "DELETE FROM AMALEAT_M"
        Dim cmAMAM As New SqlClient.SqlCommand(sAMAM, cn)
        Dim cmAMAM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AMALEAT_M', RESEED, 0)", cn)
        Dim sAP As String = "DELETE FROM APPOINTMENT"
        Dim cmAP As New SqlClient.SqlCommand(sAP, cn)
        Dim cmAP1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('APPOINTMENT', RESEED, 0)", cn)
        Dim sBIO As String = "DELETE FROM BIO_CHEMISTRY"
        Dim cmBIO As New SqlClient.SqlCommand(sBIO, cn)
        Dim cmBIO1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('BIO_CHEMISTRY', RESEED, 0)", cn)
        Dim sCBC As String = "DELETE FROM CBC"
        Dim cmCBC As New SqlClient.SqlCommand(sCBC, cn)
        Dim cmCBC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('CBC', RESEED, 0)", cn)
        'Dim sDN As String = "DELETE FROM DN"
        'Dim cmDN As New SqlClient.SqlCommand(sDN, cn)
        'Dim cmDN1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DN', RESEED, -1)", cn)
        'Dim sDNK As String = "DELETE FROM DNKEMA"
        'Dim cmDNK As New SqlClient.SqlCommand(sDNK, cn)
        'Dim cmDNK1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DNKEMA', RESEED, 0)", cn)
        Dim sDR As String = "DELETE FROM DOCTORR"
        Dim cmDR As New SqlClient.SqlCommand(sDR, cn)
        Dim cmDR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DOCTORR', RESEED, 0)", cn)
        Dim sD As String = "DELETE FROM DOCUMENT"
        Dim cmD As New SqlClient.SqlCommand(sD, cn)
        Dim cmD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DOCUMENT', RESEED, 0)", cn)
        Dim sEH As String = "DELETE FROM EIA_HORMONAL"
        Dim cmEH As New SqlClient.SqlCommand(sEH, cn)
        Dim cmEH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('EIA_HORMONAL', RESEED, 0)", cn)
        Dim sEL As String = "DELETE FROM ELECTROLYTES"
        Dim cmEL As New SqlClient.SqlCommand(sEL, cn)
        Dim cmEL1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('ELECTROLYTES', RESEED, 0)", cn)
        Dim sHA As String = "DELETE FROM HESAB_AM"
        Dim cmHA As New SqlClient.SqlCommand(sHA, cn)
        Dim cmHA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HESAB_AM', RESEED, 0)", cn)
        Dim sHD As String = "DELETE FROM HESAB_DO"
        Dim cmHD As New SqlClient.SqlCommand(sHD, cn)
        Dim cmHD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HESAB_DO', RESEED, 0)", cn)
        Dim sH As String = "DELETE FROM HISTORY"
        Dim cmH As New SqlClient.SqlCommand(sH, cn)
        Dim cmH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HISTORY', RESEED, 0)", cn)
        Dim sHAS As String = "DELETE FROM HORMONAL_ASSAY"
        Dim cmHAS As New SqlClient.SqlCommand(sHAS, cn)
        Dim cmHAS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HORMONAL_ASSAY', RESEED, 0)", cn)
        Dim sJAD As String = "DELETE FROM JAD"
        Dim cmJAD As New SqlClient.SqlCommand(sJAD, cn)
        Dim cmJAD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAD', RESEED, 0)", cn)
        Dim sJAM As String = "DELETE FROM JAM"
        Dim cmJAM As New SqlClient.SqlCommand(sJAM, cn)
        Dim cmJAM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAM', RESEED, 0)", cn)
        Dim sJAS As String = "DELETE FROM JAS"
        Dim cmJAS As New SqlClient.SqlCommand(sJAS, cn)
        Dim cmJAS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAS', RESEED, 0)", cn)
        Dim sJKT As String = "DELETE FROM JEHAKASHEFT"
        Dim cmJKT As New SqlClient.SqlCommand(sJKT, cn)
        Dim cmJKT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JEHAKASHEFT', RESEED, 0)", cn)
        Dim sJK As String = "DELETE FROM JK"
        Dim cmJK As New SqlClient.SqlCommand(sJK, cn)
        Dim cmJK1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JK', RESEED, 0)", cn)
        Dim sJS As String = "DELETE FROM JS"
        Dim cmJS As New SqlClient.SqlCommand(sJS, cn)
        Dim cmJS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JS', RESEED, 0)", cn)
        Dim sJSH As String = "DELETE FROM JSH"
        Dim cmJSH As New SqlClient.SqlCommand(sJSH, cn)
        Dim cmJSH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JSH', RESEED, 0)", cn)
        Dim sJT As String = "DELETE FROM JT"
        Dim cmJT As New SqlClient.SqlCommand(sJT, cn)
        Dim cmJT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JT', RESEED, 0)", cn)
        Dim sJTGH As String = "DELETE FROM JTGH"
        Dim cmJTGH As New SqlClient.SqlCommand(sJTGH, cn)
        Dim cmJTGH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JTGH', RESEED, 0)", cn)
        Dim sKA As String = "DELETE FROM KASHEF"
        Dim cmKA As New SqlClient.SqlCommand(sKA, cn)
        Dim cmKA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KASHEF', RESEED, 0)", cn)
        Dim sLAB As String = "DELETE FROM LAB"
        Dim cmLAB As New SqlClient.SqlCommand(sLAB, cn)
        Dim cmLAB1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LAB', RESEED, 0)", cn)
        Dim sLABD As String = "DELETE FROM LABDOC"
        Dim cmLABD As New SqlClient.SqlCommand(sLABD, cn)
        Dim cmLABD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LABDOC', RESEED, 0)", cn)
        Dim sLFT As String = "DELETE FROM LFT"
        Dim cmLFT As New SqlClient.SqlCommand(sLFT, cn)
        Dim cmLFT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LFT', RESEED, 0)", cn)
        Dim sLOSS As String = "DELETE FROM LOSS"
        Dim cmLOSS As New SqlClient.SqlCommand(sLOSS, cn)
        Dim cmLOSS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LOSS', RESEED, 0)", cn)
        Dim sM As String = "DELETE FROM MAIN"
        Dim cmM As New SqlClient.SqlCommand(sM, cn)
        Dim cmM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED, 1000)", cn)
        Dim sMO As String = "DELETE FROM MOSTAFEED"
        Dim cmMO As New SqlClient.SqlCommand(sMO, cn)
        Dim cmMO1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('MOSTAFEED', RESEED, -1)", cn)
        Dim sPH As String = "DELETE FROM PHARMACY"
        Dim cmPH As New SqlClient.SqlCommand(sPH, cn)
        Dim cmPH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PHARMACY', RESEED, 0)", cn)
        Dim sPRT As String = "DELETE FROM PROTHONBIN_TEST"
        Dim cmPRT As New SqlClient.SqlCommand(sPRT, cn)
        Dim cmPRT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PROTHONBIN_TEST', RESEED, 0)", cn)
        Dim sR As String = "DELETE FROM REPORT"
        Dim cmR As New SqlClient.SqlCommand(sR, cn)
        Dim cmR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('REPORT', RESEED, 0)", cn)
        Dim sRFT As String = "DELETE FROM LAB"
        Dim cmRFT As New SqlClient.SqlCommand(sRFT, cn)
        Dim cmRFT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LAB', RESEED, 0)", cn)
        Dim sSAD As String = "DELETE FROM SADAD"
        Dim cmSAD As New SqlClient.SqlCommand(sSAD, cn)
        Dim cmSAD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SADAD', RESEED, 0)", cn)
        Dim sSA As String = "DELETE FROM SEMEN_ANALYSIS"
        Dim cmSA As New SqlClient.SqlCommand(sSA, cn)
        Dim cmSA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SEMEN_ANALYSIS', RESEED, 0)", cn)
        Dim sSER As String = "DELETE FROM SEROLOGY"
        Dim cmSER As New SqlClient.SqlCommand(sSER, cn)
        Dim cmSER1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SEROLOGY', RESEED, 0)", cn)
        Dim sTOR As String = "DELETE FROM TIROID"
        Dim cmTOR As New SqlClient.SqlCommand(sTOR, cn)
        Dim cmTOR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TIROID', RESEED, 0)", cn)
        Dim sTORCH As String = "DELETE FROM TORCH"
        Dim cmTORCH As New SqlClient.SqlCommand(sTORCH, cn)
        Dim cmTORCH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TORCH', RESEED, 0)", cn)
        Dim sTP As String = "DELETE FROM TREATMENT_PLANING"
        Dim cmTP As New SqlClient.SqlCommand(sTP, cn)
        Dim cmTP1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TREATMENT_PLANING', RESEED, 0)", cn)
        Dim sTV As String = "DELETE FROM TREATMENT_VISITS"
        Dim cmTV As New SqlClient.SqlCommand(sTV, cn)
        Dim cmTV1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TREATMENT_VISITS', RESEED, 0)", cn)
        Dim sU As String = "DELETE FROM URINE"
        Dim cmU As New SqlClient.SqlCommand(sU, cn)
        Dim cmU1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('URINE', RESEED, 0)", cn)
        'Dim sUS As String = "DELETE FROM USERS"
        'Dim cmUS As New SqlClient.SqlCommand(sUS, cn)
        'Dim cmUS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('USERS', RESEED, -1)", cn)
        Dim sV As String = "DELETE FROM VIROLOGY"
        Dim cmV As New SqlClient.SqlCommand(sV, cn)
        Dim cmV1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('VIROLOGY', RESEED, 0)", cn)
        Dim sW As String = "DELETE FROM WIDAL_TEST"
        Dim cmW As New SqlClient.SqlCommand(sW, cn)
        Dim cmW1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('WIDAL_TEST', RESEED, 0)", cn)
        'Dim sWTY As String = "DELETE FROM TYPEEYWAA"
        'Dim cmWTY As New SqlClient.SqlCommand(sWTY, cn)
        'Dim cmW1TY As New SqlClient.SqlCommand("DBCC CHECKIDENT('TYPEEYWAA', RESEED, 0)", cn)
        'Try
        cmY.ExecuteNonQuery()
        cmM.ExecuteNonQuery()
        'cmK.ExecuteNonQuery()
        'cmk1.ExecuteNonQuery()
        'cmJ.ExecuteNonQuery()
        'cmj1.ExecuteNonQuery()
        cmDOC.ExecuteNonQuery()
        cmDOC1.ExecuteNonQuery()
        cmCDOC.ExecuteNonQuery()
        cmCDOC1.ExecuteNonQuery()
        cmFDOC.ExecuteNonQuery()
        cmfDOC1.ExecuteNonQuery()
        cmFTDOC.ExecuteNonQuery()
        cmftDOC1.ExecuteNonQuery()
        cmKAB.ExecuteNonQuery()
        cmKAB1.ExecuteNonQuery()
        cmMDOC.ExecuteNonQuery()
        cmMDOC1.ExecuteNonQuery()
        cmTAH.ExecuteNonQuery()
        cmTDOC.ExecuteNonQuery()
        cmAMA.ExecuteNonQuery()
        cmAMAM.ExecuteNonQuery()
        cmAP.ExecuteNonQuery()
        cmBIO.ExecuteNonQuery()
        cmCBC.ExecuteNonQuery()
        'cmDNK.ExecuteNonQuery()
        cmDR.ExecuteNonQuery()
        cmD.ExecuteNonQuery()
        cmEH.ExecuteNonQuery()
        cmEL.ExecuteNonQuery()
        cmHA.ExecuteNonQuery()
        cmHD.ExecuteNonQuery()
        cmH.ExecuteNonQuery()
        cmHAS.ExecuteNonQuery()
        cmJAD.ExecuteNonQuery()
        cmJAM.ExecuteNonQuery()
        cmJAS.ExecuteNonQuery()
        cmJKT.ExecuteNonQuery()
        cmJK.ExecuteNonQuery()
        cmJS.ExecuteNonQuery()
        cmJSH.ExecuteNonQuery()
        cmJT.ExecuteNonQuery()
        cmJTGH.ExecuteNonQuery()
        cmKA.ExecuteNonQuery()
        cmLAB.ExecuteNonQuery()
        cmLABD.ExecuteNonQuery()
        cmLFT.ExecuteNonQuery()
        cmLOSS.ExecuteNonQuery()
        cmMO.ExecuteNonQuery()
        cmPH.ExecuteNonQuery()
        cmPRT.ExecuteNonQuery()
        cmR.ExecuteNonQuery()
        cmRFT.ExecuteNonQuery()
        cmSAD.ExecuteNonQuery()
        cmSA.ExecuteNonQuery()
        cmSER.ExecuteNonQuery()
        cmTOR.ExecuteNonQuery()
        cmTORCH.ExecuteNonQuery()
        cmTP.ExecuteNonQuery()
        cmTV.ExecuteNonQuery()
        cmU.ExecuteNonQuery()
        'cmUS.ExecuteNonQuery()
        cmV.ExecuteNonQuery()
        cmW.ExecuteNonQuery()
        'cmDN.ExecuteNonQuery()
        'cmWTY.ExecuteNonQuery()


        cmMY.ExecuteNonQuery()
        cmTAH1.ExecuteNonQuery()
        cmTDOC1.ExecuteNonQuery()
        cmAMA1.ExecuteNonQuery()
        cmAMAM1.ExecuteNonQuery()
        cmAP1.ExecuteNonQuery()
        cmBIO1.ExecuteNonQuery()
        cmCBC1.ExecuteNonQuery()
        'cmDN1.ExecuteNonQuery()
        'cmDNK1.ExecuteNonQuery()
        cmDR1.ExecuteNonQuery()
        cmD1.ExecuteNonQuery()
        cmEH1.ExecuteNonQuery()
        cmEL1.ExecuteNonQuery()
        cmHA1.ExecuteNonQuery()
        cmHD1.ExecuteNonQuery()
        cmH1.ExecuteNonQuery()
        cmHAS1.ExecuteNonQuery()
        cmJAD1.ExecuteNonQuery()
        cmJAM1.ExecuteNonQuery()
        cmJAS1.ExecuteNonQuery()
        cmJKT1.ExecuteNonQuery()
        cmJK1.ExecuteNonQuery()
        cmJS1.ExecuteNonQuery()
        cmJSH1.ExecuteNonQuery()
        cmJT1.ExecuteNonQuery()
        cmJTGH1.ExecuteNonQuery()
        cmKA1.ExecuteNonQuery()
        cmLAB1.ExecuteNonQuery()
        cmLABD1.ExecuteNonQuery()
        cmLFT1.ExecuteNonQuery()
        cmLOSS1.ExecuteNonQuery()
        cmM1.ExecuteNonQuery()
        cmMO1.ExecuteNonQuery()
        cmPH1.ExecuteNonQuery()
        cmPRT1.ExecuteNonQuery()
        cmR1.ExecuteNonQuery()
        cmRFT1.ExecuteNonQuery()
        cmSAD1.ExecuteNonQuery()
        cmSA1.ExecuteNonQuery()
        cmSER1.ExecuteNonQuery()
        cmTOR1.ExecuteNonQuery()
        cmTORCH1.ExecuteNonQuery()
        cmTP1.ExecuteNonQuery()
        cmTV1.ExecuteNonQuery()
        cmU1.ExecuteNonQuery()
        'cmUS1.ExecuteNonQuery()
        cmV1.ExecuteNonQuery()
        cmW1.ExecuteNonQuery()
        'cmW1TY.ExecuteNonQuery()
        Call Class4.CONNIC()
        MsgBox("تم تصفير قاعدة البيانات")
        End
        'Catch ex As Exception
        '    MsgBox("لم تتم عملية التصفير")
        'End Try
        'Dim sB As String = "DELETE FROM KESEM"
        'Dim cmB As New SqlClient.SqlCommand(sB, cn)
        'Try
        '    cmB.ExecuteNonQuery()
        '    MsgBox("تم تصفير الأقسام")
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'TRUNCATE FROM USERS 
        Call Class1.CONNIC()
        Dim sK As String = "DELETE FROM KESEM"
        Dim cmK As New SqlClient.SqlCommand(sK, cn)
        Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KESEM', RESEED, 0)", cn)
        Dim sY As String = "DELETE FROM EYWAA"
        Dim cmY As New SqlClient.SqlCommand(sY, cn)
        Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED, 0)", cn)
        Dim sJ As String = "DELETE FROM EJRAA"
        Dim cmJ As New SqlClient.SqlCommand(sJ, cn)
        Dim cmj1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Ejraa', RESEED, 0)", cn)
        Dim sCDOC As String = "DELETE FROM AM_CDOC"
        Dim cmCDOC As New SqlClient.SqlCommand(sCDOC, cn)
        Dim cmCDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_CDOC', RESEED, 0)", cn)
        Dim sDOC As String = "DELETE FROM AM_DOC"
        Dim cmDOC As New SqlClient.SqlCommand(sDOC, cn)
        Dim cmDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_DOC', RESEED, 0)", cn)
        Dim sFDOC As String = "DELETE FROM AM_FDOC"
        Dim cmFDOC As New SqlClient.SqlCommand(sFDOC, cn)
        Dim cmfDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_fDOC', RESEED, 0)", cn)
        Dim sFTDOC As String = "DELETE FROM AM_FTDOC"
        Dim cmFTDOC As New SqlClient.SqlCommand(sFTDOC, cn)
        Dim cmftDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_ftDOC', RESEED, 0)", cn)
        Dim sKAB As String = "DELETE FROM AM_KAB"
        Dim cmKAB As New SqlClient.SqlCommand(sKAB, cn)
        Dim cmKAB1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_KAB', RESEED, 0)", cn)
        Dim sMDOC As String = "DELETE FROM AM_MDOC"
        Dim cmMDOC As New SqlClient.SqlCommand(sMDOC, cn)
        Dim cmMDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_MDOC', RESEED, 0)", cn)
        Dim sTAH As String = "DELETE FROM AM_TAH"
        Dim cmTAH As New SqlClient.SqlCommand(sTAH, cn)
        Dim cmTAH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_TAH', RESEED, 0)", cn)
        Dim sTDOC As String = "DELETE FROM AM_TDOC"
        Dim cmTDOC As New SqlClient.SqlCommand(sTDOC, cn)
        Dim cmTDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_TDOC', RESEED, 0)", cn)
        Dim sAMA As String = "DELETE FROM AMALEAT"
        Dim cmAMA As New SqlClient.SqlCommand(sAMA, cn)
        Dim cmAMA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AMALEAT', RESEED, 0)", cn)
        Dim sAMAM As String = "DELETE FROM AMALEAT_M"
        Dim cmAMAM As New SqlClient.SqlCommand(sAMAM, cn)
        Dim cmAMAM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AMALEAT_M', RESEED, 0)", cn)
        Dim sAP As String = "DELETE FROM APPOINTMENT"
        Dim cmAP As New SqlClient.SqlCommand(sAP, cn)
        Dim cmAP1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('APPOINTMENT', RESEED, 0)", cn)
        Dim sBIO As String = "DELETE FROM BIO_CHEMISTRY"
        Dim cmBIO As New SqlClient.SqlCommand(sBIO, cn)
        Dim cmBIO1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('BIO_CHEMISTRY', RESEED, 0)", cn)
        Dim sCBC As String = "DELETE FROM CBC"
        Dim cmCBC As New SqlClient.SqlCommand(sCBC, cn)
        Dim cmCBC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('CBC', RESEED, 0)", cn)
        Dim sDN As String = "DELETE FROM DN"
        Dim cmDN As New SqlClient.SqlCommand(sDN, cn)
        Dim cmDN1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DN', RESEED, 0)", cn)
        Dim sDNK As String = "DELETE FROM DNKEMA"
        Dim cmDNK As New SqlClient.SqlCommand(sDNK, cn)
        Dim cmDNK1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DNKEMA', RESEED, 0)", cn)
        Dim sDR As String = "DELETE FROM DOCTORR"
        Dim cmDR As New SqlClient.SqlCommand(sDR, cn)
        Dim cmDR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DOCTORR', RESEED, 0)", cn)
        Dim sD As String = "DELETE FROM DOCUMENT"
        Dim cmD As New SqlClient.SqlCommand(sD, cn)
        Dim cmD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DOCUMENT', RESEED, 0)", cn)
        Dim sEH As String = "DELETE FROM EIA_HORMONAL"
        Dim cmEH As New SqlClient.SqlCommand(sEH, cn)
        Dim cmEH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('EIA_HORMONAL', RESEED, 0)", cn)
        Dim sEL As String = "DELETE FROM ELECTROLYTES"
        Dim cmEL As New SqlClient.SqlCommand(sEL, cn)
        Dim cmEL1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('ELECTROLYTES', RESEED, 0)", cn)
        Dim sHA As String = "DELETE FROM HESAB_AM"
        Dim cmHA As New SqlClient.SqlCommand(sHA, cn)
        Dim cmHA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HESAB_AM', RESEED, 0)", cn)
        Dim sHD As String = "DELETE FROM HESAB_DO"
        Dim cmHD As New SqlClient.SqlCommand(sHD, cn)
        Dim cmHD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HESAB_DO', RESEED, 0)", cn)
        Dim sH As String = "DELETE FROM HISTORY"
        Dim cmH As New SqlClient.SqlCommand(sH, cn)
        Dim cmH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HISTORY', RESEED, 0)", cn)
        Dim sHAS As String = "DELETE FROM HORMONAL_ASSAY"
        Dim cmHAS As New SqlClient.SqlCommand(sHAS, cn)
        Dim cmHAS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HORMONAL_ASSAY', RESEED, 0)", cn)
        Dim sJAD As String = "DELETE FROM JAD"
        Dim cmJAD As New SqlClient.SqlCommand(sJAD, cn)
        Dim cmJAD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAD', RESEED, 0)", cn)
        Dim sJAM As String = "DELETE FROM JAM"
        Dim cmJAM As New SqlClient.SqlCommand(sJAM, cn)
        Dim cmJAM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAM', RESEED, 0)", cn)
        Dim sJAS As String = "DELETE FROM JAS"
        Dim cmJAS As New SqlClient.SqlCommand(sJAS, cn)
        Dim cmJAS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAS', RESEED, 0)", cn)
        Dim sJKT As String = "DELETE FROM JEHAKASHEFT"
        Dim cmJKT As New SqlClient.SqlCommand(sJKT, cn)
        Dim cmJKT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JEHAKASHEFT', RESEED, 0)", cn)
        Dim sJK As String = "DELETE FROM JK"
        Dim cmJK As New SqlClient.SqlCommand(sJK, cn)
        Dim cmJK1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JK', RESEED, 0)", cn)
        Dim sJS As String = "DELETE FROM JS"
        Dim cmJS As New SqlClient.SqlCommand(sJS, cn)
        Dim cmJS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JS', RESEED, 0)", cn)
        Dim sJSH As String = "DELETE FROM JSH"
        Dim cmJSH As New SqlClient.SqlCommand(sJSH, cn)
        Dim cmJSH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JSH', RESEED, 0)", cn)
        Dim sJT As String = "DELETE FROM JT"
        Dim cmJT As New SqlClient.SqlCommand(sJT, cn)
        Dim cmJT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JT', RESEED, 0)", cn)
        Dim sJTGH As String = "DELETE FROM JTGH"
        Dim cmJTGH As New SqlClient.SqlCommand(sJTGH, cn)
        Dim cmJTGH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JTGH', RESEED, 0)", cn)
        Dim sKA As String = "DELETE FROM KASHEF"
        Dim cmKA As New SqlClient.SqlCommand(sKA, cn)
        Dim cmKA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KASHEF', RESEED, 0)", cn)
        Dim sLAB As String = "DELETE FROM LAB"
        Dim cmLAB As New SqlClient.SqlCommand(sLAB, cn)
        Dim cmLAB1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LAB', RESEED, 0)", cn)
        Dim sLABD As String = "DELETE FROM LABDOC"
        Dim cmLABD As New SqlClient.SqlCommand(sLABD, cn)
        Dim cmLABD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LABDOC', RESEED, 0)", cn)
        Dim sLFT As String = "DELETE FROM LFT"
        Dim cmLFT As New SqlClient.SqlCommand(sLFT, cn)
        Dim cmLFT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LFT', RESEED, 0)", cn)
        Dim sLOSS As String = "DELETE FROM LOSS"
        Dim cmLOSS As New SqlClient.SqlCommand(sLOSS, cn)
        Dim cmLOSS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LOSS', RESEED, 0)", cn)
        Dim sM As String = "DELETE FROM MAIN"
        Dim cmM As New SqlClient.SqlCommand(sM, cn)
        Dim cmM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED, 0)", cn)
        Dim sMO As String = "DELETE FROM MOSTAFEED"
        Dim cmMO As New SqlClient.SqlCommand(sMO, cn)
        Dim cmMO1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('MOSTAFEED', RESEED, 0)", cn)
        Dim sPH As String = "DELETE FROM PHARMACY"
        Dim cmPH As New SqlClient.SqlCommand(sPH, cn)
        Dim cmPH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PHARMACY', RESEED, 0)", cn)
        Dim sPRT As String = "DELETE FROM PROTHONBIN_TEST"
        Dim cmPRT As New SqlClient.SqlCommand(sPRT, cn)
        Dim cmPRT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PROTHONBIN_TEST', RESEED, 0)", cn)
        Dim sR As String = "DELETE FROM REPORT"
        Dim cmR As New SqlClient.SqlCommand(sR, cn)
        Dim cmR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('REPORT', RESEED, 0)", cn)
        Dim sRFT As String = "DELETE FROM LAB"
        Dim cmRFT As New SqlClient.SqlCommand(sRFT, cn)
        Dim cmRFT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LAB', RESEED, 0)", cn)
        Dim sSAD As String = "DELETE FROM SADAD"
        Dim cmSAD As New SqlClient.SqlCommand(sSAD, cn)
        Dim cmSAD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SADAD', RESEED, 0)", cn)
        Dim sSA As String = "DELETE FROM SEMEN_ANALYSIS"
        Dim cmSA As New SqlClient.SqlCommand(sSA, cn)
        Dim cmSA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SEMEN_ANALYSIS', RESEED, 0)", cn)
        Dim sSER As String = "DELETE FROM SEROLOGY"
        Dim cmSER As New SqlClient.SqlCommand(sSER, cn)
        Dim cmSER1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SEROLOGY', RESEED, 0)", cn)
        Dim sTOR As String = "DELETE FROM TIROID"
        Dim cmTOR As New SqlClient.SqlCommand(sTOR, cn)
        Dim cmTOR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TIROID', RESEED, 0)", cn)
        Dim sTORCH As String = "DELETE FROM TORCH"
        Dim cmTORCH As New SqlClient.SqlCommand(sTORCH, cn)
        Dim cmTORCH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TORCH', RESEED, 0)", cn)
        Dim sTP As String = "DELETE FROM TREATMENT_PLANING"
        Dim cmTP As New SqlClient.SqlCommand(sTP, cn)
        Dim cmTP1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TREATMENT_PLANING', RESEED, 0)", cn)
        Dim sTV As String = "DELETE FROM TREATMENT_VISITS"
        Dim cmTV As New SqlClient.SqlCommand(sTV, cn)
        Dim cmTV1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TREATMENT_VISITS', RESEED, 0)", cn)
        Dim sU As String = "DELETE FROM URINE"
        Dim cmU As New SqlClient.SqlCommand(sU, cn)
        Dim cmU1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('URINE', RESEED, 0)", cn)
        Dim sUS As String = "DELETE FROM USERS"
        Dim cmUS As New SqlClient.SqlCommand(sUS, cn)
        Dim cmUS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('USERS', RESEED, -1)", cn)
        Dim sV As String = "DELETE FROM VIROLOGY"
        Dim cmV As New SqlClient.SqlCommand(sV, cn)
        Dim cmV1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('VIROLOGY', RESEED, 0)", cn)
        Dim sW As String = "DELETE FROM WIDAL_TEST"
        Dim cmW As New SqlClient.SqlCommand(sW, cn)
        Dim cmW1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('WIDAL_TEST', RESEED, 0)", cn)
        Dim sWTY As String = "DELETE FROM TYPEEYWAA"
        Dim cmWTY As New SqlClient.SqlCommand(sWTY, cn)
        Dim cmW1TY As New SqlClient.SqlCommand("DBCC CHECKIDENT('TYPEEYWAA', RESEED, 0)", cn)
        'Try
        cmY.ExecuteNonQuery()
        cmM.ExecuteNonQuery()
        cmK.ExecuteNonQuery()
        cmk1.ExecuteNonQuery()
        cmJ.ExecuteNonQuery()
        cmj1.ExecuteNonQuery()
        cmDOC.ExecuteNonQuery()
        cmDOC1.ExecuteNonQuery()
        cmCDOC.ExecuteNonQuery()
        cmCDOC1.ExecuteNonQuery()
        cmFDOC.ExecuteNonQuery()
        cmfDOC1.ExecuteNonQuery()
        cmFTDOC.ExecuteNonQuery()
        cmftDOC1.ExecuteNonQuery()
        cmKAB.ExecuteNonQuery()
        cmKAB1.ExecuteNonQuery()
        cmMDOC.ExecuteNonQuery()
        cmMDOC1.ExecuteNonQuery()
        cmTAH.ExecuteNonQuery()
        cmTDOC.ExecuteNonQuery()
        cmAMA.ExecuteNonQuery()
        cmAMAM.ExecuteNonQuery()
        cmAP.ExecuteNonQuery()
        cmBIO.ExecuteNonQuery()
        cmCBC.ExecuteNonQuery()
        cmDNK.ExecuteNonQuery()
        cmDR.ExecuteNonQuery()
        cmD.ExecuteNonQuery()
        cmEH.ExecuteNonQuery()
        cmEL.ExecuteNonQuery()
        cmHA.ExecuteNonQuery()
        cmHD.ExecuteNonQuery()
        cmH.ExecuteNonQuery()
        cmHAS.ExecuteNonQuery()
        cmJAD.ExecuteNonQuery()
        cmJAM.ExecuteNonQuery()
        cmJAS.ExecuteNonQuery()
        cmJKT.ExecuteNonQuery()
        cmJK.ExecuteNonQuery()
        cmJS.ExecuteNonQuery()
        cmJSH.ExecuteNonQuery()
        cmJT.ExecuteNonQuery()
        cmJTGH.ExecuteNonQuery()
        cmKA.ExecuteNonQuery()
        cmLAB.ExecuteNonQuery()
        cmLABD.ExecuteNonQuery()
        cmLFT.ExecuteNonQuery()
        cmLOSS.ExecuteNonQuery()
        cmMO.ExecuteNonQuery()
        cmPH.ExecuteNonQuery()
        cmPRT.ExecuteNonQuery()
        cmR.ExecuteNonQuery()
        cmRFT.ExecuteNonQuery()
        cmSAD.ExecuteNonQuery()
        cmSA.ExecuteNonQuery()
        cmSER.ExecuteNonQuery()
        cmTOR.ExecuteNonQuery()
        cmTORCH.ExecuteNonQuery()
        cmTP.ExecuteNonQuery()
        cmTV.ExecuteNonQuery()
        cmU.ExecuteNonQuery()
        cmUS.ExecuteNonQuery()
        cmV.ExecuteNonQuery()
        cmW.ExecuteNonQuery()
        cmDN.ExecuteNonQuery()
        cmWTY.ExecuteNonQuery()


        cmMY.ExecuteNonQuery()
        cmTAH1.ExecuteNonQuery()
        cmTDOC1.ExecuteNonQuery()
        cmAMA1.ExecuteNonQuery()
        cmAMAM1.ExecuteNonQuery()
        cmAP1.ExecuteNonQuery()
        cmBIO1.ExecuteNonQuery()
        cmCBC1.ExecuteNonQuery()
        cmDN1.ExecuteNonQuery()
        cmDNK1.ExecuteNonQuery()
        cmDR1.ExecuteNonQuery()
        cmD1.ExecuteNonQuery()
        cmEH1.ExecuteNonQuery()
        cmEL1.ExecuteNonQuery()
        cmHA1.ExecuteNonQuery()
        cmHD1.ExecuteNonQuery()
        cmH1.ExecuteNonQuery()
        cmHAS1.ExecuteNonQuery()
        cmJAD1.ExecuteNonQuery()
        cmJAM1.ExecuteNonQuery()
        cmJAS1.ExecuteNonQuery()
        cmJKT1.ExecuteNonQuery()
        cmJK1.ExecuteNonQuery()
        cmJS1.ExecuteNonQuery()
        cmJSH1.ExecuteNonQuery()
        cmJT1.ExecuteNonQuery()
        cmJTGH1.ExecuteNonQuery()
        cmKA1.ExecuteNonQuery()
        cmLAB1.ExecuteNonQuery()
        cmLABD1.ExecuteNonQuery()
        cmLFT1.ExecuteNonQuery()
        cmLOSS1.ExecuteNonQuery()
        cmM1.ExecuteNonQuery()
        cmMO1.ExecuteNonQuery()
        cmPH1.ExecuteNonQuery()
        cmPRT1.ExecuteNonQuery()
        cmR1.ExecuteNonQuery()
        cmRFT1.ExecuteNonQuery()
        cmSAD1.ExecuteNonQuery()
        cmSA1.ExecuteNonQuery()
        cmSER1.ExecuteNonQuery()
        cmTOR1.ExecuteNonQuery()
        cmTORCH1.ExecuteNonQuery()
        cmTP1.ExecuteNonQuery()
        cmTV1.ExecuteNonQuery()
        cmU1.ExecuteNonQuery()
        cmUS1.ExecuteNonQuery()
        cmV1.ExecuteNonQuery()
        cmW1.ExecuteNonQuery()
        cmW1TY.ExecuteNonQuery()
        Call Class4.CONNIC()
        MsgBox("تم تصفير قاعدة البيانات")
        End
    End Sub

    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If My.Settings.CLIN = "النسخة تجريبية" Then
        '    NotifyIcon1.BalloonTipText = "هذه " + My.Settings.CLIN
        'Else
        '    NotifyIcon1.BalloonTipText = "هذه النسخة مرخصة ل" + My.Settings.CLIN
        'End If
        'NotifyIcon1.ShowBalloonTip(200)
        Call Class1.CONNIC()
        Me.Text = My.Settings.CLIN
        Dim skkhO As String
        skkhO = "select * from MOSTAFEED"
        Dim adkkhO As New SqlClient.SqlDataAdapter(skkhO, cn)
        Dim dskkhO As New DataSet
        adkkhO.Fill(dskkhO, "MOSTAFEED")
        ComboBox1.DataSource = dskkhO.Tables(0)
        ComboBox1.DisplayMember = "NAMEM"
        ComboBox1.SelectedIndex = -1
        If ComboBox1.Items.Count = 0 Then
            Dim ss2 As String = "insert into Mostafeed(NameM,JehaM)VALUES(@NameM,@JehaM)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("@NameM", "نقدا")
            cmm2.Parameters.AddWithValue("@JehaM", "نقدا")
            Try
                cmm2.ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End If
        Button14.Visible = t1
        Panel4.Visible = T15
        Me.Label3.Text = My.Settings.CLIN
        Button1.Visible = t2
        If t3 = True Or t4 = True Or t5 = True Or t6 = True Or t7 = True Or t8 = True Or T9 = True Or T10 = True Then
            Button2.Visible = True
        Else
            Button2.Visible = False
        End If
        Button4.Visible = T11
        Button6.Visible = T12
        'إدارةالمستفيدوالجهاتToolStripMenuItem.Visible = T13
        'إدارةالعملياتToolStripMenuItem.Visible = T14
        If T11 = True Or T12 = True Or T13 = True Or T14 = True Or T15 = True Then
            Button3.Visible = True
            Button5.Visible = True
        Else
            Button3.Visible = False
            Button5.Visible = False
        End If

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Panel3.Visible = False
        Call Class4.CONNIC()
        Dim f As New EYWAA
        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel3.Visible = False
        'Panel3.Location() = New Point(313, 173)
        Call Class4.CONNIC()
        Dim f As New AMALEATvb
        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim ZakahReport As New ByDate2
        ZakahReport.ShowDialog()
    End Sub
End Class