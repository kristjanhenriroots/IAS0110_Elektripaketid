Imports CSVExporterDNF

Public Class formExport
    ' Define properties to store times, prices, delimiter, text qualifier, and exporter object
    Public Property Times As List(Of DateTime)
    Public Property Prices As List(Of Double)
    Public Property Delimiter As String
    Public Property TextQualifier As String
    Public Shared FilePath As String = String.Empty

    Public Property Exporter As IExporter

    Private Sub formExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If the file path is empty, set the file path using the exporter
        If String.IsNullOrEmpty(FilePath) Then
            FilePath = Exporter.setFileToSave()
        End If
        ' Update the text box with the file path
        txtPath.Text = FilePath
    End Sub

    Private Sub btnChangePath_Click(sender As Object, e As EventArgs) Handles btnChangePath.Click
        ' Set the file path using the exporter
        FilePath = Exporter.setFileToSave()
        ' Update the text box with the new file path
        txtPath.Text = FilePath
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Set the delimiter, text qualifier, and file path from the form input
        Delimiter = txtSeparator.Text
        TextQualifier = txtQval.Text
        FilePath = txtPath.Text

        ' If the text qualifier is empty, set it to a space
        If String.IsNullOrEmpty(TextQualifier) Then
            TextQualifier = " "
            Console.WriteLine("yup empty")
        End If

        ' Combine the data into a single array
        Dim combinedData(Times.Count - 1, 2) As Object
        For i As Integer = 0 To Times.Count - 1
            combinedData(i, 0) = Times(i)
            combinedData(i, 1) = Prices(i) * 0.8
            combinedData(i, 2) = Prices(i)
        Next

        ' Set the exporter's delimiter and text qualifier properties
        Exporter.delimiter = Delimiter
        Exporter.textQualifier = TextQualifier

        ' Save the combined data to a CSV file using the exporter
        Exporter.saveDataToCsv(combinedData, Not cbOverwrite.Checked)

        ' Close the form
        Me.Close()
    End Sub
End Class
