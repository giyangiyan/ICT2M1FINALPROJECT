Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlDesert.Visible = False
        pnlDrinks.Visible = False
        pnlPizza.Visible = True
        pnlCart.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlDesert.Visible = False
        pnlDrinks.Visible = True
        pnlPizza.Visible = False
        pnlCart.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlDesert.Visible = True
        pnlDrinks.Visible = False
        pnlPizza.Visible = False
        pnlCart.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnlDesert.Visible = False
        pnlDrinks.Visible = False
        pnlPizza.Visible = False
        pnlCart.Visible = True

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlCart_Paint(sender As Object, e As PaintEventArgs) Handles pnlCart.Paint

    End Sub
End Class
