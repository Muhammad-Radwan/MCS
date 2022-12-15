Imports System.Data.SqlClient

Public Class BackupandRestore

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "BACKUP DATABASE C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\clinicsql TO DISK='d:\clinicsql.BAK'"
        cmd.CommandText = "BACKUP DATABASE clinicsql TO DISK='e:\clinicsql.BAK' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of clinicsql';"
        cmd.Connection = cn
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "(الإسترجاع)*.bak|*.bak"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then cn.Open() : Exit Sub
        Dim cn1 As New OleDb.OleDbConnection
        Dim ext As String = OpenFileDialog1.FileName
        If IO.Path.GetExtension(ext) <> ".bak" Then
        ElseIf IO.Path.GetExtension(ext) <> ".BAK" Then
            MsgBox("هذا الملف ليس قاعدة بيانات")
            Exit Sub
        End If
        'Try
        'cn1.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=" & OpenFileDialog1.FileName() & "jet OLEDB:Database Password=13061982;"
        'cn1.Open()
        'Dim s As String = "select * from m1"
        'Dim myc As New OleDb.OleDbCommand(s, cn1)
        'Dim myr As OleDb.OleDbDataReader = myc.ExecuteReader
        'If myr.Read Then
        'End If
        'myr.Close()
        'myc.Dispose()
        'FileCopy(OpenFileDialog1.FileName, serv & "\Hotel.mdb")
        'Dim cmd As New SqlCommand
        'cmd.CommandType = CommandType.Text
        ''cmd.CommandText = "BACKUP DATABASE C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\clinicsql TO DISK='d:\clinicsql.BAK'"
        'cmd.CommandText = "RESTORE VERIFYONLY FROM DISK = '" & OpenFileDialog1.FileName & "';"
        'cmd.Connection = cn
        'cmd.ExecuteNonQuery()
        'Try
        '    'Dim cmd As New SqlCommand
        '    cmd.CommandType = CommandType.Text
        '    'cmd.CommandText = "BACKUP DATABASE C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\clinicsql TO DISK='d:\clinicsql.BAK'"
        '    cmd.CommandText = "RESTORE FILELISTONLY FROM DISK = '" & OpenFileDialog1.FileName & "';"
        '    cmd.Connection = cn
        '    cmd.ExecuteNonQuery()
        'Try
        'Dim cmd As New SqlCommand
        'cmd.CommandType = CommandType.Text
        ''cmd.CommandText = "BACKUP DATABASE C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\clinicsql TO DISK='d:\clinicsql.BAK'"
        'cmd.CommandText = "RESTORE DATABASE CLINICSQL FROM DISK = '" & OpenFileDialog1.FileName & "' WITH RECOVERY, Move() 'CLINICSQL.mdf' TO 'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CLINICSQL.mdf', Move() 'CLINICSQL_log.LDF' TO 'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CLINICSQL_log.LDF';"
        'cmd.Connection = cn
        'cmd.ExecuteNonQuery()
        'Dim strSql As String = "use master " & "RESTORE DATABASE CLINICSQL" & " " & "from disk = 'C:\MSSQL\DATA\CLINICSQL.mdf' "
        'Dim connString As New SqlConnection
        'connString.ConnectionString = "server=SYSLC\SQLEXPRESS;Trusted_Connection=false;user id=sa;password=13061982;database=CLINICSQL"
        'Dim sqlComm As New SqlCommand(strSql, connString)
        'connString.Open()
        'sqlComm.ExecuteNonQuery()
        'connString.Close()
        'Catch ex As Exception
        '    MsgBox("خطأ الاستعاده")
        'End Try
        'Catch ex As Exception
        '    MsgBox("خطأ التحقق")
        'End Try
        'ALTER AUTHORIZATION ON DATABASE::Adv2012 TO SA;
        'MsgBox(" تمت عملية إلإسترجاع لقاعدة البيانات  ", MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MsgBox("فشلت عمليةإسترجاع الملف غير صحيح", MsgBoxStyle.Information)
        'End Try

        Dim sql As String = "RESTORE DATABASE [clinicsql123] " & _
"FROM DISK = N'" & OpenFileDialog1.FileName & "' " & _
"WITH FILE = 1," & _
"Move N'clinicsql123' TO N'C:clinicsql123.mdf'," & _
"Move N'clinicsql123_log' TO N'C:clinicsql123.ldf'," & _
"NOUNLOAD, STATS = 10"

        Dim cnn As SqlConnection = New SqlConnection("server=.\sqlexpress;initial catalog=CLINICSQL123;integrated security=true;")
        cnn.Open()
        Dim cmdd As SqlCommand = New SqlCommand(sql, cnn)
        cmdd.ExecuteNonQuery()
    End Sub
End Class