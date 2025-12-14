' ===== CLASS UNTUK DATA PRODUK =====
Public Class Product
    ' ===== PROPERTIES (Variabel) =====
    Public Property ProductId As Integer
    Public Property ProductName As String
    Public Property Price As Decimal
    Public Property Quantity As Integer
    Public Property Category As ProductCategory
    Public Property Description As String

    ' ===== CONSTRUCTOR =====
    Public Sub New()
    End Sub

    ' ===== METHOD =====
    Public Overrides Function ToString() As String
        Return $"{ProductName} - Rp{Price:N0}"
    End Function
End Class