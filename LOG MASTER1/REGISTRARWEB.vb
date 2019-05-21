Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class REGISTRAR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            ' Objetos de conexión y comando
            Dim Conn As New MySqlConnection("Server=localhost;Database=logdb; Uid=root;Pwd=3829;")
            ' Estableciento propiedades
            Dim Cmd As New MySqlCommand With {
                .Connection = Conn,
                .CommandText = "INSERT INTO reguistrar VALUES (@usuario, @contrasena, @web, @nombreweb, @imagen, @codigoqr)"
            }

            ' Creando los parámetros necesarios
            Cmd.Parameters.Add("@usuario", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@contrasena", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@web", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@nombreweb", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@imagen", MySqlDbType.Blob)
            Cmd.Parameters.Add("@codigoqr", MySqlDbType.Blob)



            ' Asignando los valores a los atributos
            Cmd.Parameters("@usuario").Value = TextBoxUsuario.Text
            Cmd.Parameters("@contrasena").Value = TextBoxContrasena.Text
            Cmd.Parameters("@web").Value = TextBoxWeb.Text
            Cmd.Parameters("@nombreweb").Value = TextBoxNombreWeb.Text




            ' Stream usado como buffer
            Dim ms As New System.IO.MemoryStream()
            Dim msdos As New System.IO.MemoryStream()
            ' Se guarda la imagen en el buffer
            imgFoto.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            imgCodigoQr.Image.Save(msdos, Imaging.ImageFormat.Png)
            ' Se extraen los bytes del buffer para asignarlos como valor para el 
            ' parámetro.
            Cmd.Parameters("@imagen").Value = ms.GetBuffer()
            Cmd.Parameters("@codigoqr").Value = msdos.GetBuffer()

            Conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

        MsgBox("...:::. GUARDADO .:::...", vbOK, "Registro Creado")

        TextBoxUsuario.Text = ""
        TextBoxContrasena.Text = ""
        TextBoxWeb.Text = ""
        TextBoxNombreWeb.Text = ""
        imgFoto.Image = Nothing
        imgCodigoQr.Image = Nothing





    End Sub

    Private Function Imagen_Bytes(image As Image) As Byte()
        Throw New NotImplementedException()
    End Function

    Private Sub REGISTRAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxNombreWeb.Select()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBoxNombreWeb_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombreWeb.TextChanged

    End Sub

    Private Sub TextBoxWeb_TextChanged(sender As Object, e As EventArgs) Handles TextBoxWeb.TextChanged

    End Sub

    Private Sub TextBoxContrasena_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContrasena.TextChanged

    End Sub

    Private Sub TextBoxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuario.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dlg As New OpenFileDialog With {
            .Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes GIF|*.gif"
        }
        If dlg.ShowDialog = DialogResult.OK Then
            imgFoto.Image = Image.FromFile(dlg.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dlg As New OpenFileDialog With {
            .Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes GIF|*.gif"
        }
        If dlg.ShowDialog = DialogResult.OK Then
            imgCodigoQr.Image = Image.FromFile(dlg.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        System.Diagnostics.Process.Start("http://www.codigos-qr.com/generador-de-codigos-qr/")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("https://www.google.com.do/imghp?hl=es&tab=wi")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBoxUsuario.Text = ""
        TextBoxContrasena.Text = ""
        TextBoxWeb.Text = ""
        TextBoxNombreWeb.Text = ""
        imgFoto.Image = Nothing
        imgCodigoQr.Image = Nothing

    End Sub
End Class
