<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reviews
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReviewID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBoxEmployeeID = New System.Windows.Forms.TextBox()
        Me.TxtBoxUserID = New System.Windows.Forms.TextBox()
        Me.TxtBoxSiteID = New System.Windows.Forms.TextBox()
        Me.TxtBoxReviewID = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReviewID, Me.SiteID, Me.UserID, Me.EmployeeID})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(450, 73)
        Me.DataGridView1.TabIndex = 0
        '
        'ReviewID
        '
        Me.ReviewID.HeaderText = "Review ID"
        Me.ReviewID.Name = "ReviewID"
        '
        'SiteID
        '
        Me.SiteID.HeaderText = "Site ID"
        Me.SiteID.Name = "SiteID"
        '
        'UserID
        '
        Me.UserID.HeaderText = "User ID"
        Me.UserID.Name = "UserID"
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "Employee ID"
        Me.EmployeeID.Name = "EmployeeID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Review ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Site ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "User ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Employee ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoxEmployeeID)
        Me.GroupBox1.Controls.Add(Me.TxtBoxUserID)
        Me.GroupBox1.Controls.Add(Me.TxtBoxSiteID)
        Me.GroupBox1.Controls.Add(Me.TxtBoxReviewID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(199, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 130)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'txtBoxEmployeeID
        '
        Me.txtBoxEmployeeID.Location = New System.Drawing.Point(91, 71)
        Me.txtBoxEmployeeID.Name = "txtBoxEmployeeID"
        Me.txtBoxEmployeeID.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxEmployeeID.TabIndex = 8
        '
        'TxtBoxUserID
        '
        Me.TxtBoxUserID.Location = New System.Drawing.Point(91, 50)
        Me.TxtBoxUserID.Name = "TxtBoxUserID"
        Me.TxtBoxUserID.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxUserID.TabIndex = 7
        '
        'TxtBoxSiteID
        '
        Me.TxtBoxSiteID.Location = New System.Drawing.Point(91, 29)
        Me.TxtBoxSiteID.Name = "TxtBoxSiteID"
        Me.TxtBoxSiteID.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxSiteID.TabIndex = 6
        '
        'TxtBoxReviewID
        '
        Me.TxtBoxReviewID.Location = New System.Drawing.Point(91, 8)
        Me.TxtBoxReviewID.Name = "TxtBoxReviewID"
        Me.TxtBoxReviewID.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxReviewID.TabIndex = 5
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(315, 94)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(208, 94)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 7
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(208, 259)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(315, 259)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'reviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 336)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "reviews"
        Me.Text = "Reviews"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReviewID As DataGridViewTextBoxColumn
    Friend WithEvents SiteID As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBoxUserID As TextBox
    Friend WithEvents TxtBoxSiteID As TextBox
    Friend WithEvents TxtBoxReviewID As TextBox
    Friend WithEvents txtBoxEmployeeID As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
