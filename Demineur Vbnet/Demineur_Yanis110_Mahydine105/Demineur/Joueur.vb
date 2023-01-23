Imports System.IO

Public Class Joueur
    Private NomJoueur As String
    Private MeilleurTempsEffectuer As Integer
    Private MeilleurNbDeCasesRevelée As Decimal


    Private NbDePartiesJouées As Integer
    Private CumulTempsDeJeu As Integer

    Public Sub New(Nom_Joueur As String, Nb_DeCasesRevelée As Integer, Temps_Effectuer As Integer, Temps_Cumulé As Integer, Nb_DePartiesJouées As Integer)
        NomJoueur = Nom_Joueur
        MeilleurTempsEffectuer = Temps_Effectuer
        MeilleurNbDeCasesRevelée = Nb_DeCasesRevelée
        CumulTempsDeJeu = Temps_Cumulé
        NbDePartiesJouées = Nb_DePartiesJouées
    End Sub

    Public Function getNomJoueur() As String
        Return NomJoueur
    End Function
    Public Function getTempsEffectuer() As Integer
        Return CInt(MeilleurTempsEffectuer)
    End Function
    Public Function getCumulTempsDeJeu() As Integer
        Return CumulTempsDeJeu
    End Function
    Public Function getNbDePartiesJouées() As Integer
        Return NbDePartiesJouées
    End Function
    Public Function getNbDeCasesRevelée() As Integer
        Return MeilleurNbDeCasesRevelée
    End Function
    Public Function setTempsEffectuer(t As Integer)
        MeilleurTempsEffectuer = t
    End Function
    Public Function setNbDeCasesRevelée(nb As Integer)
        MeilleurNbDeCasesRevelée = nb
    End Function
    Public Function setNbDePartiesJouées()
        NbDePartiesJouées += 1
    End Function
    Public Function setCumulTempsDeJeu(TempsEffectuer As Decimal)
        CumulTempsDeJeu += CInt(TempsEffectuer)
    End Function
End Class
