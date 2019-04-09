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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbxExamen = New System.Windows.Forms.GroupBox()
        Me.TcEmpleados = New System.Windows.Forms.TabControl()
        Me.TpDatosEmpleado = New System.Windows.Forms.TabPage()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtNumIdent = New System.Windows.Forms.TextBox()
        Me.TpListadoEmpleado = New System.Windows.Forms.TabPage()
        Me.TxtBuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LsvEmpleados = New System.Windows.Forms.ListView()
        Me.ChNumeroIdentidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaNacimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaContratacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCiudad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCargoEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CmOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GbxExamen.SuspendLayout()
        Me.TcEmpleados.SuspendLayout()
        Me.TpDatosEmpleado.SuspendLayout()
        Me.TpListadoEmpleado.SuspendLayout()
        Me.CmOpciones.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Name = "Label2"
        '
        'PbxLogo
        '
        resources.ApplyResources(Me.PbxLogo, "PbxLogo")
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer))
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Name = "Panel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Name = "Label1"
        '
        'GbxExamen
        '
        Me.GbxExamen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbxExamen.Controls.Add(Me.TcEmpleados)
        resources.ApplyResources(Me.GbxExamen, "GbxExamen")
        Me.GbxExamen.Name = "GbxExamen"
        Me.GbxExamen.TabStop = False
        '
        'TcEmpleados
        '
        Me.TcEmpleados.Controls.Add(Me.TpDatosEmpleado)
        Me.TcEmpleados.Controls.Add(Me.TpListadoEmpleado)
        resources.ApplyResources(Me.TcEmpleados, "TcEmpleados")
        Me.TcEmpleados.Name = "TcEmpleados"
        Me.TcEmpleados.SelectedIndex = 0
        '
        'TpDatosEmpleado
        '
        Me.TpDatosEmpleado.Controls.Add(Me.BtnSalir)
        Me.TpDatosEmpleado.Controls.Add(Me.BtnCancelar)
        Me.TpDatosEmpleado.Controls.Add(Me.BtnGuardar)
        Me.TpDatosEmpleado.Controls.Add(Me.BtnModificar)
        Me.TpDatosEmpleado.Controls.Add(Me.BtnAgregar)
        Me.TpDatosEmpleado.Controls.Add(Me.TxtDireccion)
        Me.TpDatosEmpleado.Controls.Add(Me.Label8)
        Me.TpDatosEmpleado.Controls.Add(Me.CboCargoEmpleado)
        Me.TpDatosEmpleado.Controls.Add(Me.CboCiudad)
        Me.TpDatosEmpleado.Controls.Add(Me.CboSexo)
        Me.TpDatosEmpleado.Controls.Add(Me.Label12)
        Me.TpDatosEmpleado.Controls.Add(Me.Label4)
        Me.TpDatosEmpleado.Controls.Add(Me.Label3)
        Me.TpDatosEmpleado.Controls.Add(Me.DtpFechaContra)
        Me.TpDatosEmpleado.Controls.Add(Me.DtpFechaNac)
        Me.TpDatosEmpleado.Controls.Add(Me.TxtTelefono)
        Me.TpDatosEmpleado.Controls.Add(Me.TxtApellidos)
        Me.TpDatosEmpleado.Controls.Add(Me.Label11)
        Me.TpDatosEmpleado.Controls.Add(Me.Label10)
        Me.TpDatosEmpleado.Controls.Add(Me.Label9)
        Me.TpDatosEmpleado.Controls.Add(Me.Label7)
        Me.TpDatosEmpleado.Controls.Add(Me.Label6)
        Me.TpDatosEmpleado.Controls.Add(Me.Label5)
        Me.TpDatosEmpleado.Controls.Add(Me.TxtNombre)
        Me.TpDatosEmpleado.Controls.Add(Me.TxtNumIdent)
        resources.ApplyResources(Me.TpDatosEmpleado, "TpDatosEmpleado")
        Me.TpDatosEmpleado.Name = "TpDatosEmpleado"
        Me.TpDatosEmpleado.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.BtnSalir, "BtnSalir")
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.SystemColors.HotTrack
        resources.ApplyResources(Me.BtnGuardar, "BtnGuardar")
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.SystemColors.HotTrack
        resources.ApplyResources(Me.BtnModificar, "BtnModificar")
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.SystemColors.HotTrack
        resources.ApplyResources(Me.BtnAgregar, "BtnAgregar")
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'TxtDireccion
        '
        resources.ApplyResources(Me.TxtDireccion, "TxtDireccion")
        Me.TxtDireccion.Name = "TxtDireccion"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'CboCargoEmpleado
        '
        Me.CboCargoEmpleado.FormattingEnabled = True
        resources.ApplyResources(Me.CboCargoEmpleado, "CboCargoEmpleado")
        Me.CboCargoEmpleado.Name = "CboCargoEmpleado"
        '
        'CboCiudad
        '
        Me.CboCiudad.FormattingEnabled = True
        resources.ApplyResources(Me.CboCiudad, "CboCiudad")
        Me.CboCiudad.Name = "CboCiudad"
        '
        'CboSexo
        '
        Me.CboSexo.FormattingEnabled = True
        resources.ApplyResources(Me.CboSexo, "CboSexo")
        Me.CboSexo.Name = "CboSexo"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'DtpFechaContra
        '
        Me.DtpFechaContra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.DtpFechaContra, "DtpFechaContra")
        Me.DtpFechaContra.Name = "DtpFechaContra"
        '
        'DtpFechaNac
        '
        Me.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.DtpFechaNac, "DtpFechaNac")
        Me.DtpFechaNac.Name = "DtpFechaNac"
        '
        'TxtTelefono
        '
        resources.ApplyResources(Me.TxtTelefono, "TxtTelefono")
        Me.TxtTelefono.Name = "TxtTelefono"
        '
        'TxtApellidos
        '
        resources.ApplyResources(Me.TxtApellidos, "TxtApellidos")
        Me.TxtApellidos.Name = "TxtApellidos"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TxtNombre
        '
        resources.ApplyResources(Me.TxtNombre, "TxtNombre")
        Me.TxtNombre.Name = "TxtNombre"
        '
        'TxtNumIdent
        '
        resources.ApplyResources(Me.TxtNumIdent, "TxtNumIdent")
        Me.TxtNumIdent.Name = "TxtNumIdent"
        '
        'TpListadoEmpleado
        '
        Me.TpListadoEmpleado.Controls.Add(Me.TxtBuscarEmpleado)
        Me.TpListadoEmpleado.Controls.Add(Me.Label13)
        Me.TpListadoEmpleado.Controls.Add(Me.LsvEmpleados)
        Me.TpListadoEmpleado.Controls.Add(Me.ListView1)
        resources.ApplyResources(Me.TpListadoEmpleado, "TpListadoEmpleado")
        Me.TpListadoEmpleado.Name = "TpListadoEmpleado"
        Me.TpListadoEmpleado.UseVisualStyleBackColor = True
        '
        'TxtBuscarEmpleado
        '
        resources.ApplyResources(Me.TxtBuscarEmpleado, "TxtBuscarEmpleado")
        Me.TxtBuscarEmpleado.Name = "TxtBuscarEmpleado"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'LsvEmpleados
        '
        Me.LsvEmpleados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumeroIdentidad, Me.ChNombre, Me.ChApellidos, Me.ChDireccion, Me.ChTelefono, Me.ChFechaNacimiento, Me.ChFechaContratacion, Me.ChSexo, Me.ChCiudad, Me.ChCargoEmpleado})
        resources.ApplyResources(Me.LsvEmpleados, "LsvEmpleados")
        Me.LsvEmpleados.FullRowSelect = True
        Me.LsvEmpleados.GridLines = True
        Me.LsvEmpleados.Name = "LsvEmpleados"
        Me.LsvEmpleados.UseCompatibleStateImageBehavior = False
        Me.LsvEmpleados.View = System.Windows.Forms.View.Details
        '
        'ChNumeroIdentidad
        '
        resources.ApplyResources(Me.ChNumeroIdentidad, "ChNumeroIdentidad")
        '
        'ChNombre
        '
        resources.ApplyResources(Me.ChNombre, "ChNombre")
        '
        'ChApellidos
        '
        resources.ApplyResources(Me.ChApellidos, "ChApellidos")
        '
        'ChDireccion
        '
        resources.ApplyResources(Me.ChDireccion, "ChDireccion")
        '
        'ChTelefono
        '
        resources.ApplyResources(Me.ChTelefono, "ChTelefono")
        '
        'ChFechaNacimiento
        '
        resources.ApplyResources(Me.ChFechaNacimiento, "ChFechaNacimiento")
        '
        'ChFechaContratacion
        '
        resources.ApplyResources(Me.ChFechaContratacion, "ChFechaContratacion")
        '
        'ChSexo
        '
        resources.ApplyResources(Me.ChSexo, "ChSexo")
        '
        'ChCiudad
        '
        resources.ApplyResources(Me.ChCiudad, "ChCiudad")
        '
        'ChCargoEmpleado
        '
        resources.ApplyResources(Me.ChCargoEmpleado, "ChCargoEmpleado")
        '
        'ListView1
        '
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.Name = "ListView1"
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'CmOpciones
        '
        Me.CmOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmOpciones.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.CmOpciones, "CmOpciones")
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        resources.ApplyResources(Me.EditarToolStripMenuItem, "EditarToolStripMenuItem")
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        resources.ApplyResources(Me.EliminarToolStripMenuItem, "EliminarToolStripMenuItem")
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'FrmEmpleado
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ContextMenuStrip = Me.CmOpciones
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GbxExamen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmEmpleado"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbxExamen.ResumeLayout(False)
        Me.TcEmpleados.ResumeLayout(False)
        Me.TpDatosEmpleado.ResumeLayout(False)
        Me.TpDatosEmpleado.PerformLayout()
        Me.TpListadoEmpleado.ResumeLayout(False)
        Me.TpListadoEmpleado.PerformLayout()
        Me.CmOpciones.ResumeLayout(False)
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GbxExamen As GroupBox
    Friend WithEvents TcEmpleados As TabControl
    Friend WithEvents TpDatosEmpleado As TabPage
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
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
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtNumIdent As TextBox
    Friend WithEvents TpListadoEmpleado As TabPage
    Friend WithEvents LsvEmpleados As ListView
    Friend WithEvents ChNumeroIdentidad As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChFechaNacimiento As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents ChCiudad As ColumnHeader
    Friend WithEvents ChCargoEmpleado As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ChFechaContratacion As ColumnHeader
    Friend WithEvents CmOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtBuscarEmpleado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents EpMensaje As ErrorProvider
End Class
