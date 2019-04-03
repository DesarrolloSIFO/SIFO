<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbxExamen = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboCargoEmpleado = New System.Windows.Forms.ComboBox()
        Me.CboCiudad = New System.Windows.Forms.ComboBox()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaContra = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtNumIdent = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GbxExamen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-2, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(811, 40)
        Me.Panel2.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(366, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Empleado"
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(-2, -3)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(231, 120)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 30
        Me.PbxLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(227, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 123)
        Me.Panel1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(235, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Empleado"
        '
        'GbxExamen
        '
        Me.GbxExamen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbxExamen.Controls.Add(Me.BtnLimpiar)
        Me.GbxExamen.Controls.Add(Me.BtnAgregar)
        Me.GbxExamen.Controls.Add(Me.TxtDireccion)
        Me.GbxExamen.Controls.Add(Me.Label8)
        Me.GbxExamen.Controls.Add(Me.CboCargoEmpleado)
        Me.GbxExamen.Controls.Add(Me.CboCiudad)
        Me.GbxExamen.Controls.Add(Me.CboSexo)
        Me.GbxExamen.Controls.Add(Me.Label12)
        Me.GbxExamen.Controls.Add(Me.Label4)
        Me.GbxExamen.Controls.Add(Me.Label3)
        Me.GbxExamen.Controls.Add(Me.DtpFechaContra)
        Me.GbxExamen.Controls.Add(Me.DtpFechaNac)
        Me.GbxExamen.Controls.Add(Me.TxtTelefono)
        Me.GbxExamen.Controls.Add(Me.TxtApellidos)
        Me.GbxExamen.Controls.Add(Me.Label11)
        Me.GbxExamen.Controls.Add(Me.Label10)
        Me.GbxExamen.Controls.Add(Me.Label9)
        Me.GbxExamen.Controls.Add(Me.Label7)
        Me.GbxExamen.Controls.Add(Me.Label6)
        Me.GbxExamen.Controls.Add(Me.Label5)
        Me.GbxExamen.Controls.Add(Me.TxtNombres)
        Me.GbxExamen.Controls.Add(Me.TxtNumIdent)
        Me.GbxExamen.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxExamen.Location = New System.Drawing.Point(-2, 159)
        Me.GbxExamen.Name = "GbxExamen"
        Me.GbxExamen.Size = New System.Drawing.Size(791, 407)
        Me.GbxExamen.TabIndex = 33
        Me.GbxExamen.TabStop = False
        Me.GbxExamen.Text = "Datos del empleado"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.Location = New System.Drawing.Point(657, 346)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(112, 44)
        Me.BtnLimpiar.TabIndex = 30
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(523, 346)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(112, 44)
        Me.BtnAgregar.TabIndex = 29
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(53, 268)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(393, 58)
        Me.TxtDireccion.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Dirección"
        '
        'CboCargoEmpleado
        '
        Me.CboCargoEmpleado.FormattingEnabled = True
        Me.CboCargoEmpleado.Location = New System.Drawing.Point(528, 271)
        Me.CboCargoEmpleado.Name = "CboCargoEmpleado"
        Me.CboCargoEmpleado.Size = New System.Drawing.Size(200, 25)
        Me.CboCargoEmpleado.TabIndex = 26
        '
        'CboCiudad
        '
        Me.CboCiudad.FormattingEnabled = True
        Me.CboCiudad.Location = New System.Drawing.Point(528, 212)
        Me.CboCiudad.Name = "CboCiudad"
        Me.CboCiudad.Size = New System.Drawing.Size(200, 25)
        Me.CboCiudad.TabIndex = 25
        '
        'CboSexo
        '
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(528, 155)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(200, 25)
        Me.CboSexo.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(528, 246)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Cargo "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(525, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Ciudad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(528, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Sexo"
        '
        'DtpFechaContra
        '
        Me.DtpFechaContra.Location = New System.Drawing.Point(528, 98)
        Me.DtpFechaContra.Name = "DtpFechaContra"
        Me.DtpFechaContra.Size = New System.Drawing.Size(200, 25)
        Me.DtpFechaContra.TabIndex = 20
        '
        'DtpFechaNac
        '
        Me.DtpFechaNac.Location = New System.Drawing.Point(528, 42)
        Me.DtpFechaNac.Name = "DtpFechaNac"
        Me.DtpFechaNac.Size = New System.Drawing.Size(200, 25)
        Me.DtpFechaNac.TabIndex = 19
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(53, 211)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(267, 25)
        Me.TxtTelefono.TabIndex = 18
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(53, 155)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(267, 25)
        Me.TxtApellidos.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(530, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Fecha  de Contratación"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(528, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Fecha de Nacimiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Teléfono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Apellidos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Número de Identidad"
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(53, 97)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(267, 25)
        Me.TxtNombres.TabIndex = 1
        '
        'TxtNumIdent
        '
        Me.TxtNumIdent.Location = New System.Drawing.Point(53, 41)
        Me.TxtNumIdent.Name = "TxtNumIdent"
        Me.TxtNumIdent.Size = New System.Drawing.Size(267, 25)
        Me.TxtNumIdent.TabIndex = 0
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 572)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GbxExamen)
        Me.Name = "FrmEmpleado"
        Me.Text = "DatosEmpleado"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbxExamen.ResumeLayout(False)
        Me.GbxExamen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GbxExamen As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtNumIdent As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CboCargoEmpleado As ComboBox
    Friend WithEvents CboCiudad As ComboBox
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFechaContra As DateTimePicker
    Friend WithEvents DtpFechaNac As DateTimePicker
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAgregar As Button
End Class
