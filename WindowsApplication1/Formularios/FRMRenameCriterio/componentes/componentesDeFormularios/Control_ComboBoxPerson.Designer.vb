<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Control_ComboBoxPerson
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_ComboBoxPerson))
        Me.PanelCombo = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LNKLLabelCombo = New System.Windows.Forms.LinkLabel()
        Me.CMS_Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BTNExpandCombo = New System.Windows.Forms.Button()
        Me.PanelCombo.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
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
        Me.Panel7.Controls.Add(Me.LNKLLabelCombo)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1, 1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(8, 2, 2, 2)
        Me.Panel7.Size = New System.Drawing.Size(212, 19)
        Me.Panel7.TabIndex = 0
        '
        'LNKLLabelCombo
        '
        Me.LNKLLabelCombo.ActiveLinkColor = System.Drawing.Color.LightGray
        Me.LNKLLabelCombo.AutoEllipsis = True
        Me.LNKLLabelCombo.ContextMenuStrip = Me.CMS_Menu
        Me.LNKLLabelCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LNKLLabelCombo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LNKLLabelCombo.LinkArea = New System.Windows.Forms.LinkArea(0, 100)
        Me.LNKLLabelCombo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LNKLLabelCombo.LinkColor = System.Drawing.Color.DarkGray
        Me.LNKLLabelCombo.Location = New System.Drawing.Point(8, 2)
        Me.LNKLLabelCombo.Name = "LNKLLabelCombo"
        Me.LNKLLabelCombo.Size = New System.Drawing.Size(202, 15)
        Me.LNKLLabelCombo.TabIndex = 2
        Me.LNKLLabelCombo.TabStop = True
        Me.LNKLLabelCombo.Text = "<Selecione>"
        Me.LNKLLabelCombo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LNKLLabelCombo.UseCompatibleTextRendering = True
        '
        'CMS_Menu
        '
        Me.CMS_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.CMS_Menu.Name = "CMS_TipoDeProcesso"
        Me.CMS_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CMS_Menu.Size = New System.Drawing.Size(61, 4)
        Me.CMS_Menu.TabStop = True
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
        Me.Panel9.Controls.Add(Me.BTNExpandCombo)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(214, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.Panel9.Size = New System.Drawing.Size(19, 21)
        Me.Panel9.TabIndex = 0
        '
        'BTNExpandCombo
        '
        Me.BTNExpandCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNExpandCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNExpandCombo.ContextMenuStrip = Me.CMS_Menu
        Me.BTNExpandCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTNExpandCombo.FlatAppearance.BorderSize = 0
        Me.BTNExpandCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNExpandCombo.Image = CType(resources.GetObject("BTNExpandCombo.Image"), System.Drawing.Image)
        Me.BTNExpandCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNExpandCombo.Location = New System.Drawing.Point(0, 1)
        Me.BTNExpandCombo.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNExpandCombo.Name = "BTNExpandCombo"
        Me.BTNExpandCombo.Size = New System.Drawing.Size(18, 19)
        Me.BTNExpandCombo.TabIndex = 20
        Me.BTNExpandCombo.UseVisualStyleBackColor = False
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCombo As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LNKLLabelCombo As LinkLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents BTNExpandCombo As Button
    Friend WithEvents CMS_Menu As ContextMenuStrip
End Class
