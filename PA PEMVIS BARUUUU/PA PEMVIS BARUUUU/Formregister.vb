Imports MySql.Data.MySqlClient
Public Class Formregister


    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Direct connection string
        Dim connectionString As String = "server=localhost;userid=root;password=;database=dbtokoskincare"

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO register (username, password, usertype) VALUES (@username, @password, 'user')"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim frm2 As New Formlogin()
                    frm2.Show()
                    Me.Hide()
                Catch ex As MySqlException
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Formlogin.Show()
        Me.Hide()
    End Sub

 
End Class