Public Class yow
    Private Sub yow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim username As String
        'm password As String
        'username = txtUser.Text 
        'assword = txtPass.
        If (txtUser.Text.Equals("Gian") And txtPass.Text.Equals("Turirit")) Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim yow As New yow()
            yow.Show() 'Show Form2
            Me.Hide()
        End If

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class