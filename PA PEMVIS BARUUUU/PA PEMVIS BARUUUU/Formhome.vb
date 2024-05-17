Imports PA_PEMVIS_BARUUUU.Formlogin 
Public Class Formhome

    'untuk mendeklarasikan timer1
    Private directionRight As Boolean = True

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' untuk kecepatan animasi bergerak 
        If directionRight Then
            PictureBox1.Left += 5
            PictureBox3.Left += 5
            PictureBox4.Left += 5
            PictureBox10.Left += 5
            PictureBox11.Left += 5
        Else
            PictureBox1.Left -= 5
            PictureBox3.Left -= 5
            PictureBox4.Left -= 5
            PictureBox10.Left -= 5
            PictureBox11.Left -= 5
        End If

        ' untuk batas maximum bergerak, kalau mentok akan berubah arah
        If PictureBox1.Right >= Me.ClientSize.Width OrElse PictureBox1.Left <= 0 Then
            directionRight = Not directionRight
        End If
        If PictureBox3.Right >= Me.ClientSize.Width OrElse PictureBox3.Left <= 0 Then
            directionRight = Not directionRight
        End If
        If PictureBox4.Right >= Me.ClientSize.Width OrElse PictureBox4.Left <= 0 Then
            directionRight = Not directionRight
        End If
        If PictureBox10.Right >= Me.ClientSize.Width OrElse PictureBox10.Left <= 0 Then
            directionRight = Not directionRight
        End If
        If PictureBox11.Right >= Me.ClientSize.Width OrElse PictureBox11.Left <= 0 Then
            directionRight = Not directionRight
        End If
    End Sub


    Private Sub Formhome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim formmenuuser As New Formmenuuser()
        formmenuuser.Show()
    End Sub



    Private Sub btnadmin_Click(sender As Object, e As EventArgs)
        Dim Formmenuadmin As New Formmenuadmin()
        Formmenuadmin.Show()
    End Sub

    Private Sub btnuser_Click(sender As Object, e As EventArgs)
        Dim Formmenuuser As New Formmenuuser()
        Formmenuuser.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim whatsappurl As String = "https://www.whatsapp.com/?lang=id_ID"
        Process.Start(whatsappurl)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim instagramurl As String = "https://www.instagram.com/"
        Process.Start(instagramurl)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim facebookurl As String = "https://www.facebook.com/"
        Process.Start(facebookurl)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim xurl As String = "https://twitter.com/?lang=id"
        Process.Start(xurl)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Me.Hide()
        Dim Formulasan As New Formulasan()
        Formulasan.Show()
    End Sub

End Class
