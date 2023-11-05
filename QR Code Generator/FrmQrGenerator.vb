Imports System.Drawing.Imaging

Public Class FrmQrGenerator
    Private _foregroundColor As Color = Color.Black
    Private _backgroundColor As Color = Color.White
    Private foregroundColorDialog As New ColorDialog()
    Private backgroundColorDialog As New ColorDialog()
    Private Const MaxTextLength As Integer = 153
    Private QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder()
    Private ReadOnly ImageFormats As Dictionary(Of String, ImageFormat) = New Dictionary(Of String, ImageFormat) From {
        {"PNG", ImageFormat.Png},
        {"JPEG", ImageFormat.Jpeg},
        {"BMP", ImageFormat.Bmp},
        {"GIF", ImageFormat.Gif}
    }

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If Not ValidateInput() Then Exit Sub

        ' Dispose of the current image in the PictureBox, if there is one
        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
        End If

        ' Generate the new QR Code and display it
        PictureBox1.Image = GenerateQRCode(TextBox1.Text)
        btnSave.Enabled = PictureBox1.Image IsNot Nothing
        DisplayMessage(If(PictureBox1.Image IsNot Nothing, "QR Code generated successfully!", "Failed to generate QR Code."))
    End Sub

    Private Function ValidateInput() As Boolean
        If TextBox1.Text.Length > MaxTextLength Then
            DisplayMessage($"Text length must be under {MaxTextLength} characters.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(TextBox1.Text) Then
            DisplayMessage("Please enter some text to generate a QR code.")
            Return False
        End If
        Return True
    End Function

    Private Function GenerateQRCode(text As String) As Bitmap
        Try
            QR_Generator.QRCodeForegroundColor = _foregroundColor
            QR_Generator.QRCodeBackgroundColor = _backgroundColor

            Dim qrCodeImg As Bitmap = QR_Generator.Encode(text)
            Return qrCodeImg
        Catch ex As Exception
            DisplayMessage("An error occurred while generating the QR code: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If PictureBox1.Image Is Nothing Then
            DisplayMessage("Please generate a QR code before saving.", "QR Code Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        SetSaveFileDialogFilter()
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SetSaveFileDialogFilter()
        If cbFormatChoice.SelectedItem IsNot Nothing Then
            SaveFileDialog1.Filter = $"{cbFormatChoice.SelectedItem} Image|*.{cbFormatChoice.SelectedItem.ToString().ToLower()}"
        Else
            SaveFileDialog1.Filter = "PNG Image|*.png"
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        If String.IsNullOrEmpty(SaveFileDialog1.FileName) Then
            DisplayMessage("File name cannot be empty.")
            e.Cancel = True
            Exit Sub
        End If

        Try
            Using img As New Bitmap(PictureBox1.Image)
                Dim format As ImageFormat = ImageFormats(cbFormatChoice.SelectedItem.ToString())
                img.Save(SaveFileDialog1.FileName, format)
            End Using
        Catch ex As Exception
            DisplayMessage("An error occurred while saving the file: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NavigationHelper.NavigateBackTo(Of FrmQrChoice)(Me)
    End Sub

    Private Sub btnBackgroundColor_Click(sender As Object, e As EventArgs) Handles btnBackgroundColor.Click
        If backgroundColorDialog.ShowDialog() = DialogResult.OK Then
            _backgroundColor = backgroundColorDialog.Color
        End If
    End Sub

    Private Sub btnForegroundColor_Click(sender As Object, e As EventArgs) Handles btnForegroundColor.Click
        If foregroundColorDialog.ShowDialog() = DialogResult.OK Then
            _foregroundColor = foregroundColorDialog.Color
        End If
    End Sub

    Private Sub FrmQrGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        cbFormatChoice.Items.Add("PNG")
        cbFormatChoice.Items.Add("JPEG")
        cbFormatChoice.Items.Add("BMP")
        cbFormatChoice.Items.Add("GIF")
    End Sub

    Private Sub DisplayMessage(text As String, Optional title As String = "Information", Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, Optional icon As MessageBoxIcon = MessageBoxIcon.Information)
        MessageBox.Show(text, title, buttons, icon)
    End Sub
End Class






