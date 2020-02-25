<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDialogInputBox
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TxtResponse = New System.Windows.Forms.TextBox()
        Me.LBLPrompt = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBLTitle01 = New System.Windows.Forms.Label()
        Me.PanelBorder_TxtResponse = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_TxtResponse = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBorder_TxtResponse.SuspendLayout()
        Me.PanelEnvolve_TxtResponse.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(365, 162)
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
        Me.OK_Button.ForeColor = System.Drawing.Color.DarkGray
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
        'TxtResponse
        '
        Me.TxtResponse.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TxtResponse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtResponse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtResponse.ForeColor = System.Drawing.Color.DarkGray
        Me.TxtResponse.Location = New System.Drawing.Point(3, 3)
        Me.TxtResponse.MaxLength = 32
        Me.TxtResponse.Name = "TxtResponse"
        Me.TxtResponse.Size = New System.Drawing.Size(481, 13)
        Me.TxtResponse.TabIndex = 1
        '
        'LBLPrompt
        '
        Me.LBLPrompt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLPrompt.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLPrompt.Location = New System.Drawing.Point(130, 52)
        Me.LBLPrompt.Name = "LBLPrompt"
        Me.LBLPrompt.Size = New System.Drawing.Size(381, 51)
        Me.LBLPrompt.TabIndex = 2
        Me.LBLPrompt.Text = "Label1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TrevoWebMedia.My.Resources.Resources.information__2_
        Me.PictureBox1.Location = New System.Drawing.Point(22, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LBLTitle01
        '
        Me.LBLTitle01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitle01.AutoEllipsis = True
        Me.LBLTitle01.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle01.ForeColor = System.Drawing.Color.LightGray
        Me.LBLTitle01.Location = New System.Drawing.Point(126, 20)
        Me.LBLTitle01.Name = "LBLTitle01"
        Me.LBLTitle01.Size = New System.Drawing.Size(382, 32)
        Me.LBLTitle01.TabIndex = 6
        Me.LBLTitle01.Text = "Editar volume da unidade:"
        '
        'PanelBorder_TxtResponse
        '
        Me.PanelBorder_TxtResponse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBorder_TxtResponse.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelBorder_TxtResponse.Controls.Add(Me.PanelEnvolve_TxtResponse)
        Me.PanelBorder_TxtResponse.Location = New System.Drawing.Point(22, 128)
        Me.PanelBorder_TxtResponse.Name = "PanelBorder_TxtResponse"
        Me.PanelBorder_TxtResponse.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_TxtResponse.Size = New System.Drawing.Size(489, 22)
        Me.PanelBorder_TxtResponse.TabIndex = 7
        '
        'PanelEnvolve_TxtResponse
        '
        Me.PanelEnvolve_TxtResponse.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelEnvolve_TxtResponse.Controls.Add(Me.TxtResponse)
        Me.PanelEnvolve_TxtResponse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TxtResponse.Location = New System.Drawing.Point(1, 1)
        Me.PanelEnvolve_TxtResponse.Name = "PanelEnvolve_TxtResponse"
        Me.PanelEnvolve_TxtResponse.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelEnvolve_TxtResponse.Size = New System.Drawing.Size(487, 20)
        Me.PanelEnvolve_TxtResponse.TabIndex = 2
        '
        'FRMDialogInputBox
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(528, 212)
        Me.Controls.Add(Me.PanelBorder_TxtResponse)
        Me.Controls.Add(Me.LBLTitle01)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBLPrompt)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMDialogInputBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogRenameVolume"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBorder_TxtResponse.ResumeLayout(False)
        Me.PanelEnvolve_TxtResponse.ResumeLayout(False)
        Me.PanelEnvolve_TxtResponse.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TxtResponse As TextBox
    Friend WithEvents LBLPrompt As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBLTitle01 As Label
    Friend WithEvents PanelBorder_TxtResponse As Panel
    Friend WithEvents PanelEnvolve_TxtResponse As Panel
End Class
