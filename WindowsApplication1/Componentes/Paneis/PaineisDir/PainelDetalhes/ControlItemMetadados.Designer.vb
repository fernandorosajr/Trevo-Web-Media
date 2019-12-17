<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlItemMetadados
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel270 = New System.Windows.Forms.Panel()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.Button117 = New System.Windows.Forms.Button()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel270.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel270)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Panel1.Size = New System.Drawing.Size(514, 18)
        Me.Panel1.TabIndex = 2
        '
        'Panel270
        '
        Me.Panel270.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel270.Controls.Add(Me.TextBox25)
        Me.Panel270.Controls.Add(Me.Button117)
        Me.Panel270.Controls.Add(Me.Label103)
        Me.Panel270.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel270.Location = New System.Drawing.Point(0, 0)
        Me.Panel270.Name = "Panel270"
        Me.Panel270.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Panel270.Size = New System.Drawing.Size(514, 17)
        Me.Panel270.TabIndex = 2
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox25.ForeColor = System.Drawing.Color.Gainsboro
        Me.TextBox25.Location = New System.Drawing.Point(53, 1)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(438, 13)
        Me.TextBox25.TabIndex = 1
        '
        'Button117
        '
        Me.Button117.AutoSize = True
        Me.Button117.BackColor = System.Drawing.Color.Transparent
        Me.Button117.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.editar_item4
        Me.Button117.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button117.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button117.FlatAppearance.BorderSize = 0
        Me.Button117.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button117.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button117.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button117.Location = New System.Drawing.Point(491, 1)
        Me.Button117.Margin = New System.Windows.Forms.Padding(0)
        Me.Button117.Name = "Button117"
        Me.Button117.Size = New System.Drawing.Size(23, 16)
        Me.Button117.TabIndex = 22
        Me.Button117.UseVisualStyleBackColor = False
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label103.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label103.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label103.Location = New System.Drawing.Point(0, 1)
        Me.Label103.Name = "Label103"
        Me.Label103.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label103.Size = New System.Drawing.Size(53, 13)
        Me.Label103.TabIndex = 0
        Me.Label103.Text = "Nome:"
        '
        'ControlItemMetadados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ControlItemMetadados"
        Me.Size = New System.Drawing.Size(514, 241)
        Me.Panel1.ResumeLayout(False)
        Me.Panel270.ResumeLayout(False)
        Me.Panel270.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel270 As Panel
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents Button117 As Button
    Friend WithEvents Label103 As Label
End Class
