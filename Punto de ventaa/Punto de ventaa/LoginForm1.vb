Imports System.Data
Imports System.Data.SqlClient
Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
        If txtUsuario.Text.Trim() = " " Then
            Exit Sub
        End If
        Dim acc As String = " "
        Dim pass As String
        Dim Comm As New SqlCommand()
        Comm.Connection = ConnSql
        Comm.CommandText = "Acceso Usuario Login"
        Comm.CommandType = CommandType.StoredProcedure
        Comm.Parameters.Add("@Login", SqlDbType.NChar, 10).Value = txtUsuario.Text.ToString()

        Dim DReader As SqlDataReader = Comm.ExecuteReader
        If DReader.HasRows Then
            While DReader.Read()
                acc = DReader("Nombre_Cat")
                pass = DReader("Password")
            End While
        Else
            MessageBox.Show("Usuario no encontrado")
        End If
        DReader.Close()

        If txtPassword.Text = pass.Trim() Then
            Select Case acc.Trim()
                Case "Administrador"
                    Menuu.Show()
                Case "Cajero"
                    Venta.Show()
            End Select
        Else
            MsgBox("Password incorrecto")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
