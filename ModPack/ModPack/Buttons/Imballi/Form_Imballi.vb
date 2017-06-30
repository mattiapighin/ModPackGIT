Public Class Form_Imballi

    Dim Row As New RigaOrdine

    Private Sub Rinfresh()
        Bt_MostraNuovi.Text = "Imballi Nuovi (" & Ordine.ListaNuovi.Count & ")"

        Me.IndiciTableAdapter.Fill(Me.ModPackDBDataSet.Indici)
        Me.DistintaTableAdapter.Fill(Me.ModPackDBDataSet.Distinta)
        Me.ImballiTableAdapter.Fill(Me.ModPackDBDataSet.Imballi)

        'Carica solo le ultime N righe da imballi
        If Not ModPackDBDataSet.Imballi.Count = 0 Then
            Dim IndiceMax As Integer = ModPackDBDataSet.Imballi.Compute("MAX(Id)", "")
            If Not My.Settings.ImballiNRecords = 0 Then
                ImballiBindingSource.Filter = "Id > '" & IndiceMax - My.Settings.ImballiNRecords & "'"
            Else
                ImballiBindingSource.Filter = Nothing
            End If
        End If

        FiltraColonne()

    End Sub

    Private Sub Form_Imballi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rinfresh()
    End Sub


    Private Sub Bt_Modifica_Click(sender As Object, e As EventArgs) Handles Bt_Modifica.Click
        Form_ModificaImballo.Show()
        Form_ModificaImballo.CbImballo.Text = DgwImballi.CurrentRow.Cells(1).Value
        Form_ModificaImballo.CaricaCodiceNoEdit()
    End Sub

    Private Sub Bt_Refresh_Click(sender As Object, e As EventArgs) Handles Bt_Refresh.Click
        Rinfresh()
    End Sub

    Private Sub Bt_FiltroNome_Click(sender As Object, e As EventArgs) Handles Bt_FiltroNome.Click
        ImballiBindingSource.Filter = Nothing
        Dim Nome As String = InputBox("Ricerca imballo:", "Cerca per nome", "")
        If Not String.IsNullOrEmpty(Nome) Then
            ImballiBindingSource.Filter = "Imballo LIKE '" & Nome & "'"
        End If
    End Sub

    Private Sub Bt_PulisciNuovi_Click(sender As Object, e As EventArgs) Handles Bt_PulisciNuovi.Click
        If MsgBox("Sei sicuro di voler pulire la lista dei nuovi imballi?", vbYesNo, "Pulisci lista nuovi") = MsgBoxResult.Yes Then
            Ordine.ListaNuovi.Clear()
            MsgBox("Pulizia effettuata!", vbInformation, "Pulisci lista nuovi")
            LOG.Write("Lista nuovi codici pulita")
            Rinfresh()
        End If

    End Sub

    Private Sub Bt_MostraNuovi_Click(sender As Object, e As EventArgs) Handles Bt_MostraNuovi.Click
        Ordine.MostraNuovi()
    End Sub

    Private Sub Bt_StampaImballo_Click(sender As Object, e As EventArgs) Handles Bt_StampaImballo.Click
        Dim Imballo As String = ""
        Dim L As Integer
        Dim P As Integer
        Dim H As Integer
        Dim Tipo As String
        Dim Zoccoli As String = ""
        Dim Rivestimento As Boolean
        Dim TipoRivestimento As String = ""
        Dim HT As Boolean
        Dim DT As Boolean
        Dim BM As Boolean
        Dim Diagonali As Boolean
        Dim Note As String = ""
        Dim Rivest_Tot As String = ""
        Dim Indice As Integer
        Dim Codice As String = ""

        'Carico le variabili in una falsa riga di ordine
        Using TableImballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
            Using TableIndex As New ModPackDBDataSetTableAdapters.IndiciTableAdapter

                Using DS As New ModPackDBDataSet

                    TableImballi.Fill(DS.Imballi)
                    TableIndex.Fill(DS.Indici)

                    Dim RigaImballo() As DataRow = DS.Imballi.Select("Id = '" & DgwImballi.CurrentRow.Cells(0).Value & "'")

                    Imballo = RigaImballo(0)(1)
                    L = RigaImballo(0)(2)
                    P = RigaImballo(0)(3)
                    H = RigaImballo(0)(4)
                    Tipo = RigaImballo(0)(5)
                    Zoccoli = RigaImballo(0)(6)
                    Rivestimento = RigaImballo(0)(7)
                    TipoRivestimento = RigaImballo(0)(8)
                    HT = RigaImballo(0)(9)
                    DT = RigaImballo(0)(10)
                    BM = RigaImballo(0)(11)
                    Diagonali = RigaImballo(0)(12)

                    If Not DgwIndici.RowCount = 0 Then
                        Dim RigaIndice() As DataRow = DS.Indici.Select("Indice = '" & DgwIndici.CurrentRow.Cells(2).Value & "'")

                        Indice = RigaIndice(0)(2)
                        Note = RigaIndice(0)(4)
                        Rivest_Tot = RigaIndice(0)(5)
                        Codice = RigaIndice(0)(3)
                    End If

                End Using
            End Using
        End Using

        With Row
            .NumeroOrdine = ""
            .Riga = 0
            .Imballo = Imballo
            .Indice = Indice
            .Qt = 0
            .Cliente = ""
            .Codice = Codice
            .Commessa = ""
            .L = L
            .P = P
            .H = H
            .Tipo = Tipo
            .Zoccoli = Zoccoli
            .Rivestimento = Rivestimento
            .TipoRivestimento = TipoRivestimento
            .Note = Note
            .DataConsegna = Nothing
            .HT = HT
            .BM = BM
            .DT = DT
            .Rivest_Tot = Rivest_Tot
            .Magazzino = ""
            .Diagonali = Diagonali
            .Data_Ordine = Date.Now.Date
            .Evaso = False
            .Produzione = False
            .Stampato = False
        End With

        PrintImballo.DefaultPageSettings = My.Settings.FormatoStampa

        Dim Preview As New PrintPreviewDialog With {.Document = PrintImballo, .StartPosition = FormStartPosition.CenterScreen, .TopMost = True, .WindowState = FormWindowState.Maximized}
        Preview.ShowDialog()

    End Sub

    Private Sub PrintImballo_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintImballo.PrintPage
        Stampe.Stampa_Distinte(sender, e, Row)
    End Sub

    Private Sub Bt_Filtro_Click(sender As Object, e As EventArgs) Handles Bt_Filtro.Click
        Dim Filtro As String = ""
        If Form_Imballi_Filtro.ShowDialog = DialogResult.OK Then
            Filtro = Form_Imballi_Filtro.Filtro

            ImballiBindingSource.Filter = Nothing
            If Not String.IsNullOrEmpty(Filtro) Then
                ImballiBindingSource.Filter = Filtro
            End If
        End If
    End Sub

    Private Sub FiltraColonne()

        Dim Filtro As String = My.Settings.FiltroColonneImballi

        If Filtro.Length = 21 Then
            For K = 0 To 20
                If Filtro(K) = "0" Then
                    DgwImballi.Columns(K).Visible = False
                Else
                    DgwImballi.Columns(K).Visible = True
                End If
            Next
        End If


    End Sub

    Private Sub Bt_Colonne_Click(sender As Object, e As EventArgs) Handles Bt_Colonne.Click
        If Form_Imballi_Colonne.ShowDialog = DialogResult.OK Then
            FiltraColonne()
            Rinfresh()
        End If
    End Sub

    Private Sub DgwImballi_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgwImballi.CellDoubleClick
        Bt_Modifica_Click(sender, e)
    End Sub
End Class



