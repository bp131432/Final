﻿Public Class Horse_Race
    Dim KonaResult As Integer
    Dim SecertariatResult As Integer
    Dim BarbaroResult As Integer
    Dim CaliforniaResult As Integer
    Dim ZenyettaResult As Integer

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim IntWinner As Integer
        Dim intcount, intcount1, intcount2, intcount3, intcount4 As Integer
        Dim rand As New Random
        IntWinner = rand.Next(4)

        For intcount = 185 To rand.Next(50) + 693
            PicKonasKannon.Left = intcount
            'KonaResult = KonaResult + 1
        Next
        For intcount1 = 185 To rand.Next(50) + 693
            PicSecertariat.Left = intcount1
            'SecertariatResult = SecertariatResult + 1
        Next
        For intcount2 = 185 To rand.Next(50) + 693
            PicBarbaro.Left = intcount2
            ' BarbaroResult = BarbaroResult + 1
        Next
        For intcount3 = 185 To rand.Next(50) + 693
            PicCaliforniaCrome.Left = intcount3
            'CaliforniaResult = CaliforniaResult + 1
        Next
        For intcount4 = 185 To rand.Next(50) + 693
            PicZenyetta.Left = intcount4
            'ZenyettaResult = ZenyettaResult + 1
        Next
        If intcount > intcount1 And intcount2 And intcount3 And intcount4 Then
            KonaResult = KonaResult + 1
        ElseIf intcount1 > intcount And intcount2 And intcount3 And intcount4 Then
            SecertariatResult = SecertariatResult + 1
        ElseIf intcount2 > intcount And intcount1 And intcount3 And intcount4 Then
            BarbaroResult = BarbaroResult + 1
        ElseIf intcount3 > intcount And intcount1 And intcount2 And intcount4 Then
            CaliforniaResult = CaliforniaResult + 1
        ElseIf intcount4 > intcount And intcount1 And intcount2 And intcount3 Then
            ZenyettaResult = ZenyettaResult + 1
        End If
        lblBarbaro.Text = BarbaroResult.ToString
        lblCalifornia.Text = CaliforniaResult.ToString
        lblKona.Text = KonaResult.ToString
        lblSecertariat.Text = SecertariatResult.ToString
        lblZenyetta.Text = ZenyettaResult.ToString
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPlaceBet_Click(sender As Object, e As EventArgs) Handles btnPlaceBet.Click
        Dim box = New Racing_Money
        box.Show()
    End Sub
End Class