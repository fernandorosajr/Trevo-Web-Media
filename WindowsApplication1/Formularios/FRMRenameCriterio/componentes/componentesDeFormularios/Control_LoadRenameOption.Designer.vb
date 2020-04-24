<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Control_LoadRenameOption
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
        Me.PanelBorder = New System.Windows.Forms.Panel()
        Me.Panel_LoadRenameOption = New System.Windows.Forms.Panel()
        Me.PanelBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBorder
        '
        Me.PanelBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelBorder.Controls.Add(Me.Panel_LoadRenameOption)
        Me.PanelBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder.Name = "PanelBorder"
        Me.PanelBorder.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder.Size = New System.Drawing.Size(311, 308)
        Me.PanelBorder.TabIndex = 112
        '
        'Panel_LoadRenameOption
        '
        Me.Panel_LoadRenameOption.AutoScroll = True
        Me.Panel_LoadRenameOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel_LoadRenameOption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_LoadRenameOption.Location = New System.Drawing.Point(1, 1)
        Me.Panel_LoadRenameOption.Name = "Panel_LoadRenameOption"
        Me.Panel_LoadRenameOption.Size = New System.Drawing.Size(309, 306)
        Me.Panel_LoadRenameOption.TabIndex = 9
        '
        'Control_LoadRenameOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelBorder)
        Me.Name = "Control_LoadRenameOption"
        Me.Size = New System.Drawing.Size(311, 308)
        Me.PanelBorder.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBorder As Panel
    Friend WithEvents Panel_LoadRenameOption As Panel
End Class
