﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHome
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
        Me.picSmartHome = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblAverageSavings = New System.Windows.Forms.Label()
        Me.lblMostSavings = New System.Windows.Forms.Label()
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSmartHome
        '
        Me.picSmartHome.Image = Global.Smart_Home_Monthly_Electric_Savings.My.Resources.Resources.smarthome
        Me.picSmartHome.Location = New System.Drawing.Point(0, 0)
        Me.picSmartHome.Name = "picSmartHome"
        Me.picSmartHome.Size = New System.Drawing.Size(253, 229)
        Me.picSmartHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmartHome.TabIndex = 0
        Me.picSmartHome.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(273, 49)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(240, 66)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cboMonth
        '
        Me.cboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(325, 144)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 32)
        Me.cboMonth.TabIndex = 2
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavings.Location = New System.Drawing.Point(89, 275)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(357, 20)
        Me.lblSavings.TabIndex = 3
        Me.lblSavings.Text = "The electric savings for xxxxxxxxx is $XX.XX"
        Me.lblSavings.Visible = False
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.SteelBlue
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.White
        Me.btnStatistics.Location = New System.Drawing.Point(181, 310)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(175, 41)
        Me.btnStatistics.TabIndex = 4
        Me.btnStatistics.Text = "Display Statistics "
        Me.btnStatistics.UseVisualStyleBackColor = False
        Me.btnStatistics.Visible = False
        '
        'lblAverageSavings
        '
        Me.lblAverageSavings.AutoSize = True
        Me.lblAverageSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSavings.Location = New System.Drawing.Point(106, 368)
        Me.lblAverageSavings.Name = "lblAverageSavings"
        Me.lblAverageSavings.Size = New System.Drawing.Size(313, 20)
        Me.lblAverageSavings.TabIndex = 5
        Me.lblAverageSavings.Text = "The average monthly savings: $XX.XX"
        Me.lblAverageSavings.Visible = False
        '
        'lblMostSavings
        '
        Me.lblMostSavings.AutoSize = True
        Me.lblMostSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostSavings.Location = New System.Drawing.Point(53, 405)
        Me.lblMostSavings.Name = "lblMostSavings"
        Me.lblMostSavings.Size = New System.Drawing.Size(410, 20)
        Me.lblMostSavings.TabIndex = 6
        Me.lblMostSavings.Text = "xxxxxxxxx had the most significant monthly savings"
        Me.lblMostSavings.Visible = False
        '
        'frmSmartHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(540, 450)
        Me.Controls.Add(Me.lblMostSavings)
        Me.Controls.Add(Me.lblAverageSavings)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picSmartHome)
        Me.Name = "frmSmartHome"
        Me.Text = "Smart Home Application"
        CType(Me.picSmartHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSmartHome As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents lblSavings As Label
    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblAverageSavings As Label
    Friend WithEvents lblMostSavings As Label
End Class
