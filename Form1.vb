Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = TextBox1.Text
        Dim PortugueseChar() As String = {"ô", "Ô", "á", "Á", "ê", "Ê"}
        Dim Norskchar() As String = {"å", "Å", "æ", "Æ", "ø", "Ø"}
        Dim i As Integer = Nothing

        For i = 0 To UBound(PortugueseChar)
            s = Replace(s, PortugueseChar(i), Norskchar(i))
        Next

        TextBox2.Text = s

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub
End Class