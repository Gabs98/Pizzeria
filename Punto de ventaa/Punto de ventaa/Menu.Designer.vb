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
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeMaterialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromocionesYCombosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem, Me.ListaDeMaterialesToolStripMenuItem, Me.CatalogoDeProductosToolStripMenuItem, Me.PromocionesYCombosToolStripMenuItem, Me.ToolStripMenuItem1, Me.EmpleadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(810, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.CatalogoToolStripMenuItem.Text = "Catalogo de articulos"
        '
        'ListaDeMaterialesToolStripMenuItem
        '
        Me.ListaDeMaterialesToolStripMenuItem.Name = "ListaDeMaterialesToolStripMenuItem"
        Me.ListaDeMaterialesToolStripMenuItem.Size = New System.Drawing.Size(145, 24)
        Me.ListaDeMaterialesToolStripMenuItem.Text = "Lista de materiales"
        '
        'CatalogoDeProductosToolStripMenuItem
        '
        Me.CatalogoDeProductosToolStripMenuItem.Name = "CatalogoDeProductosToolStripMenuItem"
        Me.CatalogoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.CatalogoDeProductosToolStripMenuItem.Text = "Catalogo de productos"
        '
        'PromocionesYCombosToolStripMenuItem
        '
        Me.PromocionesYCombosToolStripMenuItem.Name = "PromocionesYCombosToolStripMenuItem"
        Me.PromocionesYCombosToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.PromocionesYCombosToolStripMenuItem.Text = "Promociones y combos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 24)
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 527)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeMaterialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromocionesYCombosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
End Class
