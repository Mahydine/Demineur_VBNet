Public Class Score

    Public Function Maj(ListeDeJoueurs As Joueur(), nbDeJoueurs As Integer)
        For i As Integer = 0 To nbDeJoueurs - 1
            Dim j = ListeDeJoueurs(i)
            ListBoxNoms.Items.Add(j.getNomJoueur)
            ListBoxCases.Items.Add(j.getNbDeCasesRevelée)
            ListBoxMeilleurTemps.Items.Add(j.getTempsEffectuer)
            ListBoxCumulTemps.Items.Add(j.getCumulTempsDeJeu)
            ListBoxNbPartieJouer.Items.Add(j.getNbDePartiesJouées)
        Next
    End Function

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Maj(MazModule.getListeJoueurs, MazModule.getNbDeJoueurs)
    End Sub

    Private Sub ListBoxNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNoms.SelectedIndexChanged, ListBoxCases.SelectedIndexChanged, ListBoxMeilleurTemps.SelectedIndexChanged, ListBoxCumulTemps.SelectedIndexChanged, ListBoxNbPartieJouer.SelectedIndexChanged
        Dim b As ListBox = DirectCast(sender, Windows.Forms.ListBox)
        ListBoxNoms.SelectedIndex = b.SelectedIndex
        ListBoxCases.SelectedIndex = b.SelectedIndex
        ListBoxMeilleurTemps.SelectedIndex = b.SelectedIndex
        ListBoxCumulTemps.SelectedIndex = b.SelectedIndex
        ListBoxNbPartieJouer.SelectedIndex = b.SelectedIndex
    End Sub
End Class