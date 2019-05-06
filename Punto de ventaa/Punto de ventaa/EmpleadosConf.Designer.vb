<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadosConf
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
        Me.btnGafete = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnElminar = New System.Windows.Forms.Button()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtF_Ingreso = New System.Windows.Forms.DateTimePicker()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.txtF_Nac = New System.Windows.Forms.DateTimePicker()
        Me.txtE_mail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtA_Materno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtA_Paterno = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.btnFoto = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGafete
        '
        Me.btnGafete.Location = New System.Drawing.Point(515, 409)
        Me.btnGafete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGafete.Name = "btnGafete"
        Me.btnGafete.Size = New System.Drawing.Size(100, 28)
        Me.btnGafete.TabIndex = 59
        Me.btnGafete.Text = "Gafete"
        Me.btnGafete.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(357, 14)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 28)
        Me.btnBuscar.TabIndex = 58
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(357, 412)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 28)
        Me.btnModificar.TabIndex = 57
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnElminar
        '
        Me.btnElminar.Location = New System.Drawing.Point(209, 412)
        Me.btnElminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnElminar.Name = "btnElminar"
        Me.btnElminar.Size = New System.Drawing.Size(100, 28)
        Me.btnElminar.TabIndex = 56
        Me.btnElminar.Text = "Eliminar"
        Me.btnElminar.UseVisualStyleBackColor = True
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(209, 339)
        Me.txtCat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(132, 22)
        Me.txtCat.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 348)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Id Categoria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 313)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Fecha de Ingreso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 276)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 17)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "RFC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 247)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 17)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Fecha Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 213)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 173)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Direccion"
        '
        'txtF_Ingreso
        '
        Me.txtF_Ingreso.Location = New System.Drawing.Point(209, 306)
        Me.txtF_Ingreso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtF_Ingreso.Name = "txtF_Ingreso"
        Me.txtF_Ingreso.Size = New System.Drawing.Size(265, 22)
        Me.txtF_Ingreso.TabIndex = 47
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(209, 272)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(132, 22)
        Me.txtRFC.TabIndex = 46
        '
        'txtF_Nac
        '
        Me.txtF_Nac.Location = New System.Drawing.Point(209, 239)
        Me.txtF_Nac.Margin = New System.Windows.Forms.Padding(4)
        Me.txtF_Nac.Name = "txtF_Nac"
        Me.txtF_Nac.Size = New System.Drawing.Size(265, 22)
        Me.txtF_Nac.TabIndex = 45
        '
        'txtE_mail
        '
        Me.txtE_mail.Location = New System.Drawing.Point(209, 206)
        Me.txtE_mail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtE_mail.Name = "txtE_mail"
        Me.txtE_mail.Size = New System.Drawing.Size(132, 22)
        Me.txtE_mail.TabIndex = 44
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(209, 173)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(132, 22)
        Me.txtTel.TabIndex = 43
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(209, 140)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(132, 22)
        Me.txtDireccion.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Apellido Materno"
        '
        'txtA_Materno
        '
        Me.txtA_Materno.Location = New System.Drawing.Point(209, 110)
        Me.txtA_Materno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtA_Materno.Name = "txtA_Materno"
        Me.txtA_Materno.Size = New System.Drawing.Size(132, 22)
        Me.txtA_Materno.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Apellido Paterno"
        '
        'txtA_Paterno
        '
        Me.txtA_Paterno.Location = New System.Drawing.Point(209, 77)
        Me.txtA_Paterno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtA_Paterno.Name = "txtA_Paterno"
        Me.txtA_Paterno.Size = New System.Drawing.Size(132, 22)
        Me.txtA_Paterno.TabIndex = 38
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(209, 44)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(132, 22)
        Me.txtNom.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nombre"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(209, 10)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(132, 22)
        Me.txtID.TabIndex = 35
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(75, 14)
        Me.lbl_Id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(72, 17)
        Me.lbl_Id.TabIndex = 34
        Me.lbl_Id.Text = "Id Usuario"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(74, 412)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 33
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(567, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(567, 239)
        Me.cmbCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(160, 24)
        Me.cmbCategoria.TabIndex = 31
        '
        'btnFoto
        '
        Me.btnFoto.Location = New System.Drawing.Point(583, 133)
        Me.btnFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(100, 28)
        Me.btnFoto.TabIndex = 30
        Me.btnFoto.Text = "Foto"
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'EmpleadosConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGafete)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnElminar)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtF_Ingreso)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.txtF_Nac)
        Me.Controls.Add(Me.txtE_mail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtA_Materno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtA_Paterno)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.btnFoto)
        Me.Name = "EmpleadosConf"
        Me.Text = "Empleados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGafete As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnElminar As Button
    Friend WithEvents txtCat As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtF_Ingreso As DateTimePicker
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents txtF_Nac As DateTimePicker
    Friend WithEvents txtE_mail As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtA_Materno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtA_Paterno As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lbl_Id As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents btnFoto As Button
End Class
