Public Class PageRegister
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler AppMain.SettingsUpdated, AddressOf LoadAll
    End Sub


    Public Sub LoadAll()
        TxtSample.Items.Clear()
        For Each s As Sample In Database.Samples
            TxtSample.Items.Add(New String(s.name))
        Next
    End Sub

End Class
