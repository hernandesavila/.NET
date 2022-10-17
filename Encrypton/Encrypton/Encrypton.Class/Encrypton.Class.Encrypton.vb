Imports System.Text
Imports System.Security.Cryptography
Imports System.Configuration

''' <summary>
''' Class that manage all encryption acts
''' </summary>
''' <remarks></remarks>
Public Class Encryption

#Region "Shared Variables"
    Private Shared TripleDES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
#End Region

#Region "Variables"
    ' Define the encrypt/decrypt key
    Private Shared _strKey As String = ConfigurationManager.AppSettings("EncryptKey")
#End Region

#Region "Properties"
#End Region

#Region "Constructors"
#End Region

#Region "Functions"
#End Region

#Region "Shared Functions"
    ''' <summary> 
    ''' Calculates the MD5 Hash
    ''' </summary> 
    ''' <param name="value">Key</param> 
    Public Shared Function MD5Hash(ByVal value As String) As Byte()

        ' Converte a chave para um array de bytes  
        Dim byteArray() As Byte = ASCIIEncoding.UTF8.GetBytes(value)
        Return MD5.ComputeHash(byteArray)

    End Function

    ''' <summary> 
    ''' Encrypt a string based on a key
    ''' </summary> 
    ''' <param name="stringToEncrypt">String to encrypt</param> 
    Public Shared Function Encrypt(ByVal stringToEncrypt As String) As String

        Try

            ' key and cipher's definition (in that case is Electronic 
            ' Codebook,each block will have a individual encrypt) 
            TripleDES.Key = Encryption.MD5Hash(_strKey)
            TripleDES.Mode = CipherMode.ECB

            Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
            Return Convert.ToBase64String _
                (TripleDES.CreateEncryptor(). _
                    TransformFinalBlock(Buffer, 0, Buffer.Length))

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return String.Empty
        End Try

    End Function

    ''' <summary> 
    ''' Decrypt a string based on a key
    ''' </summary> 
    ''' <param name="encryptedString">String to decrypt</param> 
    Public Shared Function Decrypt(ByVal encryptedString As String) As String

        Try

            If encryptedString = String.Empty Then Return String.Empty
            TripleDES.Key = Encryption.MD5Hash(_strKey)
            TripleDES.Mode = CipherMode.ECB


            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            Return ASCIIEncoding.ASCII.GetString _
                (TripleDES.CreateDecryptor(). _
                    TransformFinalBlock(Buffer, 0, Buffer.Length))

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return String.Empty
        End Try
    End Function
#End Region

#Region "Subs"
#End Region

#Region "Shared Subs"
#End Region

End Class
