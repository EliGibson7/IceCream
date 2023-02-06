Public Class frmMain
    Private Sub listFlavors_Click(sender As Object, e As EventArgs) Handles listFlavors.Click



    End Sub

    Private Sub listFlavors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listFlavors.SelectedIndexChanged

        If listFlavors.SelectedItem Is "Vanilla" Then
            PictureBox1.Image = My.Resources.VanillaIceCream
        End If

        If listFlavors.SelectedItem Is "Chocolate" Then
            PictureBox1.Image = My.Resources.ChocolateIceCream
        End If

        If listFlavors.SelectedItems Is "Strawberry" Then
            PictureBox1.Image = My.Resources.StrawberryIceCream
        End If

        If listFlavors.SelectedItem Is "Cookies and Cream" Then
            PictureBox1.Image = My.Resources.CookiesandCreamIceCream
        End If

        If listFlavors.SelectedItem Is "Raspberry" Then
            PictureBox1.Image = My.Resources.RaspberryIceCream
        End If




    End Sub
End Class
