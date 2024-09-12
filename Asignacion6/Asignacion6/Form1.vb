Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim caracter() As Char
        Dim t As Integer
        Dim MyCheck



        For t = 0 To 50
            ReDim Preserve caracter(t)
            caracter(t) = InputBox("Ingrese una letra ",
                         "Leer Solo Consonantes",
                         "", 100, 0)

            MyCheck = IsNumeric(caracter(t))

            If (caracter(t) = String.Empty) Then

            End If

            If MyCheck = True Then
                MessageBox.Show("Error esto no es una letra " +
                               "Ingresa una letra")
            ElseIf LCase(caracter(t)) = "a" Or (caracter(t)) = "e" Or LCase(caracter(t)) = "i" Or LCase(caracter(t)) = "o" Or LCase(caracter(t)) = "u" Then

                MessageBox.Show(String.Join("", caracter),
                                "Caracteres",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                t = t + 51
            End If
        Next






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim palabra As String
        Dim Contv, ContC, i, tamaño As Integer
        Dim MyCheck

        palabra = InputBox(" ",
                         "Ingrese una Palabra",
                         "", 100, 0)

        MyCheck = IsNumeric(palabra)
        tamaño = Len(palabra)

        If MyCheck = True Then
            MessageBox.Show("El campo contiene numeros ",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        ElseIf (palabra = String.Empty) Then
            MessageBox.Show("Error el campo esta vacio",
                            "Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Else

            For i = 1 To tamaño

                If Mid(palabra, i, 1) = "a" Or Mid(palabra, i, 1) = "i" Or Mid(palabra, i, 1) = "e" Or Mid(palabra, i, 1) = "o" Or Mid(palabra, i, 1) = "u" Then

                    Contv = Contv + 1
                Else
                    ContC = ContC + 1
                End If
            Next
            MessageBox.Show("Vocales: " & Contv & " Consonante: " & ContC,
            "Completado!",
             MessageBoxButtons.OK,
          MessageBoxIcon.Information)


        End If



    End Sub
End Class
