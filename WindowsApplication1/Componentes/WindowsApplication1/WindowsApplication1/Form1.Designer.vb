<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.outerPanel = New System.Windows.Forms.Panel()
        Me.InnerPanel = New System.Windows.Forms.Panel()
        Me.outerPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'outerPanel
        '
        Me.outerPanel.AutoScroll = True
        Me.outerPanel.Controls.Add(Me.InnerPanel)
        Me.outerPanel.Location = New System.Drawing.Point(12, 12)
        Me.outerPanel.Name = "outerPanel"
        Me.outerPanel.Size = New System.Drawing.Size(260, 179)
        Me.outerPanel.TabIndex = 0
        '
        'InnerPanel
        '
        Me.InnerPanel.AutoSize = True
        Me.InnerPanel.Location = New System.Drawing.Point(3, 3)
        Me.InnerPanel.Name = "InnerPanel"
        Me.InnerPanel.Size = New System.Drawing.Size(154, 356)
        Me.InnerPanel.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.outerPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.outerPanel.ResumeLayout(False)
        Me.outerPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents outerPanel As Panel
    Friend WithEvents InnerPanel As Panel
End Class
