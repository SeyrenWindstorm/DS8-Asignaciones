Public Class FormPrincipal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f1 As New FormOperacion

        f1.Show()

        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarU.Click
        Dim f1 As New FormCuentas

        f1.Show()

        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class