Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization
Imports AndmeParija.CAPIQuery
Imports AndmeParija.CDatabaseQuery

Public Class MainForm

    Dim chartMaker As New chartMaker()
    'combobox andmebaasi jaoks
    Private comboBoxTable As New DataTable

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Create HTTP client and set API key
            Dim client As New HttpClient()
            'client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_API_KEY")

            ' Set start and end times for 24-hour period
            Dim startTime As String = DateTime.Now.AddHours(-4).ToString("yyyy-MM-dd'T'HH:mm:ssZ")
            Dim endTime As String = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd'T'HH:mm:ssZ")

            ' Send GET request to Elering API
            Dim response As HttpResponseMessage = Await client.GetAsync($"https://dashboard.elering.ee/api/nps/price/csv?start={startTime}&end={endTime}&fields=ee")
            Dim content As Stream = Await response.Content.ReadAsStreamAsync()

            ' Parse CSV data and extract price data
            Dim times As New List(Of DateTime)()
            Dim prices As New List(Of Double)()
            Dim csvContent As New StringBuilder()
            Using reader As New StreamReader(content, Encoding.UTF8)
                ' Read header row
                csvContent.AppendLine(reader.ReadLine())

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    csvContent.AppendLine(line)
                    Dim values As String() = line.Split(";"c)

                    Dim dateValue As DateTime = DateTime.ParseExact(values(1).Trim(""""), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture)
                    Dim price As Double = Double.Parse(values(2).Trim("""").Replace(",", "."), CultureInfo.InvariantCulture)

                    ' Add dateValue to the times list and price to the prices list
                    times.Add(dateValue)
                    prices.Add(price)
                End While
            End Using
            ' Print out the times and prices lists
            For i As Integer = 0 To times.Count - 1
                Console.WriteLine($"Time: {times(i)}, Price: {prices(i)}")
            Next


            chartMaker.setChart(MainChart, times.ToArray(), prices.ToArray())
            AddHandler MainChart.MouseMove, AddressOf Chart_MouseMove

        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving data from the Elering API: " & ex.Message)
        End Try

        'Andmebaaside osa
        'Tabelite laadimine
        Dim updateBorsTable As AndmeParija.IAPIQuery 'Uue APi andmetepärimise komponendi tegemine
        updateBorsTable = New AndmeParija.CAPIQuery 'Klassi realiseerimine

        'Tehakse uuendus andmebaasile
        Try
            updateBorsTable.updateTable()
        Catch ex As Exception
            MessageBox.Show("Error updating data table.")
        End Try

        Dim loadComboBoxValues As AndmeParija.IDatabaseQuery 'Andmebaasi pärija tegemine
        loadComboBoxValues = New AndmeParija.CDatabaseQuery 'Klassi realiseerimine

        comboBoxTable = loadComboBoxValues.queryData("Select dateTime FROM bors WHERE rowid > 1 LIMIT 25") 'Päringu esitus. Võtab selle päeva ajavahemiku. Esimest rida ei vaadata

        Dim dateTimeValues = New List(Of String) 'List aegade hoidmiseks
        For Each row As DataRow In comboBoxTable.Rows
            dateTimeValues.Add(row(0)) 'Ajad lisatakse listi
        Next

        Dim providerValues = New List(Of String) 'List paketi pakkujate jaoks

        loadComboBoxValues = New AndmeParija.CDatabaseQuery ' Uue pärija klassi väärtustamine. Nõutud, muidu küsib eelmise päringu andmeid

        comboBoxTable = loadComboBoxValues.queryData("Select DISTINCT provider, name FROM borsPakett") 'Uus päring. Küsitakse pakkujaid ja pakette
        For Each row As DataRow In comboBoxTable.Rows
            providerValues.Add(row(0)) 'Pakkujad salvestatakse listi
        Next

        'Rippmenüüde liikmete lisamine
        cbProvider.DataSource = providerValues

        'Bindingcontext vajalik, et üks combobox ei valiks mõlema väärtusi samal ajal.
        cbStartTime.BindingContext = New BindingContext
        cbStartTime.DataSource = dateTimeValues
        cbEndTime.BindingContext = New BindingContext
        cbEndTime.DataSource = dateTimeValues

    End Sub

    Private Sub Chart_MouseMove(sender As Object, e As MouseEventArgs)
        Dim hit As HitTestResult = MainChart.HitTest(e.X, e.Y)

        If hit.ChartElementType = ChartElementType.DataPoint Then
            Dim point As DataPoint = MainChart.Series(0).Points(hit.PointIndex)
            ' Update tooltip to display date and time properly
            MainChart.Series(0).ToolTip = $"Time: {DateTime.FromOADate(point.XValue).ToString("dd.MM.yyyy HH:mm")}{Environment.NewLine}Price: {point.YValues(0):F2}"
        End If
    End Sub


    'Button tabs'
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        formCalc.Show()
        Me.Hide()
    End Sub

    Private Sub vordlusButton_Click(sender As Object, e As EventArgs) Handles vordlusButton.Click
        formVordlus.Show()
        Me.Hide()
    End Sub

    'Size buttons
    Private Sub enlargeButton_Click(sender As Object, e As EventArgs) Handles enlargeButton.Click
        'Increase the size of the form and all its elements by 5%
        Me.Width *= 1.05
        Me.Height *= 1.05

        For Each ctrl As Control In Me.Controls
            ctrl.Width *= 1.05
            ctrl.Height *= 1.05
            ctrl.Left *= 1.05
            ctrl.Top *= 1.05
        Next
    End Sub

    Private Sub shrink_Click(sender As Object, e As EventArgs) Handles shrinkButton.Click
        'Decrease the size of the form and all its elements by 5%
        Me.Width *= 0.95
        Me.Height *= 0.95

        For Each ctrl As Control In Me.Controls
            ctrl.Width *= 0.95
            ctrl.Height *= 0.95
            ctrl.Left *= 0.95
            ctrl.Top *= 0.95
        Next
    End Sub

    Private Sub MainChart_Click(sender As Object, e As EventArgs) Handles MainChart.Click

    End Sub

    Private Sub btnFindPackage_Click(sender As Object, e As EventArgs) Handles btnFindPackage.Click
        'Stringbuilder mitmerealise teksti jaoks
        Dim sbPakettPriceMargin As StringBuilder = New StringBuilder

        Dim comboBoxSearch As AndmeParija.IDatabaseQuery 'Andmepärija väärtustamine
        comboBoxSearch = New AndmeParija.CDatabaseQuery ' Klassi realisserimine

        Dim marginsTable As DataTable = comboBoxSearch.queryData("Select margin FROM borsPakett WHERE name = '" & cbPakett.SelectedValue & "'") 'Uus päring. Küsitakse paketi marginaal

        comboBoxSearch = New AndmeParija.CDatabaseQuery
        Dim resultTable As DataTable = comboBoxSearch.queryData("Select DISTINCT dateTime, price/10 FROM bors WHERE rowid > 1 AND dateTime BETWEEN '" _
                                                                  & cbStartTime.SelectedValue & "' AND '" & cbEndTime.SelectedValue & "'") 'Uus päring. Küsitakse börsi aeg ja vastav hind. NB hind on 10 korda kõrgem kui vaja

        Dim pakettMargin As Object = marginsTable.Rows(0)(0) 'Peaks olema üks marginaal, salevstab objekti lihtsuse mõttes 

        resultTable.Columns.Add("priceMargin", GetType(Double)) 'Andmetabelisse lisandub uus tulp, kuhu lisada hind koos margniaaliga
        For Each row As DataRow In resultTable.Rows
            row("priceMargin") = row(1) + pakettMargin 'Marginaaliga hinna lisamine
        Next

        comboBoxSearch = New AndmeParija.CDatabaseQuery
        marginsTable = comboBoxSearch.queryData("Select name, provider, margin FROM borsPakett ORDER BY margin ASC LIMIT 3") 'Uus päring. Küsitakse 3 väikseimat marginaali

        sbPakettPriceMargin.AppendLine("3 Kõige väiksemat marginaali: ") 'stringbuilderisse lisamine
        For Each row As DataRow In marginsTable.Rows
            sbPakettPriceMargin.AppendLine(row(0).ToString & " " & row(1).ToString & " " & row(2).ToString)
        Next
        sbPakettPriceMargin.AppendLine()

        comboBoxSearch = New AndmeParija.CDatabaseQuery
        marginsTable = comboBoxSearch.queryData("Select name, provider, margin FROM borsPakett ORDER BY margin DESC LIMIT 3") 'Uus päring. Küsitakse 3 suurimat marginaali

        sbPakettPriceMargin.AppendLine("3 Kõige suuremat marginaali: ") 'stringbuilderisse lisamine
        For Each row As DataRow In marginsTable.Rows
            sbPakettPriceMargin.AppendLine(row(0).ToString & " " & row(1).ToString & " " & row(2).ToString)
        Next
        sbPakettPriceMargin.AppendLine()

        sbPakettPriceMargin.AppendLine("Valitud paketti ajavahemiku hinnad tunnilõikes, koos hinnaga lõpptarbijale") 'Stringbuilderisse paketti aja börsi ja börs + marginaal lisamine
        For Each row As DataRow In resultTable.Rows
            sbPakettPriceMargin.AppendLine(row(0) & " " & row(1) & " " & row(2))
        Next



        Dim newForm As New formPriceMargin 'Uus aken andmete näitamiseks
        newForm.tbPriceMargins.Text += sbPakettPriceMargin.ToString 'Textboxi teksi lisamine
        newForm.dgvTimePrice.DataSource = resultTable 'Andmetabelisse allika lisamine

        newForm.Show() 'Kuvatakse aken
    End Sub

    'Kuna pakkujatel on erinevad paketid, siis võiks näidata ainult pakkuja vastavaid pakette
    Private Sub cbProvider_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProvider.SelectedValueChanged
        Dim nameValues = New List(Of String) 'List paketi nimede hoidmiseks
        Dim nameRow As DataRow() 'Rida pakettide hoidmiseks
        Dim filterStr As String = "provider = '" & cbProvider.SelectedValue & "'" 'String, mis otsib ainult pakkujale vastavaid pakette
        nameRow = comboBoxTable.Select(filterStr) 'Otsimine

        For Each row As DataRow In nameRow
            nameValues.Add(row(1).ToString) 'Reast listi andmete kandmine
        Next

        cbPakett.DataSource = nameValues 'Rippmenüüle andmete lisamine
    End Sub
End Class
