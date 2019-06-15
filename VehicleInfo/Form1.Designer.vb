<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.ownerphoneTxt = New System.Windows.Forms.TextBox()
        Me.ownernameTxt = New System.Windows.Forms.TextBox()
        Me.licenceTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sortedBtn = New System.Windows.Forms.Button()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.addBtn)
        Me.GroupBox1.Controls.Add(Me.ownerphoneTxt)
        Me.GroupBox1.Controls.Add(Me.ownernameTxt)
        Me.GroupBox1.Controls.Add(Me.licenceTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 233)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle Info"
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(9, 192)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(197, 23)
        Me.addBtn.TabIndex = 6
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'ownerphoneTxt
        '
        Me.ownerphoneTxt.Location = New System.Drawing.Point(9, 143)
        Me.ownerphoneTxt.Name = "ownerphoneTxt"
        Me.ownerphoneTxt.Size = New System.Drawing.Size(197, 20)
        Me.ownerphoneTxt.TabIndex = 5
        '
        'ownernameTxt
        '
        Me.ownernameTxt.Location = New System.Drawing.Point(9, 94)
        Me.ownernameTxt.Name = "ownernameTxt"
        Me.ownernameTxt.Size = New System.Drawing.Size(197, 20)
        Me.ownernameTxt.TabIndex = 4
        '
        'licenceTxt
        '
        Me.licenceTxt.Location = New System.Drawing.Point(9, 45)
        Me.licenceTxt.Name = "licenceTxt"
        Me.licenceTxt.Size = New System.Drawing.Size(197, 20)
        Me.licenceTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Owner phone number "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Owner name "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Licence plate number "
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.Location = New System.Drawing.Point(277, 49)
        Me.listBox.Name = "listBox"
        Me.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.listBox.Size = New System.Drawing.Size(534, 407)
        Me.listBox.TabIndex = 1
        '
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(277, 24)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(178, 20)
        Me.searchTxt.TabIndex = 2
        '
        'searchBtn
        '
        Me.searchBtn.Location = New System.Drawing.Point(472, 23)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 21)
        Me.searchBtn.TabIndex = 3
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(277, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "View the data for a specified vehicle"
        '
        'sortedBtn
        '
        Me.sortedBtn.Location = New System.Drawing.Point(668, 21)
        Me.sortedBtn.Name = "sortedBtn"
        Me.sortedBtn.Size = New System.Drawing.Size(143, 23)
        Me.sortedBtn.TabIndex = 5
        Me.sortedBtn.Text = "View sorted licence plates"
        Me.sortedBtn.UseVisualStyleBackColor = True
        '
        'refreshBtn
        '
        Me.refreshBtn.Location = New System.Drawing.Point(21, 13)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(75, 23)
        Me.refreshBtn.TabIndex = 6
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'removeBtn
        '
        Me.removeBtn.Location = New System.Drawing.Point(21, 410)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(197, 23)
        Me.removeBtn.TabIndex = 7
        Me.removeBtn.Text = "Remove"
        Me.removeBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 467)
        Me.Controls.Add(Me.removeBtn)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.sortedBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents addBtn As Button
    Friend WithEvents ownerphoneTxt As TextBox
    Friend WithEvents ownernameTxt As TextBox
    Friend WithEvents licenceTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listBox As ListBox
    Friend WithEvents searchTxt As TextBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents sortedBtn As Button
    Friend WithEvents refreshBtn As Button
    Friend WithEvents removeBtn As Button
End Class
