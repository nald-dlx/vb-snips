Public Class Form1

   Dim oCrypt As New CryptEngine

   Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      btnDecrypt.Enabled = False
      btnEncrypt.Enabled = False
      btnSaveKey.Enabled = False
   End Sub

   Private Sub btnGenerateKey_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerateKey.Click
      If Cursor = Cursors.WaitCursor Then
         Exit Sub
      End If
      Cursor = Cursors.WaitCursor
      oCrypt.GenerateNewKey()
      If oCrypt.KeyAvailable Then
         btnEncrypt.Enabled = True
         txtSource.Focus()
         btnDecrypt.Enabled = True
         btnSaveKey.Enabled = True
         AcceptButton = btnEncrypt
      End If
      Cursor = Cursors.Default
   End Sub

   Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click
      If Cursor = Cursors.WaitCursor Then
         Exit Sub
      End If
      If Not oCrypt.KeyAvailable Then
         MessageBox.Show("No key loaded !")
         Exit Sub
      End If
      txtDestination.Text = oCrypt.Encrypt(txtSource.Text)
   End Sub

   Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click
      If Cursor = Cursors.WaitCursor Then
         Exit Sub
      End If
      If Not oCrypt.KeyAvailable Then
         MessageBox.Show("No key loaded !")
         Exit Sub
      End If
      txtSource.Text = oCrypt.Decrypt(txtDestination.Text)
   End Sub

   Private Sub btnSaveKey_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveKey.Click
      If Cursor = Cursors.WaitCursor Then
         Exit Sub
      End If
      If Not oCrypt.KeyAvailable Then
         Exit Sub
      End If
      Cursor = Cursors.WaitCursor
      oCrypt.SaveKey("c:\temp\" & oCrypt.KeyName)
      Cursor = Cursors.Default
   End Sub

   Private Sub btnLoadKey_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadKey.Click
      If Cursor = Cursors.WaitCursor Then
         Exit Sub
      End If
      If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
         Cursor = Cursors.WaitCursor
         oCrypt.LoadKey(OpenFileDialog1.FileName)
         If oCrypt.KeyAvailable Then
            btnEncrypt.Enabled = True
            txtSource.Focus()
            btnDecrypt.Enabled = True
            AcceptButton = btnEncrypt
         End If
         Cursor = Cursors.Default
      End If
   End Sub

End Class
