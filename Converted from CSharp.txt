
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Xml
Imports System.Xml.Linq

Namespace ConsoleApplication1
	Class Program
		Const FILENAME As String = "c:\temp\test.xml"
		Private Shared Sub Main(args As String())
			Dim doc As XDocument = XDocument.Load(FILENAME)

			Dim parsedDataElements As List(Of XElement) = doc.Descendants("ParsedDataElement").ToList()

			For i As Integer = 0 To parsedDataElements.Count - 1 Step 2
				Dim newDataElement As New DataElement()
				DataElement.elements.Add(newDataElement)

				newDataElement.temperature = CDbl(parsedDataElements(i).Element("ConvertedValue"))
				newDataElement.light = CInt(parsedDataElements(i + 1).Element("ConvertedValue"))
			Next
		End Sub
	End Class
	Public Class DataElement
		Public Shared elements As New List(Of DataElement)()

		Public Property temperature() As Double
			Get
				Return m_temperature
			End Get
			Set
				m_temperature = Value
			End Set
		End Property
		Private m_temperature As Double
		Public Property light() As Integer
			Get
				Return m_light
			End Get
			Set
				m_light = Value
			End Set
		End Property
		Private m_light As Integer
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'=======================================================
