Imports System.Security.Cryptography
Imports System.Text
Imports System.DateTime
Imports System.Data

Module other
    Public Function MD5(ByVal StrSource As String, ByVal Code As Integer) As String

        Dim str As String = ""



        Dim md5Hasher As New MD5CryptoServiceProvider()


        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.Default.GetBytes(StrSource))


        Dim sBuilder As New StringBuilder()


        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i


        Select Case Code
            Case 16
                str = sBuilder.ToString().Substring(0, 16)
            Case 32
                str = sBuilder.ToString().Substring(0, 32)
        End Select


        Return str


    End Function
End Module
