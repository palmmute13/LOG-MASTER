Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO.MemoryStream
Imports System.Drawing.Imaging


Public Class REGISTRAR_TARJETA
    Private Sub TextBoxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUno.TextChanged

        If TextBoxUno.Text = "" Then
            Return
        End If





        If TextBoxUno.Text > 3000 And TextBoxUno.Text < 3999 Then
            PictureBoxVisa.Visible = False
            PictureBoxMasterCard.Visible = False
            PictureBoxDiscover.Visible = False
            PictureBoxAmericanEx.Visible = True
            LaberTarjeta.Text = "American Express"
        End If

        If TextBoxUno.Text > 4000 And TextBoxUno.Text < 4999 Then
            PictureBoxVisa.Visible = True
            PictureBoxMasterCard.Visible = False
            PictureBoxDiscover.Visible = False
            PictureBoxAmericanEx.Visible = False
            LaberTarjeta.Text = "Visa"
        End If

        If TextBoxUno.Text > 5000 And TextBoxUno.Text < 5999 Then
            PictureBoxVisa.Visible = False
            PictureBoxMasterCard.Visible = True
            PictureBoxDiscover.Visible = False
            PictureBoxAmericanEx.Visible = False
            LaberTarjeta.Text = "Master Card"
        End If

        If TextBoxUno.Text > 6000 And TextBoxUno.Text < 6999 Then
            PictureBoxVisa.Visible = False
            PictureBoxMasterCard.Visible = False
            PictureBoxDiscover.Visible = True
            PictureBoxAmericanEx.Visible = False
            LaberTarjeta.Text = "Discover"
        End If



    End Sub

    Private Sub REGISTRAR_TARJETA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxVisa.Visible = False
        PictureBoxMasterCard.Visible = False
        PictureBoxDiscover.Visible = False
        PictureBoxAmericanEx.Visible = False




        ComboBoxBanco.ForeColor= Color.Gray
        ComboBoxBanco.Text="             Banco"


        TextBoxTarjetaUser.ForeColor= Color.Gray
        TextBoxTarjetaUser.Text="             Usuario"


        ComboBoxCondicion.ForeColor= Color.Gray
        ComboBoxCondicion.Text="     Condicion"


        ComboBoxMes.ForeColor= Color.Gray
        ComboBoxMes.Text="Mes"


        ComboBoxAño.ForeColor= Color.Gray
        ComboBoxAño.Text="Año"



        TextBoxPin.ForeColor= Color.Gray
        TextBoxPin.Text="Pin"


        TextBoxMonto.ForeColor= Color.Gray
        TextBoxMonto.Text="         Monto"


        TextBoxCvv.ForeColor= Color.Gray
        TextBoxCvv.Text = "  Cvv"


        TextBoxCorte.ForeColor = Color.Gray
        TextBoxCorte.Text = "         Corte"





    End Sub

    Private Sub ComboBoxBanco_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxBanco.GotFocus


        If ComboBoxBanco.Text = "             Banco" Then
            ComboBoxBanco.Text = ""
            ComboBoxBanco.ForeColor = Color.Black


        End If



    End Sub

    Private Sub ComboBoxBanco_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxBanco.LostFocus
        If ComboBoxBanco.Text = "" Then
            ComboBoxBanco.Text = "             Banco"
            ComboBoxBanco.ForeColor = Color.Gray

        End If




    End Sub

    Private Sub ComboBoxBanco_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxBanco.TextChanged






    End Sub

    Private Sub TextBoxTarjetaUser_GotFocus(sender As Object, e As EventArgs) Handles TextBoxTarjetaUser.GotFocus


        If TextBoxTarjetaUser.Text = "             Usuario" Then
            TextBoxTarjetaUser.Text = ""
            TextBoxTarjetaUser.ForeColor = Color.Black


        End If





    End Sub

    Private Sub TextBoxTarjetaUser_LostFocus(sender As Object, e As EventArgs) Handles TextBoxTarjetaUser.LostFocus

        If TextBoxTarjetaUser.Text = "" Then
            TextBoxTarjetaUser.Text = "             Usuario"
            TextBoxTarjetaUser.ForeColor = Color.Gray

        End If

    End Sub

    Private Sub ComboBoxCondicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCondicion.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxCondicion_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxCondicion.GotFocus

        If ComboBoxCondicion.Text = "     Condicion" Then
            ComboBoxCondicion.Text = ""
            ComboBoxCondicion.ForeColor = Color.Black
        End If

    End Sub

    Private Sub ComboBoxCondicion_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxCondicion.LostFocus
        If ComboBoxCondicion.Text = "" Then
            ComboBoxCondicion.Text = "     Condicion"
            ComboBoxCondicion.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub ComboBoxMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMes.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxMes_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxMes.GotFocus


        If ComboBoxMes.Text = "Mes" Then
            ComboBoxMes.Text = ""
            ComboBoxMes.ForeColor = Color.Black
        End If

    End Sub

    Private Sub ComboBoxMes_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxMes.LostFocus


        If ComboBoxMes.Text = "" Then
            ComboBoxMes.Text = "Mes"
            ComboBoxMes.ForeColor = Color.Gray

        End If



    End Sub

    Private Sub ComboBoxAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAño.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxAño_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxAño.GotFocus
        If ComboBoxAño.Text = "Año" Then
            ComboBoxAño.Text = ""
            ComboBoxAño.ForeColor = Color.Black
        End If

    End Sub

    Private Sub ComboBoxAño_LostFocus(sender As Object, e As EventArgs) Handles ComboBoxAño.LostFocus

        If ComboBoxAño.Text = "" Then
            ComboBoxAño.Text = "Año"
            ComboBoxAño.ForeColor = Color.Gray

        End If

    End Sub

    Private Sub TextBoxPin_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPin.TextChanged


    End Sub

    Private Sub TextBoxPin_GotFocus(sender As Object, e As EventArgs) Handles TextBoxPin.GotFocus
        If TextBoxPin.Text = "Pin" Then
            TextBoxPin.Text = ""
            TextBoxPin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxPin_LostFocus(sender As Object, e As EventArgs) Handles TextBoxPin.LostFocus
        If TextBoxPin.Text = "" Then
            TextBoxPin.Text = "Pin"
            TextBoxPin.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub ComboBoxBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBanco.SelectedIndexChanged

    End Sub

    Private Sub TextBoxMonto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMonto.TextChanged

    End Sub

    Private Sub TextBoxMonto_GotFocus(sender As Object, e As EventArgs) Handles TextBoxMonto.GotFocus
        If TextBoxMonto.Text = "         Monto" Then
            TextBoxMonto.Text = ""
            TextBoxMonto.ForeColor = Color.Black
        End If

    End Sub

    Private Sub REGISTRAR_TARJETA_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus






    End Sub

    Private Sub TextBoxMonto_LostFocus(sender As Object, e As EventArgs) Handles TextBoxMonto.LostFocus
        If TextBoxMonto.Text = "" Then
            TextBoxMonto.Text = "         Monto"
            TextBoxMonto.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub TextBoCvv_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCvv.TextChanged

    End Sub

    Private Sub TextBoCvv_GotFocus(sender As Object, e As EventArgs) Handles TextBoxCvv.GotFocus

        If TextBoxCvv.Text = "  Cvv" Then
            TextBoxCvv.Text = ""
            TextBoxCvv.ForeColor = Color.Black
        End If

    End Sub

    Private Sub TextBoxCvv_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCvv.LostFocus
        If TextBoxCvv.Text = "" Then
            TextBoxCvv.Text = "  Cvv"
            TextBoxCvv.ForeColor = Color.Gray

        End If



    End Sub



    Private Sub ButtonVer_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonVer.MouseDown
        TextBoxUno.PasswordChar = ""
        TextBoxDos.PasswordChar = ""
        TextBoxTres.PasswordChar = ""
        TextBoxCuatro.PasswordChar = ""
        TextBoxPin.PasswordChar = ""
    End Sub

    Private Sub ButtonVer_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonVer.MouseUp
        TextBoxUno.PasswordChar = "X"
        TextBoxDos.PasswordChar = "X"
        TextBoxTres.PasswordChar = "X"
        TextBoxCuatro.PasswordChar = "X"
        TextBoxPin.PasswordChar = "X"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCorte.TextChanged



    End Sub

    Private Sub TextBoxCorte_GotFocus(sender As Object, e As EventArgs) Handles TextBoxCorte.GotFocus
        If TextBoxCorte.Text = "         Corte" Then
            TextBoxCorte.Text = ""
            TextBoxCorte.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxCorte_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCorte.LostFocus
        If TextBoxCorte.Text = "" Then
            TextBoxCorte.Text = "         Corte"
            TextBoxCorte.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGuardarTarjeta.Click


        Try
            ' Objetos de conexión y comando
            Dim Conn As New MySqlConnection("Server=localhost;Database=logdb; Uid=root;Pwd=3829;")
            ' Estableciento propiedades
            Dim Cmd As New MySqlCommand With {
                .Connection = Conn,
                .CommandText = "INSERT INTO reg_tarjeta VALUES (@banco, @usuario, @condicion, @monto_limite, @fecha_corte, @numero_uno, @numero_dos, @numero_tres, @numero_cuatro, @mes, @año, @pin, @cvv, @tarjeta)"
            }



            ' Creando los parámetros necesarios
            Cmd.Parameters.Add("@banco", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@usuario", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@condicion", MySqlDbType.VarChar)
            Cmd.Parameters.Add("@monto_limite", MySqlDbType.Int16)
            Cmd.Parameters.Add("@fecha_corte", MySqlDbType.Int16)
            Cmd.Parameters.Add("@numero_uno", MySqlDbType.Int16)
            Cmd.Parameters.Add("@numero_dos", MySqlDbType.Int16)
            Cmd.Parameters.Add("@numero_tres", MySqlDbType.Int16)
            Cmd.Parameters.Add("@numero_cuatro", MySqlDbType.Int16)
            Cmd.Parameters.Add("@mes", MySqlDbType.Int16)
            Cmd.Parameters.Add("@año", MySqlDbType.Int16)
            Cmd.Parameters.Add("@pin", MySqlDbType.Int16)
            Cmd.Parameters.Add("@cvv", MySqlDbType.Int16)
            Cmd.Parameters.Add("@tarjeta", MySqlDbType.VarChar)

            Cmd.Parameters("@banco").Value = ComboBoxBanco.Text
            Cmd.Parameters("@usuario").Value = TextBoxTarjetaUser.Text
            Cmd.Parameters("@condicion").Value = ComboBoxCondicion.Text
            Cmd.Parameters("@monto_limite").Value = TextBoxMonto.Text
            Cmd.Parameters("@fecha_corte").Value = TextBoxCorte.Text
            Cmd.Parameters("@numero_uno").Value = TextBoxUno.Text
            Cmd.Parameters("@numero_dos").Value = TextBoxDos.Text
            Cmd.Parameters("@numero_tres").Value = TextBoxTres.Text
            Cmd.Parameters("@numero_cuatro").Value = TextBoxCuatro.Text
            Cmd.Parameters("@mes").Value = ComboBoxMes.Text
            Cmd.Parameters("@año").Value = ComboBoxAño.Text
            Cmd.Parameters("@pin").Value = TextBoxPin.Text
            Cmd.Parameters("@cvv").Value = TextBoxPin.Text
            Cmd.Parameters("@tarjeta").Value = LaberTarjeta.Text

            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

        MsgBox("...:::. GUARDADO .:::...", vbOK, "Registro Creado")



        ComboBoxBanco.Text = ""
        TextBoxTarjetaUser.Text = ""
        ComboBoxCondicion.Text = ""
        TextBoxMonto.Text = ""
        TextBoxCorte.Text = ""
        TextBoxUno.Text = ""
        TextBoxDos.Text = ""
        TextBoxTres.Text = ""
        TextBoxCuatro.Text = ""
        ComboBoxMes.Text = ""
        ComboBoxAño.Text = ""
        TextBoxPin.Text = ""
        TextBoxCvv.Text = ""


















    End Sub

    Private Sub TextBoxUno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUno.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


        If TextBoxUno.TextLength = 4 Then
            TextBoxDos.Focus()
        End If




    End Sub

    Private Sub TextBoxDos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True


        End If


        If TextBoxDos.TextLength = 4 Then
            TextBoxTres.Focus()
        End If
    End Sub

    Private Sub TextBoxTres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTres.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True



        End If
        If TextBoxTres.TextLength = 4 Then
                TextBoxCuatro.Focus()
            End If



    End Sub

    Private Sub TextBoxCuatro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCuatro.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBoxCuatro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCuatro.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonVer_Click(sender As Object, e As EventArgs) Handles ButtonVer.Click

    End Sub

    Private Sub TextBoxPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPin.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ComboBoxBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxBanco.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If






    End Sub

    Private Sub TextBoxTarjetaUser_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTarjetaUser.TextChanged

    End Sub

    Private Sub TextBoxTarjetaUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTarjetaUser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ComboBoxCondicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxCondicion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBoxMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMonto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBoxCorte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCorte.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ComboBoxMes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxMes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ComboBoxAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxAño.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBoxCvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCvv.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBoxBanco.Text = ""
        TextBoxTarjetaUser.Text = ""
        ComboBoxCondicion.Text = ""
        TextBoxMonto.Text = ""
        TextBoxCorte.Text = ""
        TextBoxUno.Text = ""
        TextBoxDos.Text = ""
        TextBoxTres.Text = ""
        TextBoxCuatro.Text = ""
        ComboBoxMes.Text = ""
        ComboBoxAño.Text = ""
        TextBoxPin.Text = ""
        TextBoxCvv.Text = ""
    End Sub
End Class