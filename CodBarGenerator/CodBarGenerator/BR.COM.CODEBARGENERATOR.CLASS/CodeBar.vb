Imports System.IO
Imports System.Drawing.Text
Imports System.Drawing.Imaging

Public Class CodeBar

#Region "Shared Variables"
#End Region

#Region "Variables"
    Private _strTextCodeBar As String
    Private _pfcFontCollection As New PrivateFontCollection
#End Region

#Region "Properties"
    Property strTextCodeBar As String
        Get
            Return _strTextCodeBar
        End Get
        Set(value As String)
            _strTextCodeBar = value
        End Set
    End Property

    Private Property pfcFontCollection As PrivateFontCollection
        Get
            Return _pfcFontCollection
        End Get
        Set(value As PrivateFontCollection)
            _pfcFontCollection = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New(ByVal strTextCodeBar As String)
        Me.strTextCodeBar = strTextCodeBar
        Me.pfcFontCollection.AddFontFile(My.Application.Info.DirectoryPath & "\IDAutomationHC39M.ttf")
    End Sub
#End Region

#Region "Functions"
    Public Function GenerateBarCode(ByVal intWidth As Integer, ByVal intHeight As Integer) As Image
        Dim objFont As New Font(Me.pfcFontCollection.Families(0), 16)
        Dim objStringFormat As New StringFormat()
        Dim objBlackBrush As New SolidBrush(Color.Black)
        Dim objWhiteBrush As New SolidBrush(Color.White)
        Dim objBytMap As Bitmap
        Dim objGraphics As Graphics

        Try
            objBytMap = New Bitmap(intWidth, intHeight)

            Using objBytMap

                objGraphics = Graphics.FromImage(objBytMap)

                Using objGraphics
                    objStringFormat.Alignment = StringAlignment.Center
                    objGraphics.FillRectangle(objWhiteBrush, 0, 0, objBytMap.Width, objBytMap.Height)
                    objGraphics.DrawString("*" & Me.strTextCodeBar & "*", objFont, objBlackBrush, New Rectangle(0, 3, objBytMap.Width, objBytMap.Height - 3), objStringFormat)
                End Using

                Using objMemoryStream As New MemoryStream()
                    objBytMap.Save(objMemoryStream, ImageFormat.Png)
                    Return Image.FromStream(objMemoryStream)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "Shared Functions"
#End Region

#Region "Subs"
#End Region

#Region "Shared Subs"
#End Region

End Class
