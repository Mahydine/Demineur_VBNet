<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.ComboBoxNomJoueur = New System.Windows.Forms.ComboBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.Scores = New System.Windows.Forms.Button()
        Me.ButtonLancement = New System.Windows.Forms.Button()
        Me.TitleDemineur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReglagesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxNomJoueur
        '
        Me.ComboBoxNomJoueur.FormattingEnabled = True
        Me.ComboBoxNomJoueur.Location = New System.Drawing.Point(304, 196)
        Me.ComboBoxNomJoueur.Name = "ComboBoxNomJoueur"
        Me.ComboBoxNomJoueur.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxNomJoueur.TabIndex = 0
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonQuitter.Location = New System.Drawing.Point(68, 338)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(177, 46)
        Me.ButtonQuitter.TabIndex = 1
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'Scores
        '
        Me.Scores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Scores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Scores.Location = New System.Drawing.Point(312, 338)
        Me.Scores.Name = "Scores"
        Me.Scores.Size = New System.Drawing.Size(177, 46)
        Me.Scores.TabIndex = 2
        Me.Scores.Text = "Tableau des Scores"
        Me.Scores.UseVisualStyleBackColor = False
        '
        'ButtonLancement
        '
        Me.ButtonLancement.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonLancement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonLancement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLancement.Location = New System.Drawing.Point(556, 338)
        Me.ButtonLancement.Name = "ButtonLancement"
        Me.ButtonLancement.Size = New System.Drawing.Size(177, 46)
        Me.ButtonLancement.TabIndex = 3
        Me.ButtonLancement.Text = "Lancer"
        Me.ButtonLancement.UseVisualStyleBackColor = False
        '
        'TitleDemineur
        '
        Me.TitleDemineur.AutoSize = True
        Me.TitleDemineur.Font = New System.Drawing.Font("Minecraft Ten", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDemineur.ForeColor = System.Drawing.Color.Lime
        Me.TitleDemineur.Location = New System.Drawing.Point(188, 33)
        Me.TitleDemineur.Name = "TitleDemineur"
        Me.TitleDemineur.Size = New System.Drawing.Size(419, 80)
        Me.TitleDemineur.TabIndex = 4
        Me.TitleDemineur.Text = "DEMINEUR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minecraft Ten", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(95, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pseudonyme :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minecraft Ten", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(612, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Reglages"
        '
        'ReglagesButton
        '
        Me.ReglagesButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ReglagesButton.BackgroundImage = Global.Demineur.My.Resources.Resources.reglagesLogo
        Me.ReglagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReglagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReglagesButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ReglagesButton.Location = New System.Drawing.Point(641, 189)
        Me.ReglagesButton.Name = "ReglagesButton"
        Me.ReglagesButton.Size = New System.Drawing.Size(80, 80)
        Me.ReglagesButton.TabIndex = 6
        Me.ReglagesButton.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReglagesButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleDemineur)
        Me.Controls.Add(Me.ButtonLancement)
        Me.Controls.Add(Me.Scores)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ComboBoxNomJoueur)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Accueil"
        Me.Text = "Démineur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxNomJoueur As ComboBox
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents Scores As Button
    Friend WithEvents ButtonLancement As Button
    Friend WithEvents TitleDemineur As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReglagesButton As Button
    Friend WithEvents Label2 As Label
End Class
