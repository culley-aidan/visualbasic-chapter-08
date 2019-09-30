' Program Name: Chef Shack Food Truck Depreciation Windows Application
' Author:       Aidan J Culley
' Date:         September 30th, 2019
' Purpose:      The Chef Shack Inventory Windows Application determines
'               the depreciation based on a 5 year life of items in inventory
'               using the straight-line and double-declining balance methods.

Option Strict On
Public Class frmDepreciation
    ' Class Level Private variables
    Private _intLifeOfItems As Integer = 5
    Public Shared _intSizeOfArray As Integer = 7
    Public Shared _strInventoryItem(_intSizeOfArray) As String
    Private _strItemId(_intSizeOfArray) As String
    Private _decInitialPrice(_intSizeOfArray) As Decimal
    Private _intQuantity(_intSizeOfArray) As Integer

End Class
