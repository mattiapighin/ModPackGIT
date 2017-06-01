<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Preferenze
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
        Me.Bt_FormatoStampa = New System.Windows.Forms.Button()
        Me.GB_etichette = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Txt_mmX = New System.Windows.Forms.TextBox()
        Me.Txt_mmY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Txt_MargineTop = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_MargineRight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_MargineBottom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_MargineLeft = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_NomeStampante = New System.Windows.Forms.TextBox()
        Me.Bt_Salva = New System.Windows.Forms.Button()
        Me.Ck_Evaso = New System.Windows.Forms.CheckBox()
        Me.Ck_ColoraScaduti = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ck_CheckCaricamento = New System.Windows.Forms.CheckBox()
        Me.Ck_ColoraEvasi = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Nu_RigheDistinta = New System.Windows.Forms.NumericUpDown()
        Me.Nu_FontDistinta = New System.Windows.Forms.NumericUpDown()
        Me.CkBarcodeSoloCodice = New System.Windows.Forms.CheckBox()
        Me.Ck_Barcode = New System.Windows.Forms.CheckBox()
        Me.Ck_BiancoNero = New System.Windows.Forms.CheckBox()
        Me.GB_etichette.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Nu_RigheDistinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nu_FontDistinta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bt_FormatoStampa
        '
        Me.Bt_FormatoStampa.Location = New System.Drawing.Point(396, 12)
        Me.Bt_FormatoStampa.Name = "Bt_FormatoStampa"
        Me.Bt_FormatoStampa.Size = New System.Drawing.Size(120, 23)
        Me.Bt_FormatoStampa.TabIndex = 0
        Me.Bt_FormatoStampa.Text = "Formato Stampa"
        Me.Bt_FormatoStampa.UseVisualStyleBackColor = True
        '
        'GB_etichette
        '
        Me.GB_etichette.Controls.Add(Me.TableLayoutPanel2)
        Me.GB_etichette.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_etichette.Controls.Add(Me.Txt_NomeStampante)
        Me.GB_etichette.Location = New System.Drawing.Point(12, 12)
        Me.GB_etichette.Name = "GB_etichette"
        Me.GB_etichette.Size = New System.Drawing.Size(378, 116)
        Me.GB_etichette.TabIndex = 1
        Me.GB_etichette.TabStop = False
        Me.GB_etichette.Text = "Etichette"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.22472!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.77528!))
        Me.TableLayoutPanel2.Controls.Add(Me.Txt_mmX, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Txt_mmY, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(176, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(196, 64)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'Txt_mmX
        '
        Me.Txt_mmX.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_mmX.Location = New System.Drawing.Point(140, 6)
        Me.Txt_mmX.Name = "Txt_mmX"
        Me.Txt_mmX.Size = New System.Drawing.Size(49, 20)
        Me.Txt_mmX.TabIndex = 10
        '
        'Txt_mmY
        '
        Me.Txt_mmY.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_mmY.Location = New System.Drawing.Point(140, 38)
        Me.Txt_mmY.Name = "Txt_mmY"
        Me.Txt_mmY.Size = New System.Drawing.Size(49, 20)
        Me.Txt_mmY.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Dimensione Etichetta X"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Dimensione Etichetta Y"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.14634!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.85366!))
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_MargineTop, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_MargineRight, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_MargineBottom, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_MargineLeft, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(164, 93)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Txt_MargineTop
        '
        Me.Txt_MargineTop.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_MargineTop.Location = New System.Drawing.Point(99, 3)
        Me.Txt_MargineTop.Name = "Txt_MargineTop"
        Me.Txt_MargineTop.Size = New System.Drawing.Size(61, 20)
        Me.Txt_MargineTop.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Margine Right"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_MargineRight
        '
        Me.Txt_MargineRight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_MargineRight.Location = New System.Drawing.Point(99, 72)
        Me.Txt_MargineRight.Name = "Txt_MargineRight"
        Me.Txt_MargineRight.Size = New System.Drawing.Size(61, 20)
        Me.Txt_MargineRight.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Margine Left"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_MargineBottom
        '
        Me.Txt_MargineBottom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_MargineBottom.Location = New System.Drawing.Point(99, 26)
        Me.Txt_MargineBottom.Name = "Txt_MargineBottom"
        Me.Txt_MargineBottom.Size = New System.Drawing.Size(61, 20)
        Me.Txt_MargineBottom.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Margine Bottom"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_MargineLeft
        '
        Me.Txt_MargineLeft.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Txt_MargineLeft.Location = New System.Drawing.Point(99, 49)
        Me.Txt_MargineLeft.Name = "Txt_MargineLeft"
        Me.Txt_MargineLeft.Size = New System.Drawing.Size(61, 20)
        Me.Txt_MargineLeft.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Margine Top"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_NomeStampante
        '
        Me.Txt_NomeStampante.Location = New System.Drawing.Point(176, 91)
        Me.Txt_NomeStampante.Name = "Txt_NomeStampante"
        Me.Txt_NomeStampante.Size = New System.Drawing.Size(189, 20)
        Me.Txt_NomeStampante.TabIndex = 11
        '
        'Bt_Salva
        '
        Me.Bt_Salva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Salva.Location = New System.Drawing.Point(426, 325)
        Me.Bt_Salva.Name = "Bt_Salva"
        Me.Bt_Salva.Size = New System.Drawing.Size(90, 38)
        Me.Bt_Salva.TabIndex = 12
        Me.Bt_Salva.Text = "Salva"
        Me.Bt_Salva.UseVisualStyleBackColor = True
        '
        'Ck_Evaso
        '
        Me.Ck_Evaso.AutoSize = True
        Me.Ck_Evaso.Location = New System.Drawing.Point(15, 19)
        Me.Ck_Evaso.Name = "Ck_Evaso"
        Me.Ck_Evaso.Size = New System.Drawing.Size(335, 17)
        Me.Ck_Evaso.TabIndex = 2
        Me.Ck_Evaso.Text = "Chiedi conferma prima di contrassegnare un imballo come EVASO"
        Me.Ck_Evaso.UseVisualStyleBackColor = True
        '
        'Ck_ColoraScaduti
        '
        Me.Ck_ColoraScaduti.AutoSize = True
        Me.Ck_ColoraScaduti.Location = New System.Drawing.Point(15, 42)
        Me.Ck_ColoraScaduti.Name = "Ck_ColoraScaduti"
        Me.Ck_ColoraScaduti.Size = New System.Drawing.Size(346, 17)
        Me.Ck_ColoraScaduti.TabIndex = 13
        Me.Ck_ColoraScaduti.Text = "Evidenzia gli imballi scaduti o in scadenza nel modulo ""Ordini Aperti"""
        Me.Ck_ColoraScaduti.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ck_CheckCaricamento)
        Me.GroupBox1.Controls.Add(Me.Ck_ColoraEvasi)
        Me.GroupBox1.Controls.Add(Me.Ck_Evaso)
        Me.GroupBox1.Controls.Add(Me.Ck_ColoraScaduti)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 114)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preferenze"
        '
        'Ck_CheckCaricamento
        '
        Me.Ck_CheckCaricamento.AutoSize = True
        Me.Ck_CheckCaricamento.Location = New System.Drawing.Point(15, 88)
        Me.Ck_CheckCaricamento.Name = "Ck_CheckCaricamento"
        Me.Ck_CheckCaricamento.Size = New System.Drawing.Size(228, 17)
        Me.Ck_CheckCaricamento.TabIndex = 15
        Me.Ck_CheckCaricamento.Text = "Controllo su caricamento di ogni riga ordine"
        Me.Ck_CheckCaricamento.UseVisualStyleBackColor = True
        '
        'Ck_ColoraEvasi
        '
        Me.Ck_ColoraEvasi.AutoSize = True
        Me.Ck_ColoraEvasi.Location = New System.Drawing.Point(15, 65)
        Me.Ck_ColoraEvasi.Name = "Ck_ColoraEvasi"
        Me.Ck_ColoraEvasi.Size = New System.Drawing.Size(267, 17)
        Me.Ck_ColoraEvasi.TabIndex = 14
        Me.Ck_ColoraEvasi.Text = "Nascondi gli imballi evasi nel modulo ""Ordini Aperti"""
        Me.Ck_ColoraEvasi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Nu_RigheDistinta)
        Me.GroupBox2.Controls.Add(Me.Nu_FontDistinta)
        Me.GroupBox2.Controls.Add(Me.CkBarcodeSoloCodice)
        Me.GroupBox2.Controls.Add(Me.Ck_Barcode)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 71)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distinte"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Minimo Righe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dimensione Font"
        '
        'Nu_RigheDistinta
        '
        Me.Nu_RigheDistinta.Location = New System.Drawing.Point(245, 41)
        Me.Nu_RigheDistinta.Name = "Nu_RigheDistinta"
        Me.Nu_RigheDistinta.Size = New System.Drawing.Size(65, 20)
        Me.Nu_RigheDistinta.TabIndex = 3
        '
        'Nu_FontDistinta
        '
        Me.Nu_FontDistinta.Location = New System.Drawing.Point(245, 18)
        Me.Nu_FontDistinta.Name = "Nu_FontDistinta"
        Me.Nu_FontDistinta.Size = New System.Drawing.Size(65, 20)
        Me.Nu_FontDistinta.TabIndex = 2
        '
        'CkBarcodeSoloCodice
        '
        Me.CkBarcodeSoloCodice.AutoSize = True
        Me.CkBarcodeSoloCodice.Location = New System.Drawing.Point(15, 42)
        Me.CkBarcodeSoloCodice.Name = "CkBarcodeSoloCodice"
        Me.CkBarcodeSoloCodice.Size = New System.Drawing.Size(120, 17)
        Me.CkBarcodeSoloCodice.TabIndex = 1
        Me.CkBarcodeSoloCodice.Text = "Stampa solo Codice"
        Me.CkBarcodeSoloCodice.UseVisualStyleBackColor = True
        '
        'Ck_Barcode
        '
        Me.Ck_Barcode.AutoSize = True
        Me.Ck_Barcode.Location = New System.Drawing.Point(15, 19)
        Me.Ck_Barcode.Name = "Ck_Barcode"
        Me.Ck_Barcode.Size = New System.Drawing.Size(105, 17)
        Me.Ck_Barcode.TabIndex = 0
        Me.Ck_Barcode.Text = "Stampa Barcode"
        Me.Ck_Barcode.UseVisualStyleBackColor = True
        '
        'Ck_BiancoNero
        '
        Me.Ck_BiancoNero.AutoSize = True
        Me.Ck_BiancoNero.Location = New System.Drawing.Point(407, 41)
        Me.Ck_BiancoNero.Name = "Ck_BiancoNero"
        Me.Ck_BiancoNero.Size = New System.Drawing.Size(92, 17)
        Me.Ck_BiancoNero.TabIndex = 6
        Me.Ck_BiancoNero.Text = "Bianco e nero"
        Me.Ck_BiancoNero.UseVisualStyleBackColor = True
        '
        'Form_Preferenze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 375)
        Me.Controls.Add(Me.Ck_BiancoNero)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_etichette)
        Me.Controls.Add(Me.Bt_Salva)
        Me.Controls.Add(Me.Bt_FormatoStampa)
        Me.Name = "Form_Preferenze"
        Me.Text = "Form_Preferenze"
        Me.GB_etichette.ResumeLayout(False)
        Me.GB_etichette.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Nu_RigheDistinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nu_FontDistinta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bt_FormatoStampa As Button
    Friend WithEvents GB_etichette As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Txt_mmX As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_mmY As TextBox
    Friend WithEvents Txt_NomeStampante As TextBox
    Friend WithEvents Bt_Salva As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Txt_MargineTop As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_MargineRight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_MargineBottom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_MargineLeft As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ck_Evaso As CheckBox
    Friend WithEvents Ck_ColoraScaduti As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Ck_ColoraEvasi As CheckBox
    Friend WithEvents Ck_CheckCaricamento As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CkBarcodeSoloCodice As CheckBox
    Friend WithEvents Ck_Barcode As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Nu_RigheDistinta As NumericUpDown
    Friend WithEvents Nu_FontDistinta As NumericUpDown
    Friend WithEvents Ck_BiancoNero As CheckBox
End Class
