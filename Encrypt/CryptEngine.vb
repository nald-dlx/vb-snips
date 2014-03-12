Public Class CryptEngine

   Dim Key(93 * 632) As String  ' Matching key file
   Dim KeyBlock(93) As String ' next key block
   Public KeyAvailable As Boolean
   Public KeyName As String

   Public Sub GenerateNewKey()
      Dim KeyCnt As Long = 0
      Do
         ' Get next block
         Randomize()
         For i As Integer = 0 To KeyBlock.Count - 1
            KeyBlock(i) = Chr(Int(Rnd() * (126 - 33) + 33))
            For j As Integer = 0 To 92
               If KeyBlock(j) = "" Then Exit For
               If KeyBlock(i) = KeyBlock(j) And j < i Then
                  i -= 1
               End If
            Next
            If i = 92 Then
               Exit For
            End If
         Next
         For i As Long = KeyCnt To KeyCnt + 92
            Debug.Write(KeyBlock(i - KeyCnt))
            Key(i) = KeyBlock(i - KeyCnt)
         Next
         KeyCnt += 93
         Debug.WriteLine("")
         If KeyCnt > 93 * 631 Then
            Exit Do
         End If
      Loop
      KeyAvailable = True
      KeyName = "DNE" & Now.ToString("yyMMddHHmmss") & ".KEY"
   End Sub

   Public Function Encrypt(ByVal Text As String) As String
      Dim sb As New System.Text.StringBuilder
      If Not KeyAvailable Then
         Return ""
      End If
      For cnt As Long = 1 To Text.Length
         Dim KeyPos As Long = Asc(Mid(Text, cnt, 1)) - 32 + (cnt - 1) * 93
         sb.Append(Key(KeyPos))
      Next
      Return sb.ToString
   End Function

   Public Function Decrypt(ByVal Text As String) As String
      Dim sb As New System.Text.StringBuilder
      Dim KeyPos As Long = 0
      If Not KeyAvailable Then
         Return ""
      End If
      For cnt As Long = 1 To Text.Length
         For KeyPos = 0 To 93
            If Key(KeyPos + (cnt - 1) * 93) = Mid(Text, cnt, 1) Then
               Exit For
            End If
         Next
         sb.Append(Chr(KeyPos + 32))
      Next
      Return sb.ToString
   End Function

   Public Sub SaveKey(ByVal Filename As String)
      Dim sb As New System.Text.StringBuilder
      For i As Long = 0 To Key.Count - 1
         sb.Append(Key(i))
      Next
      My.Computer.FileSystem.WriteAllText(Filename, sb.ToString, False)
   End Sub

   Public Sub LoadKey(ByVal FileName As String)
      Dim sb As New System.Text.StringBuilder
      sb.Append(My.Computer.FileSystem.ReadAllText(FileName))
      For i As Integer = 0 To sb.Length - 1
         Key(i) = sb(i)
      Next
      KeyAvailable = True
      KeyName = FileName
   End Sub

End Class
