Public Class ByDate

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles DateTimePicker2.Validated
        'DateTimePicker3.Value = DateAdd("d", 2, DateTimePicker2.Value)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        VV3 = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        vv4 = Format(DateTimePicker2.Value, "yyyy/MM/dd")
        d1.Value = DateTimePicker1.Value
        d2.Value = DateTimePicker2.Value
        'If HARAKA = True Then
        '    mo = "الحركة من تاريخ" + " " + VV3 + " " + "إلى تاريخ" + " " + vv4
        '    Dim fA As New harakaprnt With {
        '        .USER = user,
        '        .NN = mo
        '    }
        '    If NotifyIcons = False Then
        '        fA.clin = "نسخة تجريبية"
        '    Else
        '        fA.clin = My.Settings.CLIN
        '    End If
        '    fA.notes = My.Settings.NOTES
        '    fA.ShowDialog()
        '    HARAKA = False
        '    Me.Close()
        '    Exit Sub
        'End If
        If fp = 1 Then
            Dim f As New lossprint With {
                .user = user,
                .nn = mo,
                .datex1 = Format(DateTimePicker1.Value, "yyyy/MM/dd"),
                .datex2 = Format(DateTimePicker2.Value, "yyyy/MM/dd"),
                .vv1 = Trim(vv1),
                .vv2 = Trim(vv2)
            }
            If NotifyIcons = False Then
                f.clin = "نسخة تجريبية"
            Else
                f.clin = My.Settings.CLIN
            End If
            f.notes = My.Settings.NOTES
            f.ShowDialog()
        ElseIf fp = 2 Then
            DOCT = 5
            Dim f As New Form59 With {
                .DD1 = Format(DateTimePicker1.Value, "yyyy/MM/dd"),
                .DD2 = Format(DateTimePicker2.Value, "yyyy/MM/dd")
            }
            If NotifyIcons = False Then
                f.CLIN = "نسخة تجريبية"
            Else
                f.CLIN = My.Settings.CLIN
            End If
            f.ShowDialog()
        End If
        Me.Close()
    End Sub

    Private Sub ByDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class