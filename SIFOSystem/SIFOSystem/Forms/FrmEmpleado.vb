﻿Imports System.Data.SqlClient

Public Class FrmEmpleado


    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                              ByVal Guardar As Boolean,
                              ByVal Modificar As Boolean,
                              ByVal Cancelar As Boolean)
        BtnAgregar.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
    End Sub
    Private Sub LlenarComboSexo()
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
                MessageBox.Show("Error al Mostrar los datos de sexo" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub
    Private Sub LlenarComboCiudad()
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
                MessageBox.Show("Error al Mostrar los datos de Ciudad" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub
    Private Sub LlenarComboCargoEmpleado()
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

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "CargoEmpleado")
                CboCargoEmpleado.DataSource = Ds.Tables(0)

                CboCargoEmpleado.DisplayMember = Ds.Tables(0).Columns("CargoEmpleado").ToString
                CboCargoEmpleado.ValueMember = Ds.Tables(0).Columns("IdCargoEmpleado").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos de cargo empleado" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub GbxExamen_Enter(sender As Object, e As EventArgs) Handles GbxExamen.Enter
        HabilitarBotones(True, False, False, False)
    End Sub



    Private Sub GuardarEmpleado()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumIdentEmpleado", SqlDbType.VarChar, 15).Value = TxtNumIdent.Text
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = TxtTelefono.Text
                    .Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = DtpFechaNac.Value.ToShortDateString
                    .Parameters.Add("@FechaContratacion", SqlDbType.Date).Value = DtpFechaContra.Value.ToShortDateString
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(CboCiudad.SelectedValue)
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .Parameters.Add("@IdCargoEmpleado", SqlDbType.Int).Value = CInt(CboCargoEmpleado.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar empleado", "SIFO" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()
    End Sub

    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim VerEmpleados As SqlDataReader
                VerEmpleados = CMd.ExecuteReader()

                LsvEmpleados.Items.Clear()
                While VerEmpleados.Read = True
                    With LsvEmpleados.Items.Add(VerEmpleados("NumIdentEmpleado").ToString)
                        .SubItems.Add(VerEmpleados("Nombre").ToString)
                        .SubItems.Add(VerEmpleados("Apellidos").ToString)
                        .SubItems.Add(VerEmpleados("Direccion").ToString)
                        .SubItems.Add(VerEmpleados("Telefono").ToString)
                        .SubItems.Add(VerEmpleados("FechaNacimiento").ToString)
                        .SubItems.Add(VerEmpleados("FechaContratacion").ToString)
                        .SubItems.Add(VerEmpleados("Sexo").ToString)
                        .SubItems.Add(VerEmpleados("NombreCiudad").ToString)
                        .SubItems.Add(VerEmpleados("CargoEmpleado").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            GuardarEmpleado()
            HabilitarBotones(True, False, False, False)
            MostrarTodo()
            Limpiar()
        End If

    End Sub

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        HabilitarBotones(False, True, False, True)
        LlenarComboCargoEmpleado()
        LlenarComboCiudad()
        LlenarComboSexo()

    End Sub

    Private Sub BtnSalir_Click_1(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        HabilitarBotones(True, False, False, False)

        ActualizarEmpleado()
        Limpiar()

        MostrarTodo()
    End Sub
    Private Sub Limpiar()
        TxtNumIdent.Clear()
        TxtNombre.Clear()
        TxtApellidos.Clear()
        TxtTelefono.Clear()
        TxtDireccion.Clear()
        CboCargoEmpleado.Text = Nothing
        CboCiudad.Text = Nothing
        CboSexo.Text = Nothing

        TxtNumIdent.BackColor = Color.White
        TxtNombre.BackColor = Color.White
        TxtApellidos.BackColor = Color.White
        TxtTelefono.BackColor = Color.White
        TxtDireccion.BackColor = Color.White
        CboCargoEmpleado.BackColor = Color.White
        CboCiudad.BackColor = Color.White
        CboSexo.BackColor = Color.White

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        LlenarComboCargoEmpleado()
        LlenarComboCiudad()
        LlenarComboSexo()
        TxtNumIdent.Text = LsvEmpleados.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvEmpleados.FocusedItem.SubItems(1).Text
        TxtApellidos.Text = LsvEmpleados.FocusedItem.SubItems(2).Text
        TxtDireccion.Text = LsvEmpleados.FocusedItem.SubItems(3).Text
        TxtTelefono.Text = LsvEmpleados.FocusedItem.SubItems(4).Text
        DtpFechaNac.Text = LsvEmpleados.FocusedItem.SubItems(5).Text
        DtpFechaContra.Text = LsvEmpleados.FocusedItem.SubItems(6).Text
        CboSexo.Text = LsvEmpleados.FocusedItem.SubItems(7).Text
        CboCiudad.Text = LsvEmpleados.FocusedItem.SubItems(8).Text
        CboCargoEmpleado.Text = LsvEmpleados.FocusedItem.SubItems(9).Text

        TxtNombre.Focus()
        HabilitarBotones(False, False, True, True)


        TcEmpleados.SelectedIndex = 0
        TxtNumIdent.Enabled = False

    End Sub
    Private Sub ActualizarEmpleado()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    ' Enviar el parametro del nombre del empleado
                    .Parameters.Add("@NumIdentEmpleado", SqlDbType.VarChar, 15).Value = TxtNumIdent.Text
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = TxtTelefono.Text
                    .Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = DtpFechaNac.Value.ToShortDateString
                    .Parameters.Add("@FechaContratacion", SqlDbType.Date).Value = DtpFechaContra.Value.ToShortDateString
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(CboCiudad.SelectedValue)
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CInt(CboSexo.SelectedValue)
                    .Parameters.Add("@IdCargoEmpleado", SqlDbType.Int).Value = CInt(CboCargoEmpleado.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Actualizado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la categoria", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    Private Sub EliminarEmpleado()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As String
                    Id = LsvEmpleados.FocusedItem.SubItems(0).Text
                    .Parameters.Add("@NumIdentEmpleado", SqlDbType.VarChar, 15).Value = Id
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
        EliminarEmpleado()
        MostrarTodo()
    End Sub

    Private Sub BuscarEmpleadoPorNombre()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "SP_MostrarEmpleadoPorNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarEmpleado.Text

                End With

                Dim VerCliente As SqlDataReader
                VerCliente = CMd.ExecuteReader

                LsvEmpleados.Items.Clear()
                While VerCliente.Read = True
                    With LsvEmpleados.Items.Add(VerCliente("NumIdentEmpleado").ToString)
                        .SubItems.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellidos").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("FechaDeNacimiento").ToString)
                        .SubItems.Add(VerCliente("FechaDeContratacion").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("NombreCiudad").ToString)
                        .SubItems.Add(VerCliente("CargoEmpleado").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar el Empleado" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub
    Private Function ValidarTextBox() As Boolean
        Dim Estado As Boolean
        If TxtNumIdent.Text = Nothing And TxtNombre.Text = Nothing And TxtApellidos.Text = Nothing And
            TxtDireccion.Text = Nothing And TxtTelefono.Text = Nothing And CboSexo.SelectedValue = -1 And
            CboCiudad.SelectedValue = -1 And CboCargoEmpleado.SelectedValue = -1 Then
            EpMensaje.SetError(TxtNumIdent, "Ingrese el numero de identtidad")
            EpMensaje.SetError(TxtNombre, "Ingrese el nombre del empleado")
            EpMensaje.SetError(TxtApellidos, "Ingrese los apellidos del empleado")
            EpMensaje.SetError(TxtDireccion, "Ingrese la direccion")
            EpMensaje.SetError(TxtTelefono, "Ingrese el telefono")
            EpMensaje.SetError(CboSexo, "Seleccione el sexo")
            EpMensaje.SetError(CboCargoEmpleado, "seleccione el cargo del empleado")
            EpMensaje.SetError(CboCiudad, "seleccione la ciudad")
            Estado = False
            TxtNumIdent.Focus()
        ElseIf TxtNumIdent.Text = Nothing Then
            EpMensaje.SetError(TxtNumIdent, "Ingrese el numero de identtidad")
            TxtNumIdent.BackColor = Color.LightBlue
            TxtNumIdent.Focus()
            Estado = False

        ElseIf TxtNombre.Text = Nothing Then
            EpMensaje.SetError(TxtNombre, "Ingrese el nombre del empleado")
            TxtNombre.BackColor = Color.LightBlue
            TxtNombre.Focus()
            Estado = False

        ElseIf TxtApellidos.Text = Nothing Then
            EpMensaje.SetError(TxtApellidos, "Ingrese los apellidos del empleado")
            TxtApellidos.BackColor = Color.LightBlue
            TxtApellidos.Focus()
            Estado = False

        ElseIf TxtTelefono.Text = Nothing Then
            EpMensaje.SetError(TxtTelefono, "Ingrese el telefono")
            TxtTelefono.BackColor = Color.LightBlue
            TxtTelefono.Focus()
            Estado = False

        ElseIf TxtDireccion.Text = Nothing Then
            EpMensaje.SetError(TxtDireccion, "Ingrese la direccion")
            TxtDireccion.BackColor = Color.LightBlue
            TxtDireccion.Focus()
            Estado = False

        ElseIf CboCargoEmpleado.SelectedValue = -1 Then
            EpMensaje.SetError(CboCargoEmpleado, "Seleccione el cargo del empleado")
            CboCargoEmpleado.BackColor = Color.LightBlue
            CboCargoEmpleado.Focus()
            Estado = False

        ElseIf CboSexo.SelectedValue = -1 Then
            EpMensaje.SetError(CboSexo, "Seleccione el sexo del empleado")
            CboSexo.BackColor = Color.LightBlue
            CboSexo.Focus()
            Estado = False

        ElseIf CboCargoEmpleado.SelectedValue = -1 Then
            EpMensaje.SetError(CboCargoEmpleado, "Seleccione el cargo del empleado")
            CboCargoEmpleado.BackColor = Color.LightBlue
            CboCargoEmpleado.Focus()
            Estado = False
        Else

            EpMensaje.SetError(TxtNumIdent, "")
            EpMensaje.SetError(TxtNombre, "")
            EpMensaje.SetError(TxtApellidos, "")
            EpMensaje.SetError(TxtDireccion, "")
            EpMensaje.SetError(TxtTelefono, "")
            EpMensaje.SetError(CboSexo, "")
            EpMensaje.SetError(CboCargoEmpleado, "")
            EpMensaje.SetError(CboCiudad, "")
            Estado = True

        End If


        Return Estado
    End Function

    Private Sub TxtBuscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarEmpleado.TextChanged
        BuscarEmpleadoPorNombre()
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
End Class