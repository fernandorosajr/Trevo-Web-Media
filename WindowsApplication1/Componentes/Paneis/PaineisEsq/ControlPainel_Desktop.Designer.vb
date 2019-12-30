<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPainel_Desktop
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPainel_Desktop))
        Me.TVWFilesAndFolders = New System.Windows.Forms.TreeView()
        Me.IMGList = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelBorder_TVWDesktop = New System.Windows.Forms.Panel()
        Me.PanelOpcoesDeProcessos = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_BTN_NewFolder = New System.Windows.Forms.Panel()
        Me.BTN_NewFolder = New System.Windows.Forms.Button()
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes = New System.Windows.Forms.Panel()
        Me.CHK_ShowCheck = New System.Windows.Forms.CheckBox()
        Me.PanelBorder_TVWDesktop.SuspendLayout()
        Me.PanelOpcoesDeProcessos.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelEnvolve_BTN_NewFolder.SuspendLayout()
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVWFilesAndFolders
        '
        Me.TVWFilesAndFolders.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TVWFilesAndFolders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVWFilesAndFolders.CheckBoxes = True
        Me.TVWFilesAndFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVWFilesAndFolders.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVWFilesAndFolders.FullRowSelect = True
        Me.TVWFilesAndFolders.HideSelection = False
        Me.TVWFilesAndFolders.ImageIndex = 0
        Me.TVWFilesAndFolders.ImageList = Me.IMGList
        Me.TVWFilesAndFolders.Location = New System.Drawing.Point(1, 1)
        Me.TVWFilesAndFolders.Name = "TVWFilesAndFolders"
        Me.TVWFilesAndFolders.SelectedImageIndex = 0
        Me.TVWFilesAndFolders.ShowLines = False
        Me.TVWFilesAndFolders.Size = New System.Drawing.Size(306, 306)
        Me.TVWFilesAndFolders.TabIndex = 3
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
        '
        'PanelBorder_TVWDesktop
        '
        Me.PanelBorder_TVWDesktop.BackColor = System.Drawing.Color.DimGray
        Me.PanelBorder_TVWDesktop.Controls.Add(Me.Panel2)
        Me.PanelBorder_TVWDesktop.Controls.Add(Me.Panel1)
        Me.PanelBorder_TVWDesktop.Controls.Add(Me.PanelOpcoesDeProcessos)
        Me.PanelBorder_TVWDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder_TVWDesktop.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder_TVWDesktop.Name = "PanelBorder_TVWDesktop"
        Me.PanelBorder_TVWDesktop.Size = New System.Drawing.Size(308, 341)
        Me.PanelBorder_TVWDesktop.TabIndex = 4
        '
        'PanelOpcoesDeProcessos
        '
        Me.PanelOpcoesDeProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelOpcoesDeProcessos.Controls.Add(Me.Panel36)
        Me.PanelOpcoesDeProcessos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpcoesDeProcessos.Location = New System.Drawing.Point(0, 0)
        Me.PanelOpcoesDeProcessos.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelOpcoesDeProcessos.Name = "PanelOpcoesDeProcessos"
        Me.PanelOpcoesDeProcessos.Padding = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.PanelOpcoesDeProcessos.Size = New System.Drawing.Size(308, 30)
        Me.PanelOpcoesDeProcessos.TabIndex = 97
        '
        'Panel36
        '
        Me.Panel36.Controls.Add(Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes)
        Me.Panel36.Controls.Add(Me.PanelEnvolve_BTN_NewFolder)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel36.Location = New System.Drawing.Point(5, 2)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.Panel36.Size = New System.Drawing.Size(298, 28)
        Me.Panel36.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TVWFilesAndFolders)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(308, 308)
        Me.Panel2.TabIndex = 99
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 3)
        Me.Panel1.TabIndex = 98
        '
        'PanelEnvolve_BTN_NewFolder
        '
        Me.PanelEnvolve_BTN_NewFolder.Controls.Add(Me.BTN_NewFolder)
        Me.PanelEnvolve_BTN_NewFolder.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEnvolve_BTN_NewFolder.Location = New System.Drawing.Point(0, 1)
        Me.PanelEnvolve_BTN_NewFolder.Name = "PanelEnvolve_BTN_NewFolder"
        Me.PanelEnvolve_BTN_NewFolder.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolve_BTN_NewFolder.Size = New System.Drawing.Size(32, 26)
        Me.PanelEnvolve_BTN_NewFolder.TabIndex = 114
        '
        'BTN_NewFolder
        '
        Me.BTN_NewFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NewFolder.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.Nova_pasta_em_agrupamentos
        Me.BTN_NewFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NewFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NewFolder.FlatAppearance.BorderSize = 0
        Me.BTN_NewFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NewFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NewFolder.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NewFolder.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_NewFolder.Name = "BTN_NewFolder"
        Me.BTN_NewFolder.Size = New System.Drawing.Size(30, 24)
        Me.BTN_NewFolder.TabIndex = 20
        Me.BTN_NewFolder.UseVisualStyleBackColor = False
        '
        'PanelEnvolveCHK_ShowPanelAllProcessosAcoes
        '
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Controls.Add(Me.CHK_ShowCheck)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Location = New System.Drawing.Point(32, 1)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Name = "PanelEnvolveCHK_ShowPanelAllProcessosAcoes"
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Size = New System.Drawing.Size(32, 26)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.TabIndex = 115
        '
        'CHK_ShowCheck
        '
        Me.CHK_ShowCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.CHK_ShowCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CHK_ShowCheck.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.Exibir_painel_de_processos
        Me.CHK_ShowCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CHK_ShowCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CHK_ShowCheck.Checked = True
        Me.CHK_ShowCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_ShowCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CHK_ShowCheck.FlatAppearance.BorderSize = 0
        Me.CHK_ShowCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.CHK_ShowCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CHK_ShowCheck.Location = New System.Drawing.Point(1, 1)
        Me.CHK_ShowCheck.Name = "CHK_ShowCheck"
        Me.CHK_ShowCheck.Size = New System.Drawing.Size(30, 24)
        Me.CHK_ShowCheck.TabIndex = 19
        Me.CHK_ShowCheck.UseVisualStyleBackColor = False
        '
        'ControlPainel_Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelBorder_TVWDesktop)
        Me.Name = "ControlPainel_Desktop"
        Me.Size = New System.Drawing.Size(308, 341)
        Me.PanelBorder_TVWDesktop.ResumeLayout(False)
        Me.PanelOpcoesDeProcessos.ResumeLayout(False)
        Me.Panel36.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelEnvolve_BTN_NewFolder.ResumeLayout(False)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TVWFilesAndFolders As TreeView
    Friend WithEvents PanelBorder_TVWDesktop As Panel
    Friend WithEvents IMGList As ImageList
    Friend WithEvents PanelOpcoesDeProcessos As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelEnvolve_BTN_NewFolder As Panel
    Friend WithEvents BTN_NewFolder As Button
    Friend WithEvents PanelEnvolveCHK_ShowPanelAllProcessosAcoes As Panel
    Friend WithEvents CHK_ShowCheck As CheckBox
End Class
