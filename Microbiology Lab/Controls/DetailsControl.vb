Public Class DetailsControl
    Private test As Test
    Public Sub updateData(test As Test)
        Me.test = test
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
            Dim dt = DateTime.ParseExact(.created_at, TimeFormat, Nothing)
            lblDate.Text = "Date of Specimen Collection: " + dt.ToShortDateString + ", " + dt.ToShortTimeString
        End With
    End Sub
End Class
