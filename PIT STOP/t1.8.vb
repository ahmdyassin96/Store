﻿Public Class t1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        chooseengine.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkout.ListBox1.Items.Add(Label7.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        checkout.ListBox1.Items.Add(Label8.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        checkout.Show()
        Me.Hide()
    End Sub
End Class