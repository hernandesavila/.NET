<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.objOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.menMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsiSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.objSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.lblInputFile = New System.Windows.Forms.Label()
        Me.menMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(12, 86)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(100, 37)
        Me.btnEncrypt.TabIndex = 0
        Me.btnEncrypt.Text = "Criptografar"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(139, 86)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(100, 37)
        Me.btnDecrypt.TabIndex = 0
        Me.btnDecrypt.Text = "Desriptografar"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'objOpenFile
        '
        Me.objOpenFile.FileName = "OpenFileDialog1"
        Me.objOpenFile.Title = "Selecionar Arquivo"
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(12, 49)
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.ReadOnly = True
        Me.txtInputFile.Size = New System.Drawing.Size(190, 20)
        Me.txtInputFile.TabIndex = 1
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(208, 48)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(31, 23)
        Me.btnSelectFile.TabIndex = 2
        Me.btnSelectFile.Text = "..."
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'menMenuStrip
        '
        Me.menMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsiSair})
        Me.menMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menMenuStrip.Name = "menMenuStrip"
        Me.menMenuStrip.Size = New System.Drawing.Size(253, 24)
        Me.menMenuStrip.TabIndex = 3
        Me.menMenuStrip.Text = "MenuStrip1"
        '
        'tsiSair
        '
        Me.tsiSair.Name = "tsiSair"
        Me.tsiSair.Size = New System.Drawing.Size(38, 20)
        Me.tsiSair.Text = "Sair"
        '
        'objSaveFile
        '
        Me.objSaveFile.Title = "Arquivo de Destino"
        '
        'lblInputFile
        '
        Me.lblInputFile.AutoSize = True
        Me.lblInputFile.Location = New System.Drawing.Point(12, 31)
        Me.lblInputFile.Name = "lblInputFile"
        Me.lblInputFile.Size = New System.Drawing.Size(97, 13)
        Me.lblInputFile.TabIndex = 4
        Me.lblInputFile.Text = "Arquivo de Origem:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 132)
        Me.Controls.Add(Me.lblInputFile)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Controls.Add(Me.txtInputFile)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.menMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menMenuStrip
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EncryptonFile"
        Me.menMenuStrip.ResumeLayout(False)
        Me.menMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents objOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtInputFile As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectFile As System.Windows.Forms.Button
    Friend WithEvents menMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tsiSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents objSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblInputFile As System.Windows.Forms.Label

End Class
