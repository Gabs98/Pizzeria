<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogoArticulos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromocionesYCombos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Empleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoArticulos, Me.ListaDeMateriales, Me.CatalogoDeProductos, Me.PromocionesYCombos, Me.ToolStripMenuItem1, Me.Empleados})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogoArticulos
        '
        Me.CatalogoArticulos.Name = "CatalogoArticulos"
        Me.CatalogoArticulos.Size = New System.Drawing.Size(163, 24)
        Me.CatalogoArticulos.Text = "Catalogo de articulos"
        '
        'ListaDeMateriales
        '
        Me.ListaDeMateriales.Name = "ListaDeMateriales"
        Me.ListaDeMateriales.Size = New System.Drawing.Size(145, 24)
        Me.ListaDeMateriales.Text = "Lista de materiales"
        '
        'CatalogoDeProductos
        '
        Me.CatalogoDeProductos.Name = "CatalogoDeProductos"
        Me.CatalogoDeProductos.Size = New System.Drawing.Size(174, 24)
        Me.CatalogoDeProductos.Text = "Catalogo de productos"
        '
        'PromocionesYCombos
        '
        Me.PromocionesYCombos.Name = "PromocionesYCombos"
        Me.PromocionesYCombos.Size = New System.Drawing.Size(175, 24)
        Me.PromocionesYCombos.Text = "Promociones y combos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 24)
        '
        'Empleados
        '
        Me.Empleados.Name = "Empleados"
        Me.Empleados.Size = New System.Drawing.Size(95, 24)
        Me.Empleados.Text = "Empleados"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Punto_de_ventaa.My.Resources.Resources.cibo_rustico_pizzeria_2017_web_sr
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 618)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogoArticulos As ToolStripMenuItem
    Friend WithEvents ListaDeMateriales As ToolStripMenuItem
    Friend WithEvents CatalogoDeProductos As ToolStripMenuItem
    Friend WithEvents PromocionesYCombos As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Empleados As ToolStripMenuItem
End Class
