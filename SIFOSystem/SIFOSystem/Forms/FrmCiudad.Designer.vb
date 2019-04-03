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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCiudad))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbCategoriaProducto = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCodCiudad = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GbCategoriaProducto.SuspendLayout()
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
        Me.PbxLogo.Location = New System.Drawing.Point(-2, -3)
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
        'GbCategoriaProducto
        '
        Me.GbCategoriaProducto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbCategoriaProducto.Controls.Add(Me.TextBox1)
        Me.GbCategoriaProducto.Controls.Add(Me.BtnLimpiar)
        Me.GbCategoriaProducto.Controls.Add(Me.BtnAgregar)
        Me.GbCategoriaProducto.Controls.Add(Me.Label6)
        Me.GbCategoriaProducto.Controls.Add(Me.Label5)
        Me.GbCategoriaProducto.Controls.Add(Me.TxtCodCiudad)
        Me.GbCategoriaProducto.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbCategoriaProducto.Location = New System.Drawing.Point(-2, 159)
        Me.GbCategoriaProducto.Name = "GbCategoriaProducto"
        Me.GbCategoriaProducto.Size = New System.Drawing.Size(804, 288)
        Me.GbCategoriaProducto.TabIndex = 33
        Me.GbCategoriaProducto.TabStop = False
        Me.GbCategoriaProducto.Text = "Datos de la ciudad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombre de la Ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo de la Ciudad"
        '
        'TxtCodCiudad
        '
        Me.TxtCodCiudad.Location = New System.Drawing.Point(168, 85)
        Me.TxtCodCiudad.Multiline = True
        Me.TxtCodCiudad.Name = "TxtCodCiudad"
        Me.TxtCodCiudad.Size = New System.Drawing.Size(190, 23)
        Me.TxtCodCiudad.TabIndex = 0
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.Location = New System.Drawing.Point(633, 223)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(112, 44)
        Me.BtnLimpiar.TabIndex = 18
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
        Me.BtnAgregar.Location = New System.Drawing.Point(499, 223)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(112, 44)
        Me.BtnAgregar.TabIndex = 17
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(168, 170)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 23)
        Me.TextBox1.TabIndex = 19
        '
        'FrmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GbCategoriaProducto)
        Me.Name = "FrmCiudad"
        Me.Text = "Gestión de Ciudades"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbCategoriaProducto.ResumeLayout(False)
        Me.GbCategoriaProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GbCategoriaProducto As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCodCiudad As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAgregar As Button
End Class
