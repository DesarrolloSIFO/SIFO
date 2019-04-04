'Imports System.Data.SqlClient
'Public Class FrmUsuario
'    Private Sub LLenarCboActivo()
'        If Cn.State = ConnectionState.Open Then
'            Cn.Close()
'        End If
'        Using CMd As New SqlCommand
'            Cn.Open()

'            Try
'                With CMd
'                    .CommandText = "Sp_MostrarActivo"
'                    .CommandType = CommandType.StoredProcedure
'                    .Connection = Cn

'                End With

'                Dim Da As New SqlDataAdapter(CMd)

'                Dim Ds As New DataSet

'                Da.Fill(Ds, "Sexo")
'                CboActivo.DataSource = Ds.Tables(0)
'                CboActivo.ValueMember = Ds.Tables(0).Columns("Activo").ToString
'            Catch ex As Exception
'                MessageBox.Show("Error al consultar los datos." + ex.Message, "CientíficaMusic", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Finally
'                Cn.Close()
'            End Try
'        End Using
'    End Sub

'    Private Sub MostrarTodo()
'        If Cn.State = ConnectionState.Open Then
'            Cn.Close()
'        End If

'        Using CMd As New SqlCommand
'            Cn.Open()

'            Try
'                With CMd
'                    .CommandText = "Sp_MostrarUsuario"
'                    .CommandType = CommandType.StoredProcedure
'                    .Connection = Cn

'                End With

'                Dim VerUsuario As SqlDataReader
'                VerUsuario = CMd.ExecuteReader

'                LsvListado.Items.Clear()
'                While VerUsuario.Read = True
'                    With LsvListado.Items.Add(VerUsuario("IdUsuario").ToString)
'                        .SubItems.Add(VerUsuario("NumIdenEmpleado").ToString)
'                        .SubItems.Add(VerUsuario("UserName").ToString)
'                        .SubItems.Add(VerUsuario("Contraseña").ToString)
'                        .SubItems.Add(VerUsuario("Activo").ToString)
'                    End With
'                End While

'            Catch ex As Exception

'                MessageBox.Show("Error al mostrar usuario" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Finally
'                Cn.Close()

'            End Try
'        End Using
'    End Sub

'    Private Sub GuardarUsuario()
'        If Cn.State = ConnectionState.Open Then
'            Cn.Close()
'        End If

'        Try
'            Cn.Open()
'            Using Cmd As New SqlCommand
'                With Cmd
'                    .CommandText = "Sp_InsertarUsuario"
'                    .CommandType = CommandType.StoredProcedure
'                    .Connection = Cn


'                    .Parameters.Add("@NumIdenEmpleado", SqlDbType.VarChar, 15).Value = TxtCodigo.Text
'                    .Parameters.Add("@UserName", SqlDbType.NVarChar, 60).Value = TxtNombre.Text
'                    .Parameters.Add("@Contraseña", SqlDbType.NVarChar, 15).Value = TxtContraseña.Text
'                    .Parameters.Add("@Activo", SqlDbType.Int).Value = CInt(CboActivo.SelectedValue)
'                    .ExecuteNonQuery()

'                    MessageBox.Show("Registro almacenado satisfactoriamente.", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

'                End With
'            End Using
'        Catch ex As Exception
'            MessageBox.Show("Error al insertar los datos del usuario" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            Cn.Close()
'        End Try
'    End Sub

'    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
'                           ByVal Guardar As Boolean,
'                           ByVal modificar As Boolean,
'                           ByVal cancelar As Boolean)
'        BtnNuevo.Enabled = Nuevo
'        BtnGuardar.Enabled = Guardar
'        BtnModificar.Enabled = modificar
'        BtnCancelar.Enabled = cancelar
'    End Sub

'    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
'        HabilitarBotones(False, True, False, True)
'        LLenarCboActivo()
'        TxtCodigo.Focus()
'    End Sub

'    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
'        HabilitarBotones(True, False, False, False)
'        GuardarUsuario()
'        MostrarTodo()
'    End Sub

'    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        HabilitarBotones(True, False, False, False)
'    End Sub
'End Class