' Program Name: Smart Home Monthly Electric Savings
' Author:       Aidan J Culley
' Date:         October 2nd, 2019
' Purpose:      Displays items from a text file

Option Strict On
Public Class frmSmartHome
    Dim intSize As Integer = 11
    Dim strMonths(intSize) As String
    Dim decSavings(intSize) As Decimal
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
        End If
    End Sub
    Private Sub CboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        btnStatistics.Visible = True
    End Sub
    End Sub
End Class
