Public Class FormUpdateBlood
    Private test As Test
    Private testresult As TestResult
    Public Sub New(t As Test)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        test = t
    End Sub

    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        Me.Text = "Update - " + test.name
        testresult = Database.TestResults.Where(Function(u) u.test = test.id).FirstOrDefault
        If IsNothing(testresult) Then
            MessageBox.Show("Test registration is not completed", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        DetailsControlEx.updateData(test)
        ReportControl1.updateData(test, testresult)
        RemarkControl1.updateData(test)
    End Sub

    Private Sub CmdUpdate_Click(sender As Object, e As EventArgs) Handles CmdUpdate.Click
        If ReportControl1.setData(test, testresult) = False Or RemarkControl1.setData(test) = False Then
            MessageBox.Show("All fields are not updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Database.SaveChanges()
        MessageBox.Show("Test Updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class