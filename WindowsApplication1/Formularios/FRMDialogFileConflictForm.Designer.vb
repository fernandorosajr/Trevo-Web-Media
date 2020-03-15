<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDialogFileConflictForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PanelEnvolveButtons = New System.Windows.Forms.Panel()
        Me.BTNSubstituir = New System.Windows.Forms.Button()
        Me.BTNMesclar = New System.Windows.Forms.Button()
        Me.BTNIgnorar = New System.Windows.Forms.Button()
        Me.LBLFolderName = New System.Windows.Forms.Label()
        Me.LBLTitle01 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLTitle02 = New System.Windows.Forms.Label()
        Me.ChBMemorizarAcao = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelEnvolve_PanelDivisor = New System.Windows.Forms.Panel()
        Me.PanelDivisor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelEnvolveButtons.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelEnvolve_PanelDivisor.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(344, 314)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.OK_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.Color.LightGray
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.ForeColor = System.Drawing.Color.DarkGray
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'PanelEnvolveButtons
        '
        Me.PanelEnvolveButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEnvolveButtons.Controls.Add(Me.Button2)
        Me.PanelEnvolveButtons.Controls.Add(Me.Button1)
        Me.PanelEnvolveButtons.Controls.Add(Me.ChBMemorizarAcao)
        Me.PanelEnvolveButtons.Controls.Add(Me.BTNSubstituir)
        Me.PanelEnvolveButtons.Controls.Add(Me.BTNMesclar)
        Me.PanelEnvolveButtons.Controls.Add(Me.BTNIgnorar)
        Me.PanelEnvolveButtons.Location = New System.Drawing.Point(24, 147)
        Me.PanelEnvolveButtons.Name = "PanelEnvolveButtons"
        Me.PanelEnvolveButtons.Size = New System.Drawing.Size(466, 156)
        Me.PanelEnvolveButtons.TabIndex = 104
        '
        'BTNSubstituir
        '
        Me.BTNSubstituir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNSubstituir.AutoEllipsis = True
        Me.BTNSubstituir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSubstituir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNSubstituir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNSubstituir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSubstituir.Location = New System.Drawing.Point(14, 41)
        Me.BTNSubstituir.Name = "BTNSubstituir"
        Me.BTNSubstituir.Size = New System.Drawing.Size(377, 23)
        Me.BTNSubstituir.TabIndex = 22
        Me.BTNSubstituir.Tag = "Exclui pasta destino e seus conteúdos e a substitui pela pasta de origem."
        Me.BTNSubstituir.Text = "Renomear todos no destino"
        Me.BTNSubstituir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTNMesclar
        '
        Me.BTNMesclar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMesclar.AutoEllipsis = True
        Me.BTNMesclar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNMesclar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNMesclar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTNMesclar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNMesclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMesclar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMesclar.ForeColor = System.Drawing.Color.LightGray
        Me.BTNMesclar.Location = New System.Drawing.Point(14, 12)
        Me.BTNMesclar.Name = "BTNMesclar"
        Me.BTNMesclar.Size = New System.Drawing.Size(445, 23)
        Me.BTNMesclar.TabIndex = 21
        Me.BTNMesclar.Tag = "Mescla pastas no destino. Se houver arquivos de mesmo nome será perguntado o que " &
    "fazer."
        Me.BTNMesclar.Text = "Substituir os arquivos no destino"
        Me.BTNMesclar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMesclar.UseVisualStyleBackColor = False
        '
        'BTNIgnorar
        '
        Me.BTNIgnorar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNIgnorar.AutoEllipsis = True
        Me.BTNIgnorar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNIgnorar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNIgnorar.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.BTNIgnorar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNIgnorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIgnorar.Location = New System.Drawing.Point(14, 70)
        Me.BTNIgnorar.Name = "BTNIgnorar"
        Me.BTNIgnorar.Size = New System.Drawing.Size(445, 23)
        Me.BTNIgnorar.TabIndex = 23
        Me.BTNIgnorar.Tag = "Nada será feito."
        Me.BTNIgnorar.Text = "Ignorar estes aruivos"
        Me.BTNIgnorar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLFolderName
        '
        Me.LBLFolderName.AutoEllipsis = True
        Me.LBLFolderName.AutoSize = True
        Me.LBLFolderName.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBLFolderName.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFolderName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLFolderName.Location = New System.Drawing.Point(58, 0)
        Me.LBLFolderName.Name = "LBLFolderName"
        Me.LBLFolderName.Size = New System.Drawing.Size(13, 14)
        Me.LBLFolderName.TabIndex = 106
        Me.LBLFolderName.Text = "0"
        '
        'LBLTitle01
        '
        Me.LBLTitle01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitle01.AutoEllipsis = True
        Me.LBLTitle01.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle01.ForeColor = System.Drawing.Color.LightGray
        Me.LBLTitle01.Location = New System.Drawing.Point(32, 51)
        Me.LBLTitle01.Name = "LBLTitle01"
        Me.LBLTitle01.Size = New System.Drawing.Size(457, 47)
        Me.LBLTitle01.TabIndex = 105
        Me.LBLTitle01.Text = "Este destino tem 2 arquivos com nomes iguais."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LBLFolderName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(32, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 21)
        Me.Panel1.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(71, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "itens de"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoEllipsis = True
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Orange
        Me.LinkLabel1.Location = New System.Drawing.Point(119, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(48, 13)
        Me.LinkLabel1.TabIndex = 109
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "pasta 01"
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(167, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "para"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoEllipsis = True
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Orange
        Me.LinkLabel2.Location = New System.Drawing.Point(197, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(48, 13)
        Me.LinkLabel2.TabIndex = 111
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "pasta 02"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 14)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Copiando"
        '
        'LBLTitle02
        '
        Me.LBLTitle02.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitle02.AutoEllipsis = True
        Me.LBLTitle02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle02.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLTitle02.Location = New System.Drawing.Point(35, 122)
        Me.LBLTitle02.Name = "LBLTitle02"
        Me.LBLTitle02.Size = New System.Drawing.Size(448, 17)
        Me.LBLTitle02.TabIndex = 109
        Me.LBLTitle02.Text = "O que deseja fazer?"
        '
        'ChBMemorizarAcao
        '
        Me.ChBMemorizarAcao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChBMemorizarAcao.AutoSize = True
        Me.ChBMemorizarAcao.Location = New System.Drawing.Point(19, 136)
        Me.ChBMemorizarAcao.Name = "ChBMemorizarAcao"
        Me.ChBMemorizarAcao.Size = New System.Drawing.Size(101, 17)
        Me.ChBMemorizarAcao.TabIndex = 105
        Me.ChBMemorizarAcao.Text = "Memorizar ação"
        Me.ChBMemorizarAcao.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoEllipsis = True
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(279, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 23)
        Me.Button1.TabIndex = 106
        Me.Button1.Tag = "Exclui pasta destino e seus conteúdos e a substitui pela pasta de origem."
        Me.Button1.Text = "Critérios"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.AutoEllipsis = True
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(14, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(445, 23)
        Me.Button2.TabIndex = 107
        Me.Button2.Tag = "Nada será feito."
        Me.Button2.Text = "Deixe-me decidir sobre cada arquivo"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelEnvolve_PanelDivisor
        '
        Me.PanelEnvolve_PanelDivisor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEnvolve_PanelDivisor.Controls.Add(Me.PanelDivisor)
        Me.PanelEnvolve_PanelDivisor.Location = New System.Drawing.Point(35, 132)
        Me.PanelEnvolve_PanelDivisor.Name = "PanelEnvolve_PanelDivisor"
        Me.PanelEnvolve_PanelDivisor.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.PanelEnvolve_PanelDivisor.Size = New System.Drawing.Size(447, 21)
        Me.PanelEnvolve_PanelDivisor.TabIndex = 110
        '
        'PanelDivisor
        '
        Me.PanelDivisor.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelDivisor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDivisor.Location = New System.Drawing.Point(5, 10)
        Me.PanelDivisor.Name = "PanelDivisor"
        Me.PanelDivisor.Size = New System.Drawing.Size(437, 1)
        Me.PanelDivisor.TabIndex = 0
        '
        'FRMDialogFileConflictForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(502, 355)
        Me.Controls.Add(Me.LBLTitle02)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LBLTitle01)
        Me.Controls.Add(Me.PanelEnvolveButtons)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelEnvolve_PanelDivisor)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMDialogFileConflictForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Substituir ou ignorar arquivos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelEnvolveButtons.ResumeLayout(False)
        Me.PanelEnvolveButtons.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelEnvolve_PanelDivisor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PanelEnvolveButtons As Panel
    Friend WithEvents BTNSubstituir As Button
    Friend WithEvents BTNMesclar As Button
    Friend WithEvents BTNIgnorar As Button
    Friend WithEvents LBLFolderName As Label
    Friend WithEvents LBLTitle01 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLTitle02 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ChBMemorizarAcao As CheckBox
    Friend WithEvents PanelEnvolve_PanelDivisor As Panel
    Friend WithEvents PanelDivisor As Panel
End Class
