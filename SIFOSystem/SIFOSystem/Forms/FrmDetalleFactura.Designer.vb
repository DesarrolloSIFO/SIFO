<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalleFactura))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbCategoriaProducto = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboCodFactura = New System.Windows.Forms.ComboBox()
        Me.CboCodProducto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.Panel2.Location = New System.Drawing.Point(-2, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 42)
        Me.Panel2.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(338, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Detalle Factura"
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(-2, -3)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(231, 114)
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
        Me.Panel1.Location = New System.Drawing.Point(228, -75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 186)
        Me.Panel1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(142, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestión Detalle de Factura"
        '
        'GbCategoriaProducto
        '
        Me.GbCategoriaProducto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbCategoriaProducto.Controls.Add(Me.BtnLimpiar)
        Me.GbCategoriaProducto.Controls.Add(Me.BtnAgregar)
        Me.GbCategoriaProducto.Controls.Add(Me.TxtPrecioVenta)
        Me.GbCategoriaProducto.Controls.Add(Me.TxtCantidad)
        Me.GbCategoriaProducto.Controls.Add(Me.Label4)
        Me.GbCategoriaProducto.Controls.Add(Me.Label3)
        Me.GbCategoriaProducto.Controls.Add(Me.CboCodFactura)
        Me.GbCategoriaProducto.Controls.Add(Me.CboCodProducto)
        Me.GbCategoriaProducto.Controls.Add(Me.Label6)
        Me.GbCategoriaProducto.Controls.Add(Me.Label5)
        Me.GbCategoriaProducto.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbCategoriaProducto.Location = New System.Drawing.Point(-2, 159)
        Me.GbCategoriaProducto.Name = "GbCategoriaProducto"
        Me.GbCategoriaProducto.Size = New System.Drawing.Size(783, 366)
        Me.GbCategoriaProducto.TabIndex = 37
        Me.GbCategoriaProducto.TabStop = False
        Me.GbCategoriaProducto.Text = "Detalle"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.Location = New System.Drawing.Point(654, 283)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(112, 44)
        Me.BtnLimpiar.TabIndex = 23
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
        Me.BtnAgregar.Location = New System.Drawing.Point(520, 283)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(112, 44)
        Me.BtnAgregar.TabIndex = 22
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(493, 172)
        Me.TxtPrecioVenta.Multiline = True
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(110, 25)
        Me.TxtPrecioVenta.TabIndex = 21
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(493, 79)
        Me.TxtCantidad.Multiline = True
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(110, 25)
        Me.TxtCantidad.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(489, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Precio de Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(489, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cantidad"
        '
        'CboCodFactura
        '
        Me.CboCodFactura.FormattingEnabled = True
        Me.CboCodFactura.Location = New System.Drawing.Point(113, 79)
        Me.CboCodFactura.Name = "CboCodFactura"
        Me.CboCodFactura.Size = New System.Drawing.Size(197, 25)
        Me.CboCodFactura.TabIndex = 17
        '
        'CboCodProducto
        '
        Me.CboCodProducto.FormattingEnabled = True
        Me.CboCodProducto.Location = New System.Drawing.Point(113, 184)
        Me.CboCodProducto.Name = "CboCodProducto"
        Me.CboCodProducto.Size = New System.Drawing.Size(197, 25)
        Me.CboCodProducto.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Codigo del Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo de la Factura"
        '
        'FrmDetalleFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GbCategoriaProducto)
        Me.Name = "FrmDetalleFactura"
        Me.Text = "Form1"
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
    Friend WithEvents CboCodProducto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboCodFactura As ComboBox
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAgregar As Button
End Class
