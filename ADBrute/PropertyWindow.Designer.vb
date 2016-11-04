<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertyWindow))
        Me.AttribList = New System.Windows.Forms.ListView
        Me.Col1 = New System.Windows.Forms.ColumnHeader
        Me.Col2 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.ObjNamelbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Domainnamelbl = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Countlbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'AttribList
        '
        Me.AttribList.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.AttribList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.AttribList.BackColor = System.Drawing.Color.Beige
        Me.AttribList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttribList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1, Me.Col2})
        Me.AttribList.Cursor = System.Windows.Forms.Cursors.Default
        Me.AttribList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttribList.ForeColor = System.Drawing.Color.Black
        Me.AttribList.FullRowSelect = True
        Me.AttribList.GridLines = True
        Me.AttribList.HideSelection = False
        Me.AttribList.Location = New System.Drawing.Point(17, 59)
        Me.AttribList.Margin = New System.Windows.Forms.Padding(8)
        Me.AttribList.MultiSelect = False
        Me.AttribList.Name = "AttribList"
        Me.AttribList.ShowGroups = False
        Me.AttribList.Size = New System.Drawing.Size(669, 428)
        Me.AttribList.TabIndex = 13
        Me.AttribList.UseCompatibleStateImageBehavior = False
        Me.AttribList.View = System.Windows.Forms.View.Details
        '
        'Col1
        '
        Me.Col1.Text = "Attribute"
        Me.Col1.Width = 201
        '
        'Col2
        '
        Me.Col2.Text = "Data"
        Me.Col2.Width = 414
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "User:"
        '
        'ObjNamelbl
        '
        Me.ObjNamelbl.AutoSize = True
        Me.ObjNamelbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjNamelbl.Location = New System.Drawing.Point(91, 19)
        Me.ObjNamelbl.Name = "ObjNamelbl"
        Me.ObjNamelbl.Size = New System.Drawing.Size(0, 13)
        Me.ObjNamelbl.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Domain:"
        '
        'Domainnamelbl
        '
        Me.Domainnamelbl.AutoSize = True
        Me.Domainnamelbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Domainnamelbl.Location = New System.Drawing.Point(91, 38)
        Me.Domainnamelbl.Name = "Domainnamelbl"
        Me.Domainnamelbl.Size = New System.Drawing.Size(0, 13)
        Me.Domainnamelbl.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Count:"
        '
        'Countlbl
        '
        Me.Countlbl.AutoSize = True
        Me.Countlbl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Countlbl.Location = New System.Drawing.Point(75, 498)
        Me.Countlbl.Name = "Countlbl"
        Me.Countlbl.Size = New System.Drawing.Size(0, 13)
        Me.Countlbl.TabIndex = 14
        '
        'PropertyWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 525)
        Me.Controls.Add(Me.Domainnamelbl)
        Me.Controls.Add(Me.ObjNamelbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Countlbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AttribList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PropertyWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PropertyWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Col1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ObjNamelbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Domainnamelbl As System.Windows.Forms.Label
    Public WithEvents AttribList As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Countlbl As System.Windows.Forms.Label
End Class
