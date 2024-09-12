Public Class Matriz
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyCheck
        Dim Numero As String
        dgvMatriz.ColumnCount = 3
        dgvMatriz.RowCount = 5
        dgvMatriz.Visible = True
        dgvMatriz.ColumnHeadersVisible = False
        dgvMatriz.RowHeadersVisible = False



        For i = 0 To 3
            For j = 0 To 1


                Numero = InputBox("Numero")
                MyCheck = IsNumeric(Numero)

                If (Numero = "") Then
                    MessageBox.Show("Campo Vacio!",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                    dgvMatriz(j, i).Value = 0

                ElseIf MyCheck = False Then
                    MessageBox.Show("El campo contiene Letras ",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                    dgvMatriz(j, i).Value = 0
                Else

                    Dim a As Decimal = CDec(Val(Numero))

                    dgvMatriz(j, i).Value = a
                    dgvMatriz.UpdateCellValue(j, i)


                End If

                dgvMatriz(2, 0).Value = dgvMatriz(0, 0).Value + dgvMatriz(1, 0).Value
                dgvMatriz(2, 1).Value = dgvMatriz(0, 1).Value + dgvMatriz(1, 1).Value
                dgvMatriz(2, 2).Value = dgvMatriz(0, 2).Value + dgvMatriz(1, 2).Value
                dgvMatriz(2, 3).Value = dgvMatriz(0, 3).Value + dgvMatriz(1, 3).Value

                dgvMatriz(0, 4).Value = dgvMatriz(0, 0).Value + dgvMatriz(0, 1).Value + dgvMatriz(0, 2).Value + dgvMatriz(0, 3).Value
                dgvMatriz(1, 4).Value = dgvMatriz(1, 0).Value + dgvMatriz(1, 1).Value + dgvMatriz(1, 2).Value + dgvMatriz(1, 3).Value
            Next
        Next

    End Sub

End Class