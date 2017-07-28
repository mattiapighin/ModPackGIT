<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Imballi
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Imballi))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgwImballi = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZoccoliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RivestimentoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TipoRivestimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HTDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DTDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BMDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DiagonaliDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GradiFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradiTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimoMoraleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImgDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataCreazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModPackDBDataSet = New ModPack.ModPackDBDataSet()
        Me.DgwDistinta = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RigaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballiDistintaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgwIndici = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RivestTotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteBICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballiIndiciBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Bt_Colonne = New System.Windows.Forms.ToolStripButton()
        Me.Bt_Refresh = New System.Windows.Forms.ToolStripButton()
        Me.Bt_FiltroNome = New System.Windows.Forms.ToolStripButton()
        Me.Bt_Filtro = New System.Windows.Forms.ToolStripButton()
        Me.Bt_MostraInfo = New System.Windows.Forms.ToolStripButton()
        Me.Bt_MostraDistinta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Bt_Modifica = New System.Windows.Forms.ToolStripButton()
        Me.Bt_Simili = New System.Windows.Forms.ToolStripButton()
        Me.Bt_StampaImballo = New System.Windows.Forms.ToolStripButton()
        Me.Bt_MostraNuovi = New System.Windows.Forms.ToolStripButton()
        Me.Bt_PulisciNuovi = New System.Windows.Forms.ToolStripButton()
        Me.Bt_Note = New System.Windows.Forms.ToolStripButton()
        Me.SplitSopra = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lbl_Conteggio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PrintImballo = New System.Drawing.Printing.PrintDocument()
        Me.ImballiIndiciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGW_Note = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImballiNoteImballiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImballiTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.ImballiTableAdapter()
        Me.DistintaTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.DistintaTableAdapter()
        Me.IndiciTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.IndiciTableAdapter()
        Me.NoteImballiTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.NoteImballiTableAdapter()
        Me.SplitIntero = New System.Windows.Forms.SplitContainer()
        Me.SplitSotto = New System.Windows.Forms.SplitContainer()
        CType(Me.DgwImballi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgwDistinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiDistintaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgwIndici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiIndiciBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitSopra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitSopra.Panel1.SuspendLayout()
        Me.SplitSopra.Panel2.SuspendLayout()
        Me.SplitSopra.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ImballiIndiciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGW_Note, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiNoteImballiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitIntero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitIntero.Panel1.SuspendLayout()
        Me.SplitIntero.Panel2.SuspendLayout()
        Me.SplitIntero.SuspendLayout()
        CType(Me.SplitSotto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitSotto.Panel1.SuspendLayout()
        Me.SplitSotto.Panel2.SuspendLayout()
        Me.SplitSotto.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgwImballi
        '
        Me.DgwImballi.AllowUserToAddRows = False
        Me.DgwImballi.AllowUserToDeleteRows = False
        Me.DgwImballi.AllowUserToResizeColumns = False
        Me.DgwImballi.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff
        Me.DgwImballi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgwImballi.AutoGenerateColumns = False
        Me.DgwImballi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgwImballi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwImballi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ImballoDataGridViewTextBoxColumn, Me.LDataGridViewTextBoxColumn, Me.PDataGridViewTextBoxColumn, Me.HDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.ZoccoliDataGridViewTextBoxColumn, Me.RivestimentoDataGridViewCheckBoxColumn, Me.TipoRivestimentoDataGridViewTextBoxColumn, Me.HTDataGridViewCheckBoxColumn, Me.DTDataGridViewCheckBoxColumn, Me.BMDataGridViewCheckBoxColumn, Me.DiagonaliDataGridViewCheckBoxColumn, Me.GradiFDataGridViewTextBoxColumn, Me.GradiTDataGridViewTextBoxColumn, Me.PrimoMoraleDataGridViewTextBoxColumn, Me.M2DataGridViewTextBoxColumn, Me.M3DataGridViewTextBoxColumn, Me.PrezzoDataGridViewTextBoxColumn, Me.ImgDataGridViewImageColumn, Me.DataCreazioneDataGridViewTextBoxColumn})
        Me.DgwImballi.DataSource = Me.ImballiBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwImballi.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgwImballi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgwImballi.Location = New System.Drawing.Point(0, 0)
        Me.DgwImballi.Name = "DgwImballi"
        Me.DgwImballi.ReadOnly = True
        Me.DgwImballi.RowHeadersVisible = False
        Me.DgwImballi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwImballi.Size = New System.Drawing.Size(1159, 666)
        Me.DgwImballi.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        Me.IdDataGridViewTextBoxColumn.Width = 22
        '
        'ImballoDataGridViewTextBoxColumn
        '
        Me.ImballoDataGridViewTextBoxColumn.DataPropertyName = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn.HeaderText = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn.Name = "ImballoDataGridViewTextBoxColumn"
        Me.ImballoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImballoDataGridViewTextBoxColumn.Width = 65
        '
        'LDataGridViewTextBoxColumn
        '
        Me.LDataGridViewTextBoxColumn.DataPropertyName = "L"
        Me.LDataGridViewTextBoxColumn.HeaderText = "L"
        Me.LDataGridViewTextBoxColumn.Name = "LDataGridViewTextBoxColumn"
        Me.LDataGridViewTextBoxColumn.ReadOnly = True
        Me.LDataGridViewTextBoxColumn.Width = 38
        '
        'PDataGridViewTextBoxColumn
        '
        Me.PDataGridViewTextBoxColumn.DataPropertyName = "P"
        Me.PDataGridViewTextBoxColumn.HeaderText = "P"
        Me.PDataGridViewTextBoxColumn.Name = "PDataGridViewTextBoxColumn"
        Me.PDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDataGridViewTextBoxColumn.Width = 39
        '
        'HDataGridViewTextBoxColumn
        '
        Me.HDataGridViewTextBoxColumn.DataPropertyName = "H"
        Me.HDataGridViewTextBoxColumn.HeaderText = "H"
        Me.HDataGridViewTextBoxColumn.Name = "HDataGridViewTextBoxColumn"
        Me.HDataGridViewTextBoxColumn.ReadOnly = True
        Me.HDataGridViewTextBoxColumn.Width = 40
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 53
        '
        'ZoccoliDataGridViewTextBoxColumn
        '
        Me.ZoccoliDataGridViewTextBoxColumn.DataPropertyName = "Zoccoli"
        Me.ZoccoliDataGridViewTextBoxColumn.HeaderText = "Zoccoli"
        Me.ZoccoliDataGridViewTextBoxColumn.Name = "ZoccoliDataGridViewTextBoxColumn"
        Me.ZoccoliDataGridViewTextBoxColumn.ReadOnly = True
        Me.ZoccoliDataGridViewTextBoxColumn.Visible = False
        Me.ZoccoliDataGridViewTextBoxColumn.Width = 67
        '
        'RivestimentoDataGridViewCheckBoxColumn
        '
        Me.RivestimentoDataGridViewCheckBoxColumn.DataPropertyName = "Rivestimento"
        Me.RivestimentoDataGridViewCheckBoxColumn.HeaderText = "Rivestimento"
        Me.RivestimentoDataGridViewCheckBoxColumn.Name = "RivestimentoDataGridViewCheckBoxColumn"
        Me.RivestimentoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.RivestimentoDataGridViewCheckBoxColumn.Width = 74
        '
        'TipoRivestimentoDataGridViewTextBoxColumn
        '
        Me.TipoRivestimentoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Rivestimento"
        Me.TipoRivestimentoDataGridViewTextBoxColumn.HeaderText = "Tipo Riv."
        Me.TipoRivestimentoDataGridViewTextBoxColumn.Name = "TipoRivestimentoDataGridViewTextBoxColumn"
        Me.TipoRivestimentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoRivestimentoDataGridViewTextBoxColumn.Visible = False
        Me.TipoRivestimentoDataGridViewTextBoxColumn.Width = 75
        '
        'HTDataGridViewCheckBoxColumn
        '
        Me.HTDataGridViewCheckBoxColumn.DataPropertyName = "HT"
        Me.HTDataGridViewCheckBoxColumn.HeaderText = "HT"
        Me.HTDataGridViewCheckBoxColumn.Name = "HTDataGridViewCheckBoxColumn"
        Me.HTDataGridViewCheckBoxColumn.ReadOnly = True
        Me.HTDataGridViewCheckBoxColumn.Width = 28
        '
        'DTDataGridViewCheckBoxColumn
        '
        Me.DTDataGridViewCheckBoxColumn.DataPropertyName = "DT"
        Me.DTDataGridViewCheckBoxColumn.HeaderText = "DT"
        Me.DTDataGridViewCheckBoxColumn.Name = "DTDataGridViewCheckBoxColumn"
        Me.DTDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DTDataGridViewCheckBoxColumn.Visible = False
        Me.DTDataGridViewCheckBoxColumn.Width = 28
        '
        'BMDataGridViewCheckBoxColumn
        '
        Me.BMDataGridViewCheckBoxColumn.DataPropertyName = "BM"
        Me.BMDataGridViewCheckBoxColumn.HeaderText = "BM"
        Me.BMDataGridViewCheckBoxColumn.Name = "BMDataGridViewCheckBoxColumn"
        Me.BMDataGridViewCheckBoxColumn.ReadOnly = True
        Me.BMDataGridViewCheckBoxColumn.Visible = False
        Me.BMDataGridViewCheckBoxColumn.Width = 29
        '
        'DiagonaliDataGridViewCheckBoxColumn
        '
        Me.DiagonaliDataGridViewCheckBoxColumn.DataPropertyName = "Diagonali"
        Me.DiagonaliDataGridViewCheckBoxColumn.HeaderText = "Diagonali"
        Me.DiagonaliDataGridViewCheckBoxColumn.Name = "DiagonaliDataGridViewCheckBoxColumn"
        Me.DiagonaliDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DiagonaliDataGridViewCheckBoxColumn.Visible = False
        Me.DiagonaliDataGridViewCheckBoxColumn.Width = 57
        '
        'GradiFDataGridViewTextBoxColumn
        '
        Me.GradiFDataGridViewTextBoxColumn.DataPropertyName = "Gradi_F"
        Me.GradiFDataGridViewTextBoxColumn.HeaderText = "Gradi F"
        Me.GradiFDataGridViewTextBoxColumn.Name = "GradiFDataGridViewTextBoxColumn"
        Me.GradiFDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradiFDataGridViewTextBoxColumn.Visible = False
        Me.GradiFDataGridViewTextBoxColumn.Width = 66
        '
        'GradiTDataGridViewTextBoxColumn
        '
        Me.GradiTDataGridViewTextBoxColumn.DataPropertyName = "Gradi_T"
        Me.GradiTDataGridViewTextBoxColumn.HeaderText = "Gradi T"
        Me.GradiTDataGridViewTextBoxColumn.Name = "GradiTDataGridViewTextBoxColumn"
        Me.GradiTDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradiTDataGridViewTextBoxColumn.Visible = False
        Me.GradiTDataGridViewTextBoxColumn.Width = 67
        '
        'PrimoMoraleDataGridViewTextBoxColumn
        '
        Me.PrimoMoraleDataGridViewTextBoxColumn.DataPropertyName = "Primo_Morale"
        Me.PrimoMoraleDataGridViewTextBoxColumn.HeaderText = "Primo Morale"
        Me.PrimoMoraleDataGridViewTextBoxColumn.Name = "PrimoMoraleDataGridViewTextBoxColumn"
        Me.PrimoMoraleDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrimoMoraleDataGridViewTextBoxColumn.Visible = False
        Me.PrimoMoraleDataGridViewTextBoxColumn.Width = 93
        '
        'M2DataGridViewTextBoxColumn
        '
        Me.M2DataGridViewTextBoxColumn.DataPropertyName = "M2"
        Me.M2DataGridViewTextBoxColumn.HeaderText = "M2"
        Me.M2DataGridViewTextBoxColumn.Name = "M2DataGridViewTextBoxColumn"
        Me.M2DataGridViewTextBoxColumn.ReadOnly = True
        Me.M2DataGridViewTextBoxColumn.Width = 47
        '
        'M3DataGridViewTextBoxColumn
        '
        Me.M3DataGridViewTextBoxColumn.DataPropertyName = "M3"
        Me.M3DataGridViewTextBoxColumn.HeaderText = "M3"
        Me.M3DataGridViewTextBoxColumn.Name = "M3DataGridViewTextBoxColumn"
        Me.M3DataGridViewTextBoxColumn.ReadOnly = True
        Me.M3DataGridViewTextBoxColumn.Width = 47
        '
        'PrezzoDataGridViewTextBoxColumn
        '
        Me.PrezzoDataGridViewTextBoxColumn.DataPropertyName = "Prezzo"
        Me.PrezzoDataGridViewTextBoxColumn.HeaderText = "Prezzo"
        Me.PrezzoDataGridViewTextBoxColumn.Name = "PrezzoDataGridViewTextBoxColumn"
        Me.PrezzoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrezzoDataGridViewTextBoxColumn.Width = 64
        '
        'ImgDataGridViewImageColumn
        '
        Me.ImgDataGridViewImageColumn.DataPropertyName = "Img"
        Me.ImgDataGridViewImageColumn.HeaderText = "Img"
        Me.ImgDataGridViewImageColumn.Name = "ImgDataGridViewImageColumn"
        Me.ImgDataGridViewImageColumn.ReadOnly = True
        Me.ImgDataGridViewImageColumn.Visible = False
        Me.ImgDataGridViewImageColumn.Width = 30
        '
        'DataCreazioneDataGridViewTextBoxColumn
        '
        Me.DataCreazioneDataGridViewTextBoxColumn.DataPropertyName = "Data_Creazione"
        Me.DataCreazioneDataGridViewTextBoxColumn.HeaderText = "Creazione"
        Me.DataCreazioneDataGridViewTextBoxColumn.Name = "DataCreazioneDataGridViewTextBoxColumn"
        Me.DataCreazioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataCreazioneDataGridViewTextBoxColumn.Width = 79
        '
        'ImballiBindingSource
        '
        Me.ImballiBindingSource.DataMember = "Imballi"
        Me.ImballiBindingSource.DataSource = Me.ModPackDBDataSet
        '
        'ModPackDBDataSet
        '
        Me.ModPackDBDataSet.DataSetName = "ModPackDBDataSet"
        Me.ModPackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DgwDistinta
        '
        Me.DgwDistinta.AllowUserToAddRows = False
        Me.DgwDistinta.AllowUserToDeleteRows = False
        Me.DgwDistinta.AllowUserToResizeColumns = False
        Me.DgwDistinta.AllowUserToResizeRows = False
        Me.DgwDistinta.AutoGenerateColumns = False
        Me.DgwDistinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwDistinta.ColumnHeadersVisible = False
        Me.DgwDistinta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.ImballoDataGridViewTextBoxColumn1, Me.RigaDataGridViewTextBoxColumn, Me.PartDataGridViewTextBoxColumn, Me.XDataGridViewTextBoxColumn, Me.YDataGridViewTextBoxColumn, Me.ZDataGridViewTextBoxColumn, Me.NDataGridViewTextBoxColumn, Me.TagDataGridViewTextBoxColumn})
        Me.DgwDistinta.DataSource = Me.ImballiDistintaBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwDistinta.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgwDistinta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgwDistinta.GridColor = System.Drawing.Color.Gainsboro
        Me.DgwDistinta.Location = New System.Drawing.Point(0, 0)
        Me.DgwDistinta.Name = "DgwDistinta"
        Me.DgwDistinta.ReadOnly = True
        Me.DgwDistinta.RowHeadersVisible = False
        Me.DgwDistinta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwDistinta.Size = New System.Drawing.Size(96, 100)
        Me.DgwDistinta.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        Me.IdDataGridViewTextBoxColumn1.Width = 41
        '
        'ImballoDataGridViewTextBoxColumn1
        '
        Me.ImballoDataGridViewTextBoxColumn1.DataPropertyName = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn1.HeaderText = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn1.Name = "ImballoDataGridViewTextBoxColumn1"
        Me.ImballoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ImballoDataGridViewTextBoxColumn1.Visible = False
        Me.ImballoDataGridViewTextBoxColumn1.Width = 65
        '
        'RigaDataGridViewTextBoxColumn
        '
        Me.RigaDataGridViewTextBoxColumn.DataPropertyName = "Riga"
        Me.RigaDataGridViewTextBoxColumn.HeaderText = "Riga"
        Me.RigaDataGridViewTextBoxColumn.Name = "RigaDataGridViewTextBoxColumn"
        Me.RigaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RigaDataGridViewTextBoxColumn.Width = 40
        '
        'PartDataGridViewTextBoxColumn
        '
        Me.PartDataGridViewTextBoxColumn.DataPropertyName = "Part"
        Me.PartDataGridViewTextBoxColumn.HeaderText = "Part"
        Me.PartDataGridViewTextBoxColumn.Name = "PartDataGridViewTextBoxColumn"
        Me.PartDataGridViewTextBoxColumn.ReadOnly = True
        Me.PartDataGridViewTextBoxColumn.Width = 40
        '
        'XDataGridViewTextBoxColumn
        '
        Me.XDataGridViewTextBoxColumn.DataPropertyName = "X"
        Me.XDataGridViewTextBoxColumn.HeaderText = "X"
        Me.XDataGridViewTextBoxColumn.Name = "XDataGridViewTextBoxColumn"
        Me.XDataGridViewTextBoxColumn.ReadOnly = True
        Me.XDataGridViewTextBoxColumn.Width = 60
        '
        'YDataGridViewTextBoxColumn
        '
        Me.YDataGridViewTextBoxColumn.DataPropertyName = "Y"
        Me.YDataGridViewTextBoxColumn.HeaderText = "Y"
        Me.YDataGridViewTextBoxColumn.Name = "YDataGridViewTextBoxColumn"
        Me.YDataGridViewTextBoxColumn.ReadOnly = True
        Me.YDataGridViewTextBoxColumn.Width = 60
        '
        'ZDataGridViewTextBoxColumn
        '
        Me.ZDataGridViewTextBoxColumn.DataPropertyName = "Z"
        Me.ZDataGridViewTextBoxColumn.HeaderText = "Z"
        Me.ZDataGridViewTextBoxColumn.Name = "ZDataGridViewTextBoxColumn"
        Me.ZDataGridViewTextBoxColumn.ReadOnly = True
        Me.ZDataGridViewTextBoxColumn.Width = 60
        '
        'NDataGridViewTextBoxColumn
        '
        Me.NDataGridViewTextBoxColumn.DataPropertyName = "N"
        Me.NDataGridViewTextBoxColumn.HeaderText = "N"
        Me.NDataGridViewTextBoxColumn.Name = "NDataGridViewTextBoxColumn"
        Me.NDataGridViewTextBoxColumn.ReadOnly = True
        Me.NDataGridViewTextBoxColumn.Width = 60
        '
        'TagDataGridViewTextBoxColumn
        '
        Me.TagDataGridViewTextBoxColumn.DataPropertyName = "Tag"
        Me.TagDataGridViewTextBoxColumn.HeaderText = "Tag"
        Me.TagDataGridViewTextBoxColumn.Name = "TagDataGridViewTextBoxColumn"
        Me.TagDataGridViewTextBoxColumn.ReadOnly = True
        Me.TagDataGridViewTextBoxColumn.Width = 60
        '
        'ImballiDistintaBindingSource
        '
        Me.ImballiDistintaBindingSource.DataMember = "Imballi_Distinta"
        Me.ImballiDistintaBindingSource.DataSource = Me.ImballiBindingSource
        '
        'DgwIndici
        '
        Me.DgwIndici.AllowUserToAddRows = False
        Me.DgwIndici.AllowUserToDeleteRows = False
        Me.DgwIndici.AllowUserToResizeColumns = False
        Me.DgwIndici.AllowUserToResizeRows = False
        Me.DgwIndici.AutoGenerateColumns = False
        Me.DgwIndici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgwIndici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwIndici.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn2, Me.ImballoDataGridViewTextBoxColumn2, Me.IndiceDataGridViewTextBoxColumn, Me.CodiceDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.RivestTotDataGridViewTextBoxColumn, Me.NoteBICDataGridViewTextBoxColumn})
        Me.DgwIndici.DataSource = Me.ImballiIndiciBindingSource1
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwIndici.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgwIndici.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgwIndici.Location = New System.Drawing.Point(0, 0)
        Me.DgwIndici.Name = "DgwIndici"
        Me.DgwIndici.ReadOnly = True
        Me.DgwIndici.RowHeadersVisible = False
        Me.DgwIndici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwIndici.Size = New System.Drawing.Size(465, 193)
        Me.DgwIndici.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn2.Visible = False
        '
        'ImballoDataGridViewTextBoxColumn2
        '
        Me.ImballoDataGridViewTextBoxColumn2.DataPropertyName = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn2.HeaderText = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn2.Name = "ImballoDataGridViewTextBoxColumn2"
        Me.ImballoDataGridViewTextBoxColumn2.ReadOnly = True
        Me.ImballoDataGridViewTextBoxColumn2.Visible = False
        '
        'IndiceDataGridViewTextBoxColumn
        '
        Me.IndiceDataGridViewTextBoxColumn.DataPropertyName = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.HeaderText = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.Name = "IndiceDataGridViewTextBoxColumn"
        Me.IndiceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodiceDataGridViewTextBoxColumn
        '
        Me.CodiceDataGridViewTextBoxColumn.DataPropertyName = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.CodiceDataGridViewTextBoxColumn.Name = "CodiceDataGridViewTextBoxColumn"
        Me.CodiceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note1"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RivestTotDataGridViewTextBoxColumn
        '
        Me.RivestTotDataGridViewTextBoxColumn.DataPropertyName = "Rivest_Tot"
        Me.RivestTotDataGridViewTextBoxColumn.HeaderText = "Note2"
        Me.RivestTotDataGridViewTextBoxColumn.Name = "RivestTotDataGridViewTextBoxColumn"
        Me.RivestTotDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoteBICDataGridViewTextBoxColumn
        '
        Me.NoteBICDataGridViewTextBoxColumn.DataPropertyName = "Note_BIC"
        Me.NoteBICDataGridViewTextBoxColumn.HeaderText = "Note Bicciato"
        Me.NoteBICDataGridViewTextBoxColumn.Name = "NoteBICDataGridViewTextBoxColumn"
        Me.NoteBICDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImballiIndiciBindingSource1
        '
        Me.ImballiIndiciBindingSource1.DataMember = "Imballi_Indici"
        Me.ImballiIndiciBindingSource1.DataSource = Me.ImballiBindingSource
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bt_Colonne, Me.Bt_Refresh, Me.Bt_FiltroNome, Me.Bt_Filtro, Me.Bt_MostraInfo, Me.Bt_MostraDistinta, Me.ToolStripSeparator1, Me.Bt_Modifica, Me.Bt_Simili, Me.Bt_StampaImballo, Me.Bt_MostraNuovi, Me.Bt_PulisciNuovi, Me.Bt_Note})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1159, 36)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Bt_Colonne
        '
        Me.Bt_Colonne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Bt_Colonne.Image = CType(resources.GetObject("Bt_Colonne.Image"), System.Drawing.Image)
        Me.Bt_Colonne.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Colonne.Name = "Bt_Colonne"
        Me.Bt_Colonne.Size = New System.Drawing.Size(23, 33)
        Me.Bt_Colonne.Text = "Colonne"
        '
        'Bt_Refresh
        '
        Me.Bt_Refresh.Image = CType(resources.GetObject("Bt_Refresh.Image"), System.Drawing.Image)
        Me.Bt_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Refresh.Name = "Bt_Refresh"
        Me.Bt_Refresh.Size = New System.Drawing.Size(66, 33)
        Me.Bt_Refresh.Text = "Refresh"
        '
        'Bt_FiltroNome
        '
        Me.Bt_FiltroNome.Image = CType(resources.GetObject("Bt_FiltroNome.Image"), System.Drawing.Image)
        Me.Bt_FiltroNome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_FiltroNome.Name = "Bt_FiltroNome"
        Me.Bt_FiltroNome.Size = New System.Drawing.Size(57, 33)
        Me.Bt_FiltroNome.Text = "Cerca"
        '
        'Bt_Filtro
        '
        Me.Bt_Filtro.Image = CType(resources.GetObject("Bt_Filtro.Image"), System.Drawing.Image)
        Me.Bt_Filtro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Filtro.Name = "Bt_Filtro"
        Me.Bt_Filtro.Size = New System.Drawing.Size(53, 33)
        Me.Bt_Filtro.Text = "Filtra"
        '
        'Bt_MostraInfo
        '
        Me.Bt_MostraInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Bt_MostraInfo.Image = CType(resources.GetObject("Bt_MostraInfo.Image"), System.Drawing.Image)
        Me.Bt_MostraInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_MostraInfo.Name = "Bt_MostraInfo"
        Me.Bt_MostraInfo.Size = New System.Drawing.Size(23, 33)
        Me.Bt_MostraInfo.ToolTipText = "Mostra info"
        '
        'Bt_MostraDistinta
        '
        Me.Bt_MostraDistinta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Bt_MostraDistinta.Image = CType(resources.GetObject("Bt_MostraDistinta.Image"), System.Drawing.Image)
        Me.Bt_MostraDistinta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_MostraDistinta.Name = "Bt_MostraDistinta"
        Me.Bt_MostraDistinta.Size = New System.Drawing.Size(23, 33)
        Me.Bt_MostraDistinta.ToolTipText = "Mostra distinta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'Bt_Modifica
        '
        Me.Bt_Modifica.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Bt_Modifica.Image = CType(resources.GetObject("Bt_Modifica.Image"), System.Drawing.Image)
        Me.Bt_Modifica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Modifica.Name = "Bt_Modifica"
        Me.Bt_Modifica.Size = New System.Drawing.Size(117, 33)
        Me.Bt_Modifica.Text = "Modifica imballo"
        '
        'Bt_Simili
        '
        Me.Bt_Simili.Image = CType(resources.GetObject("Bt_Simili.Image"), System.Drawing.Image)
        Me.Bt_Simili.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Simili.Name = "Bt_Simili"
        Me.Bt_Simili.Size = New System.Drawing.Size(95, 33)
        Me.Bt_Simili.Text = "Imballi Simili"
        '
        'Bt_StampaImballo
        '
        Me.Bt_StampaImballo.Image = CType(resources.GetObject("Bt_StampaImballo.Image"), System.Drawing.Image)
        Me.Bt_StampaImballo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_StampaImballo.Name = "Bt_StampaImballo"
        Me.Bt_StampaImballo.Size = New System.Drawing.Size(67, 33)
        Me.Bt_StampaImballo.Text = "Stampa"
        '
        'Bt_MostraNuovi
        '
        Me.Bt_MostraNuovi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Bt_MostraNuovi.Image = CType(resources.GetObject("Bt_MostraNuovi.Image"), System.Drawing.Image)
        Me.Bt_MostraNuovi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_MostraNuovi.Name = "Bt_MostraNuovi"
        Me.Bt_MostraNuovi.Size = New System.Drawing.Size(99, 33)
        Me.Bt_MostraNuovi.Text = "Mostra Nuovi"
        '
        'Bt_PulisciNuovi
        '
        Me.Bt_PulisciNuovi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Bt_PulisciNuovi.Image = CType(resources.GetObject("Bt_PulisciNuovi.Image"), System.Drawing.Image)
        Me.Bt_PulisciNuovi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_PulisciNuovi.Name = "Bt_PulisciNuovi"
        Me.Bt_PulisciNuovi.Size = New System.Drawing.Size(123, 33)
        Me.Bt_PulisciNuovi.Text = "Pulisci Lista Nuovi"
        '
        'Bt_Note
        '
        Me.Bt_Note.Image = CType(resources.GetObject("Bt_Note.Image"), System.Drawing.Image)
        Me.Bt_Note.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Bt_Note.Name = "Bt_Note"
        Me.Bt_Note.Size = New System.Drawing.Size(53, 33)
        Me.Bt_Note.Text = "Note"
        '
        'SplitSopra
        '
        Me.SplitSopra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitSopra.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitSopra.IsSplitterFixed = True
        Me.SplitSopra.Location = New System.Drawing.Point(0, 0)
        Me.SplitSopra.Name = "SplitSopra"
        '
        'SplitSopra.Panel1
        '
        Me.SplitSopra.Panel1.Controls.Add(Me.DgwImballi)
        '
        'SplitSopra.Panel2
        '
        Me.SplitSopra.Panel2.Controls.Add(Me.DgwDistinta)
        Me.SplitSopra.Panel2Collapsed = True
        Me.SplitSopra.Size = New System.Drawing.Size(1159, 666)
        Me.SplitSopra.SplitterDistance = 748
        Me.SplitSopra.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Lbl_Conteggio})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 702)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1159, 23)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(47, 18)
        Me.ToolStripStatusLabel1.Text = "Record:"
        '
        'Lbl_Conteggio
        '
        Me.Lbl_Conteggio.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Lbl_Conteggio.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Conteggio.Name = "Lbl_Conteggio"
        Me.Lbl_Conteggio.Size = New System.Drawing.Size(35, 18)
        Me.Lbl_Conteggio.Text = "Nrec"
        '
        'PrintImballo
        '
        '
        'ImballiIndiciBindingSource
        '
        Me.ImballiIndiciBindingSource.DataMember = "Imballi_Indici"
        Me.ImballiIndiciBindingSource.DataSource = Me.ImballiBindingSource
        '
        'DGW_Note
        '
        Me.DGW_Note.AllowUserToAddRows = False
        Me.DGW_Note.AllowUserToResizeColumns = False
        Me.DGW_Note.AllowUserToResizeRows = False
        Me.DGW_Note.AutoGenerateColumns = False
        Me.DGW_Note.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGW_Note.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGW_Note.BackgroundColor = System.Drawing.Color.White
        Me.DGW_Note.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW_Note.ColumnHeadersVisible = False
        Me.DGW_Note.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn3, Me.ImballoDataGridViewTextBoxColumn3, Me.NotaDataGridViewTextBoxColumn})
        Me.DGW_Note.DataSource = Me.ImballiNoteImballiBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGW_Note.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGW_Note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGW_Note.Location = New System.Drawing.Point(0, 0)
        Me.DGW_Note.Name = "DGW_Note"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightYellow
        Me.DGW_Note.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGW_Note.Size = New System.Drawing.Size(690, 193)
        Me.DGW_Note.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn3
        '
        Me.IdDataGridViewTextBoxColumn3.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn3.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn3.Name = "IdDataGridViewTextBoxColumn3"
        Me.IdDataGridViewTextBoxColumn3.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn3.Visible = False
        '
        'ImballoDataGridViewTextBoxColumn3
        '
        Me.ImballoDataGridViewTextBoxColumn3.DataPropertyName = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn3.HeaderText = "Imballo"
        Me.ImballoDataGridViewTextBoxColumn3.Name = "ImballoDataGridViewTextBoxColumn3"
        Me.ImballoDataGridViewTextBoxColumn3.Visible = False
        '
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "Nota"
        Me.NotaDataGridViewTextBoxColumn.HeaderText = "Nota"
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        '
        'ImballiNoteImballiBindingSource
        '
        Me.ImballiNoteImballiBindingSource.DataMember = "Imballi_NoteImballi"
        Me.ImballiNoteImballiBindingSource.DataSource = Me.ImballiBindingSource
        '
        'ImballiTableAdapter
        '
        Me.ImballiTableAdapter.ClearBeforeFill = True
        '
        'DistintaTableAdapter
        '
        Me.DistintaTableAdapter.ClearBeforeFill = True
        '
        'IndiciTableAdapter
        '
        Me.IndiciTableAdapter.ClearBeforeFill = True
        '
        'NoteImballiTableAdapter
        '
        Me.NoteImballiTableAdapter.ClearBeforeFill = True
        '
        'SplitIntero
        '
        Me.SplitIntero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitIntero.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitIntero.Location = New System.Drawing.Point(0, 36)
        Me.SplitIntero.Name = "SplitIntero"
        Me.SplitIntero.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitIntero.Panel1
        '
        Me.SplitIntero.Panel1.Controls.Add(Me.SplitSopra)
        '
        'SplitIntero.Panel2
        '
        Me.SplitIntero.Panel2.Controls.Add(Me.SplitSotto)
        Me.SplitIntero.Panel2Collapsed = True
        Me.SplitIntero.Size = New System.Drawing.Size(1159, 666)
        Me.SplitIntero.SplitterDistance = 469
        Me.SplitIntero.TabIndex = 5
        '
        'SplitSotto
        '
        Me.SplitSotto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitSotto.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitSotto.Location = New System.Drawing.Point(0, 0)
        Me.SplitSotto.Name = "SplitSotto"
        '
        'SplitSotto.Panel1
        '
        Me.SplitSotto.Panel1.Controls.Add(Me.DGW_Note)
        '
        'SplitSotto.Panel2
        '
        Me.SplitSotto.Panel2.Controls.Add(Me.DgwIndici)
        Me.SplitSotto.Size = New System.Drawing.Size(1159, 193)
        Me.SplitSotto.SplitterDistance = 690
        Me.SplitSotto.TabIndex = 0
        '
        'Form_Imballi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 725)
        Me.Controls.Add(Me.SplitIntero)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Imballi"
        Me.Text = "Archivio Imballi"
        CType(Me.DgwImballi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImballiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgwDistinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImballiDistintaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgwIndici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImballiIndiciBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitSopra.Panel1.ResumeLayout(False)
        Me.SplitSopra.Panel2.ResumeLayout(False)
        CType(Me.SplitSopra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitSopra.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ImballiIndiciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGW_Note, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImballiNoteImballiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitIntero.Panel1.ResumeLayout(False)
        Me.SplitIntero.Panel2.ResumeLayout(False)
        CType(Me.SplitIntero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitIntero.ResumeLayout(False)
        Me.SplitSotto.Panel1.ResumeLayout(False)
        Me.SplitSotto.Panel2.ResumeLayout(False)
        CType(Me.SplitSotto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitSotto.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgwImballi As DataGridView
    Friend WithEvents DgwDistinta As DataGridView
    Friend WithEvents DgwIndici As DataGridView
    Friend WithEvents ModPackDBDataSet As ModPackDBDataSet
    Friend WithEvents ImballiBindingSource As BindingSource
    Friend WithEvents ImballiTableAdapter As ModPackDBDataSetTableAdapters.ImballiTableAdapter
    Friend WithEvents ImballiDistintaBindingSource As BindingSource
    Friend WithEvents DistintaTableAdapter As ModPackDBDataSetTableAdapters.DistintaTableAdapter
    Friend WithEvents ImballiIndiciBindingSource As BindingSource
    Friend WithEvents IndiciTableAdapter As ModPackDBDataSetTableAdapters.IndiciTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SplitSopra As SplitContainer
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ImballoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RigaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents XDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bt_Modifica As ToolStripButton
    Friend WithEvents Bt_Refresh As ToolStripButton
    Friend WithEvents Bt_StampaImballo As ToolStripButton
    Friend WithEvents Bt_Filtro As ToolStripButton
    Friend WithEvents Bt_FiltroNome As ToolStripButton
    Friend WithEvents Bt_MostraNuovi As ToolStripButton
    Friend WithEvents Bt_PulisciNuovi As ToolStripButton
    Friend WithEvents IdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ImballoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IndiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RivestTotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteBICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImballiIndiciBindingSource1 As BindingSource
    Friend WithEvents PrintImballo As Printing.PrintDocument
    Friend WithEvents Bt_Colonne As ToolStripButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZoccoliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RivestimentoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TipoRivestimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HTDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DTDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BMDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DiagonaliDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GradiFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradiTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimoMoraleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents M2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents M3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImgDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents DataCreazioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bt_Simili As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Lbl_Conteggio As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents DGW_Note As DataGridView
    Friend WithEvents ImballiNoteImballiBindingSource As BindingSource
    Friend WithEvents NoteImballiTableAdapter As ModPackDBDataSetTableAdapters.NoteImballiTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ImballoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents NotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bt_Note As ToolStripButton
    Friend WithEvents Bt_MostraDistinta As ToolStripButton
    Friend WithEvents SplitIntero As SplitContainer
    Friend WithEvents SplitSotto As SplitContainer
    Friend WithEvents Bt_MostraInfo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
