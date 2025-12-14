Imports System.Collections.Generic

Public Class Order
    ' ===== PROPERTIES =====
    Public Property OrderId As Integer
    Public Property CustomerName As String
    Public Property CustomerEmail As String
    Public Property OrderDate As DateTime
    Public Property TotalAmount As Decimal
    Public Property Status As OrderStatus
    Public Property PaymentMethod As PaymentMethod
    Public Property Items As List(Of Product)

    ' ===== CONSTRUCTOR =====
    Public Sub New()
        Items = New List(Of Product)
        OrderDate = DateTime.Now
    End Sub

    ' ===== METHOD =====
    Public Overrides Function ToString() As String
        Return $"Order #{OrderId} - {CustomerName} - Rp{TotalAmount:N0}"
    End Function
End Class