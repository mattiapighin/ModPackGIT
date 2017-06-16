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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.DGW_Memo = New System.Windows.Forms.DataGridView()
        Me.Memo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bt_Memo = New System.Windows.Forms.Button()
        Me.Bt_Stampe = New System.Windows.Forms.Button()
        Me.Bt_Preferenze = New System.Windows.Forms.Button()
        Me.Bt_Imballi = New System.Windows.Forms.Button()
        Me.Bt_OrdiniAperti = New System.Windows.Forms.Button()
        Me.Bt_CaricaOrdine = New System.Windows.Forms.Button()
        Me.Notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGW_Memo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(741, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Azzeramento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip, Me.ProgressBar})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 297)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(874, 22)
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
        Me.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBar.Visible = False
        '
        'Calendario
        '
        Me.Calendario.Location = New System.Drawing.Point(194, 12)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.ShowWeekNumbers = True
        Me.Calendario.TabIndex = 10
        '
        'DGW_Memo
        '
        Me.DGW_Memo.AllowUserToAddRows = False
        Me.DGW_Memo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell
        Me.DGW_Memo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_Memo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Memo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGW_Memo.BackgroundColor = System.Drawing.Color.White
        Me.DGW_Memo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Memo.ColumnHeadersVisible = False
        Me.DGW_Memo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Memo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGW_Memo.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_Memo.Location = New System.Drawing.Point(455, 12)
        Me.DGW_Memo.Name = "DGW_Memo"
        Me.DGW_Memo.ReadOnly = True
        Me.DGW_Memo.RowHeadersVisible = False
        Me.DGW_Memo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGW_Memo.Size = New System.Drawing.Size(407, 270)
        Me.DGW_Memo.TabIndex = 11
        '
        'Memo
        '
        Me.Memo.HeaderText = "Memo"
        Me.Memo.Name = "Memo"
        Me.Memo.ReadOnly = True
        '
        'Bt_Memo
        '
        Me.Bt_Memo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Bt_Memo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Bt_Memo.FlatAppearance.BorderSize = 2
        Me.Bt_Memo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Memo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Memo.Image = CType(resources.GetObject("Bt_Memo.Image"), System.Drawing.Image)
        Me.Bt_Memo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Memo.Location = New System.Drawing.Point(12, 242)
        Me.Bt_Memo.Name = "Bt_Memo"
        Me.Bt_Memo.Size = New System.Drawing.Size(170, 40)
        Me.Bt_Memo.TabIndex = 12
        Me.Bt_Memo.Text = "MEMO  "
        Me.Bt_Memo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Memo.UseVisualStyleBackColor = False
        '
        'Bt_Stampe
        '
        Me.Bt_Stampe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Bt_Stampe.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Bt_Stampe.FlatAppearance.BorderSize = 2
        Me.Bt_Stampe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Stampe.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Stampe.Image = CType(resources.GetObject("Bt_Stampe.Image"), System.Drawing.Image)
        Me.Bt_Stampe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Stampe.Location = New System.Drawing.Point(12, 150)
        Me.Bt_Stampe.Name = "Bt_Stampe"
        Me.Bt_Stampe.Size = New System.Drawing.Size(170, 40)
        Me.Bt_Stampe.TabIndex = 9
        Me.Bt_Stampe.Text = "TABELLE  "
        Me.Bt_Stampe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Stampe.UseVisualStyleBackColor = False
        '
        'Bt_Preferenze
        '
        Me.Bt_Preferenze.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Bt_Preferenze.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Bt_Preferenze.FlatAppearance.BorderSize = 2
        Me.Bt_Preferenze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Preferenze.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Preferenze.Image = CType(resources.GetObject("Bt_Preferenze.Image"), System.Drawing.Image)
        Me.Bt_Preferenze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Preferenze.Location = New System.Drawing.Point(12, 196)
        Me.Bt_Preferenze.Name = "Bt_Preferenze"
        Me.Bt_Preferenze.Size = New System.Drawing.Size(170, 40)
        Me.Bt_Preferenze.TabIndex = 8
        Me.Bt_Preferenze.Text = "PREFERENZE  "
        Me.Bt_Preferenze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Preferenze.UseVisualStyleBackColor = False
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
        'Notify
        '
        Me.Notify.Icon = CType(resources.GetObject("Notify.Icon"), System.Drawing.Icon)
        Me.Notify.Text = "ModPack"
        Me.Notify.Visible = True
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(874, 319)
        Me.Controls.Add(Me.Bt_Memo)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.Bt_Stampe)
        Me.Controls.Add(Me.Bt_Preferenze)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Bt_Imballi)
        Me.Controls.Add(Me.Bt_OrdiniAperti)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bt_CaricaOrdine)
        Me.Controls.Add(Me.DGW_Memo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "ModPack"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGW_Memo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bt_CaricaOrdine As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bt_OrdiniAperti As Button
    Friend WithEvents Bt_Imballi As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip As ToolStripStatusLabel
    Friend WithEvents ProgressBar As ToolStripProgressBar
    Friend WithEvents Bt_Preferenze As Button
    Friend WithEvents Bt_Stampe As Button
    Friend WithEvents Calendario As MonthCalendar
    Friend WithEvents DGW_Memo As DataGridView
    Friend WithEvents Memo As DataGridViewTextBoxColumn
    Friend WithEvents Bt_Memo As Button
    Friend WithEvents Notify As NotifyIcon
End Class
