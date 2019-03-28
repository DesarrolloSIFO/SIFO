<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestión
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestión))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "Anthony Fabiel", "1709-2000-00097", "San Lorenzo"}, -1)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PbxPacientes = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlAgregar = New System.Windows.Forms.Panel()
        Me.PnlMostrar = New System.Windows.Forms.Panel()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LsvClientes = New System.Windows.Forms.ListView()
        Me.ChIdCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombres = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdentidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCiudad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnMostrarMenos = New System.Windows.Forms.Button()
        Me.GbxClientes = New System.Windows.Forms.GroupBox()
        Me.PnlClientes = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PbxPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        Me.GbxClientes.SuspendLayout()
        Me.PnlClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(62, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gestión de clientes"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PbxPacientes)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-1, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 41)
        Me.Panel2.TabIndex = 5
        '
        'PbxPacientes
        '
        Me.PbxPacientes.Image = Global.SIFOSystem.My.Resources.Resources.image
        Me.PbxPacientes.Location = New System.Drawing.Point(1, 0)
        Me.PbxPacientes.Name = "PbxPacientes"
        Me.PbxPacientes.Size = New System.Drawing.Size(40, 40)
        Me.PbxPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxPacientes.TabIndex = 1
        Me.PbxPacientes.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Agregar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(503, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mostrar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button1.BackgroundImage = Global.SIFOSystem.My.Resources.Resources.if_show_sidebar_3671860
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(442, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 56)
        Me.Button1.TabIndex = 8
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.BtnMostrar.BackgroundImage = Global.SIFOSystem.My.Resources.Resources.if_plus_24_103172
        Me.BtnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMostrar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnMostrar.Enabled = False
        Me.BtnMostrar.FlatAppearance.BorderSize = 0
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrar.Location = New System.Drawing.Point(253, 177)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(55, 56)
        Me.BtnMostrar.TabIndex = 6
        Me.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(-1, -2)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(232, 121)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 1
        Me.PbxLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BtnClientes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(229, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 124)
        Me.Panel1.TabIndex = 4
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.BackgroundImage = Global.SIFOSystem.My.Resources.Resources.image
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.ForeColor = System.Drawing.Color.Transparent
        Me.BtnClientes.Location = New System.Drawing.Point(26, 50)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(45, 45)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(23, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clientes"
        '
        'PnlAgregar
        '
        Me.PnlAgregar.BackColor = System.Drawing.Color.Transparent
        Me.PnlAgregar.BackgroundImage = Global.SIFOSystem.My.Resources.Resources.image__1_
        Me.PnlAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlAgregar.Location = New System.Drawing.Point(248, 172)
        Me.PnlAgregar.Name = "PnlAgregar"
        Me.PnlAgregar.Size = New System.Drawing.Size(125, 68)
        Me.PnlAgregar.TabIndex = 10
        '
        'PnlMostrar
        '
        Me.PnlMostrar.BackColor = System.Drawing.Color.Transparent
        Me.PnlMostrar.BackgroundImage = Global.SIFOSystem.My.Resources.Resources.image__1_
        Me.PnlMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlMostrar.Location = New System.Drawing.Point(438, 172)
        Me.PnlMostrar.Name = "PnlMostrar"
        Me.PnlMostrar.Size = New System.Drawing.Size(125, 68)
        Me.PnlMostrar.TabIndex = 11
        '
        'GbxDatos
        '
        Me.GbxDatos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbxDatos.Controls.Add(Me.Button3)
        Me.GbxDatos.Controls.Add(Me.Button2)
        Me.GbxDatos.Controls.Add(Me.Label11)
        Me.GbxDatos.Controls.Add(Me.Label10)
        Me.GbxDatos.Controls.Add(Me.Label9)
        Me.GbxDatos.Controls.Add(Me.Label8)
        Me.GbxDatos.Controls.Add(Me.Label7)
        Me.GbxDatos.Controls.Add(Me.Label6)
        Me.GbxDatos.Controls.Add(Me.Label5)
        Me.GbxDatos.Controls.Add(Me.DateTimePicker1)
        Me.GbxDatos.Controls.Add(Me.ComboBox2)
        Me.GbxDatos.Controls.Add(Me.ComboBox1)
        Me.GbxDatos.Controls.Add(Me.TextBox4)
        Me.GbxDatos.Controls.Add(Me.TextBox3)
        Me.GbxDatos.Controls.Add(Me.TextBox2)
        Me.GbxDatos.Controls.Add(Me.TextBox1)
        Me.GbxDatos.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxDatos.Location = New System.Drawing.Point(12, 259)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(757, 266)
        Me.GbxDatos.TabIndex = 12
        Me.GbxDatos.TabStop = False
        Me.GbxDatos.Text = "Datos del cliente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(491, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Fecha de nacimiento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(491, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Sexo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(491, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Ciudad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Número de teléfono (opcional)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Numero de identidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Apellidos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombres"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(494, 158)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 25)
        Me.DateTimePicker1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(494, 94)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(250, 25)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(494, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 25)
        Me.ComboBox1.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(53, 220)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(336, 25)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(53, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(336, 25)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(53, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(336, 25)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(53, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(336, 25)
        Me.TextBox1.TabIndex = 0
        '
        'LsvClientes
        '
        Me.LsvClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdCliente, Me.ChNombres, Me.ChIdentidad, Me.ChCiudad})
        Me.LsvClientes.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvClientes.GridLines = True
        Me.LsvClientes.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5})
        Me.LsvClientes.Location = New System.Drawing.Point(64, 35)
        Me.LsvClientes.Name = "LsvClientes"
        Me.LsvClientes.Size = New System.Drawing.Size(622, 208)
        Me.LsvClientes.TabIndex = 14
        Me.LsvClientes.UseCompatibleStateImageBehavior = False
        Me.LsvClientes.View = System.Windows.Forms.View.Details
        '
        'ChIdCliente
        '
        Me.ChIdCliente.Text = "Codigo Cliente"
        Me.ChIdCliente.Width = 126
        '
        'ChNombres
        '
        Me.ChNombres.Text = "Nombres"
        Me.ChNombres.Width = 155
        '
        'ChIdentidad
        '
        Me.ChIdentidad.Text = "Identidad"
        Me.ChIdentidad.Width = 162
        '
        'ChCiudad
        '
        Me.ChCiudad.Text = "Ciudad"
        Me.ChCiudad.Width = 166
        '
        'BtnMostrarMenos
        '
        Me.BtnMostrarMenos.BackColor = System.Drawing.Color.Transparent
        Me.BtnMostrarMenos.BackgroundImage = Global.SIFOSystem.My.Resources.Resources.iconfinder_close_309090
        Me.BtnMostrarMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMostrarMenos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMostrarMenos.FlatAppearance.BorderSize = 0
        Me.BtnMostrarMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrarMenos.Location = New System.Drawing.Point(755, 256)
        Me.BtnMostrarMenos.Name = "BtnMostrarMenos"
        Me.BtnMostrarMenos.Size = New System.Drawing.Size(25, 25)
        Me.BtnMostrarMenos.TabIndex = 13
        Me.BtnMostrarMenos.UseVisualStyleBackColor = False
        '
        'GbxClientes
        '
        Me.GbxClientes.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbxClientes.Controls.Add(Me.LsvClientes)
        Me.GbxClientes.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxClientes.Location = New System.Drawing.Point(29, 15)
        Me.GbxClientes.Name = "GbxClientes"
        Me.GbxClientes.Size = New System.Drawing.Size(756, 264)
        Me.GbxClientes.TabIndex = 14
        Me.GbxClientes.TabStop = False
        Me.GbxClientes.Text = "Clientes"
        '
        'PnlClientes
        '
        Me.PnlClientes.Controls.Add(Me.GbxClientes)
        Me.PnlClientes.Location = New System.Drawing.Point(-14, 246)
        Me.PnlClientes.Name = "PnlClientes"
        Me.PnlClientes.Size = New System.Drawing.Size(799, 341)
        Me.PnlClientes.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(506, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Agregar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(634, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 35)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Limpiar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FrmGestión
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(797, 291)
        Me.Controls.Add(Me.BtnMostrarMenos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlAgregar)
        Me.Controls.Add(Me.PnlMostrar)
        Me.Controls.Add(Me.GbxDatos)
        Me.Controls.Add(Me.PnlClientes)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.MaximizeBox = False
        Me.Name = "FrmGestión"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión de clientes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        Me.GbxClientes.ResumeLayout(False)
        Me.PnlClientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClientes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PbxPacientes As PictureBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PnlAgregar As Panel
    Friend WithEvents PnlMostrar As Panel
    Friend WithEvents GbxDatos As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LsvClientes As ListView
    Friend WithEvents ChIdCliente As ColumnHeader
    Friend WithEvents ChNombres As ColumnHeader
    Friend WithEvents ChIdentidad As ColumnHeader
    Friend WithEvents ChCiudad As ColumnHeader
    Friend WithEvents BtnMostrarMenos As Button
    Friend WithEvents GbxClientes As GroupBox
    Friend WithEvents PnlClientes As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
