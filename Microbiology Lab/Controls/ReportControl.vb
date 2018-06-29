Imports Newtonsoft.Json

Public Class ReportControl
    Private test As Test
    Private testresult As TestResult
    Private mHeight As Integer = 200
    Public Sub updateData(Test As Test, TestResult As TestResult)
        ListPathogen.Items.Clear()
        For Each p As Pathogen In Database.Pathogens
            ListPathogen.Items.Add(p.name)
        Next
        Me.test = Test
        ListResult.SelectedIndex = 0
        ListResult.SelectedIndex = ListResult.FindString(TestResult.result)
        ListGram.SelectedIndex = ListGram.FindString(TestResult.gram)
        ListPathogen.SelectedIndex = ListPathogen.FindString(TestResult.pathogen)
        Dim lkc As List(Of KeyValuePair(Of String, String)) = JsonConvert.DeserializeObject(Of List(Of KeyValuePair(Of String, String)))(TestResult.antibiotics)
        ListAntibiotics.Rows.Clear()
        For Each item As KeyValuePair(Of String, String) In lkc
            Dim row = ListAntibiotics.Rows(ListAntibiotics.Rows.Add)
            CreateAntibioticCell(item.Key, item.Value, row)
        Next
    End Sub

    Public Function setData(ByRef t As Test, tr As TestResult) As Boolean
        If ListResult.SelectedIndex = 0 Then
            Return False
        End If
        If ListResult.SelectedIndex = 2 Then
            If ListGram.SelectedIndex = -1 And ListPathogen.SelectedIndex = -1 Then
                Return False
            End If
        End If
        tr.result = ListResult.SelectedItem
        tr.gram = ListGram.SelectedItem
        tr.pathogen = ListPathogen.SelectedItem
        Dim lkc As New List(Of KeyValuePair(Of String, String))
        For Each row As DataGridViewRow In ListAntibiotics.Rows
            lkc.Add(New KeyValuePair(Of String, String)(GetAntibioticName(row), GetAntibioticValue(row)))
        Next
        tr.antibiotics = JsonConvert.SerializeObject(lkc)
        Return True
    End Function

    Private Sub ListResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListResult.SelectedIndexChanged
        If ListResult.SelectedIndex = 2 Then
            ListGram.Enabled = True
        Else
            ListGram.Enabled = False
            ListGram.SelectedIndex = -1
        End If
    End Sub

    Private Sub ListGram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListGram.SelectedIndexChanged
        If ListGram.SelectedIndex = -1 Then
            ListPathogen.Enabled = False
            ListPathogen.SelectedIndex = -1
        Else
            ListPathogen.Enabled = True
        End If
    End Sub

    Private Sub ListPathogen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPathogen.SelectedIndexChanged
        If ListPathogen.SelectedIndex = -1 Then
            ListAntibiotics.Rows.Clear()
            ListAntibiotics.Enabled = False
            ListAntibiotics.Height = 60
            Me.Height = mHeight
        Else
            ListAntibiotics.Rows.Clear()
            ListAntibiotics.Enabled = True
            If ListGram.SelectedIndex = 0 Then
                For Each an As GramPositive In Database.GramPositives
                    Dim r = ListAntibiotics.Rows(ListAntibiotics.Rows.Add)
                    r.Cells("col_name").Value = an.name
                    r.Tag = r
                Next
            Else
                For Each an As GramNegative In Database.GramNegatives
                    Dim r = ListAntibiotics.Rows(ListAntibiotics.Rows.Add)
                    r.Cells("col_name").Value = an.name
                    r.Tag = r
                Next
            End If
            Me.Height = mHeight + (ListAntibiotics.Rows.Count * 22)
            ListAntibiotics.Height = 60 + (ListAntibiotics.Rows.Count * 22)
        End If
    End Sub

    Private Sub ListAntibiotics_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListAntibiotics.CellContentClick
        Dim r = ListAntibiotics.Rows(e.RowIndex)
        Dim c = ListAntibiotics.Columns(e.ColumnIndex)
        If c.Name = "col_sen" Then
            r.Cells("col_res").Value = False
            r.Cells("col_inter").Value = False
        ElseIf c.Name = "col_res" Then
            r.Cells("col_sen").Value = False
            r.Cells("col_inter").Value = False
        ElseIf c.Name = "col_inter" Then
            r.Cells("col_sen").Value = False
            r.Cells("col_res").Value = False
        End If
    End Sub

    Private Function GetAntibioticValue(r As DataGridViewRow) As Integer
        Try
            If r.Cells("col_res").Value = True Then
                Return 1
            End If
            If r.Cells("col_sen").Value = True Then
                Return 2
            End If
            If r.Cells("col_inter").Value = True Then
                Return 3
            End If
        Catch ex As Exception
        End Try
        Return -1
    End Function
    Private Function GetAntibioticName(r As DataGridViewRow) As String
        Try
            Return r.Cells("col_name").Value
        Catch ex As Exception
            Return "Unknown"
        End Try
    End Function
    Private Sub CreateAntibioticCell(Name As String, Value As Integer, ByRef Row As DataGridViewRow)
        Row.Cells("col_name").Value = Name
        Select Case Value
            Case 1
                Row.Cells("col_res").Value = True
            Case 2
                Row.Cells("col_sen").Value = True
            Case 3
                Row.Cells("col_inter").Value = True
        End Select
    End Sub
End Class
