Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Formmenuuser
    Private Const STR As String = "server=localhost;userid=root;password=;database=dbtokoskincare"

    Private HargaProdukValues As New Dictionary(Of String, String)()

    Private Sub Formmenuuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshLabel("PRODUK 1", Label2, "namabarang")
        RefreshLabel("PRODUK 2", Label4, "namabarang")
        RefreshLabel("PRODUK 3", Label6, "namabarang")
        RefreshLabel("PRODUK 4", Label9, "namabarang")
        RefreshLabel("PRODUK 5", Label11, "namabarang")
        RefreshLabel("PRODUK 6", Label13, "namabarang")
        RefreshLabel("PRODUK 1", Label8, "harga")
        RefreshLabel("PRODUK 2", Label3, "harga")
        RefreshLabel("PRODUK 3", Label5, "harga")
        RefreshLabel("PRODUK 4", Label7, "harga")
        RefreshLabel("PRODUK 5", Label10, "harga")
        RefreshLabel("PRODUK 6", Label12, "harga")
        RefreshLabel("PRODUK 1", PictureBox1, "gambar")
        RefreshLabel("PRODUK 2", PictureBox2, "gambar")
        RefreshLabel("PRODUK 3", PictureBox3, "gambar")
        RefreshLabel("PRODUK 4", PictureBox4, "gambar")
        RefreshLabel("PRODUK 5", PictureBox5, "gambar")
        RefreshLabel("PRODUK 6", PictureBox6, "gambar")
    End Sub

    Private Sub RefreshLabel(ByVal kodeBarang As String, ByVal control As Control, ByVal field As String)
        Try
            Using conn As New MySqlConnection(STR)
                conn.Open()

                Dim sql As String = "SELECT " & field & " FROM tbbarangskincare WHERE kodebarang = @kodeBarang"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.Add("@kodeBarang", MySqlDbType.VarChar).Value = kodeBarang

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If TypeOf control Is Label Then
                                DirectCast(control, Label).Text = reader(field).ToString()
                            ElseIf TypeOf control Is PictureBox Then
                                If Not IsDBNull(reader("gambar")) Then
                                    Dim gambarBytes As Byte() = CType(reader("gambar"), Byte())
                                    Using ms As New MemoryStream(gambarBytes)
                                        DirectCast(control, PictureBox).Image = Image.FromStream(ms)
                                    End Using
                                Else
                                    DirectCast(control, PictureBox).Image = Nothing
                                End If
                            End If
                            If field = "harga" Then
                                HargaProdukValues(kodeBarang) = reader(field).ToString()
                            End If
                        Else
                            If TypeOf control Is Label Then
                                DirectCast(control, Label).Text = "Barang tidak ada"
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengambil data dari database: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
        Dim home As New Formhome()
        home.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim login As New Formlogin()
        login.ShowDialog()
    End Sub
End Class
