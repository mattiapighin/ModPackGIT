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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Imballi))
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
        Me.Bt_Modifica = New System.Windows.Forms.ToolStripButton()
        Me.Bt_Simili = New System.Windows.Forms.ToolStripButton()
        Me.Bt_StampaImballo = New System.Windows.Forms.ToolStripButton()
        Me.Bt_MostraNuovi = New System.Windows.Forms.ToolStripButton()
        Me.Bt_PulisciNuovi = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PrintImballo = New System.Drawing.Printing.PrintDocument()
        Me.ImballiIndiciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImballiTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.ImballiTableAdapter()
        Me.DistintaTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.DistintaTableAdapter()
        Me.IndiciTableAdapter = New ModPack.ModPackDBDataSetTableAdapters.IndiciTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Lbl_Conteggio = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DgwImballi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModPackDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgwDistinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiDistintaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgwIndici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImballiIndiciBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ImballiIndiciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgwImballi
        '
        Me.DgwImballi.AllowUserToAddRows = False
        Me.DgwImballi.AllowUserToDeleteRows = False
        Me.DgwImballi.AllowUserToResizeColumns = False
        Me.DgwImballi.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.PeachPuff
        Me.DgwImballi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DgwImballi.AutoGenerateColumns = False
        Me.DgwImballi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgwImballi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgwImballi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ImballoDataGridViewTextBoxColumn, Me.LDataGridViewTextBoxColumn, Me.PDataGridViewTextBoxColumn, Me.HDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.ZoccoliDataGridViewTextBoxColumn, Me.RivestimentoDataGridViewCheckBoxColumn, Me.TipoRivestimentoDataGridViewTextBoxColumn, Me.HTDataGridViewCheckBoxColumn, Me.DTDataGridViewCheckBoxColumn, Me.BMDataGridViewCheckBoxColumn, Me.DiagonaliDataGridViewCheckBoxColumn, Me.GradiFDataGridViewTextBoxColumn, Me.GradiTDataGridViewTextBoxColumn, Me.PrimoMoraleDataGridViewTextBoxColumn, Me.M2DataGridViewTextBoxColumn, Me.M3DataGridViewTextBoxColumn, Me.PrezzoDataGridViewTextBoxColumn, Me.ImgDataGridViewImageColumn, Me.DataCreazioneDataGridViewTextBoxColumn})
        Me.DgwImballi.DataSource = Me.ImballiBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwImballi.DefaultCellStyle = DataGridViewCellStyle10
        Me.DgwImballi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgwImballi.Location = New System.Drawing.Point(0, 0)
        Me.DgwImballi.Name = "DgwImballi"
        Me.DgwImballi.ReadOnly = True
        Me.DgwImballi.RowHeadersVisible = False
        Me.DgwImballi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwImballi.Size = New System.Drawing.Size(748, 498)
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
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwDistinta.DefaultCellStyle = DataGridViewCellStyle11
        Me.DgwDistinta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgwDistinta.GridColor = System.Drawing.Color.Gainsboro
        Me.DgwDistinta.Location = New System.Drawing.Point(0, 0)
        Me.DgwDistinta.Name = "DgwDistinta"
        Me.DgwDistinta.ReadOnly = True
        Me.DgwDistinta.RowHeadersVisible = False
        Me.DgwDistinta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwDistinta.Size = New System.Drawing.Size(407, 349)
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
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgwIndici.DefaultCellStyle = DataGridViewCellStyle12
        Me.DgwIndici.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgwIndici.Location = New System.Drawing.Point(0, 0)
        Me.DgwIndici.Name = "DgwIndici"
        Me.DgwIndici.ReadOnly = True
        Me.DgwIndici.RowHeadersVisible = False
        Me.DgwIndici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgwIndici.Size = New System.Drawing.Size(407, 145)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bt_Colonne, Me.Bt_Refresh, Me.Bt_FiltroNome, Me.Bt_Filtro, Me.Bt_Modifica, Me.Bt_Simili, Me.Bt_StampaImballo, Me.Bt_MostraNuovi, Me.Bt_PulisciNuovi})
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DgwImballi)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1159, 498)
        Me.SplitContainer1.SplitterDistance = 748
        Me.SplitContainer1.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DgwDistinta)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DgwIndici)
        Me.SplitContainer2.Size = New System.Drawing.Size(407, 498)
        Me.SplitContainer2.SplitterDistance = 349
        Me.SplitContainer2.TabIndex = 0
        '
        'PrintImballo
        '
        '
        'ImballiIndiciBindingSource
        '
        Me.ImballiIndiciBindingSource.DataMember = "Imballi_Indici"
        Me.ImballiIndiciBindingSource.DataSource = Me.ImballiBindingSource
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lbl_Conteggio})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 476)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(748, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Lbl_Conteggio
        '
        Me.Lbl_Conteggio.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Conteggio.Name = "Lbl_Conteggio"
        Me.Lbl_Conteggio.Size = New System.Drawing.Size(92, 17)
        Me.Lbl_Conteggio.Text = "Record Mostrati"
        '
        'Form_Imballi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 534)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
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
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ImballiIndiciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
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
End Class
