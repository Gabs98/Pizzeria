<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalogo_de_articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catalogo_de_articulos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.TsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.TsbBorrar = New System.Windows.Forms.ToolStripButton()
        Me.TsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.TsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbPrimero = New System.Windows.Forms.ToolStripButton()
        Me.TsbAnterior = New System.Windows.Forms.ToolStripButton()
        Me.TsbSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.TsbUltimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbUM = New System.Windows.Forms.ComboBox()
        Me.txtCantidadExistente = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIDArticulo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.NdMinimo = New System.Windows.Forms.NumericUpDown()
        Me.NdMaximo = New System.Windows.Forms.NumericUpDown()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NdMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NdMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbNuevo, Me.TsbGrabar, Me.TsbBorrar, Me.TsbEditar, Me.TsbCancelar, Me.ToolStripSeparator1, Me.TsbPrimero, Me.TsbAnterior, Me.TsbSiguiente, Me.TsbUltimo, Me.ToolStripSeparator2, Me.TsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(691, 33)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsbNuevo
        '
        Me.TsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbNuevo.Image = CType(resources.GetObject("TsbNuevo.Image"), System.Drawing.Image)
        Me.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbNuevo.Name = "TsbNuevo"
        Me.TsbNuevo.Size = New System.Drawing.Size(24, 30)
        Me.TsbNuevo.Text = "ToolStripButton2"
        '
        'TsbGrabar
        '
        Me.TsbGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TsbGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbGrabar.Image = CType(resources.GetObject("TsbGrabar.Image"), System.Drawing.Image)
        Me.TsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbGrabar.Name = "TsbGrabar"
        Me.TsbGrabar.Size = New System.Drawing.Size(24, 30)
        Me.TsbGrabar.Text = "ToolStripButton1"
        '
        'TsbBorrar
        '
        Me.TsbBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbBorrar.Image = CType(resources.GetObject("TsbBorrar.Image"), System.Drawing.Image)
        Me.TsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbBorrar.Name = "TsbBorrar"
        Me.TsbBorrar.Size = New System.Drawing.Size(24, 30)
        Me.TsbBorrar.Text = "ToolStripButton3"
        '
        'TsbEditar
        '
        Me.TsbEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbEditar.Image = CType(resources.GetObject("TsbEditar.Image"), System.Drawing.Image)
        Me.TsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbEditar.Name = "TsbEditar"
        Me.TsbEditar.Size = New System.Drawing.Size(24, 30)
        Me.TsbEditar.Text = "ToolStripButton4"
        '
        'TsbCancelar
        '
        Me.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbCancelar.Image = CType(resources.GetObject("TsbCancelar.Image"), System.Drawing.Image)
        Me.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbCancelar.Name = "TsbCancelar"
        Me.TsbCancelar.Size = New System.Drawing.Size(24, 30)
        Me.TsbCancelar.Text = "ToolStripButton9"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'TsbPrimero
        '
        Me.TsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbPrimero.Image = CType(resources.GetObject("TsbPrimero.Image"), System.Drawing.Image)
        Me.TsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbPrimero.Name = "TsbPrimero"
        Me.TsbPrimero.Size = New System.Drawing.Size(24, 30)
        Me.TsbPrimero.Text = "ToolStripButton5"
        '
        'TsbAnterior
        '
        Me.TsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbAnterior.Image = CType(resources.GetObject("TsbAnterior.Image"), System.Drawing.Image)
        Me.TsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbAnterior.Name = "TsbAnterior"
        Me.TsbAnterior.Size = New System.Drawing.Size(24, 30)
        Me.TsbAnterior.Text = "ToolStripButton6"
        '
        'TsbSiguiente
        '
        Me.TsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbSiguiente.Image = CType(resources.GetObject("TsbSiguiente.Image"), System.Drawing.Image)
        Me.TsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSiguiente.Name = "TsbSiguiente"
        Me.TsbSiguiente.Size = New System.Drawing.Size(24, 30)
        Me.TsbSiguiente.Text = "ToolStripButton7"
        '
        'TsbUltimo
        '
        Me.TsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbUltimo.Image = CType(resources.GetObject("TsbUltimo.Image"), System.Drawing.Image)
        Me.TsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbUltimo.Name = "TsbUltimo"
        Me.TsbUltimo.Size = New System.Drawing.Size(24, 30)
        Me.TsbUltimo.Text = "ToolStripButton8"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(14, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(665, 409)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvArticulos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(657, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NdMaximo)
        Me.TabPage2.Controls.Add(Me.NdMinimo)
        Me.TabPage2.Controls.Add(Me.cmbStatus)
        Me.TabPage2.Controls.Add(Me.cmbUM)
        Me.TabPage2.Controls.Add(Me.txtCantidadExistente)
        Me.TabPage2.Controls.Add(Me.txtPrecioVenta)
        Me.TabPage2.Controls.Add(Me.txtCosto)
        Me.TabPage2.Controls.Add(Me.txtNombre)
        Me.TabPage2.Controls.Add(Me.txtIDArticulo)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(657, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(163, 219)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(140, 25)
        Me.cmbStatus.TabIndex = 15
        '
        'cmbUM
        '
        Me.cmbUM.FormattingEnabled = True
        Me.cmbUM.Location = New System.Drawing.Point(163, 81)
        Me.cmbUM.Name = "cmbUM"
        Me.cmbUM.Size = New System.Drawing.Size(140, 25)
        Me.cmbUM.TabIndex = 14
        '
        'txtCantidadExistente
        '
        Me.txtCantidadExistente.Location = New System.Drawing.Point(163, 255)
        Me.txtCantidadExistente.Name = "txtCantidadExistente"
        Me.txtCantidadExistente.Size = New System.Drawing.Size(116, 23)
        Me.txtCantidadExistente.TabIndex = 13
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(163, 285)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(116, 23)
        Me.txtPrecioVenta.TabIndex = 12
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(163, 187)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(116, 23)
        Me.txtCosto.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(163, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(321, 23)
        Me.txtNombre.TabIndex = 10
        '
        'txtIDArticulo
        '
        Me.txtIDArticulo.Location = New System.Drawing.Point(163, 17)
        Me.txtIDArticulo.Name = "txtIDArticulo"
        Me.txtIDArticulo.Size = New System.Drawing.Size(116, 23)
        Me.txtIDArticulo.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Precio Venta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cantidad Existente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Vigencia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Costo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Maximo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Minimo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unidad de Medida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Articulo:"
        '
        'TsbSalir
        '
        Me.TsbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbSalir.Image = CType(resources.GetObject("TsbSalir.Image"), System.Drawing.Image)
        Me.TsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSalir.Name = "TsbSalir"
        Me.TsbSalir.Size = New System.Drawing.Size(133, 30)
        Me.TsbSalir.Text = "tsbSalir"
        '
        'DgvArticulos
        '
        Me.DgvArticulos.BackgroundColor = System.Drawing.Color.White
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.DgvArticulos.Location = New System.Drawing.Point(18, 20)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.RowTemplate.Height = 24
        Me.DgvArticulos.Size = New System.Drawing.Size(622, 343)
        Me.DgvArticulos.TabIndex = 0
        '
        'NdMinimo
        '
        Me.NdMinimo.Location = New System.Drawing.Point(163, 121)
        Me.NdMinimo.Name = "NdMinimo"
        Me.NdMinimo.Size = New System.Drawing.Size(120, 23)
        Me.NdMinimo.TabIndex = 18
        '
        'NdMaximo
        '
        Me.NdMaximo.Location = New System.Drawing.Point(163, 150)
        Me.NdMaximo.Name = "NdMaximo"
        Me.NdMaximo.Size = New System.Drawing.Size(120, 23)
        Me.NdMaximo.TabIndex = 19
        '
        'Catalogo_de_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 522)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Catalogo_de_articulos"
        Me.Text = "Catalogo_de_articulos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NdMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NdMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TsbNuevo As ToolStripButton
    Friend WithEvents TsbGrabar As ToolStripButton
    Friend WithEvents TsbBorrar As ToolStripButton
    Friend WithEvents TsbEditar As ToolStripButton
    Friend WithEvents TsbCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TsbPrimero As ToolStripButton
    Friend WithEvents TsbAnterior As ToolStripButton
    Friend WithEvents TsbSiguiente As ToolStripButton
    Friend WithEvents TsbUltimo As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbUM As ComboBox
    Friend WithEvents txtCantidadExistente As TextBox
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIDArticulo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TsbSalir As ToolStripButton
    Friend WithEvents DgvArticulos As DataGridView
    Friend WithEvents NdMaximo As NumericUpDown
    Friend WithEvents NdMinimo As NumericUpDown
End Class
