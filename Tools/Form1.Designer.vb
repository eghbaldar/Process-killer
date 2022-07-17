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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstKeys = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdMainRoot = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOpenSsssubKey = New System.Windows.Forms.Label()
        Me.txtOpenSubKey = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(719, 287)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstKeys)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(711, 261)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reg Keys"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstKeys
        '
        Me.lstKeys.FormattingEnabled = True
        Me.lstKeys.Location = New System.Drawing.Point(324, 6)
        Me.lstKeys.Name = "lstKeys"
        Me.lstKeys.Size = New System.Drawing.Size(381, 186)
        Me.lstKeys.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdMainRoot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtOpenSsssubKey)
        Me.GroupBox1.Controls.Add(Me.txtOpenSubKey)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.txtKey)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remove Keys"
        '
        'cmdMainRoot
        '
        Me.cmdMainRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdMainRoot.FormattingEnabled = True
        Me.cmdMainRoot.Items.AddRange(New Object() {"HKEY CURRENT USER", "HKEY LOCAL MACHINE", "HKEY CLASSIC ROOT"})
        Me.cmdMainRoot.Location = New System.Drawing.Point(15, 49)
        Me.cmdMainRoot.Name = "cmdMainRoot"
        Me.cmdMainRoot.Size = New System.Drawing.Size(280, 21)
        Me.cmdMainRoot.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Main Root:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Key:"
        '
        'txtOpenSsssubKey
        '
        Me.txtOpenSsssubKey.AutoSize = True
        Me.txtOpenSsssubKey.Location = New System.Drawing.Point(14, 82)
        Me.txtOpenSsssubKey.Name = "txtOpenSsssubKey"
        Me.txtOpenSsssubKey.Size = New System.Drawing.Size(76, 13)
        Me.txtOpenSsssubKey.TabIndex = 3
        Me.txtOpenSsssubKey.Text = "OpenSubKey :"
        '
        'txtOpenSubKey
        '
        Me.txtOpenSubKey.Location = New System.Drawing.Point(15, 101)
        Me.txtOpenSubKey.Name = "txtOpenSubKey"
        Me.txtOpenSubKey.Size = New System.Drawing.Size(280, 20)
        Me.txtOpenSubKey.TabIndex = 2
        Me.txtOpenSubKey.Text = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(15, 203)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(280, 28)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(15, 152)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.ReadOnly = True
        Me.txtKey.Size = New System.Drawing.Size(280, 35)
        Me.txtKey.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 287)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tools"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents txtOpenSsssubKey As System.Windows.Forms.Label
    Friend WithEvents txtOpenSubKey As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstKeys As System.Windows.Forms.ListBox
    Friend WithEvents cmdMainRoot As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
