Public Class PagePathogens

    Dim Loader As DialogLoading
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler AppMain.SettingsUpdated, AddressOf LoadList
    End Sub

    Private Sub PagePathogens_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = 150
    End Sub

    Private Sub LoadList()
        ListItems.Rows.Clear()
        Me.Height = 200
        CmdAdd.Enabled = True
        Loader = New DialogLoading
        Dim th As New System.Threading.Thread(AddressOf doLoad)
        th.Start()
        Loader.ShowDialog()
        Me.Height = Me.Height + (30 * ListItems.RowCount)
        ListItems.Focus()
    End Sub


    Private Sub doLoad()
        For Each a As Pathogen In Database.Pathogens
            ListItems.Invoke(Sub()
                                 Dim row = ListItems.Rows(ListItems.Rows.Add())
                                 row.Cells("col_no").Value = ListItems.RowCount
                                 row.Cells("col_name").Value = a.name
                                 row.Tag = a
                                 row.Height = 30
                             End Sub)
        Next
        Loader.Invoke(Sub() Loader.Close())
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        Dim val = InputBox("Enter name of the pathogen.", Me.ParentForm.Text, "")
        If val.Length > 0 Then
            Dim a As New Pathogen
            a.id = Database.Pathogens.Count
            a.name = val
            Database.Pathogens.Add(a)
            Database.SaveChanges()
            AppMain.EventSettings()
        End If
    End Sub

    Private Sub CmdImport_Click(sender As Object, e As EventArgs) Handles CmdImport.Click
        Try
            AppMain.Database.Database.ExecuteSqlCommand("delete from Pathogens")
            Dim file As String = My.Computer.FileSystem.CurrentDirectory + "/Resources/Pathogens.txt"
            Dim Items As String() = My.Computer.FileSystem.ReadAllText(file).Split(vbNewLine)
            For Each i As String In Items
                If i.Length > 0 Then
                    Dim a As New Pathogen With {.id = Database.Pathogens.Count, .name = i.ToString.Replace(vbCr, "").Replace(vbLf, "")}
                    Database.Pathogens.Add(a)
                End If
            Next
            Database.SaveChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MessageBox.Show("Pathogens Imported!", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        AppMain.EventSettings()
    End Sub

    Private Sub ListItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListItems.CellContentClick
        If ListItems.Columns("col_remove").Index = e.ColumnIndex Then
            Dim a As Pathogen = ListItems.Rows(e.RowIndex).Tag
            Database.Pathogens.Remove(a)
            Database.SaveChanges()
            AppMain.EventSettings()
        End If
    End Sub
End Class
