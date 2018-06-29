Imports Newtonsoft.Json

Public Class ReportSubTest
    Private test As Test
    Private testslist As List(Of TestResult)
    Private reportcontrol As ReportControl
    Private pretest As Integer
    Public Sub updateData(t As Test, tl As List(Of TestResult), rc As ReportControl)
        Me.test = t
        Me.testslist = tl
        Me.reportcontrol = rc
        ListTests.Items.Clear()
        For Each r As TestResult In testslist
            ListTests.Items.Add(r.name)
        Next
        ListTests.SelectedIndex = 0
    End Sub

    Public Function setData(ByRef t As Test, tr As TestResult) As Boolean
        Return True
    End Function

    Private Sub ListTests_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTests.SelectedIndexChanged
        Dim tr As TestResult = testslist(ListTests.SelectedIndex)
        Dim trp As TestResult = testslist(pretest)
        reportcontrol.setData(test, trp, False)
        reportcontrol.updateData(test, tr)
        pretest = ListTests.SelectedIndex
    End Sub
End Class
