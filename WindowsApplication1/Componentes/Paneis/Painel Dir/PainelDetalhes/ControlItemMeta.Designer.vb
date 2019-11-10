<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlItemMeta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlItemMeta))
        Me.Panel270 = New System.Windows.Forms.Panel()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Button117 = New System.Windows.Forms.Button()
        Me.Panel270.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel270
        '
        Me.Panel270.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel270.Controls.Add(Me.TextBox25)
        Me.Panel270.Controls.Add(Me.Button117)
        Me.Panel270.Controls.Add(Me.Label103)
        Me.Panel270.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel270.Location = New System.Drawing.Point(0, 0)
        Me.Panel270.Name = "Panel270"
        Me.Panel270.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Panel270.Size = New System.Drawing.Size(511, 17)
        Me.Panel270.TabIndex = 1
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox25.ForeColor = System.Drawing.Color.Gainsboro
        Me.TextBox25.Location = New System.Drawing.Point(47, 1)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(434, 13)
        Me.TextBox25.TabIndex = 1
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
        Me.Label103.Padding = New System.Windows.Forms.Padding(2)
        Me.Label103.Size = New System.Drawing.Size(47, 17)
        Me.Label103.TabIndex = 0
        Me.Label103.Text = "Nome:"
        '
        'Button117
        '
        Me.Button117.AutoSize = True
        Me.Button117.BackColor = System.Drawing.Color.Transparent
        Me.Button117.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button117.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button117.FlatAppearance.BorderSize = 0
        Me.Button117.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button117.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button117.Image = CType(resources.GetObject("Button117.Image"), System.Drawing.Image)
        Me.Button117.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button117.Location = New System.Drawing.Point(481, 1)
        Me.Button117.Margin = New System.Windows.Forms.Padding(0)
        Me.Button117.Name = "Button117"
        Me.Button117.Size = New System.Drawing.Size(30, 16)
        Me.Button117.TabIndex = 22
        Me.Button117.UseVisualStyleBackColor = False
        '
        'ControlItemMeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel270)
        Me.Name = "ControlItemMeta"
        Me.Size = New System.Drawing.Size(511, 241)
        Me.Panel270.ResumeLayout(False)
        Me.Panel270.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel270 As Panel
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents Button117 As Button
    Friend WithEvents Label103 As Label
End Class
