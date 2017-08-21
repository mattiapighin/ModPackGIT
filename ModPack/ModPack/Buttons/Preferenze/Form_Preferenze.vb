Public Class Form_Preferenze

    Private Sub Bt_FormatoStampa_Click(sender As Object, e As EventArgs) Handles Bt_FormatoStampa.Click
        Dim PageFormat As New PageSetupDialog With {.Document = New Printing.PrintDocument, .EnableMetric = True}

        If Not My.Settings.FormatoStampa Is Nothing Then PageFormat.PageSettings = My.Settings.FormatoStampa

        If PageFormat.ShowDialog = DialogResult.OK Then
            My.Settings.FormatoStampa = PageFormat.PageSettings
            My.Settings.Save()
        End If


    End Sub
    Private Sub CaricaSettingsEtichette()
        With My.Settings
            Txt_MargineBottom.Text = .Etichette_MargineBottom
            Txt_MargineTop.Text = .Etichette_MargineTop
            Txt_MargineRight.Text = .Etichette_MargineRight
            Txt_MargineLeft.Text = .Etichette_MargineLeft
            Txt_mmX.Text = .Etichette_DimensioneX
            Txt_mmY.Text = .Etichette_DimensioneY
            Txt_NomeStampante.Text = .Etichette_Stampante
        End With
    End Sub
    Private Sub SalvaSettingsEtichette()
        With My.Settings
            .Etichette_MargineBottom = Txt_MargineBottom.Text
            .Etichette_MargineTop = Txt_MargineTop.Text
            .Etichette_MargineRight = Txt_MargineRight.Text
            .Etichette_MargineLeft = Txt_MargineLeft.Text
            .Etichette_DimensioneX = Txt_mmX.Text
            .Etichette_DimensioneY = Txt_mmY.Text
            .Etichette_Stampante = Txt_NomeStampante.Text
            My.Settings.Save()
        End With
    End Sub

    Private Sub CaricaSettingsCK()
        Ck_Evaso.Checked = My.Settings.CK_ConfermaEvaso
        Ck_ColoraScaduti.Checked = My.Settings.OrdiniAperti_ColoraScaduti
        Ck_ColoraEvasi.Checked = My.Settings.OrdiniAperti_ColoraEvasi
        Ck_CheckCaricamento.Checked = My.Settings.CheckInserimentoImballo
        Ck_BiancoNero.Checked = My.Settings.FormatoStampa.Color
        CkNoteDinamico.Checked = My.Settings.NoteDinamico
    End Sub
    Private Sub SalvaSettingsCK()
        My.Settings.CK_ConfermaEvaso = Ck_Evaso.Checked
        My.Settings.OrdiniAperti_ColoraScaduti = Ck_ColoraScaduti.Checked
        My.Settings.OrdiniAperti_ColoraEvasi = Ck_ColoraEvasi.Checked
        My.Settings.CheckInserimentoImballo = Ck_CheckCaricamento.Checked
        My.Settings.FormatoStampa.Color = Ck_BiancoNero.Checked
        My.Settings.NoteDinamico = CkNoteDinamico.Checked
    End Sub

    Private Sub CaricaSettingsDistinta()
        Ck_Barcode.Checked = My.Settings.StampaBarcodeDistinte
        CkCodiceQT.Checked = Not My.Settings.StampaBarcodeSoloCodice
        CkBarcodeSoloCodice.Checked = My.Settings.StampaBarcodeSoloCodice
        Nu_FontDistinta.Value = My.Settings.DimensioneFontDistinta
        Nu_RigheDistinta.Value = My.Settings.NumeroRigheDistinta
    End Sub
    Private Sub SalvaSettingsDistinta()
        My.Settings.StampaBarcodeDistinte = Ck_Barcode.Checked
        My.Settings.StampaBarcodeSoloCodice = CkBarcodeSoloCodice.Checked
        My.Settings.DimensioneFontDistinta = Nu_FontDistinta.Value
        My.Settings.NumeroRigheDistinta = Nu_RigheDistinta.Value
    End Sub

    Private Sub CaricaRiferimenti()
        Txt_utente.Text = My.Settings.Utente
        Txt_LimiteStorico.Text = My.Settings.OrdiniNRecords
        RBexcel_nuovi.Checked = My.Settings.ListaNuoviExcel
        RBtext_nuovi.Checked = Not My.Settings.ListaNuoviExcel
        TxtScegliExcel.Text = My.Settings.ExcelPath
        CkDeveloper.Checked = My.Settings.Developer
    End Sub
    Private Sub SalvaRiferimenti()
        If Not String.IsNullOrEmpty(Txt_utente.Text) Then My.Settings.Utente = Txt_utente.Text
        If Not String.IsNullOrEmpty(Txt_LimiteStorico.Text) Then My.Settings.OrdiniNRecords = Txt_LimiteStorico.Text
        My.Settings.ListaNuoviExcel = RBexcel_nuovi.Checked
        My.Settings.ListaNuoviExcel = Not RBtext_nuovi.Checked
        If Not String.IsNullOrEmpty(TxtScegliExcel.Text) Then My.Settings.ExcelPath = TxtScegliExcel.Text
        My.Settings.Developer = CkDeveloper.Checked
    End Sub


    Private Sub Form_Preferenze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaSettingsEtichette()
        CaricaSettingsCK()
        CaricaSettingsDistinta()
        CaricaRiferimenti()

    End Sub
    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("Salvare le modifiche?", vbYesNo, "Preferenze") = MsgBoxResult.Yes Then
            SalvaSettingsEtichette()
            SalvaSettingsCK()
            SalvaSettingsDistinta()
            SalvaRiferimenti()

            MsgBox("Modifiche salvate", vbOKOnly, "Preferenze")
            LOG.Write("Modificate preferenze")


        End If

    End Sub

    Private Sub Bt_SettingsEmail_Click(sender As Object, e As EventArgs) Handles Bt_SettingsEmail.Click
        Form_Preferenze_Email.Show()
    End Sub

    Private Sub Bt_TestConnessioni_Click(sender As Object, e As EventArgs) Handles Bt_TestConnessioni.Click
        Dim xml = XDocument.Load(My.Settings.XMLpath)
        Dim Ip_produzione As String = xml.<Data>.<IP_Produzione>.Value
        Dim Ip_sezionatrice As String = xml.<Data>.<IP_Sezionatrice>.Value

        If My.Computer.Network.Ping(Ip_produzione) Then
            MsgBox("PC Produzione connesso", vbOKOnly, "Test")
        Else
            MsgBox("PC Produzione disconnesso", vbCritical, "Test")
        End If


        If My.Computer.Network.Ping(Ip_sezionatrice) Then
            MsgBox("PC Sezionatrice connesso", vbOKOnly, "Test")
        Else
            MsgBox("PC Sezionatrice disconnesso", vbCritical, "Test")
        End If
    End Sub

    Private Sub Bt_ScegliExcel_Click(sender As Object, e As EventArgs) Handles Bt_ScegliExcel.Click
        Dim Dialog As New OpenFileDialog With {.Filter = ("Excel|*.exe"), .FileName = "Excel.exe", .Title = "Riferimento a Excel.exe"}
        If Dialog.ShowDialog = DialogResult.OK Then
            TxtScegliExcel.Text = Dialog.FileName
        End If
    End Sub

    Private Sub Bt_EliminaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_EliminaOrdine.Click
        Dim Ordine As String = ""
        Dim OrdineControllo As String = ""

        If MsgBox("Attenzione: L'ordine selezionato verrà eliminato definitivamente dal database" & vbCrLf & "Sei sicuro di voler continuare?", vbYesNo, "Elimina Ordine") = MsgBoxResult.Yes Then

            Ordine = InputBox("Inserisci ordine da eliminare", "Elimina Ordine", "")
            OrdineControllo = InputBox("Inserisci nuovamente ordine da eliminare", "Elimina Ordine", "")

            If Not Ordine = OrdineControllo Then
                MsgBox("I due numeri di ordine inseriti non corrispondono", MsgBoxStyle.Critical, "Elimina Ordine")
                Exit Sub
            End If

            If MsgBox("Vuoi eliminare anche gli indici degli imballi contenuti nell'ordine?", vbYesNo, "Elimina Ordine") = MsgBoxResult.No Then
                SQL.Query("DELETE FROM Ordini WHERE Ordine = '" & Ordine & "'")
                LOG.Write("Eliminato ordine " & Ordine)
                MsgBox("Eliminazione completata!", vbInformation, "Elimina Ordine")
            Else

                Dim ListaIndici As New List(Of Integer)

                Using Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                    Using DS As New ModPackDBDataSet.OrdiniDataTable
                        Table.Fill(DS)

                        Dim Rows() As DataRow = DS.Select("Ordine = '" & Ordine & "'")

                        For Each R As DataRow In Rows
                            ListaIndici.Add(R(4))
                        Next

                    End Using
                End Using

                '-------

                For Each Indice As Integer In ListaIndici
                    SQL.Query("DELETE FROM Indici WHERE Indice = '" & Indice & "'")
                    LOG.Write("Eliminato indice " & Indice)
                Next

                SQL.Query("DELETE FROM Ordini WHERE Ordine = '" & Ordine & "'")
                LOG.Write("Eliminato ordine " & Ordine)

                MsgBox("Eliminazione completata!", vbInformation, "Elimina Ordine")

            End If
        End If
    End Sub

    Private Sub Bt_PulisciImballi_Click(sender As Object, e As EventArgs) Handles Bt_PulisciImballi.Click

        If MsgBox("Questa funzione permette di eliminare dal database le righe imballi senza alcun indice associato." & vbCrLf & "Sei sicuro di voler continuare?", vbYesNo, "Pulizia imballi") = MsgBoxResult.Yes Then

            Dim ListaImballi As New List(Of String)
            Dim ListaEliminare As New List(Of String)

            Using Indici As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                Using DS As New ModPackDBDataSet.IndiciDataTable
                    Indici.Fill(DS)

                    For Each Row As ModPackDBDataSet.IndiciRow In DS
                        If Not ListaImballi.Contains(Row.Imballo) Then ListaImballi.Add(Row.Imballo)
                    Next

                End Using
            End Using
            Using Imballi As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                Using DS As New ModPackDBDataSet.ImballiDataTable
                    Imballi.Fill(DS)

                    For Each Row As ModPackDBDataSet.ImballiRow In DS
                        If Not ListaImballi.Contains(Row.Imballo) Then
                            ListaEliminare.Add(Row.Imballo)
                        End If
                    Next

                End Using
            End Using

            For Each Imballo As String In ListaEliminare
                If MsgBox("Eliminare " & Imballo & "?", vbYesNo, "Pulizia imballi") = MsgBoxResult.Yes Then
                    SQL.Query("DELETE FROM Imballi WHERE Imballo = '" & Imballo & "'")
                    LOG.Write("Eliminato imballo " & Imballo)
                End If
            Next

            If ListaEliminare.Count = 0 Then MsgBox("Non ci sono imballi da eliminare!", vbInformation, "Pulizia imballi")

        End If

    End Sub

    Private Sub Bt_GestioneTipi_Click(sender As Object, e As EventArgs) Handles Bt_GestioneTipi.Click
        Form_GestioneTipi.Show()
    End Sub

    Private Sub Bt_Log_Click(sender As Object, e As EventArgs) Handles Bt_Log.Click
        Process.Start(My.Settings.FileLogPath)
    End Sub
End Class