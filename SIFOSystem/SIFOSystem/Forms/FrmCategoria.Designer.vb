<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoria))
        Me.TpCategorias = New System.Windows.Forms.TabControl()
        Me.TpCategoria = New System.Windows.Forms.TabPage()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtCodCategoria = New System.Windows.Forms.TextBox()
        Me.TpListado = New System.Windows.Forms.TabPage()
        Me.LsvCategorias = New System.Windows.Forms.ListView()
        Me.ChIdCategoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCategoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TpCategorias.SuspendLayout()
        Me.TpCategoria.SuspendLayout()
        Me.TpListado.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TpCategorias
        '
        Me.TpCategorias.Controls.Add(Me.TpCategoria)
        Me.TpCategorias.Controls.Add(Me.TpListado)
        Me.TpCategorias.Location = New System.Drawing.Point(1, 156)
        Me.TpCategorias.Name = "TpCategorias"
        Me.TpCategorias.SelectedIndex = 0
        Me.TpCategorias.Size = New System.Drawing.Size(795, 370)
        Me.TpCategorias.TabIndex = 37
        '
        'TpCategoria
        '
        Me.TpCategoria.Controls.Add(Me.BtnGuardar)
        Me.TpCategoria.Controls.Add(Me.TxtNombreCategoria)
        Me.TpCategoria.Controls.Add(Me.BtnSalir)
        Me.TpCategoria.Controls.Add(Me.BtnCancelar)
        Me.TpCategoria.Controls.Add(Me.BtnModificar)
        Me.TpCategoria.Controls.Add(Me.BtnAgregar)
        Me.TpCategoria.Controls.Add(Me.Label7)
        Me.TpCategoria.Controls.Add(Me.Label6)
        Me.TpCategoria.Controls.Add(Me.Label5)
        Me.TpCategoria.Controls.Add(Me.TxtDescripcion)
        Me.TpCategoria.Controls.Add(Me.TxtCodCategoria)
        Me.TpCategoria.Location = New System.Drawing.Point(4, 22)
        Me.TpCategoria.Name = "TpCategoria"
        Me.TpCategoria.Padding = New System.Windows.Forms.Padding(3)
        Me.TpCategoria.Size = New System.Drawing.Size(787, 344)
        Me.TpCategoria.TabIndex = 0
        Me.TpCategoria.Text = "Datos _Categoria"
        Me.TpCategoria.UseVisualStyleBackColor = True
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
        Me.BtnGuardar.Location = New System.Drawing.Point(192, 261)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(112, 44)
        Me.BtnGuardar.TabIndex = 28
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtNombreCategoria
        '
        Me.TxtNombreCategoria.Location = New System.Drawing.Point(46, 118)
        Me.TxtNombreCategoria.Name = "TxtNombreCategoria"
        Me.TxtNombreCategoria.Size = New System.Drawing.Size(230, 20)
        Me.TxtNombreCategoria.TabIndex = 27
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(638, 261)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(112, 44)
        Me.BtnSalir.TabIndex = 25
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
        Me.BtnCancelar.Location = New System.Drawing.Point(502, 261)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(112, 44)
        Me.BtnCancelar.TabIndex = 26
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancelar.UseVisualStyleBackColor = False
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
        Me.BtnModificar.Location = New System.Drawing.Point(344, 261)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(112, 44)
        Me.BtnModificar.TabIndex = 23
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
        Me.BtnAgregar.Location = New System.Drawing.Point(37, 261)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(112, 44)
        Me.BtnAgregar.TabIndex = 24
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Descripción"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Nombre de la Categoría"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Código de Categoría"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(46, 169)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(392, 73)
        Me.TxtDescripcion.TabIndex = 18
        '
        'TxtCodCategoria
        '
        Me.TxtCodCategoria.Enabled = False
        Me.TxtCodCategoria.Location = New System.Drawing.Point(46, 67)
        Me.TxtCodCategoria.Name = "TxtCodCategoria"
        Me.TxtCodCategoria.Size = New System.Drawing.Size(192, 20)
        Me.TxtCodCategoria.TabIndex = 17
        '
        'TpListado
        '
        Me.TpListado.Controls.Add(Me.LsvCategorias)
        Me.TpListado.Location = New System.Drawing.Point(4, 22)
        Me.TpListado.Name = "TpListado"
        Me.TpListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TpListado.Size = New System.Drawing.Size(787, 344)
        Me.TpListado.TabIndex = 1
        Me.TpListado.Text = "Listado"
        Me.TpListado.UseVisualStyleBackColor = True
        '
        'LsvCategorias
        '
        Me.LsvCategorias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdCategoria, Me.ChCategoria, Me.ChDescripcion})
        Me.LsvCategorias.FullRowSelect = True
        Me.LsvCategorias.GridLines = True
        Me.LsvCategorias.Location = New System.Drawing.Point(-1, 0)
        Me.LsvCategorias.Name = "LsvCategorias"
        Me.LsvCategorias.Size = New System.Drawing.Size(661, 338)
        Me.LsvCategorias.TabIndex = 0
        Me.LsvCategorias.UseCompatibleStateImageBehavior = False
        Me.LsvCategorias.View = System.Windows.Forms.View.Details
        '
        'ChIdCategoria
        '
        Me.ChIdCategoria.Text = "Id Categoria"
        '
        'ChCategoria
        '
        Me.ChCategoria.Text = "Categoria"
        Me.ChCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ChCategoria.Width = 200
        '
        'ChDescripcion
        '
        Me.ChDescripcion.Text = "Descripcion"
        Me.ChDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ChDescripcion.Width = 400
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 37)
        Me.Panel2.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(355, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Categoría"
        '
        'PbxLogo
        '
        Me.PbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(4, 8)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(230, 117)
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
        Me.Panel1.Location = New System.Drawing.Point(230, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 120)
        Me.Panel1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(190, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestión Categoria"
        '
        'CmsOpciones
        '
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "ContextMenuStrip1"
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
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.ContextMenuStrip = Me.CmsOpciones
        Me.Controls.Add(Me.TpCategorias)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestión Categoría"
        Me.TpCategorias.ResumeLayout(False)
        Me.TpCategoria.ResumeLayout(False)
        Me.TpCategoria.PerformLayout()
        Me.TpListado.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CmsOpciones.ResumeLayout(False)
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TpCategorias As TabControl
    Friend WithEvents TpCategoria As TabPage
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtNombreCategoria As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtCodCategoria As TextBox
    Friend WithEvents TpListado As TabPage
    Friend WithEvents LsvCategorias As ListView
    Friend WithEvents ChIdCategoria As ColumnHeader
    Friend WithEvents ChCategoria As ColumnHeader
    Friend WithEvents ChDescripcion As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EpMensaje As ErrorProvider
End Class
