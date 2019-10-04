<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGames
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.cboSelectGame = New System.Windows.Forms.ComboBox()
        Me.lblDownloads = New System.Windows.Forms.Label()
        Me.lblGameDownloads = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(354, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Top selling video games"
        '
        'lstGames
        '
        Me.lstGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.ItemHeight = 24
        Me.lstGames.Location = New System.Drawing.Point(18, 76)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(348, 244)
        Me.lstGames.TabIndex = 1
        '
        'cboSelectGame
        '
        Me.cboSelectGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectGame.FormattingEnabled = True
        Me.cboSelectGame.Location = New System.Drawing.Point(440, 96)
        Me.cboSelectGame.Name = "cboSelectGame"
        Me.cboSelectGame.Size = New System.Drawing.Size(200, 32)
        Me.cboSelectGame.TabIndex = 2
        '
        'lblDownloads
        '
        Me.lblDownloads.AutoSize = True
        Me.lblDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloads.Location = New System.Drawing.Point(472, 57)
        Me.lblDownloads.Name = "lblDownloads"
        Me.lblDownloads.Size = New System.Drawing.Size(152, 24)
        Me.lblDownloads.TabIndex = 3
        Me.lblDownloads.Text = "Find Downloads "
        '
        'lblGameDownloads
        '
        Me.lblGameDownloads.AutoSize = True
        Me.lblGameDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameDownloads.Location = New System.Drawing.Point(450, 152)
        Me.lblGameDownloads.Name = "lblGameDownloads"
        Me.lblGameDownloads.Size = New System.Drawing.Size(174, 40)
        Me.lblGameDownloads.TabIndex = 4
        Me.lblGameDownloads.Text = "$GAME has had" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "$DOWNLOADS total"
        Me.lblGameDownloads.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calculate All Downloads"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 352)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblGameDownloads)
        Me.Controls.Add(Me.lblDownloads)
        Me.Controls.Add(Me.cboSelectGame)
        Me.Controls.Add(Me.lstGames)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmGames"
        Me.Text = "Most Popular Games Sold"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstGames As ListBox
    Friend WithEvents cboSelectGame As ComboBox
    Friend WithEvents lblDownloads As Label
    Friend WithEvents lblGameDownloads As Label
    Friend WithEvents Button1 As Button
End Class
