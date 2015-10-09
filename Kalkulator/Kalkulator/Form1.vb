Public Class Form1
    Dim Angka, Hasil As Double
    Dim Kalkulator As String

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub btnJumlah_Click(sender As Object, e As EventArgs) Handles btnJumlah.Click
        Angka = Val(TextBox1.Text)
        Kalkulator = "+"
        TextBox1.Text = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        Angka = Val(TextBox1.Text)
        Kalkulator = "-"
        TextBox1.Text = Nothing
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Angka = Val(TextBox1.Text)
        Kalkulator = "/"
        TextBox1.Text = Nothing
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Angka = Val(TextBox1.Text)
        Kalkulator = "*"
        TextBox1.Text = Nothing
    End Sub

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        If Kalkulator = "+" Then
            TextBox1.Text = Angka + Val(TextBox1.Text)
        ElseIf Kalkulator = "-" Then
            TextBox1.Text = Angka - Val(TextBox1.Text)
        ElseIf Kalkulator = "/" Then
            TextBox1.Text = Angka / Val(TextBox1.Text)
        ElseIf Kalkulator = "*" Then
            TextBox1.Text = Angka * Val(TextBox1.Text)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
    End Sub
End Class
