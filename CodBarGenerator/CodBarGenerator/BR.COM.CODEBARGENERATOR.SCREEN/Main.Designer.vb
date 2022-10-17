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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.lblLabelTextCodeBar = New System.Windows.Forms.Label()
        Me.txtTextCodeBar = New System.Windows.Forms.TextBox()
        Me.picResultCodeBar = New System.Windows.Forms.PictureBox()
        Me.cmsImageContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.tlpComponentsBack = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpComponentsContent = New System.Windows.Forms.TableLayoutPanel()
        Me.mstMenuToolbar = New System.Windows.Forms.MenuStrip()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlCodeBarGenerator = New System.Windows.Forms.Panel()
        Me.pnlAbout = New System.Windows.Forms.Panel()
        Me.tlpAbout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblContentAbout = New System.Windows.Forms.Label()
        Me.btnCloseAbout = New System.Windows.Forms.Button()
        Me.lblTitleAbout = New System.Windows.Forms.Label()
        Me.nfiNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotifyIconContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picResultCodeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsImageContext.SuspendLayout()
        Me.tlpComponentsBack.SuspendLayout()
        Me.tlpComponentsContent.SuspendLayout()
        Me.mstMenuToolbar.SuspendLayout()
        Me.pnlCodeBarGenerator.SuspendLayout()
        Me.pnlAbout.SuspendLayout()
        Me.tlpAbout.SuspendLayout()
        Me.cmsNotifyIconContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLabelTextCodeBar
        '
        Me.lblLabelTextCodeBar.AutoSize = True
        Me.lblLabelTextCodeBar.Location = New System.Drawing.Point(3, 0)
        Me.lblLabelTextCodeBar.Name = "lblLabelTextCodeBar"
        Me.lblLabelTextCodeBar.Size = New System.Drawing.Size(75, 13)
        Me.lblLabelTextCodeBar.TabIndex = 0
        Me.lblLabelTextCodeBar.Text = "Text CodeBar:"
        '
        'txtTextCodeBar
        '
        Me.txtTextCodeBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTextCodeBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTextCodeBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtTextCodeBar.Location = New System.Drawing.Point(3, 16)
        Me.txtTextCodeBar.Name = "txtTextCodeBar"
        Me.txtTextCodeBar.Size = New System.Drawing.Size(260, 23)
        Me.txtTextCodeBar.TabIndex = 0
        '
        'picResultCodeBar
        '
        Me.picResultCodeBar.ContextMenuStrip = Me.cmsImageContext
        Me.picResultCodeBar.Location = New System.Drawing.Point(11, 148)
        Me.picResultCodeBar.Name = "picResultCodeBar"
        Me.picResultCodeBar.Size = New System.Drawing.Size(260, 85)
        Me.picResultCodeBar.TabIndex = 2
        Me.picResultCodeBar.TabStop = False
        '
        'cmsImageContext
        '
        Me.cmsImageContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSave, Me.tsmCopy})
        Me.cmsImageContext.Name = "cmsImageContext"
        Me.cmsImageContext.Size = New System.Drawing.Size(103, 48)
        '
        'tsmSave
        '
        Me.tsmSave.Name = "tsmSave"
        Me.tsmSave.Size = New System.Drawing.Size(102, 22)
        Me.tsmSave.Text = "Save"
        '
        'tsmCopy
        '
        Me.tsmCopy.Name = "tsmCopy"
        Me.tsmCopy.Size = New System.Drawing.Size(102, 22)
        Me.tsmCopy.Text = "Copy"
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(3, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 27)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Location = New System.Drawing.Point(143, 3)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(114, 27)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(240, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(22, 23)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.Text = "0"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnExit.Location = New System.Drawing.Point(261, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "r"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmbSize
        '
        Me.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Location = New System.Drawing.Point(3, 63)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(121, 23)
        Me.cmbSize.Sorted = True
        Me.cmbSize.TabIndex = 1
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(3, 47)
        Me.lblSize.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 0
        Me.lblSize.Text = "Size:"
        '
        'tlpComponentsBack
        '
        Me.tlpComponentsBack.ColumnCount = 1
        Me.tlpComponentsBack.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpComponentsBack.Controls.Add(Me.lblLabelTextCodeBar, 0, 0)
        Me.tlpComponentsBack.Controls.Add(Me.cmbSize, 0, 3)
        Me.tlpComponentsBack.Controls.Add(Me.txtTextCodeBar, 0, 1)
        Me.tlpComponentsBack.Controls.Add(Me.lblSize, 0, 2)
        Me.tlpComponentsBack.Controls.Add(Me.tlpComponentsContent, 0, 4)
        Me.tlpComponentsBack.Location = New System.Drawing.Point(11, 10)
        Me.tlpComponentsBack.Name = "tlpComponentsBack"
        Me.tlpComponentsBack.RowCount = 5
        Me.tlpComponentsBack.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpComponentsBack.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpComponentsBack.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpComponentsBack.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpComponentsBack.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpComponentsBack.Size = New System.Drawing.Size(260, 132)
        Me.tlpComponentsBack.TabIndex = 0
        '
        'tlpComponentsContent
        '
        Me.tlpComponentsContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpComponentsContent.ColumnCount = 2
        Me.tlpComponentsContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpComponentsContent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpComponentsContent.Controls.Add(Me.btnReset, 0, 0)
        Me.tlpComponentsContent.Controls.Add(Me.btnGenerate, 1, 0)
        Me.tlpComponentsContent.Location = New System.Drawing.Point(3, 94)
        Me.tlpComponentsContent.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.tlpComponentsContent.Name = "tlpComponentsContent"
        Me.tlpComponentsContent.RowCount = 1
        Me.tlpComponentsContent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpComponentsContent.Size = New System.Drawing.Size(260, 34)
        Me.tlpComponentsContent.TabIndex = 1
        '
        'mstMenuToolbar
        '
        Me.mstMenuToolbar.AutoSize = False
        Me.mstMenuToolbar.BackColor = System.Drawing.Color.Transparent
        Me.mstMenuToolbar.Dock = System.Windows.Forms.DockStyle.None
        Me.mstMenuToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ABOUTToolStripMenuItem})
        Me.mstMenuToolbar.Location = New System.Drawing.Point(0, 24)
        Me.mstMenuToolbar.Name = "mstMenuToolbar"
        Me.mstMenuToolbar.Size = New System.Drawing.Size(280, 24)
        Me.mstMenuToolbar.TabIndex = 6
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.SaveToolStripMenuItem.Text = "&SAVE"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ABOUTToolStripMenuItem.Text = "&ABOUT"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblTitle.Location = New System.Drawing.Point(9, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(117, 16)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "CodBar Generator"
        '
        'pnlCodeBarGenerator
        '
        Me.pnlCodeBarGenerator.Controls.Add(Me.tlpComponentsBack)
        Me.pnlCodeBarGenerator.Controls.Add(Me.picResultCodeBar)
        Me.pnlCodeBarGenerator.Location = New System.Drawing.Point(0, 51)
        Me.pnlCodeBarGenerator.Name = "pnlCodeBarGenerator"
        Me.pnlCodeBarGenerator.Size = New System.Drawing.Size(284, 246)
        Me.pnlCodeBarGenerator.TabIndex = 0
        '
        'pnlAbout
        '
        Me.pnlAbout.Controls.Add(Me.tlpAbout)
        Me.pnlAbout.Controls.Add(Me.lblTitleAbout)
        Me.pnlAbout.Location = New System.Drawing.Point(0, 51)
        Me.pnlAbout.Name = "pnlAbout"
        Me.pnlAbout.Size = New System.Drawing.Size(284, 246)
        Me.pnlAbout.TabIndex = 1
        '
        'tlpAbout
        '
        Me.tlpAbout.ColumnCount = 1
        Me.tlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAbout.Controls.Add(Me.lblContentAbout, 0, 0)
        Me.tlpAbout.Controls.Add(Me.btnCloseAbout, 0, 1)
        Me.tlpAbout.Location = New System.Drawing.Point(14, 42)
        Me.tlpAbout.Name = "tlpAbout"
        Me.tlpAbout.RowCount = 2
        Me.tlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpAbout.Size = New System.Drawing.Size(253, 92)
        Me.tlpAbout.TabIndex = 6
        '
        'lblContentAbout
        '
        Me.lblContentAbout.Location = New System.Drawing.Point(3, 0)
        Me.lblContentAbout.Name = "lblContentAbout"
        Me.lblContentAbout.Size = New System.Drawing.Size(244, 50)
        Me.lblContentAbout.TabIndex = 5
        Me.lblContentAbout.Text = "Developed By:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hernandes Ávila da Silva Oliveira" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "June, 2014"
        '
        'btnCloseAbout
        '
        Me.btnCloseAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseAbout.Location = New System.Drawing.Point(136, 53)
        Me.btnCloseAbout.Name = "btnCloseAbout"
        Me.btnCloseAbout.Size = New System.Drawing.Size(114, 27)
        Me.btnCloseAbout.TabIndex = 4
        Me.btnCloseAbout.Text = "&Close"
        Me.btnCloseAbout.UseVisualStyleBackColor = True
        '
        'lblTitleAbout
        '
        Me.lblTitleAbout.AutoSize = True
        Me.lblTitleAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblTitleAbout.Location = New System.Drawing.Point(13, 12)
        Me.lblTitleAbout.Name = "lblTitleAbout"
        Me.lblTitleAbout.Size = New System.Drawing.Size(52, 20)
        Me.lblTitleAbout.TabIndex = 0
        Me.lblTitleAbout.Text = "About"
        '
        'nfiNotifyIcon
        '
        Me.nfiNotifyIcon.ContextMenuStrip = Me.cmsNotifyIconContext
        Me.nfiNotifyIcon.Text = "NotifyIcon1"
        Me.nfiNotifyIcon.Visible = True
        '
        'cmsNotifyIconContext
        '
        Me.cmsNotifyIconContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAbout, Me.tsmExit})
        Me.cmsNotifyIconContext.Name = "cmsNotifyIconContext"
        Me.cmsNotifyIconContext.Size = New System.Drawing.Size(108, 48)
        '
        'tsmAbout
        '
        Me.tsmAbout.Name = "tsmAbout"
        Me.tsmAbout.Size = New System.Drawing.Size(107, 22)
        Me.tsmAbout.Text = "About"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(107, 22)
        Me.tsmExit.Text = "Exit"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.mstMenuToolbar)
        Me.Controls.Add(Me.pnlCodeBarGenerator)
        Me.Controls.Add(Me.pnlAbout)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picResultCodeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsImageContext.ResumeLayout(False)
        Me.tlpComponentsBack.ResumeLayout(False)
        Me.tlpComponentsBack.PerformLayout()
        Me.tlpComponentsContent.ResumeLayout(False)
        Me.mstMenuToolbar.ResumeLayout(False)
        Me.mstMenuToolbar.PerformLayout()
        Me.pnlCodeBarGenerator.ResumeLayout(False)
        Me.pnlAbout.ResumeLayout(False)
        Me.pnlAbout.PerformLayout()
        Me.tlpAbout.ResumeLayout(False)
        Me.cmsNotifyIconContext.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLabelTextCodeBar As System.Windows.Forms.Label
    Friend WithEvents txtTextCodeBar As System.Windows.Forms.TextBox
    Friend WithEvents picResultCodeBar As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents tlpComponentsBack As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpComponentsContent As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mstMenuToolbar As System.Windows.Forms.MenuStrip
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlCodeBarGenerator As System.Windows.Forms.Panel
    Friend WithEvents pnlAbout As System.Windows.Forms.Panel
    Friend WithEvents lblTitleAbout As System.Windows.Forms.Label
    Friend WithEvents btnCloseAbout As System.Windows.Forms.Button
    Friend WithEvents lblContentAbout As System.Windows.Forms.Label
    Friend WithEvents tlpAbout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmsImageContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nfiNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsNotifyIconContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAbout As System.Windows.Forms.ToolStripMenuItem

End Class
