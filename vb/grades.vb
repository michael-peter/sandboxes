Public Class Form1

  Private Sub btnGrade_Click(sender As Object, e As Event) Handles btnGrade.Click


    Dim score As Double = TextBox1.Text
    Dim grade As String

    Select Case True
      Case score >= 70
        grade = "A"
      Case score >= 60
        grade = "B"
      Case score >= 50
        grade = "C"
      Case score >= 45
        grade = "D"
      Case score >= 40
        grade = "E"
      Case Else
        grade = "F"
      End Select

    TextBox2.Text = grade


  End Sub

End Class