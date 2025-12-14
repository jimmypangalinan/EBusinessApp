Public Enum OrderStatus
    Pending = 1         ' Menunggu
    Processing = 2     ' Dalam Proses
    Shipped = 3        ' Dikirim
    Delivered = 4      ' Diterima
    Cancelled = 5      ' Dibatalkan
End Enum

Public Enum ProductCategory
    Electronics = 1    ' Elektronik
    Clothing = 2       ' Pakaian
    Books = 3          ' Buku
    FoodBeverage = 4   ' Makanan & Minuman
    HomeGarden = 5     ' Rumah & Taman
End Enum

Public Enum PaymentMethod
    CreditCard = 1     ' Kartu Kredit
    BankTransfer = 2   ' Transfer Bank
    EWallet = 3        ' E-Wallet
    COD = 4            ' Cash On Delivery
End Enum