Public Class frmMain
    Private Loading As Boolean = True
    Private protect As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grdComposite.AllowWrapping = True
        grdSubmittals.AllowWrapping = True
        grdRaw1.AllowWrapping = True
        grdRaw2.AllowWrapping = True

        pnlTab1.Visible = False
        pnlTab2.Visible = False
        pnlTab3.Visible = False

        If App.IsMember("IT DEVELOPER") Or App.User = "FOWLERJ" Or App.User = "SHEPPART" Or App.User = "MCCULLOJ" Then
            protect = False
        Else
            tcMain.TabPages.Remove(tpRaw1)
            tcMain.TabPages.Remove(tpRaw2)
        End If

        RetrieveSettings()
        LoadAuthorizedDivisions()

        Loading = False
    End Sub


    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        If cboRegion.Items.Count <= 0 Then
            CTS.Controls.CTSMessage.ShowDialog("There are no Authorized Regions...",
                                               "Near Miss",
                                               CTS.Controls.CTSMessage.ButtonPresets.OK)
        End If

        ApplyDateFilters()

    End Sub

    Private Sub LoadAuthorizedDivisions()

        Dim Sql = "Select Distinct trim(Column6) Description From cwprddta.CWVW45_364"
        Dim CompanyList As DataTable = App.Data.GetTable(Sql)
        For Each dr In CompanyList.Rows
            If App.IsSubOrgMember("CORP_NM", GetCompanyCode(dr("Description"))) Then
                cboRegion.Items.Add(dr("Description"))
            End If
        Next

        If cboRegion.Items.Count >= 1 Then
            cboRegion.SelectedIndex = 0
        Else
            If Not Loading Then
                CTS.Controls.CTSMessage.ShowDialog("There are no Authorized Regions...",
                                               "Near Miss",
                                               CTS.Controls.CTSMessage.ButtonPresets.OK)
            End If
        End If

    End Sub


    Private Sub RetrieveSettings()
        App.GetApplicationSetting(Me)

        Dim FromDate As String = App.GetApplicationSetting("RiskManagement", Me.Name, "FromDate")
        If IsDate(FromDate) Then
            CtsDateTime1.Value = FromDate
        Else
            CtsDateTime1.Value = Today.AddMonths(-1)
        End If

        Dim ToDate As String = App.GetApplicationSetting("RiskManagement", Me.Name, "ToDate")
        If IsDate(ToDate) Then
            CtsDateTime2.Value = ToDate
        Else
            CtsDateTime2.Value = Today
        End If

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRegion.SelectedIndexChanged
        ApplyCompanyFilter()
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles cboRegion.Enter
        ' ComboBox1.ForeColor = Color.White
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles cboRegion.Leave
        ' ComboBox1.ForeColor = Color.Black
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ApplyDateFilters()
    End Sub

    Private Sub ApplyCompanyFilter()
        grdSubmittals.ClearProgramFilters()
        grdSubmittals.AddFilter("COLUMN6", "=", cboRegion.SelectedItem,, False, "System.String", "*PROGRAM", True)

        grdComposite.ClearProgramFilters()
        grdComposite.AddFilter("C6", "=", cboRegion.SelectedItem,, False, "System.String", "*PROGRAM", True)

        If Not Loading Then
            grdSubmittals.RefreshData()
            grdComposite.RefreshData()
        End If

    End Sub

    Private Sub ApplyDateFilters()

        Dim d1 As Date = CtsDateTime1.Value
        grdSubmittals.AddFilter("F45SUBZ", ">=", d1.ToString("yyyy-MM-dd-00.00.00.000000"),, False, "System.DateTime", "*PROGRAM", True)
        grdComposite.AddFilter("F45SUBZ", ">=", d1.ToString("yyyy-MM-dd-00.00.00.000000"),, False, "System.DateTime", "*PROGRAM", True)

        Dim d2 As Date = CtsDateTime2.Value
        grdSubmittals.AddFilter("F45SUBZ", "<=", d2.ToString("yyyy-MM-dd-23.59.59.999999"),, False, "System.DateTime", "*PROGRAM", True)
        grdComposite.AddFilter("F45SUBZ", "<=", d2.ToString("yyyy-MM-dd-23.59.59.999999"),, False, "System.DateTime", "*PROGRAM", True)

        If Not Loading Then
            grdSubmittals.RefreshData()
            grdComposite.RefreshData()
        End If
    End Sub




    Private Function GetCompanyCode_XXX(Description As String) As String
        Dim result As String = String.Empty

        Select Case Description.ToLower
            Case "Blakeley Boatworks".ToLower
                result = "BBW"
            Case "C/PA (Cooper/Ports America)", "Cooper/Ports America".ToLower
                result = "C/PA"
            Case "Plimsoll Marine".ToLower
                result = "PIMMARINE"
            Case "Cooper Marine and Timberland - Chipco", "CMT Stevedoring (Chipco)".ToLower
                result = "CMTCHIPCO"
            Case "Cooper Marine and Timberland - Marine", "CMT Marine"
                result = "CMTMARINE"
            Case "cooper consolidated stevedoring", "cooper consolidated"
                result = "CCS"
            Case "Cooper/T. Smith Mooring", "cts mooring"
                result = "MOORING"
            Case "Cooper/T. Smith - Charleston"
                result = "CTSCHARLES"
            Case Else
                If Description.ToLower.StartsWith("crescent towing") Then
                    result = "CRESCENTNOL"
                ElseIf Description.ToLower.StartsWith("csa") Then
                    result = "CSA"
                ElseIf Description.ToLower.StartsWith("cooper consolidated") Then
                    result = "CCS"
                End If
        End Select

        Return result
    End Function

    Private Function GetCompanyCode(Description As String) As String
        Dim result As String = String.Empty
        result = App.Data.GetSQLValue($"select Trim(suborg) from ctsgpl.gtf_38 where cmp_name = '{Description}'")
        Return result
    End Function

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        App.SaveApplicationSetting(Me)
        App.SaveApplicationSetting("RiskManagement", Me.Name, "FromDate", CtsDateTime1.Value.ToString)
        App.SaveApplicationSetting("RiskManagement", Me.Name, "ToDate", CtsDateTime2.Value.ToString)
    End Sub

    Private Sub grdTab1_dgv_MouseDoubleClick(sender As Object, e As EventArgs) Handles grdSubmittals.dgv_MouseDoubleClick

        If grdSubmittals.dgvCTS.CurrentRow IsNot Nothing Then

            Dim dgvr As DataGridViewRow = grdSubmittals.dgvCTS.CurrentRow
            Dim FID As Integer = dgvr.Cells("F45FID").Value

            Dim f As New NMDetail
            f.SubmittedForm = FID
            f.ShowDialog()
        End If

    End Sub

    Private Sub CTSGrid1_dgv_MouseDoubleClick(sender As Object, e As EventArgs) Handles grdComposite.dgv_MouseDoubleClick

        If grdComposite.dgvCTS.CurrentRow IsNot Nothing Then

            Dim dgvr As DataGridViewRow = grdComposite.dgvCTS.CurrentRow
            Dim FID As Integer = dgvr.Cells("F45FID").Value

            Dim f As New NMDetail
            f.SubmittedForm = FID
            f.ShowDialog()
        End If

    End Sub
End Class
