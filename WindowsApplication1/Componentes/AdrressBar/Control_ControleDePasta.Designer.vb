﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_ControleDePasta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_ControleDePasta))
        Me.PanelBorder_ControleDePasta = New System.Windows.Forms.Panel()
        Me.PanelBackgroundControleDePAsta = New System.Windows.Forms.Panel()
        Me.PanelBorder_BTNMenu = New System.Windows.Forms.Panel()
        Me.BTNMenu = New System.Windows.Forms.Button()
        Me.CMenuPrincipal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNLabel = New System.Windows.Forms.Button()
        Me.BTNImage = New System.Windows.Forms.Button()
        Me.IMGList = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelBorder_ControleDePasta.SuspendLayout()
        Me.PanelBackgroundControleDePAsta.SuspendLayout()
        Me.PanelBorder_BTNMenu.SuspendLayout()
        Me.CMenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBorder_ControleDePasta
        '
        Me.PanelBorder_ControleDePasta.AutoSize = True
        Me.PanelBorder_ControleDePasta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelBorder_ControleDePasta.Controls.Add(Me.PanelBackgroundControleDePAsta)
        Me.PanelBorder_ControleDePasta.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelBorder_ControleDePasta.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder_ControleDePasta.Name = "PanelBorder_ControleDePasta"
        Me.PanelBorder_ControleDePasta.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_ControleDePasta.Size = New System.Drawing.Size(131, 36)
        Me.PanelBorder_ControleDePasta.TabIndex = 1
        '
        'PanelBackgroundControleDePAsta
        '
        Me.PanelBackgroundControleDePAsta.AutoSize = True
        Me.PanelBackgroundControleDePAsta.BackColor = System.Drawing.Color.Transparent
        Me.PanelBackgroundControleDePAsta.Controls.Add(Me.PanelBorder_BTNMenu)
        Me.PanelBackgroundControleDePAsta.Controls.Add(Me.BTNLabel)
        Me.PanelBackgroundControleDePAsta.Controls.Add(Me.BTNImage)
        Me.PanelBackgroundControleDePAsta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackgroundControleDePAsta.Location = New System.Drawing.Point(1, 1)
        Me.PanelBackgroundControleDePAsta.Name = "PanelBackgroundControleDePAsta"
        Me.PanelBackgroundControleDePAsta.Size = New System.Drawing.Size(129, 34)
        Me.PanelBackgroundControleDePAsta.TabIndex = 0
        '
        'PanelBorder_BTNMenu
        '
        Me.PanelBorder_BTNMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelBorder_BTNMenu.Controls.Add(Me.BTNMenu)
        Me.PanelBorder_BTNMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBorder_BTNMenu.Location = New System.Drawing.Point(114, 0)
        Me.PanelBorder_BTNMenu.Name = "PanelBorder_BTNMenu"
        Me.PanelBorder_BTNMenu.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.PanelBorder_BTNMenu.Size = New System.Drawing.Size(15, 34)
        Me.PanelBorder_BTNMenu.TabIndex = 0
        '
        'BTNMenu
        '
        Me.BTNMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BTNMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNMenu.ContextMenuStrip = Me.CMenuPrincipal
        Me.BTNMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTNMenu.FlatAppearance.BorderSize = 0
        Me.BTNMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.BTNMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMenu.Image = Global.TrevoWebMedia.My.Resources.Resources.setaQuebradaParaDireita
        Me.BTNMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNMenu.Location = New System.Drawing.Point(1, 0)
        Me.BTNMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNMenu.Name = "BTNMenu"
        Me.BTNMenu.Size = New System.Drawing.Size(14, 34)
        Me.BTNMenu.TabIndex = 17
        Me.BTNMenu.UseVisualStyleBackColor = False
        '
        'CMenuPrincipal
        '
        Me.CMenuPrincipal.BackColor = System.Drawing.Color.White
        Me.CMenuPrincipal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem})
        Me.CMenuPrincipal.Name = "ContextMenuStrip1"
        Me.CMenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CMenuPrincipal.ShowCheckMargin = True
        Me.CMenuPrincipal.Size = New System.Drawing.Size(203, 48)
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'BTNLabel
        '
        Me.BTNLabel.AutoSize = True
        Me.BTNLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BTNLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNLabel.FlatAppearance.BorderSize = 0
        Me.BTNLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.BTNLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNLabel.Location = New System.Drawing.Point(27, 0)
        Me.BTNLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNLabel.Name = "BTNLabel"
        Me.BTNLabel.Size = New System.Drawing.Size(87, 34)
        Me.BTNLabel.TabIndex = 19
        Me.BTNLabel.Text = "Este Computador"
        Me.BTNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLabel.UseVisualStyleBackColor = False
        '
        'BTNImage
        '
        Me.BTNImage.AutoSize = True
        Me.BTNImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BTNImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNImage.FlatAppearance.BorderSize = 0
        Me.BTNImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.BTNImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNImage.Image = Global.TrevoWebMedia.My.Resources.Resources.Desktop
        Me.BTNImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNImage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNImage.Location = New System.Drawing.Point(0, 0)
        Me.BTNImage.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNImage.Name = "BTNImage"
        Me.BTNImage.Size = New System.Drawing.Size(27, 34)
        Me.BTNImage.TabIndex = 20
        Me.BTNImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNImage.UseVisualStyleBackColor = False
        Me.BTNImage.Visible = False
        '
        'IMGList
        '
        Me.IMGList.ImageStream = CType(resources.GetObject("IMGList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMGList.TransparentColor = System.Drawing.Color.Transparent
        Me.IMGList.Images.SetKeyName(0, "Desktop")
        Me.IMGList.Images.SetKeyName(1, "Computador")
        Me.IMGList.Images.SetKeyName(2, "Imagens")
        Me.IMGList.Images.SetKeyName(3, "Documentos")
        Me.IMGList.Images.SetKeyName(4, "Musicas")
        Me.IMGList.Images.SetKeyName(5, "pastaAberta")
        Me.IMGList.Images.SetKeyName(6, "pastaFechada")
        Me.IMGList.Images.SetKeyName(7, "hd")
        Me.IMGList.Images.SetKeyName(8, "DVD")
        Me.IMGList.Images.SetKeyName(9, "UnidadeVazia")
        Me.IMGList.Images.SetKeyName(10, "info")
        Me.IMGList.Images.SetKeyName(11, "Videos")
        Me.IMGList.Images.SetKeyName(12, "down")
        Me.IMGList.Images.SetKeyName(13, "Pen.ico")
        '
        'Control_ControleDePasta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.PanelBorder_ControleDePasta)
        Me.Name = "Control_ControleDePasta"
        Me.Size = New System.Drawing.Size(268, 36)
        Me.PanelBorder_ControleDePasta.ResumeLayout(False)
        Me.PanelBorder_ControleDePasta.PerformLayout()
        Me.PanelBackgroundControleDePAsta.ResumeLayout(False)
        Me.PanelBackgroundControleDePAsta.PerformLayout()
        Me.PanelBorder_BTNMenu.ResumeLayout(False)
        Me.CMenuPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBorder_ControleDePasta As Panel
    Friend WithEvents PanelBackgroundControleDePAsta As Panel
    Friend WithEvents PanelBorder_BTNMenu As Panel
    Friend WithEvents BTNMenu As Button
    Friend WithEvents BTNLabel As Button
    Friend WithEvents CMenuPrincipal As ContextMenuStrip
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IMGList As ImageList
    Friend WithEvents BTNImage As Button
End Class
