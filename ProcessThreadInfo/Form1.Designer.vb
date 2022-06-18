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
        Me.listViewCallStack = New System.Windows.Forms.ListView()
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.buttonWalk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewCallStack
        '
        Me.listViewCallStack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listViewCallStack.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader3, Me.columnHeader4})
        Me.listViewCallStack.FullRowSelect = True
        Me.listViewCallStack.HideSelection = False
        Me.listViewCallStack.Location = New System.Drawing.Point(12, 35)
        Me.listViewCallStack.Name = "listViewCallStack"
        Me.listViewCallStack.ShowItemToolTips = True
        Me.listViewCallStack.Size = New System.Drawing.Size(375, 360)
        Me.listViewCallStack.TabIndex = 9
        Me.listViewCallStack.UseCompatibleStateImageBehavior = False
        Me.listViewCallStack.View = System.Windows.Forms.View.Details
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "TID"
        Me.columnHeader3.Width = 100
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Symbol Name"
        Me.columnHeader4.Width = 220
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 13)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Process ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 20)
        Me.TextBox1.TabIndex = 11
        '
        'buttonWalk
        '
        Me.buttonWalk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonWalk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.buttonWalk.Location = New System.Drawing.Point(312, 6)
        Me.buttonWalk.Name = "buttonWalk"
        Me.buttonWalk.Size = New System.Drawing.Size(75, 23)
        Me.buttonWalk.TabIndex = 12
        Me.buttonWalk.Text = "Get Thrads"
        Me.buttonWalk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 407)
        Me.Controls.Add(Me.buttonWalk)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.listViewCallStack)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listViewCallStack As ListView
    Private WithEvents columnHeader3 As ColumnHeader
    Private WithEvents columnHeader4 As ColumnHeader
    Private WithEvents label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents buttonWalk As Button
End Class
