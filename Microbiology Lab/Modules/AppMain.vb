Module AppMain
    Public TimeFormat As String = "yyyyMMddHHmm"
    Public User As User
    Public Database As New DatabaseEntities

    Public Function init()
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.CurrentDirectory + "/Data") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory + "/Data")
        End If
        Try
            ' NOT EXISTS 
            Database.Database.CreateIfNotExists()
            Database.Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS `BloodTests` ( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` TEXT )")
            Database.Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS `Samples` ( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` TEXT )")
            Database.Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS `SubTests` ( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `testid` INTEGER, `test` TEXT )")
            Database.Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS `Tests` ( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` TEXT, `reg_no` TEXT, `sex` TEXT, `age` INTEGER, `address` TEXT, `pincode` TEXT, `ward` TEXT, `unit` TEXT, `sample` TEXT, `nature` TEXT, `created_at` INTEGER, `created_by` TEXT, `process` INTEGER DEFAULT 0 )")
            Database.Database.ExecuteSqlCommand("CREATE TABLE IF NOT EXISTS `Users` ( `id` INTEGER PRIMARY KEY AUTOINCREMENT, `username` TEXT, `password` TEXT, `role` INTEGER, `created_at` TEXT DEFAULT CURRENT_TIMESTAMP )")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        EventSettings()
        Return True
    End Function

    ' EVENTS
    Public Event SettingsUpdated()
    Public Sub EventSettings()
        RaiseEvent SettingsUpdated()
    End Sub
End Module
