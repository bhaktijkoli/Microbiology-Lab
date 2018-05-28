Public Class PageList
    Dim Loader As DialogLoading
    Dim isSearch As Boolean = False
    Dim Result As IQueryable(Of Test)

    Private Sub CmdRefresh_Click(sender As Object, e As EventArgs) Handles CmdRefresh.Click
        isSearch = False
        Me.Height = 300
        ListUsers.Rows.Clear()
        Dim th As New Threading.Thread(AddressOf doRefresh)
        th.Start()
        Loader = New DialogLoading
        Loader.ShowDialog()
        Me.Height = 300 + (ListUsers.RowCount * 30)
    End Sub

    Private Sub doRefresh()
        If isSearch = True Then
            Result = Database.Tests.Where(Function(u) u.process = 0 And (u.name.ToLower.Contains(TxtSearch.Text.ToLower) Or u.reg_no.ToLower.Contains(TxtSearch.Text.ToLower)))
        Else
            Result = Database.Tests.Where(Function(u) u.process = 0)
        End If
        Me.Invoke(Sub()
                      For Each u As Test In Result
                          Dim row = ListUsers.Rows(ListUsers.Rows.Add())
                          row.Cells("col_no").Value = ListUsers.RowCount
                          row.Cells("col_name").Value = u.name
                          row.Cells("col_regno").Value = u.reg_no
                          row.Cells("col_ward").Value = u.ward
                          row.Cells("col_unit").Value = u.unit
                          row.Cells("col_sample").Value = u.sample
                          row.Cells("col_date").Value = DateTime.ParseExact(u.created_at, TimeFormat, Nothing).ToShortDateString
                          row.Height = 30
                          row.Tag = u
                      Next
                  End Sub)
        Loader.Invoke(Sub() Loader.Close())
    End Sub

    Private Sub CmdSearch_Click(sender As Object, e As EventArgs) Handles CmdSearch.Click
        isSearch = True
        CmdRefresh.PerformClick()
    End Sub

    Private Sub ListUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListUsers.CellContentClick
        If e.ColumnIndex = ListUsers.Columns("col_update").Index Then
            Dim row = ListUsers.Rows(e.RowIndex)
            Dim test As Test = row.Tag
            If test.sample.ToLower = "blood" Then
                Dim frm As New FormUpdate(test)
                frm.ShowDialog()
            Else
                Dim frm As New FormUpdate(test)
                frm.ShowDialog()
            End If
        End If
    End Sub
End Class
