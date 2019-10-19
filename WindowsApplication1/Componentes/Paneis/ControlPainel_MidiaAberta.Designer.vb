<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPainel_MidiaAberta
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("<Selecione uma mídia>")
        Me.PanelEnvolveMidiaAberta = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.TVFiles = New System.Windows.Forms.TreeView()
        Me.PanelEnvolveMidiaAberta.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEnvolveMidiaAberta
        '
        Me.PanelEnvolveMidiaAberta.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelEnvolveMidiaAberta.Controls.Add(Me.Panel32)
        Me.PanelEnvolveMidiaAberta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEnvolveMidiaAberta.Location = New System.Drawing.Point(0, 256)
        Me.PanelEnvolveMidiaAberta.Name = "PanelEnvolveMidiaAberta"
        Me.PanelEnvolveMidiaAberta.Size = New System.Drawing.Size(381, 248)
        Me.PanelEnvolveMidiaAberta.TabIndex = 18
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel32.Controls.Add(Me.TVFiles)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Panel32.Size = New System.Drawing.Size(381, 248)
        Me.Panel32.TabIndex = 88
        '
        'TVFiles
        '
        Me.TVFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TVFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TVFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVFiles.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVFiles.FullRowSelect = True
        Me.TVFiles.HideSelection = False
        Me.TVFiles.Location = New System.Drawing.Point(0, 0)
        Me.TVFiles.Name = "TVFiles"
        TreeNode1.ImageKey = "CD.ico"
        TreeNode1.Name = "Node1"
        TreeNode1.SelectedImageKey = "CD.ico"
        TreeNode1.Text = "<Selecione uma mídia>"
        Me.TVFiles.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TVFiles.ShowLines = False
        Me.TVFiles.Size = New System.Drawing.Size(381, 246)
        Me.TVFiles.TabIndex = 87
        '
        'UserControl2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEnvolveMidiaAberta)
        Me.Name = "UserControl2"
        Me.Size = New System.Drawing.Size(381, 504)
        Me.PanelEnvolveMidiaAberta.ResumeLayout(False)
        Me.Panel32.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEnvolveMidiaAberta As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents TVFiles As TreeView
End Class
