<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
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
        Me.mnuDepreciation = New System.Windows.Forms.MenuStrip()
        Me.SuspendLayout()
        '
        'mnuDepreciation
        '
        Me.mnuDepreciation.Location = New System.Drawing.Point(0, 0)
        Me.mnuDepreciation.Name = "mnuDepreciation"
        Me.mnuDepreciation.Size = New System.Drawing.Size(684, 24)
        Me.mnuDepreciation.TabIndex = 0
        Me.mnuDepreciation.Text = "MenuStrip1"
        '
        'frmDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 431)
        Me.Controls.Add(Me.mnuDepreciation)
        Me.MainMenuStrip = Me.mnuDepreciation
        Me.Name = "frmDepreciation"
        Me.Text = "Compute Depreciation by Method"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuDepreciation As MenuStrip
End Class
