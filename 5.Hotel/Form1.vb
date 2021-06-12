Public Class Hotel
    Dim Costo As Double
    Dim Descuento As Double
    Dim Total As Double
    Dim CantDias As Double

    Private Sub rdbtnA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnA.CheckedChanged
        Costo = 35
    End Sub

    Private Sub rdbtnB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnB.CheckedChanged
        Costo = 25
    End Sub

    Private Sub rdbtnC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnC.CheckedChanged
        Costo = 15
    End Sub

    Private Sub Txtbx1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbx1.TextChanged
        If Txtbx1.Text >= 1 And Txtbx1.Text <= 3 Then
            Descuento = 0.02
        End If
        If Txtbx1.Text = 4 And Txtbx1.Text >= 7 Then
            Descuento = 0.1
        End If
        If Txtbx1.Text >= 8 Then
            Descuento = 0.25
        End If
    End Sub

    Private Sub btnPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPro.Click
        CantDias = Val(Txtbx1.Text)
        Total = (CantDias * Costo) - (CantDias * Descuento)
        txtbxTotal.Text = Total
    End Sub
End Class
