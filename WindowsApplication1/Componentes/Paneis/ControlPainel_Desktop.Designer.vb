<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPainel_Desktop
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Computador")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Desktop", New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeView10 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView10
        '
        Me.TreeView10.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TreeView10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView10.ForeColor = System.Drawing.Color.Gainsboro
        Me.TreeView10.FullRowSelect = True
        Me.TreeView10.HideSelection = False
        Me.TreeView10.Location = New System.Drawing.Point(0, 0)
        Me.TreeView10.Name = "TreeView10"
        TreeNode1.Name = "Computador"
        TreeNode1.Text = "Computador"
        TreeNode2.ImageKey = "Desktop.ico"
        TreeNode2.Name = "Desktop"
        TreeNode2.SelectedImageKey = "Desktop.ico"
        TreeNode2.Text = "Desktop"
        Me.TreeView10.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.TreeView10.ShowLines = False
        Me.TreeView10.Size = New System.Drawing.Size(322, 455)
        Me.TreeView10.TabIndex = 3
        '
        'UserControl2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TreeView10)
        Me.Name = "UserControl2"
        Me.Size = New System.Drawing.Size(322, 455)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView10 As TreeView
End Class
