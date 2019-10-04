Option Strict On
Public Class frmTotalDownloads
    Dim strGames() As String = {}
    Private Sub FrmTotalDownloads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalDownloads As Integer
        lblTotalDownloads.Text = "The total downloads of all 10 apps is:" & vbNewLine & "$TOTAL downloads"
        For Each strGame In frmGames.strGames
            Dim arrayIndex As Integer = Array.IndexOf(frmGames.strGames, strGame)
            totalDownloads += frmGames.intDownloads(arrayIndex)
            strGames = strGames.Concat({String.Format("{0}: {1}", strGame, frmGames.intDownloads(arrayIndex).ToString())}).ToArray()
        Next
        For Each strGame In strGames.OrderBy(Function(x) x).ToArray
            lstGames.Items.Add(strGame)
        Next
        lblTotalDownloads.Text = lblTotalDownloads.Text.Replace("$TOTAL", totalDownloads.ToString())
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmGames.Visible = True
        Hide()
    End Sub
End Class