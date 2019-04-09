<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCiudad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCiudad))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TpDatos = New System.Windows.Forms.TabPage()
        Me.EpMensaje = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtNombreCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCodCiudad = New System.Windows.Forms.TextBox()
        Me.TbMenu = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.LsvCiudades = New System.Windows.Forms.ListView()
        Me.ChCodigoCiudad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreCiudad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EpMensajeCiudad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TpDatos.SuspendLayout()
        Me.EpMensaje.SuspendLayout()
        Me.TbMenu.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        CType(Me.EpMensajeCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-2, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 39)
        Me.Panel2.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(369, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ciudad"
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(0, 0)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(231, 119)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 30
        Me.PbxLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(228, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 119)
        Me.Panel1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(206, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestión Ciudad"
        '
        'TpDatos
        '
        Me.TpDatos.Controls.Add(Me.EpMensaje)
        Me.TpDatos.Location = New System.Drawing.Point(4, 28)
        Me.TpDatos.Name = "TpDatos"
        Me.TpDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TpDatos.Size = New System.Drawing.Size(796, 296)
        Me.TpDatos.TabIndex = 2
        Me.TpDatos.Text = "Datos de la ciudad"
        Me.TpDatos.UseVisualStyleBackColor = True
        '
        'EpMensaje
        '
        Me.EpMensaje.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EpMensaje.Controls.Add(Me.BtnSalir)
        Me.EpMensaje.Controls.Add(Me.BtnCancelar)
        Me.EpMensaje.Controls.Add(Me.BtnGuardar)
        Me.EpMensaje.Controls.Add(Me.BtnModificar)
        Me.EpMensaje.Controls.Add(Me.BtnNuevo)
        Me.EpMensaje.Controls.Add(Me.TxtNombreCiudad)
        Me.EpMensaje.Controls.Add(Me.Label6)
        Me.EpMensaje.Controls.Add(Me.Label5)
        Me.EpMensaje.Controls.Add(Me.TxtCodCiudad)
        Me.EpMensaje.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EpMensaje.Location = New System.Drawing.Point(-4, 0)
        Me.EpMensaje.Name = "EpMensaje"
        Me.EpMensaje.Size = New System.Drawing.Size(804, 298)
        Me.EpMensaje.TabIndex = 34
        Me.EpMensaje.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(638, 230)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(111, 44)
        Me.BtnSalir.TabIndex = 23
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
        Me.BtnCancelar.Location = New System.Drawing.Point(502, 230)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(111, 44)
        Me.BtnCancelar.TabIndex = 24
        Me.BtnCancelar.Text = "Cancelar"
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
        Me.BtnGuardar.Location = New System.Drawing.Point(191, 230)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(111, 44)
        Me.BtnGuardar.TabIndex = 20
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
        Me.BtnModificar.Location = New System.Drawing.Point(344, 230)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(111, 44)
        Me.BtnModificar.TabIndex = 21
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.Location = New System.Drawing.Point(37, 230)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(111, 44)
        Me.BtnNuevo.TabIndex = 22
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TxtNombreCiudad
        '
        Me.TxtNombreCiudad.Location = New System.Drawing.Point(301, 162)
        Me.TxtNombreCiudad.Multiline = True
        Me.TxtNombreCiudad.Name = "TxtNombreCiudad"
        Me.TxtNombreCiudad.Size = New System.Drawing.Size(190, 23)
        Me.TxtNombreCiudad.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(315, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombre de la Ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(315, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo de la Ciudad"
        '
        'TxtCodCiudad
        '
        Me.TxtCodCiudad.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtCodCiudad.Location = New System.Drawing.Point(301, 77)
        Me.TxtCodCiudad.Multiline = True
        Me.TxtCodCiudad.Name = "TxtCodCiudad"
        Me.TxtCodCiudad.ReadOnly = True
        Me.TxtCodCiudad.Size = New System.Drawing.Size(190, 23)
        Me.TxtCodCiudad.TabIndex = 0
        '
        'TbMenu
        '
        Me.TbMenu.Controls.Add(Me.TpDatos)
        Me.TbMenu.Controls.Add(Me.TbListado)
        Me.TbMenu.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbMenu.Location = New System.Drawing.Point(-2, 154)
        Me.TbMenu.Name = "TbMenu"
        Me.TbMenu.SelectedIndex = 0
        Me.TbMenu.Size = New System.Drawing.Size(804, 328)
        Me.TbMenu.TabIndex = 1
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.LsvCiudades)
        Me.TbListado.Location = New System.Drawing.Point(4, 28)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(796, 296)
        Me.TbListado.TabIndex = 3
        Me.TbListado.Text = "Listado de ciudades"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'LsvCiudades
        '
        Me.LsvCiudades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoCiudad, Me.ChNombreCiudad})
        Me.LsvCiudades.ContextMenuStrip = Me.CmsOpciones
        Me.LsvCiudades.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvCiudades.FullRowSelect = True
        Me.LsvCiudades.GridLines = True
        Me.LsvCiudades.Location = New System.Drawing.Point(202, 30)
        Me.LsvCiudades.Name = "LsvCiudades"
        Me.LsvCiudades.Size = New System.Drawing.Size(407, 227)
        Me.LsvCiudades.TabIndex = 0
        Me.LsvCiudades.UseCompatibleStateImageBehavior = False
        Me.LsvCiudades.View = System.Windows.Forms.View.Details
        '
        'ChCodigoCiudad
        '
        Me.ChCodigoCiudad.Text = "Código Ciudad"
        Me.ChCodigoCiudad.Width = 137
        '
        'ChNombreCiudad
        '
        Me.ChNombreCiudad.Text = "Nombre Ciudad"
        Me.ChNombreCiudad.Width = 266
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'EpMensajeCiudad
        '
        Me.EpMensajeCiudad.ContainerControl = Me
        '
        'FrmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.TbMenu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCiudad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Ciudades"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TpDatos.ResumeLayout(False)
        Me.EpMensaje.ResumeLayout(False)
        Me.EpMensaje.PerformLayout()
        Me.TbMenu.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.CmsOpciones.ResumeLayout(False)
        CType(Me.EpMensajeCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TpDatos As TabPage
    Friend WithEvents EpMensaje As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtNombreCiudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCodCiudad As TextBox
    Friend WithEvents TbMenu As TabControl
    Friend WithEvents TbListado As TabPage
    Friend WithEvents LsvCiudades As ListView
    Friend WithEvents ChCodigoCiudad As ColumnHeader
    Friend WithEvents ChNombreCiudad As ColumnHeader
    Friend WithEvents EpMensajeCiudad As ErrorProvider
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
