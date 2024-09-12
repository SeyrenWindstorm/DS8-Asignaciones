Public Class FormCuentas

    Structure Cuenta
        Dim nombre As String
        Dim apellido As String
        Dim cedula As String
        Dim montoi As Decimal
        Dim nc As Integer
    End Structure

    Public Sub Agregar_cuenta(ByRef temp As Cuenta)
        temp.nombre = Val(txtgetnom.Text)
        temp.apellido = Val(txtgetape.Text)
        temp.cedula = Val(txtgetced.Text)
        temp.montoi = Val(txtgetmon.Text)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cuentas(500) As Cuenta
        Dim nc, i As Integer


        If i < 499 Then
            For i = 0 To 499 Step 1
                Agregar_cuenta(Cuentas(i))
                nc = i
            Next
            MessageBox.Show("Se ha agregado una nueva cuenta.", "Operacion completada!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("Please enter a Salesperson's name", "No entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f1 As New FormPrincipal

        f1.Show()

        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtgetced.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtgetnom_TextChanged(sender As Object, e As EventArgs) Handles txtgetnom.TextChanged

    End Sub
End Class