'bagian tiara
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Formbelanja
    Private Const STR As String = "server=localhost;userid=root;password=;database=dbtokoskincare"
    Private WithEvents PrintDocument As New Printing.PrintDocument()

    Private Sub Formbelanja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New MySqlConnection(STR)
            Try
                conn.Open()

                Dim query As String = "SELECT namabarang FROM tbbarangskincare"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' untuk membaca data dari combo box
                        While reader.Read()
                            Dim namaBarang As String = reader("namabarang").ToString()
                            cbNamaBarang.Items.Add(namaBarang)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengambil data dari database: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' DataGridView
        dataGridViewBelanja.ColumnCount = 5
        dataGridViewBelanja.Columns(0).Name = "Nama Barang"
        dataGridViewBelanja.Columns(1).Name = "Harga"
        dataGridViewBelanja.Columns(2).Name = "Jumlah"
        dataGridViewBelanja.Columns(3).Name = "Total"
        dataGridViewBelanja.Columns(4).Name = "Metode Pembayaran"

        ' untuk menambah combox pembayaran
        cbMetodePembayaran.Items.Add("BRI 0166-01-020870-53-8")
        cbMetodePembayaran.Items.Add("Mandiri 111-33-0927425-9")
        cbMetodePembayaran.Items.Add("BCA 012-03-0927425-9")
        cbMetodePembayaran.Items.Add("BNI 456-34-0927425-176")
    End Sub

    Private Sub cbNamaBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNamaBarang.SelectedIndexChanged
        ' digunakan untuk jika input data kosong
        If cbNamaBarang.SelectedItem Is Nothing Then
            MessageBox.Show("Harap pilih barang terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' mengambi data harga dari data base untuk dimasukkan di combobox
        Dim selectedBarang As String = cbNamaBarang.SelectedItem.ToString()

        Using conn As New MySqlConnection(STR)
            Try
                conn.Open()

                Dim query As String = "SELECT harga FROM tbbarangskincare WHERE namabarang = @namabarang"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@namabarang", selectedBarang)

                    ' membaca hasilnya dari harga
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtHarga.Text = reader("harga").ToString()
                        Else
                            MessageBox.Show("Harga barang tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengambil data dari database: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' untuk mencek apakah semua data seudah terinput
        If Not String.IsNullOrEmpty(cbNamaBarang.Text) AndAlso
            Not String.IsNullOrEmpty(txtHarga.Text) AndAlso
            Not String.IsNullOrEmpty(txtJumlah.Text) AndAlso
            Not String.IsNullOrEmpty(cbMetodePembayaran.Text) Then

            ' mendeklarasikan agar mendapatkan hasil
            Dim namaBarang As String = cbNamaBarang.Text
            Dim harga As Decimal
            Dim jumlah As Integer

            If Decimal.TryParse(txtHarga.Text, harga) AndAlso Integer.TryParse(txtJumlah.Text, jumlah) Then
                ' untuk menghitung total harga
                Dim total As Decimal = harga * jumlah

                ' untuk menambahkan data ke DataGridView
                Dim row As String() = New String() {namaBarang, harga.ToString(), jumlah.ToString(), total.ToString(), cbMetodePembayaran.Text}
                dataGridViewBelanja.Rows.Add(row)

                ' Hitung total belanja
                HitungTotalBelanja()
            Else
                MessageBox.Show("Harga atau jumlah barang tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Harap isi semua bidang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dataGridViewBelanja_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewBelanja.CellValueChanged
        ' untuk menghitung total belanja saat ada perubahan jumlah barang
        If e.ColumnIndex = 2 Then
            HitungTotalBelanja()
        End If
    End Sub

    Private Function HitungTotalBelanja() As Decimal
        Dim totalBelanja As Decimal = 0

        For Each row As DataGridViewRow In dataGridViewBelanja.Rows
            ' untuk memastikan data yang diinput tidak kosong atau bukan baris baru
            If Not row.IsNewRow Then
                Dim harga As Decimal
                Dim jumlah As Integer

                ' memastikan data tidak kosong sebelum diproses
                If row.Cells(1).Value IsNot Nothing AndAlso row.Cells(2).Value IsNot Nothing AndAlso
                    Decimal.TryParse(row.Cells(1).Value.ToString(), harga) AndAlso
                    Integer.TryParse(row.Cells(2).Value.ToString(), jumlah) Then

                    Dim total As Decimal = harga * jumlah
                    row.Cells(3).Value = total.ToString("F2") ' Format ke 2 desimal
                    totalBelanja += total
                End If
            End If
        Next

        ' menampilkan total belanja di label 
        lblTotalBelanja.Text = "Total Belanja: " & totalBelanja.ToString("C2")

        Return totalBelanja ' Mengembalikan total belanja
    End Function


    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim fontTitle As New Font("Arial", 30, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 20)
        Dim headerBrush As New SolidBrush(Color.Black)
        Dim bodyBrush As New SolidBrush(Color.Black)
        Dim pen As New Pen(Color.Black)

        ' Menentukan koordinat dan lebar untuk judul, alamat, dan nomor telepon
        Dim titleX As Single = (e.PageBounds.Width - e.Graphics.MeasureString("STRUK SUBASIC BEAUTY'S", fontTitle).Width) / 2
        Dim titleY As Single = 20
        Dim addressX As Single = (e.PageBounds.Width - e.Graphics.MeasureString("Jl. Subasic No. 123", fontBody).Width) / 2
        Dim addressY As Single = titleY + fontTitle.GetHeight() + 5
        Dim phoneX As Single = (e.PageBounds.Width - e.Graphics.MeasureString("Telp: (123) 456-7890", fontBody).Width) / 2
        Dim phoneY As Single = addressY + fontBody.GetHeight() + 5

        Dim titleText As String = "STRUK SUBASIC BEAUTY'S"
        Dim addressText As String = "Jl. Subasic No. 123"
        Dim phoneText As String = "Telp: (123) 456-7890"

        ' Gambar judul, alamat, dan nomor telepon
        e.Graphics.DrawString(titleText, fontTitle, headerBrush, titleX, titleY)
        e.Graphics.DrawString(addressText, fontBody, bodyBrush, addressX, addressY)
        e.Graphics.DrawString(phoneText, fontBody, bodyBrush, phoneX, phoneY)

        ' Jarak antara judul/alama/nomor telepon dan tabel
        Dim tableY As Single = phoneY + fontBody.GetHeight() + 20

        '  membuatTabel
        Dim cellWidths As Single() = {200, 100, 100, 100, 200} ' Atur lebar kolom sesuai kebutuhan
        Dim xPos As Single = 20
        Dim yPos As Single = tableY
        Dim cellHeight As Single = fontBody.GetHeight() + 5

        Dim headers As String() = {"Nama Barang", "Harga", "Jumlah", "Total", "Metode Pembayaran"}

        ' Gambar header tabel
        For i As Integer = 0 To headers.Length - 1
            e.Graphics.DrawString(headers(i), fontBody, headerBrush, xPos, yPos)
            xPos += cellWidths(i)
        Next
        yPos += cellHeight

        ' Garis horizontal atas tabel
        e.Graphics.DrawLine(pen, 20, yPos, 550, yPos)

        ' Isi Tabel
        Dim totalBelanja As Decimal = 0
        For Each row As DataGridViewRow In dataGridViewBelanja.Rows
            If Not row.IsNewRow Then
                xPos = 20
                For i As Integer = 0 To headers.Length - 1
                    Dim cellValue As String = If(row.Cells(i).Value IsNot Nothing, row.Cells(i).Value.ToString(), "")
                    e.Graphics.DrawString(cellValue, fontBody, bodyBrush, xPos, yPos)
                    If i = 3 AndAlso Decimal.TryParse(cellValue, totalBelanja) Then
                        ' Jika ini adalah kolom total, tambahkan ke total belanja
                        totalBelanja += Decimal.Parse(cellValue)
                    End If
                    xPos += cellWidths(i)
                Next
                yPos += cellHeight
                ' Garis horizontal setiap baris tabel
                e.Graphics.DrawLine(pen, 20, yPos, 550, yPos)
            End If
        Next

        ' Garis vertikal di sepanjang kolom
        xPos = 20
        For i As Integer = 0 To headers.Length - 1
            e.Graphics.DrawLine(pen, xPos, tableY, xPos, yPos)
            xPos += cellWidths(i)
        Next

        ' Garis horizontal bawah tabel
        e.Graphics.DrawLine(pen, 20, yPos, 550, yPos)

        ' Tampilkan total belanja di tengah struk
        Dim totalBelanjaText As String = "Total Belanja: " & HitungTotalBelanja().ToString("C2") ' Hitung total belanja
        Dim totalX As Single = (e.PageBounds.Width - e.Graphics.MeasureString(totalBelanjaText, fontBody).Width) / 2
        e.Graphics.DrawString(totalBelanjaText, fontBody, bodyBrush, totalX, yPos + 20)
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim printDialog As New PrintDialog()

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument.PrinterSettings = printDialog.PrinterSettings
            PrintDocument.Print()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Formhome.Show()
        Me.Hide()
    End Sub
End Class
