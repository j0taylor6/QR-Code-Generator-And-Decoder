Public Class FrmQrChoice
    Private Sub btnGenerationChoice_Click(sender As Object, e As EventArgs) Handles btnGenerationChoice.Click
        ShowSingleInstance(Of FrmQrGenerator)()
    End Sub

    Private Sub btnDecoderChoice_Click(sender As Object, e As EventArgs) Handles btnDecoderChoice.Click
        ShowSingleInstance(Of FrmQrDecoder)()
    End Sub


    Private Sub ShowSingleInstance(Of T As {Form, New})()

        Dim form As T = Application.OpenForms.OfType(Of T)().FirstOrDefault()

        If form Is Nothing Then
            form = New T()
        End If

        form.Show()
        Me.Hide()
    End Sub

End Class

