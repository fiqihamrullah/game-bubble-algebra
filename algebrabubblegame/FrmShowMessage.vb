Public Class FrmShowMessage

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Dispose()
    End Sub
    Public Sub SetMessage(ByVal text As String)
        lblPesan.Text = text
    End Sub

End Class