Imports System.Data.SqlClient
Public Class FrmProducto

    Private Sub InvestigarCorrelaticoProducto()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarProducto As New SqlCommand("Sp_InvestigarCorrelativoProducto", Cn)
            ListarProducto.CommandType = CommandType.StoredProcedure
            Dim ListarProductoR As SqlDataReader
            Cn.Open()
            ListarProductoR = ListarProducto.ExecuteReader()

            If ListarProductoR.Read = True Then
                If ListarProductoR("IdProducto") = 1 Then
                    TxtCodigoProducto.Text = 1
                Else
                    TxtCodigoProducto.Text = ListarProductoR("IdProducto").ToString
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al investigar el correlativo los datos", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub


    Private Sub LlenarComboBoxCategoria()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_MostrarCategoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim Da As New SqlDataAdapter(Cmd)

                Dim Ds As New DataSet
                Da.Fill(Ds, "Categoria")
                CboCategoria.DataSource = Ds.Tables(0)


                CboCategoria.DisplayMember = Ds.Tables(0).Columns("NombreCategoria").ToString
                CboCategoria.ValueMember = Ds.Tables(0).Columns("IdCategoria").ToString


                CboCategoria.Text = "--Select--"

            Catch ex As Exception
                MessageBox.Show("Error al llenar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarTodoProducto()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_MostrarProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim VerProducto As SqlDataReader
                VerProducto = Cmd.ExecuteReader()

                LsvProducto.Items.Clear()
                While VerProducto.Read = True
                    With LsvProducto.Items.Add(VerProducto("IdProducto").ToString)
                        .SubItems.Add(VerProducto("NombreProducto").ToString)
                        .SubItems.Add(VerProducto("PrecioCosto").ToString)
                        .SubItems.Add(VerProducto("PrecioVenta").ToString)
                        .SubItems.Add(VerProducto("Stock").ToString)
                        .SubItems.Add(VerProducto("NombreCategoria").ToString)

                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los productos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub GuardarProducto()

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn



                    .Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 50).Value = TxtNombreProducto.Text
                    .Parameters.Add("@PrecioCosto", SqlDbType.Money).Value = TxtPrecioCosto.Text
                    .Parameters.Add("@PrecioVenta", SqlDbType.Money).Value = TxtPrecioVenta.Text
                    .Parameters.Add("@Stock", SqlDbType.Int).Value = TxtStock.Text
                    .Parameters.Add("@IdCategoria", SqlDbType.Int).Value = CInt(CboCategoria.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos del producto", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodoProducto()
        HabilitarBotones(True, False, False, False)
    End Sub

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                                 ByVal Guardar As Boolean,
                                 ByVal Modificar As Boolean,
                                 ByVal Limpiar As Boolean)

        BtnAgregar.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnLimpiar.Enabled = Limpiar


    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        HabilitarBotones(False, True, False, True)
        LlenarComboBoxCategoria()
        Limpiar()
        InvestigarCorrelaticoProducto()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTexBox() = True Then
            HabilitarBotones(True, False, False, False)
            GuardarProducto()
            MostrarTodoProducto()
            Limpiar()
        End If


    End Sub
    Private Sub Limpiar()
        TxtNombreProducto.Text = Nothing
        TxtCodigoProducto.Text = Nothing
        TxtPrecioCosto.Text = Nothing
        TxtPrecioVenta.Text = Nothing
        TxtStock.Text = Nothing
        CboCategoria.Text = "--Seleccione--"
    End Sub

    Private Sub ActualizarPorducto()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del genero musical

                    .Parameters.Add("@IdProducto", SqlDbType.Int).Value = CInt(TxtCodigoProducto.Text)
                    .Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 50).Value = TxtNombreProducto.Text
                    .Parameters.Add("@PrecioCosto", SqlDbType.Money).Value = CInt(TxtPrecioCosto.Text)
                    .Parameters.Add("@PrecioVenta", SqlDbType.Money).Value = CInt(TxtPrecioVenta.Text)
                    .Parameters.Add("@Stock", SqlDbType.Int).Value = CInt(TxtStock.Text)
                    .Parameters.Add("@IdCategoria", SqlDbType.Int).Value = CInt(CboCategoria.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Actualizado Satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el producto", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        HabilitarBotones(True, False, False, True)
        ActualizarPorducto()
        MostrarTodoProducto()

        TcOpcion.SelectedIndex = 1

    End Sub
    Private Sub BuscarProductoPorCodigo()

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_BuscarProductoPorCodigo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.Char, 4).Value = TxtBuscarPorCodigo.Text

                End With

                Dim VerProducto As SqlDataReader
                VerProducto = Cmd.ExecuteReader()

                LsvProducto.Items.Clear()
                While VerProducto.Read = True
                    With LsvProducto.Items.Add(VerProducto("IdProducto").ToString)
                        .SubItems.Add(VerProducto("NombreProducto").ToString)
                        .SubItems.Add(VerProducto("PrecioCosto").ToString)
                        .SubItems.Add(VerProducto("PrecioVenta").ToString)
                        .SubItems.Add(VerProducto("Stock").ToString)
                        .SubItems.Add(VerProducto("NombreCategoria").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtBuscarPorCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarPorCodigo.TextChanged
        BuscarProductoPorCodigo()


    End Sub

    Private Sub RdbPorNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPorNombre.CheckedChanged
        BtnBuscar.Visible = False
        TxtPorNombre.Visible = True
        TxtBuscarPorCodigo.Visible = False
    End Sub
    Private Sub BuscarProductoPorNombre()

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using Cmd As New SqlCommand
            Cn.Open()
            Try
                With Cmd
                    .CommandText = "Sp_BuscarProductoPorNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtPorNombre.Text

                End With

                Dim VerProducto As SqlDataReader
                VerProducto = Cmd.ExecuteReader()

                LsvProducto.Items.Clear()
                While VerProducto.Read = True
                    With LsvProducto.Items.Add(VerProducto("IdProducto").ToString)
                        .SubItems.Add(VerProducto("NombreProducto").ToString)
                        .SubItems.Add(VerProducto("PrecioCosto").ToString)
                        .SubItems.Add(VerProducto("PrecioVenta").ToString)
                        .SubItems.Add(VerProducto("Stock").ToString)
                        .SubItems.Add(VerProducto("NombreCategoria").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtPorNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtPorNombre.TextChanged
        BuscarProductoPorNombre()

    End Sub

    Private Sub RdbPorCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPorCodigo.CheckedChanged
        BtnBuscar.Visible = True
        TxtPorNombre.Visible = False
        TxtBuscarPorCodigo.Visible = True
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodigoProducto.Text = LsvProducto.FocusedItem.SubItems(0).Text
        TxtNombreProducto.Text = LsvProducto.FocusedItem.SubItems(1).Text
        TxtPrecioCosto.Text = LsvProducto.FocusedItem.SubItems(2).Text
        TxtPrecioVenta.Text = LsvProducto.FocusedItem.SubItems(3).Text
        TxtStock.Text = LsvProducto.FocusedItem.SubItems(4).Text
        CboCategoria.Text = LsvProducto.FocusedItem.SubItems(5).Text

        HabilitarBotones(False, False, True, True)

        TcOpcion.SelectedIndex = 0
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarProducto()
        MostrarTodoProducto()

    End Sub


    Private Sub EliminarProducto()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarProducto"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del genero musical

                    Dim Id As Integer
                    Id = CInt(LsvProducto.FocusedItem.SubItems(0).Text)

                    .Parameters.Add("@IdProducto", SqlDbType.Int).Value = Id

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro ELIMINADO satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos del artistas", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Function ValidarTexBox()

        Dim Estado As Boolean

        If TxtCodigoProducto.Text = Nothing And TxtNombreProducto.Text = Nothing And TxtPrecioCosto.Text = Nothing And TxtPrecioVenta.Text = Nothing And TxtStock.Text = Nothing And CboCategoria.SelectedValue = -1 Then
            EpMensage.SetError(TxtNombreProducto, "Ingrese el Nombre del producto")
            EpMensage.SetError(TxtPrecioCosto, "Ingrese el precio costo")
            EpMensage.SetError(TxtPrecioVenta, "Ingrese el precio venta")
            EpMensage.SetError(TxtStock, "Ingrese el Stock(Cantidad del producto)")
            EpMensage.SetError(CboCategoria, "Seleccione la categoria del producto")
            TxtNombreProducto.BackColor = Color.LightBlue
            TxtNombreProducto.Focus()
            Estado = False

        ElseIf TxtNombreProducto.Text = Nothing Then
            EpMensage.SetError(TxtNombreProducto, "Ingrese el nombre del producto")
            Estado = False
            TxtNombreProducto.BackColor = Color.LightBlue
            TxtNombreProducto.Focus()

        ElseIf TxtPrecioCosto.Text = Nothing Then
            EpMensage.SetError(TxtPrecioCosto, "Ingrese el Nombre del Artista")
            Estado = False
            TxtPrecioCosto.BackColor = Color.LightBlue
            TxtPrecioCosto.Focus()

        ElseIf TxtPrecioVenta.Text = Nothing Then
            EpMensage.SetError(TxtPrecioVenta, "Ingrese el precio venta")
            Estado = False
            TxtPrecioVenta.BackColor = Color.LightBlue
            TxtPrecioVenta.Focus()

        ElseIf TxtStock.Text = Nothing Then
            EpMensage.SetError(TxtStock, "Ingrese el Stock(Cantidad del producto)")
            Estado = False
            TxtStock.BackColor = Color.LightBlue
            TxtStock.Focus()

        ElseIf CboCategoria.SelectedValue = -1 Then
            EpMensage.SetError(CboCategoria, "Seleccione la categoria del producto")
            Estado = False
            CboCategoria.BackColor = Color.LightBlue
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class