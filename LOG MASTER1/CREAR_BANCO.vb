Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO.MemoryStream
Imports System.Drawing.Imaging

Public Class CREAR_BANCO
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCargarImgBanco.Click
        Dim dlg As New OpenFileDialog With {
            .Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes GIF|*.gif"
        }
        If dlg.ShowDialog = DialogResult.OK Then
            imgFoto.Image = Image.FromFile(dlg.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCargarImgQr.Click
        Dim dlg As New OpenFileDialog With {
            .Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes GIF|*.gif"
        }
        If dlg.ShowDialog = DialogResult.OK Then
            imgCodigoQr.Image = Image.FromFile(dlg.FileName)
        End If
    End Sub

    Private Sub ButtonGuardarTarjeta_Click(sender As Object, e As EventArgs) Handles ButtonGuardarTarjeta.Click

        If TextBoxBanco.Text = "" And TextBoxTelUno.Text = "" And TextBoxTelDos.Text = "" And TextBoxTelTres.Text = "" And TextBoxLinkWeb.Text = "" And TextBoxBanking.Text = "" And imgFoto.Image Is Nothing And imgCodigoQr.Image Is Nothing Then

            MsgBox("ELFORMULARIO ESTA VACIO", vbCritical)
            Return
        End If



        If TextBoxBanco.Text = "" Then
            MsgBox("POR FAVOR INTRODUSCA EL NOMBRE DEL BANCO", MsgBoxStyle.Exclamation, "                   >>> AVISO <<<")
            TextBoxBanco.Focus()

            Return
        End If

        If TextBoxTelUno.Text = "" Then
            MsgBox("POR FAVOR INTRODUSCA AL MENOS UN TELEFONO", MsgBoxStyle.Exclamation, "                   >>> AVISO <<<")
            TextBoxTelUno.Focus()

            Return
        End If



        If TextBoxLinkWeb.Text = "" Then
            MsgBox("POR FAVOR INTRODUSCA EL SITIO WEB", MsgBoxStyle.Exclamation, "                   >>> AVISO <<<")
            TextBoxLinkWeb.Focus()

            Return
        End If


        If TextBoxBanking.Text = "" Then
            MsgBox("POR FAVOR INTRODUSCA EL BANKING", MsgBoxStyle.Exclamation, "                   >>> AVISO <<<")
            TextBoxBanking.Focus()

            Return
        End If

        If imgFoto.Image Is Nothing Then
            MsgBox("ES NECESARIO SUBIR UNA IMAGEN RELACIONADA AL BANCO", MsgBoxStyle.Exclamation, "                   >>> AVISO <<<")
            ButtonCargarImgBanco.Focus()

            Return
        End If

        If imgCodigoQr.Image Is Nothing Then
            MsgBox("ES NECESARIO SUBIR UNA IMAGEN CON EL CODIGO QR", MsgBoxStyle.Exclamation, "                   >>> AVISO <<<")
            ButtonCargarImgQr.Focus()

            Return
        End If








        Try
            ' Objetos de conexión y comando
            Dim Conn As New MySqlConnection("Server=localhost;Database=logdb; Uid=root;Pwd=3829;")
            ' Estableciento propiedades
            Dim Cmd As New MySqlCommand With {
                .Connection = Conn,
                .CommandText = "INSERT INTO banco VALUES (@nbanco, @teluno, @teldos, @teltres, @urlweb, @urlbankig, @banlogo, @bancodigoqr)"
            }

            ' Creando los parámetros necesarios
            Cmd.Parameters.Add("@nbanco", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@teluno", MySqlDbType.Int32)
            Cmd.Parameters.Add("@teldos", MySqlDbType.Int32)
            Cmd.Parameters.Add("@teltres", MySqlDbType.Int32)
            Cmd.Parameters.Add("@urlweb", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@urlbankig", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@banlogo", MySqlDbType.Blob)
            Cmd.Parameters.Add("@bancodigoqr", MySqlDbType.Blob)





            Cmd.Parameters("@nbanco").Value = TextBoxBanco.Text
            Cmd.Parameters("@teluno").Value = TextBoxTelDos.Text
            Cmd.Parameters("@teldos").Value = TextBoxTelDos.Text
            Cmd.Parameters("@teltres").Value = TextBoxTelTres.Text
            Cmd.Parameters("@urlweb").Value = TextBoxLinkWeb.Text
            Cmd.Parameters("@urlbankig").Value = TextBoxBanking.Text





            ' Stream usado como buffer
            Dim ms As New System.IO.MemoryStream()
            Dim msdos As New System.IO.MemoryStream()
            ' Se guarda la imagen en el buffer
            imgFoto.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            imgCodigoQr.Image.Save(msdos, Imaging.ImageFormat.Png)
            ' Se extraen los bytes del buffer para asignarlos como valor para el 
            ' parámetro.
            Cmd.Parameters("@banlogo").Value = ms.GetBuffer()
            Cmd.Parameters("@bancodigoqr").Value = msdos.GetBuffer()

            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

        MsgBox("...:::. GUARDADO .:::...", vbOK, "Registro Creado")

        TextBoxBanco.Text = ""
        TextBoxTelUno.Text = ""
        TextBoxTelDos.Text = ""
        TextBoxTelTres.Text = ""
        TextBoxLinkWeb.Text = ""
        TextBoxBanking.Text = ""
        imgFoto.Image = Nothing
        imgCodigoQr.Image = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBoxBanco.Text = ""
        TextBoxTelUno.Text = ""
        TextBoxTelDos.Text = ""
        TextBoxTelTres.Text = ""
        TextBoxLinkWeb.Text = ""
        TextBoxBanking.Text = ""
        imgFoto.Image = Nothing
        imgCodigoQr.Image = Nothing




    End Sub

    Private Sub TextBoxTelUno_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTelUno.TextChanged

    End Sub

    Private Sub TextBoxTelUno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelUno.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If




    End Sub

    Private Sub TextBoxTelDos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelDos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If




    End Sub

    Private Sub TextBoxTelTres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelTres.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub CREAR_BANCO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class