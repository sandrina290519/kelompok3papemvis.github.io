<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formbelanja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formbelanja))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.cbNamaBarang = New System.Windows.Forms.ComboBox()
        Me.dataGridViewBelanja = New System.Windows.Forms.DataGridView()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.lblTotalBelanja = New System.Windows.Forms.Label()
        Me.cbMetodePembayaran = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.dataGridViewBelanja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BELANJA "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(365, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(600, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTambah.Location = New System.Drawing.Point(427, 162)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(100, 43)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'cbNamaBarang
        '
        Me.cbNamaBarang.FormattingEnabled = True
        Me.cbNamaBarang.Location = New System.Drawing.Point(174, 114)
        Me.cbNamaBarang.Name = "cbNamaBarang"
        Me.cbNamaBarang.Size = New System.Drawing.Size(174, 24)
        Me.cbNamaBarang.TabIndex = 5
        '
        'dataGridViewBelanja
        '
        Me.dataGridViewBelanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewBelanja.Location = New System.Drawing.Point(40, 221)
        Me.dataGridViewBelanja.Name = "dataGridViewBelanja"
        Me.dataGridViewBelanja.RowTemplate.Height = 24
        Me.dataGridViewBelanja.Size = New System.Drawing.Size(700, 227)
        Me.dataGridViewBelanja.TabIndex = 6
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(427, 116)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(144, 22)
        Me.txtHarga.TabIndex = 7
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(668, 117)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(137, 22)
        Me.txtJumlah.TabIndex = 8
        '
        'lblTotalBelanja
        '
        Me.lblTotalBelanja.AutoSize = True
        Me.lblTotalBelanja.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBelanja.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBelanja.Location = New System.Drawing.Point(485, 464)
        Me.lblTotalBelanja.Name = "lblTotalBelanja"
        Me.lblTotalBelanja.Size = New System.Drawing.Size(168, 29)
        Me.lblTotalBelanja.TabIndex = 9
        Me.lblTotalBelanja.Text = "Total Belanja"
        '
        'cbMetodePembayaran
        '
        Me.cbMetodePembayaran.FormattingEnabled = True
        Me.cbMetodePembayaran.Location = New System.Drawing.Point(174, 172)
        Me.cbMetodePembayaran.Name = "cbMetodePembayaran"
        Me.cbMetodePembayaran.Size = New System.Drawing.Size(174, 24)
        Me.cbMetodePembayaran.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(43, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Opsi Pembayaran"
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCetak.Location = New System.Drawing.Point(632, 496)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(124, 42)
        Me.btnCetak.TabIndex = 12
        Me.btnCetak.Text = "CETAK STRUK"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(477, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 43)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 68
        Me.PictureBox7.TabStop = False
        '
        'Formbelanja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(821, 550)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbMetodePembayaran)
        Me.Controls.Add(Me.lblTotalBelanja)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.dataGridViewBelanja)
        Me.Controls.Add(Me.cbNamaBarang)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formbelanja"
        Me.Text = "Formpembayaran"
        CType(Me.dataGridViewBelanja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents cbNamaBarang As System.Windows.Forms.ComboBox
    Friend WithEvents dataGridViewBelanja As System.Windows.Forms.DataGridView
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalBelanja As System.Windows.Forms.Label
    Friend WithEvents cbMetodePembayaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
End Class
