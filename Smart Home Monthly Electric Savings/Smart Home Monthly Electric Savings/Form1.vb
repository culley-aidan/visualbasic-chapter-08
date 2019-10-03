' Program Name: Smart Home Monthly Electric Savings
' Author:       Aidan J Culley
' Date:         October 2nd, 2019
' Purpose:      Displays items from a text file

Option Strict On
Public Class frmSmartHome
    Dim intSize As Integer = 11
    Dim strMonths(intSize) As String
    Dim decSavings(intSize) As Decimal
    Dim index As Integer
    Private Sub FrmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' declarations
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "..\\..\\savings.txt"
        Dim strFileError As String = "The file is not available. Restart when the file is available"
        Dim intCount As Integer = 0, intFill As Integer

        ' check stuff
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            Do While objReader.Peek <> -1
                strMonths(intCount) = objReader.ReadLine()
                decSavings(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()
            For intFill = 0 To (strMonths.GetLength(0) - 1)
                cboMonth.Items.Add(strMonths(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub
    Private Sub CboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        btnStatistics.Visible = True
        If cboMonth.SelectedIndex <> -1 Then
            index = cboMonth.SelectedIndex
        End If
    End Sub

    Private Sub BtnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        lblSavings.Text = String.Format("The electric savings for {0} is {1}", strMonths(index), decSavings(index).ToString("C"))
        Dim iterations As Integer = 0
        Dim totalSavings As Decimal
        Dim averageSavings As Decimal
        Do While iterations <> 12
            totalSavings += decSavings(iterations)
            iterations += 1
        Loop
        averageSavings = totalSavings / 12
        lblAverageSavings.Text = String.Format("The average monthly savings: {0}", averageSavings.ToString("C"))
        lblMostSavings.Text = String.Format("{0} had the most significant monthly savings", strMonths(Array.IndexOf(decSavings, decSavings.Max())))
        Houdini()
    End Sub
    Private Sub Houdini()
        ' makes things visible epic
        lblSavings.Visible = True
        lblAverageSavings.Visible = True
        lblMostSavings.Visible = True
    End Sub
End Class
