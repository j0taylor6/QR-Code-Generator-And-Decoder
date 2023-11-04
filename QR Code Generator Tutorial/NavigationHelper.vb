Module NavigationHelper
    Public Sub NavigateBackTo(Of T As {Form, New})(currentForm As Form)
        Dim form As T = Application.OpenForms.OfType(Of T)().FirstOrDefault()

        If form Is Nothing Then

            form = New T()
            form.Show()
        Else

            form.BringToFront()
            form.Show()
        End If

        currentForm.Close()
    End Sub
End Module

