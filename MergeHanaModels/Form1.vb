Imports System.Xml

Public Class Form1
    Private Function GetFile()
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFilePath As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        'fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFilePath = fd.FileName
            Return strFilePath
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        'Dim inputString As String = "This is more text right here."
        'My.Computer.FileSystem.WriteAllText(
        '"C:\Temp\filetest//testfile.txt", inputString, True)

        lblSource.Text = GetFile()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTarget.Click

        lblTarget.Text = GetFile()

    End Sub

    Private Sub btnMerge_Click(sender As Object, e As EventArgs) Handles btnMerge.Click
        ' The XmlDocument that we want to merge from.
        Dim xdFrom As New XmlDocument()
        'xdFrom.Load("C:\XmlTest2.xml")
        xdFrom.Load(lblSource.Text)

        ' The XMLDocument that we want to merge to.
        Dim xdTo As New XmlDocument()
        'xdTo.Load("C:\XmlTest.xml")
        xdTo.Load(lblTarget.Text)

        ' Loop through all of the nodes in the "from" document.
        ' We don't want to copy the root node in this instance.
        For Each nod As XmlNode In xdFrom.DocumentElement.ChildNodes
            ' Import the node to our "to" document.
            Dim tmpNod As XmlNode = xdTo.ImportNode(nod, True)
            ' Append this temporary node to the end of the "to" document
            ' but inside the root element.
            xdTo.DocumentElement.AppendChild(tmpNod)
        Next nod

        ' Save the "to" document with it's newly appended nodes.
        xdTo.Save("C:\temp\XmlTest.xml")
    End Sub
End Class
