<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NMDetail
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
        Me.wbSubmitted = New System.Windows.Forms.WebBrowser()
        Me.wbReview1 = New System.Windows.Forms.WebBrowser()
        Me.wbReview2 = New System.Windows.Forms.WebBrowser()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblSubmit = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblReview1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.lblReview2 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'wbSubmitted
        '
        Me.wbSubmitted.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbSubmitted.Location = New System.Drawing.Point(0, 25)
        Me.wbSubmitted.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbSubmitted.Name = "wbSubmitted"
        Me.wbSubmitted.Size = New System.Drawing.Size(505, 690)
        Me.wbSubmitted.TabIndex = 2
        '
        'wbReview1
        '
        Me.wbReview1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbReview1.Location = New System.Drawing.Point(0, 25)
        Me.wbReview1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbReview1.Name = "wbReview1"
        Me.wbReview1.Size = New System.Drawing.Size(383, 404)
        Me.wbReview1.TabIndex = 1
        '
        'wbReview2
        '
        Me.wbReview2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbReview2.Location = New System.Drawing.Point(0, 25)
        Me.wbReview2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbReview2.Name = "wbReview2"
        Me.wbReview2.Size = New System.Drawing.Size(383, 257)
        Me.wbReview2.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.wbSubmitted)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(892, 715)
        Me.SplitContainer1.SplitterDistance = 505
        Me.SplitContainer1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lblSubmit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(505, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripLabel1.Text = "Near Miss Submission"
        '
        'lblSubmit
        '
        Me.lblSubmit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblSubmit.Name = "lblSubmit"
        Me.lblSubmit.Size = New System.Drawing.Size(25, 22)
        Me.lblSubmit.Text = "100"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.wbReview1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.wbReview2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip3)
        Me.SplitContainer2.Size = New System.Drawing.Size(383, 715)
        Me.SplitContainer2.SplitterDistance = 429
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.lblReview1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(383, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripLabel2.Text = "Near Miss Review"
        '
        'lblReview1
        '
        Me.lblReview1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblReview1.Name = "lblReview1"
        Me.lblReview1.Size = New System.Drawing.Size(25, 22)
        Me.lblReview1.Text = "100"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.lblReview2})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(383, 25)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel3.Text = "Corporate Review"
        '
        'lblReview2
        '
        Me.lblReview2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblReview2.Name = "lblReview2"
        Me.lblReview2.Size = New System.Drawing.Size(25, 22)
        Me.lblReview2.Text = "100"
        '
        'NMDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 715)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "NMDetail"
        Me.Text = "Near Miss Detail/Forms"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbSubmitted As WebBrowser
    Friend WithEvents wbReview1 As WebBrowser
    Friend WithEvents wbReview2 As WebBrowser
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblSubmit As ToolStripLabel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblReview1 As ToolStripLabel
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents lblReview2 As ToolStripLabel
End Class
