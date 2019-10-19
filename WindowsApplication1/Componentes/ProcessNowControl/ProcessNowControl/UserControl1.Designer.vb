<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Área de Trabalho")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Computador", New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelListaProcessoAgendado = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelExecutarProcesso = New System.Windows.Forms.Panel()
        Me.Panel90 = New System.Windows.Forms.Panel()
        Me.Button41 = New System.Windows.Forms.Button()
        Me.Panel89 = New System.Windows.Forms.Panel()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel76 = New System.Windows.Forms.Panel()
        Me.PanelMidia = New System.Windows.Forms.Panel()
        Me.RadioButton69 = New System.Windows.Forms.RadioButton()
        Me.RadioButton72 = New System.Windows.Forms.RadioButton()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.PanelEnvolveMidiaAberta = New System.Windows.Forms.Panel()
        Me.TVFiles = New System.Windows.Forms.TreeView()
        Me.PanelListaProcessoAgendado.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelExecutarProcesso.SuspendLayout()
        Me.Panel90.SuspendLayout()
        Me.Panel89.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel76.SuspendLayout()
        Me.PanelMidia.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.PanelEnvolveMidiaAberta.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "grupo02.png")
        Me.ImageList1.Images.SetKeyName(1, "grupo01.png")
        Me.ImageList1.Images.SetKeyName(2, "pasta")
        Me.ImageList1.Images.SetKeyName(3, "imageres_4.ico")
        Me.ImageList1.Images.SetKeyName(4, "imageres_19.ico")
        Me.ImageList1.Images.SetKeyName(5, "imageres_32.ico")
        Me.ImageList1.Images.SetKeyName(6, "imageres_60.ico")
        Me.ImageList1.Images.SetKeyName(7, "imageres_62.ico")
        Me.ImageList1.Images.SetKeyName(8, "imageres_63.ico")
        Me.ImageList1.Images.SetKeyName(9, "imageres_64.ico")
        Me.ImageList1.Images.SetKeyName(10, "imageres_81.ico")
        Me.ImageList1.Images.SetKeyName(11, "imageres_108.ico")
        Me.ImageList1.Images.SetKeyName(12, "imageres_112.ico")
        Me.ImageList1.Images.SetKeyName(13, "imageres_113.ico")
        Me.ImageList1.Images.SetKeyName(14, "imageres_141.ico")
        Me.ImageList1.Images.SetKeyName(15, "imageres_142.ico")
        Me.ImageList1.Images.SetKeyName(16, "imageres_155.ico")
        Me.ImageList1.Images.SetKeyName(17, "imageres_162.ico")
        Me.ImageList1.Images.SetKeyName(18, "shell32_264.ico")
        Me.ImageList1.Images.SetKeyName(19, "processo.ico")
        Me.ImageList1.Images.SetKeyName(20, "novoarq.ico")
        Me.ImageList1.Images.SetKeyName(21, "copypara.png")
        Me.ImageList1.Images.SetKeyName(22, "renomear.png")
        Me.ImageList1.Images.SetKeyName(23, "movepara.png")
        Me.ImageList1.Images.SetKeyName(24, "excluir.png")
        Me.ImageList1.Images.SetKeyName(25, "pasta raiz.png")
        '
        'PanelListaProcessoAgendado
        '
        Me.PanelListaProcessoAgendado.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PanelListaProcessoAgendado.Controls.Add(Me.Panel2)
        Me.PanelListaProcessoAgendado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelListaProcessoAgendado.Location = New System.Drawing.Point(0, 268)
        Me.PanelListaProcessoAgendado.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelListaProcessoAgendado.Name = "PanelListaProcessoAgendado"
        Me.PanelListaProcessoAgendado.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelListaProcessoAgendado.Size = New System.Drawing.Size(324, 60)
        Me.PanelListaProcessoAgendado.TabIndex = 101
        Me.PanelListaProcessoAgendado.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(322, 58)
        Me.Panel2.TabIndex = 101
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(6, 3, 1, 3)
        Me.Panel5.Size = New System.Drawing.Size(34, 56)
        Me.Panel5.TabIndex = 102
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(6, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 50)
        Me.Button4.TabIndex = 98
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(291, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel3.Size = New System.Drawing.Size(30, 56)
        Me.Panel3.TabIndex = 106
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(1, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.Button2.Size = New System.Drawing.Size(28, 50)
        Me.Button2.TabIndex = 98
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(35, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.Panel4.Size = New System.Drawing.Size(256, 56)
        Me.Panel4.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 21)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Processo agendado para ####"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 15)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Processo agendado para ####"
        '
        'PanelExecutarProcesso
        '
        Me.PanelExecutarProcesso.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PanelExecutarProcesso.Controls.Add(Me.Panel1)
        Me.PanelExecutarProcesso.Controls.Add(Me.Panel89)
        Me.PanelExecutarProcesso.Controls.Add(Me.Panel90)
        Me.PanelExecutarProcesso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelExecutarProcesso.Location = New System.Drawing.Point(0, 238)
        Me.PanelExecutarProcesso.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelExecutarProcesso.Name = "PanelExecutarProcesso"
        Me.PanelExecutarProcesso.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.PanelExecutarProcesso.Size = New System.Drawing.Size(324, 30)
        Me.PanelExecutarProcesso.TabIndex = 99
        '
        'Panel90
        '
        Me.Panel90.Controls.Add(Me.Button41)
        Me.Panel90.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel90.Location = New System.Drawing.Point(6, 2)
        Me.Panel90.Name = "Panel90"
        Me.Panel90.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel90.Size = New System.Drawing.Size(30, 26)
        Me.Panel90.TabIndex = 102
        '
        'Button41
        '
        Me.Button41.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button41.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button41.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button41.FlatAppearance.BorderSize = 0
        Me.Button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button41.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button41.Image = CType(resources.GetObject("Button41.Image"), System.Drawing.Image)
        Me.Button41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button41.Location = New System.Drawing.Point(1, 3)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(28, 20)
        Me.Button41.TabIndex = 98
        Me.Button41.UseVisualStyleBackColor = False
        '
        'Panel89
        '
        Me.Panel89.Controls.Add(Me.Button14)
        Me.Panel89.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel89.Location = New System.Drawing.Point(36, 2)
        Me.Panel89.Name = "Panel89"
        Me.Panel89.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel89.Size = New System.Drawing.Size(30, 26)
        Me.Panel89.TabIndex = 105
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button14.Location = New System.Drawing.Point(1, 3)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(28, 20)
        Me.Button14.TabIndex = 98
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(66, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel1.Size = New System.Drawing.Size(30, 26)
        Me.Panel1.TabIndex = 106
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(1, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 20)
        Me.Button1.TabIndex = 98
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel76
        '
        Me.Panel76.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel76.Controls.Add(Me.PanelMidia)
        Me.Panel76.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel76.Location = New System.Drawing.Point(0, 0)
        Me.Panel76.Name = "Panel76"
        Me.Panel76.Padding = New System.Windows.Forms.Padding(3, 1, 3, 0)
        Me.Panel76.Size = New System.Drawing.Size(324, 21)
        Me.Panel76.TabIndex = 89
        '
        'PanelMidia
        '
        Me.PanelMidia.Controls.Add(Me.RadioButton72)
        Me.PanelMidia.Controls.Add(Me.RadioButton69)
        Me.PanelMidia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMidia.Location = New System.Drawing.Point(3, 1)
        Me.PanelMidia.Name = "PanelMidia"
        Me.PanelMidia.Size = New System.Drawing.Size(318, 20)
        Me.PanelMidia.TabIndex = 95
        '
        'RadioButton69
        '
        Me.RadioButton69.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton69.Checked = True
        Me.RadioButton69.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadioButton69.FlatAppearance.BorderSize = 0
        Me.RadioButton69.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.RadioButton69.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton69.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton69.ForeColor = System.Drawing.Color.Silver
        Me.RadioButton69.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton69.Location = New System.Drawing.Point(0, 0)
        Me.RadioButton69.Name = "RadioButton69"
        Me.RadioButton69.Size = New System.Drawing.Size(83, 20)
        Me.RadioButton69.TabIndex = 17
        Me.RadioButton69.TabStop = True
        Me.RadioButton69.Text = "Copiar"
        Me.RadioButton69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton69.UseVisualStyleBackColor = True
        '
        'RadioButton72
        '
        Me.RadioButton72.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton72.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadioButton72.FlatAppearance.BorderSize = 0
        Me.RadioButton72.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.RadioButton72.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton72.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton72.ForeColor = System.Drawing.Color.Silver
        Me.RadioButton72.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton72.Location = New System.Drawing.Point(83, 0)
        Me.RadioButton72.Name = "RadioButton72"
        Me.RadioButton72.Size = New System.Drawing.Size(83, 20)
        Me.RadioButton72.TabIndex = 22
        Me.RadioButton72.Text = "Mover"
        Me.RadioButton72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton72.UseVisualStyleBackColor = True
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel32.Controls.Add(Me.TVFiles)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel32.Location = New System.Drawing.Point(0, 21)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel32.Size = New System.Drawing.Size(324, 217)
        Me.Panel32.TabIndex = 88
        '
        'PanelEnvolveMidiaAberta
        '
        Me.PanelEnvolveMidiaAberta.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelEnvolveMidiaAberta.Controls.Add(Me.Panel32)
        Me.PanelEnvolveMidiaAberta.Controls.Add(Me.Panel76)
        Me.PanelEnvolveMidiaAberta.Controls.Add(Me.PanelExecutarProcesso)
        Me.PanelEnvolveMidiaAberta.Controls.Add(Me.PanelListaProcessoAgendado)
        Me.PanelEnvolveMidiaAberta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolveMidiaAberta.Location = New System.Drawing.Point(0, 0)
        Me.PanelEnvolveMidiaAberta.Name = "PanelEnvolveMidiaAberta"
        Me.PanelEnvolveMidiaAberta.Size = New System.Drawing.Size(324, 328)
        Me.PanelEnvolveMidiaAberta.TabIndex = 18
        '
        'TVFiles
        '
        Me.TVFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TVFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TVFiles.CheckBoxes = True
        Me.TVFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVFiles.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVFiles.FullRowSelect = True
        Me.TVFiles.HideSelection = False
        Me.TVFiles.ImageIndex = 2
        Me.TVFiles.ImageList = Me.ImageList1
        Me.TVFiles.Location = New System.Drawing.Point(2, 2)
        Me.TVFiles.Name = "TVFiles"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Área de Trabalho"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "Computador"
        Me.TVFiles.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.TVFiles.SelectedImageIndex = 0
        Me.TVFiles.ShowLines = False
        Me.TVFiles.Size = New System.Drawing.Size(320, 213)
        Me.TVFiles.TabIndex = 87
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEnvolveMidiaAberta)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(324, 328)
        Me.PanelListaProcessoAgendado.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelExecutarProcesso.ResumeLayout(False)
        Me.Panel90.ResumeLayout(False)
        Me.Panel89.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel76.ResumeLayout(False)
        Me.PanelMidia.ResumeLayout(False)
        Me.Panel32.ResumeLayout(False)
        Me.PanelEnvolveMidiaAberta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PanelListaProcessoAgendado As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents PanelExecutarProcesso As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel89 As Panel
    Friend WithEvents Button14 As Button
    Friend WithEvents Panel90 As Panel
    Friend WithEvents Button41 As Button
    Friend WithEvents Panel76 As Panel
    Friend WithEvents PanelMidia As Panel
    Friend WithEvents RadioButton72 As RadioButton
    Friend WithEvents RadioButton69 As RadioButton
    Friend WithEvents Panel32 As Panel
    Friend WithEvents TVFiles As TreeView
    Friend WithEvents PanelEnvolveMidiaAberta As Panel
End Class
