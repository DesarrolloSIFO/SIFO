Imports System.Data.SqlClient

Public Class FrmTipoExamen

        Private Sub InvestigarCorrelativoExamenCliente()
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If

            Try
            Dim ListarGenero As New SqlCommand("Sp_InvestigarCorrelativoExamenCliente", Cn)
            ListarGenero.CommandType = CommandType.StoredProcedure

                Dim ListarExamenR As SqlDataReader
                Cn.Open()
                ListarExamenR = ListarGenero.ExecuteReader()

                If ListarExamenR.Read = True Then
                    If ListarExamenR("IdExamenCliente") Is DBNull.Value Then
                        TxtCodExamenCliente.Text = 1
                    Else
                        TxtCodExamenCliente.Text = ListarExamenR("IdExamenCliente").ToString
                    End If
                End If
            Catch ex As Exception
            MessageBox.Show("Error al Consultar los Datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
                Cn.Close()
            End Try
        End Sub

        Private Sub MostrarExamenCliente()
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If

            Using CMd As New SqlCommand
                Cn.Open()
                Try
                    With CMd
                        .CommandText = "Sp_MostrarTodoExamenCliente"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Cn
                    End With

                    Dim VerExamen As SqlDataReader
                    VerExamen = CMd.ExecuteReader()

                    LsvExamenCliente.Items.Clear()
                    While VerExamen.Read = True
                        With LsvExamenCliente.Items.Add(VerExamen("IdExamenCliente").ToString)
                        .SubItems.Add(VerExamen("NumIdentCliente").ToString)
                        .SubItems.Add(VerExamen("FechaExamen").ToString)
                        .SubItems.Add(VerExamen("OI").ToString)
                        .SubItems.Add(VerExamen("OD").ToString)
                        .SubItems.Add(VerExamen("Adicion").ToString)
                        .SubItems.Add(VerExamen("DistanciaPupilar").ToString)
                        .SubItems.Add(VerExamen("TipoExamen").ToString)
                        .SubItems.Add(VerExamen("UserName").ToString)
                    End With
                    End While
                Catch ex As Exception
                    MessageBox.Show("Error al Mostrar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Cn.Close()
                End Try
            End Using
        End Sub

    Private Sub FrmTipoExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarExamenCliente()
        HabilitarBotones(True, False, False, False, True)
    End Sub


    Private Sub GuardarExamenCliente()
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If

            Try
                Cn.Open()
                Using Cmd As New SqlCommand
                    With Cmd
                        .CommandText = "Sp_InsertarExamenCliente"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Cn

                        .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = TxtNumIdenCliente.Text
                        .Parameters.Add("@FechaExamen", SqlDbType.Date).Value = DtpFechaExamen.Value.Date.ToShortDateString()
                        .Parameters.Add("@OI", SqlDbType.NVarChar, 20).Value = TxtOI.Text
                        .Parameters.Add("@OD", SqlDbType.NVarChar, 20).Value = TxtOD.Text
                        .Parameters.Add("@Adicion", SqlDbType.NVarChar, 30).Value = TxtAdicion.Text
                        .Parameters.Add("@DistanciaPupilar", SqlDbType.NVarChar, 15).Value = TxtDistanciaPupilar.Text
                        .Parameters.Add("@IdTipoExamen", SqlDbType.Int).Value = CInt(CboTipoExamen.SelectedValue)
                        .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)
                        .ExecuteNonQuery()

                        MessageBox.Show("Registro realizado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al insertar los datos del examen", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
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
                MessageBox.Show("Error al Mostrar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                    Cn.Close()
                End Try
            End Using
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

                    Da.Fill(Ds, "Ciudad")
                    CboUsuario.DataSource = Ds.Tables(0)

                    CboUsuario.DisplayMember = Ds.Tables(0).Columns("UserName").ToString
                    CboUsuario.ValueMember = Ds.Tables(0).Columns("IdUsuario").ToString

                Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                    Cn.Close()
                End Try
            End Using
        End Sub

        Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                                ByVal Guardar As Boolean,
                                ByVal Modificar As Boolean,
                                ByVal Cancelar As Boolean,
                                ByVal Salir As Boolean)
            BtnAgregar.Enabled = Nuevo
            BtnGuardar.Enabled = Guardar
            BtnModificar.Enabled = Modificar
            BtnLimpiar.Enabled = Cancelar
            BtnSalir.Enabled = Salir
        End Sub

        Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
            HabilitarBotones(False, True, False, True, True)
            InvestigarCorrelativoExamenCliente()
            LlenarComboTipoExamen()
            LlenarComboUsuario()
        End Sub


        Private Function ValidarTextBox()
            Dim Estado As Boolean

            If TxtNumIdenCliente.Text = Nothing And TxtOD.Text = Nothing And TxtOI.Text = Nothing And CboTipoExamen.SelectedValue = -1 And CboUsuario.SelectedValue = -1 And TxtAdicion.Text = Nothing And TxtDistanciaPupilar.Text = Nothing Then
                EpMensage.SetError(TxtNumIdenCliente, "Ingrese el numero de indentidad del cliente")
                EpMensage.SetError(TxtOD, "OD")
                EpMensage.SetError(TxtOD, "OI")
                EpMensage.SetError(TxtAdicion, "Ingrese la adicion")
                EpMensage.SetError(TxtDistanciaPupilar, "Ingrese la distancia pupilar")
                EpMensage.SetError(CboTipoExamen, "Seleccione el tipo de examen")
                EpMensage.SetError(CboUsuario, "Seleccione el usuario")
                Estado = False

            ElseIf TxtNumIdenCliente.Text = Nothing Then
                EpMensage.SetError(TxtNumIdenCliente, "Ingrese el numero de indentidad del cliente")
                Estado = False
                TxtNumIdenCliente.BackColor = Color.LightBlue
                TxtNumIdenCliente.Focus()

            ElseIf TxtOI.Text = Nothing Then
                EpMensage.SetError(TxtOD, "OI")
                Estado = False
                TxtOI.BackColor = Color.LightBlue
                TxtOI.Focus()

            ElseIf TxtOD.Text = Nothing Then
                EpMensage.SetError(TxtOD, "OD")
                Estado = False
                TxtOD.BackColor = Color.LightBlue
                TxtOD.Focus()

            ElseIf TxtAdicion.Text = Nothing Then
                EpMensage.SetError(TxtAdicion, "Ingrese la adicion")
                Estado = False
                TxtAdicion.BackColor = Color.LightBlue
                TxtAdicion.Focus()

            ElseIf TxtDistanciaPupilar.Text = Nothing Then
                EpMensage.SetError(TxtDistanciaPupilar, "Ingrese la distancia pupilar")
                Estado = False
                TxtDistanciaPupilar.BackColor = Color.LightBlue
                TxtDistanciaPupilar.Focus()

            ElseIf CboTipoExamen.SelectedValue = -1 Then
                EpMensage.SetError(CboTipoExamen, "Seleccione el tipo de examen")
                Estado = False
                CboTipoExamen.BackColor = Color.LightBlue

            ElseIf CboUsuario.SelectedValue = -1 Then
                EpMensage.SetError(CboUsuario, "Seleccione el Usuario")
                Estado = False
                CboUsuario.BackColor = Color.LightBlue
            Else
                Estado = True
            End If
            Return Estado
        End Function

        Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
            If ValidarTextBox() = True Then
                HabilitarBotones(True, False, False, False, True)
                GuardarExamenCliente()
                MostrarExamenCliente()
                Limpiar()
            End If
        End Sub

        Private Sub Limpiar()
            TxtDistanciaPupilar.Text = Nothing
            TxtNumIdenCliente.Text = Nothing
            TxtCodExamenCliente.Text = Nothing
            TxtOD.Text = Nothing
            TxtAdicion.Text = Nothing
            TxtOI.Text = Nothing
            CboTipoExamen.Text = "--Seleccione--"
            CboUsuario.Text = "--Seleccione--"
        End Sub

        Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
            Limpiar()
        End Sub

        Private Sub ActualizarExamenCliente()
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If

            Using CMd As New SqlCommand
                Cn.Open()
                Try
                    With CMd
                        .CommandText = "Sp_ActualizarExamenCliente"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Cn

                        .Parameters.Add("@IdExamenCliente", SqlDbType.Int).Value = TxtCodExamenCliente.Text
                        .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = TxtNumIdenCliente.Text
                        .Parameters.Add("@FechaExamen", SqlDbType.Date).Value = DtpFechaExamen.Value.Date.ToShortDateString()
                        .Parameters.Add("@OI", SqlDbType.NVarChar, 20).Value = TxtOI.Text
                        .Parameters.Add("@OD", SqlDbType.NVarChar, 20).Value = TxtOD.Text
                        .Parameters.Add("@Adicion", SqlDbType.NVarChar, 30).Value = TxtAdicion.Text
                        .Parameters.Add("@DistanciaPupilar", SqlDbType.NVarChar, 15).Value = TxtDistanciaPupilar.Text
                        .Parameters.Add("@IdTipoExamen", SqlDbType.Int).Value = CInt(CboTipoExamen.SelectedValue)
                        .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)
                        .ExecuteNonQuery()

                        MessageBox.Show("Actualizacion realizada Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End With

                Catch ex As Exception
                MessageBox.Show("Error al Actualizar los datos" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                    Cn.Close()
                End Try
            End Using
        End Sub

        Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
            HabilitarBotones(False, False, True, True, True)
            TxtCodExamenCliente.Text = LsvExamenCliente.FocusedItem.SubItems(0).Text
            TxtNumIdenCliente.Text = LsvExamenCliente.FocusedItem.SubItems(1).Text
        TxtOI.Text = LsvExamenCliente.FocusedItem.SubItems(3).Text
        TxtOD.Text = LsvExamenCliente.FocusedItem.SubItems(4).Text
        TxtAdicion.Text = LsvExamenCliente.FocusedItem.SubItems(5).Text
        TxtDistanciaPupilar.Text = LsvExamenCliente.FocusedItem.SubItems(6).Text
        CboTipoExamen.Text = LsvExamenCliente.FocusedItem.SubItems(7).Text
        CboUsuario.Text = LsvExamenCliente.FocusedItem.SubItems(8).Text
        DtpFechaExamen.Text = LsvExamenCliente.FocusedItem.SubItems(2).Text

        LlenarComboTipoExamen()
        LlenarComboUsuario()

        TabExamenCliente.SelectedIndex = 0
        End Sub

        Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
            HabilitarBotones(True, False, False, True, True)
            ActualizarExamenCliente()
            MostrarExamenCliente()

            TabExamenCliente.SelectedIndex = 1
        End Sub

        Private Sub EliminarExamenCliente()
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If

            Try
                Cn.Open()
                Using Cmd As New SqlCommand
                    With Cmd
                        .CommandText = "Sp_EliminarExamenCliente"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Cn


                        Dim Id As Integer
                        Id = CInt(LsvExamenCliente.FocusedItem.SubItems(0).Text)
                        .Parameters.Add("@IdExamenCliente", SqlDbType.Int).Value = Id
                        .ExecuteNonQuery()

                        MessageBox.Show("Registro Eliminado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al elimnar el ExamenCliente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Sub

        Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
            EliminarExamenCliente()
            MostrarExamenCliente()
        End Sub

        Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
            Close()
        End Sub

        Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        FrmBuscarCliente.ShowDialog()
    End Sub
End Class