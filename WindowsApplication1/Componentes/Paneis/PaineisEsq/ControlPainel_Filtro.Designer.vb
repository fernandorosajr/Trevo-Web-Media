<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPainel_Filtro
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Incluir Pastas")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Incluir Arquivos")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPainel_Filtro))
        Me.TVWFiltro = New System.Windows.Forms.TreeView()
        Me.Panel_Filtro = New System.Windows.Forms.Panel()
        Me.Panel_Explorer_Prima = New System.Windows.Forms.Panel()
        Me.Panel_ExplorarPorFiltro = New System.Windows.Forms.Panel()
        Me.Panel195 = New System.Windows.Forms.Panel()
        Me.Panel277 = New System.Windows.Forms.Panel()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.Button124 = New System.Windows.Forms.Button()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Button121 = New System.Windows.Forms.Button()
        Me.Panel_Filtro.SuspendLayout()
        Me.Panel_Explorer_Prima.SuspendLayout()
        Me.Panel_ExplorarPorFiltro.SuspendLayout()
        Me.Panel195.SuspendLayout()
        Me.Panel277.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVWFiltro
        '
        Me.TVWFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TVWFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVWFiltro.CheckBoxes = True
        Me.TVWFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVWFiltro.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVWFiltro.FullRowSelect = True
        Me.TVWFiltro.Location = New System.Drawing.Point(3, 3)
        Me.TVWFiltro.Name = "TVWFiltro"
        TreeNode7.Checked = True
        TreeNode7.ImageKey = "Pasta.ico"
        TreeNode7.Name = "Node2"
        TreeNode7.SelectedImageKey = "Pasta.ico"
        TreeNode7.Text = "Incluir Pastas"
        TreeNode8.Checked = True
        TreeNode8.ImageKey = "arquivo.ico"
        TreeNode8.Name = "Node1"
        TreeNode8.SelectedImageKey = "arquivo.ico"
        TreeNode8.Text = "Incluir Arquivos"
        Me.TVWFiltro.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Me.TVWFiltro.ShowLines = False
        Me.TVWFiltro.Size = New System.Drawing.Size(318, 234)
        Me.TVWFiltro.TabIndex = 2
        '
        'Panel_Filtro
        '
        Me.Panel_Filtro.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel_Filtro.Controls.Add(Me.Panel_Explorer_Prima)
        Me.Panel_Filtro.Controls.Add(Me.Panel34)
        Me.Panel_Filtro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Filtro.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Filtro.Name = "Panel_Filtro"
        Me.Panel_Filtro.Size = New System.Drawing.Size(324, 295)
        Me.Panel_Filtro.TabIndex = 2
        '
        'Panel_Explorer_Prima
        '
        Me.Panel_Explorer_Prima.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel_Explorer_Prima.Controls.Add(Me.Panel_ExplorarPorFiltro)
        Me.Panel_Explorer_Prima.Controls.Add(Me.Panel195)
        Me.Panel_Explorer_Prima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Explorer_Prima.Location = New System.Drawing.Point(0, 29)
        Me.Panel_Explorer_Prima.Name = "Panel_Explorer_Prima"
        Me.Panel_Explorer_Prima.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Panel_Explorer_Prima.Size = New System.Drawing.Size(324, 266)
        Me.Panel_Explorer_Prima.TabIndex = 4
        '
        'Panel_ExplorarPorFiltro
        '
        Me.Panel_ExplorarPorFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel_ExplorarPorFiltro.Controls.Add(Me.TVWFiltro)
        Me.Panel_ExplorarPorFiltro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ExplorarPorFiltro.Location = New System.Drawing.Point(0, 26)
        Me.Panel_ExplorarPorFiltro.Name = "Panel_ExplorarPorFiltro"
        Me.Panel_ExplorarPorFiltro.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel_ExplorarPorFiltro.Size = New System.Drawing.Size(324, 240)
        Me.Panel_ExplorarPorFiltro.TabIndex = 1
        '
        'Panel195
        '
        Me.Panel195.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel195.Controls.Add(Me.Panel277)
        Me.Panel195.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel195.Location = New System.Drawing.Point(0, 1)
        Me.Panel195.Name = "Panel195"
        Me.Panel195.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel195.Size = New System.Drawing.Size(324, 25)
        Me.Panel195.TabIndex = 4
        '
        'Panel277
        '
        Me.Panel277.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel277.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel277.Controls.Add(Me.TextBox26)
        Me.Panel277.Controls.Add(Me.Button124)
        Me.Panel277.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel277.Location = New System.Drawing.Point(3, 3)
        Me.Panel277.Name = "Panel277"
        Me.Panel277.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel277.Size = New System.Drawing.Size(318, 19)
        Me.Panel277.TabIndex = 93
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox26.ForeColor = System.Drawing.Color.Gray
        Me.TextBox26.Location = New System.Drawing.Point(3, 3)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(295, 13)
        Me.TextBox26.TabIndex = 9
        Me.TextBox26.Text = "    Filtrar"
        '
        'Button124
        '
        Me.Button124.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button124.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button124.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button124.FlatAppearance.BorderSize = 0
        Me.Button124.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button124.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button124.Image = Global.TrevoWebMedia.My.Resources.Resources.localizar1
        Me.Button124.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button124.Location = New System.Drawing.Point(298, 3)
        Me.Button124.Margin = New System.Windows.Forms.Padding(0)
        Me.Button124.Name = "Button124"
        Me.Button124.Size = New System.Drawing.Size(15, 11)
        Me.Button124.TabIndex = 18
        Me.Button124.UseVisualStyleBackColor = False
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel34.Controls.Add(Me.Label105)
        Me.Panel34.Controls.Add(Me.Button121)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel34.Location = New System.Drawing.Point(0, 0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(324, 29)
        Me.Panel34.TabIndex = 5
        '
        'Label105
        '
        Me.Label105.BackColor = System.Drawing.Color.Transparent
        Me.Label105.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label105.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label105.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label105.Location = New System.Drawing.Point(15, 0)
        Me.Label105.Name = "Label105"
        Me.Label105.Padding = New System.Windows.Forms.Padding(5)
        Me.Label105.Size = New System.Drawing.Size(309, 29)
        Me.Label105.TabIndex = 1
        Me.Label105.Text = "Filtro"
        '
        'Button121
        '
        Me.Button121.BackColor = System.Drawing.Color.Transparent
        Me.Button121.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button121.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button121.FlatAppearance.BorderSize = 0
        Me.Button121.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button121.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button121.Image = CType(resources.GetObject("Button121.Image"), System.Drawing.Image)
        Me.Button121.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button121.Location = New System.Drawing.Point(0, 0)
        Me.Button121.Margin = New System.Windows.Forms.Padding(0)
        Me.Button121.Name = "Button121"
        Me.Button121.Size = New System.Drawing.Size(15, 29)
        Me.Button121.TabIndex = 22
        Me.Button121.UseVisualStyleBackColor = False
        '
        'ControlPainel_Filtro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel_Filtro)
        Me.Name = "ControlPainel_Filtro"
        Me.Size = New System.Drawing.Size(324, 295)
        Me.Panel_Filtro.ResumeLayout(False)
        Me.Panel_Explorer_Prima.ResumeLayout(False)
        Me.Panel_ExplorarPorFiltro.ResumeLayout(False)
        Me.Panel195.ResumeLayout(False)
        Me.Panel277.ResumeLayout(False)
        Me.Panel277.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TVWFiltro As TreeView
    Friend WithEvents Panel_Filtro As Panel
    Friend WithEvents Panel_Explorer_Prima As Panel
    Friend WithEvents Panel_ExplorarPorFiltro As Panel
    Friend WithEvents Panel195 As Panel
    Friend WithEvents Panel277 As Panel
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents Button124 As Button
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Label105 As Label
    Friend WithEvents Button121 As Button
End Class
