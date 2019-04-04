Imports System.Data.SqlClient
Public Class FrmCiudad
    Private Sub InvestigarCorrelativoCiudad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListaCiudad As New SqlCommand("Sp_InvestigarCorrelativoCiudad", Cn)
            ListaCiudad.CommandType = CommandType.StoredProcedure
            Dim ListarCiudadR As SqlDataReader
            Cn.Open()
            ListarCiudadR = ListaCiudad.ExecuteReader()

            If ListarCiudadR.Read = True Then
                If ListarCiudadR("IdCiudad") Is "" Then
                    TxtCodCiudad.Text = 1
                Else
                    TxtCodCiudad.Text = ListarCiudadR("IdCiudad").ToString
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub GuardarCiudad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NombreCiudad", SqlDbType.NVarChar, 40).Value = TxtNombreCiudad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al insertar el Género Musical", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    Private Sub ActualizarCiudad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NombreCiudad", SqlDbType.NVarChar, 40).Value = TxtNombreCiudad.Text
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(TxtCodCiudad.Text)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al actualizar la ciudad", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarCiudad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer
                    Id = CInt(LsvCiudades.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar la ciudad", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtNombreCiudad.Text = Nothing Then
            EpMensajeCiudad.SetError(TxtNombreCiudad, "Tiene que ingresar la ciudad")
            TxtNombreCiudad.Focus()
            TxtNombreCiudad.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensajeCiudad.SetError(TxtNombreCiudad, "")

        End If
        Return Estado
    End Function

    Private Sub Limpiar()
        TxtCodCiudad.Text = Nothing
        TxtNombreCiudad.Text = Nothing
    End Sub

    Private Sub TxtNombreCiudad_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreCiudad.TextChanged
        If TxtNombreCiudad.Text <> Nothing Then
            EpMensajeCiudad.SetError(TxtNombreCiudad, "")
            TxtNombreCiudad.BackColor = Color.White
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
                    .CommandText = "Sp_MostrarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerCiudad As SqlDataReader
                VerCiudad = CMd.ExecuteReader

                LsvCiudades.Items.Clear()
                While VerCiudad.Read = True
                    With LsvCiudades.Items.Add(VerCiudad("IdCiudad").ToString)
                        .SubItems.Add(VerCiudad("NombreCiudad").ToString)
                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar las ciudades" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        InvestigarCorrelativoCiudad()

        TxtNombreCiudad.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        HabilitarBotones(True, False, False, False)

        If ValidarTextBox() = True Then
            GuardarCiudad()
            Limpiar()
            HabilitarBotones(True, False, False, False)
            MostrarTodo()
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, True)
            ActualizarCiudad()
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
End Class