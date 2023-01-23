Public Class Jeu
    Dim TempsEcoulé As Decimal = 0
    Dim LeJoueur As Joueur
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNomJoueur.Text = "Le Joueur : " & LeJoueur.getNomJoueur() 'Récupération du nom du joueur
        TempsEcoulé = 0
        ChronoPartie.Start() 'Démarage du Chrono
        InitialisationMines()
        InitialisationChiffres()
    End Sub

    Private Sub ChronoPartie_Tick(sender As Object, e As EventArgs) Handles ChronoPartie.Tick
        TempsEcoulé = TempsEcoulé + 0.1 'Cumule les ticks
        LabelChronoPartie.Text = CInt(getTempsPartie() - TempsEcoulé) 'Fait le décompte (60 à 0)
        If TempsEcoulé > getTempsPartie() - 10 Then LabelChronoPartie.ForeColor = Color.DarkRed
        If TempsEcoulé > getTempsPartie() Then FinDePartie(LeJoueur)
    End Sub

    Private Sub ButtonAbbandonner_Click(sender As Object, e As EventArgs) Handles BoutonAbandon.Click
        Dim AbandonConfirmation As Integer
        AbandonConfirmation = MsgBox("Êtes-vous sur de vouloir abandonner", vbYesNo + vbDefaultButton2, "Déjà ?")
        If (AbandonConfirmation = vbYes) Then
            Close()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click, Button41.Click, Button42.Click, Button43.Click, Button44.Click, Button45.Click, Button46.Click, Button47.Click, Button48.Click, Button49.Click, Button50.Click, Button51.Click, Button52.Click, Button53.Click, Button54.Click, Button55.Click, Button56.Click, Button57.Click, Button58.Click, Button59.Click, Button60.Click, Button61.Click, Button63.Click, Button64.Click, Button65.Click
        Dim b As Button = DirectCast(sender, Windows.Forms.Button)
        joueUnCoup(b, LeJoueur)
    End Sub

    Private Sub Button_ClickDroit(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown, Button2.MouseDown, Button3.MouseDown, Button4.MouseDown, Button5.MouseDown, Button6.MouseDown, Button7.MouseDown, Button8.MouseDown, Button9.MouseDown, Button10.MouseDown, Button11.MouseDown, Button12.MouseDown, Button13.MouseDown, Button14.MouseDown, Button15.MouseDown, Button16.MouseDown, Button17.MouseDown, Button18.MouseDown, Button19.MouseDown, Button20.MouseDown, Button21.MouseDown, Button22.MouseDown, Button23.MouseDown, Button24.MouseDown, Button25.MouseDown, Button26.MouseDown, Button27.MouseDown, Button28.MouseDown, Button29.MouseDown, Button30.MouseDown, Button31.MouseDown, Button32.MouseDown, Button33.MouseDown, Button34.MouseDown, Button35.MouseDown, Button36.MouseDown, Button37.MouseDown, Button38.MouseDown, Button39.MouseDown, Button40.MouseDown, Button41.MouseDown, Button42.MouseDown, Button43.MouseDown, Button44.MouseDown, Button45.MouseDown, Button46.MouseDown, Button47.MouseDown, Button48.MouseDown, Button49.MouseDown, Button50.MouseDown, Button51.MouseDown, Button52.MouseDown, Button53.MouseDown, Button54.MouseDown, Button55.MouseDown, Button56.MouseDown, Button57.MouseDown, Button58.MouseDown, Button59.MouseDown, Button60.MouseDown, Button61.MouseDown, Button62.MouseDown, Button63.MouseDown, Button64.MouseDown, Button65.MouseDown
        Dim b As Button = DirectCast(sender, Windows.Forms.Button)
        If e.Button = Button.MouseButtons.Right Then 'Si clic Droit
            CocherMine(b)
        End If
    End Sub

    Public Function getTempsEcoulé() As Decimal
        Return TempsEcoulé
    End Function
    Public Function setJoueur(j As Joueur)
        LeJoueur = j
    End Function
End Class