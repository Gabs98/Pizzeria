Imports System.Data.SqlClient
Imports System.Data
Module Config
    Public ConnSql As SqlConnection
    Public EmpConfig As String

    Public Property ConectionString As String

    Public Sub IniciarConexion()
        ConnSql = New SqlConnection("Server= MSI; Database=C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL12.SQLEXPRESS\MSSQL\DATA\PIZZERIAPALITROCHE.MDF; Trusted_Connetion=True;")
        ConnSql.Open()
    End Sub
End Module
