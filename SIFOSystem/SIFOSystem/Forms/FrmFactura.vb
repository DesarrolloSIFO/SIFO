Imports System.Data.SqlClient

Public Class Form

    Private Sub InvestigarCorrelativoFactura()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarFactura As New SqlCommand("Sp_InvestigarCorrelativoFactura", Cn)
            ListarFactura.CommandType = CommandType.StoredProcedure

            Dim ListarFacturaR As SqlDataReader
            Cn.Open()
            ListarFacturaR = ListarFactura.ExecuteReader()

            If ListarFacturaR.Read = True Then
                If ListarFacturaR("IdFactura") Is DBNull.Value Then
                    TxtCodFactura.Text = 1
                Else
                    TxtCodFactura.Text = ListarFacturaR("IdFactura").ToString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Consultar los Datos", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub MostrarFacturas()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarTodoFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim VerFactura As SqlDataReader
                VerFactura = CMd.ExecuteReader()

                LsvDetalleFac.Items.Clear()
                While VerFactura.Read = True
                    With LsvDetalleFac.Items.Add(VerFactura("IdFactura").ToString)
                        .SubItems.Add(VerFactura("NumIdentCliente").ToString)
                        .SubItems.Add(VerFactura("TipoExamen").ToString)
                        .SubItems.Add(VerFactura("FechaFactura").ToString)
                        .SubItems.Add(VerFactura("UserName").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub


    Private Sub GuardarFactura()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = TxtNumIdentCliente.Text
                    .Parameters.Add("@IdTipoExamen", SqlDbType.Int).Value = CInt(CboTipoExamen.SelectedValue)
                    .Parameters.Add("@FechaFactura", SqlDbType.Date).Value = DtpFechaFactura.Value.Date.ToShortDateString()
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboIdUsuario.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub LlenarComboUsuario()
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

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "Usuario")
                CboIdUsuario.DataSource = Ds.Tables(0)

                CboIdUsuario.DisplayMember = Ds.Tables(0).Columns("UserName").ToString
                CboIdUsuario.ValueMember = Ds.Tables(0).Columns("IdUsuario").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub


    Private Sub LlenarComboTipoExamen()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarTipoExamen"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "TipoExamen")
                CboTipoExamen.DataSource = Ds.Tables(0)

                CboTipoExamen.DisplayMember = Ds.Tables(0).Columns("TipoExamen").ToString
                CboTipoExamen.ValueMember = Ds.Tables(0).Columns("IdTipoExamen").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos TipoExamen" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativoFactura()
        LlenarComboTipoExamen()
        LlenarComboUsuario()
    End Sub

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                                ByVal Guardar As Boolean,
                                ByVal Modificar As Boolean,
                                ByVal Cancelar As Boolean,
                                ByVal Salir As Boolean)
        BtnAgregar.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        BtnSalir.Enabled = Salir
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, True, True)
            GuardarFactura()
            MostrarFacturas()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True)
        Limpiar()
    End Sub

    Private Sub Limpiar()
        TxtNumIdentCliente.Clear()
        TxtCodFactura.Clear()
        CboTipoExamen.Text = "--Seleccione--"
        CboIdUsuario.Text = "--Seleccione--"
    End Sub

    Private Sub ActualizarFactura()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@IdFactura", SqlDbType.Int).Value = TxtCodFactura.Text
                    .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = TxtNumIdentCliente.Text
                    .Parameters.Add("@IdTipoExamen", SqlDbType.Int).Value = CInt(CboTipoExamen.SelectedValue)
                    .Parameters.Add("@FechaFactura", SqlDbType.Date).Value = DtpFechaFactura.Value.Date.ToShortDateString()
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboIdUsuario.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro modificado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al modificar el registro" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarFacturas()
    End Sub

    Private Sub EliminarFactura()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    Dim Id As Integer
                    Id = CInt(LsvDetalleFac.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdFactura", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Eliminado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al elimnar la Factura", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        HabilitarBotones(False, False, True, True, True)
        TxtCodFactura.Text = LsvDetalleFac.FocusedItem.SubItems(0).Text
        TxtNumIdentCliente.Text = LsvDetalleFac.FocusedItem.SubItems(1).Text
        CboTipoExamen.Text = LsvDetalleFac.FocusedItem.SubItems(2).Text
        DtpFechaFactura.Value = LsvDetalleFac.FocusedItem.SubItems(3).Text
        CboIdUsuario.Text = LsvDetalleFac.FocusedItem.SubItems(4).Text

        TpMenuFact.SelectedIndex = 0
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        HabilitarBotones(False, False, True, True, True)
        ActualizarFactura()
        MostrarFacturas()

        TpMenuFact.SelectedIndex = 1
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarFactura()
        MostrarFacturas()
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtNumIdentCliente.Text = Nothing And CboIdUsuario.SelectedValue = -1 And CboTipoExamen.SelectedValue = -1 Then
            EpMensajeFact.SetError(TxtNumIdentCliente, "Ingrese el numero de identidad del cliente")
            EpMensajeFact.SetError(CboIdUsuario, "Seleccione el usuario")
            EpMensajeFact.SetError(CboTipoExamen, "Seleccione el Tipo de Examen")
            Estado = False
        ElseIf TxtNumIdentCliente.Text = Nothing Then
            EpMensajeFact.SetError(TxtNumIdentCliente, "Ingrese el numero de identidad del cliente")
            TxtNumIdentCliente.BackColor = Color.LightBlue
            TxtNumIdentCliente.Focus()
            Estado = False
        ElseIf CboIdUsuario.SelectedValue = -1 Then
            EpMensajeFact.SetError(CboIdUsuario, "Seleccione el usuario")
            Estado = False
        ElseIf CboTipoExamen.SelectedValue = -1 Then
            EpMensajeFact.SetError(CboTipoExamen, "Seleccione el Tipo de Examen")
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub BtnBuscarNumIdentCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarNumIdentCliente.Click
        FrmGestión.ShowDialog()
    End Sub
End Class