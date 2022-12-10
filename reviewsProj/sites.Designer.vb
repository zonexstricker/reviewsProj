<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sites
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
        Me.SiteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiteName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiteWebAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SitePostcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SiteID, Me.SiteName, Me.SiteWebAddress, Me.SitePostcode})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 282)
        Me.DataGridView1.TabIndex = 0
        '
        'SiteID
        '
        Me.SiteID.HeaderText = "Site ID"
        Me.SiteID.Name = "SiteID"
        '
        'SiteName
        '
        Me.SiteName.HeaderText = "Site Name"
        Me.SiteName.Name = "SiteName"
        '
        'SiteWebAddress
        '
        Me.SiteWebAddress.HeaderText = "Site Web Address"
        Me.SiteWebAddress.Name = "SiteWebAddress"
        '
        'SitePostcode
        '
        Me.SitePostcode.HeaderText = "Site Postcode"
        Me.SitePostcode.Name = "SitePostcode"
        '
        'sites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 309)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "sites"
        Me.Text = "Sites"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SiteID As DataGridViewTextBoxColumn
    Friend WithEvents SiteName As DataGridViewTextBoxColumn
    Friend WithEvents SiteWebAddress As DataGridViewTextBoxColumn
    Friend WithEvents SitePostcode As DataGridViewTextBoxColumn
End Class
