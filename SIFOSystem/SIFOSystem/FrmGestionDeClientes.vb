Public Class FrmGestión

    Private Sub PnlAgregar_Click(sender As Object, e As EventArgs) Handles PnlAgregar.Click
        GbxDatos.Visible = True
        PnlClientes.Visible = False
        BtnMostrarMenos.Visible = True

        Height = 598
    End Sub

    Private Sub PnlMostrar_Click(sender As Object, e As EventArgs) Handles PnlMostrar.Click
        GbxDatos.Visible = False
        PnlClientes.Visible = True
        BtnMostrarMenos.Visible = True

        Height = 598
    End Sub

    Private Sub BtnMostrarMenos_Click(sender As Object, e As EventArgs) Handles BtnMostrarMenos.Click
        GbxDatos.Visible = False
        PnlClientes.Visible = False
        BtnMostrarMenos.Visible = False
        Height = 317
    End Sub

    Private Sub FrmGestión_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Height = 330
        GbxDatos.Visible = False
        PnlClientes.Visible = False
        BtnMostrarMenos.Visible = False
    End Sub
End Class
