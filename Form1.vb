Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LowerCase As String
        Dim UpperCase As String

        LowerCase = " Visual Basic"
        UpperCase = "Visual Basic"

        MsgBox(Microsoft.VisualBasic.LCase("Visual Basic"))
        MsgBox(Microsoft.VisualBasic.UCase("Visual Basic"))
    End Sub
End Class
