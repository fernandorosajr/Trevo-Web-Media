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
        Me.TVWDesktop = New System.Windows.Forms.TreeView()
        Me.PanelBorder_TVWDesktop = New System.Windows.Forms.Panel()
        Me.PanelBorder_TVWDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVWDesktop
        '
        Me.TVWDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TVWDesktop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVWDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVWDesktop.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVWDesktop.FullRowSelect = True
        Me.TVWDesktop.HideSelection = False
        Me.TVWDesktop.Location = New System.Drawing.Point(1, 1)
        Me.TVWDesktop.Name = "TVWDesktop"
        TreeNode1.Name = "Computador"
        TreeNode1.Text = "Computador"
        TreeNode2.ImageKey = "Desktop.ico"
        TreeNode2.Name = "Desktop"
        TreeNode2.SelectedImageKey = "Desktop.ico"
        TreeNode2.Text = "Desktop"
        Me.TVWDesktop.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.TVWDesktop.ShowLines = False
        Me.TVWDesktop.Size = New System.Drawing.Size(320, 453)
        Me.TVWDesktop.TabIndex = 3
        '
        'PanelBorder_TVWDesktop
        '
        Me.PanelBorder_TVWDesktop.BackColor = System.Drawing.Color.DimGray
        Me.PanelBorder_TVWDesktop.Controls.Add(Me.TVWDesktop)
        Me.PanelBorder_TVWDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder_TVWDesktop.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder_TVWDesktop.Name = "PanelBorder_TVWDesktop"
        Me.PanelBorder_TVWDesktop.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_TVWDesktop.Size = New System.Drawing.Size(322, 455)
        Me.PanelBorder_TVWDesktop.TabIndex = 4
        '
        'ControlPainel_Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelBorder_TVWDesktop)
        Me.Name = "ControlPainel_Desktop"
        Me.Size = New System.Drawing.Size(322, 455)
        Me.PanelBorder_TVWDesktop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TVWDesktop As TreeView
    Friend WithEvents PanelBorder_TVWDesktop As Panel
End Class
