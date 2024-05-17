Imports MySql.Data.MySqlClient

Public Class Formulasan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String = TextBox1.Text
        Dim ulasan As String = TextBox2.Text

        ' harus mengisi semua kolom
        If String.IsNullOrWhiteSpace(nama) OrElse String.IsNullOrWhiteSpace(ulasan) Then
            MsgBox("Mohon isi semua kolom terlebih dahulu.")
            Return
        End If

        Try
            Using connection As New MySqlConnection(Module1.STR)
                connection.Open()
                Dim query As String = "INSERT INTO ulasan (nama, ulasan) VALUES (@nama, @ulasan)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@nama", nama)
                    command.Parameters.AddWithValue("@ulasan", ulasan)
                    command.ExecuteNonQuery()
                End Using
            End Using

            TampilkanUlasan()

            Label1.Text = "Terima kasih atas ulasan, " & nama & "!"
            TextBox1.Text = ""
            TextBox2.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Formulasan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanUlasan()
    End Sub

    Private Sub TampilkanUlasan()
        Try
            ListBox1.Items.Clear()

            Using connection As New MySqlConnection(Module1.STR)
                connection.Open()
                Dim query As String = "SELECT * FROM ulasan"
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Menambahkan setiap ulasan ke dalam ListBox
                            ListBox1.Items.Add("Nama: " & reader("nama").ToString() & ", Ulasan: " & reader("ulasan").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Formhome.Show()
        Me.Hide()
    End Sub
End Class
