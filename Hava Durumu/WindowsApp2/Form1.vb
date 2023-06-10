Imports System.Xml.Linq
Imports System.Xml.XmlDocument
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Api = "2d889f5c3e5fabc3803c5a403124f716"
        Dim sehir = "bursa"

        Dim Connection = "http://api.openweathermap.org/data/2.5/weather?q=" & sehir & "&mode=xml&lang=tr&units=metric&appid=" & Api
        Dim weather As XDocument = XDocument.Load(Connection)

        Dim temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value
        Dim durum = weather.Descendants("clouds").ElementAt(0).Attribute("name").Value
        Dim ruzgar = weather.Descendants("speed").ElementAt(0).Attribute("value").Value
        Dim nem = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value

        Label5.Text = temp
        Label6.Text = durum
        Label7.Text = ruzgar
        Label9.Text = nem & "%"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Api = "2d889f5c3e5fabc3803c5a403124f716"
        Dim sehir = ComboBox1.SelectedItem

        Dim Connection = "http://api.openweathermap.org/data/2.5/weather?q=" & sehir & "&mode=xml&lang=tr&units=metric&appid=" & Api
        Dim weather As XDocument = XDocument.Load(Connection)

        Dim temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value
        Dim durum = weather.Descendants("clouds").ElementAt(0).Attribute("name").Value
        Dim ruzgar = weather.Descendants("speed").ElementAt(0).Attribute("value").Value
        Dim nem = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value

        Label5.Text = temp
        Label6.Text = durum
        Label7.Text = ruzgar
        Label9.Text = nem & "%"

    End Sub
End Class
