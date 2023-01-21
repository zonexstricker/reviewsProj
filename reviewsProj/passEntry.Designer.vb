<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passEntry
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
        Me.txtBoxPassword = New System.Windows.Forms.TextBox()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.wiganNews = New System.Windows.Forms.Label()
        Me.pbHideShow = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.PictureBox()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.lblCapsWarning = New System.Windows.Forms.Label()
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        CType(Me.pbHideShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.Location = New System.Drawing.Point(71, 153)
        Me.txtBoxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(447, 22)
        Me.txtBoxPassword.TabIndex = 23
        Me.txtBoxPassword.Text = "Password"
        Me.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxPassword.UseSystemPasswordChar = True
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.Location = New System.Drawing.Point(71, 123)
        Me.txtBoxUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(447, 22)
        Me.txtBoxUsername.TabIndex = 22
        Me.txtBoxUsername.Text = "Username"
        Me.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'wiganNews
        '
        Me.wiganNews.AutoSize = True
        Me.wiganNews.BackColor = System.Drawing.Color.Transparent
        Me.wiganNews.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wiganNews.ForeColor = System.Drawing.Color.Black
        Me.wiganNews.Location = New System.Drawing.Point(72, 9)
        Me.wiganNews.Name = "wiganNews"
        Me.wiganNews.Size = New System.Drawing.Size(448, 90)
        Me.wiganNews.TabIndex = 25
        Me.wiganNews.Text = "Wigan News"
        '
        'pbHideShow
        '
        Me.pbHideShow.BackColor = System.Drawing.Color.Transparent
        Me.pbHideShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHideShow.Image = Global.reviewsProj.My.Resources.Resources.hideShowPassword
        Me.pbHideShow.Location = New System.Drawing.Point(525, 153)
        Me.pbHideShow.Margin = New System.Windows.Forms.Padding(4)
        Me.pbHideShow.Name = "pbHideShow"
        Me.pbHideShow.Size = New System.Drawing.Size(32, 25)
        Me.pbHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHideShow.TabIndex = 26
        Me.pbHideShow.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(511, 181)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblStatus.TabIndex = 27
        Me.lblStatus.Text = "Hidden"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.Image = Global.reviewsProj.My.Resources.Resources.OKBtn
        Me.btnLogIn.Location = New System.Drawing.Point(205, 187)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(199, 62)
        Me.btnLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogIn.TabIndex = 28
        Me.btnLogIn.TabStop = False
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.BackColor = System.Drawing.Color.Transparent
        Me.rbAdmin.ForeColor = System.Drawing.Color.Black
        Me.rbAdmin.Location = New System.Drawing.Point(71, 187)
        Me.rbAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(66, 20)
        Me.rbAdmin.TabIndex = 29
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = False
        '
        'lblCapsWarning
        '
        Me.lblCapsWarning.AutoSize = True
        Me.lblCapsWarning.BackColor = System.Drawing.Color.Transparent
        Me.lblCapsWarning.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapsWarning.Location = New System.Drawing.Point(65, 97)
        Me.lblCapsWarning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapsWarning.Name = "lblCapsWarning"
        Me.lblCapsWarning.Size = New System.Drawing.Size(0, 26)
        Me.lblCapsWarning.TabIndex = 30
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.Location = New System.Drawing.Point(431, 226)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(139, 23)
        Me.btnForgotPassword.TabIndex = 31
        Me.btnForgotPassword.Text = "Forgot Password"
        Me.btnForgotPassword.UseVisualStyleBackColor = True
        '
        'passEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(603, 263)
        Me.Controls.Add(Me.btnForgotPassword)
        Me.Controls.Add(Me.lblCapsWarning)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pbHideShow)
        Me.Controls.Add(Me.wiganNews)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "passEntry"
        Me.Text = "Password Entry"
        CType(Me.pbHideShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents txtBoxUsername As TextBox
    Friend WithEvents wiganNews As Label
    Friend WithEvents pbHideShow As PictureBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnLogIn As PictureBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents lblCapsWarning As Label
    Friend WithEvents btnForgotPassword As Button
End Class
