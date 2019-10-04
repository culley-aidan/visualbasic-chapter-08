' Program Name: Most Popular Games Sold
' Author:       Aidan J Culley
' Date:         October 4th, 2019
' Purpose:      Display stuff

Option Strict On
Public Class frmGames
    Public Shared intSize As Integer = 9
    Public Shared strGames(intSize) As String
    Public Shared intDownloads(intSize) As Integer
    Dim frmSecond As New frmTotalDownloads
    Private Sub FrmGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load '
        frmTotalDownloads.Hide()
        ' loads stuff 
        Dim objReader As IO.StreamReader
        Dim strPath As String = "..\\..\\mobile.txt", strFileError As String = "The file is not available. Restart when the file is available"
        Dim intCount As Integer = 0, intFill As Integer

        If IO.File.Exists(strPath) Then
            objReader = IO.File.OpenText(strPath)
            Do While objReader.Peek <> -1
                strGames(intCount) = objReader.ReadLine()
                intDownloads(intCount) = Integer.Parse(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

            For intFill = 0 To (strGames.Length - 1)
                lstGames.Items.Add(strGames(intFill))
                cboSelectGame.Items.Add(strGames(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub CboSelectGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectGame.SelectedIndexChanged
        lblGameDownloads.Text = "$GAME" & vbNewLine & "has" & vbNewLine & "$DOWNLOADS downloads total"
        If cboSelectGame.SelectedIndex <> -1 Then
            lblGameDownloads.Text = lblGameDownloads.Text.Replace("$GAME", strGames(cboSelectGame.SelectedIndex)).Replace("$DOWNLOADS", intDownloads(cboSelectGame.SelectedIndex).ToString())
        End If
        lblGameDownloads.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        frmSecond.Visible = True
    End Sub
End Class
