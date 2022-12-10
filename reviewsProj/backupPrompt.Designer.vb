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
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(206, 285)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 23)
        Me.btnBackup.TabIndex = 6
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'rbEmp
        '
        Me.rbEmp.AutoSize = True
        Me.rbEmp.Location = New System.Drawing.Point(206, 151)
        Me.rbEmp.Name = "rbEmp"
        Me.rbEmp.Size = New System.Drawing.Size(71, 17)
        Me.rbEmp.TabIndex = 7
        Me.rbEmp.TabStop = True
        Me.rbEmp.Text = "Employee"
        Me.rbEmp.UseVisualStyleBackColor = True
        '
        'rbRev
        '
        Me.rbRev.AutoSize = True
        Me.rbRev.Location = New System.Drawing.Point(206, 174)
        Me.rbRev.Name = "rbRev"
        Me.rbRev.Size = New System.Drawing.Size(66, 17)
        Me.rbRev.TabIndex = 8
        Me.rbRev.TabStop = True
        Me.rbRev.Text = "Reviews"
        Me.rbRev.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(206, 197)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Sites"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(206, 220)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton4.TabIndex = 10
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "unverifiedTable"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(206, 243)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton5.TabIndex = 11
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Users"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'backupPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.rbRev)
        Me.Controls.Add(Me.rbEmp)
        Me.Controls.Add(Me.btnBackup)
        Me.Name = "backupPrompt"
        Me.Text = "backupPrompt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackup As Button
    Friend WithEvents rbEmp As RadioButton
    Friend WithEvents rbRev As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
End Class
