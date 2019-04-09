Imports System.Data.SqlClient
Public Class FrmGestión
    Private Sub LLenarCboSexo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "Sexo")
                CboSexo.DataSource = Ds.Tables(0)
                CboSexo.DisplayMember = Ds.Tables(0).Columns("Sexo").ToString
                CboSexo.ValueMember = Ds.Tables(0).Columns("IdSexo").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LLenarCboCiudad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "Ciudad")
                CboCiudad.DataSource = Ds.Tables(0)
                CboCiudad.DisplayMember = Ds.Tables(0).Columns("NombreCiudad").ToString
                CboCiudad.ValueMember = Ds.Tables(0).Columns("IdCiudad").ToString
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
                    .CommandText = "Sp_MostrarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerCliente As SqlDataReader
                VerCliente = CMd.ExecuteReader

                LsvCliente.Items.Clear()
                While VerCliente.Read = True
                    With LsvCliente.Items.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellidos").ToString)
                        .SubItems.Add(VerCliente("NumIdentCliente").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaDeNacimiento").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("NombreCiudad").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar el cliente" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub GuardarCliente()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del Género Musical
                    .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = TxtNumIdent.Text
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombres.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = TxtTelefono.Text
                    .Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = DtpFechaNac.Text
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(CboCiudad.SelectedValue)

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos del cliente" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                             ByVal Guardar As Boolean,
                             ByVal modificar As Boolean,
                             ByVal cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = modificar
        BtnCancelar.Enabled = cancelar

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        LLenarCboSexo()
        CboSexo.Text = "--Seleccione--"
        LLenarCboCiudad()
        CboCiudad.Text = "--Seleccione--"
        TxtNombres.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        HabilitarBotones(True, False, False, False)

        If ValidarTextBox() = True Then
            GuardarCliente()
            MostrarTodo()
            Limpiar()
        End If

    End Sub

    Private Sub FrmGestión_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub BuscarClientePorNombre()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarClientePorNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarPorNombre.Text

                End With

                Dim VerCliente As SqlDataReader
                VerCliente = CMd.ExecuteReader

                LsvCliente.Items.Clear()
                While VerCliente.Read = True
                    With LsvCliente.Items.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellidos").ToString)
                        .SubItems.Add(VerCliente("NumIdentCliente").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaDeNacimiento").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("NombreCiudad").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar el cliente" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarClientePorIdentidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarClientePorIdentidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarPorCodigo.Text

                End With

                Dim VerCliente As SqlDataReader
                VerCliente = CMd.ExecuteReader

                LsvCliente.Items.Clear()
                While VerCliente.Read = True
                    With LsvCliente.Items.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellidos").ToString)
                        .SubItems.Add(VerCliente("NumIdentCliente").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaDeNacimiento").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("NombreCiudad").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar el cliente" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarPorNombre.TextChanged
        BuscarClientePorNombre()
        BtnLimpiar.Visible = True
    End Sub

    Private Sub EliminarCliente()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As String
                    Id = LsvCliente.FocusedItem.SubItems(2).Text
                    .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MostrarTodo()

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el cliente" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarCliente()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtNombres.Text = LsvCliente.FocusedItem.SubItems(0).Text
        TxtApellidos.Text = LsvCliente.FocusedItem.SubItems(1).Text
        TxtNumIdent.Text = LsvCliente.FocusedItem.SubItems(2).Text
        TxtTelefono.Text = LsvCliente.FocusedItem.SubItems(3).Text
        TxtDireccion.Text = LsvCliente.FocusedItem.SubItems(4).Text
        CboSexo.Text = LsvCliente.FocusedItem.SubItems(6).Text
        CboCiudad.Text = LsvCliente.FocusedItem.SubItems(7).Text
        DtpFechaNac.Text = LsvCliente.FocusedItem.SubItems(5).Text




        TpCliente.SelectedIndex = 0
        HabilitarBotones(False, False, True, True)

        LLenarCboCiudad()
        LLenarCboSexo()
    End Sub

    Private Sub ActualizarCliente()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = TxtNumIdent.Text
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombres.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = TxtTelefono.Text
                    .Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = DtpFechaNac.Text
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(CboCiudad.SelectedValue)


                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el cliente " + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        HabilitarBotones(True, False, False, True)

        If ValidarTextBox() = True Then
            ActualizarCliente()
            MostrarTodo()
            Limpiar()

            TpCliente.SelectedIndex = 1
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)

        Limpiar()
    End Sub


    Private Sub Limpiar()
        For Each Ctrl In GbxExamen.Controls
            If TypeOf Ctrl Is TextBox Then
                Ctrl.Text = ""
            End If
        Next
        LLenarCboCiudad()
        CboCiudad.Text = "--Seleccione--"
        LLenarCboSexo()
        CboSexo.Text = "--Seleccione--"
    End Sub

    Private Function ValidarTextBox() As Boolean
        Dim Estado As Boolean

        If TxtNombres.Text = Nothing And TxtApellidos.Text = Nothing And TxtNumIdent.Text = Nothing And TxtDireccion.Text = Nothing And CboSexo.Text = "--Seleccione--" And CboCiudad.Text = "--Seleccione--" Then
            EpMensaje.SetError(TxtNombres, "Tiene que ingresar el nombre")
            EpMensaje.SetError(TxtApellidos, "Tiene que ingresar los apellidos")
            EpMensaje.SetError(TxtNumIdent, "Tiene que ingresar su número de identidad")
            EpMensaje.SetError(TxtDireccion, "Tiene que ingresar la dirección")
            EpMensaje.SetError(CboSexo, "Tiene que seleccionar su sexo")
            EpMensaje.SetError(CboCiudad, "Tiene que seleccionar su ciudad")


            TxtNombres.Focus()
            TxtNombres.BackColor = Color.LightBlue
            TxtApellidos.BackColor = Color.LightBlue
            TxtNumIdent.BackColor = Color.LightBlue
            TxtDireccion.BackColor = Color.LightBlue
            CboSexo.BackColor = Color.LightBlue
            CboCiudad.BackColor = Color.LightBlue

            Estado = False

        ElseIf TxtNombres.Text = Nothing Then
            EpMensaje.SetError(TxtNombres, "Tiene que ingresar el nombre")
            TxtNombres.Focus()
            TxtNombres.BackColor = Color.LightBlue
            Estado = False

        ElseIf TxtApellidos.Text = Nothing Then
            EpMensaje.SetError(TxtApellidos, "Tiene que ingresar los apellidos")
            TxtApellidos.Focus()
            TxtApellidos.BackColor = Color.LightBlue
            Estado = False

        ElseIf TxtNumIdent.Text = Nothing Then
            EpMensaje.SetError(TxtNumIdent, "Tiene que ingresar su número de identidad")
            TxtNumIdent.Focus()
            TxtNumIdent.BackColor = Color.LightBlue
            Estado = False

        ElseIf TxtDireccion.Text = Nothing Then
            EpMensaje.SetError(TxtDireccion, "Tiene que ingresar la dirección")
            TxtDireccion.Focus()
            TxtDireccion.BackColor = Color.LightBlue
            Estado = False

        ElseIf CboSexo.Text = "--Seleccione--" Then
            EpMensaje.SetError(CboSexo, "Tiene que seleccionar su sexo")
            CboSexo.Focus()
            CboSexo.BackColor = Color.LightBlue
            Estado = False

        ElseIf CboCiudad.Text = "--Seleccione--" Then
            EpMensaje.SetError(CboCiudad, "Tiene que seleccionar su sexo")
            CboCiudad.Focus()
            CboCiudad.BackColor = Color.LightBlue
            Estado = False

        Else
            EpMensaje.SetError(TxtNombres, "")
            EpMensaje.SetError(TxtApellidos, "")
            EpMensaje.SetError(TxtDireccion, "")
            EpMensaje.SetError(TxtNumIdent, "")
            EpMensaje.SetError(CboSexo, "")
            EpMensaje.SetError(CboCiudad, "")
            Estado = True
            Estado = True
            Estado = True
            Estado = True
            Estado = True
            Estado = True


        End If
        Return Estado
    End Function

    Private Sub TxtNombres_TextChanged(sender As Object, e As EventArgs) Handles TxtNombres.TextChanged
        If TxtNombres.Text <> Nothing Then
            EpMensaje.SetError(TxtNombres, "")
            TxtNombres.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtApellidos_TextChanged(sender As Object, e As EventArgs) Handles TxtApellidos.TextChanged
        If TxtApellidos.Text <> Nothing Then
            EpMensaje.SetError(TxtApellidos, "")
            TxtApellidos.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtNumIdent_TextChanged(sender As Object, e As EventArgs) Handles TxtNumIdent.TextChanged
        If TxtNumIdent.Text <> Nothing Then
            EpMensaje.SetError(TxtNumIdent, "")
            TxtNumIdent.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged
        If TxtDireccion.Text <> Nothing Then
            EpMensaje.SetError(TxtDireccion, "")
            TxtDireccion.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtNumIdent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumIdent.KeyPress
        Dim texto As String = TxtNumIdent.Text
        If TxtNumIdent.Text.Length = 4 Then
            texto = texto + "-" + e.KeyChar
            TxtNumIdent.Text = texto
            e.Handled = True
            TxtNumIdent.Select(TxtNumIdent.Text.Length, 0)

        ElseIf TxtNumIdent.Text.Length = 9 Then
            texto = texto + "-" + e.KeyChar
            TxtNumIdent.Text = texto
            e.Handled = True
            TxtNumIdent.Select(TxtNumIdent.Text.Length, 0)
        End If


    End Sub

    Private Sub CboSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSexo.SelectedIndexChanged
        If CboSexo.Text <> "--Seleccione--" Then
            EpMensaje.SetError(CboSexo, "")
            CboSexo.BackColor = Color.White
        End If
    End Sub

    Private Sub CboCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCiudad.SelectedIndexChanged
        If CboCiudad.Text <> "--Seleccione--" Then
            EpMensaje.SetError(CboCiudad, "")
            CboCiudad.BackColor = Color.White
        End If
    End Sub

    Private Sub RdbPorNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPorNombre.CheckedChanged
        TxtBuscarPorNombre.Visible = True
        TxtBuscarPorNombre.Focus()
        TxtBuscarPorCodigo.Visible = False
    End Sub

    Private Sub RdbPorIdentidad_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPorIdentidad.CheckedChanged
        TxtBuscarPorCodigo.Visible = True
        TxtBuscarPorCodigo.Focus()
        TxtBuscarPorNombre.Visible = False
    End Sub

    Private Sub TxtBuscarPorCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarPorCodigo.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "-")
        End If

        Dim texto As String = TxtBuscarPorCodigo.Text
        If TxtBuscarPorCodigo.Text.Length = 4 Then
            texto = texto + "-" + e.KeyChar
            TxtBuscarPorCodigo.Text = texto
            e.Handled = True
            TxtBuscarPorCodigo.Select(TxtBuscarPorCodigo.Text.Length, 0)

        ElseIf TxtBuscarPorCodigo.Text.Length = 9 Then
            texto = texto + "-" + e.KeyChar
            TxtBuscarPorCodigo.Text = texto
            e.Handled = True
            TxtBuscarPorCodigo.Select(TxtBuscarPorCodigo.Text.Length, 0)
        End If
    End Sub

    Private Sub TxtBuscarPorCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarPorCodigo.TextChanged
        BuscarClientePorIdentidad()
        BtnLimpiar.Visible = True
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtBuscarPorCodigo.Clear()
        TxtBuscarPorNombre.Clear()

        If TxtBuscarPorCodigo.Visible = True Then
            TxtBuscarPorCodigo.Focus()
        Else
            TxtBuscarPorNombre.Focus()

        End If
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs)
        FrmTipoExamen.TxtNumIdenCliente.Text = LsvCliente.FocusedItem.SubItems(0).Text
        Close()
    End Sub
End Class
