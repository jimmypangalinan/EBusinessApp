Imports System.Collections.Generic

Public Class AddProductForm
    ' Properti untuk akses dari MainForm
    Public Property NewProduct As Product

    Public Sub New()
        InitializeComponent()
        LoadCategories()
    End Sub

    ' ===== FUNGSI LOAD KATEGORI =====
    Private Sub LoadCategories()
        Dim categories As String() = [Enum].GetNames(GetType(ProductCategory))
        cmbCategory.Items.AddRange(categories)
        If cmbCategory.Items.Count > 0 Then
            cmbCategory.SelectedIndex = 0
        End If
    End Sub

    ' ===== FUNGSI VALIDASI =====
    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MessageBox.Show("Nama produk tidak boleh kosong! ",
                "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductName.Focus()
            Return False
        End If

        If nudPrice.Value < AppConstants.MIN_PRODUCT_PRICE Then
            MessageBox.Show($"Harga minimal Rp{AppConstants.MIN_PRODUCT_PRICE:N0}! ",
                "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nudPrice.Focus()
            Return False
        End If

        If nudQuantity.Value <= 0 Then
            MessageBox.Show("Stok harus lebih dari 0!",
                "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nudQuantity.Focus()
            Return False
        End If

        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Pilih kategori! ",
                "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' ===== EVENT BUTTON SIMPAN =====
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInput() Then
            Return
        End If

        NewProduct = New Product()
        NewProduct.ProductId = New Random().Next(1000, 9999)
        NewProduct.ProductName = txtProductName.Text.Trim()
        NewProduct.Price = nudPrice.Value
        NewProduct.Quantity = CInt(nudQuantity.Value)
        NewProduct.Category = CType([Enum].Parse(GetType(ProductCategory), cmbCategory.SelectedItem.ToString()), ProductCategory)
        NewProduct.Description = txtDescription.Text.Trim()

        DialogResult = DialogResult.OK
        Close()
    End Sub

    ' ===== EVENT BUTTON BATAL =====
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class