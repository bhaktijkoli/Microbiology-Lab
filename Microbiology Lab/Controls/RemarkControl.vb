Public Class RemarkControl
    Public Sub updateData(Test As Test)
        TxtRemark.Text = Test.remark
    End Sub
    Public Function setData(ByRef Test As Test)
        Test.remark = TxtRemark.Text
        Return True
    End Function
End Class
