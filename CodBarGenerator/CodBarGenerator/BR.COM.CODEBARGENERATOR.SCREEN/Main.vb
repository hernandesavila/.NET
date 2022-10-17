Public Class Main

#Region "Variables"
#End Region

#Region "Properties"
#End Region

#Region "Constructors"
#End Region

#Region "Functions"
    Private Function ValidateScreen() As Boolean
        Try
            If txtTextCodeBar.Text.Equals(String.Empty) Then
                MsgBox("Text CodeBar is requirid!!", MsgBoxStyle.Exclamation, Me.Name)
                txtTextCodeBar.Focus()
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "Subs"
    Private Sub SetNotifyIcon()
        Try
            nfiNotifyIcon.Text = My.Application.Info.Title
            nfiNotifyIcon.Icon = Me.Icon
            nfiNotifyIcon.Visible = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SendMessageBallonNotifyIcon(ByVal strMessge As String, ByVal ttiIcon As ToolTipIcon, strTitle As String, Optional ByVal intTimeOut As Integer = 500)
        Try
            If nfiNotifyIcon IsNot Nothing Then
                nfiNotifyIcon.ShowBalloonTip(intTimeOut, strTitle, strMessge, ttiIcon)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub ShowPicBarcodeImage(ByVal bolShowComponent As Boolean)
        Try
            If bolShowComponent And Me.Height < 300 Then
                Me.Height = 300
            ElseIf Not bolShowComponent And Me.Height > 200 Then
                Me.Height = 200
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub ChangePanels(ByVal objControl As Object)
        Try
            Select Case objControl.Name
                Case ABOUTToolStripMenuItem.Name, tsmAbout.Name
                    pnlCodeBarGenerator.Visible = False
                    pnlAbout.Visible = True
                    pnlAbout.BringToFront()
                Case btnCloseAbout.Name
                    pnlCodeBarGenerator.Visible = True
                    pnlAbout.Visible = False
                    pnlCodeBarGenerator.BringToFront()
                Case Else
                    pnlCodeBarGenerator.Visible = True
                    pnlAbout.Visible = False
                    pnlCodeBarGenerator.BringToFront()
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub LoadComboSize()
        Dim objListSizes As New List(Of String) From {"260x85", "300x85", "400x85", "500x85"}

        Try
            With cmbSize
                .ValueMember = "value"
                .DataSource = New BindingSource(objListSizes, Nothing)
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub ResizeAndPositionForm()
        Try
            If picResultCodeBar.Width > 284 Then
                Me.Width = picResultCodeBar.Width + 23
            Else
                Me.Width = 284
            End If

            btnExit.Location = New Point(Me.Width - btnExit.Width, btnExit.Location.Y)
            btnMinimize.Location = New Point(btnExit.Location.X - btnMinimize.Width, btnMinimize.Location.Y)
            pnlCodeBarGenerator.Width = Me.Width
            pnlAbout.Width = Me.Width

            With Me
                .Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
                .Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SaveImege()
        Dim objSaveFileDialog = New SaveFileDialog

        Try
            With objSaveFileDialog
                .Filter = "Image PNG | *.png"
                .DefaultExt = "png"
            End With

            If objSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                picResultCodeBar.Image.Save(objSaveFileDialog.FileName, Imaging.ImageFormat.Png)
            End If

            Call SendMessageBallonNotifyIcon("Image Save Successful!", ToolTipIcon.Info, My.Application.Info.Title & " - Save Image", 300)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SystemExit()
        Try
            Me.Close()
            End
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "Events"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call SetNotifyIcon()
            Call ShowPicBarcodeImage(False)
            Call LoadComboSize()
            Call ChangePanels(sender)
            Call ResizeAndPositionForm()

            SaveToolStripMenuItem.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            nfiNotifyIcon.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub nfiNotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nfiNotifyIcon.MouseDoubleClick
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Normal
            Else
                Me.WindowState = FormWindowState.Minimized
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub tsmSave_Click(sender As Object, e As EventArgs) Handles tsmSave.Click
        Try
            Call SaveImege()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub tsmCopy_Click(sender As Object, e As EventArgs) Handles tsmCopy.Click
        Try
            Clipboard.Clear()
            Clipboard.SetImage(picResultCodeBar.Image)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub tsmAbout_Click(sender As Object, e As EventArgs) Handles tsmAbout.Click
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Normal
            End If

            Call ChangePanels(sender)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        Try
            Call SystemExit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Call SaveImege()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        Try
            Call ChangePanels(sender)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub btnGenerateCodeBar_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            If ValidateScreen() Then
                Call ShowPicBarcodeImage(True)

                With picResultCodeBar
                    .Width = cmbSize.SelectedItem.ToString.Split("x")(0)
                    .Height = cmbSize.SelectedItem.ToString.Split("x")(1)
                    .Image = New CodeBar(txtTextCodeBar.Text).GenerateBarCode(cmbSize.SelectedItem.ToString.Split("x")(0), cmbSize.SelectedItem.ToString.Split("x")(1))
                End With

                Call ResizeAndPositionForm()

                SaveToolStripMenuItem.Enabled = True
                Call SendMessageBallonNotifyIcon("Barcode Creation Successful!", ToolTipIcon.Info, My.Application.Info.Title & " - Generate Barcode", 300)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            Call ShowPicBarcodeImage(False)

            txtTextCodeBar.Text = String.Empty
            picResultCodeBar.Image = Nothing
            SaveToolStripMenuItem.Enabled = False
            cmbSize.SelectedIndex = 0
            picResultCodeBar.Width = 284
            txtTextCodeBar.Focus()

            Call ResizeAndPositionForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub btnCloseAbout_Click(sender As Object, e As EventArgs) Handles btnCloseAbout.Click
        Try
            Call ChangePanels(sender)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            Call SystemExit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub txtTextCodeBar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTextCodeBar.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                cmbSize.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub

    Private Sub cmbSize_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSize.KeyDown
        Try
            If e.KeyCode = Keys.Return Then
                btnGenerate.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Name)
        End Try
    End Sub
#End Region

End Class
