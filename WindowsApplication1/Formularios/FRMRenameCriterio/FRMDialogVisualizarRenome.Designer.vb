<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDialogVisualizarRenome
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nó0")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nó1")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nó2")
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.LBLTitle01 = New System.Windows.Forms.Label()
        Me.LBRenomeados = New System.Windows.Forms.ListBox()
        Me.PanelBorder = New System.Windows.Forms.Panel()
        Me.PanelBackground = New System.Windows.Forms.Panel()
        Me.TVWRenomeados = New System.Windows.Forms.TreeView()
        Me.LBLExplicacao = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelBorder.SuspendLayout()
        Me.PanelBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 352)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(611, 29)
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
        Me.OK_Button.Location = New System.Drawing.Point(272, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Visto"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'LBLTitle01
        '
        Me.LBLTitle01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitle01.AutoEllipsis = True
        Me.LBLTitle01.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle01.ForeColor = System.Drawing.Color.LightGray
        Me.LBLTitle01.Location = New System.Drawing.Point(27, 22)
        Me.LBLTitle01.Name = "LBLTitle01"
        Me.LBLTitle01.Size = New System.Drawing.Size(607, 29)
        Me.LBLTitle01.TabIndex = 1
        Me.LBLTitle01.Text = "Detalhe da previsão de renome"
        '
        'LBRenomeados
        '
        Me.LBRenomeados.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.LBRenomeados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBRenomeados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBRenomeados.ForeColor = System.Drawing.Color.DarkGray
        Me.LBRenomeados.FormattingEnabled = True
        Me.LBRenomeados.Location = New System.Drawing.Point(4, 4)
        Me.LBRenomeados.Name = "LBRenomeados"
        Me.LBRenomeados.Size = New System.Drawing.Size(601, 249)
        Me.LBRenomeados.TabIndex = 2
        '
        'PanelBorder
        '
        Me.PanelBorder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelBorder.Controls.Add(Me.PanelBackground)
        Me.PanelBorder.Location = New System.Drawing.Point(23, 74)
        Me.PanelBorder.Name = "PanelBorder"
        Me.PanelBorder.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder.Size = New System.Drawing.Size(611, 259)
        Me.PanelBorder.TabIndex = 4
        '
        'PanelBackground
        '
        Me.PanelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PanelBackground.Controls.Add(Me.LBRenomeados)
        Me.PanelBackground.Controls.Add(Me.TVWRenomeados)
        Me.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackground.Location = New System.Drawing.Point(1, 1)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelBackground.Size = New System.Drawing.Size(609, 257)
        Me.PanelBackground.TabIndex = 3
        '
        'TVWRenomeados
        '
        Me.TVWRenomeados.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TVWRenomeados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVWRenomeados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVWRenomeados.ForeColor = System.Drawing.Color.DarkGray
        Me.TVWRenomeados.HideSelection = False
        Me.TVWRenomeados.Location = New System.Drawing.Point(4, 4)
        Me.TVWRenomeados.Name = "TVWRenomeados"
        TreeNode4.Name = "Nó0"
        TreeNode4.Text = "Nó0"
        TreeNode5.Name = "Nó1"
        TreeNode5.Text = "Nó1"
        TreeNode6.Name = "Nó2"
        TreeNode6.Text = "Nó2"
        Me.TVWRenomeados.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Me.TVWRenomeados.ShowPlusMinus = False
        Me.TVWRenomeados.ShowRootLines = False
        Me.TVWRenomeados.Size = New System.Drawing.Size(601, 249)
        Me.TVWRenomeados.TabIndex = 6
        '
        'LBLExplicacao
        '
        Me.LBLExplicacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLExplicacao.AutoEllipsis = True
        Me.LBLExplicacao.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLExplicacao.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLExplicacao.Location = New System.Drawing.Point(31, 54)
        Me.LBLExplicacao.Name = "LBLExplicacao"
        Me.LBLExplicacao.Size = New System.Drawing.Size(603, 22)
        Me.LBLExplicacao.TabIndex = 5
        Me.LBLExplicacao.Text = "Carregando ..."
        '
        'Timer1
        '
        '
        'FRMDialogVisualizarRenome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(658, 403)
        Me.Controls.Add(Me.PanelBorder)
        Me.Controls.Add(Me.LBLTitle01)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LBLExplicacao)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMDialogVisualizarRenome"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalhar previsão de renome"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelBorder.ResumeLayout(False)
        Me.PanelBackground.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents LBLTitle01 As Label
    Friend WithEvents LBRenomeados As ListBox
    Friend WithEvents PanelBorder As Panel
    Friend WithEvents PanelBackground As Panel
    Friend WithEvents LBLExplicacao As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TVWRenomeados As TreeView
End Class
