Public Class Menu
    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoArticulos.Click
        Catalogo_de_articulos.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Catalogo_de_articulos.MdiParent = Me
        Lista_de_materiales.MdiParent = Me
        Catalogo_de_productos.MdiParent = Me
        Promociones_y_combos.MdiParent = Me
        EmpleadosConf.MdiParent = Me
    End Sub

    Private Sub ListaDeMateriales_Click(sender As Object, e As EventArgs) Handles ListaDeMateriales.Click
        Lista_de_materiales.Show()
    End Sub

    Private Sub CatalogoDeProductos_Click(sender As Object, e As EventArgs) Handles CatalogoDeProductos.Click
        Catalogo_de_productos.Show()
    End Sub

    Private Sub PromocionesYCombos_Click(sender As Object, e As EventArgs) Handles PromocionesYCombos.Click
        Promociones_y_combos.Show()
    End Sub

    Private Sub Empleados_Click(sender As Object, e As EventArgs) Handles Empleados.Click
        EmpleadosConf.Show()
    End Sub
End Class
