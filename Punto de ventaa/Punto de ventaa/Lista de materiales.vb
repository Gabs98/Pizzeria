Imports System.Data
Imports System.Data.SqlClient

Public Class Lista_de_materiales
    Public DbSql As SqlConnection
    Private Sub Lista_de_materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbSql = New SqlConnection(Config.ConectionString)
        DbSql.Open()

        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select Nombre,IDArticulo from Articulos Order by Nombre"
        Dim SqlDa As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDa.Fill(tblArticulos)
        CmbArticuloID.ValueMember = "IDArticulo"
        CmbArticuloID.DisplayMember = "Nombre"
        CmbArticuloID.DataSource = tblArticulos

        Comm.Dispose()

    End Sub
    Private Sub FrmListaMateriales_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DbSql.Close()
    End Sub

    Public Function ManejodeListadeMateriales(ByVal vProducto As String, ByVal vNombre As String) As DialogResult
        txtNumProducto.Text = vProducto
        txtNombre.Text = vNombre
        Me.Show()
        Catalogo_de_productos.ActualizaListaMateriales()
        Return btnSalir.DialogResult
    End Function
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        btnSalir.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CmbArticuloID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbArticuloID.SelectedIndexChanged
        txtNombreArt.Text = CmbArticuloID.SelectedValue.ToString()
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select UnidadMedida from Articulos where IDArticulo='" & CmbArticuloID.SelectedValue.ToString() & "'"
        Dim SqlDR As SqlDataReader
        SqlDR = Comm.ExecuteReader()
        If SqlDR.Read() Then
            txtUnidadMedida.Text = SqlDR("UnidadMedida").ToString()
        End If
        SqlDR.Close()
        Comm.Dispose()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Insert into ListaMateriales(NumProducto,IDArticulo,UnidadMedida,Cantidad) " _
          & "Values(@NumProducto,@IDArticulo,@UnidadMedida,@Cantidad) "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IDArticulo", SqlDbType.NVarChar, 15).Value = CmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@UnidadMedida", SqlDbType.NVarChar, 15).Value = txtUnidadMedida.Text.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandText = CommandType.Text
        Comm.CommandType = "Update ListaMateriales set Cantidad= @Cantidad where NumProducto=@NumProducto and " _
           & "IDArticulo=@IDArticulo "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IDArticulo", SqlDbType.NVarChar, 15).Value = CmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()
    End Sub
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Delete from  ListaMateriales where NumProducto=@NumProducto and " _
           & "IDArticulo=@IDArticulo "
        Comm.Parameters.Add("@NumProducto", SqlDbType.NVarChar, 15).Value = txtNumProducto.Text.ToString()
        Comm.Parameters.Add("@IDArticulo", SqlDbType.NVarChar, 15).Value = CmbArticuloID.SelectedValue.ToString()
        Comm.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 15).Value = Decimal.Parse(txtCantidad.Text.ToString())
        Comm.ExecuteNonQuery()

        txtCantidad.Text = 0
        ActualizaLista()
    End Sub
    Private Sub ActualizaLista()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from ListaMateriales where NumProducto='" & txtNumProducto.Text.ToString _
           & "' Order by idArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        Dim tblArticulos As DataTable = New DataTable()
        SqlDA.Fill(tblArticulos)
        DgvLista.DataSource = tblArticulos
    End Sub

End Class