<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Bt_CaricaOrdine = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bt_CaricaOrdine
        '
        Me.Bt_CaricaOrdine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bt_CaricaOrdine.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite
        Me.Bt_CaricaOrdine.FlatAppearance.BorderSize = 2
        Me.Bt_CaricaOrdine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_CaricaOrdine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_CaricaOrdine.Image = CType(resources.GetObject("Bt_CaricaOrdine.Image"), System.Drawing.Image)
        Me.Bt_CaricaOrdine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_CaricaOrdine.Location = New System.Drawing.Point(12, 12)
        Me.Bt_CaricaOrdine.Name = "Bt_CaricaOrdine"
        Me.Bt_CaricaOrdine.Size = New System.Drawing.Size(170, 40)
        Me.Bt_CaricaOrdine.TabIndex = 0
        Me.Bt_CaricaOrdine.Text = "CARICA ORDINE "
        Me.Bt_CaricaOrdine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_CaricaOrdine.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Dispose"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(584, 473)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bt_CaricaOrdine)
        Me.Name = "Main"
        Me.Text = "ModPack"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bt_CaricaOrdine As Button
    Friend WithEvents Button1 As Button
End Class
