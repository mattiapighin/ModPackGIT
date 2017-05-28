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
        Me.Bt_OrdiniAperti = New System.Windows.Forms.Button()
        Me.Bt_Imballi = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bt_CaricaOrdine
        '
        Me.Bt_CaricaOrdine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Bt_CaricaOrdine.FlatAppearance.BorderColor = System.Drawing.Color.Silver
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
        Me.Button1.Location = New System.Drawing.Point(497, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Svuota DB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bt_OrdiniAperti
        '
        Me.Bt_OrdiniAperti.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Bt_OrdiniAperti.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Bt_OrdiniAperti.FlatAppearance.BorderSize = 2
        Me.Bt_OrdiniAperti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_OrdiniAperti.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_OrdiniAperti.Image = CType(resources.GetObject("Bt_OrdiniAperti.Image"), System.Drawing.Image)
        Me.Bt_OrdiniAperti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_OrdiniAperti.Location = New System.Drawing.Point(12, 58)
        Me.Bt_OrdiniAperti.Name = "Bt_OrdiniAperti"
        Me.Bt_OrdiniAperti.Size = New System.Drawing.Size(170, 40)
        Me.Bt_OrdiniAperti.TabIndex = 2
        Me.Bt_OrdiniAperti.Text = "ORDINI APERTI  "
        Me.Bt_OrdiniAperti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_OrdiniAperti.UseVisualStyleBackColor = False
        '
        'Bt_Imballi
        '
        Me.Bt_Imballi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Bt_Imballi.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Bt_Imballi.FlatAppearance.BorderSize = 2
        Me.Bt_Imballi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Imballi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Imballi.Image = CType(resources.GetObject("Bt_Imballi.Image"), System.Drawing.Image)
        Me.Bt_Imballi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Imballi.Location = New System.Drawing.Point(12, 104)
        Me.Bt_Imballi.Name = "Bt_Imballi"
        Me.Bt_Imballi.Size = New System.Drawing.Size(170, 40)
        Me.Bt_Imballi.TabIndex = 3
        Me.Bt_Imballi.Text = "IMBALLI  "
        Me.Bt_Imballi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Imballi.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(497, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip, Me.ProgressBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 263)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip
        '
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(0, 17)
        '
        'ProgressBar
        '
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBar.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(584, 285)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Bt_Imballi)
        Me.Controls.Add(Me.Bt_OrdiniAperti)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bt_CaricaOrdine)
        Me.Name = "Main"
        Me.Text = "ModPack"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bt_CaricaOrdine As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bt_OrdiniAperti As Button
    Friend WithEvents Bt_Imballi As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip As ToolStripStatusLabel
    Friend WithEvents ProgressBar As ToolStripProgressBar
End Class
