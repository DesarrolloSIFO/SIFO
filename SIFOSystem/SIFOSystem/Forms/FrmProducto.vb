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
                MessageBox.Show("Error al consultar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                        .SubItems.Add(VerProducto("Categoria").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los productos los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                    ' Enviar los parameters

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
        HabilitarBotones(True, False, False, False)
        MostrarTodoProducto()
        Limpiar()


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
                    .Parameters.Add("@PrecioCosto", SqlDbType.Money).Value = TxtPrecioCosto.Text
                    .Parameters.Add("@PrecioVenta", SqlDbType.Money).Value = TxtPrecioVenta.Text
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
End Class