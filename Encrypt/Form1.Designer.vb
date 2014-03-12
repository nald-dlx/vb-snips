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
      Me.txtSource = New System.Windows.Forms.TextBox()
      Me.txtDestination = New System.Windows.Forms.TextBox()
      Me.btnEncrypt = New System.Windows.Forms.Button()
      Me.btnDecrypt = New System.Windows.Forms.Button()
      Me.btnSaveKey = New System.Windows.Forms.Button()
      Me.btnLoadKey = New System.Windows.Forms.Button()
      Me.btnGenerateKey = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'txtSource
      '
      Me.txtSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtSource.Location = New System.Drawing.Point(13, 13)
      Me.txtSource.Multiline = True
      Me.txtSource.Name = "txtSource"
      Me.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtSource.Size = New System.Drawing.Size(809, 186)
      Me.txtSource.TabIndex = 0
      '
      'txtDestination
      '
      Me.txtDestination.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtDestination.Location = New System.Drawing.Point(13, 234)
      Me.txtDestination.Multiline = True
      Me.txtDestination.Name = "txtDestination"
      Me.txtDestination.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtDestination.Size = New System.Drawing.Size(809, 188)
      Me.txtDestination.TabIndex = 1
      '
      'btnEncrypt
      '
      Me.btnEncrypt.Location = New System.Drawing.Point(13, 205)
      Me.btnEncrypt.Name = "btnEncrypt"
      Me.btnEncrypt.Size = New System.Drawing.Size(75, 23)
      Me.btnEncrypt.TabIndex = 2
      Me.btnEncrypt.Text = "Encrypt"
      Me.btnEncrypt.UseVisualStyleBackColor = True
      '
      'btnDecrypt
      '
      Me.btnDecrypt.Location = New System.Drawing.Point(94, 205)
      Me.btnDecrypt.Name = "btnDecrypt"
      Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
      Me.btnDecrypt.TabIndex = 3
      Me.btnDecrypt.Text = "Decrypt"
      Me.btnDecrypt.UseVisualStyleBackColor = True
      '
      'btnSaveKey
      '
      Me.btnSaveKey.Location = New System.Drawing.Point(175, 205)
      Me.btnSaveKey.Name = "btnSaveKey"
      Me.btnSaveKey.Size = New System.Drawing.Size(75, 23)
      Me.btnSaveKey.TabIndex = 4
      Me.btnSaveKey.Text = "Save Key"
      Me.btnSaveKey.UseVisualStyleBackColor = True
      '
      'btnLoadKey
      '
      Me.btnLoadKey.Location = New System.Drawing.Point(256, 205)
      Me.btnLoadKey.Name = "btnLoadKey"
      Me.btnLoadKey.Size = New System.Drawing.Size(75, 23)
      Me.btnLoadKey.TabIndex = 5
      Me.btnLoadKey.Text = "Load Key"
      Me.btnLoadKey.UseVisualStyleBackColor = True
      '
      'btnGenerateKey
      '
      Me.btnGenerateKey.Location = New System.Drawing.Point(721, 205)
      Me.btnGenerateKey.Name = "btnGenerateKey"
      Me.btnGenerateKey.Size = New System.Drawing.Size(101, 23)
      Me.btnGenerateKey.TabIndex = 6
      Me.btnGenerateKey.Text = "Generate Key"
      Me.btnGenerateKey.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(834, 434)
      Me.Controls.Add(Me.btnGenerateKey)
      Me.Controls.Add(Me.btnLoadKey)
      Me.Controls.Add(Me.btnSaveKey)
      Me.Controls.Add(Me.btnDecrypt)
      Me.Controls.Add(Me.btnEncrypt)
      Me.Controls.Add(Me.txtDestination)
      Me.Controls.Add(Me.txtSource)
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents txtSource As System.Windows.Forms.TextBox
   Friend WithEvents txtDestination As System.Windows.Forms.TextBox
   Friend WithEvents btnEncrypt As System.Windows.Forms.Button
   Friend WithEvents btnDecrypt As System.Windows.Forms.Button
   Friend WithEvents btnSaveKey As System.Windows.Forms.Button
   Friend WithEvents btnLoadKey As System.Windows.Forms.Button
   Friend WithEvents btnGenerateKey As System.Windows.Forms.Button

End Class
