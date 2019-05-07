<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Me.gpbDetalles = New System.Windows.Forms.GroupBox()
        Me.txtTipoProd = New System.Windows.Forms.TextBox()
        Me.dgvVentaDetalles = New System.Windows.Forms.DataGridView()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNumProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnDomicilio = New System.Windows.Forms.Button()
        Me.btnTel = New System.Windows.Forms.Button()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnParaLlevar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnVentaNueva = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskTotal = New System.Windows.Forms.MaskedTextBox()
        Me.gpbDetalles.SuspendLayout()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBuscarProducto.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbDetalles
        '
        Me.gpbDetalles.Controls.Add(Me.txtTipoProd)
        Me.gpbDetalles.Controls.Add(Me.dgvVentaDetalles)
        Me.gpbDetalles.Controls.Add(Me.txtCantidad)
        Me.gpbDetalles.Controls.Add(Me.txtPrecio)
        Me.gpbDetalles.Controls.Add(Me.txtNumProducto)
        Me.gpbDetalles.Controls.Add(Me.Label4)
        Me.gpbDetalles.Controls.Add(Me.Label3)
        Me.gpbDetalles.Controls.Add(Me.Label2)
        Me.gpbDetalles.Controls.Add(Me.txtNombreProducto)
        Me.gpbDetalles.Location = New System.Drawing.Point(12, 371)
        Me.gpbDetalles.Name = "gpbDetalles"
        Me.gpbDetalles.Size = New System.Drawing.Size(830, 352)
        Me.gpbDetalles.TabIndex = 29
        Me.gpbDetalles.TabStop = False
        '
        'txtTipoProd
        '
        Me.txtTipoProd.Location = New System.Drawing.Point(719, 93)
        Me.txtTipoProd.Name = "txtTipoProd"
        Me.txtTipoProd.Size = New System.Drawing.Size(92, 22)
        Me.txtTipoProd.TabIndex = 8
        '
        'dgvVentaDetalles
        '
        Me.dgvVentaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentaDetalles.Location = New System.Drawing.Point(7, 136)
        Me.dgvVentaDetalles.Name = "dgvVentaDetalles"
        Me.dgvVentaDetalles.RowTemplate.Height = 24
        Me.dgvVentaDetalles.Size = New System.Drawing.Size(817, 191)
        Me.dgvVentaDetalles.TabIndex = 7
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(517, 93)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 22)
        Me.txtCantidad.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(269, 93)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(143, 22)
        Me.txtPrecio.TabIndex = 5
        '
        'txtNumProducto
        '
        Me.txtNumProducto.Location = New System.Drawing.Point(10, 93)
        Me.txtNumProducto.Name = "txtNumProducto"
        Me.txtNumProducto.Size = New System.Drawing.Size(160, 22)
        Me.txtNumProducto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(514, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Num. Producto:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(7, 22)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(817, 22)
        Me.txtNombreProducto.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(900, 523)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(130, 51)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnDomicilio
        '
        Me.btnDomicilio.Location = New System.Drawing.Point(900, 405)
        Me.btnDomicilio.Name = "btnDomicilio"
        Me.btnDomicilio.Size = New System.Drawing.Size(130, 73)
        Me.btnDomicilio.TabIndex = 27
        Me.btnDomicilio.Text = "Entrega a Domicilio"
        Me.btnDomicilio.UseVisualStyleBackColor = True
        '
        'btnTel
        '
        Me.btnTel.Location = New System.Drawing.Point(900, 296)
        Me.btnTel.Name = "btnTel"
        Me.btnTel.Size = New System.Drawing.Size(130, 71)
        Me.btnTel.TabIndex = 26
        Me.btnTel.Text = "Telefono/Recoger en Local"
        Me.btnTel.UseVisualStyleBackColor = True
        '
        'btnLocal
        '
        Me.btnLocal.Location = New System.Drawing.Point(900, 208)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(130, 52)
        Me.btnLocal.TabIndex = 25
        Me.btnLocal.Text = "Consumo en local"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'btnParaLlevar
        '
        Me.btnParaLlevar.Location = New System.Drawing.Point(900, 110)
        Me.btnParaLlevar.Name = "btnParaLlevar"
        Me.btnParaLlevar.Size = New System.Drawing.Size(130, 51)
        Me.btnParaLlevar.TabIndex = 24
        Me.btnParaLlevar.Text = "Para Llevar"
        Me.btnParaLlevar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(866, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Seleccione tipo de venta"
        '
        'gpbBuscarProducto
        '
        Me.gpbBuscarProducto.Controls.Add(Me.dgvProductos)
        Me.gpbBuscarProducto.Controls.Add(Me.txtProducto)
        Me.gpbBuscarProducto.Location = New System.Drawing.Point(12, 65)
        Me.gpbBuscarProducto.Name = "gpbBuscarProducto"
        Me.gpbBuscarProducto.Size = New System.Drawing.Size(830, 288)
        Me.gpbBuscarProducto.TabIndex = 22
        Me.gpbBuscarProducto.TabStop = False
        Me.gpbBuscarProducto.Text = "Producto"
        '
        'dgvProductos
        '
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(7, 50)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.Size = New System.Drawing.Size(817, 217)
        Me.dgvProductos.TabIndex = 1
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(7, 22)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(817, 22)
        Me.txtProducto.TabIndex = 0
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(180, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(160, 22)
        Me.txtId.TabIndex = 21
        '
        'btnVentaNueva
        '
        Me.btnVentaNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentaNueva.Location = New System.Drawing.Point(22, 7)
        Me.btnVentaNueva.Name = "btnVentaNueva"
        Me.btnVentaNueva.Size = New System.Drawing.Size(112, 42)
        Me.btnVentaNueva.TabIndex = 20
        Me.btnVentaNueva.Text = "Nueva Venta"
        Me.btnVentaNueva.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(625, 729)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 24)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Total: $"
        '
        'mskTotal
        '
        Me.mskTotal.Location = New System.Drawing.Point(736, 729)
        Me.mskTotal.Name = "mskTotal"
        Me.mskTotal.Size = New System.Drawing.Size(100, 22)
        Me.mskTotal.TabIndex = 31
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 791)
        Me.Controls.Add(Me.mskTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gpbDetalles)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDomicilio)
        Me.Controls.Add(Me.btnTel)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.btnParaLlevar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpbBuscarProducto)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnVentaNueva)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.gpbDetalles.ResumeLayout(False)
        Me.gpbDetalles.PerformLayout()
        CType(Me.dgvVentaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBuscarProducto.ResumeLayout(False)
        Me.gpbBuscarProducto.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbDetalles As GroupBox
    Friend WithEvents txtTipoProd As TextBox
    Friend WithEvents dgvVentaDetalles As DataGridView
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNumProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnDomicilio As Button
    Friend WithEvents btnTel As Button
    Friend WithEvents btnLocal As Button
    Friend WithEvents btnParaLlevar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gpbBuscarProducto As GroupBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnVentaNueva As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents mskTotal As MaskedTextBox
End Class
