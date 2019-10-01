' The frmDisplayInventory class is opened by frmDepreciation
' and displays the inventory file in sorted order

Option Strict On
Public Class frmDisplayInventory
    Private Sub FrmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' the frmDisplayInventory load event is a second form that 
        ' displays the sorted inventory items 

        Dim strItem As String

        ' Sorts the _strInventoryItem array 
        Array.Sort(frmDepreciation._strInventoryItem)

        ' Displays the _strInventoryItem array
        For Each strItem In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItem)
        Next
    End Sub
End Class