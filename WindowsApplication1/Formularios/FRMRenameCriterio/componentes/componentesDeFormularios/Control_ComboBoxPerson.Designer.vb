﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.PanelBackground_LNKLabelCombo = New System.Windows.Forms.Panel()
        Me.LNKLLabelCombo = New System.Windows.Forms.LinkLabel()
        Me.CMS_Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_BTNExpandCombo = New System.Windows.Forms.Panel()
        Me.BTNExpandCombo = New System.Windows.Forms.Button()
        Me.PanelBorder_PanelCombo = New System.Windows.Forms.Panel()
        Me.PanelCombo.SuspendLayout()
        Me.PanelBackground_LNKLabelCombo.SuspendLayout()
        Me.PanelEnvolve_BTNExpandCombo.SuspendLayout()
        Me.PanelBorder_PanelCombo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCombo
        '
        Me.PanelCombo.BackColor = System.Drawing.Color.Transparent
        Me.PanelCombo.Controls.Add(Me.PanelBorder_PanelCombo)
        Me.PanelCombo.Controls.Add(Me.Panel8)
        Me.PanelCombo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCombo.Location = New System.Drawing.Point(0, 0)
        Me.PanelCombo.Name = "PanelCombo"
        Me.PanelCombo.Size = New System.Drawing.Size(233, 21)
        Me.PanelCombo.TabIndex = 3
        '
        'PanelBackground_LNKLabelCombo
        '
        Me.PanelBackground_LNKLabelCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelBackground_LNKLabelCombo.Controls.Add(Me.LNKLLabelCombo)
        Me.PanelBackground_LNKLabelCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackground_LNKLabelCombo.Location = New System.Drawing.Point(1, 1)
        Me.PanelBackground_LNKLabelCombo.Name = "PanelBackground_LNKLabelCombo"
        Me.PanelBackground_LNKLabelCombo.Padding = New System.Windows.Forms.Padding(8, 2, 2, 2)
        Me.PanelBackground_LNKLabelCombo.Size = New System.Drawing.Size(211, 19)
        Me.PanelBackground_LNKLabelCombo.TabIndex = 0
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
        Me.LNKLLabelCombo.Size = New System.Drawing.Size(201, 15)
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
        Me.Panel8.Location = New System.Drawing.Point(232, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 21)
        Me.Panel8.TabIndex = 1
        '
        'PanelEnvolve_BTNExpandCombo
        '
        Me.PanelEnvolve_BTNExpandCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelEnvolve_BTNExpandCombo.Controls.Add(Me.BTNExpandCombo)
        Me.PanelEnvolve_BTNExpandCombo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEnvolve_BTNExpandCombo.Location = New System.Drawing.Point(212, 1)
        Me.PanelEnvolve_BTNExpandCombo.Name = "PanelEnvolve_BTNExpandCombo"
        Me.PanelEnvolve_BTNExpandCombo.Size = New System.Drawing.Size(19, 19)
        Me.PanelEnvolve_BTNExpandCombo.TabIndex = 0
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
        Me.BTNExpandCombo.Location = New System.Drawing.Point(0, 0)
        Me.BTNExpandCombo.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNExpandCombo.Name = "BTNExpandCombo"
        Me.BTNExpandCombo.Size = New System.Drawing.Size(19, 19)
        Me.BTNExpandCombo.TabIndex = 20
        Me.BTNExpandCombo.UseVisualStyleBackColor = False
        '
        'PanelBorder_PanelCombo
        '
        Me.PanelBorder_PanelCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelBorder_PanelCombo.Controls.Add(Me.PanelBackground_LNKLabelCombo)
        Me.PanelBorder_PanelCombo.Controls.Add(Me.PanelEnvolve_BTNExpandCombo)
        Me.PanelBorder_PanelCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder_PanelCombo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder_PanelCombo.Name = "PanelBorder_PanelCombo"
        Me.PanelBorder_PanelCombo.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_PanelCombo.Size = New System.Drawing.Size(232, 21)
        Me.PanelBorder_PanelCombo.TabIndex = 2
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
        Me.PanelBackground_LNKLabelCombo.ResumeLayout(False)
        Me.PanelEnvolve_BTNExpandCombo.ResumeLayout(False)
        Me.PanelBorder_PanelCombo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCombo As Panel
    Friend WithEvents PanelBackground_LNKLabelCombo As Panel
    Friend WithEvents LNKLLabelCombo As LinkLabel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PanelEnvolve_BTNExpandCombo As Panel
    Friend WithEvents BTNExpandCombo As Button
    Friend WithEvents CMS_Menu As ContextMenuStrip
    Friend WithEvents PanelBorder_PanelCombo As Panel
End Class
