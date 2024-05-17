<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formmenuadmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formmenuadmin))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbokodebarang = New System.Windows.Forms.ComboBox()
        Me.BukaGambar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pcgambar = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pcgambar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(735, 112)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(449, 282)
        Me.DataGridView1.TabIndex = 85
        '
        'cbokodebarang
        '
        Me.cbokodebarang.BackColor = System.Drawing.Color.White
        Me.cbokodebarang.ForeColor = System.Drawing.Color.Black
        Me.cbokodebarang.FormattingEnabled = True
        Me.cbokodebarang.Items.AddRange(New Object() {"PRODUK 1", "PRODUK 2", "PRODUK 3", "PRODUK 4", "PRODUK 5", "PRODUK 6"})
        Me.cbokodebarang.Location = New System.Drawing.Point(352, 123)
        Me.cbokodebarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbokodebarang.Name = "cbokodebarang"
        Me.cbokodebarang.Size = New System.Drawing.Size(256, 24)
        Me.cbokodebarang.TabIndex = 83
        '
        'BukaGambar
        '
        Me.BukaGambar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BukaGambar.Font = New System.Drawing.Font("Goudy Stout", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BukaGambar.ForeColor = System.Drawing.Color.White
        Me.BukaGambar.Location = New System.Drawing.Point(146, 395)
        Me.BukaGambar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BukaGambar.Name = "BukaGambar"
        Me.BukaGambar.Size = New System.Drawing.Size(150, 63)
        Me.BukaGambar.TabIndex = 82
        Me.BukaGambar.Text = "Buka Gambar"
        Me.BukaGambar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'pcgambar
        '
        Me.pcgambar.BackColor = System.Drawing.Color.White
        Me.pcgambar.Location = New System.Drawing.Point(412, 334)
        Me.pcgambar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcgambar.Name = "pcgambar"
        Me.pcgambar.Size = New System.Drawing.Size(153, 124)
        Me.pcgambar.TabIndex = 81
        Me.pcgambar.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label5.Location = New System.Drawing.Point(87, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(284, 23)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "GAMBAR BARANG"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.IndianRed
        Me.lblname.Location = New System.Drawing.Point(558, 36)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(220, 39)
        Me.lblname.TabIndex = 79
        Me.lblname.Text = "USERNAME"
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnubah.Font = New System.Drawing.Font("Goudy Stout", 7.8!)
        Me.btnubah.ForeColor = System.Drawing.Color.White
        Me.btnubah.Location = New System.Drawing.Point(882, 439)
        Me.btnubah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(125, 46)
        Me.btnubah.TabIndex = 78
        Me.btnubah.Text = "UBAH"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'txtharga
        '
        Me.txtharga.BackColor = System.Drawing.Color.White
        Me.txtharga.Font = New System.Drawing.Font("Lucida Fax", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtharga.ForeColor = System.Drawing.Color.Black
        Me.txtharga.Location = New System.Drawing.Point(352, 275)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(256, 23)
        Me.txtharga.TabIndex = 77
        '
        'txtnamabarang
        '
        Me.txtnamabarang.BackColor = System.Drawing.Color.White
        Me.txtnamabarang.Font = New System.Drawing.Font("Lucida Fax", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtnamabarang.ForeColor = System.Drawing.Color.Black
        Me.txtnamabarang.Location = New System.Drawing.Point(352, 167)
        Me.txtnamabarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(256, 23)
        Me.txtnamabarang.TabIndex = 76
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.White
        Me.NumericUpDown1.Font = New System.Drawing.Font("Lucida Fax", 7.8!, System.Drawing.FontStyle.Bold)
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.Black
        Me.NumericUpDown1.Location = New System.Drawing.Point(352, 222)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(256, 23)
        Me.NumericUpDown1.TabIndex = 75
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btndelete.Font = New System.Drawing.Font("Goudy Stout", 7.8!)
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(1027, 439)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(123, 46)
        Me.btndelete.TabIndex = 74
        Me.btndelete.Text = "HAPUS"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnsimpan.Font = New System.Drawing.Font("Goudy Stout", 7.8!)
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(735, 439)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(125, 46)
        Me.btnsimpan.TabIndex = 73
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label6.Location = New System.Drawing.Point(87, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(261, 23)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "HARGA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(86, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 23)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "STOK BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(87, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 23)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "KODE BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Goudy Stout", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(87, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 23)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "NAMA BARANG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 38)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "ADMIN"
        '
        'Formmenuadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1196, 517)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbokodebarang)
        Me.Controls.Add(Me.BukaGambar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pcgambar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formmenuadmin"
        Me.Text = " "
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pcgambar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NumericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbokodebarang As System.Windows.Forms.ComboBox
    Friend WithEvents BukaGambar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pcgambar As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
