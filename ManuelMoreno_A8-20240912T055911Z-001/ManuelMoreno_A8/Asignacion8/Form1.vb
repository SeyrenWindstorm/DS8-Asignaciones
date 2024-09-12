Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class Form1

    Public ob_conexion
    Public servidor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim usuario, psw, BD, servidor As String
        Try
            servidor = ”DESKTOP-PDQLURG”
            usuario = ”sa”
            psw = ”pitsburg12”
            BD = ”Estrellas”
            ob_conexion = New SqlClient.SqlConnection
            ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" 'cadena de conexión
            ob_conexion.Open()
            MsgBox("Conectado al servidor y la BD")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            ob_conexion.Open()
            Dim nombre As String = TextBox1.Text
            Dim tipo As String = TextBox2.Text
            Dim masa As String = TextBox3.Text
            Dim distancia As String = TextBox4.Text
            Dim galaxia As String = TextBox5.Text

            If nombre & tipo & masa & distancia & galaxia = "" Then
                MsgBox("Campos Vacios")
            Else
                smt = "INSERT INTO Clasificadas (Nombre, Tipo, Masa, Distancia, Galaxia) values ('" & nombre & "','" & tipo & "','" & masa & "','" & distancia & "','" & galaxia & "')"
                cmd = New SqlClient.SqlCommand(smt, ob_conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Los datos se guardaron correctamente")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click

        Dim smt As String
        Dim cmd As SqlClient.SqlCommand
        Dim data As SqlClient.SqlDataReader
        Try
            ob_conexion.Open()
            smt = "Select * From Clasificadas"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader
            While (data.Read())
                DataGridView1.Rows.Add(data("Nombre"), data("Tipo"),
                data("Masa"), data("Distancia"), data("Galaxia"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            ob_conexion.Open()
            Dim nombre As String = TextBox1.Text
            Dim tipo As String = TextBox2.Text
            Dim masa As String = TextBox3.Text
            Dim distancia As String = TextBox4.Text
            Dim galaxia As String = TextBox5.Text
            smt = "Update Clasificadas
                 Set Tipo = '" & tipo & " ', Masa = ' " & masa & "', Distancia= '" & distancia & "',
                 Galaxia='" & galaxia & " '
                 where Nombre='" & nombre & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Los datos se han actualizado correctamente")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
            TextBox5.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            ob_conexion.Open()
            Dim nombre As String = TextBox1.Text
            If nombre = "" Then
                MsgBox("Seleccione un Nombre para borrar")
            Else
                smt = "DELETE From Clasificadas Where Nombre = '" & nombre & "' "
                cmd = New SqlClient.SqlCommand(smt, ob_conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("El registro se ha eliminado")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ob_conexion.Close()
    End Sub

End Class
