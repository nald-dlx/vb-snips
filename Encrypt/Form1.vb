﻿'----------------------------------------------------------------------
'
' Cryptengine class test software
' 
'----------------------------------------------------------------------

Public Class Form1

   Dim oCrypt As New CryptEngine

   Private Sub btnGenerateKey_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerateKey.Click
      If Cursor = Cursors.WaitCursor Then
         Exit Sub
      End If
      Cursor = Cursors.WaitCursor
      oCrypt.GenerateNewKey()
      txtKeyName.Text = oCrypt.KeyName
      btnDecrypt.Enabled = True
      btnEncrypt.Enabled = True
      btnSaveKey.Enabled = True
      Cursor = Cursors.Default
   End Sub

   Private Sub btnEncrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnEncrypt.Click
      txtDestination.Text = oCrypt.Encrypt(txtSource.Text)
   End Sub

   Private Sub btnDecrypt_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrypt.Click
      txtSource.Text = oCrypt.Decrypt(txtDestination.Text)
   End Sub

   Private Sub btnSaveKey_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveKey.Click
      If Not oCrypt.KeyAvailable Then
         Exit Sub
      End If
      oCrypt.SaveKey("c:\temp\DNE130619082717.KEY")  ' & oCrypt.KeyName
      txtKeyName.Text = oCrypt.KeyName
   End Sub

   Private Sub btnLoadKey_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadKey.Click
      oCrypt.LoadKey("C:\Temp\DNE130619082717.KEY")
      txtKeyName.Text = oCrypt.KeyName
      btnDecrypt.Enabled = True
      btnEncrypt.Enabled = True
   End Sub

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      btnDecrypt.Enabled = False
      btnEncrypt.Enabled = False
      btnSaveKey.Enabled = False
   End Sub

End Class
