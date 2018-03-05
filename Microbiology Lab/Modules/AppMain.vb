Module AppMain
    Public TimeFormat As String = "yyyyMMdd"
    Public User As User
    Public Database As New DatabaseEntities


    ' EVENTS
    Public Event SettingsUpdated()
    Public Sub EventSettings()
        RaiseEvent SettingsUpdated()
    End Sub
End Module
