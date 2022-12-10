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
        Me.SuspendLayout()
        '
        'btnBackUp
        '
        Me.btnBackUp.Location = New System.Drawing.Point(322, 250)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(75, 23)
        Me.btnBackUp.TabIndex = 0
        Me.btnBackUp.Text = "backup"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'emailsBackupsStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(519, 350)
        Me.Controls.Add(Me.btnBackUp)
        Me.Name = "emailsBackupsStatistics"
        Me.Text = "emailsBackupsStatistics"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBackUp As Button
End Class
