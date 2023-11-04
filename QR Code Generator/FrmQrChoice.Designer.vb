<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQrChoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGenerationChoice = New System.Windows.Forms.Button()
        Me.btnDecoderChoice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGenerationChoice
        '
        Me.btnGenerationChoice.Location = New System.Drawing.Point(13, 13)
        Me.btnGenerationChoice.Name = "btnGenerationChoice"
        Me.btnGenerationChoice.Size = New System.Drawing.Size(356, 67)
        Me.btnGenerationChoice.TabIndex = 0
        Me.btnGenerationChoice.Text = "QR Code Generation"
        Me.btnGenerationChoice.UseVisualStyleBackColor = True
        '
        'btnDecoderChoice
        '
        Me.btnDecoderChoice.Location = New System.Drawing.Point(13, 91)
        Me.btnDecoderChoice.Name = "btnDecoderChoice"
        Me.btnDecoderChoice.Size = New System.Drawing.Size(356, 67)
        Me.btnDecoderChoice.TabIndex = 1
        Me.btnDecoderChoice.Text = "QR Code Decoder"
        Me.btnDecoderChoice.UseVisualStyleBackColor = True
        '
        'FrmQrChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 170)
        Me.Controls.Add(Me.btnDecoderChoice)
        Me.Controls.Add(Me.btnGenerationChoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmQrChoice"
        Me.Text = "qrChoice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerationChoice As Button
    Friend WithEvents btnDecoderChoice As Button
End Class
