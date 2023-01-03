<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainMenu
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnNewAccount = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.wiganNews = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(338, 141)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(81, 64)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log-In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnNewAccount
        '
        Me.btnNewAccount.Location = New System.Drawing.Point(82, 141)
        Me.btnNewAccount.Name = "btnNewAccount"
        Me.btnNewAccount.Size = New System.Drawing.Size(81, 64)
        Me.btnNewAccount.TabIndex = 3
        Me.btnNewAccount.Text = "Sign-Up"
        Me.btnNewAccount.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.wiganNews)
        Me.Panel1.Location = New System.Drawing.Point(-474, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1275, 118)
        Me.Panel1.TabIndex = 28
        '
        'wiganNews
        '
        Me.wiganNews.AutoSize = True
        Me.wiganNews.BackColor = System.Drawing.Color.Transparent
        Me.wiganNews.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wiganNews.ForeColor = System.Drawing.Color.Black
        Me.wiganNews.Location = New System.Drawing.Point(486, 8)
        Me.wiganNews.Name = "wiganNews"
        Me.wiganNews.Size = New System.Drawing.Size(448, 90)
        Me.wiganNews.TabIndex = 29
        Me.wiganNews.Text = "Wigan News"
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 228)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNewAccount)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "mainMenu"
        Me.Text = "mainMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnNewAccount As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents wiganNews As Label
End Class
