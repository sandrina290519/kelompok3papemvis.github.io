Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Formmenuadmin
    Private Const connectionString As String = "server=localhost;userid=root;password=;database=dbtokoskincare"

    Private Sub Formmenuadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT kodebarang, namabarang, stokbarang, harga, gambar FROM tbbarangskincare"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Using adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    table.Columns.Add("Image", GetType(Image))

                    For Each row As DataRow In table.Rows
                        If Not IsDBNull(row("gambar")) Then
                            Dim gambarBytes As Byte() = CType(row("gambar"), Byte())
                            Using ms As New MemoryStream(gambarBytes)
                                row("Image") = Image.FromStream(ms)
                            End Using
                        End If
                    Next

                    DataGridView1.DataSource = table
                    DataGridView1.Columns("gambar").Visible = False

                    Dim imageColumn As New DataGridViewImageColumn()
                    imageColumn = CType(DataGridView1.Columns("Image"), DataGridViewImageColumn)
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom

                    DataGridView1.Columns("kodebarang").Width = 100
                    DataGridView1.Columns("namabarang").Width = 200
                    DataGridView1.Columns("stokbarang").Width = 100
                    DataGridView1.Columns("harga").Width = 100
                    DataGridView1.Columns("Image").Width = 150
                End Using
            End Using
        End Using
    End Sub

    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        ' Hanya bisa input angka
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            ' harga tidak boleh kosong
            If String.IsNullOrWhiteSpace(txtharga.Text) Then
                MessageBox.Show("Harga tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' input harga menjadi Decimal
            Dim harga As Decimal
            If Not Decimal.TryParse(txtharga.Text, harga) Then
                MessageBox.Show("Harga harus berupa angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' harga tidak boleh negatif
            If harga < 0 Then
                MessageBox.Show("Harga tidak boleh negatif.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not cbokodebarang.Items.Contains(cbokodebarang.Text) Then
                MessageBox.Show("Kode barang yang dipilih tidak valid.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If btnsimpan.Text = "Simpan" Then
                InsertRecord()
            Else
                UpdateRecord()
            End If

            txtnamabarang.Clear()
            pcgambar.Image = Nothing
            txtharga.Clear()
            cbokodebarang.SelectedIndex = -1


            btnsimpan.Text = "Simpan"


            LoadData()

            MessageBox.Show("Produk berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan. Pastikan semua input sudah diisi dengan benar." & vbCrLf & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertRecord()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim sql As String = "INSERT INTO tbbarangskincare (kodebarang, namabarang, stokbarang, harga, gambar) VALUES (@kodebarang, @namabarang, @stokbarang, @harga, @gambar)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kodebarang", cbokodebarang.Text)
                cmd.Parameters.AddWithValue("@namabarang", txtnamabarang.Text)
                cmd.Parameters.AddWithValue("@stokbarang", NumericUpDown1.Value)
                cmd.Parameters.AddWithValue("@harga", Decimal.Parse(txtharga.Text))

                Dim ms As New MemoryStream()
                pcgambar.Image.Save(ms, pcgambar.Image.RawFormat)
                Dim gambarBytes As Byte() = ms.ToArray()
                cmd.Parameters.AddWithValue("@gambar", gambarBytes)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub UpdateRecord()
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim kodebarang As String = selectedRow.Cells("kodebarang").Value.ToString()

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim sql As String = "UPDATE tbbarangskincare SET namabarang = @namabarang, stokbarang = @stokbarang, harga = @harga, gambar = @gambar WHERE kodebarang = @kodebarang"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@namabarang", txtnamabarang.Text)
                cmd.Parameters.AddWithValue("@stokbarang", NumericUpDown1.Value)
                cmd.Parameters.AddWithValue("@harga", Decimal.Parse(txtharga.Text))

                Dim ms As New MemoryStream()
                pcgambar.Image.Save(ms, pcgambar.Image.RawFormat)
                Dim gambarBytes As Byte() = ms.ToArray()
                cmd.Parameters.AddWithValue("@gambar", gambarBytes)

                cmd.Parameters.AddWithValue("@kodebarang", kodebarang)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim kodebarang As String = selectedRow.Cells("kodebarang").Value.ToString()
            Dim namabarang As String = selectedRow.Cells("namabarang").Value.ToString()
            Dim stokbarang As Integer = Convert.ToInt32(selectedRow.Cells("stokbarang").Value)
            Dim harga As Decimal = Convert.ToDecimal(selectedRow.Cells("harga").Value)

            cbokodebarang.Text = kodebarang
            txtnamabarang.Text = namabarang
            NumericUpDown1.Value = stokbarang
            txtharga.Text = harga.ToString()

            'mode pembaruan
            btnsimpan.Text = "Perbarui"
        Else
            MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaGambar_Click(sender As Object, e As EventArgs) Handles BukaGambar.Click

        Using openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            openFileDialog1.Title = "Pilih Gambar Produk"

            If openFileDialog1.ShowDialog() = DialogResult.OK Then

                pcgambar.Image = Image.FromFile(openFileDialog1.FileName)
            End If
        End Using
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmationResult = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim kodebarang As String = selectedRow.Cells("kodebarang").Value.ToString()

                Try
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()

                        Dim sql As String = "DELETE FROM tbbarangskincare WHERE kodebarang = @kodebarang"
                        Using cmd As New MySqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("@kodebarang", kodebarang)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Record deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()


                    cbokodebarang.SelectedIndex = -1
                    txtnamabarang.Clear()
                    NumericUpDown1.Value = 0
                    txtharga.Clear()
                    pcgambar.Image = Nothing
                    btnsimpan.Text = "Simpan"
                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Dim home As New Formhome()
        home.ShowDialog()
    End Sub
End Class
