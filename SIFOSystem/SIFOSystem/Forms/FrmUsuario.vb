Imports System.Data.SqlClient
Public Class FrmUsuario
    Public Sub LLenarCboActivo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarActivo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "Sexo")
                CboActivo.DataSource = Ds.Tables(0)
                CboActivo.ValueMember = Ds.Tables(0).Columns("Activo").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CientíficaMusic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub


    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerUsuario As SqlDataReader
                VerUsuario = CMd.ExecuteReader

                LsvListado.Items.Clear()
                While VerUsuario.Read = True
                    With LsvListado.Items.Add(VerUsuario("IdUsuario").ToString)
                        .SubItems.Add(VerUsuario("NumIdentEmpleado").ToString)
                        .SubItems.Add(VerUsuario("UserName").ToString)
                        .SubItems.Add(VerUsuario("Contraseña").ToString)
                        .SubItems.Add(VerUsuario("Activo").ToString)
                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar usuario" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub GuardarUsuario()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    .Parameters.Add("@NumIdentEmpleado", SqlDbType.VarChar, 15).Value = TxtIdentidad.Text
                    .Parameters.Add("@UserName", SqlDbType.NVarChar, 60).Value = TxtNombre.Text
                    .Parameters.Add("@Contraseña", SqlDbType.NVarChar, 15).Value = TxtContraseña.Text
                    .Parameters.Add("@Activo", SqlDbType.Int).Value = CInt(CboActivo.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos del usuario" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    Private Sub ActualizarUsuario()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = TxtCodigo.Text
                    .Parameters.Add("@NumIdentEmpleado", SqlDbType.VarChar, 15).Value = TxtIdentidad.Text
                    .Parameters.Add("@UserName", SqlDbType.NVarChar, 60).Value = TxtNombre.Text
                    .Parameters.Add("@Contraseña", SqlDbType.NVarChar, 15).Value = TxtContraseña.Text
                    .Parameters.Add("@Activo", SqlDbType.Int).Value = CInt(CboActivo.Text)

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el usuario " + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    Private Sub EliminarUsuario()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As String
                    Id = LsvListado.FocusedItem.SubItems(0).Text
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarTodo()

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el usuarios" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Public Sub HabilitarBotones(ByVal Nuevo As Boolean,
                           ByVal Guardar As Boolean,
                           ByVal modificar As Boolean,
                           ByVal cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = modificar
        BtnCancelar.Enabled = cancelar
    End Sub
    Private Sub Limpiar()
        TxtCodigo.Clear()
        TxtIdentidad.Clear()
        TxtNombre.Clear()
        TxtContraseña.Clear()
        CboActivo.Text = Nothing
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativoUsuario()
        LLenarCboActivo()

        TxtIdentidad.Focus()
    End Sub

    Public Sub InvestigarCorrelativoUsuario()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListaUsuario As New SqlCommand("Sp_InvestigarCorrelativoUsuario", Cn)
            ListaUsuario.CommandType = CommandType.StoredProcedure
            Dim ListarUsuarioR As SqlDataReader
            Cn.Open()
            ListarUsuarioR = ListaUsuario.ExecuteReader()

            If ListarUsuarioR.Read = True Then
                If ListarUsuarioR("IdUsuario") Is "" Then
                    TxtCodigo.Text = 1
                Else
                    TxtCodigo.Text = ListarUsuarioR("IdUsuario").ToString
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos " + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            If ExisteUsuario() = False Then
                HabilitarBotones(True, False, False, False)
                GuardarUsuario()
                Limpiar()
                MostrarTodo()
            End If
        End If
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False)
        MostrarTodo()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodigo.Text = LsvListado.FocusedItem.SubItems(0).Text
        TxtIdentidad.Text = LsvListado.FocusedItem.SubItems(1).Text
        TxtNombre.Text = LsvListado.FocusedItem.SubItems(2).Text
        TxtContraseña.Text = LsvListado.FocusedItem.SubItems(3).Text
        CboActivo.Text = LsvListado.FocusedItem.SubItems(4).Text

        TcOpciones.SelectedIndex = 0
        HabilitarBotones(False, False, True, True)
    End Sub

    Private Sub BtnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles BtnBuscarUsuario.Click
        FrmBuscarUsuario.Show()
        HabilitarBotones(False, True, False, True)
        Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarUsuario()
        MostrarTodo()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            ActualizarUsuario()
            HabilitarBotones(True, False, False, True)
            MostrarTodo()
            TcOpciones.SelectedIndex = 1
            Limpiar()

        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()


    End Sub

    Private Function ValidarTextBox() As Boolean
        Dim Estado As Boolean

        If TxtIdentidad.Text = Nothing And TxtNombre.Text = Nothing And TxtContraseña.Text = Nothing And CboActivo.Text = "--Seleccione--" Then
            EpMensaje.SetError(TxtIdentidad, "tiene que ingresar su identidad")
            EpMensaje.SetError(TxtNombre, "Tiene que ingresar su nombre de usuario")
            EpMensaje.SetError(TxtContraseña, "Tiene que ingresar su contraseña")
            EpMensaje.SetError(CboActivo, "Tiene que seleccionar su estado")

            TxtIdentidad.Focus()
            TxtIdentidad.BackColor = Color.LightBlue
            TxtNombre.BackColor = Color.LightBlue
            TxtContraseña.BackColor = Color.LightBlue
            CboActivo.BackColor = Color.LightBlue

            Estado = False
        ElseIf TxtIdentidad.Text = Nothing Then
            EpMensaje.SetError(TxtIdentidad, "tiene que ingresar su identidad")
            TxtIdentidad.BackColor = Color.LightBlue
            TxtIdentidad.Focus()
            Estado = False


        ElseIf TxtNombre.Text = Nothing Then
            EpMensaje.SetError(TxtNombre, "Tiene que ingresar su nombre de usuario")
            TxtNombre.BackColor = Color.LightBlue
            TxtNombre.Focus()
            Estado = False

        ElseIf TxtContraseña.Text = Nothing Then
            EpMensaje.SetError(TxtContraseña, "Tiene que ingresar su contraseña")
            TxtContraseña.BackColor = Color.LightBlue
            TxtContraseña.Focus()
            Estado = False

        ElseIf CboActivo.Text = "--Seleccione--" Then
            EpMensaje.SetError(CboActivo, "Tiene que seleccionar su estado")
            CboActivo.BackColor = Color.LightBlue
            CboActivo.Focus()
            Estado = False

        Else
            EpMensaje.SetError(TxtIdentidad, "")
            EpMensaje.SetError(TxtNombre, "")
            EpMensaje.SetError(TxtContraseña, "")
            EpMensaje.SetError(CboActivo, "")
            Estado = True
            Estado = True
            Estado = True
            Estado = True
        End If

        Return Estado
    End Function

    Private Function ExisteUsuario() As Boolean
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Dim EstadoU As Boolean = False
        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ExisteUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumIdentEmpleado", SqlDbType.VarChar, 15).Value = TxtIdentidad.Text.Trim

                End With

                Dim Existe As Integer = Cmd.ExecuteScalar()

                If Existe <> 0 Then
                    EstadoU = True
                    MessageBox.Show("Ya esta esta registrado el numero de identidad" + " " + TxtIdentidad.Text, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al almacenar el registrio" + ex.Message, "CarWashSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

        Return EstadoU
    End Function

End Class