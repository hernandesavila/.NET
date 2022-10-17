Imports System.IO
Imports System.Runtime.InteropServices

Public Class Main

    Private Const _STR_KEY As String = "MyKey"

    Private Sub ClearScreen()
        objOpenFile.FileName = String.Empty
        txtInputFile.Text = String.Empty
        btnEncrypt.Enabled = False
        btnDecrypt.Enabled = False
    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        Dim strOutputFileName As String

        Try
            With objSaveFile
                .FileName = Path.GetFileName(txtInputFile.Text)
                .Filter = "All files (*.*)|*.*"
            End With

            If objSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strOutputFileName = objSaveFile.FileName

                'Cryptograph access only user account crypt
                'File.Copy(txtFileName.Text, strOutputFileName)
                'File.Encrypt(strOutputFileName)

                SharpAESCrypt.SharpAESCrypt.Encrypt(_STR_KEY, txtInputFile.Text, strOutputFileName, 10)

                Call ClearScreen()

                MsgBox("Arquivo Criptografado com Sucesso!", MsgBoxStyle.Information, Me.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text & " - Erro")
        End Try
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Dim strOutputFileName As String

        Try
            With objSaveFile
                .FileName = Path.GetFileName(txtInputFile.Text)
                .DefaultExt = Path.GetExtension(txtInputFile.Text)
            End With

            If objSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strOutputFileName = objSaveFile.FileName

                'Cryptograph access only user account crypt
                'File.Copy(txtFileName.Text, strOutputFileName)
                'File.Decrypt(strOutputFileName)

                SharpAESCrypt.SharpAESCrypt.Decrypt(_STR_KEY, txtInputFile.Text, strOutputFileName)

                Call ClearScreen()

                MsgBox("Arquivo Desriptografado com Sucesso!", MsgBoxStyle.Information, Me.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text & " - Erro")
        End Try
    End Sub

    Private Sub tsiSair_Click(sender As Object, e As EventArgs) Handles tsiSair.Click
        Try
            Me.Dispose()
            End
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text & " - Erro")
        End Try
    End Sub

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        Try
            If objOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtInputFile.Text = objOpenFile.FileName
                btnEncrypt.Enabled = True
                btnDecrypt.Enabled = True
            Else
                Call ClearScreen()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text & " - Erro")
        End Try
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call ClearScreen()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text & " - Erro")
        End Try
    End Sub

End Class
