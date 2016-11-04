<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADBruteFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADBruteFrm))
        Me.Label2 = New System.Windows.Forms.Label
        Me.EnumBtn = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Countlbl = New System.Windows.Forms.Label
        Me.Domainlbl = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ExportBtn = New System.Windows.Forms.Button
        Me.SaveDlg = New System.Windows.Forms.SaveFileDialog
        Me.Password = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Username = New System.Windows.Forms.Label
        Me.SysList = New System.Windows.Forms.ListView
        Me.Col1 = New System.Windows.Forms.ColumnHeader
        Me.Col2 = New System.Windows.Forms.ColumnHeader
        Me.DomainName = New System.Windows.Forms.Label
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ViewAllBtn = New System.Windows.Forms.Button
        Me.Menu = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExportToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExSyslist = New System.Windows.Forms.ListView
        Me.ColLogon = New System.Windows.Forms.ColumnHeader
        Me.ColPass = New System.Windows.Forms.ColumnHeader
        Me.TotUsercountlbl = New System.Windows.Forms.Label
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'EnumBtn
        '
        Me.EnumBtn.Enabled = False
        Me.EnumBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnumBtn.Location = New System.Drawing.Point(373, 103)
        Me.EnumBtn.Name = "EnumBtn"
        Me.EnumBtn.Size = New System.Drawing.Size(121, 23)
        Me.EnumBtn.TabIndex = 3
        Me.EnumBtn.Text = "&Start"
        Me.EnumBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Users:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Domain:"
        '
        'Countlbl
        '
        Me.Countlbl.AutoSize = True
        Me.Countlbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Countlbl.Location = New System.Drawing.Point(130, 448)
        Me.Countlbl.Name = "Countlbl"
        Me.Countlbl.Size = New System.Drawing.Size(0, 13)
        Me.Countlbl.TabIndex = 4
        '
        'Domainlbl
        '
        Me.Domainlbl.AutoSize = True
        Me.Domainlbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Domainlbl.Location = New System.Drawing.Point(378, 448)
        Me.Domainlbl.Name = "Domainlbl"
        Me.Domainlbl.Size = New System.Drawing.Size(0, 13)
        Me.Domainlbl.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Domain"
        '
        'ExportBtn
        '
        Me.ExportBtn.Enabled = False
        Me.ExportBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportBtn.Location = New System.Drawing.Point(374, 476)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(120, 23)
        Me.ExportBtn.TabIndex = 14
        Me.ExportBtn.Text = "&Export to File"
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'SaveDlg
        '
        Me.SaveDlg.Filter = "Comma Separated Values (*.csv)|*.csv|Text File (*.txt)|*.txt|Excel File (*.xls)|*" & _
            ".xls"
        Me.SaveDlg.RestoreDirectory = True
        Me.SaveDlg.Title = "Export Enumeration"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(99, 105)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(228, 21)
        Me.Password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Default Pass:"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.Maroon
        Me.Username.Location = New System.Drawing.Point(96, 72)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(82, 13)
        Me.Username.TabIndex = 4
        Me.Username.Text = "<username>"
        '
        'SysList
        '
        Me.SysList.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.SysList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.SysList.BackColor = System.Drawing.Color.Beige
        Me.SysList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SysList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1, Me.Col2})
        Me.SysList.Cursor = System.Windows.Forms.Cursors.Default
        Me.SysList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SysList.ForeColor = System.Drawing.Color.Black
        Me.SysList.FullRowSelect = True
        Me.SysList.GridLines = True
        Me.SysList.HideSelection = False
        Me.SysList.Location = New System.Drawing.Point(18, 149)
        Me.SysList.Margin = New System.Windows.Forms.Padding(8)
        Me.SysList.MultiSelect = False
        Me.SysList.Name = "SysList"
        Me.SysList.ShowGroups = False
        Me.SysList.Size = New System.Drawing.Size(476, 278)
        Me.SysList.TabIndex = 15
        Me.SysList.UseCompatibleStateImageBehavior = False
        Me.SysList.View = System.Windows.Forms.View.Details
        '
        'Col1
        '
        Me.Col1.Text = "Full Name"
        Me.Col1.Width = 216
        '
        'Col2
        '
        Me.Col2.Text = "Login Name"
        Me.Col2.Width = 183
        '
        'DomainName
        '
        Me.DomainName.AutoSize = True
        Me.DomainName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainName.ForeColor = System.Drawing.Color.Maroon
        Me.DomainName.Location = New System.Drawing.Point(96, 41)
        Me.DomainName.Name = "DomainName"
        Me.DomainName.Size = New System.Drawing.Size(0, 13)
        Me.DomainName.TabIndex = 4
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'ViewAllBtn
        '
        Me.ViewAllBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAllBtn.Location = New System.Drawing.Point(18, 476)
        Me.ViewAllBtn.Name = "ViewAllBtn"
        Me.ViewAllBtn.Size = New System.Drawing.Size(119, 23)
        Me.ViewAllBtn.TabIndex = 17
        Me.ViewAllBtn.Text = "&View All Users"
        Me.ViewAllBtn.UseVisualStyleBackColor = True
        Me.ViewAllBtn.Visible = False
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(512, 24)
        Me.Menu.TabIndex = 18
        Me.Menu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExportToFileToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StartToolStripMenuItem.Text = "&Start"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'ExportToFileToolStripMenuItem
        '
        Me.ExportToFileToolStripMenuItem.Name = "ExportToFileToolStripMenuItem"
        Me.ExportToFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToFileToolStripMenuItem.Text = "&Export to File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExSyslist
        '
        Me.ExSyslist.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ExSyslist.BackColor = System.Drawing.SystemColors.Info
        Me.ExSyslist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColLogon, Me.ColPass})
        Me.ExSyslist.GridLines = True
        Me.ExSyslist.Location = New System.Drawing.Point(18, 149)
        Me.ExSyslist.MultiSelect = False
        Me.ExSyslist.Name = "ExSyslist"
        Me.ExSyslist.Size = New System.Drawing.Size(476, 278)
        Me.ExSyslist.TabIndex = 19
        Me.ExSyslist.UseCompatibleStateImageBehavior = False
        Me.ExSyslist.View = System.Windows.Forms.View.Details
        '
        'ColLogon
        '
        Me.ColLogon.Text = "Logon Name"
        Me.ColLogon.Width = 242
        '
        'ColPass
        '
        Me.ColPass.Text = "Password"
        Me.ColPass.Width = 160
        '
        'TotUsercountlbl
        '
        Me.TotUsercountlbl.AutoSize = True
        Me.TotUsercountlbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotUsercountlbl.Location = New System.Drawing.Point(293, 72)
        Me.TotUsercountlbl.Name = "TotUsercountlbl"
        Me.TotUsercountlbl.Size = New System.Drawing.Size(0, 13)
        Me.TotUsercountlbl.TabIndex = 20
        '
        'ADBruteFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 514)
        Me.Controls.Add(Me.TotUsercountlbl)
        Me.Controls.Add(Me.ViewAllBtn)
        Me.Controls.Add(Me.SysList)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.ExportBtn)
        Me.Controls.Add(Me.EnumBtn)
        Me.Controls.Add(Me.Domainlbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Countlbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DomainName)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.ExSyslist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.MaximizeBox = False
        Me.Name = "ADBruteFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADBrute v1.2"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EnumBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Countlbl As System.Windows.Forms.Label
    Friend WithEvents Domainlbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ExportBtn As System.Windows.Forms.Button
    Friend WithEvents SaveDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Username As System.Windows.Forms.Label
    Public WithEvents SysList As System.Windows.Forms.ListView
    Friend WithEvents Col1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DomainName As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ViewAllBtn As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend Shadows WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExSyslist As System.Windows.Forms.ListView
    Friend WithEvents ColLogon As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColPass As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotUsercountlbl As System.Windows.Forms.Label

End Class
