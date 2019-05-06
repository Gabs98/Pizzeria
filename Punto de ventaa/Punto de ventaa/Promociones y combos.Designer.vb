<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Promociones_y_combos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Promociones_y_combos))
        Me.LstProductos = New System.Windows.Forms.ListBox()
        Me.dgvCombos = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtPrecioFinal = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPasar = New System.Windows.Forms.Button()
        Me.txtPrecioReg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvCombos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstProductos
        '
        Me.LstProductos.FormattingEnabled = True
        Me.LstProductos.ItemHeight = 16
        Me.LstProductos.Items.AddRange(New Object() {"Productos"})
        Me.LstProductos.Location = New System.Drawing.Point(646, 59)
        Me.LstProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.LstProductos.Name = "LstProductos"
        Me.LstProductos.Size = New System.Drawing.Size(349, 276)
        Me.LstProductos.TabIndex = 40
        '
        'dgvCombos
        '
        Me.dgvCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCombos.Location = New System.Drawing.Point(102, 433)
        Me.dgvCombos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCombos.Name = "dgvCombos"
        Me.dgvCombos.Size = New System.Drawing.Size(895, 153)
        Me.dgvCombos.TabIndex = 39
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(646, 382)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(131, 28)
        Me.btnSalir.TabIndex = 38
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(401, 382)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(139, 28)
        Me.btnBorrar.TabIndex = 37
        Me.btnBorrar.Text = "Borrar Seleccion"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(102, 382)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(152, 28)
        Me.btnAgregar.TabIndex = 36
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(401, 324)
        Me.dtpFin.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(137, 22)
        Me.dtpFin.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 331)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Fin:"
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(172, 324)
        Me.dtpInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(132, 22)
        Me.dtpInicio.TabIndex = 33
        '
        'txtPrecioFinal
        '
        Me.txtPrecioFinal.Location = New System.Drawing.Point(282, 282)
        Me.txtPrecioFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioFinal.Name = "txtPrecioFinal"
        Me.txtPrecioFinal.Size = New System.Drawing.Size(132, 22)
        Me.txtPrecioFinal.TabIndex = 32
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(282, 244)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(160, 24)
        Me.cmbTipo.TabIndex = 31
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(282, 198)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(333, 22)
        Me.txtNombre.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 325)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(98, 286)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Precio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 244)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nombre Oferta/Combo:"
        '
        'btnPasar
        '
        Me.btnPasar.Image = CType(resources.GetObject("btnPasar.Image"), System.Drawing.Image)
        Me.btnPasar.Location = New System.Drawing.Point(517, 110)
        Me.btnPasar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPasar.Name = "btnPasar"
        Me.btnPasar.Size = New System.Drawing.Size(100, 28)
        Me.btnPasar.TabIndex = 25
        Me.btnPasar.UseVisualStyleBackColor = True
        '
        'txtPrecioReg
        '
        Me.txtPrecioReg.Location = New System.Drawing.Point(102, 144)
        Me.txtPrecioReg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioReg.Name = "txtPrecioReg"
        Me.txtPrecioReg.Size = New System.Drawing.Size(132, 22)
        Me.txtPrecioReg.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Precio Regular:"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(102, 59)
        Me.cmbProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(513, 24)
        Me.cmbProducto.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Producto:"
        '
        'Promociones_y_combos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 613)
        Me.Controls.Add(Me.LstProductos)
        Me.Controls.Add(Me.dgvCombos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.txtPrecioFinal)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPasar)
        Me.Controls.Add(Me.txtPrecioReg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Promociones_y_combos"
        Me.Text = "Promociones_y_combos"
        CType(Me.dgvCombos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstProductos As ListBox
    Friend WithEvents dgvCombos As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents txtPrecioFinal As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPasar As Button
    Friend WithEvents txtPrecioReg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents Label1 As Label
End Class
