<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_OrdiniAperti
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_OrdiniAperti))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGW_OrdiniAperti = New System.Windows.Forms.DataGridView()
        Me.Bt_Refresh = New System.Windows.Forms.Button()
        Me.Dgw_Ordine = New System.Windows.Forms.DataGridView()
        Me.Bt_Disegni = New System.Windows.Forms.Button()
        Me.Bt_Etichette = New System.Windows.Forms.Button()
        CType(Me.DGW_OrdiniAperti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgw_Ordine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGW_OrdiniAperti
        '
        Me.DGW_OrdiniAperti.AllowUserToAddRows = False
        Me.DGW_OrdiniAperti.AllowUserToDeleteRows = False
        Me.DGW_OrdiniAperti.AllowUserToResizeColumns = False
        Me.DGW_OrdiniAperti.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DGW_OrdiniAperti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGW_OrdiniAperti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGW_OrdiniAperti.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGW_OrdiniAperti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_OrdiniAperti.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_OrdiniAperti.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGW_OrdiniAperti.Location = New System.Drawing.Point(12, 12)
        Me.DGW_OrdiniAperti.Name = "DGW_OrdiniAperti"
        Me.DGW_OrdiniAperti.ReadOnly = True
        Me.DGW_OrdiniAperti.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DGW_OrdiniAperti.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGW_OrdiniAperti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGW_OrdiniAperti.Size = New System.Drawing.Size(202, 478)
        Me.DGW_OrdiniAperti.TabIndex = 0
        '
        'Bt_Refresh
        '
        Me.Bt_Refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Refresh.FlatAppearance.BorderSize = 0
        Me.Bt_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Refresh.Image = CType(resources.GetObject("Bt_Refresh.Image"), System.Drawing.Image)
        Me.Bt_Refresh.Location = New System.Drawing.Point(1123, 12)
        Me.Bt_Refresh.Name = "Bt_Refresh"
        Me.Bt_Refresh.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Refresh.TabIndex = 2
        Me.Bt_Refresh.UseVisualStyleBackColor = True
        '
        'Dgw_Ordine
        '
        Me.Dgw_Ordine.AllowUserToAddRows = False
        Me.Dgw_Ordine.AllowUserToDeleteRows = False
        Me.Dgw_Ordine.AllowUserToResizeColumns = False
        Me.Dgw_Ordine.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgw_Ordine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgw_Ordine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgw_Ordine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgw_Ordine.BackgroundColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgw_Ordine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgw_Ordine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgw_Ordine.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dgw_Ordine.Location = New System.Drawing.Point(220, 12)
        Me.Dgw_Ordine.Name = "Dgw_Ordine"
        Me.Dgw_Ordine.ReadOnly = True
        Me.Dgw_Ordine.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.Dgw_Ordine.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dgw_Ordine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgw_Ordine.Size = New System.Drawing.Size(897, 478)
        Me.Dgw_Ordine.TabIndex = 0
        '
        'Bt_Disegni
        '
        Me.Bt_Disegni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Disegni.FlatAppearance.BorderSize = 0
        Me.Bt_Disegni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Disegni.Image = CType(resources.GetObject("Bt_Disegni.Image"), System.Drawing.Image)
        Me.Bt_Disegni.Location = New System.Drawing.Point(1123, 58)
        Me.Bt_Disegni.Name = "Bt_Disegni"
        Me.Bt_Disegni.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Disegni.TabIndex = 3
        Me.Bt_Disegni.UseVisualStyleBackColor = True
        '
        'Bt_Etichette
        '
        Me.Bt_Etichette.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bt_Etichette.FlatAppearance.BorderSize = 0
        Me.Bt_Etichette.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Etichette.Image = CType(resources.GetObject("Bt_Etichette.Image"), System.Drawing.Image)
        Me.Bt_Etichette.Location = New System.Drawing.Point(1123, 104)
        Me.Bt_Etichette.Name = "Bt_Etichette"
        Me.Bt_Etichette.Size = New System.Drawing.Size(40, 40)
        Me.Bt_Etichette.TabIndex = 4
        Me.Bt_Etichette.UseVisualStyleBackColor = True
        '
        'Form_OrdiniAperti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 502)
        Me.Controls.Add(Me.Bt_Etichette)
        Me.Controls.Add(Me.Bt_Disegni)
        Me.Controls.Add(Me.Bt_Refresh)
        Me.Controls.Add(Me.Dgw_Ordine)
        Me.Controls.Add(Me.DGW_OrdiniAperti)
        Me.Name = "Form_OrdiniAperti"
        Me.Text = "Ordini Aperti"
        CType(Me.DGW_OrdiniAperti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgw_Ordine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGW_OrdiniAperti As DataGridView
    Friend WithEvents Bt_Refresh As Button
    Friend WithEvents Dgw_Ordine As DataGridView
    Friend WithEvents Bt_Disegni As Button
    Friend WithEvents Bt_Etichette As Button
End Class
