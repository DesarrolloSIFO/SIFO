<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TbDetalleFactura = New System.Windows.Forms.TabPage()
        Me.GbxExamen = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.CboTipoExamen = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.CboIdUsuario = New System.Windows.Forms.ComboBox()
        Me.TxtNumIdentCliente = New System.Windows.Forms.TextBox()
        Me.TxtCodFactura = New System.Windows.Forms.TextBox()
        Me.TbListadoFactura = New System.Windows.Forms.TabPage()
        Me.LsvDetalleFac = New System.Windows.Forms.ListView()
        Me.CHCodDetalle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHNumeroIdentidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoExamen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHCiudad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TbDetalleFactura.SuspendLayout()
        Me.GbxExamen.SuspendLayout()
        Me.TbListadoFactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-3, 143)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1068, 46)
        Me.Panel2.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(515, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Factura"
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(-3, -4)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(308, 150)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 26
        Me.PbxLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(304, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 151)
        Me.Panel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(289, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Detalle Factura"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TbDetalleFactura)
        Me.TabControl1.Controls.Add(Me.TbListadoFactura)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 196)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1075, 409)
        Me.TabControl1.TabIndex = 29
        '
        'TbDetalleFactura
        '
        Me.TbDetalleFactura.Controls.Add(Me.GbxExamen)
        Me.TbDetalleFactura.Location = New System.Drawing.Point(4, 25)
        Me.TbDetalleFactura.Name = "TbDetalleFactura"
        Me.TbDetalleFactura.Padding = New System.Windows.Forms.Padding(3)
        Me.TbDetalleFactura.Size = New System.Drawing.Size(1067, 380)
        Me.TbDetalleFactura.TabIndex = 0
        Me.TbDetalleFactura.Text = "Datos Detalle de Factura"
        Me.TbDetalleFactura.UseVisualStyleBackColor = True
        '
        'GbxExamen
        '
        Me.GbxExamen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbxExamen.Controls.Add(Me.BtnSalir)
        Me.GbxExamen.Controls.Add(Me.BtnCancelar)
        Me.GbxExamen.Controls.Add(Me.BtnGuardar)
        Me.GbxExamen.Controls.Add(Me.BtnModificar)
        Me.GbxExamen.Controls.Add(Me.BtnAgregar)
        Me.GbxExamen.Controls.Add(Me.CboTipoExamen)
        Me.GbxExamen.Controls.Add(Me.Label11)
        Me.GbxExamen.Controls.Add(Me.Label10)
        Me.GbxExamen.Controls.Add(Me.Label8)
        Me.GbxExamen.Controls.Add(Me.Label7)
        Me.GbxExamen.Controls.Add(Me.Lbl)
        Me.GbxExamen.Controls.Add(Me.Label5)
        Me.GbxExamen.Controls.Add(Me.DtpFechaFactura)
        Me.GbxExamen.Controls.Add(Me.CboIdUsuario)
        Me.GbxExamen.Controls.Add(Me.TxtNumIdentCliente)
        Me.GbxExamen.Controls.Add(Me.TxtCodFactura)
        Me.GbxExamen.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxExamen.Location = New System.Drawing.Point(3, 4)
        Me.GbxExamen.Margin = New System.Windows.Forms.Padding(4)
        Me.GbxExamen.Name = "GbxExamen"
        Me.GbxExamen.Padding = New System.Windows.Forms.Padding(4)
        Me.GbxExamen.Size = New System.Drawing.Size(1060, 380)
        Me.GbxExamen.TabIndex = 31
        Me.GbxExamen.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(845, 291)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(149, 54)
        Me.BtnSalir.TabIndex = 42
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(664, 291)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(149, 54)
        Me.BtnCancelar.TabIndex = 43
        Me.BtnCancelar.Text = "Limpiar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.Location = New System.Drawing.Point(249, 291)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(149, 54)
        Me.BtnGuardar.TabIndex = 39
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.Location = New System.Drawing.Point(453, 291)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(149, 54)
        Me.BtnModificar.TabIndex = 40
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnModificar.UseVisualStyleBackColor = False
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
        Me.BtnAgregar.Location = New System.Drawing.Point(44, 291)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(149, 54)
        Me.BtnAgregar.TabIndex = 41
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'CboTipoExamen
        '
        Me.CboTipoExamen.FormattingEnabled = True
        Me.CboTipoExamen.Location = New System.Drawing.Point(73, 209)
        Me.CboTipoExamen.Margin = New System.Windows.Forms.Padding(4)
        Me.CboTipoExamen.Name = "CboTipoExamen"
        Me.CboTipoExamen.Size = New System.Drawing.Size(444, 29)
        Me.CboTipoExamen.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(669, 68)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 25)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Fecha "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(670, 150)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 25)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Id Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 180)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tipo Examen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 105)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Numero de identidad"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(71, 92)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(0, 19)
        Me.Lbl.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo Factura "
        '
        'DtpFechaFactura
        '
        Me.DtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFactura.Location = New System.Drawing.Point(673, 101)
        Me.DtpFechaFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpFechaFactura.Name = "DtpFechaFactura"
        Me.DtpFechaFactura.Size = New System.Drawing.Size(150, 29)
        Me.DtpFechaFactura.TabIndex = 6
        '
        'CboIdUsuario
        '
        Me.CboIdUsuario.FormattingEnabled = True
        Me.CboIdUsuario.Location = New System.Drawing.Point(674, 181)
        Me.CboIdUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.CboIdUsuario.Name = "CboIdUsuario"
        Me.CboIdUsuario.Size = New System.Drawing.Size(332, 29)
        Me.CboIdUsuario.TabIndex = 5
        '
        'TxtNumIdentCliente
        '
        Me.TxtNumIdentCliente.Location = New System.Drawing.Point(71, 135)
        Me.TxtNumIdentCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumIdentCliente.Name = "TxtNumIdentCliente"
        Me.TxtNumIdentCliente.Size = New System.Drawing.Size(447, 29)
        Me.TxtNumIdentCliente.TabIndex = 2
        '
        'TxtCodFactura
        '
        Me.TxtCodFactura.Location = New System.Drawing.Point(71, 52)
        Me.TxtCodFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodFactura.Name = "TxtCodFactura"
        Me.TxtCodFactura.Size = New System.Drawing.Size(447, 29)
        Me.TxtCodFactura.TabIndex = 0
        '
        'TbListadoFactura
        '
        Me.TbListadoFactura.Controls.Add(Me.LsvDetalleFac)
        Me.TbListadoFactura.Location = New System.Drawing.Point(4, 25)
        Me.TbListadoFactura.Name = "TbListadoFactura"
        Me.TbListadoFactura.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListadoFactura.Size = New System.Drawing.Size(1067, 380)
        Me.TbListadoFactura.TabIndex = 1
        Me.TbListadoFactura.Text = "Listado"
        Me.TbListadoFactura.UseVisualStyleBackColor = True
        '
        'LsvDetalleFac
        '
        Me.LsvDetalleFac.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHCodDetalle, Me.CHNumeroIdentidad, Me.ChTipoExamen, Me.CHCiudad, Me.CHUsuario, Me.CHFecha})
        Me.LsvDetalleFac.FullRowSelect = True
        Me.LsvDetalleFac.GridLines = True
        Me.LsvDetalleFac.Location = New System.Drawing.Point(3, 6)
        Me.LsvDetalleFac.Name = "LsvDetalleFac"
        Me.LsvDetalleFac.Size = New System.Drawing.Size(1061, 368)
        Me.LsvDetalleFac.TabIndex = 0
        Me.LsvDetalleFac.UseCompatibleStateImageBehavior = False
        Me.LsvDetalleFac.View = System.Windows.Forms.View.Details
        '
        'CHCodDetalle
        '
        Me.CHCodDetalle.Text = "Código Detalle"
        Me.CHCodDetalle.Width = 100
        '
        'CHNumeroIdentidad
        '
        Me.CHNumeroIdentidad.Text = "Número de Identidad"
        Me.CHNumeroIdentidad.Width = 150
        '
        'ChTipoExamen
        '
        Me.ChTipoExamen.Text = "TipoExamen"
        Me.ChTipoExamen.Width = 150
        '
        'CHCiudad
        '
        Me.CHCiudad.Text = "Ciudad"
        Me.CHCiudad.Width = 100
        '
        'CHUsuario
        '
        Me.CHUsuario.Text = "Usuario"
        Me.CHUsuario.Width = 100
        '
        'CHFecha
        '
        Me.CHFecha.Text = "Fecha"
        Me.CHFecha.Width = 100
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1071, 615)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form"
        Me.Text = "Factura "
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TbDetalleFactura.ResumeLayout(False)
        Me.GbxExamen.ResumeLayout(False)
        Me.GbxExamen.PerformLayout()
        Me.TbListadoFactura.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TbDetalleFactura As TabPage
    Friend WithEvents TbListadoFactura As TabPage
    Friend WithEvents GbxExamen As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents CboTipoExamen As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpFechaFactura As DateTimePicker
    Friend WithEvents CboIdUsuario As ComboBox
    Friend WithEvents TxtNumIdentCliente As TextBox
    Friend WithEvents TxtCodFactura As TextBox
    Friend WithEvents LsvDetalleFac As ListView
    Friend WithEvents CHCodDetalle As ColumnHeader
    Friend WithEvents CHNumeroIdentidad As ColumnHeader
    Friend WithEvents ChTipoExamen As ColumnHeader
    Friend WithEvents CHCiudad As ColumnHeader
    Friend WithEvents CHUsuario As ColumnHeader
    Friend WithEvents CHFecha As ColumnHeader
End Class
