Imports System.Collections.Generic

Public Class MainForm
    ' ===== VARIABEL MEMBER =====
    Private products As List(Of Product)
    Private orders As List(Of Order)

    ' ===== CONSTRUCTOR =====
    Public Sub New()
        InitializeComponent()
        InitializeData()
        LoadProducts()
    End Sub

    ' ===== FUNGSI INISIALISASI DATA =====
    Private Sub InitializeData()
        products = New List(Of Product)

        ' Produk 1
        Dim p1 As New Product()
        p1.ProductId = 1
        p1.ProductName = "Laptop Dell XPS"
        p1.Price = 15000000D
        p1.Quantity = 10
        p1.Category = ProductCategory.Electronics
        p1.Description = "Laptop gaming berperforma tinggi"
        products.Add(p1)

        ' Produk 2
        Dim p2 As New Product()
        p2.ProductId = 2
        p2.ProductName = "T-Shirt Cotton Premium"
        p2.Price = 250000D
        p2.Quantity = 50
        p2.Category = ProductCategory.Clothing
        p2.Description = "Kaos katun 100%"
        products.Add(p2)

        ' Produk 3
        Dim p3 As New Product()
        p3.ProductId = 3
        p3.ProductName = "Novel Laskar Pelangi"
        p3.Price = 85000D
        p3.Quantity = 100
        p3.Category = ProductCategory.Books
        p3.Description = "Novel karya Andrea Hirata"
        products.Add(p3)

        orders = New List(Of Order)
    End Sub

    ' ===== FUNGSI LOAD PRODUK =====
    Private Sub LoadProducts()
        dgvProducts.DataSource = Nothing
        dgvProducts.DataSource = products
    End Sub

    ' ===== EVENT HANDLER - MENU EXIT =====
    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim addForm As New AddProductForm()
        Dim result As DialogResult = addForm.ShowDialog()

        If result = DialogResult.OK Then
            Dim newProduct As Product = addForm.NewProduct
            products.Add(newProduct)
            LoadProducts()

            MessageBox.Show("Produk berhasil ditambahkan!",
            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ===== EVENT HANDLER - BUTTON LIHAT PESANAN =====
    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        Dim orderForm As New OrderForm(products, orders)
        orderForm.ShowDialog()
    End Sub
End Class