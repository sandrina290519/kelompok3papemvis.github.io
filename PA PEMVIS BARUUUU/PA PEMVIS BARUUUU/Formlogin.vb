Imports MySql.Data.MySqlClient
Public Class Formlogin
    Dim dr As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim conn As New MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Formregister As New Formregister()
        Formregister.Show()
        Me.Hide()
    End Sub



    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        conn.ConnectionString = "server=localhost;userid=root;password=;database=dbtokoskincare"

        Try
            conn.Open()
            Dim query As String
            query = "select * from register where username=@username and password=@password"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("username", txtuser.Text)
            cmd.Parameters.AddWithValue("password", txtpass.Text)
            dr = cmd.ExecuteReader

            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While

            ' Jika tidak ada hasil yang ditemukan
            If count = 0 Then
                MessageBox.Show("Username atau password yang Anda masukkan salah.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If count = 1 Then
                    Dim usertype = dr.GetString("usertype")
                    If usertype = "admin" Then
                        FormMenuAdmin.lblname.Text = dr("username").ToString
                        MsgBox("Selamat datang admin", MsgBoxStyle.Information, "Welcome")
                        Me.Hide()
                        FormMenuAdmin.ShowDialog() ' Tampilkan FormMenuAdmin sebagai dialog
                    Else
                        Me.Hide()
                        Formbelanja.ShowDialog()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Formhome.Show()
        Me.Hide()
    End Sub
End Class