<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.nudPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductName
        '
        Me.lblProductName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(20, 20)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(150, 25)
        Me.lblProductName.TabIndex = 0
        Me.lblProductName.Text = "Nama Produk:"
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(180, 20)
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(350, 25)
        Me.txtProductName.TabIndex = 1
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(20, 60)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(150, 25)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Harga (Rp):"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudPrice
        '
        Me.nudPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPrice.Location = New System.Drawing.Point(180, 60)
        Me.nudPrice.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(350, 26)
        Me.nudPrice.TabIndex = 3
        '
        'lblQuantity
        '
        Me.lblQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(20, 100)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(150, 25)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Stok:"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudQuantity
        '
        Me.nudQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(180, 100)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(350, 26)
        Me.nudQuantity.TabIndex = 5
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCategory
        '
        Me.lblCategory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(20, 140)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(150, 25)
        Me.lblCategory.TabIndex = 6
        Me.lblCategory.Text = "Kategori:"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(180, 140)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(350, 25)
        Me.cmbCategory.TabIndex = 7
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(20, 180)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(100, 23)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Deskripsi:"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(180, 180)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(350, 100)
        Me.txtDescription.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(180, 300)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 40)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(350, 300)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Batal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 505)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.nudPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.lblProductName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tambah Produk Baru"
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProductName As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents lblQuantity As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
