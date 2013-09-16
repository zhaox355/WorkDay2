Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String = txtFullName.Text
        'read the input from the user
        'display the result to thr user

        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")
        'extract the forst name
        Dim firstname As String

        firstname = fullnameTrimmed.Substring(0, idxSpace)
        txtFirstName.Text = firstname
    End Sub
End Class
