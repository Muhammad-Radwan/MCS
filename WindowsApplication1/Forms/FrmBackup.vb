Imports System.Windows.Forms
Imports System.IO
Imports System.Data.SqlClient

Public Class FrmBackup

    Private Sub backup_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Timer1.Start()

       
    End Sub

    Private Sub backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call Class1.CONNIC()
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            For Each myd In DriveInfo.GetDrives
                If myd.IsReady Then
                    If myd.DriveType = IO.DriveType.Removable Then
                        TextBox1.Text = myd.Name
                        ListBox1.Items.Add("Drive " & myd.Name & "  is ready")
                        ListBox1.Items.Add("AvailableFreeSpace: " & myd.AvailableFreeSpace)
                        ListBox1.Items.Add("DriveFormat: " & myd.DriveFormat)
                        ListBox1.Items.Add("DriveType: " & myd.DriveType)
                        ListBox1.Items.Add("DriveType: " & myd.DriveType.ToString)
                        ListBox1.Items.Add("Full RootDirectory: " & myd.RootDirectory.FullName)
                        ListBox1.Items.Add("TotalFreeSpace: " & myd.TotalFreeSpace)
                        ListBox1.Items.Add("TotalSize: " & myd.TotalSize)
                        ListBox1.Items.Add("VolumeLabel: " & myd.VolumeLabel)
                        ListBox1.Items.Add(" ")
                        ListBox1.Items.Add(" ")
                    End If
                End If
            Next
            Try
                My.Computer.FileSystem.CreateDirectory(Path & Date.Today.Day & Date.Today.Month & Date.Today.Year)

            Catch ex As Exception

            End Try

            Try
                Call Class1.CONNIC()
                Dim cmd As New SqlCommand
                cmd.CommandType = CommandType.Text
                'cmd.CommandText = "BACKUP DATABASE C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\clinicsql TO DISK='d:\clinicsql.BAK'"
                cmd.CommandText = "BACKUP DATABASE clinicsql TO DISK='" & path & Date.Today.Day & Date.Today.Month & Date.Today.Year & "\CLINICSQL.bak' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of clinicsql';"
                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                MessageBox.Show("تمت عملية النسخ الإحتياطي لقاعدة البيانات" & "  " & "في أمان الله", "النسخ الإحتياطي", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox("لم تتم عملية النسخ الاحتياطي على القرص الخارجي")
            End Try
            Close()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class