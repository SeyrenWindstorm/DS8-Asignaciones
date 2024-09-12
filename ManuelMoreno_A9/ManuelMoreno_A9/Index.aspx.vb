Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Resp1, Resp2, Resp3, Resp4 As String
        Dim testComp1, testComp2, testComp3, testComp4, Cnt1, cnt2, cnt3, cnt4 As Integer
        Resp1 = "Cristiano"
        Resp2 = "Messi"
        Resp3 = "Brazil"
        Resp4 = "Panamá"

        testComp1 = StrComp(Resp1, RadioButtonList1.Text, CompareMethod.Text)
        testComp2 = StrComp(Resp2, RadioButtonList2.Text, CompareMethod.Text)
        testComp3 = StrComp(Resp3, RadioButtonList3.Text, CompareMethod.Text)
        testComp4 = StrComp(Resp4, RadioButtonList4.Text, CompareMethod.Text)

        If testComp1 = 0 Then
            Cnt1 = +1

        End If

        If testComp2 = 0 Then
                cnt2 = +1
        End If
        If testComp3 = 0 Then
                cnt3 = +1
        End If
        If testComp4 = 0 Then
            cnt4 = +1
        End If

        Resultado.Text = "Has Acertado: " & Cnt1 + cnt2 + cnt3 + cnt4
        Resultado.Visible = True

    End Sub
End Class