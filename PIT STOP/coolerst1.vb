Public Class coolerst1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        coleerchostage.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        checkout.ListBox1.Items.Add(Label3.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        checkout.Show()
        Me.Hide()
    End Sub
End Class