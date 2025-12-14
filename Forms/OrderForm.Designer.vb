<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.grpSelectProduct = New System.Windows.Forms.GroupBox()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.nudOrderQty = New System.Windows.Forms.NumericUpDown()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpCustomerInfo.SuspendLayout()
        Me.grpSelectProduct.SuspendLayout()
        CType(Me.nudOrderQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomerInfo
        '
        Me.grpCustomerInfo.Controls.Add(Me.txtCustomerName)
        Me.grpCustomerInfo.Controls.Add(Me.lblCustomerName)
        Me.grpCustomerInfo.Location = New System.Drawing.Point(20, 20)
        Me.grpCustomerInfo.Name = "grpCustomerInfo"
        Me.grpCustomerInfo.Size = New System.Drawing.Size(750, 100)
        Me.grpCustomerInfo.TabIndex = 0
        Me.grpCustomerInfo.TabStop = False
        Me.grpCustomerInfo.Text = "Informasi Pelanggan"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(10, 25)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(150, 25)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Nama Pelanggan:"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(170, 25)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(400, 25)
        Me.txtCustomerName.TabIndex = 1
        '
        'grpSelectProduct
        '
        Me.grpSelectProduct.Controls.Add(Me.btnAddToCart)
        Me.grpSelectProduct.Controls.Add(Me.nudOrderQty)
        Me.grpSelectProduct.Controls.Add(Me.lblQty)
        Me.grpSelectProduct.Controls.Add(Me.cmbProduct)
        Me.grpSelectProduct.Controls.Add(Me.lblProduct)
        Me.grpSelectProduct.Location = New System.Drawing.Point(20, 130)
        Me.grpSelectProduct.Name = "grpSelectProduct"
        Me.grpSelectProduct.Size = New System.Drawing.Size(750, 100)
        Me.grpSelectProduct.TabIndex = 1
        Me.grpSelectProduct.TabStop = False
        Me.grpSelectProduct.Text = "Pilih Produk dan Jumlah"
        '
        'lblProduct
        '
        Me.lblProduct.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(10, 25)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(100, 25)
        Me.lblProduct.TabIndex = 0
        Me.lblProduct.Text = "Produk:"
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbProduct
        '
        Me.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduct.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(120, 25)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(314, 26)
        Me.cmbProduct.TabIndex = 1
        '
        'lblQty
        '
        Me.lblQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(451, 26)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(50, 25)
        Me.lblQty.TabIndex = 2
        Me.lblQty.Text = "Qty:"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudOrderQty
        '
        Me.nudOrderQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudOrderQty.Location = New System.Drawing.Point(507, 25)
        Me.nudOrderQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudOrderQty.Name = "nudOrderQty"
        Me.nudOrderQty.Size = New System.Drawing.Size(80, 26)
        Me.nudOrderQty.TabIndex = 3
        Me.nudOrderQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.Location = New System.Drawing.Point(120, 64)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(214, 30)
        Me.btnAddToCart.TabIndex = 4
        Me.btnAddToCart.Text = "Tambah ke keranjang"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'dgvCart
        '
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Location = New System.Drawing.Point(20, 240)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.Size = New System.Drawing.Size(750, 150)
        Me.dgvCart.TabIndex = 2
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.txtTotalAmount)
        Me.grpPayment.Controls.Add(Me.lblTotalAmount)
        Me.grpPayment.Controls.Add(Me.cmbPaymentMethod)
        Me.grpPayment.Controls.Add(Me.lblPaymentMethod)
        Me.grpPayment.Location = New System.Drawing.Point(20, 400)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(750, 100)
        Me.grpPayment.TabIndex = 3
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Pembayaran dan Total"
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMethod.Location = New System.Drawing.Point(10, 25)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(183, 25)
        Me.lblPaymentMethod.TabIndex = 0
        Me.lblPaymentMethod.Text = "Metode Pembayaran:"
        Me.lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(189, 25)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(350, 26)
        Me.cmbPaymentMethod.TabIndex = 1
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(10, 60)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(150, 25)
        Me.lblTotalAmount.TabIndex = 2
        Me.lblTotalAmount.Text = "Total (Rp):"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(189, 64)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(350, 26)
        Me.txtTotalAmount.TabIndex = 3
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessOrder.Location = New System.Drawing.Point(170, 520)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(150, 40)
        Me.btnProcessOrder.TabIndex = 4
        Me.btnProcessOrder.Text = "Proses Pesanan"
        Me.btnProcessOrder.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(340, 520)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 658)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.dgvCart)
        Me.Controls.Add(Me.grpSelectProduct)
        Me.Controls.Add(Me.grpCustomerInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buat Pesanan Baru"
        Me.grpCustomerInfo.ResumeLayout(False)
        Me.grpCustomerInfo.PerformLayout()
        Me.grpSelectProduct.ResumeLayout(False)
        CType(Me.nudOrderQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCustomerInfo As GroupBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents grpSelectProduct As GroupBox
    Friend WithEvents lblProduct As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents nudOrderQty As NumericUpDown
    Friend WithEvents lblQty As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents btnProcessOrder As Button
    Friend WithEvents btnCancel As Button
End Class
