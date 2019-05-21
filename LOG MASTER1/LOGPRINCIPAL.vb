Public Class LOGPRINCIPAL
    Public Property REGUISTRARWeb As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REGISTRAR.ShowDialog()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CONSULTARWEB.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        REGISTRAR_TARJETA.ShowDialog(
            )
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CREAR_BANCO.ShowDialog()

    End Sub

    Private Sub LOGPRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelHora.Text = TimeOfDay

    End Sub
End Class
