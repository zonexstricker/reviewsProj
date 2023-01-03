<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbProfilePic = New System.Windows.Forms.PictureBox()
        Me.btnUploadPfp = New System.Windows.Forms.Button()
        Me.ReviewsDBDataSet1 = New reviewsProj.reviewsDBDataSet()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pbHideShow = New System.Windows.Forms.PictureBox()
        Me.txtBoxPassword = New System.Windows.Forms.TextBox()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBoxFirst = New System.Windows.Forms.TextBox()
        Me.txtBoxSurname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.wiganNews = New System.Windows.Forms.Label()
        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReviewsDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHideShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbProfilePic
        '
        Me.pbProfilePic.BackColor = System.Drawing.Color.Transparent
        Me.pbProfilePic.Image = Global.reviewsProj.My.Resources.Resources.prof_pic
        Me.pbProfilePic.Location = New System.Drawing.Point(165, 106)
        Me.pbProfilePic.Name = "pbProfilePic"
        Me.pbProfilePic.Size = New System.Drawing.Size(81, 79)
        Me.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfilePic.TabIndex = 0
        Me.pbProfilePic.TabStop = False
        '
        'btnUploadPfp
        '
        Me.btnUploadPfp.Location = New System.Drawing.Point(120, 191)
        Me.btnUploadPfp.Name = "btnUploadPfp"
        Me.btnUploadPfp.Size = New System.Drawing.Size(164, 23)
        Me.btnUploadPfp.TabIndex = 1
        Me.btnUploadPfp.Text = "Upload Profile Picture"
        Me.btnUploadPfp.UseVisualStyleBackColor = True
        '
        'ReviewsDBDataSet1
        '
        Me.ReviewsDBDataSet1.DataSetName = "reviewsDBDataSet"
        Me.ReviewsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(175, 395)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblStatus.TabIndex = 31
        Me.lblStatus.Text = "Hidden"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbHideShow
        '
        Me.pbHideShow.BackColor = System.Drawing.Color.Transparent
        Me.pbHideShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHideShow.Image = Global.reviewsProj.My.Resources.Resources.hideShowPassword
        Me.pbHideShow.Location = New System.Drawing.Point(189, 367)
        Me.pbHideShow.Margin = New System.Windows.Forms.Padding(4)
        Me.pbHideShow.Name = "pbHideShow"
        Me.pbHideShow.Size = New System.Drawing.Size(32, 25)
        Me.pbHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHideShow.TabIndex = 30
        Me.pbHideShow.TabStop = False
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.Location = New System.Drawing.Point(64, 310)
        Me.txtBoxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(275, 22)
        Me.txtBoxPassword.TabIndex = 29
        Me.txtBoxPassword.Text = "Password"
        Me.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBoxPassword.UseSystemPasswordChar = True
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.Location = New System.Drawing.Point(64, 232)
        Me.txtBoxUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(275, 22)
        Me.txtBoxUsername.TabIndex = 28
        Me.txtBoxUsername.Text = "Username"
        Me.txtBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.reviewsProj.My.Resources.Resources.BtnAdd
        Me.PictureBox1.Location = New System.Drawing.Point(76, 418)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(252, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'txtBoxFirst
        '
        Me.txtBoxFirst.Location = New System.Drawing.Point(64, 258)
        Me.txtBoxFirst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxFirst.Name = "txtBoxFirst"
        Me.txtBoxFirst.Size = New System.Drawing.Size(275, 22)
        Me.txtBoxFirst.TabIndex = 33
        Me.txtBoxFirst.Text = "First Name"
        Me.txtBoxFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxSurname
        '
        Me.txtBoxSurname.Location = New System.Drawing.Point(64, 284)
        Me.txtBoxSurname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBoxSurname.Name = "txtBoxSurname"
        Me.txtBoxSurname.Size = New System.Drawing.Size(275, 22)
        Me.txtBoxSurname.TabIndex = 34
        Me.txtBoxSurname.Text = "Surname"
        Me.txtBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.wiganNews)
        Me.Panel1.Location = New System.Drawing.Point(-778, -17)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1275, 118)
        Me.Panel1.TabIndex = 35
        '
        'wiganNews
        '
        Me.wiganNews.AutoSize = True
        Me.wiganNews.BackColor = System.Drawing.Color.Transparent
        Me.wiganNews.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wiganNews.ForeColor = System.Drawing.Color.Black
        Me.wiganNews.Location = New System.Drawing.Point(813, 36)
        Me.wiganNews.Name = "wiganNews"
        Me.wiganNews.Size = New System.Drawing.Size(337, 68)
        Me.wiganNews.TabIndex = 29
        Me.wiganNews.Text = "Wigan News"
        '
        'newAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(407, 517)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBoxSurname)
        Me.Controls.Add(Me.txtBoxFirst)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pbHideShow)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Controls.Add(Me.btnUploadPfp)
        Me.Controls.Add(Me.pbProfilePic)
        Me.Name = "newAccount"
        Me.Text = "newAccount"
        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReviewsDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHideShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbProfilePic As PictureBox
    Friend WithEvents btnUploadPfp As Button
    Friend WithEvents ReviewsDBDataSet1 As reviewsDBDataSet
    Friend WithEvents lblStatus As Label
    Friend WithEvents pbHideShow As PictureBox
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents txtBoxUsername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBoxFirst As TextBox
    Friend WithEvents txtBoxSurname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents wiganNews As Label
End Class
