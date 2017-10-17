Imports System.Xml

Public Class Form1
    Private Function GetFile()
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFilePath As String

        fd.Title = "Open File Dialog"
        'fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        'fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFilePath = fd.FileName
            Return strFilePath
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        lblSource.Text = GetFile()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTarget.Click
        lblTarget.Text = GetFile()

    End Sub

    Private Sub btnMerge_Click(sender As Object, e As EventArgs) Handles btnMerge.Click
        Dim strDataSource As String
        Dim strCalcViews As String
        Dim strLogicalMod As String
        Dim strLayout As String

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
            Dim tmpNod As XmlNode = xdFrom.ImportNode(nod, True)
            ' Append this temporary node to the end of the "to" document
            ' but inside the root element.
            'If nod.Name = "Datasources" Then
            '    strDataSource = nod.InnerXml
            'End If
            Select Case nod.Name
                Case "dataSources"
                    strDataSource = nod.InnerXml
                Case "calculationViews"
                    strCalcViews = nod.InnerXml
                Case "logicalModel"
                    strLogicalMod = nod.InnerXml
                Case "layout"
                    strLayout = nod.InnerXml
            End Select
            'xdTo.DocumentElement.AppendChild(tmpNod)
        Next nod

        For Each nod As XmlNode In xdTo.DocumentElement.ChildNodes
            ' Import the node to our "to" document.
            Dim tmpNod As XmlNode = xdTo.ImportNode(nod, True)
            Dim doc = New XmlDocument()
            Dim tmpDoc = New XmlDocument()
            'Dim newNod As XmlNode = doc.CreateNode(strDataSource, "ds", )
            ' Append this temporary node to the end of the "to" document
            ' but inside the root element.
            'If nod.Name = "Datasources" Then
            '    strDataSource = nod.InnerXml
            'End If
            Select Case nod.Name
                Case "dataSources"
                    tmpDoc.LoadXml(strDataSource)
                    xdTo.DocumentElement.AppendChild(tmpDoc)
                    'strDataSource = nod.InnerXml
                Case "calculationViews"
                    tmpDoc.LoadXml(strCalcViews)
                    xdTo.DocumentElement.AppendChild(tmpDoc)
                    'strCalcViews = nod.InnerXml
                Case "logicalModel"
                    tmpDoc.LoadXml(strLogicalMod)
                    xdTo.DocumentElement.AppendChild(tmpDoc)
                    'strLogicalMod = nod.InnerXml
                Case "layout"
                    tmpDoc.LoadXml(strLayout)
                    xdTo.DocumentElement.AppendChild(tmpDoc)
                    'strLayout = nod.InnerXml
            End Select
            'xdTo.DocumentElement.AppendChild(tmpNod)
        Next nod

        ' Save the "to" document with it's newly appended nodes.
        xdTo.Save("C:\temp\XmlTest.xml")
        MessageBox.Show("Done", "SuperCool App")

    End Sub
End Class
