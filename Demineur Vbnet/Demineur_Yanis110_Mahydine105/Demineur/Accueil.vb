Imports System.IO

Public Class Accueil
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonLancement.Click
        If (ComboBoxNomJoueur.Text.Trim.Length >= 3) Then
            If Not ComboBoxNomJoueur.Items.Contains(ComboBoxNomJoueur.Text) Then
                enregistrerJoueur(ComboBoxNomJoueur.Text, 0, 0, 0, 0)
            End If
            Jeu.setJoueur(getJoueurByName(ComboBoxNomJoueur.Text))
            Jeu.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim reponseConfirmation As Integer
        reponseConfirmation = MsgBox("Êtes-vous sur de vouloir quitter", vbYesNo + vbDefaultButton2, "Confirmation")
        If (reponseConfirmation = vbYes) Then
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Scores.Click
        Score.Show()
    End Sub

    Private Sub Accueil_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Dim listeDeJoueursEcriture As New StreamWriter("ListeJoueurs.txt")
        Dim ListeJ = getListeJoueurs()
        For i As Integer = 0 To getNbDeJoueurs() - 1
            listeDeJoueursEcriture.WriteLine(ListeJ(i).getNomJoueur)
            listeDeJoueursEcriture.WriteLine(ListeJ(i).getNbDeCasesRevelée)
            listeDeJoueursEcriture.WriteLine(CInt(ListeJ(i).getTempsEffectuer))
            listeDeJoueursEcriture.WriteLine(ListeJ(i).getCumulTempsDeJeu)
            listeDeJoueursEcriture.WriteLine(ListeJ(i).getNbDePartiesJouées)
        Next
        listeDeJoueursEcriture.Close()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listeDeJoueursLecture As New StreamReader("ListeJoueurs.txt")
        Do While listeDeJoueursLecture.Peek() >= 0
            enregistrerJoueur(listeDeJoueursLecture.ReadLine, listeDeJoueursLecture.ReadLine, listeDeJoueursLecture.ReadLine, listeDeJoueursLecture.ReadLine, listeDeJoueursLecture.ReadLine)
        Loop
        listeDeJoueursLecture.Close()
    End Sub

    Private Sub Reglages_Click(sender As Object, e As EventArgs) Handles ReglagesButton.Click
        Reglages.Show()
    End Sub
End Class
