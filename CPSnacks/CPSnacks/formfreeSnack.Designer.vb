<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formfreeSnack
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
        Me.lblfreeSnack = New System.Windows.Forms.Label()
        Me.btnbeanburitto = New System.Windows.Forms.Button()
        Me.btnFalafel = New System.Windows.Forms.Button()
        Me.btnGreekYoghurt = New System.Windows.Forms.Button()
        Me.btnSpringRolls = New System.Windows.Forms.Button()
        Me.PicSpringrolls = New System.Windows.Forms.PictureBox()
        Me.PicGreekYoghurt = New System.Windows.Forms.PictureBox()
        Me.PicFalafel = New System.Windows.Forms.PictureBox()
        Me.PicbeanBurrito = New System.Windows.Forms.PictureBox()
        Me.btnSelectbutton = New System.Windows.Forms.Button()
        Me.BtnExitWindow = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        CType(Me.PicSpringrolls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGreekYoghurt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFalafel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbeanBurrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblfreeSnack
        '
        Me.lblfreeSnack.AutoSize = True
        Me.lblfreeSnack.BackColor = System.Drawing.Color.Bisque
        Me.lblfreeSnack.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfreeSnack.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblfreeSnack.Location = New System.Drawing.Point(235, 18)
        Me.lblfreeSnack.Name = "lblfreeSnack"
        Me.lblfreeSnack.Size = New System.Drawing.Size(192, 39)
        Me.lblfreeSnack.TabIndex = 0
        Me.lblfreeSnack.Text = "Free Snack"
        '
        'btnbeanburitto
        '
        Me.btnbeanburitto.BackColor = System.Drawing.Color.MistyRose
        Me.btnbeanburitto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbeanburitto.Location = New System.Drawing.Point(99, 216)
        Me.btnbeanburitto.Name = "btnbeanburitto"
        Me.btnbeanburitto.Size = New System.Drawing.Size(143, 38)
        Me.btnbeanburitto.TabIndex = 1
        Me.btnbeanburitto.Text = "Bean buritto"
        Me.btnbeanburitto.UseVisualStyleBackColor = False
        '
        'btnFalafel
        '
        Me.btnFalafel.BackColor = System.Drawing.Color.MistyRose
        Me.btnFalafel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFalafel.Location = New System.Drawing.Point(484, 216)
        Me.btnFalafel.Name = "btnFalafel"
        Me.btnFalafel.Size = New System.Drawing.Size(143, 38)
        Me.btnFalafel.TabIndex = 6
        Me.btnFalafel.Text = "Falefel"
        Me.btnFalafel.UseVisualStyleBackColor = False
        '
        'btnGreekYoghurt
        '
        Me.btnGreekYoghurt.BackColor = System.Drawing.Color.MistyRose
        Me.btnGreekYoghurt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreekYoghurt.Location = New System.Drawing.Point(99, 430)
        Me.btnGreekYoghurt.Name = "btnGreekYoghurt"
        Me.btnGreekYoghurt.Size = New System.Drawing.Size(143, 38)
        Me.btnGreekYoghurt.TabIndex = 7
        Me.btnGreekYoghurt.Text = "GreekYoghurt"
        Me.btnGreekYoghurt.UseVisualStyleBackColor = False
        '
        'btnSpringRolls
        '
        Me.btnSpringRolls.BackColor = System.Drawing.Color.MistyRose
        Me.btnSpringRolls.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpringRolls.Location = New System.Drawing.Point(484, 430)
        Me.btnSpringRolls.Name = "btnSpringRolls"
        Me.btnSpringRolls.Size = New System.Drawing.Size(143, 38)
        Me.btnSpringRolls.TabIndex = 8
        Me.btnSpringRolls.Text = "Spring Rolls"
        Me.btnSpringRolls.UseVisualStyleBackColor = False
        '
        'PicSpringrolls
        '
        Me.PicSpringrolls.Image = Global.CPSnacks.My.Resources.Resources.spring_rolls
        Me.PicSpringrolls.Location = New System.Drawing.Point(443, 260)
        Me.PicSpringrolls.Name = "PicSpringrolls"
        Me.PicSpringrolls.Size = New System.Drawing.Size(200, 150)
        Me.PicSpringrolls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpringrolls.TabIndex = 5
        Me.PicSpringrolls.TabStop = False
        Me.PicSpringrolls.Visible = False
        '
        'PicGreekYoghurt
        '
        Me.PicGreekYoghurt.Image = Global.CPSnacks.My.Resources.Resources.Greek_Yoghurt
        Me.PicGreekYoghurt.Location = New System.Drawing.Point(70, 260)
        Me.PicGreekYoghurt.Name = "PicGreekYoghurt"
        Me.PicGreekYoghurt.Size = New System.Drawing.Size(200, 150)
        Me.PicGreekYoghurt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGreekYoghurt.TabIndex = 4
        Me.PicGreekYoghurt.TabStop = False
        Me.PicGreekYoghurt.Visible = False
        '
        'PicFalafel
        '
        Me.PicFalafel.Image = Global.CPSnacks.My.Resources.Resources.Falafel
        Me.PicFalafel.Location = New System.Drawing.Point(443, 60)
        Me.PicFalafel.Name = "PicFalafel"
        Me.PicFalafel.Size = New System.Drawing.Size(200, 150)
        Me.PicFalafel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFalafel.TabIndex = 3
        Me.PicFalafel.TabStop = False
        Me.PicFalafel.Visible = False
        '
        'PicbeanBurrito
        '
        Me.PicbeanBurrito.Image = Global.CPSnacks.My.Resources.Resources.Beanburrito
        Me.PicbeanBurrito.Location = New System.Drawing.Point(70, 60)
        Me.PicbeanBurrito.Name = "PicbeanBurrito"
        Me.PicbeanBurrito.Size = New System.Drawing.Size(200, 150)
        Me.PicbeanBurrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbeanBurrito.TabIndex = 2
        Me.PicbeanBurrito.TabStop = False
        Me.PicbeanBurrito.Visible = False
        '
        'btnSelectbutton
        '
        Me.btnSelectbutton.BackColor = System.Drawing.Color.MistyRose
        Me.btnSelectbutton.Enabled = False
        Me.btnSelectbutton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectbutton.Location = New System.Drawing.Point(284, 294)
        Me.btnSelectbutton.Name = "btnSelectbutton"
        Me.btnSelectbutton.Size = New System.Drawing.Size(143, 38)
        Me.btnSelectbutton.TabIndex = 9
        Me.btnSelectbutton.Text = "Select Button"
        Me.btnSelectbutton.UseVisualStyleBackColor = False
        '
        'BtnExitWindow
        '
        Me.BtnExitWindow.BackColor = System.Drawing.Color.MistyRose
        Me.BtnExitWindow.Enabled = False
        Me.BtnExitWindow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExitWindow.Location = New System.Drawing.Point(275, 584)
        Me.BtnExitWindow.Name = "BtnExitWindow"
        Me.BtnExitWindow.Size = New System.Drawing.Size(143, 38)
        Me.BtnExitWindow.TabIndex = 10
        Me.BtnExitWindow.Text = "Exit Window"
        Me.BtnExitWindow.UseVisualStyleBackColor = False
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.BackColor = System.Drawing.Color.White
        Me.lbldescription.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.Location = New System.Drawing.Point(66, 486)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(635, 44)
        Me.lbldescription.TabIndex = 11
        Me.lbldescription.Text = "Choose the Snack you want and then hit the Select button when you are ready" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "                  "
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.BackColor = System.Drawing.Color.White
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(280, 544)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(147, 22)
        Me.lblConfirmation.TabIndex = 12
        Me.lblConfirmation.Text = "Enjoy your Snack"
        Me.lblConfirmation.Visible = False
        '
        'formfreeSnack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 644)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.BtnExitWindow)
        Me.Controls.Add(Me.btnSelectbutton)
        Me.Controls.Add(Me.btnSpringRolls)
        Me.Controls.Add(Me.btnGreekYoghurt)
        Me.Controls.Add(Me.btnFalafel)
        Me.Controls.Add(Me.PicSpringrolls)
        Me.Controls.Add(Me.PicGreekYoghurt)
        Me.Controls.Add(Me.PicFalafel)
        Me.Controls.Add(Me.PicbeanBurrito)
        Me.Controls.Add(Me.btnbeanburitto)
        Me.Controls.Add(Me.lblfreeSnack)
        Me.Name = "formfreeSnack"
        Me.Text = "FreeSnack"
        CType(Me.PicSpringrolls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGreekYoghurt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFalafel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbeanBurrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblfreeSnack As Label
    Friend WithEvents btnbeanburitto As Button
    Friend WithEvents PicbeanBurrito As PictureBox
    Friend WithEvents PicFalafel As PictureBox
    Friend WithEvents PicGreekYoghurt As PictureBox
    Friend WithEvents PicSpringrolls As PictureBox
    Friend WithEvents btnFalafel As Button
    Friend WithEvents btnGreekYoghurt As Button
    Friend WithEvents btnSpringRolls As Button
    Friend WithEvents btnSelectbutton As Button
    Friend WithEvents BtnExitWindow As Button
    Friend WithEvents lbldescription As Label
    Friend WithEvents lblConfirmation As Label
End Class
