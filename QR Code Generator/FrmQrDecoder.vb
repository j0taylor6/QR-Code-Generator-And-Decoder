Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data

Public Class FrmQrDecoder
    Private Const DefaultPath As String = "c:\"
    Private Const Filter As String = "PNG files (*.png)|*.png|JPEG files (*.jpeg;*.jpg)|*.jpeg;*.jpg"

    Private Sub btnFindFile_Click(sender As Object, e As EventArgs) Handles btnFindFile.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.InitialDirectory = DefaultPath
            openFileDialog.Filter = Filter
            openFileDialog.FilterIndex = 2
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the selected file's path
                Dim selectedFilePath As String = openFileDialog.FileName

                Try
                    ' Decode the QR Code from the selected file
                    Dim decodedData As String = DecodeQRCode(selectedFilePath)
                    tbOutput.Text = decodedData
                Catch ex As IOException
                    MessageBox.Show("An I/O error occurred: " & ex.Message)
                Catch ex As UnauthorizedAccessException
                    MessageBox.Show("You do not have permission to read the file.")
                Catch ex As Exception
                    MessageBox.Show("An unexpected error occurred. Please try again.")

                End Try
            End If
        End Using
    End Sub

    Private Function DecodeQRCode(filePath As String) As String
        Using image As New Bitmap(filePath)
            Dim decoder As New QRCodeDecoder()
            Return decoder.decode(New QRCodeBitmapImage(image))
        End Using
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NavigationHelper.NavigateBackTo(Of FrmQrChoice)(Me)
    End Sub
End Class
