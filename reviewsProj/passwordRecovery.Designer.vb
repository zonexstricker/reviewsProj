<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwordRecovery
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
        Me.lblCapsWarning = New System.Windows.Forms.Label()
        Me.txtBoxForename = New System.Windows.Forms.TextBox()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.wiganNews = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pbHideShow = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHideShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCapsWarning
        '
        Me.lblCapsWarning.AutoSize = True
        Me.lblCapsWarning.BackColor = System.Drawing.Color.Transparent
        Me.lblCapsWarning.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapsWarning.Location = New System.Drawing.Point(149, 132)
        Me.lblCapsWarning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapsWarning.Name = "lblCapsWarning"
        Me.lblCapsWarning.Size = New System.Drawing.Size(0, 26)
        Me.lblCapsWarning.TabIndex = 33
        '
        'txtBoxForename
        '
        Me.txtBoxForename.Location = New System.Drawing.Point(12, 149)
        Me.txtBoxForename.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxForename.Name = "txtBoxForename"
        Me.txtBoxForename.Size = New System.Drawing.Size(447, 22)
        Me.txtBoxForename.TabIndex = 32
        Me.txtBoxForename.Text = "Forename"
        Me.txtBoxForename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.Location = New System.Drawing.Point(12, 108)
        Me.txtBoxUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(447, 22)
        Me.txtBoxUsername.TabIndex = 31
        Me.txtBoxUsername.Text = "Username"
        Me.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.Location = New System.Drawing.Point(12, 249)
        Me.txtBoxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(447, 22)
        Me.txtBoxPassword.TabIndex = 35
        Me.txtBoxPassword.Text = "Password"
        Me.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxPassword.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.reviewsProj.My.Resources.Resources.OKBtn
        Me.PictureBox1.Location = New System.Drawing.Point(136, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'wiganNews
        '
        Me.wiganNews.AutoSize = True
        Me.wiganNews.BackColor = System.Drawing.Color.Transparent
        Me.wiganNews.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wiganNews.ForeColor = System.Drawing.Color.Black
        Me.wiganNews.Location = New System.Drawing.Point(9, 9)
        Me.wiganNews.Name = "wiganNews"
        Me.wiganNews.Size = New System.Drawing.Size(448, 90)
        Me.wiganNews.TabIndex = 37
        Me.wiganNews.Text = "Wigan News"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(211, 305)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblStatus.TabIndex = 39
        Me.lblStatus.Text = "Hidden"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbHideShow
        '
        Me.pbHideShow.BackColor = System.Drawing.Color.Transparent
        Me.pbHideShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHideShow.Image = Global.reviewsProj.My.Resources.Resources.hideShowPassword
        Me.pbHideShow.Location = New System.Drawing.Point(225, 277)
        Me.pbHideShow.Margin = New System.Windows.Forms.Padding(4)
        Me.pbHideShow.Name = "pbHideShow"
        Me.pbHideShow.Size = New System.Drawing.Size(32, 25)
        Me.pbHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHideShow.TabIndex = 38
        Me.pbHideShow.TabStop = False
        '
        'passwordRecovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(469, 337)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pbHideShow)
        Me.Controls.Add(Me.wiganNews)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.lblCapsWarning)
        Me.Controls.Add(Me.txtBoxForename)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Name = "passwordRecovery"
        Me.Text = "passwordRecovery"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHideShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCapsWarning As Label
    Friend WithEvents txtBoxForename As TextBox
    Friend WithEvents txtBoxUsername As TextBox
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents wiganNews As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents pbHideShow As PictureBox
End Class
