Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputString As String = "This is more text right here."

        'My.Computer.FileSystem.WriteAllText(
        '"C:\Temp\filetest//testfile.txt", inputString, True)

        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strSourceFile As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strSourceFile = fd.FileName
            lblSource.Text = strSourceFile
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strTargetFile As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strTargetFile = fd.FileName
            lblTarget.Text = strTargetFile
        End If

    End Sub
End Class
