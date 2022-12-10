<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.pbStaff = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbUser
        '
        Me.pbUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(76, 104)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(300, 100)
        Me.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbUser.TabIndex = 7
        Me.pbUser.TabStop = False
        '
        'pbStaff
        '
        Me.pbStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbStaff.Image = CType(resources.GetObject("pbStaff.Image"), System.Drawing.Image)
        Me.pbStaff.Location = New System.Drawing.Point(76, 234)
        Me.pbStaff.Name = "pbStaff"
        Me.pbStaff.Size = New System.Drawing.Size(300, 100)
        Me.pbStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbStaff.TabIndex = 10
        Me.pbStaff.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(169, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(456, 354)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbStaff)
        Me.Controls.Add(Me.pbUser)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "mainMenu"
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents pbStaff As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
