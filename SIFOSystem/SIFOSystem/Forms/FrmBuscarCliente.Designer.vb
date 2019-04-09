<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarCliente))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.RdbPorIdentidad = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RdbPorNombre = New System.Windows.Forms.RadioButton()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.TxtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EpMensajeCargo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LsvCliente = New System.Windows.Forms.ListView()
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdentidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaDeNacimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCiudad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.EpMensajeCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnLimpiar)
        Me.Panel2.Controls.Add(Me.RdbPorIdentidad)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.RdbPorNombre)
        Me.Panel2.Controls.Add(Me.BtnModificar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtBuscarCodigo)
        Me.Panel2.Controls.Add(Me.TxtBuscarNombre)
        Me.Panel2.Location = New System.Drawing.Point(-2, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 39)
        Me.Panel2.TabIndex = 36
        '
        'TxtBuscarCodigo
        '
        Me.TxtBuscarCodigo.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarCodigo.Location = New System.Drawing.Point(163, 6)
        Me.TxtBuscarCodigo.Name = "TxtBuscarCodigo"
        Me.TxtBuscarCodigo.Size = New System.Drawing.Size(233, 25)
        Me.TxtBuscarCodigo.TabIndex = 59
        Me.TxtBuscarCodigo.Visible = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.Location = New System.Drawing.Point(388, 5)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(93, 27)
        Me.BtnLimpiar.TabIndex = 58
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        Me.BtnLimpiar.Visible = False
        '
        'RdbPorIdentidad
        '
        Me.RdbPorIdentidad.AutoSize = True
        Me.RdbPorIdentidad.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbPorIdentidad.Location = New System.Drawing.Point(527, 18)
        Me.RdbPorIdentidad.Name = "RdbPorIdentidad"
        Me.RdbPorIdentidad.Size = New System.Drawing.Size(103, 20)
        Me.RdbPorIdentidad.TabIndex = 39
        Me.RdbPorIdentidad.TabStop = True
        Me.RdbPorIdentidad.Text = "Por identidad"
        Me.RdbPorIdentidad.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Buscar"
        '
        'RdbPorNombre
        '
        Me.RdbPorNombre.AutoSize = True
        Me.RdbPorNombre.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbPorNombre.Location = New System.Drawing.Point(528, 1)
        Me.RdbPorNombre.Name = "RdbPorNombre"
        Me.RdbPorNombre.Size = New System.Drawing.Size(93, 20)
        Me.RdbPorNombre.TabIndex = 38
        Me.RdbPorNombre.TabStop = True
        Me.RdbPorNombre.Text = "Por nombre"
        Me.RdbPorNombre.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnModificar.Location = New System.Drawing.Point(639, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(114, 29)
        Me.BtnModificar.TabIndex = 56
        Me.BtnModificar.Text = "Seleccionar"
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'TxtBuscarNombre
        '
        Me.TxtBuscarNombre.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscarNombre.Location = New System.Drawing.Point(163, 6)
        Me.TxtBuscarNombre.Name = "TxtBuscarNombre"
        Me.TxtBuscarNombre.Size = New System.Drawing.Size(233, 25)
        Me.TxtBuscarNombre.TabIndex = 1
        Me.TxtBuscarNombre.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(335, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 0
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(46, -4)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(231, 119)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 34
        Me.PbxLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(229, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 119)
        Me.Panel1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(206, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar Cliente"
        '
        'EpMensajeCargo
        '
        Me.EpMensajeCargo.ContainerControl = Me
        '
        'LsvCliente
        '
        Me.LsvCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNombre, Me.ChApellidos, Me.ChIdentidad, Me.ChTelefono, Me.ChDireccion, Me.ChFechaDeNacimiento, Me.ChSexo, Me.ChCiudad})
        Me.LsvCliente.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvCliente.FullRowSelect = True
        Me.LsvCliente.GridLines = True
        Me.LsvCliente.Location = New System.Drawing.Point(0, 152)
        Me.LsvCliente.Name = "LsvCliente"
        Me.LsvCliente.Size = New System.Drawing.Size(801, 332)
        Me.LsvCliente.TabIndex = 37
        Me.LsvCliente.UseCompatibleStateImageBehavior = False
        Me.LsvCliente.View = System.Windows.Forms.View.Details
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre"
        Me.ChNombre.Width = 161
        '
        'ChApellidos
        '
        Me.ChApellidos.Text = "Apellidos"
        Me.ChApellidos.Width = 150
        '
        'ChIdentidad
        '
        Me.ChIdentidad.Text = "Numero de Identidad"
        Me.ChIdentidad.Width = 170
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Teléfono"
        Me.ChTelefono.Width = 170
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Dirección"
        Me.ChDireccion.Width = 151
        '
        'ChFechaDeNacimiento
        '
        Me.ChFechaDeNacimiento.Text = "Fecha de Nacimiento"
        Me.ChFechaDeNacimiento.Width = 142
        '
        'ChSexo
        '
        Me.ChSexo.Text = "Sexo"
        Me.ChSexo.Width = 125
        '
        'ChCiudad
        '
        Me.ChCiudad.Text = "Ciudad"
        Me.ChCiudad.Width = 149
        '
        'FrmBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.LsvCliente)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EpMensajeCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents EpMensajeCargo As ErrorProvider
    Friend WithEvents TxtBuscarNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnModificar As Button
    Friend WithEvents LsvCliente As ListView
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChIdentidad As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChFechaDeNacimiento As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents ChCiudad As ColumnHeader
    Friend WithEvents RdbPorIdentidad As RadioButton
    Friend WithEvents RdbPorNombre As RadioButton
    Friend WithEvents TxtBuscarCodigo As TextBox
    Friend WithEvents BtnLimpiar As Button
End Class
