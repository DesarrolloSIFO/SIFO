Imports System.Data.SqlClient

Public Class FrmCargoEmpleado
    Private Sub InvestigarCorrelativoCargo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListaCargos As New SqlCommand("Sp_InvestigarCorrelativoCargoEmpleado", Cn)
            ListaCargos.CommandType = CommandType.StoredProcedure
            Dim ListarCargosR As SqlDataReader
            Cn.Open()
            ListarCargosR = ListaCargos.ExecuteReader()

            If ListarCargosR.Read = True Then
                If ListarCargosR("IdCargoEmpleado") Is "" Then
                    TxtCodCargo.Text = 1
                Else
                    TxtCodCargo.Text = ListarCargosR("IdCargoEmpleado").ToString
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub GuardarCargoEmpleado()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarCargoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CargoEmpleado", SqlDbType.NVarChar, 40).Value = TxtCargoEmpleado.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar el cargo" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    Private Sub ActualizarCargoEmpleado()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarCargoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CargoEmpleado", SqlDbType.NVarChar, 40).Value = TxtCargoEmpleado.Text
                    .Parameters.Add("@IdCargoEmpleado", SqlDbType.Int).Value = CInt(TxtCodCargo.Text)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el Cargo" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarCargoEmpleado()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarCargoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer
                    Id = CInt(LsvCargos.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdCargoEmpleado", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el Cargo", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtCargoEmpleado.Text = Nothing Then
            EpMensajeCargo.SetError(TxtCargoEmpleado, "Tiene que ingresar el Cargo")
            TxtCargoEmpleado.Focus()
            TxtCargoEmpleado.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensajeCargo.SetError(TxtCargoEmpleado, "")

        End If
        Return Estado
    End Function

    Private Sub Limpiar()
        TxtCodCargo.Text = Nothing
        TxtCargoEmpleado.Text = Nothing
    End Sub

    Private Sub TxtCargoEmpleado_TextChanged(sender As Object, e As EventArgs) Handles TxtCargoEmpleado.TextChanged
        If TxtCargoEmpleado.Text <> Nothing Then
            EpMensajeCargo.SetError(TxtCargoEmpleado, "")
            TxtCargoEmpleado.BackColor = Color.White
        End If
    End Sub

    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarCargoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerCargos As SqlDataReader
                VerCargos = CMd.ExecuteReader

                LsvCargos.Items.Clear()
                While VerCargos.Read = True
                    With LsvCargos.Items.Add(VerCargos("IdCargoEmpleado").ToString)
                        .SubItems.Add(VerCargos("CargoEmpleado").ToString)
                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar los Cargos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnModificar.Enabled = Modificar
        BtnGuardar.Enabled = Guardar
        BtnCancelar.Enabled = Cancelar
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativoCargo()

        TxtCargoEmpleado.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        HabilitarBotones(True, False, False, False)
        If ValidarTextBox() = True Then
            If ExisteCargo() = False Then
                GuardarCargoEmpleado()
                HabilitarBotones(True, False, False, False)
                MostrarTodo()
                Limpiar()
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, True)
            ActualizarCargoEmpleado()
            MostrarTodo()
            Limpiar()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)

        Limpiar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodCargo.Text = LsvCargos.FocusedItem.SubItems(0).Text
        TxtCargoEmpleado.Text = LsvCargos.FocusedItem.SubItems(1).Text
        TbMenu.SelectedIndex = 0
        HabilitarBotones(False, False, True, True)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarCargoEmpleado()
        MostrarTodo()

        HabilitarBotones(True, False, False, False)
    End Sub

    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Function ExisteCargo() As Boolean
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Dim Estado As Boolean = False
        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ExisteCargo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CargoEmpleado", SqlDbType.NVarChar, 40).Value = TxtCargoEmpleado.Text.Trim

                End With

                Dim Existe As Integer = Cmd.ExecuteScalar()

                If Existe <> 0 Then
                    Estado = True
                    MessageBox.Show("Ya esta esta registrado el cargo" + " " + TxtCargoEmpleado.Text, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al almacenar el registrio" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

        Return Estado
    End Function
End Class