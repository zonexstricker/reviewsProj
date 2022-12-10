<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class publishReview
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbxDeliverySpeed = New System.Windows.Forms.ComboBox()
        Me.cmbxQuality = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbxQuantity = New System.Windows.Forms.ComboBox()
        Me.cmbxCom = New System.Windows.Forms.ComboBox()
        Me.cmbxResp = New System.Windows.Forms.ComboBox()
        Me.cmbxServ = New System.Windows.Forms.ComboBox()
        Me.txtBoxSiteName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Site Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Delivery Speed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quality of Prodcut"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quantity of Product"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ability to Communicate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Response Speed"
        '
        'cmbxDeliverySpeed
        '
        Me.cmbxDeliverySpeed.BackColor = System.Drawing.Color.Firebrick
        Me.cmbxDeliverySpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDeliverySpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxDeliverySpeed.FormattingEnabled = True
        Me.cmbxDeliverySpeed.Items.AddRange(New Object() {"Very Fast", "Fast", "Ok", "Slow", "Very Slow"})
        Me.cmbxDeliverySpeed.Location = New System.Drawing.Point(65, 73)
        Me.cmbxDeliverySpeed.Name = "cmbxDeliverySpeed"
        Me.cmbxDeliverySpeed.Size = New System.Drawing.Size(121, 21)
        Me.cmbxDeliverySpeed.TabIndex = 8
        '
        'cmbxQuality
        '
        Me.cmbxQuality.BackColor = System.Drawing.Color.Firebrick
        Me.cmbxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxQuality.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxQuality.FormattingEnabled = True
        Me.cmbxQuality.Items.AddRange(New Object() {"Very High", "High", "Ok", "Poor", "Very Poor"})
        Me.cmbxQuality.Location = New System.Drawing.Point(65, 97)
        Me.cmbxQuality.Name = "cmbxQuality"
        Me.cmbxQuality.Size = New System.Drawing.Size(121, 21)
        Me.cmbxQuality.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(192, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Service"
        '
        'cmbxQuantity
        '
        Me.cmbxQuantity.BackColor = System.Drawing.Color.Firebrick
        Me.cmbxQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxQuantity.FormattingEnabled = True
        Me.cmbxQuantity.Items.AddRange(New Object() {"Very High", "High", "Medium", "Low", "Very Low"})
        Me.cmbxQuantity.Location = New System.Drawing.Point(65, 121)
        Me.cmbxQuantity.Name = "cmbxQuantity"
        Me.cmbxQuantity.Size = New System.Drawing.Size(121, 21)
        Me.cmbxQuantity.TabIndex = 11
        '
        'cmbxCom
        '
        Me.cmbxCom.BackColor = System.Drawing.Color.Firebrick
        Me.cmbxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxCom.FormattingEnabled = True
        Me.cmbxCom.Items.AddRange(New Object() {"Very Easy", "Easy", "Ok", "Hard", "None"})
        Me.cmbxCom.Location = New System.Drawing.Point(65, 146)
        Me.cmbxCom.Name = "cmbxCom"
        Me.cmbxCom.Size = New System.Drawing.Size(121, 21)
        Me.cmbxCom.TabIndex = 12
        '
        'cmbxResp
        '
        Me.cmbxResp.BackColor = System.Drawing.Color.Firebrick
        Me.cmbxResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxResp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxResp.FormattingEnabled = True
        Me.cmbxResp.Items.AddRange(New Object() {"Very Quick", "Quick", "Ok", "Slow", "None"})
        Me.cmbxResp.Location = New System.Drawing.Point(65, 173)
        Me.cmbxResp.Name = "cmbxResp"
        Me.cmbxResp.Size = New System.Drawing.Size(121, 21)
        Me.cmbxResp.TabIndex = 13
        '
        'cmbxServ
        '
        Me.cmbxServ.BackColor = System.Drawing.Color.Firebrick
        Me.cmbxServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxServ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbxServ.FormattingEnabled = True
        Me.cmbxServ.Items.AddRange(New Object() {"Very Good", "Good", "Ok", "Bad", "None"})
        Me.cmbxServ.Location = New System.Drawing.Point(65, 200)
        Me.cmbxServ.Name = "cmbxServ"
        Me.cmbxServ.Size = New System.Drawing.Size(121, 21)
        Me.cmbxServ.TabIndex = 14
        '
        'txtBoxSiteName
        '
        Me.txtBoxSiteName.BackColor = System.Drawing.Color.Firebrick
        Me.txtBoxSiteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxSiteName.Location = New System.Drawing.Point(65, 47)
        Me.txtBoxSiteName.Name = "txtBoxSiteName"
        Me.txtBoxSiteName.Size = New System.Drawing.Size(121, 20)
        Me.txtBoxSiteName.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.reviewsProj.My.Resources.Resources.BtnSubmit
        Me.PictureBox1.Location = New System.Drawing.Point(61, 252)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'publishReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(425, 364)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBoxSiteName)
        Me.Controls.Add(Me.cmbxServ)
        Me.Controls.Add(Me.cmbxResp)
        Me.Controls.Add(Me.cmbxCom)
        Me.Controls.Add(Me.cmbxQuantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbxQuality)
        Me.Controls.Add(Me.cmbxDeliverySpeed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "publishReview"
        Me.Text = "Publish a Review"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbxDeliverySpeed As ComboBox
    Friend WithEvents cmbxQuality As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbxQuantity As ComboBox
    Friend WithEvents cmbxCom As ComboBox
    Friend WithEvents cmbxResp As ComboBox
    Friend WithEvents cmbxServ As ComboBox
    Friend WithEvents txtBoxSiteName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
