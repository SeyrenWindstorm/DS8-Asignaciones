Public Class Form1
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles ValorResultado.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ValorY.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g, y, q, resultado As Decimal

        y = Val(ValorY.Text)
        q = Val(ValorQ.Text)
        g = Val(ValorG.Text)
        resultado = Val(ValorResultado.Text)


        resultado = y + (q ^ 2 / (2 * g * (y ^ 2)))

        ValorResultado.Text = Format(Math.Round(resultado, 2), "#.##")



    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles ValorG.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles ValorQ.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
