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
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtKeyName = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'txtSource
      '
      Me.txtSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtSource.Location = New System.Drawing.Point(17, 16)
      Me.txtSource.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.txtSource.Multiline = True
      Me.txtSource.Name = "txtSource"
      Me.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtSource.Size = New System.Drawing.Size(1077, 228)
      Me.txtSource.TabIndex = 0
      '
      'txtDestination
      '
      Me.txtDestination.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtDestination.Location = New System.Drawing.Point(17, 288)
      Me.txtDestination.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.txtDestination.Multiline = True
      Me.txtDestination.Name = "txtDestination"
      Me.txtDestination.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtDestination.Size = New System.Drawing.Size(1077, 230)
      Me.txtDestination.TabIndex = 1
      '
      'btnEncrypt
      '
      Me.btnEncrypt.Location = New System.Drawing.Point(17, 252)
      Me.btnEncrypt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.btnEncrypt.Name = "btnEncrypt"
      Me.btnEncrypt.Size = New System.Drawing.Size(100, 28)
      Me.btnEncrypt.TabIndex = 2
      Me.btnEncrypt.Text = "Encrypt"
      Me.btnEncrypt.UseVisualStyleBackColor = True
      '
      'btnDecrypt
      '
      Me.btnDecrypt.Location = New System.Drawing.Point(125, 252)
      Me.btnDecrypt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.btnDecrypt.Name = "btnDecrypt"
      Me.btnDecrypt.Size = New System.Drawing.Size(100, 28)
      Me.btnDecrypt.TabIndex = 3
      Me.btnDecrypt.Text = "Decrypt"
      Me.btnDecrypt.UseVisualStyleBackColor = True
      '
      'btnSaveKey
      '
      Me.btnSaveKey.Location = New System.Drawing.Point(233, 252)
      Me.btnSaveKey.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.btnSaveKey.Name = "btnSaveKey"
      Me.btnSaveKey.Size = New System.Drawing.Size(100, 28)
      Me.btnSaveKey.TabIndex = 4
      Me.btnSaveKey.Text = "Save Key"
      Me.btnSaveKey.UseVisualStyleBackColor = True
      '
      'btnLoadKey
      '
      Me.btnLoadKey.Location = New System.Drawing.Point(341, 252)
      Me.btnLoadKey.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.btnLoadKey.Name = "btnLoadKey"
      Me.btnLoadKey.Size = New System.Drawing.Size(100, 28)
      Me.btnLoadKey.TabIndex = 5
      Me.btnLoadKey.Text = "Load Key"
      Me.btnLoadKey.UseVisualStyleBackColor = True
      '
      'btnGenerateKey
      '
      Me.btnGenerateKey.Location = New System.Drawing.Point(449, 252)
      Me.btnGenerateKey.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.btnGenerateKey.Name = "btnGenerateKey"
      Me.btnGenerateKey.Size = New System.Drawing.Size(135, 28)
      Me.btnGenerateKey.TabIndex = 6
      Me.btnGenerateKey.Text = "Generate Key"
      Me.btnGenerateKey.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(591, 258)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(79, 17)
      Me.Label1.TabIndex = 7
      Me.Label1.Text = "Keyname : "
      '
      'txtKeyName
      '
      Me.txtKeyName.Location = New System.Drawing.Point(666, 255)
      Me.txtKeyName.Name = "txtKeyName"
      Me.txtKeyName.Size = New System.Drawing.Size(428, 22)
      Me.txtKeyName.TabIndex = 8
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1112, 534)
      Me.Controls.Add(Me.txtKeyName)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.btnGenerateKey)
      Me.Controls.Add(Me.btnLoadKey)
      Me.Controls.Add(Me.btnSaveKey)
      Me.Controls.Add(Me.btnDecrypt)
      Me.Controls.Add(Me.btnEncrypt)
      Me.Controls.Add(Me.txtDestination)
      Me.Controls.Add(Me.txtSource)
      Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.Name = "Form1"
      Me.Text = "Encryption toolset"
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
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtKeyName As System.Windows.Forms.TextBox

End Class
