<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reglages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reglages))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Minecraft Ten", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mode Sombre"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(38, 73)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 33)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Activé"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(164, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Sauvegarder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Minecraft Ten", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(12, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "More will be added in future version"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Minecraft Ten", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(12, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "by Yanis And Mahydine"
        '
        'Reglages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(317, 232)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reglages"
        Me.Text = "Reglages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
