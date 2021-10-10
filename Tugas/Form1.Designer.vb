<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pelanggan = New System.Windows.Forms.Label()
        Me.nama_barang = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.Label()
        Me.diskon = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPelanggan = New System.Windows.Forms.TextBox()
        Me.txtBarang = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.Label()
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pelanggan
        '
        Me.pelanggan.AutoSize = True
        Me.pelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pelanggan.Location = New System.Drawing.Point(13, 23)
        Me.pelanggan.Name = "pelanggan"
        Me.pelanggan.Size = New System.Drawing.Size(103, 13)
        Me.pelanggan.TabIndex = 0
        Me.pelanggan.Text = "Nama Pelanggan"
        '
        'nama_barang
        '
        Me.nama_barang.AutoSize = True
        Me.nama_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_barang.Location = New System.Drawing.Point(13, 54)
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Size = New System.Drawing.Size(83, 13)
        Me.nama_barang.TabIndex = 1
        Me.nama_barang.Text = "Nama Barang"
        '
        'harga
        '
        Me.harga.AutoSize = True
        Me.harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.Location = New System.Drawing.Point(13, 84)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(41, 13)
        Me.harga.TabIndex = 2
        Me.harga.Text = "Harga"
        '
        'qty
        '
        Me.qty.AutoSize = True
        Me.qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty.Location = New System.Drawing.Point(13, 111)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(26, 13)
        Me.qty.TabIndex = 3
        Me.qty.Text = "Qty"
        '
        'jumlah
        '
        Me.jumlah.AutoSize = True
        Me.jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Location = New System.Drawing.Point(13, 139)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(84, 13)
        Me.jumlah.TabIndex = 4
        Me.jumlah.Text = "Jumlah Harga"
        '
        'diskon
        '
        Me.diskon.AutoSize = True
        Me.diskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diskon.Location = New System.Drawing.Point(13, 164)
        Me.diskon.Name = "diskon"
        Me.diskon.Size = New System.Drawing.Size(46, 13)
        Me.diskon.TabIndex = 5
        Me.diskon.Text = "Diskon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total Bayar"
        '
        'txtPelanggan
        '
        Me.txtPelanggan.Location = New System.Drawing.Point(123, 23)
        Me.txtPelanggan.Name = "txtPelanggan"
        Me.txtPelanggan.Size = New System.Drawing.Size(193, 20)
        Me.txtPelanggan.TabIndex = 7
        '
        'txtBarang
        '
        Me.txtBarang.Location = New System.Drawing.Point(123, 49)
        Me.txtBarang.Name = "txtBarang"
        Me.txtBarang.Size = New System.Drawing.Size(193, 20)
        Me.txtBarang.TabIndex = 8
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(123, 81)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(149, 20)
        Me.txtHarga.TabIndex = 9
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(123, 111)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(149, 20)
        Me.txtQty.TabIndex = 10
        '
        'txtJumlah
        '
        Me.txtJumlah.AutoSize = True
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(120, 139)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(14, 13)
        Me.txtJumlah.TabIndex = 11
        Me.txtJumlah.Text = "0"
        '
        'txtDiskon
        '
        Me.txtDiskon.Location = New System.Drawing.Point(123, 161)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(43, 20)
        Me.txtDiskon.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "%"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(120, 192)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(14, 13)
        Me.txtTotal.TabIndex = 14
        Me.txtTotal.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 239)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiskon)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtBarang)
        Me.Controls.Add(Me.txtPelanggan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.diskon)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.nama_barang)
        Me.Controls.Add(Me.pelanggan)
        Me.Name = "Form1"
        Me.Text = "Operator & Variabel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pelanggan As System.Windows.Forms.Label
    Friend WithEvents nama_barang As System.Windows.Forms.Label
    Friend WithEvents harga As System.Windows.Forms.Label
    Friend WithEvents qty As System.Windows.Forms.Label
    Friend WithEvents jumlah As System.Windows.Forms.Label
    Friend WithEvents diskon As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents txtBarang As System.Windows.Forms.TextBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.Label
    Friend WithEvents txtDiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label

End Class
