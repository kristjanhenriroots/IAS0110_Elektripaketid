Imports CSVExporterDNF


Public Class formExport
    Public Property Times As List(Of DateTime)
    Public Property Prices As List(Of Double)
    Public Property Delimiter As String
    Public Property TextQualifier As String
    Public Shared FilePath As String = String.Empty

    Public Property Exporter As IExporter


    Private Sub formExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(FilePath) Then
            FilePath = Exporter.setFileToSave()
        End If
        txtPath.Text = FilePath
    End Sub


    Private Sub btnChangePath_Click(sender As Object, e As EventArgs) Handles btnChangePath.Click
        FilePath = Exporter.setFileToSave()
        txtPath.Text = FilePath
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Delimiter = txtSeparator.Text
        TextQualifier = txtQval.Text
        FilePath = txtPath.Text

        If String.IsNullOrEmpty(TextQualifier) Then
            TextQualifier = " "
            Console.WriteLine("yup empty")
        End If

        Dim combinedData(Times.Count - 1, 2) As Object
        For i As Integer = 0 To Times.Count - 1
            combinedData(i, 0) = Times(i)
            combinedData(i, 1) = Prices(i) * 0.8
            combinedData(i, 2) = Prices(i)
        Next

        Exporter.delimiter = Delimiter
        Exporter.textQualifier = TextQualifier

        Exporter.saveDataToCsv(combinedData, Not cbOverwrite.Checked)


        Me.Close()
    End Sub
End Class
