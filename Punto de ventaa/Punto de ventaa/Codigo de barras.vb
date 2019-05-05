Imports System.Data
Imports System.Data.SqlClient
Public Class Codigo_de_barras
    Private Sub Codigo_de_barras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Config.IniciarConexion()
    End Sub

    Private Sub BtnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnManual.Select()
        End If
    End Sub

    Private Sub txtCodigo_Validated(sender As Object, e As EventArgs) Handles txtCodigo.Validated
        Config.EmpConfig = txtCodigo.Text.Trim()
        If txtCodigo.Text.Trim() = " " Then
            Exit Sub
        End If
        Dim acc As String = " "
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "Acceso Usuario"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@Id_Usuario", SqlDbType.NChar, 10).Value = txtCodigo.Text.ToString()

        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")
            End While
        Else
            MessageBox.Show("Usuario no encontrado")
        End If
        DReader.Close()
        Select Case acc.Trim()
            Case "Administrador"
                Menuu.Show()
            Case "Cajero"

            Case " "
                Me.Close()
        End Select
    End Sub
End Class