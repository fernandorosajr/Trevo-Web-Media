<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPainel_Atividades
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel85 = New System.Windows.Forms.Panel()
        Me.Panel87 = New System.Windows.Forms.Panel()
        Me.PanelLoad_ControlInfor = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Panel85.SuspendLayout()
        Me.Panel87.SuspendLayout()
        Me.PanelLoad_ControlInfor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel85
        '
        Me.Panel85.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel85.Controls.Add(Me.Panel87)
        Me.Panel85.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel85.Location = New System.Drawing.Point(0, 0)
        Me.Panel85.Name = "Panel85"
        Me.Panel85.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel85.Size = New System.Drawing.Size(368, 519)
        Me.Panel85.TabIndex = 89
        '
        'Panel87
        '
        Me.Panel87.BackColor = System.Drawing.Color.Transparent
        Me.Panel87.Controls.Add(Me.PanelLoad_ControlInfor)
        Me.Panel87.Controls.Add(Me.Label110)
        Me.Panel87.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel87.Location = New System.Drawing.Point(3, 3)
        Me.Panel87.Name = "Panel87"
        Me.Panel87.Size = New System.Drawing.Size(362, 513)
        Me.Panel87.TabIndex = 3
        '
        'PanelLoad_ControlInfor
        '
        Me.PanelLoad_ControlInfor.AutoScroll = True
        Me.PanelLoad_ControlInfor.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelLoad_ControlInfor.Controls.Add(Me.Label29)
        Me.PanelLoad_ControlInfor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLoad_ControlInfor.Location = New System.Drawing.Point(0, 29)
        Me.PanelLoad_ControlInfor.Name = "PanelLoad_ControlInfor"
        Me.PanelLoad_ControlInfor.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.PanelLoad_ControlInfor.Size = New System.Drawing.Size(362, 484)
        Me.PanelLoad_ControlInfor.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Padding = New System.Windows.Forms.Padding(5)
        Me.Label29.Size = New System.Drawing.Size(354, 29)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "Semana Passada"
        '
        'Label110
        '
        Me.Label110.BackColor = System.Drawing.Color.Transparent
        Me.Label110.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label110.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label110.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label110.Location = New System.Drawing.Point(0, 0)
        Me.Label110.Name = "Label110"
        Me.Label110.Padding = New System.Windows.Forms.Padding(5)
        Me.Label110.Size = New System.Drawing.Size(362, 29)
        Me.Label110.TabIndex = 1
        Me.Label110.Text = "Hoje"
        '
        'ControlPainel_Atividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel85)
        Me.Name = "ControlPainel_Atividades"
        Me.Size = New System.Drawing.Size(368, 519)
        Me.Panel85.ResumeLayout(False)
        Me.Panel87.ResumeLayout(False)
        Me.PanelLoad_ControlInfor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel85 As Panel
    Friend WithEvents Panel87 As Panel
    Friend WithEvents PanelLoad_ControlInfor As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents Label110 As Label
End Class
