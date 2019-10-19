<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlVerListas
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
        Me.FLPanelRecebe = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FLPanelRecebe
        '
        Me.FLPanelRecebe.AutoSize = True
        Me.FLPanelRecebe.Dock = System.Windows.Forms.DockStyle.Top
        Me.FLPanelRecebe.Location = New System.Drawing.Point(0, 0)
        Me.FLPanelRecebe.Margin = New System.Windows.Forms.Padding(0)
        Me.FLPanelRecebe.Name = "FLPanelRecebe"
        Me.FLPanelRecebe.Size = New System.Drawing.Size(288, 0)
        Me.FLPanelRecebe.TabIndex = 1
        '
        'ControlVerListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.Controls.Add(Me.FLPanelRecebe)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ControlVerListas"
        Me.Size = New System.Drawing.Size(288, 299)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FLPanelRecebe As FlowLayoutPanel
End Class
