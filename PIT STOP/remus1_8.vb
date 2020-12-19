Public Class remus1_8
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        remus.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkout.ListBox1.Items.Add(Label7.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        checkout.ListBox1.Items.Add(Label8.Text)
    End Sub
End Class