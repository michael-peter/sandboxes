Public Class Form1

  Private Sub btnCalculate_Click(sender As Object, e As Event) Handles btnCalculate.Click

    Dim fullName, faculty, department, matricNum, year As String
    fullName = TextBox00.Text, faculty = TextBox01.Text, department = TextBox02.Text
    matricNum = TextBox03.Text, year = TextBox04.Text

    Dim score1, score2, score3, score4, score5, score6, score7, score8 As Double
    Dim unit1, unit2, unit3, unit4, unit5, unit6, unit7, unit8 As Double
    Dim grade1, grade2, grade3, grade4, grade5, grade6, grade7, grade8 As Double
    Dim grades, units, gpa As Double
    Dim result As String

    score1 = TextBox1.Text, score2 = TextBox2.Text, score3 = TextBox3.Text, score4 = TextBox4.Text
    score5 = TextBox5.Text, score6 = TextBox6.Text, score7 = TextBox7.Text, score8 = TextBox8.Text

    unit1 = TextBox9.Text, unit2 = TextBox10.Text, unit3 = TextBox11.Text, unit4 = TextBox12.Text
    unit5 = TextBox13.Text, unit6 = TextBox14.Text, unit7 = TextBox15.Text, unit8 = TextBox16.Text

    grade1 = getGrade(score1, unit1), grade2 = getGrade(score2, unit2), grade3 = getGrade(score3, unit3)
    grade4 = getGrade(score4, unit4), grade5 = getGrade(score5, unit5), grade6 = getGrade(score6, unit6)
    grade7 = getGrade(score7, unit7), grade8 = getGrade(score8, unit8)

    units = unit1 + unit2 + unit3 + unit4 + unit5 + unit6 + unit7 + unit8
    grades = grade1 + grade2 + grade3 + grade4 + grade5 + grade6 + grade7 + grade8

    gpa = grades / units

    result = "Name: {1}{0}Faculty: {2}{0}Department: {3}{0}Matric. Number: {4}{0}Year: {5}{0}GPA: {6}"
    result = String.Format(result, Environment.NewLine, fullName, faculty, department, matricNum, year, gpa)

    TextBox17.Text = result

  End Sub

  Function getGrade(score as Double, unit As Double) As Double
    Dim result As Double

    Select Case True
      Case score >= 70
        result = (5 * unit)
      Case score >= 60
        result = (4 * unit)
      Case score >= 50
        result = (3 * unit)
      Case score >= 45
        result = (2 * unit)
      Case score >= 40
        result = (1 * unit)
      Case Else
        result = (0 * unit)
    End Select

    Return result

  End Function

End Class