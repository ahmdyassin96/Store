﻿Public Class intakechoose
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        intakeapr.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        intakepitstop.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        intaketmg.Show()
        Me.Hide()
    End Sub
End Class