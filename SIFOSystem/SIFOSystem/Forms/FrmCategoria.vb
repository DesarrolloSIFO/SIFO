Imports System.Data.SqlClient

Public Class FrmCategoria

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                              ByVal Guardar As Boolean,
                              ByVal Modificar As Boolean,
                              ByVal Cancelar As Boolean)
        BtnAgregar.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar

        BtnModificar.Enabled = Modificar

        BtnCancelar.Enabled = Cancelar
    End Sub
    Private Sub InvestigarCorrelativo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarGenero As New SqlCommand("Sp_InvestigarCorrelativoCategoria", Cn)
            ListarGenero.CommandType = CommandType.StoredProcedure

            Dim ListarGeneroR As SqlDataReader
            Cn.Open()
            ListarGeneroR = ListarGenero.ExecuteReader()

            If ListarGeneroR.Read = True Then
                If ListarGeneroR("IdCategoria") Is DBNull.Value Then
                    TxtCodCategoria.Text = 1
                Else
                    TxtCodCategoria.Text = ListarGeneroR("IdCategoria").ToString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Consultar los Datos en investigar correlativo" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativo()
        TxtNombreCategoria.Focus()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False)
            GuardarCategoria()
            Limpiar()
            MostrarTodo()
        End If



    End Sub
    Private Sub Limpiar()
        TxtNombreCategoria.Clear()
        TxtDescripcion.Clear()
        TxtCodCategoria.Clear()
    End Sub
    Private Sub GuardarCategoria()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarCategoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    ' Enviar el parametro del nombre de la categoria
                    .Parameters.Add("@NombreCategoria", SqlDbType.NVarChar, 30).Value = TxtNombreCategoria.Text
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 300).Value = TxtDescripcion.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar categoria", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub ActualizarCategoria()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarCategoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    ' Enviar el parametro del nombre de la categoria
                    .Parameters.Add("@NombreCategoria", SqlDbType.NVarChar, 30).Value = TxtNombreCategoria.Text
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 30).Value = TxtDescripcion.Text
                    .Parameters.Add("@IdCategoria", SqlDbType.Int).Value = TxtCodCategoria.Text
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
    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarCategoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim vercategorias As SqlDataReader
                vercategorias = CMd.ExecuteReader()

                LsvCategorias.Items.Clear()
                While vercategorias.Read = True
                    With LsvCategorias.Items.Add(vercategorias("IdCategoria").ToString)
                        .SubItems.Add(vercategorias("NombreCategoria").ToString)
                        .SubItems.Add(vercategorias("Descripcion").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar las categorias" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        HabilitarBotones(True, False, False, False)
        ActualizarCategoria()
        Limpiar()
        MostrarTodo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodCategoria.Text = LsvCategorias.FocusedItem.SubItems(0).Text
        TxtNombreCategoria.Text = LsvCategorias.FocusedItem.SubItems(1).Text
        TxtDescripcion.Text = LsvCategorias.FocusedItem.SubItems(2).Text
        TxtNombreCategoria.Focus()
        HabilitarBotones(False, False, True, True)

        TpCategorias.SelectedIndex = 0

    End Sub

    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
        HabilitarBotones(True, False, False, False)

    End Sub

    Private Sub EliminarCategoria()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarCategoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    ' Enviar el parametro del nombre de la categoria
                    Dim Id As Integer
                    Id = CInt(LsvCategorias.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdCategoria", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Categoria Eliminada Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al elimnar la categoria" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarCategoria()
        MostrarTodo()
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean
        If TxtNombreCategoria.Text = Nothing And TxtDescripcion.Text = Nothing Then
            EpMensaje.SetError(TxtNombreCategoria, "Primero debe ingresar datos")
            TxtNombreCategoria.Focus()
            TxtNombreCategoria.BackColor = Color.LightBlue
            TxtDescripcion.BackColor = Color.LightBlue

            Estado = False
        ElseIf TxtNombreCategoria.Text = Nothing Then
            EpMensaje.SetError(TxtNombreCategoria, "Ingrese el nombre de la categoria")
            TxtNombreCategoria.Focus()
            Estado = False
        ElseIf TxtDescripcion.Text = Nothing Then
            EpMensaje.SetError(TxtDescripcion, "Ingrese una descripcion a la categoria")
            TxtDescripcion.Focus()
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtNombreCategoria, "")

        End If
        Return Estado
    End Function

    Private Sub TxtNombreCategoria_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreCategoria.TextChanged
        If TxtNombreCategoria.Text <> Nothing Then
            EpMensaje.SetError(TxtNombreCategoria, "")
            TxtNombreCategoria.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged
        If TxtDescripcion.Text <> Nothing Then
            EpMensaje.SetError(TxtDescripcion, "")
            TxtDescripcion.BackColor = Color.White
        End If
    End Sub
    Private Sub BuscarCategoriaPorNombre()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarXCategoriaPorNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarCategoria.Text

                End With

                Dim VerCategorias As SqlDataReader
                VerCategorias = CMd.ExecuteReader

                LsvCategorias.Items.Clear()
                While VerCategorias.Read = True
                    With LsvCategorias.Items.Add(VerCategorias("IdCategoria").ToString)
                        .SubItems.Add(VerCategorias("NombreCategoria").ToString)
                        .SubItems.Add(VerCategorias("Descripcion").ToString)


                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar la categoria" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub TxtBuscarCategoria_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCategoria.TextChanged
        BuscarCategoriaPorNombre()
    End Sub
End Class