Imports MediSteadySystemSketching.medsDetails

Module SharedData
    Public favoriteItems As New List(Of ProductItem)
    Public cartItems As New List(Of CartItem)
    Public ordercount As Integer = 0
    Public currentusername As String

    ' Public order() As DataTable
    '  Dim I As Integer = 0 ' would + 1 for every order made
    ' Dim order.columns.add(I, "Order" & I)
    ' button to view order set selection mode to fullrowselect lepas tu transfer all the data again to order details, then tunjuk in a dgv
End Module
