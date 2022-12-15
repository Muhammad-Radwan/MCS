Imports System.Management
Imports System.Data
Imports System.Data.OleDb
Public Class Activation
   

    'Friend NAMECLINIC As String
    Private Sub Activation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim HDinformation As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
        'Dim HD As ManagementObject
        'For Each HD In HDinformation.Get()
        '    TextBox3.Text = HD("SerialNumber").ToString()
        'Next
        'TextBox2.Text = GetDriveSerialNumber()
        TextBox2.Text = GetVolumeSerial()
        'Dim hd As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
        'For Each dvs As ManagementObject In hd.Get()
        '    Dim serial As String = dvs("SerialNumber").ToString()
        '    TextBox3.Text = serial
        'Next
        'Dim HDD_Serial, MB_serial As String
        'Dim Sniper1 As New ManagementObjectSearcher("select * from Win32_DiskDrive")
        'For Each hd In Sniper1.Get
        '    HDD_Serial = hd("SerialNumber")
        'Next
        TextBox1.Text = My.Settings.CLIN
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Call Class1.CONNIC()
        'Dim ss As String = "INSERT INTO ttt1(ttt1) values(@ttt1)"
        'Dim cmm As New SqlClient.SqlCommand(ss, cn)
        'cmm.Parameters.AddWithValue("@ttt1", Trim(TextBox2.Text))
        Try
            'cmm.ExecuteNonQuery()
            'My.Settings.activ = TextBox2.Text
            'My.Settings.CLIN = TextBox1.Text
            'SaveSetting("CLIN", TextBox1.Text)
            My.Settings.Save()
            'Dim RM As Resources.ResourceManager
            'RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
            'TextBox1.Text = RM.GetString("NAMECLINIC")
            'ProductName.Replace("مستشفى التميز التخصصي", "clinic")
            TextBox1.Enabled = False
            MsgBox("تم تسجيل النشاط")
            Call Class4.CONNIC()
            Me.Close()
        Catch ex As Exception
            MsgBox("لم يتم التنشيط")
            Call Class4.CONNIC()
        End Try
        'RM.BaseName.Replace("مستشفى التميز التخصصي", "123")
    End Sub
End Class