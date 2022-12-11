<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.btnAccount = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.PictureBox()
        CType(Me.btnAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAccount
        '
        Me.btnAccount.Image = Global.reviewsProj.My.Resources.Resources.BtnAdd
        Me.btnAccount.Location = New System.Drawing.Point(75, 105)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(225, 116)
        Me.btnAccount.TabIndex = 0
        Me.btnAccount.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Image = Global.reviewsProj.My.Resources.Resources.BtnAdd
        Me.btnLogin.Location = New System.Drawing.Point(413, 105)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(308, 141)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.TabStop = False
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnAccount)
        Me.Name = "mainMenu"
        Me.Text = "mainMenu"
        CType(Me.btnAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAccount As PictureBox
    Friend WithEvents btnLogin As PictureBox
End Class
