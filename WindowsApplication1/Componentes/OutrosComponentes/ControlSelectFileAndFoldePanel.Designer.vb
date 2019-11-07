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
        Me.PanelCaminho = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button93 = New System.Windows.Forms.Button()
        Me.Button94 = New System.Windows.Forms.Button()
        Me.Button95 = New System.Windows.Forms.Button()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PanelEnvolveControl = New System.Windows.Forms.Panel()
        Me.PanelControl.SuspendLayout()
        Me.PanelMarginNameAndExtencao.SuspendLayout()
        Me.PanelNameAndExtencao.SuspendLayout()
        Me.PanelName.SuspendLayout()
        Me.PanelEXTProp.SuspendLayout()
        Me.PanelMarginPath.SuspendLayout()
        Me.PanelBorderPath.SuspendLayout()
        Me.PanelCaminho.SuspendLayout()
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
        Me.PanelControl.Size = New System.Drawing.Size(640, 63)
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
        Me.PanelMarginNameAndExtencao.Size = New System.Drawing.Size(591, 36)
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
        Me.PanelNameAndExtencao.Size = New System.Drawing.Size(585, 30)
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
        Me.PanelName.Size = New System.Drawing.Size(520, 28)
        Me.PanelName.TabIndex = 93
        '
        'TXTName
        '
        Me.TXTName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTName.ForeColor = System.Drawing.Color.Gainsboro
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
        Me.BTN_TXTName.Size = New System.Drawing.Size(15, 22)
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
        Me.PanelEXTProp.Size = New System.Drawing.Size(63, 28)
        Me.PanelEXTProp.TabIndex = 95
        '
        'TXTExetencao
        '
        Me.TXTExetencao.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTExetencao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTExetencao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTExetencao.ForeColor = System.Drawing.Color.Gainsboro
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
        Me.BTN_TXTExetencao.Size = New System.Drawing.Size(15, 22)
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
        Me.PanelBorderPath.Controls.Add(Me.PanelCaminho)
        Me.PanelBorderPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorderPath.Location = New System.Drawing.Point(3, 3)
        Me.PanelBorderPath.Name = "PanelBorderPath"
        Me.PanelBorderPath.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorderPath.Size = New System.Drawing.Size(585, 20)
        Me.PanelBorderPath.TabIndex = 0
        '
        'PanelCaminho
        '
        Me.PanelCaminho.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelCaminho.Controls.Add(Me.TextBox6)
        Me.PanelCaminho.Controls.Add(Me.Button93)
        Me.PanelCaminho.Controls.Add(Me.Button94)
        Me.PanelCaminho.Controls.Add(Me.Button95)
        Me.PanelCaminho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCaminho.Location = New System.Drawing.Point(1, 1)
        Me.PanelCaminho.Name = "PanelCaminho"
        Me.PanelCaminho.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelCaminho.Size = New System.Drawing.Size(583, 18)
        Me.PanelCaminho.TabIndex = 93
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.ForeColor = System.Drawing.Color.Gainsboro
        Me.TextBox6.Location = New System.Drawing.Point(33, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(532, 13)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.Text = "  C:/"
        '
        'Button93
        '
        Me.Button93.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button93.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button93.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button93.FlatAppearance.BorderSize = 0
        Me.Button93.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button93.Image = CType(resources.GetObject("Button93.Image"), System.Drawing.Image)
        Me.Button93.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button93.Location = New System.Drawing.Point(18, 3)
        Me.Button93.Margin = New System.Windows.Forms.Padding(0)
        Me.Button93.Name = "Button93"
        Me.Button93.Size = New System.Drawing.Size(15, 12)
        Me.Button93.TabIndex = 20
        Me.Button93.UseVisualStyleBackColor = False
        '
        'Button94
        '
        Me.Button94.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button94.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.arquivo2
        Me.Button94.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button94.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button94.FlatAppearance.BorderSize = 0
        Me.Button94.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button94.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button94.Location = New System.Drawing.Point(3, 3)
        Me.Button94.Margin = New System.Windows.Forms.Padding(0)
        Me.Button94.Name = "Button94"
        Me.Button94.Size = New System.Drawing.Size(15, 12)
        Me.Button94.TabIndex = 19
        Me.Button94.UseVisualStyleBackColor = False
        '
        'Button95
        '
        Me.Button95.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button95.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button95.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button95.FlatAppearance.BorderSize = 0
        Me.Button95.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button95.Image = CType(resources.GetObject("Button95.Image"), System.Drawing.Image)
        Me.Button95.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button95.Location = New System.Drawing.Point(565, 3)
        Me.Button95.Margin = New System.Windows.Forms.Padding(0)
        Me.Button95.Name = "Button95"
        Me.Button95.Size = New System.Drawing.Size(15, 12)
        Me.Button95.TabIndex = 18
        Me.Button95.UseVisualStyleBackColor = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox16.Image = Global.TrevoWebMedia.My.Resources.Resources.pasta_winphone1
        Me.PictureBox16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox16.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(45, 59)
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
        Me.PanelEnvolveControl.Size = New System.Drawing.Size(642, 65)
        Me.PanelEnvolveControl.TabIndex = 4
        '
        'ControlSelectFileAndFoldePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEnvolveControl)
        Me.Name = "ControlSelectFileAndFoldePanel"
        Me.Size = New System.Drawing.Size(642, 65)
        Me.PanelControl.ResumeLayout(False)
        Me.PanelMarginNameAndExtencao.ResumeLayout(False)
        Me.PanelNameAndExtencao.ResumeLayout(False)
        Me.PanelName.ResumeLayout(False)
        Me.PanelName.PerformLayout()
        Me.PanelEXTProp.ResumeLayout(False)
        Me.PanelEXTProp.PerformLayout()
        Me.PanelMarginPath.ResumeLayout(False)
        Me.PanelBorderPath.ResumeLayout(False)
        Me.PanelCaminho.ResumeLayout(False)
        Me.PanelCaminho.PerformLayout()
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
    Friend WithEvents PanelCaminho As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button93 As Button
    Friend WithEvents Button94 As Button
    Friend WithEvents Button95 As Button
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PanelEnvolveControl As Panel
    Friend WithEvents PanelBorderPath As Panel
End Class
