
Public Class Class3
    'Function getserial()
    '    Dim harddiskserial As New HWINFOCOMLib.HD
    '    Dim ser As String = harddiskserial.serialnumber
    '    Return ser
    'End Function

    'Function cryp2(ByVal inp As String, ByVal i As Integer) As String
    '    Dim crypt As New Chilkat.Crypt2()

    '    Dim success As Boolean
    '    success = crypt.UnlockComponent("Anything for 30-day trial")



    '    crypt.CryptAlgorithm = "blowfish2"

    '    ' CipherMode may be "ecb", "cbc", or "cfb"
    '    crypt.CipherMode = "cbc"

    '    ' KeyLength (in bits) may be a number between 32 and 448.
    '    ' 128-bits is usually sufficient. The KeyLength must be a
    '    ' multiple of 8.
    '    crypt.KeyLength = 128

    '    ' The padding scheme determines the contents of the bytes
    '    ' that are added to pad the result to a multiple of the
    '    ' encryption algorithm's block size. Blowfish has a block
    '    ' size of 8 bytes, so encrypted output is always
    '    ' a multiple of 8.
    '    crypt.PaddingScheme = 0

    '    ' EncodingMode specifies the encoding of the output for
    '    ' encryption, and the input for decryption.
    '    ' It may be "hex", "url", "base64", or "quoted-printable".
    '    crypt.EncodingMode = "hex"

    '    ' An initialization vector is required if using CBC or CFB modes.
    '    ' ECB mode does not use an IV.
    '    ' The length of the IV is equal to the algorithm's block size.
    '    ' It is NOT equal to the length of the key.
    '    Dim ivHex As String
    '    ivHex = "0001020304050607"
    '    crypt.SetEncodedIV(ivHex, "hex")

    '    ' The secret key must equal the size of the key. For
    '    ' 256-bit encryption, the binary secret key is 32 bytes.
    '    ' For 128-bit encryption, the binary secret key is 16 bytes. 

    '    Dim keyHex As String
    '    keyHex = "000102030405060708090A0B0C0D0E0F"
    '    crypt.SetEncodedKey(keyHex, "hex")


    '    If i = 0 Then
    '        Return (crypt.EncryptStringENC(inp))
    '    Else
    '        Return (crypt.DecryptStringENC(inp))
    '    End If

    'End Function

    'sorce: تعلم كيف تحمي برامجك من السرقة من الصفر 
   
End Class
