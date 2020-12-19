Public Class checkout
    Dim cart As Integer



    Dim newarray() As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("thank you for buying from BOOST4LIFE ")
        ListBox1.Items.Clear()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim total As Integer
        Dim counter2 As Integer
        If TextBox2.Text.Length < 16 Then
            MsgBox("please enter correct Card number")
            TextBox2.Clear()


        End If
        For Each ahmad As String In ListBox1.Items
            total = total + CInt(ahmad)
        Next
        If (ComboBox1.SelectedItem) Then
            TextBox1.Text = total / ComboBox1.SelectedItem
        Else
            TextBox1.Text = total
        End If

    End Sub
End Class