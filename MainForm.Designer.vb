<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnViewOrders = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(961, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductsToolStripMenuItem, Me.ViewProductsToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(89, 27)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewOrderToolStripMenuItem, Me.ViewOrdersToolStripMenuItem})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(73, 27)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(57, 27)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddProductsToolStripMenuItem
        '
        Me.AddProductsToolStripMenuItem.Name = "AddProductsToolStripMenuItem"
        Me.AddProductsToolStripMenuItem.Size = New System.Drawing.Size(188, 28)
        Me.AddProductsToolStripMenuItem.Text = "Add Products"
        '
        'ViewProductsToolStripMenuItem
        '
        Me.ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
        Me.ViewProductsToolStripMenuItem.Size = New System.Drawing.Size(188, 28)
        Me.ViewProductsToolStripMenuItem.Text = "View Products"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.NewOrderToolStripMenuItem.Text = "New Order"
        '
        'ViewOrdersToolStripMenuItem
        '
        Me.ViewOrdersToolStripMenuItem.Name = "ViewOrdersToolStripMenuItem"
        Me.ViewOrdersToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.ViewOrdersToolStripMenuItem.Text = "View Orders"
        '
        'mainPanel
        '
        Me.mainPanel.Controls.Add(Me.StatusStrip1)
        Me.mainPanel.Controls.Add(Me.dgvProducts)
        Me.mainPanel.Controls.Add(Me.btnViewOrders)
        Me.mainPanel.Controls.Add(Me.btnAddProduct)
        Me.mainPanel.Controls.Add(Me.lbTitle)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 31)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(961, 489)
        Me.mainPanel.TabIndex = 1
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(20, 20)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(307, 29)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "Sistem E-Business Toko Online"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(20, 70)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(150, 40)
        Me.btnAddProduct.TabIndex = 1
        Me.btnAddProduct.Text = "Tambah Produk"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnViewOrders
        '
        Me.btnViewOrders.Location = New System.Drawing.Point(180, 70)
        Me.btnViewOrders.Name = "btnViewOrders"
        Me.btnViewOrders.Size = New System.Drawing.Size(150, 40)
        Me.btnViewOrders.TabIndex = 2
        Me.btnViewOrders.Text = "Lihat Pesanan"
        Me.btnViewOrders.UseVisualStyleBackColor = True
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(20, 130)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(700, 300)
        Me.dgvProducts.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(961, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 520)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainPanel As Panel
    Friend WithEvents lbTitle As Label
    Friend WithEvents btnViewOrders As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents dgvProducts As DataGridView
End Class
