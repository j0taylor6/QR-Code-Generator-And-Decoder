<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmQrGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBackgroundColor = New System.Windows.Forms.Button()
        Me.btnForegroundColor = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cbFormatChoice = New System.Windows.Forms.ComboBox()
        Me.lblSaveFormat = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Location = New System.Drawing.Point(12, 289)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(258, 27)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "QR_Code.png"
        Me.SaveFileDialog1.Filter = "PNG Image|*.png"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(12, 363)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(258, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Location = New System.Drawing.Point(12, 396)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(258, 27)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Go Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBackgroundColor
        '
        Me.btnBackgroundColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackgroundColor.Location = New System.Drawing.Point(12, 256)
        Me.btnBackgroundColor.Name = "btnBackgroundColor"
        Me.btnBackgroundColor.Size = New System.Drawing.Size(125, 27)
        Me.btnBackgroundColor.TabIndex = 5
        Me.btnBackgroundColor.Text = "Background Color"
        Me.btnBackgroundColor.UseVisualStyleBackColor = True
        '
        'btnForegroundColor
        '
        Me.btnForegroundColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForegroundColor.Location = New System.Drawing.Point(143, 256)
        Me.btnForegroundColor.Name = "btnForegroundColor"
        Me.btnForegroundColor.Size = New System.Drawing.Size(127, 27)
        Me.btnForegroundColor.TabIndex = 6
        Me.btnForegroundColor.Text = "Foreground Color"
        Me.btnForegroundColor.UseVisualStyleBackColor = True
        '
        'cbFormatChoice
        '
        Me.cbFormatChoice.FormattingEnabled = True
        Me.cbFormatChoice.Location = New System.Drawing.Point(12, 336)
        Me.cbFormatChoice.Name = "cbFormatChoice"
        Me.cbFormatChoice.Size = New System.Drawing.Size(258, 21)
        Me.cbFormatChoice.TabIndex = 7
        '
        'lblSaveFormat
        '
        Me.lblSaveFormat.AutoSize = True
        Me.lblSaveFormat.Location = New System.Drawing.Point(12, 319)
        Me.lblSaveFormat.Name = "lblSaveFormat"
        Me.lblSaveFormat.Size = New System.Drawing.Size(70, 13)
        Me.lblSaveFormat.TabIndex = 8
        Me.lblSaveFormat.Text = "Save Format:"
        '
        'FrmQrGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 429)
        Me.Controls.Add(Me.lblSaveFormat)
        Me.Controls.Add(Me.cbFormatChoice)
        Me.Controls.Add(Me.btnForegroundColor)
        Me.Controls.Add(Me.btnBackgroundColor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmQrGenerator"
        Me.Text = "QR Code Generator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnBackgroundColor As Button
    Friend WithEvents btnForegroundColor As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbFormatChoice As ComboBox
    Friend WithEvents lblSaveFormat As Label
End Class
