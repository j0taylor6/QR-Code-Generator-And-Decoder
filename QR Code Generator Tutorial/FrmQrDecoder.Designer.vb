<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQrDecoder
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
        Me.btnFindFile = New System.Windows.Forms.Button()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFindFile
        '
        Me.btnFindFile.Location = New System.Drawing.Point(9, 11)
        Me.btnFindFile.Name = "btnFindFile"
        Me.btnFindFile.Size = New System.Drawing.Size(259, 37)
        Me.btnFindFile.TabIndex = 0
        Me.btnFindFile.Text = "Choose File"
        Me.btnFindFile.UseVisualStyleBackColor = True
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(9, 68)
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.ReadOnly = True
        Me.tbOutput.Size = New System.Drawing.Size(258, 20)
        Me.tbOutput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Decoded Text:"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Location = New System.Drawing.Point(8, 101)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(260, 27)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Go Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmQrDecoder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 140)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.btnFindFile)
        Me.Name = "FrmQrDecoder"
        Me.Text = "FrmQrDecoder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFindFile As Button
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
