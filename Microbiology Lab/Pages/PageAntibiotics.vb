Public Class PageAntibiotics

    Dim Loader As DialogLoading
    Dim GramStrain As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler AppMain.SettingsUpdated, AddressOf LoadList
    End Sub

    Private Sub PageAntibiotics_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = 150
        ListGramStrain.SelectedIndex = 0
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
        If GramStrain = 0 Then
            For Each a As GramPositive In Database.GramPositives
                ListItems.Invoke(Sub()
                                     Dim row = ListItems.Rows(ListItems.Rows.Add())
                                     row.Cells("col_no").Value = ListItems.RowCount
                                     row.Cells("col_name").Value = a.name
                                     row.Tag = a
                                     row.Height = 30
                                 End Sub)
            Next
        Else
            For Each a As GramNegative In Database.GramNegatives
                ListItems.Invoke(Sub()
                                     Dim row = ListItems.Rows(ListItems.Rows.Add())
                                     row.Cells("col_no").Value = ListItems.RowCount
                                     row.Cells("col_name").Value = a.name
                                     row.Tag = a
                                     row.Height = 30
                                 End Sub)
            Next
        End If

        Loader.Invoke(Sub() Loader.Close())
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        Dim val = ""
        If GramStrain = 0 Then
            val = InputBox("Enter name of the gram positive antibiotic.", Me.ParentForm.Text, "")
        Else
            val = InputBox("Enter name of the gram negative antibiotic.", Me.ParentForm.Text, "")
        End If
        If val.Length > 0 Then
            If GramStrain = 0 Then
                Dim a As New GramPositive
                a.id = Database.GramPositives.Count
                a.name = val
                Database.GramPositives.Add(a)
            Else
                Dim a As New GramNegative
                a.id = Database.GramNegatives.Count
                a.name = val
                Database.GramNegatives.Add(a)
            End If
            Database.SaveChanges()
            AppMain.EventSettings()
        End If
    End Sub

    Private Sub CmdImport_Click(sender As Object, e As EventArgs) Handles CmdImport.Click
        If GramStrain = 0 Then
            Try
                AppMain.Database.Database.ExecuteSqlCommand("delete from GramPositives")
                Dim file As String = My.Computer.FileSystem.CurrentDirectory + "/Resources/GramPositives.txt"
                Dim Items As String() = My.Computer.FileSystem.ReadAllText(file).Split(vbNewLine)
                For Each i As String In Items
                    If i.Length > 0 Then
                        Dim a As New GramPositive With {.id = Database.GramPositives.Count, .name = i.ToString.Replace(vbCr, "").Replace(vbLf, "")}
                        Database.GramPositives.Add(a)
                    End If
                Next
                Database.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Gram positive antibiotics Imported!", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            AppMain.EventSettings()
        Else
            Try
                AppMain.Database.Database.ExecuteSqlCommand("delete from GramNegatives")
                Dim file As String = My.Computer.FileSystem.CurrentDirectory + "/Resources/GramNegatives.txt"
                Dim Items As String() = My.Computer.FileSystem.ReadAllText(file).Split(vbNewLine)
                For Each i As String In Items
                    If i.Length > 0 Then
                        Dim a As New GramNegative With {.id = Database.GramNegatives.Count, .name = i.ToString.Replace(vbCr, "").Replace(vbLf, "")}
                        Database.GramNegatives.Add(a)
                    End If
                Next
                Database.SaveChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MessageBox.Show("Gram negative antibiotics Imported!", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            AppMain.EventSettings()
        End If
    End Sub

    Private Sub ListItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListItems.CellContentClick
        If ListItems.Columns("col_remove").Index = e.ColumnIndex Then
            If GramStrain = 0 Then
                Dim a As GramPositive = ListItems.Rows(e.RowIndex).Tag
                Database.GramPositives.Remove(a)
            Else
                Dim a As GramNegative = ListItems.Rows(e.RowIndex).Tag
                Database.GramNegatives.Remove(a)
            End If
            Database.SaveChanges()
                AppMain.EventSettings()
            End If
    End Sub

    Private Sub ListGramStrain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListGramStrain.SelectedIndexChanged
        GramStrain = ListGramStrain.SelectedIndex
        LoadList()
    End Sub
End Class
