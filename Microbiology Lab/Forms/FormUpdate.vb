Public Class FormUpdate
    Private test As Test
    Public Sub New(t As Test)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        test = t
    End Sub

    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        Me.Text = "Update - " + test.name
        With test
            TxtName.Text = .name
            TxtReg.Text = .reg_no
            TxtSex.Text = .sex
            TxtAge.Text = .age
            TxtAddress.Text = .address
            TxtPin.Text = .pincode
            TxtWard.Text = .ward
            TxtUnit.Text = .unit
            TxtSample.Text = .sample
        End With
    End Sub
End Class