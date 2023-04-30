' Program Name: Latte Selection'
' Developer:    Mark Bulmer
' Purpose:      Choose the best latte.
Public Class frmLatteSelection
    Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        ' This code is executed when the user clicks the Pumpkin Spice button. It displays the
        ' pumpkin picture, hides the mocha picture, and enables the Select Latte button.

        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        ' This code is executed when the user clicks the Mocha button. It displays the
        ' mocha picture, hides the pumpkin picture, and enables the Select Latte button.

        picPumpkin.Visible = False
        picMocha.Visible = True
        btnSelect.Enabled = True
    End Sub
End Class
