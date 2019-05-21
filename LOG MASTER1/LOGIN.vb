Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO.MemoryStream
Imports System.Drawing.Imaging
Public Class LOGIN

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxUsuario.Text = "                     USUARIO"
        TextBoxUsuario.ForeColor = Color.Gray

        TextBoxContrasena.Text = "                 CONTRASEÑA"
        TextBoxContrasena.ForeColor = Color.Gray






    End Sub

    Private Sub TextBoxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuario.TextChanged

    End Sub

    Private Sub TextBoxUsuario_GotFocus(sender As Object, e As EventArgs) Handles TextBoxUsuario.GotFocus
        TextBoxUsuario.Text = ""
        TextBoxUsuario.ForeColor = Color.Black
        TextBoxContrasena.PasswordChar = ""
        TextBoxContrasena.Text = "                 CONTRASEÑA"
        TextBoxContrasena.ForeColor = Color.Gray



    End Sub

    Private Sub TextBoxUsuario_LostFocus(sender As Object, e As EventArgs) Handles TextBoxUsuario.LostFocus

        If TextBoxUsuario.Text = "                     USUARIO" Then
            TextBoxUsuario.ForeColor = Color.Gray

        End If

        If TextBoxUsuario.Text = "" Then
            TextBoxUsuario.Text = "                     USUARIO"
            TextBoxUsuario.ForeColor = Color.Gray

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub TextBoxContrasena_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContrasena.TextChanged

    End Sub

    Private Sub TextBoxContrasena_GotFocus(sender As Object, e As EventArgs) Handles TextBoxContrasena.GotFocus
        TextBoxContrasena.Text = ""
        TextBoxContrasena.ForeColor = Color.Black
        TextBoxContrasena.PasswordChar = "X"
    End Sub

    Private Sub TextBoxContrasena_LostFocus(sender As Object, e As EventArgs) Handles TextBoxContrasena.LostFocus
        If TextBoxContrasena.Text = "                 CONTRASEÑA" Then
            TextBoxUsuario.ForeColor = Color.Gray

        End If

        If TextBoxContrasena.Text = "" Then
            TextBoxContrasena.Text = "                 CONTRASEÑA"
            TextBoxContrasena.ForeColor = Color.Gray

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonEntrar.Click
        If TextBoxUsuario.Text = "                     USUARIO" And TextBoxContrasena.Text = "                 CONTRASEÑA" Then
            MsgBox("'INTRODUSCA EL NOMBRE DE USUARIO Y CONTRASEÑA POR FAVOR'",)
            Return
        End If

        Dim Conn As New MySqlConnection("Server=localhost;Database=logdb; Uid=root;Pwd=3829;")
            Dim Cmd As New MySqlCommand("SELECT * FROM logtable Where usuario = @usuario and contrasena = @contrasena", Conn)
            Conn.Open()

            Cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = TextBoxUsuario.Text
            Cmd.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = TextBoxContrasena.Text

            Dim Adapt As New MySqlDataAdapter(Cmd)
            Dim Datable As New DataTable()
            Adapt.Fill(Datable)

            If Datable.Rows.Count() <= 0 Then
            MessageBox.Show("EL NOMBRE DE USUARIO Y CONTRASEÑA SON INVALIDO")
            TextBoxUsuario.Text = "                     USUARIO"
            TextBoxContrasena.Text = "                 CONTRASEÑA"
            TextBoxContrasena.ForeColor = Color.Gray
            TextBoxUsuario.ForeColor = Color.Gray
            TextBoxContrasena.PasswordChar = ""
            ButtonSalir.Focus()


        Else
            LOGPRINCIPAL.Show()
            Me.Hide()

        End If
            Conn.Close()



    End Sub

    Private Sub TextBoxUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextBoxContrasena.Focus()
        End If

    End Sub

    Private Sub TextBoxContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxContrasena.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ButtonEntrar.Focus()
        End If
    End Sub
End Class