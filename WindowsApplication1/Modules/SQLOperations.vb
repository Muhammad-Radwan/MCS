Imports System.Data.SqlClient

Public Class SQLOperations

    Public Function GetDataFromDatabase(Query As String) As DataTable
        Dim DT As New DataTable()
        Try
            Call Class1.CONNIC()
            Dim DA As New SqlDataAdapter(Query, cn)
            Dim DS As New DataSet()

            DA.Fill(DS, "MyTable")

            If DS.Tables(0).Rows.Count > 0 Then
                DT = DS.Tables(0)
            Else
                DT = Nothing
            End If
        Catch ex As Exception
            MsgBox($"حدث خطأ أثناء عملية جلب البيانات {ex.Message}", MsgBoxStyle.Information)
        End Try

        Return DT
    End Function

    Public Function GetValueFromDB(Aggregate As String, FieldName As String, TableName As String, Extra As String) As Decimal
        Dim RV As Decimal = 0
        Try
            Call Class1.CONNIC()
            Dim DT As New DataTable()
            Dim DA As New SqlDataAdapter($"Select {Aggregate}({FieldName}) from {TableName} {Extra}", cn)
            Dim DS As New DataSet()

            DA.Fill(DS, "MyTable")
            DT = DS.Tables(0)

            If DT.Rows(0)(0) = DBNull.Value Then
                RV = 0
            Else
                RV = DT.Rows(0)(0)
            End If
        Catch ex As Exception
            MsgBox($"حدث خطأ أثناء عملية جلب البيانات: {ex.Message}", MsgBoxStyle.Information)
        End Try
        Return RV
    End Function
End Class
