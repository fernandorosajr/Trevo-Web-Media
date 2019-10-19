<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPainel_PastaIsolada
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1.exe")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pasta", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Arquivo.txt")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pasta isolada 02", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Me.PanelTeste = New System.Windows.Forms.Panel()
        Me.PanelModo_Isolamento = New System.Windows.Forms.Panel()
        Me.TreeView4 = New System.Windows.Forms.TreeView()
        Me.Panel276 = New System.Windows.Forms.Panel()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.RB_Fechar_Modo_Isolamento = New System.Windows.Forms.RadioButton()
        Me.RB_Modo_Isolamento = New System.Windows.Forms.RadioButton()
        Me.PanelToolBar = New System.Windows.Forms.Panel()
        Me.PanelTeste.SuspendLayout()
        Me.PanelModo_Isolamento.SuspendLayout()
        Me.Panel276.SuspendLayout()
        Me.Panel41.SuspendLayout()
        Me.PanelToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTeste
        '
        Me.PanelTeste.Controls.Add(Me.PanelModo_Isolamento)
        Me.PanelTeste.Controls.Add(Me.PanelToolBar)
        Me.PanelTeste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTeste.Location = New System.Drawing.Point(0, 0)
        Me.PanelTeste.Name = "PanelTeste"
        Me.PanelTeste.Size = New System.Drawing.Size(304, 452)
        Me.PanelTeste.TabIndex = 1
        '
        'PanelModo_Isolamento
        '
        Me.PanelModo_Isolamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PanelModo_Isolamento.Controls.Add(Me.Panel276)
        Me.PanelModo_Isolamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelModo_Isolamento.Location = New System.Drawing.Point(0, 34)
        Me.PanelModo_Isolamento.Name = "PanelModo_Isolamento"
        Me.PanelModo_Isolamento.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelModo_Isolamento.Size = New System.Drawing.Size(304, 418)
        Me.PanelModo_Isolamento.TabIndex = 20
        Me.PanelModo_Isolamento.Visible = False
        '
        'TreeView4
        '
        Me.TreeView4.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TreeView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView4.ForeColor = System.Drawing.Color.Gainsboro
        Me.TreeView4.FullRowSelect = True
        Me.TreeView4.HideSelection = False
        Me.TreeView4.Location = New System.Drawing.Point(4, 4)
        Me.TreeView4.Name = "TreeView4"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Node1.exe"
        TreeNode2.Name = "Computador"
        TreeNode2.Text = "Pasta"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "Arquivo.txt"
        TreeNode4.ImageKey = "Desktop.ico"
        TreeNode4.Name = "Desktop"
        TreeNode4.SelectedImageKey = "Desktop.ico"
        TreeNode4.Text = "Pasta isolada 02"
        Me.TreeView4.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.TreeView4.ShowLines = False
        Me.TreeView4.Size = New System.Drawing.Size(292, 406)
        Me.TreeView4.TabIndex = 2
        '
        'Panel276
        '
        Me.Panel276.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel276.Controls.Add(Me.TreeView4)
        Me.Panel276.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel276.Location = New System.Drawing.Point(2, 2)
        Me.Panel276.Name = "Panel276"
        Me.Panel276.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel276.Size = New System.Drawing.Size(300, 414)
        Me.Panel276.TabIndex = 6
        '
        'Panel41
        '
        Me.Panel41.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel41.Controls.Add(Me.RB_Modo_Isolamento)
        Me.Panel41.Controls.Add(Me.RB_Fechar_Modo_Isolamento)
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel41.Location = New System.Drawing.Point(0, 0)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Panel41.Size = New System.Drawing.Size(304, 31)
        Me.Panel41.TabIndex = 5
        '
        'RB_Fechar_Modo_Isolamento
        '
        Me.RB_Fechar_Modo_Isolamento.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Fechar_Modo_Isolamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.RB_Fechar_Modo_Isolamento.Dock = System.Windows.Forms.DockStyle.Right
        Me.RB_Fechar_Modo_Isolamento.FlatAppearance.BorderSize = 0
        Me.RB_Fechar_Modo_Isolamento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.RB_Fechar_Modo_Isolamento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.RB_Fechar_Modo_Isolamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Fechar_Modo_Isolamento.ForeColor = System.Drawing.Color.Gainsboro
        Me.RB_Fechar_Modo_Isolamento.Image = Global.TrevoWebMedia.My.Resources.Resources.fechar_branco
        Me.RB_Fechar_Modo_Isolamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RB_Fechar_Modo_Isolamento.Location = New System.Drawing.Point(279, 5)
        Me.RB_Fechar_Modo_Isolamento.Name = "RB_Fechar_Modo_Isolamento"
        Me.RB_Fechar_Modo_Isolamento.Size = New System.Drawing.Size(20, 26)
        Me.RB_Fechar_Modo_Isolamento.TabIndex = 6
        Me.RB_Fechar_Modo_Isolamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RB_Fechar_Modo_Isolamento.UseVisualStyleBackColor = False
        Me.RB_Fechar_Modo_Isolamento.Visible = False
        '
        'RB_Modo_Isolamento
        '
        Me.RB_Modo_Isolamento.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Modo_Isolamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.RB_Modo_Isolamento.Checked = True
        Me.RB_Modo_Isolamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RB_Modo_Isolamento.FlatAppearance.BorderSize = 0
        Me.RB_Modo_Isolamento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.RB_Modo_Isolamento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.RB_Modo_Isolamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Modo_Isolamento.ForeColor = System.Drawing.Color.Gainsboro
        Me.RB_Modo_Isolamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RB_Modo_Isolamento.Location = New System.Drawing.Point(5, 5)
        Me.RB_Modo_Isolamento.Name = "RB_Modo_Isolamento"
        Me.RB_Modo_Isolamento.Size = New System.Drawing.Size(274, 26)
        Me.RB_Modo_Isolamento.TabIndex = 5
        Me.RB_Modo_Isolamento.TabStop = True
        Me.RB_Modo_Isolamento.Text = "Modo isolamento"
        Me.RB_Modo_Isolamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RB_Modo_Isolamento.UseVisualStyleBackColor = False
        Me.RB_Modo_Isolamento.Visible = False
        '
        'PanelToolBar
        '
        Me.PanelToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PanelToolBar.Controls.Add(Me.Panel41)
        Me.PanelToolBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelToolBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelToolBar.Name = "PanelToolBar"
        Me.PanelToolBar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.PanelToolBar.Size = New System.Drawing.Size(304, 34)
        Me.PanelToolBar.TabIndex = 4
        '
        'PainelPastaIsolada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelTeste)
        Me.Name = "PainelPastaIsolada"
        Me.Size = New System.Drawing.Size(304, 452)
        Me.PanelTeste.ResumeLayout(False)
        Me.PanelModo_Isolamento.ResumeLayout(False)
        Me.Panel276.ResumeLayout(False)
        Me.Panel41.ResumeLayout(False)
        Me.PanelToolBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTeste As Panel
    Friend WithEvents PanelModo_Isolamento As Panel
    Friend WithEvents Panel276 As Panel
    Friend WithEvents TreeView4 As TreeView
    Friend WithEvents PanelToolBar As Panel
    Friend WithEvents Panel41 As Panel
    Friend WithEvents RB_Modo_Isolamento As RadioButton
    Friend WithEvents RB_Fechar_Modo_Isolamento As RadioButton
End Class
