Public Class ReportControl
    Private Test As Test
    Private mHeight As Integer = 200
    Public Sub updateData(Test As Test)
        ListPathogen.Items.Clear()
        For Each p As Pathogen In Database.Pathogens
            ListPathogen.Items.Add(p.name)
        Next
        Me.Test = Test
        ListResult.SelectedIndex = 0
    End Sub

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
End Class
