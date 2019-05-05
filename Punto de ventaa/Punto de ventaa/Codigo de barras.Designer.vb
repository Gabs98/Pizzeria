<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Codigo_de_barras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Codigo_de_barras))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(111, 188)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(257, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'btnManual
        '
        Me.btnManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.Location = New System.Drawing.Point(150, 259)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(183, 44)
        Me.btnManual.TabIndex = 1
        Me.btnManual.Text = "Acceso Manual"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'Codigo_de_barras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(479, 543)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.txtCodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Codigo_de_barras"
        Me.Text = "Acceso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnManual As Button
End Class
