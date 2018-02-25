Module AppValidation
    Public Function ValidateUsername(Text As String) As Boolean
        If Text.Length < 3 Or Text.Length > 20 Then
            MessageBox.Show("Enter a username of 3-20 characters.", My.Application.OpenForms(0).Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    Public Function ValidatePassword(Text As String, Text2 As String) As Boolean
        If Text.Length < 3 Then
            MessageBox.Show("Enter a password of minimum 3 characters", My.Application.OpenForms(0).Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Not Text = Text2 Then
            MessageBox.Show("Passwords doesn't match.", My.Application.OpenForms(0).Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
End Module
