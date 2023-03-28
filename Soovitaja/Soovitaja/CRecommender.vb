Public Class CRecommender
    Implements IRecommender

    Private recommendation As String 'Soovitatud firma nimi
    Private priceHour As Double 'Odavaim tunni hind

    Private companyName As Integer = 1 'Tabeli asukoht firma nime jaoks
    Private priceHourRowNr As Integer = 2 'Tabeli asukoht tunnihinna jaoks
    Private priceMonthRowNr As Integer = 3 'Tabeli asukoht kuuhinna jaoks

    Private Sub processData(dataT As DataTable)
        Dim firstDataRow As DataRow = dataT.Rows(0) 'Esimene saadud rida
        recommendation = Convert.ToString(firstDataRow.Item(companyName)) 'Esimene firma nimi
        priceHour = Convert.ToDouble(firstDataRow.Item(priceHourRowNr)) 'Esimene ettejuhtuv väärtus
        Dim placeholder As Double = Convert.ToDouble(firstDataRow.Item(priceHourRowNr)) 'Sama siin 

        For Each row As DataRow In dataT.Rows 'Käib läbi tabeli
            placeholder = Convert.ToDouble(row.Item(priceHourRowNr)) 'Võtab rea tunnihinna
            If priceHour > placeholder Then 'Võrdleb salvestatud tunnihinnaga
                priceHour = placeholder 'Kui väiksem siis salvestab
                recommendation = Convert.ToString(row.Item(companyName)) 'Salvestab odavaima firma nime
            End If
        Next


    End Sub

    Public Function getRecommendation(dataT As DataTable) As String Implements IRecommender.getRecommendation
        processData(dataT) 'Kutsub välja funktsiooni
        Return recommendation 'Tagasta saadud väärtus
    End Function
End Class
