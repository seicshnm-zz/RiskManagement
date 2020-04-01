Public Class NMDetail

    Public SubmittedForm As Integer
    Private ReviewForm As Integer
    Private CorpReviewForm As Integer
    Private Workfolder As String

    Private Sub NMDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Workfolder = IO.Path.Combine(IO.Path.GetTempPath, IO.Path.GetRandomFileName)
        Workfolder = IO.Path.GetTempPath

        GetForms(SubmittedForm)

        lblSubmit.Text = SubmittedForm


    End Sub



    Public Sub GetForms(FID As Integer)

        Dim sqlstr = "SELECT RvwFrm.f45fid RvwFrm, CrpRvwFrm.f45fid CrpRvwFrm " &
 "FROM cwprddta.CWVW45_364 SbmFrm " &
 "Join cwprddta.SCPF1000 SbmAsn ON SbmFrm.F45FID = SbmAsn.F10LINKID And SbmAsn.F10LINKTYP = 'CWFORM' " &
 "Join cwprddta.SCPF1015 RvwLnk ON SbmAsn.F10EID = RvwLnk.F15FEID " &
 "Left Join cwprddta.SCPF1000 RvwAsn ON RvwLnk.F15TEID = RvwAsn.F10EID " &
 "Left JOIN cwprddta.CWVW45_368 RvwFrm ON RvwAsn.F10LINKID = RvwFrm.F45FID " &
 "Left Join cwprddta.SCPF1015 CrpRvwLnk ON RvwLnk.F15TEID = CrpRvwLnk.F15FEID " &
 "Left JOIN cwprddta.SCPF1000 CrpRvwAsn ON CrpRvwAsn.F10EID = CrpRvwLnk.F15TEID " &
 "LEFT JOIN cwprddta.CWVW45_369 CrpRvwFrm ON CrpRvwAsn.F10LINKID = CrpRvwFrm.F45FID " &
 $"Where sbmfrm.f45fid = {FID}"

        Dim dr = App.Data.GetRow(sqlstr)
        If dr IsNot Nothing Then
            ReviewForm = IIf(IsDBNull(dr("RvwFrm")), 0, dr("RvwFrm"))
            CorpReviewForm = IIf(IsDBNull(dr("CrpRvwFrm")), 0, dr("CrpRvwFrm"))

            lblReview1.Text = ReviewForm
            lblReview2.Text = CorpReviewForm
        Else

        End If

        If SubmittedForm > 0 Then
            Dim result1 = LoadFormFile(SubmittedForm)
            wbSubmitted.Navigate("file:///" & result1.Trim)
        End If

        If ReviewForm > 0 Then
            Dim result2 = LoadFormFile(ReviewForm)
            wbReview1.Navigate("file:///" & result2.Trim)
        End If

        If CorpReviewForm > 0 Then
            Dim result3 = LoadFormFile(SubmittedForm)
            wbReview2.Navigate("file:///" & result3.Trim)
        End If

    End Sub




    Public Function LoadFormFile(ByVal FID As Long) As String
        Dim result As String = String.Empty

        Using ms As IO.MemoryStream = App.Data.GetSQLBlob("Select FILEB From cwprddta.cwtb145 Where FORMID = {0}", FID)
            If ms IsNot Nothing Then

                Dim ext = App.Data.GetSQLValue("Select FILET From cwprddta.cwtb145 Where FORMID = {0}", FID)

                If ext.Trim.StartsWith(".") Then
                    result = $"{IO.Path.Combine(Workfolder, FID.ToString.Trim)}{ext.Trim}"
                Else
                    result = $"{IO.Path.Combine(Workfolder, FID.ToString.Trim)}.{ext.Trim}"
                End If

                If IO.File.Exists(result) Then
                    IO.File.Delete(result)
                End If

                Using fs As New IO.FileStream(result, IO.FileMode.Create)
                    ms.CopyTo(fs)
                End Using

                ms.Close()
            End If
        End Using

        Return result
    End Function

End Class