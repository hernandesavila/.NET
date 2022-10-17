Public Class Main

#Region "Events"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtInput.Text = String.Empty
            txtOutput.Text = String.Empty
            txtOutput.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            txtInput.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        Try
            If Not txtInput.Text.Trim.Equals(String.Empty) Then
                txtOutput.Text = String.Empty
                txtOutput.Text = Encrypton.Encryption.Encrypt(txtInput.Text.Trim)
            Else
                MsgBox("Informe o texto a se descriptografado!", MsgBoxStyle.Exclamation, Me.Name)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Try
            If Not txtInput.Text.Trim.Equals(String.Empty) Then
                txtOutput.Text = String.Empty
                txtOutput.Text = Encrypton.Encryption.Decrypt(txtInput.Text)
            Else
                MsgBox("Informe o texto a se descriptografado!", MsgBoxStyle.Exclamation, Me.Name)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            txtInput.Text = String.Empty
            txtOutput.Text = String.Empty
            txtInput.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub
#End Region
    
End Class
