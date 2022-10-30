Public Class Form1

  Private Sub btnCalculate_Click(sender As Object, e As Event) Handles btnCalculate.Click

    Dim m, n as Double
    Dim side1, side2, hypotenuse as Double
    Dim result as String

    m = TextBox1.Text
    n = TextBox2.Text

    side1 = (m * m) - (n * n)
    side2 = 2 * (m * n)
    hypotenuse = (m * m ) + (n * n)

    result = "Side 1: {1}{0}Side 2: {2}{0}Hypotenuse: {3}"
    result = String.Format(result, Environment.NewLine, side1, side2, hypotenuse)

    TextBox3.Text = result


  End Sub

End Class