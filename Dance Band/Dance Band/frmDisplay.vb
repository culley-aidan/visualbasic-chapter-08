Option Strict On
Public Class frmDisplay
    Private Sub CboSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSort.SelectedIndexChanged
        lstSongs2.Items.Clear()
        If cboSort.SelectedIndex = 0 Then
            For Each strSong In frmDanceBand.strSongName
                If frmDanceBand.strGenre(Array.IndexOf(frmDanceBand.strSongName, strSong)) = frmDanceBand.cboGenre.Items.Item(frmDanceBand.cboGenre.SelectedIndex).ToString() Then
                    lstSongs2.Items.Add(String.Format("{0} - {1}", strSong, frmDanceBand.strTime(Array.IndexOf(frmDanceBand.strSongName, strSong))))
                End If
            Next
        ElseIf cboSort.SelectedIndex = 1 Then
            Dim epic() As String = {}
            For Each strSong In frmDanceBand.strSongName
                If frmDanceBand.strGenre(Array.IndexOf(frmDanceBand.strSongName, strSong)) = frmDanceBand.cboGenre.Items.Item(frmDanceBand.cboGenre.SelectedIndex).ToString() Then
                    epic = epic.Concat({String.Format("{0} - {1}", strSong, frmDanceBand.strTime(Array.IndexOf(frmDanceBand.strSongName, strSong)))}).ToArray()
                End If
            Next
            Array.Sort(epic)
            For Each strSong In epic
                lstSongs2.Items.Add(strSong)
            Next
        End If
    End Sub
    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim frmFirst As New frmDanceBand
        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class