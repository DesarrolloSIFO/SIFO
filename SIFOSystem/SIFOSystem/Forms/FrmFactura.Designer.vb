﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbxExamen = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
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
        Me.Panel2.Location = New System.Drawing.Point(-2, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 37)
        Me.Panel2.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(386, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Factura"
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = CType(resources.GetObject("PbxLogo.Image"), System.Drawing.Image)
        Me.PbxLogo.Location = New System.Drawing.Point(-2, -3)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(231, 122)
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
        Me.Panel1.Location = New System.Drawing.Point(228, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 123)
        Me.Panel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(217, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Detalle Factura"
        '
        'GbxExamen
        '
        Me.GbxExamen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbxExamen.Controls.Add(Me.Button3)
        Me.GbxExamen.Controls.Add(Me.BtnLimpiar)
        Me.GbxExamen.Controls.Add(Me.Button2)
        Me.GbxExamen.Controls.Add(Me.Button1)
        Me.GbxExamen.Controls.Add(Me.BtnAgregar)
        Me.GbxExamen.Controls.Add(Me.ComboBox3)
        Me.GbxExamen.Controls.Add(Me.Label3)
        Me.GbxExamen.Controls.Add(Me.Label11)
        Me.GbxExamen.Controls.Add(Me.Label10)
        Me.GbxExamen.Controls.Add(Me.Label9)
        Me.GbxExamen.Controls.Add(Me.Label8)
        Me.GbxExamen.Controls.Add(Me.Label7)
        Me.GbxExamen.Controls.Add(Me.Lbl)
        Me.GbxExamen.Controls.Add(Me.Label5)
        Me.GbxExamen.Controls.Add(Me.DateTimePicker1)
        Me.GbxExamen.Controls.Add(Me.ComboBox2)
        Me.GbxExamen.Controls.Add(Me.ComboBox1)
        Me.GbxExamen.Controls.Add(Me.TextBox3)
        Me.GbxExamen.Controls.Add(Me.TextBox2)
        Me.GbxExamen.Controls.Add(Me.TextBox1)
        Me.GbxExamen.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxExamen.Location = New System.Drawing.Point(8, 159)
        Me.GbxExamen.Name = "GbxExamen"
        Me.GbxExamen.Size = New System.Drawing.Size(783, 347)
        Me.GbxExamen.TabIndex = 29
        Me.GbxExamen.TabStop = False
        Me.GbxExamen.Text = "DATOS DE FACTURA"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(55, 234)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(334, 25)
        Me.ComboBox3.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nombre Cliente "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(491, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Fecha De Examen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(491, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Id Usuario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(491, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Ciudad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tipo Examen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Numero de identidad"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft JhengHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(53, 75)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(0, 16)
        Me.Lbl.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo Factura "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(494, 160)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 25)
        Me.DateTimePicker1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(494, 100)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(250, 25)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(494, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 25)
        Me.ComboBox1.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(53, 158)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(336, 25)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(53, 98)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(336, 25)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(53, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(336, 25)
        Me.TextBox1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(639, 288)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 44)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Salir"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.Location = New System.Drawing.Point(503, 288)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(112, 44)
        Me.BtnLimpiar.TabIndex = 22
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(192, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 44)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Guardar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(345, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 44)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Modificar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.BtnAgregar.Location = New System.Drawing.Point(38, 288)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(112, 44)
        Me.BtnAgregar.TabIndex = 20
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(803, 518)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GbxExamen)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form"
        Me.Text = "Factura "
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnAgregar As Button
End Class
