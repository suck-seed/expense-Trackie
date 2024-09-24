Module EncryptorDecryptor
    'Public Function EncryptPassword(password As String) As String
    '    Dim key As Integer = 123
    '    Dim encryptedBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)


    '    For i As Integer = 0 To encryptedBytes.Length - 1
    '        encryptedBytes(i) = encryptedBytes(i) Xor key
    '    Next

    '    Return Convert.ToBase64String(encryptedBytes)

    'End Function



    '' Decrypts the password using XOR and Base64 decoding
    'Public Function DecryptPassword(encryptedPassword As String) As String

    '    ' using same key for decryption
    '    Dim key As Integer = 123
    '    Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedPassword)

    '    ' XOR each byte with the key to decrypt
    '    For i As Integer = 0 To encryptedBytes.Length - 1
    '        encryptedBytes(i) = encryptedBytes(i) Xor key
    '    Next

    '    ' Convert byte array back to the original string
    '    Return System.Text.Encoding.UTF8.GetString(encryptedBytes)
    'End Function



    ' Encrypts the password using XOR and Base64 encoding
    Public Function EncryptPassword(password As String) As String
        Dim key As Integer = 123 ' The XOR key, must be the same for decryption
        Dim passwordBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)

        ' XOR each byte of the password with the key
        For i As Integer = 0 To passwordBytes.Length - 1
            passwordBytes(i) = passwordBytes(i) Xor key
        Next

        ' Convert the XORed bytes to a Base64 string for safe storage
        Return Convert.ToBase64String(passwordBytes)
    End Function

    ' Decrypts the password by reversing XOR and Base64 decoding
    Public Function DecryptPassword(encryptedPassword As String) As String
        Dim key As Integer = 123 ' The XOR key, must match the encryption key
        Dim encryptedBytes As Byte() = Convert.FromBase64String(encryptedPassword)

        ' XOR each byte with the key to revert the encryption
        For i As Integer = 0 To encryptedBytes.Length - 1
            encryptedBytes(i) = encryptedBytes(i) Xor key
        Next

        ' Convert the bytes back to the original password string
        Return System.Text.Encoding.UTF8.GetString(encryptedBytes)
    End Function


End Module
