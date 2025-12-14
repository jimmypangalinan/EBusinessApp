Imports System.Collections.Generic
Imports System.Linq

Public Class OrderForm
    ' ===== VARIABEL MEMBER =====
    Private availableProducts As List(Of Product)
    Private orders As List(Of Order)
    Private cartItems As List(Of Product)
    Private subtotal As Decimal = 0

    ' ===== CONSTRUCTOR =====
    Public Sub New(products As List(Of Product), existingOrders As List(Of Order))
        InitializeComponent()
        availableProducts = products
        Me.orders = existingOrders
        cartItems = New List(Of Product)
        LoadProducts()
        LoadPaymentMethods()
    End Sub

    ' ===== FUNGSI LOAD PRODUK =====
    Private Sub LoadProducts()
        cmbProduct.DataSource = Nothing
        cmbProduct.DataSource = New List(Of Product)(availableProducts)
        cmbProduct.DisplayMember = "ProductName"
        cmbProduct.ValueMember = "ProductId"
    End Sub

    ' ===== FUNGSI LOAD METODE PEMBAYARAN =====
    Private Sub LoadPaymentMethods()
        Dim paymentMethods As String() = [Enum].GetNames(GetType(PaymentMethod))
        cmbPaymentMethod.Items.AddRange(paymentMethods)
        If cmbPaymentMethod.Items.Count > 0 Then
            cmbPaymentMethod.SelectedIndex = 0
        End If
    End Sub

    ' ===== EVENT HANDLER:  PRODUK DIPILIH =====
    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        Dim selectedProduct As Product = CType(cmbProduct.SelectedItem, Product)
        If selectedProduct IsNot Nothing Then
            nudOrderQty.Maximum = selectedProduct.Quantity
            nudOrderQty.Value = 1
        End If
    End Sub

    ' ===== EVENT HANDLER:  TAMBAH KE KERANJANG =====
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If cmbProduct.SelectedItem Is Nothing Then
            MessageBox.Show("Pilih produk terlebih dahulu! ",
                "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedProduct As Product = CType(cmbProduct.SelectedItem, Product)
        Dim orderQty As Integer = CInt(nudOrderQty.Value)

        ' ===== OPERATOR ARITMATIKA:  Perbandingan (>) =====
        If orderQty > selectedProduct.Quantity Then
            MessageBox.Show("Stok tidak cukup! ",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Buat item untuk keranjang
        Dim cartItem As New Product()
        cartItem.ProductId = selectedProduct.ProductId
        cartItem.ProductName = selectedProduct.ProductName
        cartItem.Price = selectedProduct.Price
        cartItem.Quantity = orderQty
        cartItem.Category = selectedProduct.Category

        ' Tambahkan ke keranjang
        cartItems.Add(cartItem)

        ' Refresh DataGridView
        dgvCart.DataSource = Nothing
        dgvCart.DataSource = cartItems

        ' Hitung total
        CalculateTotal()

        MessageBox.Show("Produk ditambahkan ke keranjang!",
            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ===== FUNGSI HITUNG TOTAL (OPERATOR ARITMATIKA) =====
    Private Sub CalculateTotal()
        ' STEP 1: HITUNG SUBTOTAL
        ' OPERATOR ARITMATIKA: Perkalian (*) dan Penjumlahan (+)
        subtotal = 0
        For Each item In cartItems
            ' Subtotal += (Harga × Jumlah)
            ' OPERATOR:  Perkalian (*)
            subtotal += item.Price * item.Quantity
        Next

        ' STEP 2: HITUNG PAJAK
        ' OPERATOR ARITMATIKA: Perkalian (*)
        ' Pajak = Subtotal × 10%
        Dim tax As Decimal = subtotal * AppConstants.TAX_RATE

        ' STEP 3: HITUNG DISKON
        ' OPERATOR ARITMATIKA: Perkalian (*)
        ' Diskon = Subtotal × 15%
        Dim discount As Decimal = subtotal * AppConstants.DISCOUNT_PERCENTAGE

        ' STEP 4: AMBIL BIAYA PENGIRIMAN
        Dim shipping As Decimal = AppConstants.SHIPPING_COST

        ' STEP 5: HITUNG TOTAL AKHIR
        ' OPERATOR ARITMATIKA: Penjumlahan (+) dan Pengurangan (-)
        ' Total = Subtotal + Pajak - Diskon + Pengiriman
        Dim totalAmount As Decimal = subtotal + tax - discount + shipping

        ' Tampilkan hasil
        txtTotalAmount.Text = totalAmount.ToString("N0")
    End Sub

    ' ===== EVENT HANDLER: PROSES PESANAN =====
    Private Sub btnProcessOrder_Click(sender As Object, e As EventArgs) Handles btnProcessOrder.Click
        ' ===== VALIDASI INPUT =====
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Nama pelanggan harus diisi!",
                "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Return
        End If

        If cartItems.Count = 0 Then
            MessageBox.Show("Keranjang belanja kosong!",
                "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbPaymentMethod.SelectedIndex = -1 Then
            MessageBox.Show("Pilih metode pembayaran! ",
                "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ===== BUAT PESANAN BARU =====
        Dim newOrder As New Order()
        newOrder.OrderId = New Random().Next(10000, 99999)
        newOrder.CustomerName = txtCustomerName.Text.Trim()
        newOrder.OrderDate = DateTime.Now

        ' Parse total dari TextBox
        Dim totalAmountParsed As Decimal = Decimal.Parse(
            txtTotalAmount.Text.Replace(".", "").Replace(",", "")
        )
        newOrder.TotalAmount = totalAmountParsed

        newOrder.Status = OrderStatus.Pending
        newOrder.PaymentMethod = CType([Enum].Parse(GetType(PaymentMethod), cmbPaymentMethod.SelectedItem.ToString()), PaymentMethod)
        newOrder.Items = New List(Of Product)(cartItems)

        ' ===== TAMBAH PESANAN KE LIST =====
        orders.Add(newOrder)

        ' ===== TAMPILKAN KONFIRMASI =====
        Dim message As String = $"Pesanan berhasil dibuat!" & vbCrLf & vbCrLf &
                                $"ID Pesanan: {newOrder.OrderId}" & vbCrLf &
                                $"Nama:  {newOrder.CustomerName}" & vbCrLf &
                                $"Total:  Rp{newOrder.TotalAmount:N0}" & vbCrLf &
                                $"Status:  {newOrder.Status}"

        MessageBox.Show(message, "Sukses",
            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Close()
    End Sub

    ' ===== EVENT HANDLER:  BUTTON BATAL =====
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class