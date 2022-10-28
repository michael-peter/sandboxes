Public Class Form1

  Private Sub btnCalculate_Click(sender As Object, e As Event) Handles btnCalculate.Click


    Dim a As Double = TextBox1.Text
    Dim b As Double = TextBox2.Text
    Dim c As Double = TextBox3.Text
    Dim d As Double = (b * b) - (4 * a * c)
    Dim x As Double
    Dim x1 As Double
    Dim x2 As Double
    Dim real As Double
    Dim imag As Double
    Dim result As String


    Select Case True
      Case d > 0
        x1 = ((b * -1) + Math.Sqrt(d)) / (2 * a)
        x2 = ((b * -1) - Math.Sqrt(d)) / (2 * a)
        result = String.Format("x1: {0}, x2: {1}", x1, x2)
      Case d = 0
        x = (b * -1) / (2 * a)
        result = String.Format("x: {0}", x)
      Case Else
        real = (b * -1) / (2 * a)
        imag = Math.Sqrt((d * -1)) / (2 * a)
        result = String.Format("real: {0}, imag: {1}", real, imag)
      End Select


    TextBox4.Text = result


  End Sub

End Class