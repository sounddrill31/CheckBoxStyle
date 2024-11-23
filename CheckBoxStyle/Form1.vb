Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Bold_CheckedChanged(sender As Object, e As EventArgs) Handles Bold.CheckedChanged
        If Bold.Checked Then
            StringEntered.Font = New Font(StringEntered.Font, StringEntered.Font.Style & FontStyle.Bold)
        Else
            StringEntered.Font = New Font(StringEntered.Font, StringEntered.Font.Style ^ FontStyle.Bold)
        End If
    End Sub

    Private Sub Italics_CheckedChanged(sender As Object, e As EventArgs) Handles Italics.CheckedChanged
        If Italics.Checked Then
            StringEntered.Font = New Font(StringEntered.Font, FontStyle.Italic)
        Else
            StringEntered.Font = New Font(StringEntered.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub Underline_CheckedChanged(sender As Object, e As EventArgs) Handles Underline.CheckedChanged
        If Underline.Checked Then
            StringEntered.Font = New Font(StringEntered.Font, FontStyle.Underline)
        Else
            StringEntered.Font = New Font(StringEntered.Font, FontStyle.Regular)
        End If
    End Sub
End Class
