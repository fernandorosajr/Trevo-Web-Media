<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_TextBoxPerson
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
        Me.PanelTXT = New System.Windows.Forms.Panel()
        Me.PanelBorder = New System.Windows.Forms.Panel()
        Me.PanelEnvolveTXT = New System.Windows.Forms.Panel()
        Me.TXTBox = New System.Windows.Forms.TextBox()
        Me.PanelTXT.SuspendLayout()
        Me.PanelBorder.SuspendLayout()
        Me.PanelEnvolveTXT.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTXT
        '
        Me.PanelTXT.BackColor = System.Drawing.Color.Transparent
        Me.PanelTXT.Controls.Add(Me.PanelBorder)
        Me.PanelTXT.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTXT.Location = New System.Drawing.Point(0, 0)
        Me.PanelTXT.Name = "PanelTXT"
        Me.PanelTXT.Size = New System.Drawing.Size(194, 21)
        Me.PanelTXT.TabIndex = 4
        '
        'PanelBorder
        '
        Me.PanelBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelBorder.Controls.Add(Me.PanelEnvolveTXT)
        Me.PanelBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder.Name = "PanelBorder"
        Me.PanelBorder.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder.Size = New System.Drawing.Size(194, 21)
        Me.PanelBorder.TabIndex = 2
        '
        'PanelEnvolveTXT
        '
        Me.PanelEnvolveTXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelEnvolveTXT.Controls.Add(Me.TXTBox)
        Me.PanelEnvolveTXT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolveTXT.Location = New System.Drawing.Point(1, 1)
        Me.PanelEnvolveTXT.Name = "PanelEnvolveTXT"
        Me.PanelEnvolveTXT.Padding = New System.Windows.Forms.Padding(8, 4, 2, 2)
        Me.PanelEnvolveTXT.Size = New System.Drawing.Size(192, 19)
        Me.PanelEnvolveTXT.TabIndex = 0
        '
        'TXTBox
        '
        Me.TXTBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTBox.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTBox.Location = New System.Drawing.Point(8, 4)
        Me.TXTBox.Name = "TXTBox"
        Me.TXTBox.Size = New System.Drawing.Size(182, 13)
        Me.TXTBox.TabIndex = 0
        '
        'Control_TextBoxPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelTXT)
        Me.Name = "Control_TextBoxPerson"
        Me.Size = New System.Drawing.Size(194, 150)
        Me.PanelTXT.ResumeLayout(False)
        Me.PanelBorder.ResumeLayout(False)
        Me.PanelEnvolveTXT.ResumeLayout(False)
        Me.PanelEnvolveTXT.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTXT As Panel
    Friend WithEvents PanelBorder As Panel
    Friend WithEvents PanelEnvolveTXT As Panel
    Friend WithEvents TXTBox As TextBox
End Class
