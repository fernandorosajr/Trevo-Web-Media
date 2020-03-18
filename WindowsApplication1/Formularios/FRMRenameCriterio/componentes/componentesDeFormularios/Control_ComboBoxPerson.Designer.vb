<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_ComboBoxPerson
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_ComboBoxPerson))
        Me.PanelCombo = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CMS_Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelCombo.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.CMS_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCombo
        '
        Me.PanelCombo.BackColor = System.Drawing.Color.Transparent
        Me.PanelCombo.Controls.Add(Me.Panel5)
        Me.PanelCombo.Controls.Add(Me.Panel8)
        Me.PanelCombo.Controls.Add(Me.Panel9)
        Me.PanelCombo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCombo.Location = New System.Drawing.Point(0, 0)
        Me.PanelCombo.Name = "PanelCombo"
        Me.PanelCombo.Size = New System.Drawing.Size(233, 21)
        Me.PanelCombo.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.Panel5.Size = New System.Drawing.Size(213, 21)
        Me.Panel5.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel7.Controls.Add(Me.LinkLabel1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1, 1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(8, 2, 2, 2)
        Me.Panel7.Size = New System.Drawing.Size(212, 19)
        Me.Panel7.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.LightGray
        Me.LinkLabel1.AutoEllipsis = True
        Me.LinkLabel1.ContextMenuStrip = Me.CMS_Menu
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(0, 100)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 2)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(202, 15)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(213, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 21)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Button1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(214, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.Panel9.Size = New System.Drawing.Size(19, 21)
        Me.Panel9.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.ContextMenuStrip = Me.CMS_Menu
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(0, 1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 19)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CMS_TipoDeProcesso
        '
        Me.CMS_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.CMS_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem, Me.IToolStripMenuItem})
        Me.CMS_Menu.Name = "CMS_TipoDeProcesso"
        Me.CMS_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CMS_Menu.Size = New System.Drawing.Size(118, 48)
        Me.CMS_Menu.TabStop = True
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NoneToolStripMenuItem.Text = "<none>"
        '
        'IToolStripMenuItem
        '
        Me.IToolStripMenuItem.Name = "IToolStripMenuItem"
        Me.IToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.IToolStripMenuItem.Text = "i"
        '
        'Control_ComboBoxPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.PanelCombo)
        Me.Name = "Control_ComboBoxPerson"
        Me.Size = New System.Drawing.Size(233, 193)
        Me.PanelCombo.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.CMS_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCombo As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents CMS_Menu As ContextMenuStrip
    Friend WithEvents NoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IToolStripMenuItem As ToolStripMenuItem
End Class
