
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO.MemoryStream
Imports System.Drawing.Imaging


Public Class CONSULTARWEB
    Dim Conn As New MySqlConnection("Server=localhost;Database=logdb; Uid=root;Pwd=3829;")
    Dim Adapt As MySqlDataAdapter
    Dim datos As New DataSet



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If TextBoxBuscar.Text = "" Then
            MsgBox("Introdusca el nombre de una pagina para buscar", MsgBoxStyle.OkOnly, "                   ...:::.HAY CAMPOS VACIO.:::...")

            Return


        End If


        Dim Conn As New MySqlConnection("Server=localhost;Database=logdb; Uid=root;Pwd=3829;")
        Dim consulta As String = "SELECT * FROM reguistrar WHERE nombreweb = @nombreweb"



        Dim Adpt As New MySqlDataAdapter()
        Dim Tble As New DataTable

        Using Conn

            Dim Cmd As New MySqlCommand(consulta, Conn)


            Cmd.Parameters.AddWithValue("nombreweb", TextBoxBuscar.Text)
            Conn.Open()
            Dim Dr As MySqlDataReader = Cmd.ExecuteReader()
            If Dr.HasRows Then
                While Dr.Read
                    TextBoxUsuario.Text = Dr.GetString(0)
                    TextBoxContrasena.Text = Dr.GetString(1)
                    TextBoxLink.Text = Dr.GetString(2)
                    TextBoxNombreWeb.Text = Dr.GetString(3)

                    Dim imagen As Byte() = CType(Dr("imagen"), Byte())
                    Using Memorystream As New IO.MemoryStream(imagen)
                        imgFoto2.Image = Image.FromStream(Memorystream)



                    End Using
                End While
            Else

                MessageBox.Show("No Encotro Datos")

            End If
            Dr.Close()

        End Using


    End Sub


    Private Sub ButtonCopyUser_Click(sender As Object, e As EventArgs) Handles ButtonCopyUser.Click
        Clipboard.SetText(TextBoxUsuario.Text)
    End Sub

    Private Sub ButtonCopyContrasena_Click(sender As Object, e As EventArgs) Handles ButtonCopyContrasena.Click
        Clipboard.SetText(TextBoxContrasena.Text)
    End Sub

    Private Sub ButtonCopyLink_Click(sender As Object, e As EventArgs) Handles ButtonCopyLink.Click


        If TextBoxLink.Text = "" Then
            Return
        End If
        Clipboard.SetText(TextBoxLink.Text)
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxUsuario.Text = ""
        TextBoxContrasena.Text = ""
        TextBoxLink.Text = ""
        TextBoxNombreWeb.Text = ""
        TextBoxBuscar.Text = ""
        imgFoto2.Image = Nothing
        imgCodigoQr2.Image = Nothing

        ComboBoxNombreWeb.Text = ""

    End Sub

    Private Sub CONSULTARWEB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxNombreWeb.SelectedItem = 0

        TextBoxLink.ForeColor = Color.Gray
        TextBoxLink.Text = "                                        Link"


        TextBoxUsuario.ForeColor = Color.Gray
        TextBoxUsuario.Text = "              Usuario"


        TextBoxContrasena.ForeColor = Color.Gray
        TextBoxContrasena.Text = "              Contraseña"

        TextBoxBuscar.Select()

        Dim Conn As New MySqlConnection("Server=localhost;Database=logdb; Uid=root;Pwd=3829;")
        Dim Adapt As MySqlDataAdapter
        Dim datos As New DataSet
        Conn.Open()

        Dim Consulta As String
        Consulta = "SELECT * FROM reguistrar"
        Adapt = New MySqlDataAdapter(Consulta, Conn)
        datos.Tables.Add("reguistrar")
        Adapt.Fill(datos.Tables("reguistrar"))
        ComboBoxNombreWeb.DataSource = datos.Tables("reguistrar")
        ComboBoxNombreWeb.DisplayMember = "nombreweb"

        ComboBoxNombreWeb.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxLink.ForeColor = Color.Black
        TextBoxUsuario.ForeColor = Color.Black
        TextBoxContrasena.ForeColor = Color.Black





        TextBoxContrasena.PasswordChar = "X"

        If ComboBoxNombreWeb.Text = "" Then
            MsgBox("Introdusca el nombre de una pagina para buscar", MsgBoxStyle.OkOnly, "                   ...:::.HAY CAMPOS VACIO.:::...")

            Return


        End If


        Dim Conn As New MySqlConnection("Server=localhost;Database=logdb; Uid=root;Pwd=3829;")
        Dim consulta As String = "SELECT * FROM reguistrar WHERE nombreweb = @nombreweb"



        Dim Adpt As New MySqlDataAdapter()
        Dim Tble As New DataTable

        Using Conn

            Dim Cmd As New MySqlCommand(consulta, Conn)


            Cmd.Parameters.AddWithValue("nombreweb", ComboBoxNombreWeb.Text)
            Conn.Open()
            Dim Dr As MySqlDataReader = Cmd.ExecuteReader()
            If Dr.HasRows Then
                While Dr.Read
                    TextBoxUsuario.Text = Dr.GetString(0)
                    TextBoxContrasena.Text = Dr.GetString(1)
                    TextBoxLink.Text = Dr.GetString(2)
                    TextBoxNombreWeb.Text = Dr.GetString(3)

                    Dim qr As Byte() = CType(Dr("imagen"), Byte())
                    Dim qrdos As Byte() = CType(Dr("codigoqr"), Byte())
                    Using Memorystream As New IO.MemoryStream(qr)
                        imgFoto2.Image = Image.FromStream(Memorystream)

                    End Using
                    Using Memorystream As New IO.MemoryStream(qrdos)
                        imgCodigoQr2.Image = Image.FromStream(Memorystream)

                    End Using

                End While
            Else

                MessageBox.Show("No Encotro Datos")

            End If
            Dr.Close()

        End Using

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim link As String

        link = TextBoxLink.Text

        System.Diagnostics.Process.Start(link)









    End Sub

    Private Sub TextBoxLink_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLink.TextChanged

    End Sub

    Private Sub TextBoxLink_GotFocus(sender As Object, e As EventArgs) Handles TextBoxLink.GotFocus
        If TextBoxLink.Text = "                                        Link" Then
            TextBoxLink.Text = ""
            TextBoxLink.ForeColor = Color.Black


        End If
    End Sub

    Private Sub TextBoxLink_LostFocus(sender As Object, e As EventArgs) Handles TextBoxLink.LostFocus


        If TextBoxLink.Text = "" Then
            TextBoxLink.Text = "                                        Link"
            TextBoxLink.ForeColor = Color.Gray

        End If


    End Sub

    Private Sub TextBoxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuario.TextChanged

    End Sub

    Private Sub TextBoxUsuario_GotFocus(sender As Object, e As EventArgs) Handles TextBoxUsuario.GotFocus

        If TextBoxUsuario.Text = "              Usuario" Then
            TextBoxUsuario.Text = ""
        End If








    End Sub

    Private Sub TextBoxUsuario_LostFocus(sender As Object, e As EventArgs) Handles TextBoxUsuario.LostFocus
        If TextBoxUsuario.Text = "" Then
            TextBoxUsuario.Text = "              Usuario"
            TextBoxUsuario.ForeColor = Color.Gray


        End If




    End Sub

    Private Sub TextBoxContrasena_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContrasena.TextChanged

    End Sub

    Private Sub TextBoxContrasena_GotFocus(sender As Object, e As EventArgs) Handles TextBoxContrasena.GotFocus
        TextBoxContrasena.PasswordChar = "X"

        If TextBoxContrasena.Text = "              Contraseña" Then
            TextBoxContrasena.Text = ""
        End If

    End Sub

    Private Sub TextBoxContrasena_LostFocus(sender As Object, e As EventArgs) Handles TextBoxContrasena.LostFocus
        If TextBoxContrasena.Text = "" Then
            TextBoxContrasena.Text = "              Contraseña"
            TextBoxContrasena.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub ButtonVer_Click(sender As Object, e As EventArgs) Handles ButtonVer.Click

    End Sub

    Private Sub ButtonVer_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonVer.MouseDown

        TextBoxContrasena.PasswordChar = ""



    End Sub

    Private Sub ButtonVer_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonVer.MouseUp
        TextBoxContrasena.PasswordChar = "X"
    End Sub

    Private Sub ComboBoxNombreWeb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNombreWeb.SelectedIndexChanged

    End Sub
End Class