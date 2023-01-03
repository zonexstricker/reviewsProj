<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class backupPrompt
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
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.rbEmp = New System.Windows.Forms.RadioButton()
        Me.rbRev = New System.Windows.Forms.RadioButton()
        Me.rbSites = New System.Windows.Forms.RadioButton()
        Me.rbUnv = New System.Windows.Forms.RadioButton()
        Me.rbUsers = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.wiganNews = New System.Windows.Forms.Label()
        Me.pbProfilePic = New System.Windows.Forms.PictureBox()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(68, 249)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(183, 103)
        Me.btnBackup.TabIndex = 6
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'rbEmp
        '
        Me.rbEmp.AutoSize = True
        Me.rbEmp.BackColor = System.Drawing.Color.Transparent
        Me.rbEmp.Location = New System.Drawing.Point(117, 108)
        Me.rbEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.rbEmp.Name = "rbEmp"
        Me.rbEmp.Size = New System.Drawing.Size(90, 20)
        Me.rbEmp.TabIndex = 7
        Me.rbEmp.TabStop = True
        Me.rbEmp.Text = "Employee"
        Me.rbEmp.UseVisualStyleBackColor = False
        '
        'rbRev
        '
        Me.rbRev.AutoSize = True
        Me.rbRev.BackColor = System.Drawing.Color.Transparent
        Me.rbRev.Location = New System.Drawing.Point(117, 136)
        Me.rbRev.Margin = New System.Windows.Forms.Padding(4)
        Me.rbRev.Name = "rbRev"
        Me.rbRev.Size = New System.Drawing.Size(80, 20)
        Me.rbRev.TabIndex = 8
        Me.rbRev.TabStop = True
        Me.rbRev.Text = "Reviews"
        Me.rbRev.UseVisualStyleBackColor = False
        '
        'rbSites
        '
        Me.rbSites.AutoSize = True
        Me.rbSites.BackColor = System.Drawing.Color.Transparent
        Me.rbSites.Location = New System.Drawing.Point(117, 164)
        Me.rbSites.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSites.Name = "rbSites"
        Me.rbSites.Size = New System.Drawing.Size(58, 20)
        Me.rbSites.TabIndex = 9
        Me.rbSites.TabStop = True
        Me.rbSites.Text = "Sites"
        Me.rbSites.UseVisualStyleBackColor = False
        '
        'rbUnv
        '
        Me.rbUnv.AutoSize = True
        Me.rbUnv.BackColor = System.Drawing.Color.Transparent
        Me.rbUnv.Location = New System.Drawing.Point(117, 193)
        Me.rbUnv.Margin = New System.Windows.Forms.Padding(4)
        Me.rbUnv.Name = "rbUnv"
        Me.rbUnv.Size = New System.Drawing.Size(89, 20)
        Me.rbUnv.TabIndex = 10
        Me.rbUnv.TabStop = True
        Me.rbUnv.Text = "Unverified"
        Me.rbUnv.UseVisualStyleBackColor = False
        '
        'rbUsers
        '
        Me.rbUsers.AutoSize = True
        Me.rbUsers.BackColor = System.Drawing.Color.Transparent
        Me.rbUsers.Location = New System.Drawing.Point(117, 221)
        Me.rbUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.rbUsers.Name = "rbUsers"
        Me.rbUsers.Size = New System.Drawing.Size(64, 20)
        Me.rbUsers.TabIndex = 11
        Me.rbUsers.TabStop = True
        Me.rbUsers.Text = "Users"
        Me.rbUsers.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.pbProfilePic)
        Me.Panel1.Controls.Add(Me.lblCurrentUser)
        Me.Panel1.Controls.Add(Me.wiganNews)
        Me.Panel1.Location = New System.Drawing.Point(-50, -11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 103)
        Me.Panel1.TabIndex = 29
        '
        'wiganNews
        '
        Me.wiganNews.AutoSize = True
        Me.wiganNews.BackColor = System.Drawing.Color.Transparent
        Me.wiganNews.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wiganNews.ForeColor = System.Drawing.Color.Black
        Me.wiganNews.Location = New System.Drawing.Point(60, 31)
        Me.wiganNews.Name = "wiganNews"
        Me.wiganNews.Size = New System.Drawing.Size(226, 46)
        Me.wiganNews.TabIndex = 29
        Me.wiganNews.Text = "Wigan News"
        '
        'pbProfilePic
        '
        Me.pbProfilePic.BackColor = System.Drawing.Color.Transparent
        Me.pbProfilePic.Image = Global.reviewsProj.My.Resources.Resources.prof_pic
        Me.pbProfilePic.Location = New System.Drawing.Point(288, 12)
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
        Me.lblCurrentUser.Location = New System.Drawing.Point(276, 81)
        Me.lblCurrentUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(92, 16)
        Me.lblCurrentUser.TabIndex = 30
        Me.lblCurrentUser.Text = "[USERNAME]"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'backupPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(327, 365)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbUsers)
        Me.Controls.Add(Me.rbUnv)
        Me.Controls.Add(Me.rbSites)
        Me.Controls.Add(Me.rbRev)
        Me.Controls.Add(Me.rbEmp)
        Me.Controls.Add(Me.btnBackup)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "backupPrompt"
        Me.Text = "backupPrompt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackup As Button
    Friend WithEvents rbEmp As RadioButton
    Friend WithEvents rbRev As RadioButton
    Friend WithEvents rbSites As RadioButton
    Friend WithEvents rbUnv As RadioButton
    Friend WithEvents rbUsers As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents wiganNews As Label
    Friend WithEvents pbProfilePic As PictureBox
    Friend WithEvents lblCurrentUser As Label
End Class
