﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoExamen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoExamen))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabExamenCliente = New System.Windows.Forms.TabControl()
        Me.TbExamenCliente = New System.Windows.Forms.TabPage()
        Me.GbxExamen = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtDistanciaPupilar = New System.Windows.Forms.TextBox()
        Me.TxtAdicion = New System.Windows.Forms.TextBox()
        Me.TxtOI = New System.Windows.Forms.TextBox()
        Me.TxtOD = New System.Windows.Forms.TextBox()
        Me.TxtNumIdenCliente = New System.Windows.Forms.TextBox()
        Me.TxtCodExamenCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpFechaExamen = New System.Windows.Forms.DateTimePicker()
        Me.CboUsuario = New System.Windows.Forms.ComboBox()
        Me.CboTipoExamen = New System.Windows.Forms.ComboBox()
        Me.TbListadoExamenCliente = New System.Windows.Forms.TabPage()
        Me.LsvExamenCliente = New System.Windows.Forms.ListView()
        Me.CHCodigoExamenCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHNumIdentCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHFechaExamen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHOjoI = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHOD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHAdicion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHDistanciaPupilar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHTipoExamen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHIdUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EpMensage = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabExamenCliente.SuspendLayout()
        Me.TbExamenCliente.SuspendLayout()
        Me.GbxExamen.SuspendLayout()
        Me.TbListadoExamenCliente.SuspendLayout()
        CType(Me.EpMensage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(7, 138)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1069, 55)
        Me.Panel2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(459, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Examen Cliente"
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(7, 0)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(308, 145)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 16
        Me.PbxLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(315, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 148)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(184, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestión Examen Cliente"
        '
        'TabExamenCliente
        '
        Me.TabExamenCliente.Controls.Add(Me.TbExamenCliente)
        Me.TabExamenCliente.Controls.Add(Me.TbListadoExamenCliente)
        Me.TabExamenCliente.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabExamenCliente.Location = New System.Drawing.Point(7, 199)
        Me.TabExamenCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabExamenCliente.Name = "TabExamenCliente"
        Me.TabExamenCliente.SelectedIndex = 0
        Me.TabExamenCliente.Size = New System.Drawing.Size(1055, 478)
        Me.TabExamenCliente.TabIndex = 19
        '
        'TbExamenCliente
        '
        Me.TbExamenCliente.Controls.Add(Me.GbxExamen)
        Me.TbExamenCliente.Location = New System.Drawing.Point(4, 34)
        Me.TbExamenCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbExamenCliente.Name = "TbExamenCliente"
        Me.TbExamenCliente.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbExamenCliente.Size = New System.Drawing.Size(1047, 440)
        Me.TbExamenCliente.TabIndex = 0
        Me.TbExamenCliente.Text = "Examen Cliente"
        Me.TbExamenCliente.UseVisualStyleBackColor = True
        '
        'GbxExamen
        '
        Me.GbxExamen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbxExamen.Controls.Add(Me.BtnBuscar)
        Me.GbxExamen.Controls.Add(Me.BtnSalir)
        Me.GbxExamen.Controls.Add(Me.BtnLimpiar)
        Me.GbxExamen.Controls.Add(Me.BtnGuardar)
        Me.GbxExamen.Controls.Add(Me.BtnModificar)
        Me.GbxExamen.Controls.Add(Me.BtnAgregar)
        Me.GbxExamen.Controls.Add(Me.TxtDistanciaPupilar)
        Me.GbxExamen.Controls.Add(Me.TxtAdicion)
        Me.GbxExamen.Controls.Add(Me.TxtOI)
        Me.GbxExamen.Controls.Add(Me.TxtOD)
        Me.GbxExamen.Controls.Add(Me.TxtNumIdenCliente)
        Me.GbxExamen.Controls.Add(Me.TxtCodExamenCliente)
        Me.GbxExamen.Controls.Add(Me.Label4)
        Me.GbxExamen.Controls.Add(Me.Label3)
        Me.GbxExamen.Controls.Add(Me.Label11)
        Me.GbxExamen.Controls.Add(Me.Label10)
        Me.GbxExamen.Controls.Add(Me.Label9)
        Me.GbxExamen.Controls.Add(Me.Label8)
        Me.GbxExamen.Controls.Add(Me.Label7)
        Me.GbxExamen.Controls.Add(Me.Label6)
        Me.GbxExamen.Controls.Add(Me.Label5)
        Me.GbxExamen.Controls.Add(Me.DtpFechaExamen)
        Me.GbxExamen.Controls.Add(Me.CboUsuario)
        Me.GbxExamen.Controls.Add(Me.CboTipoExamen)
        Me.GbxExamen.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxExamen.Location = New System.Drawing.Point(0, 4)
        Me.GbxExamen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GbxExamen.Name = "GbxExamen"
        Me.GbxExamen.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GbxExamen.Size = New System.Drawing.Size(1044, 455)
        Me.GbxExamen.TabIndex = 26
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
        Me.BtnSalir.Location = New System.Drawing.Point(855, 368)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(149, 54)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.Location = New System.Drawing.Point(661, 368)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(149, 54)
        Me.BtnLimpiar.TabIndex = 30
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnLimpiar.UseVisualStyleBackColor = False
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
        Me.BtnGuardar.Location = New System.Drawing.Point(252, 368)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(149, 54)
        Me.BtnGuardar.TabIndex = 26
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
        Me.BtnModificar.Location = New System.Drawing.Point(456, 368)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(149, 54)
        Me.BtnModificar.TabIndex = 27
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
        Me.BtnAgregar.Location = New System.Drawing.Point(47, 368)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(149, 54)
        Me.BtnAgregar.TabIndex = 28
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'TxtDistanciaPupilar
        '
        Me.TxtDistanciaPupilar.Location = New System.Drawing.Point(303, 292)
        Me.TxtDistanciaPupilar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDistanciaPupilar.Name = "TxtDistanciaPupilar"
        Me.TxtDistanciaPupilar.Size = New System.Drawing.Size(256, 29)
        Me.TxtDistanciaPupilar.TabIndex = 25
        '
        'TxtAdicion
        '
        Me.TxtAdicion.Location = New System.Drawing.Point(303, 240)
        Me.TxtAdicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAdicion.Name = "TxtAdicion"
        Me.TxtAdicion.Size = New System.Drawing.Size(256, 29)
        Me.TxtAdicion.TabIndex = 24
        '
        'TxtOI
        '
        Me.TxtOI.Location = New System.Drawing.Point(303, 124)
        Me.TxtOI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtOI.Name = "TxtOI"
        Me.TxtOI.Size = New System.Drawing.Size(256, 29)
        Me.TxtOI.TabIndex = 23
        '
        'TxtOD
        '
        Me.TxtOD.Location = New System.Drawing.Point(303, 179)
        Me.TxtOD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtOD.Name = "TxtOD"
        Me.TxtOD.Size = New System.Drawing.Size(256, 29)
        Me.TxtOD.TabIndex = 22
        '
        'TxtNumIdenCliente
        '
        Me.TxtNumIdenCliente.Location = New System.Drawing.Point(304, 69)
        Me.TxtNumIdenCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNumIdenCliente.Name = "TxtNumIdenCliente"
        Me.TxtNumIdenCliente.Size = New System.Drawing.Size(255, 29)
        Me.TxtNumIdenCliente.TabIndex = 21
        '
        'TxtCodExamenCliente
        '
        Me.TxtCodExamenCliente.Location = New System.Drawing.Point(303, 14)
        Me.TxtCodExamenCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCodExamenCliente.Name = "TxtCodExamenCliente"
        Me.TxtCodExamenCliente.Size = New System.Drawing.Size(256, 29)
        Me.TxtCodExamenCliente.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 292)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Distancia Pupilar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "OD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(700, 218)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 24)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Fecha De Examen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(700, 125)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 24)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Usuario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(696, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 24)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tipo Examen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 128)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "OI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(273, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Numero de identidad Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(212, 246)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Adicion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo Examen Cliente"
        '
        'DtpFechaExamen
        '
        Me.DtpFechaExamen.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaExamen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaExamen.Location = New System.Drawing.Point(704, 252)
        Me.DtpFechaExamen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DtpFechaExamen.Name = "DtpFechaExamen"
        Me.DtpFechaExamen.Size = New System.Drawing.Size(173, 29)
        Me.DtpFechaExamen.TabIndex = 6
        '
        'CboUsuario
        '
        Me.CboUsuario.FormattingEnabled = True
        Me.CboUsuario.Location = New System.Drawing.Point(704, 154)
        Me.CboUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.Size = New System.Drawing.Size(332, 29)
        Me.CboUsuario.TabIndex = 5
        '
        'CboTipoExamen
        '
        Me.CboTipoExamen.FormattingEnabled = True
        Me.CboTipoExamen.Location = New System.Drawing.Point(700, 54)
        Me.CboTipoExamen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboTipoExamen.Name = "CboTipoExamen"
        Me.CboTipoExamen.Size = New System.Drawing.Size(332, 29)
        Me.CboTipoExamen.TabIndex = 4
        '
        'TbListadoExamenCliente
        '
        Me.TbListadoExamenCliente.Controls.Add(Me.LsvExamenCliente)
        Me.TbListadoExamenCliente.Location = New System.Drawing.Point(4, 34)
        Me.TbListadoExamenCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbListadoExamenCliente.Name = "TbListadoExamenCliente"
        Me.TbListadoExamenCliente.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbListadoExamenCliente.Size = New System.Drawing.Size(1047, 440)
        Me.TbListadoExamenCliente.TabIndex = 1
        Me.TbListadoExamenCliente.Text = "Listado"
        Me.TbListadoExamenCliente.UseVisualStyleBackColor = True
        '
        'LsvExamenCliente
        '
        Me.LsvExamenCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHCodigoExamenCliente, Me.CHNumIdentCliente, Me.CHFechaExamen, Me.CHOjoI, Me.CHOD, Me.CHAdicion, Me.CHDistanciaPupilar, Me.CHTipoExamen, Me.CHIdUsuario})
        Me.LsvExamenCliente.ContextMenuStrip = Me.CmsOpciones
        Me.LsvExamenCliente.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvExamenCliente.GridLines = True
        Me.LsvExamenCliente.Location = New System.Drawing.Point(5, 6)
        Me.LsvExamenCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LsvExamenCliente.Name = "LsvExamenCliente"
        Me.LsvExamenCliente.Size = New System.Drawing.Size(1035, 434)
        Me.LsvExamenCliente.TabIndex = 0
        Me.LsvExamenCliente.UseCompatibleStateImageBehavior = False
        Me.LsvExamenCliente.View = System.Windows.Forms.View.Details
        '
        'CHCodigoExamenCliente
        '
        Me.CHCodigoExamenCliente.Text = "Codigo"
        '
        'CHNumIdentCliente
        '
        Me.CHNumIdentCliente.Text = "Numero de Identidad "
        Me.CHNumIdentCliente.Width = 150
        '
        'CHFechaExamen
        '
        Me.CHFechaExamen.Text = "Fecha Examen"
        Me.CHFechaExamen.Width = 150
        '
        'CHOjoI
        '
        Me.CHOjoI.Text = "Ojo Izquierdo"
        Me.CHOjoI.Width = 100
        '
        'CHOD
        '
        Me.CHOD.Text = "Ojo Derecho"
        Me.CHOD.Width = 100
        '
        'CHAdicion
        '
        Me.CHAdicion.Text = "Adicion"
        Me.CHAdicion.Width = 100
        '
        'CHDistanciaPupilar
        '
        Me.CHDistanciaPupilar.Text = "Distancia Pupilar"
        Me.CHDistanciaPupilar.Width = 150
        '
        'CHTipoExamen
        '
        Me.CHTipoExamen.Text = "Tipo Examen"
        Me.CHTipoExamen.Width = 100
        '
        'CHIdUsuario
        '
        Me.CHIdUsuario.Text = "Usuario"
        Me.CHIdUsuario.Width = 100
        '
        'EpMensage
        '
        Me.EpMensage.ContainerControl = Me
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(133, 52)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(583, 69)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(60, 29)
        Me.BtnBuscar.TabIndex = 31
        Me.BtnBuscar.Text = "..."
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmTipoExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1067, 690)
        Me.Controls.Add(Me.TabExamenCliente)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmTipoExamen"
        Me.Text = "Examen Cliente "
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabExamenCliente.ResumeLayout(False)
        Me.TbExamenCliente.ResumeLayout(False)
        Me.GbxExamen.ResumeLayout(False)
        Me.GbxExamen.PerformLayout()
        Me.TbListadoExamenCliente.ResumeLayout(False)
        CType(Me.EpMensage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabExamenCliente As TabControl
    Friend WithEvents TbExamenCliente As TabPage
    Friend WithEvents GbxExamen As GroupBox
    Friend WithEvents TxtDistanciaPupilar As TextBox
    Friend WithEvents TxtAdicion As TextBox
    Friend WithEvents TxtOI As TextBox
    Friend WithEvents TxtOD As TextBox
    Friend WithEvents TxtNumIdenCliente As TextBox
    Friend WithEvents TxtCodExamenCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpFechaExamen As DateTimePicker
    Friend WithEvents CboUsuario As ComboBox
    Friend WithEvents CboTipoExamen As ComboBox
    Friend WithEvents TbListadoExamenCliente As TabPage
    Friend WithEvents LsvExamenCliente As ListView
    Friend WithEvents CHCodigoExamenCliente As ColumnHeader
    Friend WithEvents CHNumIdentCliente As ColumnHeader
    Friend WithEvents CHFechaExamen As ColumnHeader
    Friend WithEvents CHOjoI As ColumnHeader
    Friend WithEvents CHOD As ColumnHeader
    Friend WithEvents CHAdicion As ColumnHeader
    Friend WithEvents CHDistanciaPupilar As ColumnHeader
    Friend WithEvents CHTipoExamen As ColumnHeader
    Friend WithEvents CHIdUsuario As ColumnHeader
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents EpMensage As ErrorProvider
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnBuscar As Button
End Class
