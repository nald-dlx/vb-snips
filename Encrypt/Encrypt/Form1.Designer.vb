<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Me.btnGenerateKey = New System.Windows.Forms.Button()
      Me.btnLoadKey = New System.Windows.Forms.Button()
      Me.btnSaveKey = New System.Windows.Forms.Button()
      Me.btnDecrypt = New System.Windows.Forms.Button()
      Me.btnEncrypt = New System.Windows.Forms.Button()
      Me.txtDestination = New System.Windows.Forms.TextBox()
      Me.txtSource = New System.Windows.Forms.TextBox()
      Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
      Me.SuspendLayout()
      '
      'btnGenerateKey
      '
      Me.btnGenerateKey.Location = New System.Drawing.Point(403, 204)
      Me.btnGenerateKey.Name = "btnGenerateKey"
      Me.btnGenerateKey.Size = New System.Drawing.Size(101, 23)
      Me.btnGenerateKey.TabIndex = 13
      Me.btnGenerateKey.Text = "Generate Key"
      Me.btnGenerateKey.UseVisualStyleBackColor = True
      '
      'btnLoadKey
      '
      Me.btnLoadKey.Location = New System.Drawing.Point(255, 204)
      Me.btnLoadKey.Name = "btnLoadKey"
      Me.btnLoadKey.Size = New System.Drawing.Size(75, 23)
      Me.btnLoadKey.TabIndex = 12
      Me.btnLoadKey.Text = "Load Key"
      Me.btnLoadKey.UseVisualStyleBackColor = True
      '
      'btnSaveKey
      '
      Me.btnSaveKey.Location = New System.Drawing.Point(174, 204)
      Me.btnSaveKey.Name = "btnSaveKey"
      Me.btnSaveKey.Size = New System.Drawing.Size(75, 23)
      Me.btnSaveKey.TabIndex = 11
      Me.btnSaveKey.Text = "Save Key"
      Me.btnSaveKey.UseVisualStyleBackColor = True
      '
      'btnDecrypt
      '
      Me.btnDecrypt.Location = New System.Drawing.Point(93, 204)
      Me.btnDecrypt.Name = "btnDecrypt"
      Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
      Me.btnDecrypt.TabIndex = 10
      Me.btnDecrypt.Text = "Decrypt"
      Me.btnDecrypt.UseVisualStyleBackColor = True
      '
      'btnEncrypt
      '
      Me.btnEncrypt.Location = New System.Drawing.Point(12, 204)
      Me.btnEncrypt.Name = "btnEncrypt"
      Me.btnEncrypt.Size = New System.Drawing.Size(75, 23)
      Me.btnEncrypt.TabIndex = 9
      Me.btnEncrypt.Text = "Encrypt"
      Me.btnEncrypt.UseVisualStyleBackColor = True
      '
      'txtDestination
      '
      Me.txtDestination.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtDestination.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDestination.Location = New System.Drawing.Point(12, 233)
      Me.txtDestination.Multiline = True
      Me.txtDestination.Name = "txtDestination"
      Me.txtDestination.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtDestination.Size = New System.Drawing.Size(605, 213)
      Me.txtDestination.TabIndex = 8
      '
      'txtSource
      '
      Me.txtSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtSource.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSource.Location = New System.Drawing.Point(12, 12)
      Me.txtSource.Multiline = True
      Me.txtSource.Name = "txtSource"
      Me.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtSource.Size = New System.Drawing.Size(605, 186)
      Me.txtSource.TabIndex = 7
      '
      'OpenFileDialog1
      '
      Me.OpenFileDialog1.FileName = "OpenFileDialog1"
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(629, 458)
      Me.Controls.Add(Me.btnGenerateKey)
      Me.Controls.Add(Me.btnLoadKey)
      Me.Controls.Add(Me.btnSaveKey)
      Me.Controls.Add(Me.btnDecrypt)
      Me.Controls.Add(Me.btnEncrypt)
      Me.Controls.Add(Me.txtDestination)
      Me.Controls.Add(Me.txtSource)
      Me.Name = "Form1"
      Me.Text = "Encrypt"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents btnGenerateKey As System.Windows.Forms.Button
   Friend WithEvents btnLoadKey As System.Windows.Forms.Button
   Friend WithEvents btnSaveKey As System.Windows.Forms.Button
   Friend WithEvents btnDecrypt As System.Windows.Forms.Button
   Friend WithEvents btnEncrypt As System.Windows.Forms.Button
   Friend WithEvents txtDestination As System.Windows.Forms.TextBox
   Friend WithEvents txtSource As System.Windows.Forms.TextBox
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
