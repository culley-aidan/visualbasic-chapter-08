<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalDownloads
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
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.lblTotalDownloads = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGames
        '
        Me.lstGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.ItemHeight = 24
        Me.lstGames.Location = New System.Drawing.Point(12, 12)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(436, 244)
        Me.lstGames.TabIndex = 0
        '
        'lblTotalDownloads
        '
        Me.lblTotalDownloads.AutoSize = True
        Me.lblTotalDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDownloads.Location = New System.Drawing.Point(42, 273)
        Me.lblTotalDownloads.Name = "lblTotalDownloads"
        Me.lblTotalDownloads.Size = New System.Drawing.Size(354, 48)
        Me.lblTotalDownloads.TabIndex = 1
        Me.lblTotalDownloads.Text = "The total downloads of all 10 apps is:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$TOTAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTotalDownloads.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(164, 351)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(108, 36)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmTotalDownloads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 419)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblTotalDownloads)
        Me.Controls.Add(Me.lstGames)
        Me.Name = "frmTotalDownloads"
        Me.Text = "Total Downloads"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGames As ListBox
    Friend WithEvents lblTotalDownloads As Label
    Friend WithEvents btnReturn As Button
End Class
