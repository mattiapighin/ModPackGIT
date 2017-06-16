Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Net.Mail


Public Class Form_OrdiniAperti

    Dim ConfermaOrdineDS As New DataSet
    Dim EtichetteDS As New DataSet
    Dim CheckListDS As New DataSet

    Dim Ordine As String
    Dim RowOrdine As New List(Of RigaOrdine)

    Private Sub BloccaButtons()
        Bt_Etichette.Enabled = False
        Bt_ConfermaOrdine.Enabled = False
        Bt_Disegni.Enabled = False
        Bt_CheckList.Enabled = False
        Bt_ListaMorali.Enabled = False
        Bt_ListaRivestimenti.Enabled = False
    End Sub
    Private Sub SbloccaButtons()
        Bt_Etichette.Enabled = True
        Bt_ConfermaOrdine.Enabled = True
        Bt_Disegni.Enabled = True
        Bt_CheckList.Enabled = True
        Bt_ListaMorali.Enabled = True
        Bt_ListaRivestimenti.Enabled = True
    End Sub

    '### Qui avvengono le operazioni più importanti ###
    'Sono mostrati tutti gli ordini aperti, e selezionandoli è possibile stampare
    'I disegni, etichette, conferma d'ordine, liste varie ecc

    '### Per eseguire operazioni sulle righe selezionate ###
    'For Each Riga As DataGridViewRow In Dgw_Ordine.SelectedRows
    '        MsgBox(Riga.Cells("Imballo").Value)
    'Next

    Private Sub Form_OrdiniAperti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaListaOrdiniAperti()
        CaricaTuttiNonEvasi()
        BloccaButtons()
    End Sub
    Private Sub DGW_OrdiniAperti_Click(sender As Object, e As EventArgs) Handles DGW_OrdiniAperti.Click

        If DGW_OrdiniAperti.SelectedRows.Count > 0 Then
                CaricaOrdineSelezionato(DGW_OrdiniAperti.SelectedCells.Item(0).Value)
                Lbl_Ordine.Text = DGW_OrdiniAperti.SelectedCells.Item(0).Value
                Ordine = (DGW_OrdiniAperti.SelectedCells.Item(0).Value)
            End If

    End Sub

    Private Sub Dgw_Ordine_Sorted(sender As Object, e As EventArgs) Handles Dgw_Ordine.Sorted
        If My.Settings.OrdiniAperti_ColoraEvasi = True Then ColoraEvasi()
        If My.Settings.OrdiniAperti_ColoraScaduti = True Then ColoraDateConsegna()
    End Sub
    Private Sub CaricaListaOrdiniAperti()
        DGW_OrdiniAperti.DataSource = Nothing
        'Riempie la tabella OrdiniAperti con i numeri d'ordine di ordini con ancora righe non evase
        Dim DS As New DataSet
        Dim Query As String = "SELECT DISTINCT Ordine FROM Ordini WHERE Evaso = 'False'"
        Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

            Try
                Con.Open()
                Dim adapter As New SqlDataAdapter(Query, Con)
                adapter.Fill(DS)    '
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        DGW_OrdiniAperti.DataSource = DS.Tables(0)
        DGW_OrdiniAperti.Columns(0).Width = DGW_OrdiniAperti.Width - 3
    End Sub
    Private Sub CaricaOrdineSelezionato(ByVal Ordine As String)
        'Riempie la DGW Ordine con le righe non evase dell'ordine selezionato nella DGW ordini aperti
        Dgw_Ordine.DataSource = Nothing
        Dim DS As New DataSet
        Dim Query As String

        Query = "SELECT Ordini.Id, Ordini.Riga, Ordini.Imballo, Ordini.Qt, Ordini.Cliente, Ordini.Codice, Ordini.Commessa, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Data_Consegna AS Consegna, Imballi.Prezzo, (Imballi.Prezzo * Ordini.Qt) AS Totale, Ordini.Stampato, Ordini.Evaso, Ordini.Data_Ordine AS 'Data Ordine' FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"


        Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

            Try
                Con.Open()
                Dim adapter As New SqlDataAdapter(Query, Con)
                adapter.Fill(DS)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        Dgw_Ordine.DataSource = DS.Tables(0)
        DGW_OrdiniAperti.Columns(0).Width = DGW_OrdiniAperti.Width - 3
        ColoraDateConsegna()
        ColoraEvasi()
        Dgw_Ordine.Columns(0).Visible = False
        SbloccaButtons()
    End Sub
    Private Sub CaricaTuttiNonEvasi()
        'Ignora la tabella OrdiniAperti e carica tutte le righe non evase
        Dgw_Ordine.DataSource = Nothing

        Dim DS As New DataSet
        Dim Query As String = "SELECT Ordini.Id, Ordini.Ordine, Ordini.Riga, Ordini.Imballo, Ordini.Qt, Ordini.Cliente, Ordini.Codice, Ordini.Commessa, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Data_Consegna AS Consegna, Imballi.Prezzo, (Imballi.Prezzo * Ordini.Qt) AS Totale, Ordini.Stampato, Ordini.Evaso, Ordini.Data_Ordine AS 'Data Ordine' FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Evaso = 'False'"
        Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

            Try

                Con.Open()

                Dim adapter As New SqlDataAdapter(Query, Con)
                adapter.Fill(DS)


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        Dgw_Ordine.DataSource = DS.Tables(0)  'Assegna alla DGW la tabella creata
        DGW_OrdiniAperti.Columns(0).Width = DGW_OrdiniAperti.Width - 3

        ColoraDateConsegna()
        Dgw_Ordine.Columns("Id").Visible = False
        DGW_OrdiniAperti.ClearSelection()
        Lbl_Ordine.Text = "ORDINI APERTI"

        BloccaButtons()
    End Sub
    Private Sub ColoraDateConsegna()
        If My.Settings.OrdiniAperti_ColoraScaduti = True Then
            For Each Row As DataGridViewRow In Dgw_Ordine.Rows
                Select Case Row.Cells("Consegna").Value
                    Case < Date.Today.Date
                        Row.DefaultCellStyle.ForeColor = Color.Red
                    Case = Date.Today.Date
                        Row.DefaultCellStyle.ForeColor = Color.Blue
                End Select
            Next
        End If
    End Sub
    Private Sub ColoraEvasi()
        If My.Settings.OrdiniAperti_ColoraEvasi = True Then
            For Each Row As DataGridViewRow In Dgw_Ordine.Rows
                Select Case Row.Cells("Evaso").Value
                    Case True
                        Row.DefaultCellStyle.ForeColor = Color.LightGray
                End Select
            Next
        End If
    End Sub

    Private Sub Bt_Evaso_Click(sender As Object, e As EventArgs) Handles Bt_Evaso.Click
        If Not (Control.ModifierKeys = Keys.Control) Then
            For Each Row As DataGridViewRow In Dgw_Ordine.SelectedRows
                If My.Settings.CK_ConfermaEvaso = True Then
                    If MsgBox("Contrassegnare " & Row.Cells("Imballo").Value & "come evaso?", vbYesNo, "Segna come evaso") = MsgBoxResult.Yes Then
                        SQL.Query("UPDATE Ordini SET Evaso = 'True' WHERE Id = " & Row.Cells("Id").Value)
                        LOG.Write("Evaso imballo " & Row.Cells("Imballo").Value)
                        Row.Cells("Evaso").Value = True
                    End If
                Else
                    SQL.Query("UPDATE Ordini SET Evaso = 'True' WHERE Id = " & Row.Cells("Id").Value)
                    LOG.Write("Evaso imballo " & Row.Cells("Imballo").Value)
                    Row.Cells("Evaso").Value = True
                End If
            Next
        Else
            For Each Row As DataGridViewRow In Dgw_Ordine.SelectedRows
                SQL.Query("UPDATE Ordini SET Evaso = 'False' WHERE Id = " & Row.Cells("Id").Value)
                LOG.Write("Non più evaso imballo " & Row.Cells("Imballo").Value)
                Row.Cells("Evaso").Value = False
            Next
        End If
    End Sub
    Private Sub Bt_SeeAll_Click(sender As Object, e As EventArgs) Handles Bt_SeeAll.Click
        CaricaTuttiNonEvasi()
    End Sub

    Private Sub Bt_ConfermaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_ConfermaOrdine.Click

        If Not DGW_OrdiniAperti.SelectedRows.Count = 0 Then

            Dim DialogStampa As New PrintDialog

            If DialogStampa.ShowDialog = DialogResult.OK Then

                Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value
                ConfermaOrdineDS.Clear()
                Dim Query As String = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Imballi.Tipo, Imballi.L, Imballi.P, Imballi.H, Ordini.indice, Imballi.m3, Imballi.Tipo_Rivestimento, Imballi.Prezzo  FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"
                Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                    Try
                        Con.Open()
                        Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                        adapter.Fill(ConfermaOrdineDS)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

                End Using


                LOG.Write("Stampata conferma ordine " & Ordine)
                Print_ConfermaOrdine.DefaultPageSettings = My.Settings.FormatoStampa
                Print_ConfermaOrdine.PrinterSettings = DialogStampa.PrinterSettings

                Print_ConfermaOrdine.DocumentName = "CO" & Ordine
                Print_ConfermaOrdine.Print()
            End If
        Else
            MsgBox("Selezionare prima un'ordine nella lista di sinistra", vbInformation, "Attenzione")
        End If

    End Sub
    Private Sub Bt_Etichette_Click(sender As Object, e As EventArgs) Handles Bt_Etichette.Click
        If Not DGW_OrdiniAperti.SelectedRows.Count = 0 Then

            'Salva nome dell'ordine per stamparlo su etichetta
            Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

            ' ### SETTA STAMPANTE ###
            'Carica da my.settings tutti i settaggi per la stampante delle etichette
            Print_Etichette.PrinterSettings.PrinterName = My.Settings.Etichette_Stampante
            Dim psz As New Printing.PaperSize With {.RawKind = Printing.PaperKind.Custom, .Width = (My.Settings.Etichette_DimensioneX / 0.254), .Height = (My.Settings.Etichette_DimensioneY / 0.254)}
            Print_Etichette.DefaultPageSettings.PaperSize = psz

            With Print_Etichette.DefaultPageSettings.Margins
                .Top = (My.Settings.Etichette_MargineTop / 0.254)
                .Bottom = (My.Settings.Etichette_MargineBottom / 0.254)
                .Left = (My.Settings.Etichette_MargineLeft / 0.254)
                .Right = (My.Settings.Etichette_MargineRight / 0.254)
            End With
            ' ##############################

            If Not (Control.ModifierKeys = Keys.Control) Then
                'se è premuto CTRL stampa solo l'etichetta selezionata, altrimenti tutto l'ordine

                If MsgBox("Stampare etichette per l'ordine " & Ordine & "?", vbYesNo, "Etichette") = DialogResult.Yes Then

                    EtichetteDS.Clear()
                    Dim Query As String = "SELECT Magazzino, Cliente, Codice, Commessa, Imballo, Qt, Ordine FROM Ordini WHERE Ordine = '" & Ordine & "'"
                    Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                        'Riempie Dataset con i dati necessari
                        Try
                            Con.Open()
                            Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                            adapter.Fill(EtichetteDS)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End Using

                    LOG.Write("Stampata etichette " & Ordine)
                    Print_Etichette.DocumentName = "ET" & Ordine
                    Print_Etichette.Print()

                End If
            Else
                If MsgBox("Stampare etichetta per " & Dgw_Ordine.CurrentRow.Cells("Imballo").Value & "?", vbYesNo, "Etichette") = DialogResult.Yes Then

                    EtichetteDS.Clear()

                    Dim Query As String = "SELECT Magazzino, Cliente, Codice, Commessa, Imballo, Qt, Ordine FROM Ordini WHERE Id = '" & Dgw_Ordine.CurrentRow.Cells("Id").Value & "'"
                    Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                        Try
                            Con.Open()
                            Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                            adapter.Fill(EtichetteDS)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End Using

                    LOG.Write("Stampata etichette " & Ordine)
                    Print_Etichette.DocumentName = "ET" & Ordine
                    Print_Etichette.Print()


                End If
            End If
        Else
            MsgBox("Selezionare prima un'ordine nella lista di sinistra", vbInformation, "Attenzione")

        End If

    End Sub
    Private Sub Bt_CheckList_Click(sender As Object, e As EventArgs) Handles Bt_CheckList.Click
        If Not DGW_OrdiniAperti.SelectedRows.Count = 0 Then

            Dim DialogStampa As New PrintDialog

            If DialogStampa.ShowDialog = DialogResult.OK Then

                Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value
                CheckListDS.Clear()

                Dim Query As String = ""


                If MsgBox("Vuoi stampare anche gli imballi evasi?", MsgBoxStyle.YesNo, "Checklist") = MsgBoxResult.Yes Then
                    Query = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Ordini.Tipo, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Evaso, Ordini.Codice, Ordini.Commessa FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"
                Else
                    Query = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Ordini.Tipo, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Evaso, Ordini.Codice, Ordini.Commessa FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "' AND Ordini.Evaso = 'False'"
                End If


                Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                        Try
                            Con.Open()
                            Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                            adapter.Fill(CheckListDS)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try

                    End Using


                    LOG.Write("Stampata checklist ordine " & Ordine)
                    Print_CheckList.DefaultPageSettings = My.Settings.FormatoStampa
                    Print_CheckList.PrinterSettings = DialogStampa.PrinterSettings

                    Print_CheckList.DocumentName = "CKL" & Ordine
                    Print_CheckList.Print()
                End If
            Else
            MsgBox("Selezionare prima un'ordine nella lista di sinistra", vbInformation, "Attenzione")
        End If

    End Sub
    Private Sub Bt_ListaMorali_Click(sender As Object, e As EventArgs) Handles Bt_ListaMorali.Click
        If Not DGW_OrdiniAperti.SelectedRows.Count = 0 Then

            Liste.Ordine = DGW_OrdiniAperti.CurrentCell.Value
            Form_StampaListe.ShowDialog()

        Else
            MsgBox("Selezionare prima un'ordine nella lista di sinistra", vbInformation, "Attenzione")
        End If
    End Sub
    Private Sub Bt_Disegni_Click(sender As Object, e As EventArgs) Handles Bt_Disegni.Click
        RowOrdine.Clear()
        Ordine = DGW_OrdiniAperti.CurrentRow.Cells(0).Value

        Using OrdineTable As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
            Using Ds As New ModPackDBDataSet.OrdiniDataTable

                OrdineTable.Fill(Ds)

                If Not My.Computer.Keyboard.CtrlKeyDown Then

                    'Se non è premuto CTRL stampa tutto l'ordine
                    For Each Row As ModPackDBDataSet.OrdiniRow In Ds.Rows
                        If Row.Ordine = Ordine Then
                            Dim Riga As New RigaOrdine With {.NumeroOrdine = Row.Ordine, .Riga = Row.Riga, .Imballo = Row.Imballo, .Indice = Row.Indice, .Qt = Row.Qt, .Cliente = Row.Cliente, .Codice = Row.Codice, .Commessa = Row.Commessa,
                                .L = Row.L, .P = Row.P, .H = Row.H, .Tipo = Row.Tipo, .Zoccoli = Row.Zoccoli, .Rivestimento = Row.Rivestimento, .TipoRivestimento = Row.Tipo_Rivestimento, .Note = Row.Note, .DataConsegna = Row.Data_Consegna,
                                .HT = Row.HT, .DT = Row.DT, .BM = Row.BM, .Rivest_Tot = Row.Rivest_Tot, .Magazzino = Row.Magazzino, .Diagonali = Row.Diagonali, .Data_Ordine = .Data_Ordine, .Evaso = False, .Produzione = False, .Stampato = False}
                            RowOrdine.Add(Riga)
                        End If
                        Row.Stampato = True
                    Next

                Else

                    'Se è premuto CTRL stampa solo le righe selezionate
                    For Each Row As ModPackDBDataSet.OrdiniRow In Ds.Rows
                        For Each RigaSelezionata As DataGridViewRow In Dgw_Ordine.SelectedRows
                            If Row.Ordine = Ordine And Row.Id = RigaSelezionata.Cells(0).Value Then
                                Dim Riga As New RigaOrdine With {.NumeroOrdine = Row.Ordine, .Riga = Row.Riga, .Imballo = Row.Imballo, .Indice = Row.Indice, .Qt = Row.Qt, .Cliente = Row.Cliente, .Codice = Row.Codice, .Commessa = Row.Commessa,
                                    .L = Row.L, .P = Row.P, .H = Row.H, .Tipo = Row.Tipo, .Zoccoli = Row.Zoccoli, .Rivestimento = Row.Rivestimento, .TipoRivestimento = Row.Tipo_Rivestimento, .Note = Row.Note, .DataConsegna = Row.Data_Consegna,
                                    .HT = Row.HT, .DT = Row.DT, .BM = Row.BM, .Rivest_Tot = Row.Rivest_Tot, .Magazzino = Row.Magazzino, .Diagonali = Row.Diagonali, .Data_Ordine = .Data_Ordine, .Evaso = False, .Produzione = False, .Stampato = False}
                                RowOrdine.Add(Riga)
                                Row.Stampato = True
                            End If
                        Next
                    Next

                End If

                If Not RowOrdine.Count = 0 Then
                    OrdineTable.Update(Ds)
                    Print_Distinte.DefaultPageSettings = My.Settings.FormatoStampa
                    Dim L As New PrintPreviewDialog With {.Document = Print_Distinte}
                    L.Show()
                End If

            End Using
        End Using
        CaricaOrdineSelezionato(Ordine)
    End Sub
    Private Sub Bt_ListaRivestimenti_Click(sender As Object, e As EventArgs) Handles Bt_ListaRivestimenti.Click
        If MsgBox("Inviare il file Rivestimenti alla sezionatrice?", vbYesNo, "Rivestimenti") = MsgBoxResult.Yes Then
            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim Ip_sezionatrice As String = xml.<Data>.<IP_Sezionatrice>.Value

            'Controlla che il pc della sezionatrice sia connesso
            If My.Computer.Network.Ping(Ip_sezionatrice) Then

                Try

                    Dim Ordine As String = DGW_OrdiniAperti.CurrentCell.Value
                    Dim Path As String = "\\" & Ip_sezionatrice & "\sezionatrice\ModPack"



                    Dim Righe As New List(Of String)
                    Dim Magazzino As String = ""

                    Using TA As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                        Using Table As New ModPackDBDataSet.OrdiniDataTable

                            TA.Fill(Table)


                            For Each Row As ModPackDBDataSet.OrdiniRow In Table.Rows
                                If Row.Ordine = Ordine Then
                                    If Row.Rivestimento = True Then

                                        If Not Row.IsMagazzinoNull Then
                                            Magazzino = Row.Magazzino
                                        End If

                                        Dim Imballo As String = Row.Codice
                                        Dim Qt As String = Row.Qt
                                        Dim Rivestimento As String = ""
                                        If Not Row.IsTipo_RivestimentoNull Then Rivestimento = SQL.GetSQLValue("SELECT Descrizione FROM Rivestimenti WHERE Tipo_Rivestimento = '" & Row.Tipo_Rivestimento & "'")
                                        Dim BC As String = (Row.L - 5) & " x " & (Row.P - 5) & " = " & (Row.Qt * 2)
                                        Dim F As String = (Row.L - 5) & " x " & (Row.H - 10) & " = " & (Row.Qt * 2)
                                        Dim T As String = (Row.P - 5) & " x " & (Row.H - 10) & " = " & (Row.Qt * 2)

                                        Dim Note1 As String = ""
                                        Dim Note2 As String = ""

                                        If Not Row.IsNoteNull Then Note1 = Row.Note
                                        If Not Row.IsRivest_TotNull Then Note2 = Row.Rivest_Tot

                                        'Solo su GST cartonplast su coperchio e faesite su base
                                        If Row.Tipo = "GST" Then BC = (Row.L - 5) & " x " & (Row.P - 5) & " = " & (Row.Qt) & " (+ " & (Row.Qt) & " FAESITE)"

                                        Righe.Add(Imballo & "|" & Qt & "|" & Rivestimento & "|" & BC & "|" & F & "|" & T & "|" & Note1 & "|" & Note2)

                                    End If
                                End If
                            Next

                        End Using
                    End Using

                    Dim NomeFile As String = Path & "\" & "MAG" & Magazzino & " RIV-" & Ordine & ".txt"

                    If Not My.Computer.FileSystem.DirectoryExists(Path) Then
                        'Controlla che esista la directory ModPack se no la crea
                        My.Computer.FileSystem.CreateDirectory(Path)
                        MsgBox("Creata")
                    End If

                    If IO.File.Exists(NomeFile) Then
                        'Controlla che non sia già stata creata la lista
                        If MsgBox("Il file esiste già, vuoi dargli un'altro nome?", vbYesNo, "Nome") = MsgBoxResult.Yes Then
                            Dim NuovoNome As String = InputBox("Nome:", "Rivestimenti", IO.Path.GetFileNameWithoutExtension(NomeFile))
                            If String.IsNullOrEmpty(NomeFile) Then Exit Sub

                            NomeFile = ""
                            NomeFile = Path & "\" & "MAG" & Magazzino & " RIV-" & NuovoNome & ".txt"

                        Else
                            Exit Sub
                        End If

                    End If

                    IO.File.WriteAllLines(NomeFile, Righe)
                    MsgBox("File '" & IO.Path.GetFileNameWithoutExtension(NomeFile) & "' inviato!", vbInformation, "Rivestimenti")
                Catch ex As Exception
                    MsgBox(ex)
                End Try

            Else
                MsgBox("Sezionatrice non raggiungibile!" & vbCrLf & "Controllare la connessione", vbCritical, "Test")
            End If
        End If



    End Sub

    '### STAMPE ###

    Private Sub Print_ConfermaOrdine_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Print_ConfermaOrdine.PrintPage
        Stampe.ConfermaDOrdine(sender, e, Ordine, ConfermaOrdineDS)
    End Sub
    Private Sub Print_Etichette_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Print_Etichette.PrintPage
        Static EtichetteStampate = 0

        Static EtichetteTotali As Integer = EtichetteDS.Tables(0).Rows.Count - 1

        With EtichetteDS.Tables(0).Rows(EtichetteStampate)
            Stampe.Etichetta(sender, e, .Item(0), .Item(1), .Item(2), .Item(3), .Item(4), .Item(5), .Item(6))
        End With

        EtichetteStampate += 1

        If EtichetteStampate <= EtichetteTotali Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            EtichetteStampate = 0
        End If
    End Sub
    Private Sub Print_CheckList_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Print_CheckList.PrintPage
        Stampe.CheckList(sender, e, Ordine, CheckListDS)
    End Sub
    Private Sub Print_Distinte_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Print_Distinte.PrintPage
        Static PagineStampate = 0
        Dim DistinteTotali As Integer = RowOrdine.Count - 1

        Stampe.Stampa_Distinte(sender, e, RowOrdine.Item(PagineStampate))

        PagineStampate += 1

        If PagineStampate <= DistinteTotali Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            PagineStampate = 0
        End If
    End Sub


End Class