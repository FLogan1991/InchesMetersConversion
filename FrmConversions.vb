Imports System.Runtime.Remoting.Lifetime

Public Class frmConversions
    Dim vbMath As Integer
    Dim vbMathOut As Double
    Dim vbType As Integer
    Dim vbMathOutStr As Double
    Dim vbTextBoxUsr As Double

    Function MathConversion(x As Integer, Type As Integer)
        'Function created to complete the conversion
        'Type 2 is meter to inches conversion and type 1 is inches to meters conversion
        If Type = 1 Then
            vbMathOut = x * 0.0254
        ElseIf Type = 2 Then
            vbMathOut = x * 39.3701
        End If

        Return vbMathOut
    End Function

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'set dimension for the UserInput to get the textbox input
        Dim userInput As String = boxInput.Text

        'if statement performs a check of the userinput to ensure that letters are not used nor negative numbers are used
        'if they are used then a message box error will execute and will exit the subroutine
        If IsNumeric(userInput) = False Then
            MsgBox("Enter a positive number", , "Input Error")
            Exit Sub
        ElseIf Int(userInput) < 1 Then
            MsgBox("The measurement must be greater than 0", , "Input Error")
            Exit Sub
        End If

        'verifies if a radio button has been selected opens clear to ensure that the user selects the correct conversion type needed
        If radMeters.Checked = True Then
            vbType = 2
            vbMathOutStr = MathConversion(Int(boxInput.Text), vbType)
            lblConverted.Text = boxInput.Text & " meters is " & vbMathOutStr & " inches."
        ElseIf radInches.Checked = True Then
            vbType = 1
            vbMathOutStr = MathConversion(Int(boxInput.Text), vbType)
            lblConverted.Text = boxInput.Text & " inches is " & vbMathOutStr & " meters."
        Else
            MsgBox("Please choose a conversion type", , "Input Error")
            Exit Sub
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears the text from the forms
        lblConverted.Text = ""
        boxInput.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'button closes the program
        Me.Close()
    End Sub
End Class
