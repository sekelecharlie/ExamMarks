Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim ExamScore As Decimal

        If IsNumeric(txtExamscore.Text) = True Then
            ExamScore = txtExamscore.Text
        Else
            MsgBox("That is not a Number!")
            Exit Sub
        End If

        If ExamScore < 0 Or ExamScore > 100 Then
            MsgBox("Invalid score")

        ElseIf ExamScore >= 50 And ExamScore < 75 Then
            MsgBox("Congratulation You have Passed With " & ExamScore & "%")

        ElseIf ExamScore >= 75 Then
            MsgBox("Wonderful You have Passed with Distiction " & ExamScore & "%")

        ElseIf ExamScore < 50 Then
            MsgBox("Sorry you Failed " & ExamScore & "%")

        End If


    End Sub


End Class
