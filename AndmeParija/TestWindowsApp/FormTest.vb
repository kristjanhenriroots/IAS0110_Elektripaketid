Imports System.Reflection.Emit
Imports AndmeParija.CAPIQuery
Imports AndmeParija.CDatabaseQuery
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization
Imports System.Text
Imports System.Configuration
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder

Public Class FormTest

    Private comboBoxTable As New DataTable

    Private Sub FormTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim testShit As AndmeParija.IAPIQuery
        testShit = New AndmeParija.CAPIQuery
        Try
            testShit.updateTable()
        Catch ex As Exception
            Console.WriteLine("Fuck")
        End Try



        Dim loadComboboxValues As AndmeParija.IDatabaseQuery
        loadComboboxValues = New AndmeParija.CDatabaseQuery

        comboBoxTable = loadComboboxValues.queryData("Select dateTime FROM bors WHERE rowid > 1 LIMIT 25")

        Dim providerValues = New List(Of String)
        Dim dateTimeValues = New List(Of String)
        For Each row As DataRow In comboBoxTable.Rows
            dateTimeValues.Add(row(0))
        Next

        loadComboboxValues = New AndmeParija.CDatabaseQuery
        comboBoxTable = loadComboboxValues.queryData("Select DISTINCT provider, name FROM borsPakett")
        For Each row As DataRow In comboBoxTable.Rows
            providerValues.Add(row(0))
        Next

        cbProvider.DataSource = providerValues
        ComboBox1.BindingContext = New BindingContext
        ComboBox1.DataSource = dateTimeValues
        ComboBox2.BindingContext = New BindingContext
        ComboBox2.DataSource = dateTimeValues

    End Sub

    Private Sub firstSeries(values As Double(), s As String())

        'chartArea
        Dim ChartArea = New ChartArea()
        Chart1.ChartAreas(0).Axes(0).MajorGrid.Enabled = False '/x axis
        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "P"
        'chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 13);
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).Axes(1).MajorGrid.Enabled = True 'y axis

        'Series
        Dim series1 As New Series()
        Chart1.Series.Add(series1)
        'Series style
        series1.ChartType = SeriesChartType.Line ' type
        series1.BorderWidth = 2
        series1.Color = Color.Green

        Dim x As Integer = 0
        For Each v In values
            series1.Points.AddXY(s(x), v)
            x = x + 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testTable As New DataTable
        Dim buttonPress As AndmeParija.IDatabaseQuery
        buttonPress = New AndmeParija.CDatabaseQuery

        Dim query1 As String = "dateTime"
        Dim query2 As String = "NPSEesti"

        testTable = buttonPress.queryData("Select * FROM bors WHERE rowid < 24")

        Dim Len As Integer = testTable.Columns.Count
        Dim i As Integer = 0
        Dim dummy As String = ""

        Dim dateTimeValues = New List(Of String)
        Dim priceValues = New List(Of Double)

        For Each row As DataRow In testTable.Rows
            If i = 0 Then
                i = i + 1 'Esimene rida apist on lampi pealkiri XDXDXDXDXD
            Else
                dateTimeValues.Add(row(1).ToString)
                priceValues.Add(row(2).ToString)

                Console.WriteLine(row.Item(2))
                Console.WriteLine(row.Item(1))
                Console.WriteLine(row.GetType)
                dummy = Convert.ToString(row.Item(2))
                Console.WriteLine(dummy)
                Console.WriteLine(dummy.GetType)
                i = i + 1
            End If
        Next
        Chart1.Series(0).XValueMember = query1
        Chart1.Series(0).YValueMembers = query2

        Chart1.DataBind()

        firstSeries(priceValues.ToArray, dateTimeValues.ToArray)

    End Sub

    Private Sub cbProvider_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProvider.SelectedValueChanged
        Dim nameValues = New List(Of String)
        Dim nameRow As DataRow()
        Console.WriteLine(cbProvider.SelectedValue)
        Dim filterStr As String = "provider = '" & cbProvider.SelectedValue & "'"
        nameRow = comboBoxTable.Select(filterStr)

        For Each row As DataRow In nameRow
            nameValues.Add(row(1).ToString)
        Next

        cbPakett.DataSource = nameValues

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim sb As StringBuilder = New StringBuilder
        Dim loadComboBoxValues As AndmeParija.IDatabaseQuery
        loadComboBoxValues = New AndmeParija.CDatabaseQuery

        Dim tempTable2 As DataTable = loadComboBoxValues.queryData("Select margin FROM borsPakett WHERE name = '" & cbPakett.SelectedValue & "'")
        loadComboBoxValues = New AndmeParija.CDatabaseQuery

        Dim tempTable As DataTable = loadComboBoxValues.queryData("Select DISTINCT dateTime, price/10 FROM bors WHERE rowid > 1 AND dateTime BETWEEN '" _
                                                                  & ComboBox1.SelectedValue & "' AND '" & ComboBox2.SelectedValue & "'")

        Dim pakettMargin As Object = tempTable2.Rows(0)(0)

        tempTable.Columns.Add("priceMargin", GetType(Double))
        For Each row As DataRow In tempTable.Rows
            row("priceMargin") = row(1) + pakettMargin 'bandaid fix. Hind on 10 korda suurem kui muidu
            Console.WriteLine(row(0) & " " & row(1) & " " & row(2))
        Next

        loadComboBoxValues = New AndmeParija.CDatabaseQuery

        tempTable2 = loadComboBoxValues.queryData("Select name, provider, margin FROM borsPakett ORDER BY margin ASC LIMIT 3")
        sb.AppendLine("3 Kõige väiksemat marginaali: ")
        For Each row As DataRow In tempTable2.Rows
            sb.AppendLine(row(0).ToString & " " & row(1).ToString & " " & row(2).ToString)
        Next
        sb.AppendLine()

        loadComboBoxValues = New AndmeParija.CDatabaseQuery
        tempTable2 = loadComboBoxValues.queryData("Select name, provider, margin FROM borsPakett ORDER BY margin DESC LIMIT 3")
        sb.AppendLine("3 Kõige suuremat marginaali: ")
        For Each row As DataRow In tempTable2.Rows
            sb.AppendLine(row(0).ToString & " " & row(1).ToString & " " & row(2).ToString)
        Next
        sb.AppendLine()

        sb.AppendLine("Valitud paketti hinnad tunnilõikes, koos hinnaga lõpptarbijale")
        For Each row As DataRow In tempTable.Rows
            sb.AppendLine(row(0) & " " & row(1) & " " & row(2))
        Next



        Dim newForm As New FormTemp
        newForm.tbMargins.Text += sb.ToString

        newForm.dgvTimePrice.DataSource = tempTable

        newForm.Show()
    End Sub


End Class
