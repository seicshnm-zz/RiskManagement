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
        Me.grdSubmittals = New CTS.Controls.CTSGrid()
        Me.tcMain = New CTS.Controls.TabControlCTS()
        Me.tpSubmittals = New System.Windows.Forms.TabPage()
        Me.pnlTab1 = New System.Windows.Forms.Panel()
        Me.tpRaw1 = New System.Windows.Forms.TabPage()
        Me.grdRaw1 = New CTS.Controls.CTSGrid()
        Me.pnlTab2 = New System.Windows.Forms.Panel()
        Me.tpRaw2 = New System.Windows.Forms.TabPage()
        Me.grdRaw2 = New CTS.Controls.CTSGrid()
        Me.pnlTab3 = New System.Windows.Forms.Panel()
        Me.tpComposite = New System.Windows.Forms.TabPage()
        Me.grdComposite = New CTS.Controls.CTSGrid()
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.CtsDateTime1 = New CTS.Controls.CTSDateTime()
        Me.CtsDateTime2 = New CTS.Controls.CTSDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.tcMain.SuspendLayout()
        Me.tpSubmittals.SuspendLayout()
        Me.tpRaw1.SuspendLayout()
        Me.tpRaw2.SuspendLayout()
        Me.tpComposite.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdSubmittals
        '
        Me.grdSubmittals.AllowFilter = True
        Me.grdSubmittals.AllowSort = True
        Me.grdSubmittals.AllowWrapping = False
        Me.grdSubmittals.AutoRefresh = 0
        Me.grdSubmittals.BackColor = System.Drawing.Color.Honeydew
        Me.grdSubmittals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grdSubmittals.BannerText = Nothing
        Me.grdSubmittals.ConnectionString = Nothing
        Me.grdSubmittals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSubmittals.GridApp = "CW"
        Me.grdSubmittals.GridMode = CTS.Controls.GridModes.Display
        Me.grdSubmittals.GridName = "FormSbm_364"
        Me.grdSubmittals.LoadMethod = CTS.Controls.GridLoadMethods.DataTable
        Me.grdSubmittals.Location = New System.Drawing.Point(3, 52)
        Me.grdSubmittals.Name = "grdSubmittals"
        Me.grdSubmittals.PrimaryKeys = Nothing
        Me.grdSubmittals.SelectionDelay = 0
        Me.grdSubmittals.ShowBanner = True
        Me.grdSubmittals.ShowStatusStrip = True
        Me.grdSubmittals.ShowTotals = False
        Me.grdSubmittals.Size = New System.Drawing.Size(879, 327)
        Me.grdSubmittals.TabIndex = 0
        Me.grdSubmittals.UpdateMethod = CTS.Controls.GridUpdateMethods.None
        '
        'tcMain
        '
        Me.tcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcMain.Controls.Add(Me.tpComposite)
        Me.tcMain.Controls.Add(Me.tpSubmittals)
        Me.tcMain.Controls.Add(Me.tpRaw1)
        Me.tcMain.Controls.Add(Me.tpRaw2)
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
        'tpSubmittals
        '
        Me.tpSubmittals.Controls.Add(Me.grdSubmittals)
        Me.tpSubmittals.Controls.Add(Me.pnlTab1)
        Me.tpSubmittals.Location = New System.Drawing.Point(4, 25)
        Me.tpSubmittals.Name = "tpSubmittals"
        Me.tpSubmittals.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSubmittals.Size = New System.Drawing.Size(885, 382)
        Me.tpSubmittals.TabIndex = 0
        Me.tpSubmittals.Text = "Near Miss Submittals"
        Me.tpSubmittals.UseVisualStyleBackColor = True
        '
        'pnlTab1
        '
        Me.pnlTab1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTab1.Location = New System.Drawing.Point(3, 3)
        Me.pnlTab1.Name = "pnlTab1"
        Me.pnlTab1.Size = New System.Drawing.Size(879, 49)
        Me.pnlTab1.TabIndex = 3
        '
        'tpRaw1
        '
        Me.tpRaw1.Controls.Add(Me.grdRaw1)
        Me.tpRaw1.Controls.Add(Me.pnlTab2)
        Me.tpRaw1.Location = New System.Drawing.Point(4, 25)
        Me.tpRaw1.Name = "tpRaw1"
        Me.tpRaw1.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRaw1.Size = New System.Drawing.Size(885, 382)
        Me.tpRaw1.TabIndex = 1
        Me.tpRaw1.Text = "Initial Review"
        Me.tpRaw1.UseVisualStyleBackColor = True
        '
        'grdRaw1
        '
        Me.grdRaw1.AllowFilter = True
        Me.grdRaw1.AllowSort = True
        Me.grdRaw1.AllowWrapping = False
        Me.grdRaw1.AutoRefresh = 0
        Me.grdRaw1.BackColor = System.Drawing.Color.Honeydew
        Me.grdRaw1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grdRaw1.BannerText = Nothing
        Me.grdRaw1.ConnectionString = Nothing
        Me.grdRaw1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRaw1.GridApp = "CW"
        Me.grdRaw1.GridMode = CTS.Controls.GridModes.Display
        Me.grdRaw1.GridName = "FormSbm_368"
        Me.grdRaw1.LoadMethod = CTS.Controls.GridLoadMethods.DataTable
        Me.grdRaw1.Location = New System.Drawing.Point(3, 55)
        Me.grdRaw1.Name = "grdRaw1"
        Me.grdRaw1.PrimaryKeys = Nothing
        Me.grdRaw1.SelectionDelay = 0
        Me.grdRaw1.ShowBanner = True
        Me.grdRaw1.ShowStatusStrip = True
        Me.grdRaw1.ShowTotals = False
        Me.grdRaw1.Size = New System.Drawing.Size(879, 324)
        Me.grdRaw1.TabIndex = 1
        Me.grdRaw1.UpdateMethod = CTS.Controls.GridUpdateMethods.None
        '
        'pnlTab2
        '
        Me.pnlTab2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTab2.Location = New System.Drawing.Point(3, 3)
        Me.pnlTab2.Name = "pnlTab2"
        Me.pnlTab2.Size = New System.Drawing.Size(879, 52)
        Me.pnlTab2.TabIndex = 2
        '
        'tpRaw2
        '
        Me.tpRaw2.Controls.Add(Me.grdRaw2)
        Me.tpRaw2.Controls.Add(Me.pnlTab3)
        Me.tpRaw2.Location = New System.Drawing.Point(4, 25)
        Me.tpRaw2.Name = "tpRaw2"
        Me.tpRaw2.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRaw2.Size = New System.Drawing.Size(885, 382)
        Me.tpRaw2.TabIndex = 2
        Me.tpRaw2.Text = "Corporate Review"
        Me.tpRaw2.UseVisualStyleBackColor = True
        '
        'grdRaw2
        '
        Me.grdRaw2.AllowFilter = True
        Me.grdRaw2.AllowSort = True
        Me.grdRaw2.AllowWrapping = False
        Me.grdRaw2.AutoRefresh = 0
        Me.grdRaw2.BackColor = System.Drawing.Color.Honeydew
        Me.grdRaw2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grdRaw2.BannerText = Nothing
        Me.grdRaw2.ConnectionString = Nothing
        Me.grdRaw2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRaw2.GridApp = "CW"
        Me.grdRaw2.GridMode = CTS.Controls.GridModes.Display
        Me.grdRaw2.GridName = "FormSbm_369"
        Me.grdRaw2.LoadMethod = CTS.Controls.GridLoadMethods.DataTable
        Me.grdRaw2.Location = New System.Drawing.Point(3, 55)
        Me.grdRaw2.Name = "grdRaw2"
        Me.grdRaw2.PrimaryKeys = Nothing
        Me.grdRaw2.SelectionDelay = 0
        Me.grdRaw2.ShowBanner = True
        Me.grdRaw2.ShowStatusStrip = True
        Me.grdRaw2.ShowTotals = False
        Me.grdRaw2.Size = New System.Drawing.Size(879, 324)
        Me.grdRaw2.TabIndex = 3
        Me.grdRaw2.UpdateMethod = CTS.Controls.GridUpdateMethods.None
        '
        'pnlTab3
        '
        Me.pnlTab3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTab3.Location = New System.Drawing.Point(3, 3)
        Me.pnlTab3.Name = "pnlTab3"
        Me.pnlTab3.Size = New System.Drawing.Size(879, 52)
        Me.pnlTab3.TabIndex = 4
        '
        'tpComposite
        '
        Me.tpComposite.Controls.Add(Me.grdComposite)
        Me.tpComposite.Location = New System.Drawing.Point(4, 25)
        Me.tpComposite.Name = "tpComposite"
        Me.tpComposite.Padding = New System.Windows.Forms.Padding(3)
        Me.tpComposite.Size = New System.Drawing.Size(885, 382)
        Me.tpComposite.TabIndex = 3
        Me.tpComposite.Text = "Near Miss Composite Summary"
        Me.tpComposite.UseVisualStyleBackColor = True
        '
        'grdComposite
        '
        Me.grdComposite.AllowFilter = True
        Me.grdComposite.AllowSort = True
        Me.grdComposite.AllowWrapping = True
        Me.grdComposite.AutoRefresh = 0
        Me.grdComposite.BackColor = System.Drawing.Color.Honeydew
        Me.grdComposite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grdComposite.BannerText = Nothing
        Me.grdComposite.ConnectionString = Nothing
        Me.grdComposite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdComposite.GridApp = "CW"
        Me.grdComposite.GridMode = CTS.Controls.GridModes.Display
        Me.grdComposite.GridName = "CW_NearMiss"
        Me.grdComposite.LoadMethod = CTS.Controls.GridLoadMethods.DataTable
        Me.grdComposite.Location = New System.Drawing.Point(3, 3)
        Me.grdComposite.Name = "grdComposite"
        Me.grdComposite.PrimaryKeys = Nothing
        Me.grdComposite.SelectionDelay = 0
        Me.grdComposite.ShowBanner = True
        Me.grdComposite.ShowStatusStrip = True
        Me.grdComposite.ShowTotals = False
        Me.grdComposite.Size = New System.Drawing.Size(879, 376)
        Me.grdComposite.TabIndex = 4
        Me.grdComposite.UpdateMethod = CTS.Controls.GridUpdateMethods.None
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
        Me.tpSubmittals.ResumeLayout(False)
        Me.tpRaw1.ResumeLayout(False)
        Me.tpRaw2.ResumeLayout(False)
        Me.tpComposite.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdSubmittals As CTS.Controls.CTSGrid
    Friend WithEvents tcMain As CTS.Controls.TabControlCTS
    Friend WithEvents tpSubmittals As TabPage
    Friend WithEvents pnlTab1 As Panel
    Friend WithEvents tpRaw1 As TabPage
    Friend WithEvents grdRaw1 As CTS.Controls.CTSGrid
    Friend WithEvents pnlTab2 As Panel
    Friend WithEvents tpRaw2 As TabPage
    Friend WithEvents grdRaw2 As CTS.Controls.CTSGrid
    Friend WithEvents pnlTab3 As Panel
    Friend WithEvents cboRegion As ComboBox
    Friend WithEvents CtsDateTime1 As CTS.Controls.CTSDateTime
    Friend WithEvents CtsDateTime2 As CTS.Controls.CTSDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents tpComposite As TabPage
    Friend WithEvents grdComposite As CTS.Controls.CTSGrid
End Class
