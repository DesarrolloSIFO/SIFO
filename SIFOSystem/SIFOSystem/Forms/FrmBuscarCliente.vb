Imports System.Data.SqlClient
Public Class FrmBuscarCliente

    Private Sub BuscarClientePorNombre()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarClientePorNombre"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarNombre.Text

                End With

                Dim VerCliente As SqlDataReader
                VerCliente = CMd.ExecuteReader

                LsvCliente.Items.Clear()
                While VerCliente.Read = True
                    With LsvCliente.Items.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellidos").ToString)
                        .SubItems.Add(VerCliente("NumIdentCliente").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaDeNacimiento").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("NombreCiudad").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar el cliente" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarClientePorIdentidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarClientePorIdentidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarCodigo.Text

                End With

                Dim VerCliente As SqlDataReader
                VerCliente = CMd.ExecuteReader

                LsvCliente.Items.Clear()
                While VerCliente.Read = True
                    With LsvCliente.Items.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellidos").ToString)
                        .SubItems.Add(VerCliente("NumIdentCliente").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaDeNacimiento").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("NombreCiudad").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar el cliente" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub TxtBuscarNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarNombre.TextChanged
        BuscarClientePorNombre()
        BtnLimpiar.Visible = True
    End Sub

    Private Sub TxtBuscarCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCodigo.TextChanged
        BuscarClientePorIdentidad()
        BtnLimpiar.Visible = True
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtBuscarCodigo.Clear()
        TxtBuscarNombre.Clear()

        If TxtBuscarCodigo.Visible = True Then
            TxtBuscarCodigo.Focus()
        Else
            TxtBuscarNombre.Focus()

        End If
    End Sub

    Private Sub TxtBuscarCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarCodigo.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "-")
        End If

        Dim texto As String = TxtBuscarCodigo.Text
        If TxtBuscarCodigo.Text.Length = 4 Then
            texto = texto + "-" + e.KeyChar
            TxtBuscarCodigo.Text = texto
            e.Handled = True
            TxtBuscarCodigo.Select(TxtBuscarCodigo.Text.Length, 0)

        ElseIf TxtBuscarCodigo.Text.Length = 9 Then
            texto = texto + "-" + e.KeyChar
            TxtBuscarCodigo.Text = texto
            e.Handled = True
            TxtBuscarCodigo.Select(TxtBuscarCodigo.Text.Length, 0)
        End If
    End Sub

    Private Sub RdbPorNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPorNombre.CheckedChanged
        TxtBuscarNombre.Visible = True
        TxtBuscarCodigo.Visible = False
    End Sub

    Private Sub RdbPorIdentidad_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPorIdentidad.CheckedChanged
        TxtBuscarCodigo.Visible = True
        TxtBuscarNombre.Visible = False
    End Sub

    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerCliente As SqlDataReader
                VerCliente = CMd.ExecuteReader

                LsvCliente.Items.Clear()
                While VerCliente.Read = True
                    With LsvCliente.Items.Add(VerCliente("Nombre").ToString)
                        .SubItems.Add(VerCliente("Apellidos").ToString)
                        .SubItems.Add(VerCliente("NumIdentCliente").ToString)
                        .SubItems.Add(VerCliente("Telefono").ToString)
                        .SubItems.Add(VerCliente("Direccion").ToString)
                        .SubItems.Add(VerCliente("FechaDeNacimiento").ToString)
                        .SubItems.Add(VerCliente("Sexo").ToString)
                        .SubItems.Add(VerCliente("NombreCiudad").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar el cliente" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FrmTipoExamen.TxtNumIdenCliente.Text = LsvCliente.FocusedItem.SubItems(2).Text
        FrmFactura.TxtNumIdentCliente.Text = LsvCliente.FocusedItem.SubItems(2).Text
        Close()

    End Sub
End Class