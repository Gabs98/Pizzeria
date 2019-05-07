Imports System.Data
Imports System.Data.SqlClient
Public Class Catalogo_de_articulos
    Public DbSql As SqlConnection
    Dim TblArticulos As DataTable = New DataTable()
    Public vIDArticuloID As String
    Public vRegistroActual As Integer
    Public vTotalArticulos As Integer
    Public vArticuloNuevo As Boolean = False

    Private Sub Catalogo_de_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbSql = New SqlConnection(Config.ConectionString)
        DbSql.Open()
        LlenaTablaArticulos()
        HabilitaDeshabilitaTextos(False)
    End Sub
    Private Sub frmArticulos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DbSql.Close()
    End Sub
    Private Sub TsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbSalir.Click
        Me.Close()
    End Sub

    Private Sub LlenaTablaArticulos()
        Dim Comm As SqlCommand
        Comm = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.Text
        Comm.CommandText = "Select * from Articulos Order by idArticulo"
        Dim SqlDA As SqlDataAdapter = New SqlDataAdapter(Comm)
        SqlDA.Fill(TblArticulos)
        DgvArticulos.DataSource = TblArticulos
        vTotalArticulos = TblArticulos.Rows.Count
        If TblArticulos.Rows.Count = 0 Then
            TsbPrimero.Enabled = False
            TsbAnterior.Enabled = False
            TsbSiguiente.Enabled = False
            TsbUltimo.Enabled = False
        Else
            vIDArticuloID = TblArticulos.Rows(0)("IDArticulo").ToString()
            Llena_Textos(0)
        End If
    End Sub

    Private Sub HabilitaDeshabilitaTextos(ByVal vEdicion As Boolean)
        txtIDArticulo.ReadOnly = Not vEdicion
        txtNombre.ReadOnly = Not vEdicion
        cmbUM.Enabled = vEdicion
        NdMinimo.Enabled = vEdicion
        NdMaximo.Enabled = vEdicion
        txtCosto.ReadOnly = Not vEdicion
        cmbStatus.Enabled = vEdicion
        txtCantidadExistente.ReadOnly = Not vEdicion
        txtPrecioVenta.ReadOnly = Not vEdicion

        If vEdicion = True Then
            TsbGrabar.Enabled = True
            TsbCancelar.Enabled = True
            TsbNuevo.Enabled = False
            TsbEditar.Enabled = False
            TsbBorrar.Enabled = False

            TsbPrimero.Enabled = False
            TsbAnterior.Enabled = False
            TsbSiguiente.Enabled = False
            TsbUltimo.Enabled = False

        Else
            vArticuloNuevo = False
            TsbGrabar.Enabled = False
            TsbCancelar.Enabled = False
            TsbNuevo.Enabled = True
            TsbEditar.Enabled = True
            TsbBorrar.Enabled = True

            TsbPrimero.Enabled = True
            TsbAnterior.Enabled = True
            TsbSiguiente.Enabled = True
            TsbUltimo.Enabled = True
        End If
    End Sub


    Private Sub TsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbNuevo.Click
        HabilitaDeshabilitaTextos(True)
        vArticuloNuevo = True
        TabControl1.SelectedIndex = 1

        txtIDArticulo.Text = ""
        txtNombre.Text = ""
        cmbUM.Text = ""
        NdMinimo.Value = 1
        NdMaximo.Value = 1
        txtCosto.Text = ""
        cmbStatus.Text = ""
        txtCantidadExistente.Text = 1
        txtPrecioVenta.Text = 0
        txtIDArticulo.Focus()
    End Sub

    Private Sub Llena_Textos(ByVal vRecord As Integer)
        txtIDArticulo.Text = TblArticulos.Rows(vRecord)("IDArticulo").ToString()
        txtNombre.Text = TblArticulos.Rows(vRecord)("Nombre").ToString()
        cmbUM.Text = TblArticulos.Rows(vRecord)("UnidadMedida").ToString()
        NdMinimo.Value = Decimal.Parse(TblArticulos.Rows(vRecord)("Minimo").ToString())
        NdMaximo.Value = Decimal.Parse(TblArticulos.Rows(vRecord)("Maximo").ToString())
        txtCosto.Text = TblArticulos.Rows(vRecord)("Costo").ToString()
        cmbStatus.Text = TblArticulos.Rows(vRecord)("Vigencia").ToString()
        txtCantidadExistente.Text = TblArticulos.Rows(vRecord)("CantidadExistente").ToString()
        txtPrecioVenta.Text = TblArticulos.Rows(vRecord)("PrecioVenta").ToString()
    End Sub

    Private Sub TsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbCancelar.Click
        HabilitaDeshabilitaTextos(False)
    End Sub

    Private Sub TsbPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbPrimero.Click
        Llena_Textos(0)
    End Sub

    Private Sub TsbAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbAnterior.Click
        If vRegistroActual > 0 Then
            vRegistroActual = vRegistroActual - 1
            Llena_Textos(vRegistroActual)
        End If
    End Sub

    Private Sub TsbSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbSiguiente.Click
        If (vRegistroActual + 1) < vTotalArticulos Then
            vRegistroActual = vRegistroActual + 1
            Llena_Textos(vRegistroActual)
        End If
    End Sub

    Private Sub TsbUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbUltimo.Click
        Llena_Textos(vTotalArticulos - 1)
    End Sub

    Private Sub TsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbGrabar.Click
        Dim vStoreProcedure As String
        If vArticuloNuevo = True Then
            vStoreProcedure = "INS_ARTICULO"
        Else
            vStoreProcedure = "MODIFICA_ARTICULO"
        End If
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = vStoreProcedure
        Comm.Parameters.Add("@IDArticulo", SqlDbType.NVarChar, 15).Value = txtIDArticulo.Text.ToString()
        Comm.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = txtNombre.Text.ToString()
        Comm.Parameters.Add("@UnidadMedida", SqlDbType.NVarChar, 10).Value = cmbUM.Text.ToString()
        Comm.Parameters.Add("@Minimo", SqlDbType.Decimal).Value = NdMinimo.Value
        Comm.Parameters.Add("@Maximo", SqlDbType.Decimal).Value = NdMaximo.Value
        Comm.Parameters.Add("@Costo", SqlDbType.Decimal).Value = Double.Parse(txtCosto.Text.ToString())
        Comm.Parameters.Add("@CantidadExistente", SqlDbType.Decimal).Value = Double.Parse(txtCantidadExistente.Text.ToString())
        Comm.Parameters.Add("@Vigencia", SqlDbType.VarChar, 12).Value = cmbStatus.Text.ToString()
        Comm.Parameters.Add("@PrecioVenta", SqlDbType.Decimal).Value = Double.Parse(txtPrecioVenta.Text.ToString())
        Comm.ExecuteNonQuery()

        LlenaTablaArticulos()
        HabilitaDeshabilitaTextos(False)

    End Sub

    Private Sub DgvArticulos_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvArticulos.RowEnter
        Llena_Textos(e.RowIndex)
    End Sub

    Private Sub TsbBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbBorrar.Click
        Dim Comm As SqlCommand = New SqlCommand()
        Comm.Connection = DbSql
        Comm.CommandType = CommandType.StoredProcedure
        Comm.CommandText = "BORRAR_ARTICULO"
        Comm.Parameters.Add("@IDArticulo", SqlDbType.NVarChar, 15).Value = txtIDArticulo.Text.ToString()
        Comm.ExecuteNonQuery()

        LlenaTablaArticulos()
        HabilitaDeshabilitaTextos(False)
    End Sub

End Class