<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSelectFileAndFoldePanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlSelectFileAndFoldePanel))
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.PanelMarginNameAndExtencao = New System.Windows.Forms.Panel()
        Me.PanelNameAndExtencao = New System.Windows.Forms.Panel()
        Me.PanelName = New System.Windows.Forms.Panel()
        Me.TXTName = New System.Windows.Forms.TextBox()
        Me.BTN_TXTName = New System.Windows.Forms.Button()
        Me.PanelEXTProp = New System.Windows.Forms.Panel()
        Me.TXTExetencao = New System.Windows.Forms.TextBox()
        Me.BTN_TXTExetencao = New System.Windows.Forms.Button()
        Me.PanelMarginPath = New System.Windows.Forms.Panel()
        Me.PanelBorderPath = New System.Windows.Forms.Panel()
        Me.PanelPath = New System.Windows.Forms.Panel()
        Me.TXTPath = New System.Windows.Forms.TextBox()
        Me.BTNExpandiPath = New System.Windows.Forms.Button()
        Me.BTNIconPath = New System.Windows.Forms.Button()
        Me.BTN_TXTPath = New System.Windows.Forms.Button()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PanelEnvolveControl = New System.Windows.Forms.Panel()
        Me.PanelControl.SuspendLayout()
        Me.PanelMarginNameAndExtencao.SuspendLayout()
        Me.PanelNameAndExtencao.SuspendLayout()
        Me.PanelName.SuspendLayout()
        Me.PanelEXTProp.SuspendLayout()
        Me.PanelMarginPath.SuspendLayout()
        Me.PanelBorderPath.SuspendLayout()
        Me.PanelPath.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEnvolveControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl
        '
        Me.PanelControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelControl.Controls.Add(Me.PanelMarginNameAndExtencao)
        Me.PanelControl.Controls.Add(Me.PanelMarginPath)
        Me.PanelControl.Controls.Add(Me.PictureBox16)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl.Location = New System.Drawing.Point(1, 1)
        Me.PanelControl.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelControl.Size = New System.Drawing.Size(640, 96)
        Me.PanelControl.TabIndex = 3
        '
        'PanelMarginNameAndExtencao
        '
        Me.PanelMarginNameAndExtencao.BackColor = System.Drawing.Color.Transparent
        Me.PanelMarginNameAndExtencao.Controls.Add(Me.PanelNameAndExtencao)
        Me.PanelMarginNameAndExtencao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMarginNameAndExtencao.Location = New System.Drawing.Point(47, 25)
        Me.PanelMarginNameAndExtencao.Name = "PanelMarginNameAndExtencao"
        Me.PanelMarginNameAndExtencao.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelMarginNameAndExtencao.Size = New System.Drawing.Size(591, 69)
        Me.PanelMarginNameAndExtencao.TabIndex = 96
        '
        'PanelNameAndExtencao
        '
        Me.PanelNameAndExtencao.BackColor = System.Drawing.Color.DimGray
        Me.PanelNameAndExtencao.Controls.Add(Me.PanelName)
        Me.PanelNameAndExtencao.Controls.Add(Me.PanelEXTProp)
        Me.PanelNameAndExtencao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNameAndExtencao.Location = New System.Drawing.Point(3, 3)
        Me.PanelNameAndExtencao.Name = "PanelNameAndExtencao"
        Me.PanelNameAndExtencao.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelNameAndExtencao.Size = New System.Drawing.Size(585, 63)
        Me.PanelNameAndExtencao.TabIndex = 4
        '
        'PanelName
        '
        Me.PanelName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelName.Controls.Add(Me.TXTName)
        Me.PanelName.Controls.Add(Me.BTN_TXTName)
        Me.PanelName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelName.Location = New System.Drawing.Point(1, 1)
        Me.PanelName.Name = "PanelName"
        Me.PanelName.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelName.Size = New System.Drawing.Size(520, 61)
        Me.PanelName.TabIndex = 93
        '
        'TXTName
        '
        Me.TXTName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTName.Cursor = System.Windows.Forms.Cursors.Default
        Me.TXTName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTName.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTName.Location = New System.Drawing.Point(3, 3)
        Me.TXTName.Name = "TXTName"
        Me.TXTName.Size = New System.Drawing.Size(499, 13)
        Me.TXTName.TabIndex = 9
        Me.TXTName.Text = " <NOME>"
        '
        'BTN_TXTName
        '
        Me.BTN_TXTName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTN_TXTName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_TXTName.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_TXTName.FlatAppearance.BorderSize = 0
        Me.BTN_TXTName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_TXTName.Image = CType(resources.GetObject("BTN_TXTName.Image"), System.Drawing.Image)
        Me.BTN_TXTName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_TXTName.Location = New System.Drawing.Point(502, 3)
        Me.BTN_TXTName.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_TXTName.Name = "BTN_TXTName"
        Me.BTN_TXTName.Size = New System.Drawing.Size(15, 55)
        Me.BTN_TXTName.TabIndex = 18
        Me.BTN_TXTName.UseVisualStyleBackColor = False
        '
        'PanelEXTProp
        '
        Me.PanelEXTProp.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelEXTProp.Controls.Add(Me.TXTExetencao)
        Me.PanelEXTProp.Controls.Add(Me.BTN_TXTExetencao)
        Me.PanelEXTProp.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEXTProp.Location = New System.Drawing.Point(521, 1)
        Me.PanelEXTProp.Name = "PanelEXTProp"
        Me.PanelEXTProp.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelEXTProp.Size = New System.Drawing.Size(63, 61)
        Me.PanelEXTProp.TabIndex = 95
        '
        'TXTExetencao
        '
        Me.TXTExetencao.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTExetencao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTExetencao.Cursor = System.Windows.Forms.Cursors.Default
        Me.TXTExetencao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTExetencao.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTExetencao.Location = New System.Drawing.Point(3, 3)
        Me.TXTExetencao.Name = "TXTExetencao"
        Me.TXTExetencao.Size = New System.Drawing.Size(42, 13)
        Me.TXTExetencao.TabIndex = 9
        Me.TXTExetencao.Text = "EXT"
        '
        'BTN_TXTExetencao
        '
        Me.BTN_TXTExetencao.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTN_TXTExetencao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_TXTExetencao.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_TXTExetencao.FlatAppearance.BorderSize = 0
        Me.BTN_TXTExetencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_TXTExetencao.Image = CType(resources.GetObject("BTN_TXTExetencao.Image"), System.Drawing.Image)
        Me.BTN_TXTExetencao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_TXTExetencao.Location = New System.Drawing.Point(45, 3)
        Me.BTN_TXTExetencao.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_TXTExetencao.Name = "BTN_TXTExetencao"
        Me.BTN_TXTExetencao.Size = New System.Drawing.Size(15, 55)
        Me.BTN_TXTExetencao.TabIndex = 18
        Me.BTN_TXTExetencao.UseVisualStyleBackColor = False
        '
        'PanelMarginPath
        '
        Me.PanelMarginPath.BackColor = System.Drawing.Color.Transparent
        Me.PanelMarginPath.Controls.Add(Me.PanelBorderPath)
        Me.PanelMarginPath.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMarginPath.Location = New System.Drawing.Point(47, 2)
        Me.PanelMarginPath.Name = "PanelMarginPath"
        Me.PanelMarginPath.Padding = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.PanelMarginPath.Size = New System.Drawing.Size(591, 23)
        Me.PanelMarginPath.TabIndex = 3
        '
        'PanelBorderPath
        '
        Me.PanelBorderPath.BackColor = System.Drawing.Color.DimGray
        Me.PanelBorderPath.Controls.Add(Me.PanelPath)
        Me.PanelBorderPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorderPath.Location = New System.Drawing.Point(3, 3)
        Me.PanelBorderPath.Name = "PanelBorderPath"
        Me.PanelBorderPath.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorderPath.Size = New System.Drawing.Size(585, 20)
        Me.PanelBorderPath.TabIndex = 0
        '
        'PanelPath
        '
        Me.PanelPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelPath.Controls.Add(Me.TXTPath)
        Me.PanelPath.Controls.Add(Me.BTNExpandiPath)
        Me.PanelPath.Controls.Add(Me.BTNIconPath)
        Me.PanelPath.Controls.Add(Me.BTN_TXTPath)
        Me.PanelPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPath.Location = New System.Drawing.Point(1, 1)
        Me.PanelPath.Name = "PanelPath"
        Me.PanelPath.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelPath.Size = New System.Drawing.Size(583, 18)
        Me.PanelPath.TabIndex = 93
        '
        'TXTPath
        '
        Me.TXTPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.TXTPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPath.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTPath.Location = New System.Drawing.Point(33, 3)
        Me.TXTPath.Name = "TXTPath"
        Me.TXTPath.Size = New System.Drawing.Size(532, 13)
        Me.TXTPath.TabIndex = 9
        Me.TXTPath.Text = "  C:/"
        '
        'BTNExpandiPath
        '
        Me.BTNExpandiPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNExpandiPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNExpandiPath.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNExpandiPath.FlatAppearance.BorderSize = 0
        Me.BTNExpandiPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNExpandiPath.Image = CType(resources.GetObject("BTNExpandiPath.Image"), System.Drawing.Image)
        Me.BTNExpandiPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNExpandiPath.Location = New System.Drawing.Point(18, 3)
        Me.BTNExpandiPath.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNExpandiPath.Name = "BTNExpandiPath"
        Me.BTNExpandiPath.Size = New System.Drawing.Size(15, 12)
        Me.BTNExpandiPath.TabIndex = 20
        Me.BTNExpandiPath.UseVisualStyleBackColor = False
        '
        'BTNIconPath
        '
        Me.BTNIconPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTNIconPath.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.arquivo2
        Me.BTNIconPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNIconPath.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNIconPath.FlatAppearance.BorderSize = 0
        Me.BTNIconPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIconPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNIconPath.Location = New System.Drawing.Point(3, 3)
        Me.BTNIconPath.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNIconPath.Name = "BTNIconPath"
        Me.BTNIconPath.Size = New System.Drawing.Size(15, 12)
        Me.BTNIconPath.TabIndex = 19
        Me.BTNIconPath.UseVisualStyleBackColor = False
        '
        'BTN_TXTPath
        '
        Me.BTN_TXTPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BTN_TXTPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_TXTPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTN_TXTPath.FlatAppearance.BorderSize = 0
        Me.BTN_TXTPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_TXTPath.Image = CType(resources.GetObject("BTN_TXTPath.Image"), System.Drawing.Image)
        Me.BTN_TXTPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_TXTPath.Location = New System.Drawing.Point(565, 3)
        Me.BTN_TXTPath.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_TXTPath.Name = "BTN_TXTPath"
        Me.BTN_TXTPath.Size = New System.Drawing.Size(15, 12)
        Me.BTN_TXTPath.TabIndex = 18
        Me.BTN_TXTPath.UseVisualStyleBackColor = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox16.Image = Global.TrevoWebMedia.My.Resources.Resources.pasta_winphone1
        Me.PictureBox16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox16.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(45, 92)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox16.TabIndex = 95
        Me.PictureBox16.TabStop = False
        '
        'PanelEnvolveControl
        '
        Me.PanelEnvolveControl.BackColor = System.Drawing.Color.DimGray
        Me.PanelEnvolveControl.Controls.Add(Me.PanelControl)
        Me.PanelEnvolveControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolveControl.Location = New System.Drawing.Point(0, 0)
        Me.PanelEnvolveControl.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelEnvolveControl.Name = "PanelEnvolveControl"
        Me.PanelEnvolveControl.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolveControl.Size = New System.Drawing.Size(642, 98)
        Me.PanelEnvolveControl.TabIndex = 4
        '
        'ControlSelectFileAndFoldePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEnvolveControl)
        Me.Name = "ControlSelectFileAndFoldePanel"
        Me.Size = New System.Drawing.Size(642, 98)
        Me.PanelControl.ResumeLayout(False)
        Me.PanelMarginNameAndExtencao.ResumeLayout(False)
        Me.PanelNameAndExtencao.ResumeLayout(False)
        Me.PanelName.ResumeLayout(False)
        Me.PanelName.PerformLayout()
        Me.PanelEXTProp.ResumeLayout(False)
        Me.PanelEXTProp.PerformLayout()
        Me.PanelMarginPath.ResumeLayout(False)
        Me.PanelBorderPath.ResumeLayout(False)
        Me.PanelPath.ResumeLayout(False)
        Me.PanelPath.PerformLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEnvolveControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl As Panel
    Friend WithEvents PanelMarginNameAndExtencao As Panel
    Friend WithEvents PanelNameAndExtencao As Panel
    Friend WithEvents PanelName As Panel
    Friend WithEvents TXTName As TextBox
    Friend WithEvents BTN_TXTName As Button
    Friend WithEvents PanelEXTProp As Panel
    Friend WithEvents TXTExetencao As TextBox
    Friend WithEvents BTN_TXTExetencao As Button
    Friend WithEvents PanelMarginPath As Panel
    Friend WithEvents PanelPath As Panel
    Friend WithEvents TXTPath As TextBox
    Friend WithEvents BTNExpandiPath As Button
    Friend WithEvents BTNIconPath As Button
    Friend WithEvents BTN_TXTPath As Button
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PanelEnvolveControl As Panel
    Friend WithEvents PanelBorderPath As Panel
End Class
