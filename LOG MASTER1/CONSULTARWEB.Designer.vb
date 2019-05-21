<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONSULTARWEB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONSULTARWEB))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.TextBoxContrasena = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreWeb = New System.Windows.Forms.TextBox()
        Me.TextBoxLink = New System.Windows.Forms.TextBox()
        Me.ButtonCopyUser = New System.Windows.Forms.Button()
        Me.ButtonCopyContrasena = New System.Windows.Forms.Button()
        Me.ButtonCopyLink = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.imgFoto2 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxNombreWeb = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonVer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.imgCodigoQr2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.imgFoto2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCodigoQr2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(649, 212)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 10, 10, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "...:::. WEB .:::..."
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.Location = New System.Drawing.Point(718, 22)
        Me.ButtonSalir.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(109, 75)
        Me.ButtonSalir.TabIndex = 15
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(236, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "BUSCAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBoxBuscar.Location = New System.Drawing.Point(68, 15)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(153, 22)
        Me.TextBoxBuscar.TabIndex = 18
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBoxUsuario.Location = New System.Drawing.Point(42, 37)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(189, 22)
        Me.TextBoxUsuario.TabIndex = 25
        '
        'TextBoxContrasena
        '
        Me.TextBoxContrasena.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBoxContrasena.Location = New System.Drawing.Point(42, 93)
        Me.TextBoxContrasena.Name = "TextBoxContrasena"
        Me.TextBoxContrasena.Size = New System.Drawing.Size(189, 22)
        Me.TextBoxContrasena.TabIndex = 26
        '
        'TextBoxNombreWeb
        '
        Me.TextBoxNombreWeb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBoxNombreWeb.Location = New System.Drawing.Point(549, 229)
        Me.TextBoxNombreWeb.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.TextBoxNombreWeb.Name = "TextBoxNombreWeb"
        Me.TextBoxNombreWeb.ReadOnly = True
        Me.TextBoxNombreWeb.Size = New System.Drawing.Size(296, 22)
        Me.TextBoxNombreWeb.TabIndex = 27
        Me.TextBoxNombreWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxLink
        '
        Me.TextBoxLink.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBoxLink.Location = New System.Drawing.Point(44, 35)
        Me.TextBoxLink.Name = "TextBoxLink"
        Me.TextBoxLink.Size = New System.Drawing.Size(681, 22)
        Me.TextBoxLink.TabIndex = 28
        '
        'ButtonCopyUser
        '
        Me.ButtonCopyUser.Image = CType(resources.GetObject("ButtonCopyUser.Image"), System.Drawing.Image)
        Me.ButtonCopyUser.Location = New System.Drawing.Point(237, 21)
        Me.ButtonCopyUser.Name = "ButtonCopyUser"
        Me.ButtonCopyUser.Size = New System.Drawing.Size(40, 38)
        Me.ButtonCopyUser.TabIndex = 29
        Me.ButtonCopyUser.UseVisualStyleBackColor = True
        '
        'ButtonCopyContrasena
        '
        Me.ButtonCopyContrasena.Image = CType(resources.GetObject("ButtonCopyContrasena.Image"), System.Drawing.Image)
        Me.ButtonCopyContrasena.Location = New System.Drawing.Point(237, 77)
        Me.ButtonCopyContrasena.Name = "ButtonCopyContrasena"
        Me.ButtonCopyContrasena.Size = New System.Drawing.Size(40, 38)
        Me.ButtonCopyContrasena.TabIndex = 30
        Me.ButtonCopyContrasena.UseVisualStyleBackColor = True
        '
        'ButtonCopyLink
        '
        Me.ButtonCopyLink.BackgroundImage = CType(resources.GetObject("ButtonCopyLink.BackgroundImage"), System.Drawing.Image)
        Me.ButtonCopyLink.Image = CType(resources.GetObject("ButtonCopyLink.Image"), System.Drawing.Image)
        Me.ButtonCopyLink.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonCopyLink.Location = New System.Drawing.Point(731, 19)
        Me.ButtonCopyLink.Name = "ButtonCopyLink"
        Me.ButtonCopyLink.Size = New System.Drawing.Size(40, 38)
        Me.ButtonCopyLink.TabIndex = 31
        Me.ButtonCopyLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonCopyLink.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Image = CType(resources.GetObject("ButtonLimpiar.Image"), System.Drawing.Image)
        Me.ButtonLimpiar.Location = New System.Drawing.Point(589, 21)
        Me.ButtonLimpiar.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(109, 75)
        Me.ButtonLimpiar.TabIndex = 32
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'imgFoto2
        '
        Me.imgFoto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgFoto2.Location = New System.Drawing.Point(549, 255)
        Me.imgFoto2.Name = "imgFoto2"
        Me.imgFoto2.Size = New System.Drawing.Size(145, 137)
        Me.imgFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFoto2.TabIndex = 33
        Me.imgFoto2.TabStop = False
        '
        'ComboBoxNombreWeb
        '
        Me.ComboBoxNombreWeb.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxNombreWeb.FormattingEnabled = True
        Me.ComboBoxNombreWeb.Location = New System.Drawing.Point(68, 41)
        Me.ComboBoxNombreWeb.Name = "ComboBoxNombreWeb"
        Me.ComboBoxNombreWeb.Size = New System.Drawing.Size(153, 24)
        Me.ComboBoxNombreWeb.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonVer)
        Me.GroupBox1.Controls.Add(Me.ButtonSalir)
        Me.GroupBox1.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 452)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 103)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'ButtonVer
        '
        Me.ButtonVer.Image = CType(resources.GetObject("ButtonVer.Image"), System.Drawing.Image)
        Me.ButtonVer.Location = New System.Drawing.Point(467, 22)
        Me.ButtonVer.Name = "ButtonVer"
        Me.ButtonVer.Size = New System.Drawing.Size(109, 75)
        Me.ButtonVer.TabIndex = 33
        Me.ButtonVer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.TextBoxLink)
        Me.GroupBox2.Controls.Add(Me.ButtonCopyLink)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(833, 73)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(8, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(777, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 38)
        Me.Button3.TabIndex = 32
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.TextBoxContrasena)
        Me.GroupBox3.Controls.Add(Me.TextBoxUsuario)
        Me.GroupBox3.Controls.Add(Me.ButtonCopyUser)
        Me.GroupBox3.Controls.Add(Me.ButtonCopyContrasena)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 131)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(8, 84)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(6, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'imgCodigoQr2
        '
        Me.imgCodigoQr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgCodigoQr2.Location = New System.Drawing.Point(700, 255)
        Me.imgCodigoQr2.Name = "imgCodigoQr2"
        Me.imgCodigoQr2.Size = New System.Drawing.Size(145, 137)
        Me.imgCodigoQr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCodigoQr2.TabIndex = 39
        Me.imgCodigoQr2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox4)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.TextBoxBuscar)
        Me.GroupBox5.Controls.Add(Me.ComboBoxNombreWeb)
        Me.GroupBox5.Location = New System.Drawing.Point(519, 101)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(326, 74)
        Me.GroupBox5.TabIndex = 40
        Me.GroupBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImageLocation = ""
        Me.PictureBox4.Location = New System.Drawing.Point(6, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(56, 53)
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'CONSULTARWEB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgFoto2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.imgCodigoQr2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBoxNombreWeb)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(873, 606)
        Me.MinimumSize = New System.Drawing.Size(873, 606)
        Me.Name = "CONSULTARWEB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                           ...:::.CONSULTAR CREDECIALES.:::..."
        CType(Me.imgFoto2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCodigoQr2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents TextBoxContrasena As TextBox
    Friend WithEvents TextBoxNombreWeb As TextBox
    Friend WithEvents TextBoxLink As TextBox
    Friend WithEvents ButtonCopyUser As Button
    Friend WithEvents ButtonCopyContrasena As Button
    Friend WithEvents ButtonCopyLink As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents imgFoto2 As PictureBox
    Friend WithEvents ComboBoxNombreWeb As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents imgCodigoQr2 As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ButtonVer As Button
End Class
