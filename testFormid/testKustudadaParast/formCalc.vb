Public Class formCalc

    Private appliances As Dictionary(Of String, Double)

    Private Sub formCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set combobox dropdown style so user can't write'
        applianceComboBox.DropDownStyle = ComboBoxStyle.DropDownList

        'Disable calculateButton until all required entries are filled'
        calculateButton.Enabled = False

        'Set costTextBox to read-only'
        costTextBox.ReadOnly = True

        ' Handle the KeyPress event of the text boxes to allow double values with commas and dots.
        AddHandler powerRatingTextBox.KeyPress, AddressOf TextBox_KeyPress
        AddHandler timeUsedTextBox.KeyPress, AddressOf TextBox_KeyPress
        AddHandler electricityRateTextBox.KeyPress, AddressOf TextBox_KeyPress

        'Fill appliances dictionary'
        'Data from: https://rohe.geenius.ee/rubriik/uudis/millised-su-kodumasinad-kulutavad-aastas-enim-elektrit-ei-see-pole-pesumasin-voi-elektripliit/'
        appliances = New Dictionary(Of String, Double) From {
            {"Mikrolaineahi [1000W]", 1000},
            {"Kohvimasin [1000 W]", 1000},
            {"Veekeetja [1500 W]", 1500},
            {"Keraamiline pliit [2000 W]", 2000},
            {"Induktsioonpliit [2500 W]", 2500},
            {"Elektripliit [2500 W]", 2500},
            {"Elektriahi [3000 W]", 3000},
            {"Triikraud [2000 W]", 2000},
            {"Tolmuimeja [800 W]", 800},
            {"Mängukonsool [90 W]", 90},
            {"Digiboks [60 W]", 60},
            {"Wifi ruuter [20 W]", 20},
            {"Kell-raadio [10 W]", 10},
            {"Elektriboiler 100 l [2200 W]", 2200},
            {"Elektriradiaator [2000 W]", 2000},
            {"Valgusti Halogeen [60 W]", 60},
            {"Valgusti LED [10 W]", 10},
            {"Laptop [50 W]", 50},
            {"Arvuti [250 W]", 250},
            {"Televisioon [100 W]", 100}
        }

        For Each applianceName As String In appliances.Keys
            applianceComboBox.Items.Add(applianceName)
        Next
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Replace any dots with commas to allow double values with both separators.
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub applianceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles applianceComboBox.SelectedIndexChanged
        ' When the user selects an appliance from the ComboBox, update the powerRatingTextBox with its power rating.
        Dim selectedAppliance As String = applianceComboBox.SelectedItem.ToString()
        Dim powerRating As Double = appliances(selectedAppliance)
        powerRatingTextBox.Text = powerRating.ToString()
    End Sub

    Private Sub anyTextBox_TextChanged(sender As Object, e As EventArgs) Handles powerRatingTextBox.TextChanged, electricityRateTextBox.TextChanged, timeUsedTextBox.TextChanged
        ' Enable the calculateButton if all inputs are entered.
        If Not String.IsNullOrEmpty(powerRatingTextBox.Text) And Not String.IsNullOrEmpty(timeUsedTextBox.Text) And Not String.IsNullOrEmpty(electricityRateTextBox.Text) Then
            calculateButton.Enabled = True
        Else
            calculateButton.Enabled = False
        End If
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim powerRating As Double
        Dim timeUsed As Double
        Dim electricityRate As Double
        Dim cost As Double

        powerRating = Double.Parse(powerRatingTextBox.Text)
        timeUsed = Double.Parse(timeUsedTextBox.Text)
        electricityRate = Double.Parse(electricityRateTextBox.Text)

        cost = ((powerRating * timeUsed) / 1000) * electricityRate

        'Convert cost to Eur if over 100 cents
        If cost < 100.0 Then
            costTextBox.Text = cost.ToString() + " s"
        Else
            costTextBox.Text = (cost / 100).ToString() + " €"
        End If

    End Sub

    'Button tabs'
    Private Sub homeButton_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        formHome.Show()
        Me.Hide()
    End Sub

    Private Sub vordlusButton_Click(sender As Object, e As EventArgs) Handles vordlusButton.Click
        formVordlus.Show()
        Me.Hide()
    End Sub

End Class