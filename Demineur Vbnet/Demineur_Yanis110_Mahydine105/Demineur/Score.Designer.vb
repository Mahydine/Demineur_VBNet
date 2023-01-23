<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Score
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Score))
        Me.TitleScores = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxNoms = New System.Windows.Forms.ListBox()
        Me.ListBoxCases = New System.Windows.Forms.ListBox()
        Me.ListBoxMeilleurTemps = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxCumulTemps = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxNbPartieJouer = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TitleScores
        '
        Me.TitleScores.AutoSize = True
        Me.TitleScores.Font = New System.Drawing.Font("Minecraft Ten", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleScores.ForeColor = System.Drawing.Color.Lime
        Me.TitleScores.Location = New System.Drawing.Point(12, 0)
        Me.TitleScores.Name = "TitleScores"
        Me.TitleScores.Size = New System.Drawing.Size(360, 80)
        Me.TitleScores.TabIndex = 5
        Me.TitleScores.Text = "Scores :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(21, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Noms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(242, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cases découvertes"
        '
        'ListBoxNoms
        '
        Me.ListBoxNoms.FormattingEnabled = True
        Me.ListBoxNoms.ItemHeight = 16
        Me.ListBoxNoms.Location = New System.Drawing.Point(26, 142)
        Me.ListBoxNoms.Name = "ListBoxNoms"
        Me.ListBoxNoms.Size = New System.Drawing.Size(199, 180)
        Me.ListBoxNoms.TabIndex = 9
        '
        'ListBoxCases
        '
        Me.ListBoxCases.FormattingEnabled = True
        Me.ListBoxCases.ItemHeight = 16
        Me.ListBoxCases.Location = New System.Drawing.Point(246, 142)
        Me.ListBoxCases.Name = "ListBoxCases"
        Me.ListBoxCases.Size = New System.Drawing.Size(199, 180)
        Me.ListBoxCases.TabIndex = 10
        '
        'ListBoxMeilleurTemps
        '
        Me.ListBoxMeilleurTemps.FormattingEnabled = True
        Me.ListBoxMeilleurTemps.ItemHeight = 16
        Me.ListBoxMeilleurTemps.Location = New System.Drawing.Point(469, 142)
        Me.ListBoxMeilleurTemps.Name = "ListBoxMeilleurTemps"
        Me.ListBoxMeilleurTemps.Size = New System.Drawing.Size(199, 180)
        Me.ListBoxMeilleurTemps.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(465, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Meilleur Temps"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(689, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Temps Total"
        '
        'ListBoxCumulTemps
        '
        Me.ListBoxCumulTemps.FormattingEnabled = True
        Me.ListBoxCumulTemps.ItemHeight = 16
        Me.ListBoxCumulTemps.Location = New System.Drawing.Point(693, 142)
        Me.ListBoxCumulTemps.Name = "ListBoxCumulTemps"
        Me.ListBoxCumulTemps.Size = New System.Drawing.Size(199, 180)
        Me.ListBoxCumulTemps.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(912, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Parties Total"
        '
        'ListBoxNbPartieJouer
        '
        Me.ListBoxNbPartieJouer.FormattingEnabled = True
        Me.ListBoxNbPartieJouer.ItemHeight = 16
        Me.ListBoxNbPartieJouer.Location = New System.Drawing.Point(916, 142)
        Me.ListBoxNbPartieJouer.Name = "ListBoxNbPartieJouer"
        Me.ListBoxNbPartieJouer.Size = New System.Drawing.Size(199, 180)
        Me.ListBoxNbPartieJouer.TabIndex = 15
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1138, 355)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBoxNbPartieJouer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBoxCumulTemps)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBoxMeilleurTemps)
        Me.Controls.Add(Me.ListBoxCases)
        Me.Controls.Add(Me.ListBoxNoms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleScores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Score"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleScores As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxNoms As ListBox
    Friend WithEvents ListBoxCases As ListBox
    Friend WithEvents ListBoxMeilleurTemps As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxCumulTemps As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBoxNbPartieJouer As ListBox
End Class
