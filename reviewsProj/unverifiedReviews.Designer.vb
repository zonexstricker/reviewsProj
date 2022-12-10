<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class unverifiedReviews
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
        Me.components = New System.ComponentModel.Container()
        Me.ReviewsDBDataSet = New reviewsProj.reviewsDBDataSet()
        Me.UnverifiedReviewsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnverifiedReviewsTableAdapter = New reviewsProj.reviewsDBDataSetTableAdapters.unverifiedReviewsTableAdapter()
        Me.txtBoxSpd = New System.Windows.Forms.TextBox()
        Me.txtBoxQual = New System.Windows.Forms.TextBox()
        Me.txtBoxServ = New System.Windows.Forms.TextBox()
        Me.txtBoxQuant = New System.Windows.Forms.TextBox()
        Me.txtBoxResp = New System.Windows.Forms.TextBox()
        Me.txtBoxCom = New System.Windows.Forms.TextBox()
        Me.txtBoxUnverifiedID = New System.Windows.Forms.TextBox()
        Me.txtBoxSiteID = New System.Windows.Forms.TextBox()
        Me.txtBoxUserID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.wiganNews = New System.Windows.Forms.Label()
        Me.btnReject = New System.Windows.Forms.PictureBox()
        Me.btnPush = New System.Windows.Forms.PictureBox()
        CType(Me.ReviewsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnverifiedReviewsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnReject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPush, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReviewsDBDataSet
        '
        Me.ReviewsDBDataSet.DataSetName = "reviewsDBDataSet"
        Me.ReviewsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnverifiedReviewsBindingSource
        '
        Me.UnverifiedReviewsBindingSource.DataMember = "unverifiedReviews"
        Me.UnverifiedReviewsBindingSource.DataSource = Me.ReviewsDBDataSet
        '
        'UnverifiedReviewsTableAdapter
        '
        Me.UnverifiedReviewsTableAdapter.ClearBeforeFill = True
        '
        'txtBoxSpd
        '
        Me.txtBoxSpd.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxSpd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxSpd.Location = New System.Drawing.Point(214, 127)
        Me.txtBoxSpd.Name = "txtBoxSpd"
        Me.txtBoxSpd.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxSpd.TabIndex = 4
        Me.txtBoxSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxQual
        '
        Me.txtBoxQual.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxQual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxQual.Location = New System.Drawing.Point(214, 153)
        Me.txtBoxQual.Name = "txtBoxQual"
        Me.txtBoxQual.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxQual.TabIndex = 5
        Me.txtBoxQual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxServ
        '
        Me.txtBoxServ.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxServ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxServ.Location = New System.Drawing.Point(214, 257)
        Me.txtBoxServ.Name = "txtBoxServ"
        Me.txtBoxServ.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxServ.TabIndex = 9
        Me.txtBoxServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxQuant
        '
        Me.txtBoxQuant.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxQuant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxQuant.Location = New System.Drawing.Point(214, 179)
        Me.txtBoxQuant.Name = "txtBoxQuant"
        Me.txtBoxQuant.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxQuant.TabIndex = 6
        Me.txtBoxQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxResp
        '
        Me.txtBoxResp.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxResp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxResp.Location = New System.Drawing.Point(214, 231)
        Me.txtBoxResp.Name = "txtBoxResp"
        Me.txtBoxResp.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxResp.TabIndex = 8
        Me.txtBoxResp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxCom
        '
        Me.txtBoxCom.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxCom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCom.Location = New System.Drawing.Point(214, 205)
        Me.txtBoxCom.Name = "txtBoxCom"
        Me.txtBoxCom.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxCom.TabIndex = 7
        Me.txtBoxCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxUnverifiedID
        '
        Me.txtBoxUnverifiedID.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxUnverifiedID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxUnverifiedID.Location = New System.Drawing.Point(49, 151)
        Me.txtBoxUnverifiedID.Name = "txtBoxUnverifiedID"
        Me.txtBoxUnverifiedID.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxUnverifiedID.TabIndex = 0
        Me.txtBoxUnverifiedID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxSiteID
        '
        Me.txtBoxSiteID.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxSiteID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxSiteID.Location = New System.Drawing.Point(49, 177)
        Me.txtBoxSiteID.Name = "txtBoxSiteID"
        Me.txtBoxSiteID.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxSiteID.TabIndex = 1
        Me.txtBoxSiteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxUserID
        '
        Me.txtBoxUserID.BackColor = System.Drawing.Color.DarkRed
        Me.txtBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxUserID.Location = New System.Drawing.Point(49, 203)
        Me.txtBoxUserID.Name = "txtBoxUserID"
        Me.txtBoxUserID.Size = New System.Drawing.Size(100, 13)
        Me.txtBoxUserID.TabIndex = 2
        Me.txtBoxUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblCurrentUser)
        Me.Panel1.Controls.Add(Me.wiganNews)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 96)
        Me.Panel1.TabIndex = 31
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.reviewsProj.My.Resources.Resources.black_cube
        Me.PictureBox3.Location = New System.Drawing.Point(4, 86)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(949, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.reviewsProj.My.Resources.Resources.black_cube
        Me.PictureBox1.Location = New System.Drawing.Point(351, -146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 389)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.reviewsProj.My.Resources.Resources.black_cube
        Me.PictureBox6.Location = New System.Drawing.Point(0, -84)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 389)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 32
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.reviewsProj.My.Resources.Resources.black_cube
        Me.PictureBox5.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(949, 10)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.reviewsProj.My.Resources.Resources.prof_pic
        Me.PictureBox2.Location = New System.Drawing.Point(285, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCurrentUser.Location = New System.Drawing.Point(276, 71)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(74, 13)
        Me.lblCurrentUser.TabIndex = 19
        Me.lblCurrentUser.Text = "[USERNAME]"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'wiganNews
        '
        Me.wiganNews.AutoSize = True
        Me.wiganNews.BackColor = System.Drawing.Color.DarkRed
        Me.wiganNews.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wiganNews.ForeColor = System.Drawing.Color.Black
        Me.wiganNews.Location = New System.Drawing.Point(11, 12)
        Me.wiganNews.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.wiganNews.Name = "wiganNews"
        Me.wiganNews.Size = New System.Drawing.Size(269, 55)
        Me.wiganNews.TabIndex = 11
        Me.wiganNews.Text = "Wigan News"
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.Transparent
        Me.btnReject.Image = Global.reviewsProj.My.Resources.Resources.BtnReject
        Me.btnReject.Location = New System.Drawing.Point(20, 284)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(144, 50)
        Me.btnReject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnReject.TabIndex = 32
        Me.btnReject.TabStop = False
        '
        'btnPush
        '
        Me.btnPush.BackColor = System.Drawing.Color.Transparent
        Me.btnPush.Image = Global.reviewsProj.My.Resources.Resources.BtnPush
        Me.btnPush.Location = New System.Drawing.Point(197, 284)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(144, 50)
        Me.btnPush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPush.TabIndex = 33
        Me.btnPush.TabStop = False
        '
        'unverifiedReviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.reviewsProj.My.Resources.Resources.bckgrnd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(359, 350)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.txtBoxSpd)
        Me.Controls.Add(Me.txtBoxQual)
        Me.Controls.Add(Me.txtBoxUnverifiedID)
        Me.Controls.Add(Me.txtBoxServ)
        Me.Controls.Add(Me.txtBoxSiteID)
        Me.Controls.Add(Me.txtBoxQuant)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBoxResp)
        Me.Controls.Add(Me.txtBoxUserID)
        Me.Controls.Add(Me.txtBoxCom)
        Me.Name = "unverifiedReviews"
        Me.Text = "unverifiedReviews"
        CType(Me.ReviewsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnverifiedReviewsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnReject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPush, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReviewsDBDataSet As reviewsDBDataSet
    Friend WithEvents UnverifiedReviewsBindingSource As BindingSource
    Friend WithEvents UnverifiedReviewsTableAdapter As reviewsDBDataSetTableAdapters.unverifiedReviewsTableAdapter
    Friend WithEvents txtBoxSpd As TextBox
    Friend WithEvents txtBoxQual As TextBox
    Friend WithEvents txtBoxServ As TextBox
    Friend WithEvents txtBoxQuant As TextBox
    Friend WithEvents txtBoxResp As TextBox
    Friend WithEvents txtBoxCom As TextBox
    Friend WithEvents txtBoxUnverifiedID As TextBox
    Friend WithEvents txtBoxSiteID As TextBox
    Friend WithEvents txtBoxUserID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblCurrentUser As Label
    Friend WithEvents wiganNews As Label
    Friend WithEvents btnReject As PictureBox
    Friend WithEvents btnPush As PictureBox
End Class
