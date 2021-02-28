Imports System.ComponentModel

Public Class frmDriverlessUberCar

    Const _cdecCostPerMile As Decimal = 1.8D
    Const _cdecFlatRate As Decimal = 2.8D

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumMiles.Clear()
        lblTotalCost.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDisplayFare_Click(sender As Object, e As EventArgs) Handles btnDisplayFare.Click
        Dim strEnterNumberOfMiles As String
        Dim intEnterNumberOfMiles As Integer
        Dim decTotalCost As Decimal

        lblTotalCost.Visible = True

        strEnterNumberOfMiles = txtNumMiles.Text
        intEnterNumberOfMiles = Convert.ToInt32(strEnterNumberOfMiles)
        decTotalCost = _cdecFlatRate + _cdecCostPerMile * intEnterNumberOfMiles
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub frmDriverlessUberCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = "Only " & _cdecCostPerMile.ToString("C") & " Per Mile"
        lblTotalCost.Text = ""
        txtNumMiles.Focus()
    End Sub

End Class
