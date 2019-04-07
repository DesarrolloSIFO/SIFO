Imports System.Data.SqlClient

Public Class Form
    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarFactura"
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
                        .SubItems.Add(VerFactura("IdUsuario").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                    .Parameters.Add("@IdFactura", SqlDbType.Int).Value = TxtCodFactura.Text
                    .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = TxtNumIdentCliente.Text
                    .Parameters.Add("@IdTipoExamen", SqlDbType.Int).Value = CInt(CboTipoExamen.SelectedValue)
                    .Parameters.Add("@FechaFactura", SqlDbType.Date).Value = DtpFechaFactura
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboIdUsuario.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
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
                MessageBox.Show("Error al Mostrar los datos", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        HabilitarBotones(False, True, False, True, True)
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
        HabilitarBotones(True, False, False, False, True)
        GuardarFactura()
        MostrarTodo()
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
                    .CommandText = "Sp_ModificarFactura"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@IdFactura", SqlDbType.Int).Value = TxtCodFactura.Text
                    .Parameters.Add("@NumIdentCliente", SqlDbType.VarChar, 15).Value = TxtNumIdentCliente.Text
                    .Parameters.Add("@IdTipoExamen", SqlDbType.Int).Value = CInt(CboTipoExamen.SelectedValue)
                    .Parameters.Add("@FechaFactura", SqlDbType.Date).Value = DtpFechaFactura
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ActualizarFactura()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class