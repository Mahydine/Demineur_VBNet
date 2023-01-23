Public Class Reglages
    Private Sub Reglages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If getDarkMode() = True Then
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            setDarkMode(True)
            Jeu.BackColor = Color.DarkBlue
            Accueil.BackColor = Color.DarkBlue
            Score.BackColor = Color.DarkBlue
            BackColor = Color.DarkBlue
            Accueil.ReglagesButton.BackColor = Color.DarkBlue
            Accueil.ReglagesButton.ForeColor = Color.DarkBlue
        Else
            setDarkMode(False)
            Jeu.BackColor = Color.DimGray
            Accueil.BackColor = Color.DimGray
            Score.BackColor = Color.DimGray
            BackColor = Color.DimGray
            Accueil.ReglagesButton.BackColor = Color.DimGray
            Accueil.ReglagesButton.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class