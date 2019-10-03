<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplay
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.cboSort = New System.Windows.Forms.ComboBox()
        Me.lstSongs2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(355, 387)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(122, 51)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'cboSort
        '
        Me.cboSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSort.FormattingEnabled = True
        Me.cboSort.Items.AddRange(New Object() {"None", "Sorted"})
        Me.cboSort.Location = New System.Drawing.Point(340, 12)
        Me.cboSort.Name = "cboSort"
        Me.cboSort.Size = New System.Drawing.Size(148, 32)
        Me.cboSort.TabIndex = 1
        Me.cboSort.Text = "Order Songs"
        '
        'lstSongs2
        '
        Me.lstSongs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSongs2.FormattingEnabled = True
        Me.lstSongs2.ItemHeight = 24
        Me.lstSongs2.Location = New System.Drawing.Point(226, 65)
        Me.lstSongs2.Name = "lstSongs2"
        Me.lstSongs2.Size = New System.Drawing.Size(379, 316)
        Me.lstSongs2.TabIndex = 2
        '
        'frmDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstSongs2)
        Me.Controls.Add(Me.cboSort)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "frmDisplay"
        Me.Text = "Display Song Set"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents cboSort As ComboBox
    Friend WithEvents lstSongs2 As ListBox
End Class
