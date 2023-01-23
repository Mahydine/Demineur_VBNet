Imports System.IO

Module MazModule
    Private NbDeMinesMax As Integer = 10
    Private TempsPartie As Integer = 60
    Private NbDeCasesRevelée As Integer = 0
    Private Dimensions As Integer = 8
    Dim CasesAvecMines(Dimensions, Dimensions) As Boolean
    Dim ChiffresDesCases(Dimensions, Dimensions) As Integer
    Dim ListeJoueurs(2) As Joueur
    Dim NbDeJoueurs As Integer = 0
    Dim DarkMode As Boolean
    Public Function InitialisationMines() As Integer
        For i As Integer = 0 To Dimensions - 1 'Remet a False toutes les cases
            For j As Integer = 0 To Dimensions - 1
                CasesAvecMines(i, j) = False
            Next
        Next

        Dim random As New Random(), nba1 As Integer, nba2 As Integer 'Variable utiles pour nombre aléatoire

        For i As Integer = 0 To NbDeMinesMax - 1 'Fabrique Autant de mines que NbDeMinesMax
            nba1 = random.Next(Dimensions) 'ligne
            nba2 = random.Next(Dimensions) 'colonne
            CasesAvecMines(nba1, nba2) = True 'Met la valeur a True pour indiquer que c'est une mine
        Next

        Return 0
    End Function

    Public Function InitialisationChiffres() As Integer

        For i As Integer = 0 To Dimensions - 1 'Remet a 0 toutes les cases
            For j As Integer = 0 To Dimensions - 1
                ChiffresDesCases(i, j) = 0
            Next
        Next

        For ligne As Integer = 0 To Dimensions - 1
            For colonne As Integer = 0 To Dimensions - 1
                If CasesAvecMines(ligne, colonne) = True Then 'Si la case est une mine alors
                    For i As Integer = -1 To 1 'pour chaque ligne adjacentes (de haut en bas)
                        For j As Integer = -1 To 1 'et pour chaque colonnes adjacentes (de gauche a droite)
                            If caseExiste(ligne + i, colonne + j) Then
                                ChiffresDesCases(ligne + i, colonne + j) += 1 ' +1
                            End If
                        Next
                    Next
                End If
            Next
        Next
        Return 0
    End Function

    Public Function enregistrerJoueur(NomJoueur As String, NbDeCasesRevelée As Integer, TempsEffectuer As Integer, TempsCumulé As Integer, NbDePartiesJouées As Integer) As Integer
        Dim j As New Joueur(NomJoueur, NbDeCasesRevelée, TempsEffectuer, TempsCumulé, NbDePartiesJouées)
        If ListeJoueurs.Length > NbDeJoueurs Then
            ListeJoueurs(NbDeJoueurs) = j
        Else
            ReDim Preserve ListeJoueurs(NbDeJoueurs + 5)
            ListeJoueurs(NbDeJoueurs) = j
        End If
        NbDeJoueurs += 1
        Accueil.ComboBoxNomJoueur.Items.Add(NomJoueur)
        Return 0
    End Function

    Public Function getJoueurByName(n As String) As Joueur
        For i As Integer = 0 To NbDeJoueurs
            If ListeJoueurs(i).getNomJoueur = n Then
                Return ListeJoueurs(i)
            End If
        Next
        Return Nothing
    End Function

    Public Function getListeJoueurs() As Joueur()
        Return ListeJoueurs
    End Function
    Public Function getNbDeJoueurs() As Integer
        Return NbDeJoueurs
    End Function

    Public Function joueUnCoup(b As Button, LeJoueur As Joueur) As Integer

        Dim ligne As Integer, colonne As Integer

        For i As Integer = 0 To Dimensions - 1 'Retrouve les indexs du bouton cliqué
            For j As Integer = 0 To Dimensions - 1
                If b.Equals(Jeu.PanelGlobal.Controls(i).Controls(j)) Then
                    ligne = i
                    colonne = j
                End If
            Next
        Next

        If estUneMine(b) = True Then 'Clic sur Mine
            b.BackColor = Color.Red
            FinDePartie(LeJoueur)
        End If
        If ChiffresDesCases(ligne, colonne) > 0 Then 'Clic sur case avec mines adjacentes
            demasqueCase(ligne, colonne, LeJoueur)
        End If
        If ChiffresDesCases(ligne, colonne) = 0 Then 'Clic sur case sans mines adjacentes
            demasqueCaseAdjacentes(ligne, colonne, LeJoueur)
        End If
        Return 0
    End Function

    Public Function demasqueCase(ligne As Integer, colonne As Integer, LeJoueur As Joueur) As Integer

        If ChiffresDesCases(ligne, colonne) > 0 Then
            Jeu.PanelGlobal.Controls(ligne).Controls(colonne).Text = ChiffresDesCases(ligne, colonne)
        End If
        If ChiffresDesCases(ligne, colonne) = 1 Then
            Jeu.PanelGlobal.Controls(ligne).Controls(colonne).ForeColor = Color.Green
        ElseIf ChiffresDesCases(ligne, colonne) = 2 Then
            Jeu.PanelGlobal.Controls(ligne).Controls(colonne).ForeColor = Color.DarkOrange
        ElseIf ChiffresDesCases(ligne, colonne) = 3 Then
            Jeu.PanelGlobal.Controls(ligne).Controls(colonne).ForeColor = Color.Red
        ElseIf ChiffresDesCases(ligne, colonne) >= 4 Then
            Jeu.PanelGlobal.Controls(ligne).Controls(colonne).ForeColor = Color.DarkRed
        End If

        If Jeu.PanelGlobal.Controls(ligne).Controls(colonne).BackColor <> Color.White And CasesAvecMines(ligne, colonne) = False Then
        End If
        Jeu.PanelGlobal.Controls(ligne).Controls(colonne).BackColor = Color.White

        NbDeCasesRevelée += 1
        Dim j = getJoueurByName(Accueil.ComboBoxNomJoueur.Text)
        j.setNbDeCasesRevelée(NbDeCasesRevelée)
        j.setTempsEffectuer(Jeu.getTempsEcoulé())

        If PartieTerminéeOuPas() Then
            FinDePartie(LeJoueur)
        End If

        Return 0
    End Function

    Public Function PartieTerminéeOuPas() As Boolean
        Dim compteurDeMinesReel As Integer = 0
        Dim compteurDeCasesDemasquée As Integer = 0
        For i As Integer = 0 To Dimensions - 1
            For j As Integer = 0 To Dimensions - 1
                If CasesAvecMines(i, j) Then
                    compteurDeMinesReel += 1
                End If
                If Jeu.PanelGlobal.Controls(i).Controls(j).BackColor = Color.White Then
                    compteurDeCasesDemasquée += 1
                End If
            Next
        Next
        If compteurDeCasesDemasquée + compteurDeMinesReel >= 64 Then
            Return True
        End If
        Return False
    End Function

    Public Function CocherMine(b As Button) As Integer
        If b.BackgroundImageLayout <> ImageLayout.Stretch And b.BackColor <> Color.White Then
            b.BackgroundImage = Demineur.My.Resources.Resources.flag
            b.BackgroundImageLayout = ImageLayout.Stretch
        Else
            b.BackgroundImage = Nothing
            b.BackgroundImageLayout = ImageLayout.Tile
        End If

        Return 0
    End Function
    Public Function demasqueCaseAdjacentes(ligne, colonne, LeJoueur) As Integer
        demasqueCase(ligne, colonne, LeJoueur)
        If ChiffresDesCases(ligne, colonne) = 0 Then
            For i As Integer = -1 To 1
                For j As Integer = -1 To 1
                    If caseExiste(ligne + i, colonne + j) Then
                        If Jeu.PanelGlobal.Controls(ligne + i).Controls(colonne + j).BackColor <> Color.White Then
                            demasqueCaseAdjacentes(ligne + i, colonne + j, LeJoueur)
                        End If
                    End If
                Next
            Next
        End If
        Return 0
    End Function

    Public Function caseExiste(ligne As Integer, colonne As Integer) As Boolean
        If ligne >= 0 And ligne <= Dimensions - 1 And colonne >= 0 And colonne <= Dimensions - 1 Then
            Return True
        End If
        Return False
    End Function

    Public Function estUneMine(b As Button) As Boolean
        For i As Integer = 0 To Dimensions - 1 'Retrouve les indexs du bouton cliqué
            For j As Integer = 0 To Dimensions - 1
                If b.Equals(Jeu.PanelGlobal.Controls(i).Controls(j)) Then
                    If CasesAvecMines(i, j) = True Then
                        Return 1
                    End If
                    Return 0
                End If
            Next
        Next
    End Function

    Public Function FinDePartie(LeJoueur As Joueur) As Integer
        Jeu.ChronoPartie.Stop()

        LeJoueur.setNbDePartiesJouées()
        LeJoueur.setCumulTempsDeJeu(Jeu.getTempsEcoulé())

        MsgBox("Fin de Partie pour vous " & LeJoueur.getNomJoueur() & vbCrLf & vbCrLf &
               "Votre Score : " & vbCrLf _
               & LeJoueur.getNbDeCasesRevelée & " case(s) révélée(s) " & "en " & LeJoueur.getTempsEffectuer & " secondes.")
        Jeu.Close()
        Return 0
    End Function
    Public Function getTempsPartie() As Integer
        Return TempsPartie
    End Function

    Public Function getCasesAvecMines() As Boolean(,)
        Return CasesAvecMines
    End Function
    Public Function getChiffresDesCases() As Integer(,)
        Return ChiffresDesCases
    End Function
    Public Function getDarkMode() As Boolean
        Return DarkMode
    End Function
    Public Function setDarkMode(b As Boolean) As Boolean
        DarkMode = b
    End Function

End Module
