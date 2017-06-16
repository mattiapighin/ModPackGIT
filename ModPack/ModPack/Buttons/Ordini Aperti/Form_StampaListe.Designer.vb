<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_StampaListe
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StampaListe))
        Me.DGW = New System.Windows.Forms.DataGridView()
        Me.Bt_MoraliHT = New System.Windows.Forms.Button()
        Me.Bt_Morali = New System.Windows.Forms.Button()
        Me.Lbl_Titolo = New System.Windows.Forms.Label()
        Me.Bt_Esporta = New System.Windows.Forms.Button()
        Me.PrintMorali = New System.Drawing.Printing.PrintDocument()
        Me.Bt_Stampa = New System.Windows.Forms.Button()
        CType(Me.DGW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW
        '
        Me.DGW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW.Location = New System.Drawing.Point(9, 80)
        Me.DGW.Name = "DGW"
        Me.DGW.Size = New System.Drawing.Size(723, 455)
        Me.DGW.TabIndex = 0
        '
        'Bt_MoraliHT
        '
        Me.Bt_MoraliHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_MoraliHT.Location = New System.Drawing.Point(80, 9)
        Me.Bt_MoraliHT.Name = "Bt_MoraliHT"
        Me.Bt_MoraliHT.Size = New System.Drawing.Size(65, 65)
        Me.Bt_MoraliHT.TabIndex = 1
        Me.Bt_MoraliHT.Text = "HT"
        Me.Bt_MoraliHT.UseVisualStyleBackColor = True
        '
        'Bt_Morali
        '
        Me.Bt_Morali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Morali.Location = New System.Drawing.Point(9, 9)
        Me.Bt_Morali.Name = "Bt_Morali"
        Me.Bt_Morali.Size = New System.Drawing.Size(65, 65)
        Me.Bt_Morali.TabIndex = 2
        Me.Bt_Morali.Text = "FRESCO"
        Me.Bt_Morali.UseVisualStyleBackColor = True
        '
        'Lbl_Titolo
        '
        Me.Lbl_Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Titolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Titolo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titolo.Location = New System.Drawing.Point(154, 9)
        Me.Lbl_Titolo.Name = "Lbl_Titolo"
        Me.Lbl_Titolo.Size = New System.Drawing.Size(578, 24)
        Me.Lbl_Titolo.TabIndex = 5
        Me.Lbl_Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bt_Esporta
        '
        Me.Bt_Esporta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Esporta.FlatAppearance.BorderSize = 0
        Me.Bt_Esporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Esporta.Image = CType(resources.GetObject("Bt_Esporta.Image"), System.Drawing.Image)
        Me.Bt_Esporta.Location = New System.Drawing.Point(646, 34)
        Me.Bt_Esporta.Name = "Bt_Esporta"
        Me.Bt_Esporta.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Esporta.TabIndex = 8
        Me.Bt_Esporta.UseVisualStyleBackColor = True
        '
        'PrintMorali
        '
        '
        'Bt_Stampa
        '
        Me.Bt_Stampa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Stampa.FlatAppearance.BorderSize = 0
        Me.Bt_Stampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Stampa.Image = CType(resources.GetObject("Bt_Stampa.Image"), System.Drawing.Image)
        Me.Bt_Stampa.Location = New System.Drawing.Point(692, 34)
        Me.Bt_Stampa.Name = "Bt_Stampa"
        Me.Bt_Stampa.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Stampa.TabIndex = 9
        Me.Bt_Stampa.UseVisualStyleBackColor = True
        '
        'Form_StampaListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 547)
        Me.Controls.Add(Me.Bt_Stampa)
        Me.Controls.Add(Me.Bt_Esporta)
        Me.Controls.Add(Me.Lbl_Titolo)
        Me.Controls.Add(Me.Bt_Morali)
        Me.Controls.Add(Me.Bt_MoraliHT)
        Me.Controls.Add(Me.DGW)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_StampaListe"
        Me.Text = "Lista Morali"
        CType(Me.DGW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGW As DataGridView
    Friend WithEvents Bt_MoraliHT As Button
    Friend WithEvents Bt_Morali As Button
    Friend WithEvents Lbl_Titolo As Label
    Friend WithEvents Bt_Esporta As Button
    Friend WithEvents PrintMorali As Printing.PrintDocument
    Friend WithEvents Bt_Stampa As Button
End Class
