<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grdTab1 = New CTS.Controls.CTSGrid()
        Me.tcMain = New CTS.Controls.TabControlCTS()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlTab1 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdTab2 = New CTS.Controls.CTSGrid()
        Me.pnlTab2 = New System.Windows.Forms.Panel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.grdTab3 = New CTS.Controls.CTSGrid()
        Me.pnlTab3 = New System.Windows.Forms.Panel()
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.CtsDateTime1 = New CTS.Controls.CTSDateTime()
        Me.CtsDateTime2 = New CTS.Controls.CTSDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CtsGrid1 = New CTS.Controls.CTSGrid()
        Me.tcMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdTab1
        '
        Me.grdTab1.AllowFilter = True
        Me.grdTab1.AllowSort = True
        Me.grdTab1.AllowWrapping = False
        Me.grdTab1.AutoRefresh = 0
        Me.grdTab1.BackColor = System.Drawing.Color.Honeydew
        Me.grdTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grdTab1.BannerText = Nothing
        Me.grdTab1.ConnectionString = Nothing
        Me.grdTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTab1.GridApp = "CW"
        Me.grdTab1.GridMode = CTS.Controls.GridModes.Display
        Me.grdTab1.GridName = "FormSbm_364"
        Me.grdTab1.LoadMethod = CTS.Controls.GridLoadMethods.DataTable
        Me.grdTab1.Location = New System.Drawing.Point(3, 52)
        Me.grdTab1.Name = "grdTab1"
        Me.grdTab1.PrimaryKeys = Nothing
        Me.grdTab1.SelectionDelay = 0
        Me.grdTab1.ShowBanner = True
        Me.grdTab1.ShowStatusStrip = True
        Me.grdTab1.ShowTotals = False
        Me.grdTab1.Size = New System.Drawing.Size(879, 327)
        Me.grdTab1.TabIndex = 0
        Me.grdTab1.UpdateMethod = CTS.Controls.GridUpdateMethods.None
        '
        'tcMain
        '
        Me.tcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcMain.Controls.Add(Me.TabPage1)
        Me.tcMain.Controls.Add(Me.TabPage2)
        Me.tcMain.Controls.Add(Me.TabPage3)
        Me.tcMain.Controls.Add(Me.TabPage4)
        Me.tcMain.CustomStyle = CTS.Controls.TabControlCTS.CustomStyles.Chrome
        Me.tcMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tcMain.HoverBackcolor = System.Drawing.Color.Empty
        Me.tcMain.HoverForecolor = System.Drawing.Color.Black
        Me.tcMain.Location = New System.Drawing.Point(12, 39)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.SelectedTabBackcolor = System.Drawing.Color.Empty
        Me.tcMain.SelectedTabForecolor = System.Drawing.Color.Black
        Me.tcMain.Size = New System.Drawing.Size(893, 411)
        Me.tcMain.TabIndex = 1
        Me.tcMain.UnselectedTabBackcolor = System.Drawing.Color.Empty
        Me.tcMain.UnselectedTabForecolor = System.Drawing.Color.Black
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grdTab1)
        Me.TabPage1.Controls.Add(Me.pnlTab1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(885, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Near Miss Submittals"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlTab1
        '
        Me.pnlTab1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTab1.Location = New System.Drawing.Point(3, 3)
        Me.pnlTab1.Name = "pnlTab1"
        Me.pnlTab1.Size = New System.Drawing.Size(879, 49)
        Me.pnlTab1.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdTab2)
        Me.TabPage2.Controls.Add(Me.pnlTab2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(885, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Initial Review"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grdTab2
        '
        Me.grdTab2.AllowFilter = True
        Me.grdTab2.AllowSort = True
        Me.grdTab2.AllowWrapping = False
        Me.grdTab2.AutoRefresh = 0
        Me.grdTab2.BackColor = System.Drawing.Color.Honeydew
        Me.grdTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grdTab2.BannerText = Nothing
        Me.grdTab2.ConnectionString = Nothing
        Me.grdTab2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTab2.GridApp = "CW"
        Me.grdTab2.GridMode = CTS.Controls.GridModes.Display
        Me.grdTab2.GridName = "FormSbm_368"
        Me.grdTab2.LoadMethod = CTS.Controls.GridLoadMethods.DataTable
        Me.grdTab2.Location = New System.Drawing.Point(3, 55)
        Me.grdTab2.Name = "grdTab2"
        Me.grdTab2.PrimaryKeys = Nothing
        Me.grdTab2.SelectionDelay = 0
        Me.grdTab2.ShowBanner = True
        Me.grdTab2.ShowStatusStrip = True
        Me.grdTab2.ShowTotals = False
        Me.grdTab2.Size = New System.Drawing.Size(879, 324)
        Me.grdTab2.TabIndex = 1
        Me.grdTab2.UpdateMethod = CTS.Controls.GridUpdateMethods.None
        '
        'pnlTab2
        '
        Me.pnlTab2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTab2.Location = New System.Drawing.Point(3, 3)
        Me.pnlTab2.Name = "pnlTab2"
        Me.pnlTab2.Size = New System.Drawing.Size(879, 52)
        Me.pnlTab2.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.grdTab3)
        Me.TabPage3.Controls.Add(Me.pnlTab3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(885, 382)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Corporate Review"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'grdTab3
        '
        Me.grdTab3.AllowFilter = True
        Me.grdTab3.AllowSort = True
        Me.grdTab3.AllowWrapping = False
        Me.grdTab3.AutoRefresh = 0
        Me.grdTab3.BackColor = System.Drawing.Color.Honeydew
        Me.grdTab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grdTab3.BannerText = Nothing
        Me.grdTab3.ConnectionString = Nothing
        Me.grdTab3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTab3.GridApp = "CW"
        Me.grdTab3.GridMode = CTS.Controls.GridModes.Display
        Me.grdTab3.GridName = "FormSbm_369"
        Me.grdTab3.LoadMethod = CTS.Controls.GridLoadMethods.DataTable
        Me.grdTab3.Location = New System.Drawing.Point(3, 55)
        Me.grdTab3.Name = "grdTab3"
        Me.grdTab3.PrimaryKeys = Nothing
        Me.grdTab3.SelectionDelay = 0
        Me.grdTab3.ShowBanner = True
        Me.grdTab3.ShowStatusStrip = True
        Me.grdTab3.ShowTotals = False
        Me.grdTab3.Size = New System.Drawing.Size(879, 324)
        Me.grdTab3.TabIndex = 3
        Me.grdTab3.UpdateMethod = CTS.Controls.GridUpdateMethods.None
        '
        'pnlTab3
        '
        Me.pnlTab3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTab3.Location = New System.Drawing.Point(3, 3)
        Me.pnlTab3.Name = "pnlTab3"
        Me.pnlTab3.Size = New System.Drawing.Size(879, 52)
        Me.pnlTab3.TabIndex = 4
        '
        'cboRegion
        '
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.Location = New System.Drawing.Point(12, 12)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(289, 21)
        Me.cboRegion.TabIndex = 2
        '
        'CtsDateTime1
        '
        Me.CtsDateTime1.AllowIncrement = False
        Me.CtsDateTime1.BackColor = System.Drawing.Color.Transparent
        Me.CtsDateTime1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CtsDateTime1.EditFormat = CTS.Controls.CTSDateTime.DisplayType.DateOnly
        Me.CtsDateTime1.Location = New System.Drawing.Point(612, 12)
        Me.CtsDateTime1.Margin = New System.Windows.Forms.Padding(0)
        Me.CtsDateTime1.MaxValue = New Date(CType(0, Long))
        Me.CtsDateTime1.MinValue = New Date(CType(0, Long))
        Me.CtsDateTime1.Name = "CtsDateTime1"
        Me.CtsDateTime1.ProviderFormat = CTS.Controls.CTSDateTime.ProviderType.DateOnly
        Me.CtsDateTime1.ReadOnly = False
        Me.CtsDateTime1.ReadOnlyBackColor = System.Drawing.Color.White
        Me.CtsDateTime1.ShowCalendarPrompt = True
        Me.CtsDateTime1.ShowDateCheckBox = False
        Me.CtsDateTime1.Size = New System.Drawing.Size(95, 22)
        Me.CtsDateTime1.TabIndex = 0
        Me.CtsDateTime1.Value = New Date(CType(0, Long))
        '
        'CtsDateTime2
        '
        Me.CtsDateTime2.AllowIncrement = False
        Me.CtsDateTime2.BackColor = System.Drawing.Color.Transparent
        Me.CtsDateTime2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CtsDateTime2.EditFormat = CTS.Controls.CTSDateTime.DisplayType.DateOnly
        Me.CtsDateTime2.Location = New System.Drawing.Point(746, 12)
        Me.CtsDateTime2.Margin = New System.Windows.Forms.Padding(0)
        Me.CtsDateTime2.MaxValue = New Date(CType(0, Long))
        Me.CtsDateTime2.MinValue = New Date(CType(0, Long))
        Me.CtsDateTime2.Name = "CtsDateTime2"
        Me.CtsDateTime2.ProviderFormat = CTS.Controls.CTSDateTime.ProviderType.DateOnly
        Me.CtsDateTime2.ReadOnly = False
        Me.CtsDateTime2.ReadOnlyBackColor = System.Drawing.Color.White
        Me.CtsDateTime2.ShowCalendarPrompt = True
        Me.CtsDateTime2.ShowDateCheckBox = False
        Me.CtsDateTime2.Size = New System.Drawing.Size(95, 22)
        Me.CtsDateTime2.TabIndex = 1
        Me.CtsDateTime2.Value = New Date(CType(0, Long))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(576, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(720, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(845, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(56, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CtsGrid1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(885, 382)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Near Miss Composite Summary"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CtsGrid1
        '
        Me.CtsGrid1.AllowFilter = True
        Me.CtsGrid1.AllowSort = True
        Me.CtsGrid1.AllowWrapping = True
        Me.CtsGrid1.AutoRefresh = 0
        Me.CtsGrid1.BackColor = System.Drawing.Color.Honeydew
        Me.CtsGrid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CtsGrid1.BannerText = Nothing
        Me.CtsGrid1.ConnectionString = Nothing
        Me.CtsGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtsGrid1.GridApp = "CW"
        Me.CtsGrid1.GridMode = CTS.Controls.GridModes.Display
        Me.CtsGrid1.GridName = "CW_NearMiss"
        Me.CtsGrid1.LoadMethod = CTS.Controls.GridLoadMethods.DataTable
        Me.CtsGrid1.Location = New System.Drawing.Point(3, 3)
        Me.CtsGrid1.Name = "CtsGrid1"
        Me.CtsGrid1.PrimaryKeys = Nothing
        Me.CtsGrid1.SelectionDelay = 0
        Me.CtsGrid1.ShowBanner = True
        Me.CtsGrid1.ShowStatusStrip = True
        Me.CtsGrid1.ShowTotals = False
        Me.CtsGrid1.Size = New System.Drawing.Size(879, 376)
        Me.CtsGrid1.TabIndex = 4
        Me.CtsGrid1.UpdateMethod = CTS.Controls.GridUpdateMethods.None
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 462)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboRegion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tcMain)
        Me.Controls.Add(Me.CtsDateTime2)
        Me.Controls.Add(Me.CtsDateTime1)
        Me.Name = "frmMain"
        Me.Text = "Risk Management - Near Miss "
        Me.tcMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdTab1 As CTS.Controls.CTSGrid
    Friend WithEvents tcMain As CTS.Controls.TabControlCTS
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pnlTab1 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents grdTab2 As CTS.Controls.CTSGrid
    Friend WithEvents pnlTab2 As Panel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents grdTab3 As CTS.Controls.CTSGrid
    Friend WithEvents pnlTab3 As Panel
    Friend WithEvents cboRegion As ComboBox
    Friend WithEvents CtsDateTime1 As CTS.Controls.CTSDateTime
    Friend WithEvents CtsDateTime2 As CTS.Controls.CTSDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CtsGrid1 As CTS.Controls.CTSGrid
End Class
