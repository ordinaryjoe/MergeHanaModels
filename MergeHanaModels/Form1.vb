Public Class Form1
    Private Function GetFile()
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFilePath As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFilePath = fd.FileName
            'lblSource.Text = strSourceFile
        End If

        Return strFilePath

    End Function

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        'Dim inputString As String = "This is more text right here."
        'My.Computer.FileSystem.WriteAllText(
        '"C:\Temp\filetest//testfile.txt", inputString, True)

        lblSource.Text = GetFile()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTarget.Click

        lblTarget.Text = GetFile()

    End Sub
End Class
