Public Class Form1

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        choosecar.Show()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        chooseenginestage.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exhausteng.Show()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        coleerchostage.Show()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        intakechoose.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        choosedsg.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.username And
           TextBox2.Text = My.Settings.password Then
            checkout.Show()
        Else
            MsgBox("Incorrect username or password", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Enter Valid account and password", MsgBoxStyle.Information, "Error")
        Else
            My.Settings.username = TextBox1.Text
            My.Settings.password = TextBox2.Text
            My.Settings.Save()
            MsgBox("signed up ", MsgBoxStyle.Information, "Welcome")
        End If


    End Sub
End Class
