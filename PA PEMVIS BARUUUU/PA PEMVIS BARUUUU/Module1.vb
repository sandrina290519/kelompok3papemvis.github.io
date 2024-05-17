Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Module Module1
    Public CONN As MySqlConnection
    Public STR As String = "server=localhost;userid=root;password=;database=dbtokoskincare"

    Public Function Koneksi() As MySqlConnection
        CONN = New MySqlConnection(STR)
        Try
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi database gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return CONN ' Mengembalikan objek koneksi
    End Function

    Public Sub TutupKoneksi()
        If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
            CONN.Close()
            CONN.Dispose()
        End If
    End Sub
End Module
