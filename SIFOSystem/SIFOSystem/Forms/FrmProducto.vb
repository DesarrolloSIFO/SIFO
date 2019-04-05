Imports System.Data.SqlClient
Public Class FrmProducto

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
                CboStock.DataSource = Ds.Tables(0)
                CboStock.DisplayMember = Ds.Tables(0).Columns("NombreCategoria").ToString
                CboStock.ValueMember = Ds.Tables(0).Columns("IdCategoria").ToString

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

                LsvMostrarProducto.Items.Clear()
                While VerProducto.Read = True
                    With LsvMostrarProducto.Items.Add(VerProducto("IdProducto").ToString)
                        .SubItems.Add(VerProducto("NombreProducto").ToString)
                        .SubItems.Add(VerProducto("PrecioCosto").ToString)
                        .SubItems.Add(VerProducto("PrecioVenta").ToString)
                        .SubItems.Add(VerProducto("Stock").ToString)
                        .SubItems.Add(VerProducto("Categoria").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                    ' Enviar el parámet

                    .Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 50).Value = TxtNombreProducto.Text
                    .Parameters.Add("@PrecioCosto", SqlDbType.Money).Value = TxtPrecioCosto.Text
                    .Parameters.Add("@PrecioVenta", SqlDbType.Money).Value = TxtPrecioVenta.Text
                    .Parameters.Add("@Stock", SqlDbType.Int).Value = CInt(CboStock.SelectedValue)
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

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        GuardarProducto()
        HabilitarBotones(True, False, False, False)
        MostrarTodoProducto()
    End Sub



End Class