' Program Name: Dance Band
' Author:       Aidan J Culley
' Date:         October 3rd, 2019
' Purpose:      Displays songs from a text file
' Comment:      This entire program is a quick and dirty hack, 
'               you can't use the text file found at CengageBrain.com 
'               or change anything, I'm so sorry.

Option Strict On
Public Class frmDanceBand
    ' global declarations
    Public Shared intSize As Integer = 51
    Public Shared strSongName(intSize) As String
    Public Shared strGenre(intSize) As String
    Public Shared strTime(intSize) As String
    Public shared _genreList() As String
    Public Shared strSongs() As String
    Private Sub FrmDanceBand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' declarations
        Dim objReader As IO.StreamReader
        Dim strPath As String = "..\\..\\songs.txt"
        Dim strFileError As String = "The file is not available. Restart when the file is available"
        Dim intCount As Integer = 0, intFill As Integer

        ' check stuff
        If IO.File.Exists(strPath) Then
            objReader = IO.File.OpenText(strPath)
            Do While objReader.Peek <> -1
                strSongName(intCount) = objReader.ReadLine()
                strGenre(intCount) = objReader.ReadLine()
                strTime(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()
            _genreList = {strGenre(0), strGenre(1), strGenre(2), strGenre(3)}
            For intFill = 0 To (_genreList.Length - 1)
                cboGenre.Items.Add(_genreList(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub CboGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGenre.SelectedIndexChanged
        lstSongs.Items.Clear()
        For Each strSong In strSongName
            If strGenre(Array.IndexOf(strSongName, strSong)) = cboGenre.Items.Item(cboGenre.SelectedIndex).ToString() Then
                lstSongs.Items.Add(String.Format("{0} - {1}", strSong, strTime(Array.IndexOf(strSongName, strSong))))
            End If
        Next
        lstSongs.Visible = True
    End Sub

    Private Sub MnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        Dim frmSecond As New frmDisplay
        Hide()
        frmDisplay.ShowDialog()
    End Sub

    Private Sub MnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstSongs.Items.Clear()
        lstSongs.Visible = False
        cboGenre.Text = "Select Genre"
        cboGenre.SelectedIndex = -1
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
End Class
