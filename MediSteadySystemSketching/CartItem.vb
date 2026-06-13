Imports MediSteadySystemSketching.medsDetails

Public Class CartItem
    Public Property Product As ProductItem
    Public Property Quantity As Integer

    Public Sub New(product As ProductItem, quantity As Integer)
        Me.Product = product
        Me.Quantity = quantity
    End Sub

    Public Function GetTotalPrice() As Decimal
        Return Product.ProductPrice * Quantity
    End Function
End Class
