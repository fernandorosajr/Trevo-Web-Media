<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Control_AddressBar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_AddressBar))
        Me.PanelBorder = New System.Windows.Forms.Panel()
        Me.PanelBackgroundAddress = New System.Windows.Forms.Panel()
        Me.PanelAddress = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelRecebeControlesDePastas = New System.Windows.Forms.Panel()
        Me.Panel_EnvolveTXT = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BTNExpandir = New System.Windows.Forms.Button()
        Me.BTNExpandePrincipal = New System.Windows.Forms.Button()
        Me.BTNPrincipal = New System.Windows.Forms.Button()
        Me.PanelBorderReflesh = New System.Windows.Forms.Panel()
        Me.PanelBackgroundRefresh = New System.Windows.Forms.Panel()
        Me.BTNRefresh = New System.Windows.Forms.Button()
        Me.PanelBorder.SuspendLayout()
        Me.PanelBackgroundAddress.SuspendLayout()
        Me.PanelAddress.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_EnvolveTXT.SuspendLayout()
        Me.PanelBorderReflesh.SuspendLayout()
        Me.PanelBackgroundRefresh.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBorder
        '
        Me.PanelBorder.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelBorder.Controls.Add(Me.PanelBackgroundAddress)
        Me.PanelBorder.Controls.Add(Me.PanelBorderReflesh)
        Me.PanelBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder.Name = "PanelBorder"
        Me.PanelBorder.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder.Size = New System.Drawing.Size(677, 61)
        Me.PanelBorder.TabIndex = 18
        '
        'PanelBackgroundAddress
        '
        Me.PanelBackgroundAddress.BackColor = System.Drawing.Color.White
        Me.PanelBackgroundAddress.Controls.Add(Me.PanelAddress)
        Me.PanelBackgroundAddress.Controls.Add(Me.BTNExpandir)
        Me.PanelBackgroundAddress.Controls.Add(Me.BTNExpandePrincipal)
        Me.PanelBackgroundAddress.Controls.Add(Me.BTNPrincipal)
        Me.PanelBackgroundAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackgroundAddress.Location = New System.Drawing.Point(1, 1)
        Me.PanelBackgroundAddress.Name = "PanelBackgroundAddress"
        Me.PanelBackgroundAddress.Size = New System.Drawing.Size(647, 59)
        Me.PanelBackgroundAddress.TabIndex = 8
        '
        'PanelAddress
        '
        Me.PanelAddress.Controls.Add(Me.Panel1)
        Me.PanelAddress.Controls.Add(Me.Panel_EnvolveTXT)
        Me.PanelAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAddress.Location = New System.Drawing.Point(30, 0)
        Me.PanelAddress.Name = "PanelAddress"
        Me.PanelAddress.Size = New System.Drawing.Size(602, 59)
        Me.PanelAddress.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelRecebeControlesDePastas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 59)
        Me.Panel1.TabIndex = 10
        '
        'PanelRecebeControlesDePastas
        '
        Me.PanelRecebeControlesDePastas.AutoSize = True
        Me.PanelRecebeControlesDePastas.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelRecebeControlesDePastas.Location = New System.Drawing.Point(0, 0)
        Me.PanelRecebeControlesDePastas.Name = "PanelRecebeControlesDePastas"
        Me.PanelRecebeControlesDePastas.Size = New System.Drawing.Size(0, 59)
        Me.PanelRecebeControlesDePastas.TabIndex = 19
        '
        'Panel_EnvolveTXT
        '
        Me.Panel_EnvolveTXT.Controls.Add(Me.TextBox3)
        Me.Panel_EnvolveTXT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_EnvolveTXT.Location = New System.Drawing.Point(0, 0)
        Me.Panel_EnvolveTXT.Name = "Panel_EnvolveTXT"
        Me.Panel_EnvolveTXT.Size = New System.Drawing.Size(602, 59)
        Me.Panel_EnvolveTXT.TabIndex = 21
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox3.Location = New System.Drawing.Point(0, 0)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(602, 13)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "Pesquisar"
        '
        'BTNExpandir
        '
        Me.BTNExpandir.BackColor = System.Drawing.Color.White
        Me.BTNExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNExpandir.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTNExpandir.FlatAppearance.BorderSize = 0
        Me.BTNExpandir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BTNExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNExpandir.Image = CType(resources.GetObject("BTNExpandir.Image"), System.Drawing.Image)
        Me.BTNExpandir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNExpandir.Location = New System.Drawing.Point(632, 0)
        Me.BTNExpandir.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNExpandir.Name = "BTNExpandir"
        Me.BTNExpandir.Size = New System.Drawing.Size(15, 59)
        Me.BTNExpandir.TabIndex = 18
        Me.BTNExpandir.UseVisualStyleBackColor = False
        '
        'BTNExpandePrincipal
        '
        Me.BTNExpandePrincipal.BackColor = System.Drawing.Color.White
        Me.BTNExpandePrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNExpandePrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNExpandePrincipal.FlatAppearance.BorderSize = 0
        Me.BTNExpandePrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.BTNExpandePrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNExpandePrincipal.Image = CType(resources.GetObject("BTNExpandePrincipal.Image"), System.Drawing.Image)
        Me.BTNExpandePrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNExpandePrincipal.Location = New System.Drawing.Point(15, 0)
        Me.BTNExpandePrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNExpandePrincipal.Name = "BTNExpandePrincipal"
        Me.BTNExpandePrincipal.Size = New System.Drawing.Size(15, 59)
        Me.BTNExpandePrincipal.TabIndex = 16
        Me.BTNExpandePrincipal.UseVisualStyleBackColor = False
        '
        'BTNPrincipal
        '
        Me.BTNPrincipal.BackColor = System.Drawing.Color.White
        Me.BTNPrincipal.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.pasta_1
        Me.BTNPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNPrincipal.FlatAppearance.BorderSize = 0
        Me.BTNPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.BTNPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPrincipal.ImageKey = "(nenhum/a)"
        Me.BTNPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.BTNPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNPrincipal.Name = "BTNPrincipal"
        Me.BTNPrincipal.Size = New System.Drawing.Size(15, 59)
        Me.BTNPrincipal.TabIndex = 15
        Me.BTNPrincipal.UseVisualStyleBackColor = False
        '
        'PanelBorderReflesh
        '
        Me.PanelBorderReflesh.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelBorderReflesh.Controls.Add(Me.PanelBackgroundRefresh)
        Me.PanelBorderReflesh.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBorderReflesh.Location = New System.Drawing.Point(648, 1)
        Me.PanelBorderReflesh.Name = "PanelBorderReflesh"
        Me.PanelBorderReflesh.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.PanelBorderReflesh.Size = New System.Drawing.Size(28, 59)
        Me.PanelBorderReflesh.TabIndex = 21
        '
        'PanelBackgroundRefresh
        '
        Me.PanelBackgroundRefresh.BackColor = System.Drawing.Color.White
        Me.PanelBackgroundRefresh.Controls.Add(Me.BTNRefresh)
        Me.PanelBackgroundRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackgroundRefresh.Location = New System.Drawing.Point(1, 0)
        Me.PanelBackgroundRefresh.Name = "PanelBackgroundRefresh"
        Me.PanelBackgroundRefresh.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelBackgroundRefresh.Size = New System.Drawing.Size(27, 59)
        Me.PanelBackgroundRefresh.TabIndex = 8
        '
        'BTNRefresh
        '
        Me.BTNRefresh.BackColor = System.Drawing.Color.White
        Me.BTNRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTNRefresh.FlatAppearance.BorderSize = 0
        Me.BTNRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.BTNRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRefresh.Image = CType(resources.GetObject("BTNRefresh.Image"), System.Drawing.Image)
        Me.BTNRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNRefresh.Location = New System.Drawing.Point(3, 3)
        Me.BTNRefresh.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNRefresh.Name = "BTNRefresh"
        Me.BTNRefresh.Size = New System.Drawing.Size(21, 53)
        Me.BTNRefresh.TabIndex = 17
        Me.BTNRefresh.UseVisualStyleBackColor = False
        '
        'Control_AddressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelBorder)
        Me.Name = "Control_AddressBar"
        Me.Size = New System.Drawing.Size(677, 61)
        Me.PanelBorder.ResumeLayout(False)
        Me.PanelBackgroundAddress.ResumeLayout(False)
        Me.PanelAddress.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_EnvolveTXT.ResumeLayout(False)
        Me.Panel_EnvolveTXT.PerformLayout()
        Me.PanelBorderReflesh.ResumeLayout(False)
        Me.PanelBackgroundRefresh.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBorder As Panel
    Friend WithEvents PanelBackgroundAddress As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BTNExpandir As Button
    Friend WithEvents BTNExpandePrincipal As Button
    Friend WithEvents BTNPrincipal As Button
    Friend WithEvents PanelBorderReflesh As Panel
    Friend WithEvents PanelBackgroundRefresh As Panel
    Friend WithEvents BTNRefresh As Button
    Friend WithEvents Panel_EnvolveTXT As Panel
    Friend WithEvents PanelAddress As Panel
    Friend WithEvents PanelRecebeControlesDePastas As Panel
    Friend WithEvents Panel1 As Panel
End Class
