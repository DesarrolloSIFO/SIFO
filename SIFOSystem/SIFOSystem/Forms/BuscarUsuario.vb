Imports System.Data.SqlClient
Public Class FrmBuscarUsuario
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

    Private Sub FrmBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FrmUsuario.TxtIdentidad.Text = LsvEmpleados.FocusedItem.SubItems(0).Text
        FrmUsuario.InvestigarCorrelativoUsuario()
        FrmUsuario.Show()
        Close()


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

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text

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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        BuscarEmpleadoPorNombre()
    End Sub

End Class