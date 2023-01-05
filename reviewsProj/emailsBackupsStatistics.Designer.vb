<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class emailsBackupsStatistics
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
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbProfilePic = New System.Windows.Forms.PictureBox()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.wiganNews = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBackUp
        '
        Me.btnBackUp.Location = New System.Drawing.Point(586, 35)
        Me.btnBackUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(100, 55)
        Me.btnBackUp.TabIndex = 0
        Me.btnBackUp.Text = "Backup Menu"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.pbProfilePic)
        Me.Panel1.Controls.Add(Me.btnBackUp)
        Me.Panel1.Controls.Add(Me.lblCurrentUser)
        Me.Panel1.Controls.Add(Me.wiganNews)
        Me.Panel1.Location = New System.Drawing.Point(-573, -6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1975, 118)
        Me.Panel1.TabIndex = 29
        '
        'pbProfilePic
        '
        Me.pbProfilePic.BackColor = System.Drawing.Color.Transparent
        Me.pbProfilePic.Image = Global.reviewsProj.My.Resources.Resources.prof_pic
        Me.pbProfilePic.Location = New System.Drawing.Point(1869, 19)
        Me.pbProfilePic.Margin = New System.Windows.Forms.Padding(4)
        Me.pbProfilePic.Name = "pbProfilePic"
        Me.pbProfilePic.Size = New System.Drawing.Size(76, 65)
        Me.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfilePic.TabIndex = 31
        Me.pbProfilePic.TabStop = False
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Location = New System.Drawing.Point(1857, 88)
        Me.lblCurrentUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(92, 16)
        Me.lblCurrentUser.TabIndex = 30
        Me.lblCurrentUser.Text = "[USERNAME]"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'wiganNews
        '
        Me.wiganNews.AutoSize = True
        Me.wiganNews.BackColor = System.Drawing.Color.Transparent
        Me.wiganNews.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wiganNews.ForeColor = System.Drawing.Color.Black
        Me.wiganNews.Location = New System.Drawing.Point(1031, 15)
        Me.wiganNews.Name = "wiganNews"
        Me.wiganNews.Size = New System.Drawing.Size(448, 90)
        Me.wiganNews.TabIndex = 29
        Me.wiganNews.Text = "Wigan News"
        '
        'emailsBackupsStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1401, 431)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "emailsBackupsStatistics"
        Me.Text = "emailsBackupsStatistics"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBackUp As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents wiganNews As Label
    Friend WithEvents pbProfilePic As PictureBox
    Friend WithEvents lblCurrentUser As Label
End Class
