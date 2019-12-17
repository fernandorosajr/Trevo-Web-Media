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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Incluir Pastas")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Incluir Arquivos")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPainel_Filtro))
        Me.TVWFiltro = New System.Windows.Forms.TreeView()
        Me.Panel_Border = New System.Windows.Forms.Panel()
        Me.Panel_Explorer_Prima = New System.Windows.Forms.Panel()
        Me.Panel_ExplorarPorFiltro = New System.Windows.Forms.Panel()
        Me.PanelTXTFiltrar = New System.Windows.Forms.Panel()
        Me.PanelBorder_TXTFiltrar = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_TXTFiltrar = New System.Windows.Forms.Panel()
        Me.TXTFiltrar = New System.Windows.Forms.TextBox()
        Me.BTN_TXTFiltrar = New System.Windows.Forms.Button()
        Me.Panel_LBLTitle = New System.Windows.Forms.Panel()
        Me.LBLTitle = New System.Windows.Forms.Label()
        Me.BTNLBLTitle = New System.Windows.Forms.Button()
        Me.Panel_Filtro = New System.Windows.Forms.Panel()
        Me.PanelMargin = New System.Windows.Forms.Panel()
        Me.Panel_Border.SuspendLayout()
        Me.Panel_Explorer_Prima.SuspendLayout()
        Me.Panel_ExplorarPorFiltro.SuspendLayout()
        Me.PanelTXTFiltrar.SuspendLayout()
        Me.PanelBorder_TXTFiltrar.SuspendLayout()
        Me.PanelEnvolve_TXTFiltrar.SuspendLayout()
        Me.Panel_LBLTitle.SuspendLayout()
        Me.Panel_Filtro.SuspendLayout()
        Me.PanelMargin.SuspendLayout()
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
        TreeNode1.Checked = True
        TreeNode1.ImageKey = "Pasta.ico"
        TreeNode1.Name = "Node2"
        TreeNode1.SelectedImageKey = "Pasta.ico"
        TreeNode1.Text = "Incluir Pastas"
        TreeNode2.Checked = True
        TreeNode2.ImageKey = "arquivo.ico"
        TreeNode2.Name = "Node1"
        TreeNode2.SelectedImageKey = "arquivo.ico"
        TreeNode2.Text = "Incluir Arquivos"
        Me.TVWFiltro.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.TVWFiltro.ShowLines = False
        Me.TVWFiltro.Size = New System.Drawing.Size(316, 232)
        Me.TVWFiltro.TabIndex = 2
        '
        'Panel_Border
        '
        Me.Panel_Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel_Border.Controls.Add(Me.Panel_Explorer_Prima)
        Me.Panel_Border.Controls.Add(Me.Panel_LBLTitle)
        Me.Panel_Border.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Border.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Border.Name = "Panel_Border"
        Me.Panel_Border.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel_Border.Size = New System.Drawing.Size(324, 295)
        Me.Panel_Border.TabIndex = 2
        '
        'Panel_Explorer_Prima
        '
        Me.Panel_Explorer_Prima.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel_Explorer_Prima.Controls.Add(Me.Panel_ExplorarPorFiltro)
        Me.Panel_Explorer_Prima.Controls.Add(Me.PanelTXTFiltrar)
        Me.Panel_Explorer_Prima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Explorer_Prima.Location = New System.Drawing.Point(1, 30)
        Me.Panel_Explorer_Prima.Name = "Panel_Explorer_Prima"
        Me.Panel_Explorer_Prima.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Panel_Explorer_Prima.Size = New System.Drawing.Size(322, 264)
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
        Me.Panel_ExplorarPorFiltro.Size = New System.Drawing.Size(322, 238)
        Me.Panel_ExplorarPorFiltro.TabIndex = 1
        '
        'PanelTXTFiltrar
        '
        Me.PanelTXTFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelTXTFiltrar.Controls.Add(Me.PanelBorder_TXTFiltrar)
        Me.PanelTXTFiltrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTXTFiltrar.Location = New System.Drawing.Point(0, 1)
        Me.PanelTXTFiltrar.Name = "PanelTXTFiltrar"
        Me.PanelTXTFiltrar.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelTXTFiltrar.Size = New System.Drawing.Size(322, 25)
        Me.PanelTXTFiltrar.TabIndex = 4
        '
        'PanelBorder_TXTFiltrar
        '
        Me.PanelBorder_TXTFiltrar.BackColor = System.Drawing.Color.DimGray
        Me.PanelBorder_TXTFiltrar.Controls.Add(Me.PanelEnvolve_TXTFiltrar)
        Me.PanelBorder_TXTFiltrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder_TXTFiltrar.Location = New System.Drawing.Point(3, 3)
        Me.PanelBorder_TXTFiltrar.Name = "PanelBorder_TXTFiltrar"
        Me.PanelBorder_TXTFiltrar.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_TXTFiltrar.Size = New System.Drawing.Size(316, 19)
        Me.PanelBorder_TXTFiltrar.TabIndex = 19
        '
        'PanelEnvolve_TXTFiltrar
        '
        Me.PanelEnvolve_TXTFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelEnvolve_TXTFiltrar.Controls.Add(Me.TXTFiltrar)
        Me.PanelEnvolve_TXTFiltrar.Controls.Add(Me.BTN_TXTFiltrar)
        Me.PanelEnvolve_TXTFiltrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TXTFiltrar.Location = New System.Drawing.Point(1, 1)
        Me.PanelEnvolve_TXTFiltrar.Name = "PanelEnvolve_TXTFiltrar"
        Me.PanelEnvolve_TXTFiltrar.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelEnvolve_TXTFiltrar.Size = New System.Drawing.Size(314, 17)
        Me.PanelEnvolve_TXTFiltrar.TabIndex = 93
        '
        'TXTFiltrar
        '
        Me.TXTFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTFiltrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTFiltrar.ForeColor = System.Drawing.Color.Gray
        Me.TXTFiltrar.Location = New System.Drawing.Point(3, 3)
        Me.TXTFiltrar.Name = "TXTFiltrar"
        Me.TXTFiltrar.Size = New System.Drawing.Size(293, 13)
        Me.TXTFiltrar.TabIndex = 9
        Me.TXTFiltrar.Text = "    Filtrar"
        '
        'BTN_TXTFiltrar
        '
        Me.BTN_TXTFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_TXTFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_TXTFiltrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_TXTFiltrar.FlatAppearance.BorderSize = 0
        Me.BTN_TXTFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BTN_TXTFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_TXTFiltrar.Image = Global.TrevoWebMedia.My.Resources.Resources.localizar1
        Me.BTN_TXTFiltrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_TXTFiltrar.Location = New System.Drawing.Point(296, 3)
        Me.BTN_TXTFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_TXTFiltrar.Name = "BTN_TXTFiltrar"
        Me.BTN_TXTFiltrar.Size = New System.Drawing.Size(15, 11)
        Me.BTN_TXTFiltrar.TabIndex = 18
        Me.BTN_TXTFiltrar.UseVisualStyleBackColor = False
        '
        'Panel_LBLTitle
        '
        Me.Panel_LBLTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel_LBLTitle.Controls.Add(Me.LBLTitle)
        Me.Panel_LBLTitle.Controls.Add(Me.BTNLBLTitle)
        Me.Panel_LBLTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_LBLTitle.Location = New System.Drawing.Point(1, 1)
        Me.Panel_LBLTitle.Name = "Panel_LBLTitle"
        Me.Panel_LBLTitle.Size = New System.Drawing.Size(322, 29)
        Me.Panel_LBLTitle.TabIndex = 5
        '
        'LBLTitle
        '
        Me.LBLTitle.BackColor = System.Drawing.Color.Transparent
        Me.LBLTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBLTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LBLTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.LBLTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBLTitle.Location = New System.Drawing.Point(15, 0)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Padding = New System.Windows.Forms.Padding(5)
        Me.LBLTitle.Size = New System.Drawing.Size(307, 29)
        Me.LBLTitle.TabIndex = 1
        Me.LBLTitle.Text = "Filtro"
        '
        'BTNLBLTitle
        '
        Me.BTNLBLTitle.BackColor = System.Drawing.Color.Transparent
        Me.BTNLBLTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNLBLTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNLBLTitle.FlatAppearance.BorderSize = 0
        Me.BTNLBLTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLBLTitle.Image = CType(resources.GetObject("BTNLBLTitle.Image"), System.Drawing.Image)
        Me.BTNLBLTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNLBLTitle.Location = New System.Drawing.Point(0, 0)
        Me.BTNLBLTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNLBLTitle.Name = "BTNLBLTitle"
        Me.BTNLBLTitle.Size = New System.Drawing.Size(15, 29)
        Me.BTNLBLTitle.TabIndex = 22
        Me.BTNLBLTitle.UseVisualStyleBackColor = False
        '
        'Panel_Filtro
        '
        Me.Panel_Filtro.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel_Filtro.Controls.Add(Me.PanelMargin)
        Me.Panel_Filtro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Filtro.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Filtro.Name = "Panel_Filtro"
        Me.Panel_Filtro.Size = New System.Drawing.Size(324, 295)
        Me.Panel_Filtro.TabIndex = 3
        '
        'PanelMargin
        '
        Me.PanelMargin.Controls.Add(Me.Panel_Border)
        Me.PanelMargin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMargin.Location = New System.Drawing.Point(0, 0)
        Me.PanelMargin.Name = "PanelMargin"
        Me.PanelMargin.Size = New System.Drawing.Size(324, 295)
        Me.PanelMargin.TabIndex = 3
        '
        'ControlPainel_Filtro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel_Filtro)
        Me.Name = "ControlPainel_Filtro"
        Me.Size = New System.Drawing.Size(324, 295)
        Me.Panel_Border.ResumeLayout(False)
        Me.Panel_Explorer_Prima.ResumeLayout(False)
        Me.Panel_ExplorarPorFiltro.ResumeLayout(False)
        Me.PanelTXTFiltrar.ResumeLayout(False)
        Me.PanelBorder_TXTFiltrar.ResumeLayout(False)
        Me.PanelEnvolve_TXTFiltrar.ResumeLayout(False)
        Me.PanelEnvolve_TXTFiltrar.PerformLayout()
        Me.Panel_LBLTitle.ResumeLayout(False)
        Me.Panel_Filtro.ResumeLayout(False)
        Me.PanelMargin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TVWFiltro As TreeView
    Friend WithEvents Panel_Border As Panel
    Friend WithEvents Panel_Explorer_Prima As Panel
    Friend WithEvents Panel_ExplorarPorFiltro As Panel
    Friend WithEvents PanelTXTFiltrar As Panel
    Friend WithEvents PanelEnvolve_TXTFiltrar As Panel
    Friend WithEvents TXTFiltrar As TextBox
    Friend WithEvents BTN_TXTFiltrar As Button
    Friend WithEvents Panel_LBLTitle As Panel
    Friend WithEvents LBLTitle As Label
    Friend WithEvents BTNLBLTitle As Button
    Friend WithEvents Panel_Filtro As Panel
    Friend WithEvents PanelMargin As Panel
    Friend WithEvents PanelBorder_TXTFiltrar As Panel
End Class
