Public Class FormLogin

    Dim Loader As DialogLoading
    Dim Result As Boolean = False

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppMain.init()
        Me.Text = My.Application.Info.ProductName + " - Login"
        If AppMain.Database.Users.Count = 0 Then
            Dim frm As New FormGettingStarted
            frm.Show()
            Me.Close()
        End If
        TxtUsername.Text = "test"
        TxtPassword.Text = "test"
        CmdLogin.PerformClick()
    End Sub

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles CmdLogin.Click
        Loader = New DialogLoading
        Dim th As New Threading.Thread(AddressOf doLogin)
        th.Start()
        Loader.ShowDialog()
        If Result Then
            Dim frm As New FormMain
            frm.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid username or password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub doLogin()
        Result = False
        Dim user = AppMain.Database.Users.Where(Function(u) u.username = TxtUsername.Text).FirstOrDefault
        If IsNothing(user) Then
            Result = False
        ElseIf user.password = TxtPassword.Text Then
            Result = True
            AppMain.User = user
        End If
        Loader.Invoke(Sub() Loader.Close())
    End Sub

End Class
