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
        Me.Panel_FechaPanelOpcoesDeProcessos = New System.Windows.Forms.Panel()
        Me.BTN_FechaPanelOpcoesDeProcessos = New System.Windows.Forms.Button()
        Me.Panel_NovoProcessoGravar = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoGravar = New System.Windows.Forms.Button()
        Me.Panel96 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoExcluir = New System.Windows.Forms.Button()
        Me.Panel97 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoCopiar = New System.Windows.Forms.Button()
        Me.Panel101 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoMover = New System.Windows.Forms.Button()
        Me.Panel102 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoRenomear = New System.Windows.Forms.Button()
        Me.Panel94 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoCriar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBorder_TVWDesktop.SuspendLayout()
        Me.PanelOpcoesDeProcessos.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.Panel_FechaPanelOpcoesDeProcessos.SuspendLayout()
        Me.Panel_NovoProcessoGravar.SuspendLayout()
        Me.Panel96.SuspendLayout()
        Me.Panel97.SuspendLayout()
        Me.Panel101.SuspendLayout()
        Me.Panel102.SuspendLayout()
        Me.Panel94.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel36.Controls.Add(Me.Panel_FechaPanelOpcoesDeProcessos)
        Me.Panel36.Controls.Add(Me.Panel_NovoProcessoGravar)
        Me.Panel36.Controls.Add(Me.Panel96)
        Me.Panel36.Controls.Add(Me.Panel97)
        Me.Panel36.Controls.Add(Me.Panel101)
        Me.Panel36.Controls.Add(Me.Panel102)
        Me.Panel36.Controls.Add(Me.Panel94)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel36.Location = New System.Drawing.Point(5, 2)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.Panel36.Size = New System.Drawing.Size(298, 28)
        Me.Panel36.TabIndex = 0
        '
        'Panel_FechaPanelOpcoesDeProcessos
        '
        Me.Panel_FechaPanelOpcoesDeProcessos.Controls.Add(Me.BTN_FechaPanelOpcoesDeProcessos)
        Me.Panel_FechaPanelOpcoesDeProcessos.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_FechaPanelOpcoesDeProcessos.Location = New System.Drawing.Point(285, 1)
        Me.Panel_FechaPanelOpcoesDeProcessos.Name = "Panel_FechaPanelOpcoesDeProcessos"
        Me.Panel_FechaPanelOpcoesDeProcessos.Size = New System.Drawing.Size(13, 26)
        Me.Panel_FechaPanelOpcoesDeProcessos.TabIndex = 114
        '
        'BTN_FechaPanelOpcoesDeProcessos
        '
        Me.BTN_FechaPanelOpcoesDeProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_FechaPanelOpcoesDeProcessos.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.fechar_cinza
        Me.BTN_FechaPanelOpcoesDeProcessos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_FechaPanelOpcoesDeProcessos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_FechaPanelOpcoesDeProcessos.FlatAppearance.BorderSize = 0
        Me.BTN_FechaPanelOpcoesDeProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_FechaPanelOpcoesDeProcessos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_FechaPanelOpcoesDeProcessos.Location = New System.Drawing.Point(0, 0)
        Me.BTN_FechaPanelOpcoesDeProcessos.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_FechaPanelOpcoesDeProcessos.Name = "BTN_FechaPanelOpcoesDeProcessos"
        Me.BTN_FechaPanelOpcoesDeProcessos.Size = New System.Drawing.Size(13, 20)
        Me.BTN_FechaPanelOpcoesDeProcessos.TabIndex = 31
        Me.BTN_FechaPanelOpcoesDeProcessos.UseVisualStyleBackColor = False
        '
        'Panel_NovoProcessoGravar
        '
        Me.Panel_NovoProcessoGravar.Controls.Add(Me.BTN_NovoProcessoGravar)
        Me.Panel_NovoProcessoGravar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_NovoProcessoGravar.Location = New System.Drawing.Point(110, 1)
        Me.Panel_NovoProcessoGravar.Name = "Panel_NovoProcessoGravar"
        Me.Panel_NovoProcessoGravar.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel_NovoProcessoGravar.Size = New System.Drawing.Size(19, 26)
        Me.Panel_NovoProcessoGravar.TabIndex = 112
        '
        'BTN_NovoProcessoGravar
        '
        Me.BTN_NovoProcessoGravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoGravar.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.dvd
        Me.BTN_NovoProcessoGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoGravar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoGravar.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoGravar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoGravar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoGravar.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoGravar.Name = "BTN_NovoProcessoGravar"
        Me.BTN_NovoProcessoGravar.Size = New System.Drawing.Size(17, 24)
        Me.BTN_NovoProcessoGravar.TabIndex = 29
        Me.BTN_NovoProcessoGravar.UseVisualStyleBackColor = False
        '
        'Panel96
        '
        Me.Panel96.Controls.Add(Me.BTN_NovoProcessoExcluir)
        Me.Panel96.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel96.Location = New System.Drawing.Point(92, 1)
        Me.Panel96.Name = "Panel96"
        Me.Panel96.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel96.Size = New System.Drawing.Size(18, 26)
        Me.Panel96.TabIndex = 111
        '
        'BTN_NovoProcessoExcluir
        '
        Me.BTN_NovoProcessoExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoExcluir.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.excluir
        Me.BTN_NovoProcessoExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoExcluir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoExcluir.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoExcluir.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoExcluir.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoExcluir.Name = "BTN_NovoProcessoExcluir"
        Me.BTN_NovoProcessoExcluir.Size = New System.Drawing.Size(16, 24)
        Me.BTN_NovoProcessoExcluir.TabIndex = 28
        Me.BTN_NovoProcessoExcluir.UseVisualStyleBackColor = False
        '
        'Panel97
        '
        Me.Panel97.Controls.Add(Me.BTN_NovoProcessoCopiar)
        Me.Panel97.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel97.Location = New System.Drawing.Point(69, 1)
        Me.Panel97.Name = "Panel97"
        Me.Panel97.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel97.Size = New System.Drawing.Size(23, 26)
        Me.Panel97.TabIndex = 110
        '
        'BTN_NovoProcessoCopiar
        '
        Me.BTN_NovoProcessoCopiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoCopiar.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.NovoProcessoCopiar
        Me.BTN_NovoProcessoCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoCopiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoCopiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoCopiar.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoCopiar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoCopiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoCopiar.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoCopiar.Name = "BTN_NovoProcessoCopiar"
        Me.BTN_NovoProcessoCopiar.Size = New System.Drawing.Size(21, 24)
        Me.BTN_NovoProcessoCopiar.TabIndex = 27
        Me.BTN_NovoProcessoCopiar.UseVisualStyleBackColor = False
        '
        'Panel101
        '
        Me.Panel101.Controls.Add(Me.BTN_NovoProcessoMover)
        Me.Panel101.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel101.Location = New System.Drawing.Point(46, 1)
        Me.Panel101.Name = "Panel101"
        Me.Panel101.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel101.Size = New System.Drawing.Size(23, 26)
        Me.Panel101.TabIndex = 109
        '
        'BTN_NovoProcessoMover
        '
        Me.BTN_NovoProcessoMover.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoMover.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.NovoProcessoMover2
        Me.BTN_NovoProcessoMover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoMover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoMover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoMover.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoMover.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoMover.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoMover.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoMover.Name = "BTN_NovoProcessoMover"
        Me.BTN_NovoProcessoMover.Size = New System.Drawing.Size(21, 24)
        Me.BTN_NovoProcessoMover.TabIndex = 26
        Me.BTN_NovoProcessoMover.UseVisualStyleBackColor = False
        '
        'Panel102
        '
        Me.Panel102.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel102.Controls.Add(Me.BTN_NovoProcessoRenomear)
        Me.Panel102.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel102.Location = New System.Drawing.Point(23, 1)
        Me.Panel102.Name = "Panel102"
        Me.Panel102.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel102.Size = New System.Drawing.Size(23, 26)
        Me.Panel102.TabIndex = 108
        '
        'BTN_NovoProcessoRenomear
        '
        Me.BTN_NovoProcessoRenomear.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoRenomear.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.renomear
        Me.BTN_NovoProcessoRenomear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoRenomear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoRenomear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoRenomear.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoRenomear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoRenomear.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoRenomear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoRenomear.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoRenomear.Name = "BTN_NovoProcessoRenomear"
        Me.BTN_NovoProcessoRenomear.Size = New System.Drawing.Size(21, 24)
        Me.BTN_NovoProcessoRenomear.TabIndex = 25
        Me.BTN_NovoProcessoRenomear.UseVisualStyleBackColor = False
        '
        'Panel94
        '
        Me.Panel94.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel94.Controls.Add(Me.BTN_NovoProcessoCriar)
        Me.Panel94.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel94.Location = New System.Drawing.Point(0, 1)
        Me.Panel94.Name = "Panel94"
        Me.Panel94.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel94.Size = New System.Drawing.Size(23, 26)
        Me.Panel94.TabIndex = 113
        '
        'BTN_NovoProcessoCriar
        '
        Me.BTN_NovoProcessoCriar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoCriar.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.novo_arquivo_2
        Me.BTN_NovoProcessoCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoCriar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoCriar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoCriar.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoCriar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoCriar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoCriar.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoCriar.Name = "BTN_NovoProcessoCriar"
        Me.BTN_NovoProcessoCriar.Size = New System.Drawing.Size(21, 24)
        Me.BTN_NovoProcessoCriar.TabIndex = 30
        Me.BTN_NovoProcessoCriar.UseVisualStyleBackColor = False
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
        Me.Panel_FechaPanelOpcoesDeProcessos.ResumeLayout(False)
        Me.Panel_NovoProcessoGravar.ResumeLayout(False)
        Me.Panel96.ResumeLayout(False)
        Me.Panel97.ResumeLayout(False)
        Me.Panel101.ResumeLayout(False)
        Me.Panel102.ResumeLayout(False)
        Me.Panel94.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TVWFilesAndFolders As TreeView
    Friend WithEvents PanelBorder_TVWDesktop As Panel
    Friend WithEvents IMGList As ImageList
    Friend WithEvents PanelOpcoesDeProcessos As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Panel_FechaPanelOpcoesDeProcessos As Panel
    Friend WithEvents BTN_FechaPanelOpcoesDeProcessos As Button
    Friend WithEvents Panel_NovoProcessoGravar As Panel
    Friend WithEvents BTN_NovoProcessoGravar As Button
    Friend WithEvents Panel96 As Panel
    Friend WithEvents BTN_NovoProcessoExcluir As Button
    Friend WithEvents Panel97 As Panel
    Friend WithEvents BTN_NovoProcessoCopiar As Button
    Friend WithEvents Panel101 As Panel
    Friend WithEvents BTN_NovoProcessoMover As Button
    Friend WithEvents Panel102 As Panel
    Friend WithEvents BTN_NovoProcessoRenomear As Button
    Friend WithEvents Panel94 As Panel
    Friend WithEvents BTN_NovoProcessoCriar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
