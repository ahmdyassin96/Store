﻿
Public Class dsg7
    Dim cart As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        choosedsg.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkout.ListBox1.Items.Add(Label3.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        checkout.Show()
        Me.Hide()
    End Sub
End Class