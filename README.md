# E-Business Application

Aplikasi E-Business Desktop menggunakan Visual Basic .NET Framework 4.7.2.

## 📋 Deskripsi

Aplikasi manajemen e-commerce dengan fitur: 
- Manajemen Produk
- Pembuatan Pesanan
- Perhitungan Otomatis (Pajak, Diskon, Ongkir)
- Validasi Input
- Message Box dan Dialog

## 🎯 Komponen yang Diimplementasikan

### Enumerations
- OrderStatus: Pending, Processing, Shipped, Delivered, Cancelled
- ProductCategory: Electronics, Clothing, Books, Food & Beverage, Home & Garden
- PaymentMethod: Credit Card, Bank Transfer, E-Wallet, COD

### Constants
- SHIPPING_COST: Rp50. 000
- TAX_RATE: 10%
- DISCOUNT_PERCENTAGE: 15%
- MIN_PRODUCT_PRICE: Rp10.000
- MAX_PRODUCT_QUANTITY: 1000

### Variables & Data Types
- products: List(Of Product)
- orders: List(Of Order)
- cartItems: List(Of Product)
- subtotal: Decimal

### Arithmetic Operators
- Perkalian (*): Harga × Jumlah
- Penjumlahan (+): Subtotal + Pajak + Pengiriman
- Pengurangan (-): Total - Diskon

### Controls
- *Common Controls*: Label, TextBox, Button, ComboBox, NumericUpDown, DataGridView
- *Container Controls*:  Panel, GroupBox, Form
- *Other*:  MenuStrip, StatusStrip

### Events
- Button Click Events
- Menu Events
- ComboBox Selection Changed
- Form Events

## 📁 Struktur Project
```
EBusinessApp/ 
  ├── Models/ 
  │ ├── Enumerations.vb 
  │ ├── Product.vb 
  │ └── Order.vb 
  ├── Utilities/ 
  │ └── AppConstants.vb 
  ├── Forms/ 
  │ ├── MainForm.vb 
  │ ├── AddProductForm.vb 
  │ └── OrderForm.vb 
  ├── Dialogs/ 
  └── Program.vb
```

## 🚀 Cara Menjalankan
1. Buka Project di Visual Studio
2. Build Solution (Ctrl+Alt+B)
3. Jalankan (F5)

## 📝 Fitur Utama
### 1. Tampilan Utama (MainForm)
- Menu bar (File, Products, Orders, Help)
- Button tambah produk
- Button lihat pesanan
- Tabel produk

### 2. Tambah Produk (AddProductForm)
- Input nama, harga, stok, kategori, deskripsi
- Validasi input
- Dialog form

### 3. Buat Pesanan (OrderForm)
- Pilih produk dan jumlah
- Keranjang belanja
- Perhitungan otomatis: 
  - Subtotal = Harga × Jumlah
  - Pajak = Subtotal × 10%
  - Diskon = Subtotal × 15%
  - Total = Subtotal + Pajak - Diskon + Pengiriman
- Pilih metode pembayaran
- Proses pesanan

## 💻 Teknologi
- *Bahasa*: Visual Basic .NET
- *Framework*: .NET Framework 4.7.2
- *Platform*: Windows Desktop
- *UI*: Windows Forms

## 📚 Mata Kuliah
Pemrograman Visual - UTS

## ✍️ Author
Jimmi Pangalinan
