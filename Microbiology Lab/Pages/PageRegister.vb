Public Class PageRegister
    Dim Loader As DialogLoading
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.Height = 530
        ' Add any initialization after the InitializeComponent() call.
        AddHandler AppMain.SettingsUpdated, AddressOf LoadAll
    End Sub


    Public Sub LoadAll()
        TxtSample.Items.Clear()
        For Each s As Sample In Database.Samples
            TxtSample.Items.Add(New String(s.name))
        Next

        ' Autocomplete
        With TxtName
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            For Each t As Test In Database.Tests
                If Not .AutoCompleteCustomSource.Contains(t.name) Then
                    .AutoCompleteCustomSource.Add(t.name)
                End If
            Next
        End With

        If IsNothing(My.Settings.ward) Then
            My.Settings.ward = New Specialized.StringCollection
        End If
        If IsNothing(My.Settings.unit) Then
            My.Settings.unit = New Specialized.StringCollection
        End If
        If IsNothing(My.Settings.pincode) Then
            My.Settings.pincode = New Specialized.StringCollection
        End If
        With TxtWard
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            For Each s As String In My.Settings.ward
                .AutoCompleteCustomSource.Add(s)
            Next
        End With
        With TxtUnit
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            For Each s As String In My.Settings.unit
                .AutoCompleteCustomSource.Add(s)
            Next
        End With
        With TxtPincode
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            For Each s As String In My.Settings.pincode
                .AutoCompleteCustomSource.Add(s)
            Next
        End With

        ListTests.Rows.Clear()
        For Each T As BloodTest In Database.BloodTests
            Dim row = ListTests.Rows(ListTests.Rows.Add())
            row.Cells("col_name").Value = T.name
        Next


    End Sub

    Private Sub CmdRegister_Click(sender As Object, e As EventArgs) Handles CmdRegister.Click
        If TxtName.TextLength < 1 Then
            MessageBox.Show("Enter a valid name.", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtRegNo.TextLength < 1 Then
            MessageBox.Show("Enter a valid registration number.", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtSex.SelectedIndex < 0 Then
            MessageBox.Show("Select proper sex.", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtAge.Value <= 0 Then
            MessageBox.Show("Enter proper Age.", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtWard.TextLength < 1 Then
            MessageBox.Show("Enter a valid ward name.", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtUnit.TextLength < 1 Then
            MessageBox.Show("Enter a valid unit name.", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtSample.SelectedIndex = -1 Then
            MessageBox.Show("Select sample.", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtSample.Text.ToLower = "blood" And GetSubTestCount() = 0 Then
            MessageBox.Show("You must select atleast one test.", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Loader = New DialogLoading
        Dim th As New Threading.Thread(AddressOf doRegister)
        th.Start()
        Loader.ShowDialog()
        MessageBox.Show("Registration successful!", Me.ParentForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        CmdClear.PerformClick()
    End Sub

    Private Sub doRegister()
        Dim Test As New Test
        Me.Invoke(Sub()
                      Test.name = TxtName.Text
                      Test.reg_no = TxtRegNo.Text
                      Test.sex = TxtSex.SelectedItem
                      Test.age = TxtAge.Value
                      Test.address = TxtAddress.Text
                      Test.pincode = TxtPincode.Text
                      Test.ward = TxtWard.Text
                      Test.unit = TxtUnit.Text
                      Test.sample = TxtSample.SelectedItem
                      Test.nature = TxtNature.SelectedItem
                      Test.process = 0
                      Test.created_by = AppMain.User.username
                      Test.created_at = DateTime.Now.ToString(TimeFormat)
                  End Sub)
        Database.Tests.Add(Test)
        Database.SaveChanges()

        If Test.sample.ToLower = "blood" Then
            Me.Invoke(Sub()
                          For Each row As DataGridViewRow In ListTests.Rows
                              If row.Cells("col_check").Value = False Then
                                  Continue For
                              End If
                              Dim subtest As New SubTest
                              subtest.testid = Test.id
                              subtest.test = row.Cells("col_name").Value
                              Database.SubTests.Add(subtest)
                          Next
                      End Sub)
            Database.SaveChanges()
        End If

        If My.Settings.ward.Contains(TxtWard.Text) = False Then
            My.Settings.ward.Add(TxtWard.Text)
        End If
        If My.Settings.unit.Contains(TxtUnit.Text) = False Then
            My.Settings.unit.Add(TxtUnit.Text)
        End If
        If My.Settings.pincode.Contains(TxtPincode.Text) = False Then
            My.Settings.pincode.Add(TxtPincode.Text)
        End If
        My.Settings.Save()
        Loader.Invoke(Sub() Loader.Close())
    End Sub
    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles CmdClear.Click
        TxtName.Clear()
        TxtAddress.Clear()
        TxtAge.Value = 1
        TxtPincode.Clear()
        TxtRegNo.Clear()
        TxtSample.SelectedIndex = -1
        TxtSex.SelectedIndex = -1
        TxtUnit.Clear()
        TxtWard.Clear()
        TxtNature.SelectedIndex = -1
    End Sub

    Private Sub TxtSample_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSample.SelectedIndexChanged
        If TxtSample.Text.ToLower = "blood" Then
            LblTests.Visible = True
            ListTests.Visible = True
        Else
            LblTests.Visible = False
            ListTests.Visible = False
        End If
    End Sub

    ' FUNCTIONs
    Private Function GetSubTestCount() As Integer
        Dim count As Integer = 0
        For Each row As DataGridViewRow In ListTests.Rows
            If row.Cells("col_check").Value = True Then
                count += 1
            End If
        Next
        Return count
    End Function
End Class
