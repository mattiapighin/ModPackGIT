Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Form_OrdiniAperti
    Dim OrdineDS As New DataSet
    Dim Ordine As String

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
        Lbl_Ordine.Text = ""
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
                    End If
                Else
                    SQL.Query("UPDATE Ordini SET Evaso = 'True' WHERE Id = " & Row.Cells("Id").Value)
                    LOG.Write("Evaso imballo " & Row.Cells("Imballo").Value)
                End If
            Next
        Else
            For Each Row As DataGridViewRow In Dgw_Ordine.SelectedRows
                SQL.Query("UPDATE Ordini SET Evaso = 'False' WHERE Id = " & Row.Cells("Id").Value)
                LOG.Write("Non più evaso imballo " & Row.Cells("Imballo").Value)
            Next
        End If

        ' Bt_Refresh_Click(sender, e)
    End Sub
    Private Sub Bt_Refresh_Click(sender As Object, e As EventArgs) Handles Bt_Refresh.Click
        If Not DGW_OrdiniAperti.SelectedRows.Count = 0 Then
            CaricaOrdineSelezionato(DGW_OrdiniAperti.SelectedCells.Item(0).Value)
            Lbl_Ordine.Text = DGW_OrdiniAperti.SelectedCells.Item(0).Value
        Else
            MsgBox("Selezionare prima un'ordine nella lista di sinistra", vbInformation, "Attenzione")
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
                OrdineDS.Clear()
                Dim Query As String = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Imballi.Tipo, Imballi.L, Imballi.P, Imballi.H, Ordini.indice, Imballi.m3, Imballi.Tipo_Rivestimento, Imballi.Prezzo  FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"
                Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                    Try
                        Con.Open()
                        Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                        adapter.Fill(OrdineDS)
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

                    OrdineDS.Clear()
                    Dim Query As String = "SELECT Magazzino, Cliente, Codice, Commessa, Imballo, Qt, Ordine FROM Ordini WHERE Ordine = '" & Ordine & "'"
                    Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                        'Riempie Dataset con i dati necessari
                        Try
                            Con.Open()
                            Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                            adapter.Fill(OrdineDS)
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

                    If Not Dgw_Ordine.CurrentRow Is Nothing Then
                        OrdineDS.Clear()
                        Dim Query As String = "SELECT Magazzino, Cliente, Codice, Commessa, Imballo, Qt, Ordine FROM Ordini WHERE Id = '" & Dgw_Ordine.CurrentRow.Cells("Id").Value & "'"
                        Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                            Try
                                Con.Open()
                                Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                                adapter.Fill(OrdineDS)
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End Using

                        LOG.Write("Stampata etichette " & Ordine)
                        Print_Etichette.DocumentName = "ET" & Ordine
                        Print_Etichette.Print()

                    End If

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
                OrdineDS.Clear()
                Dim Query As String = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Imballi.Tipo, Imballi.L, Imballi.P, Imballi.H, Ordini.indice, Imballi.m3, Imballi.Tipo_Rivestimento, Ordini.Evaso FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "'"
                Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                    Try
                        Con.Open()
                        Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                        adapter.Fill(OrdineDS)
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

    '### STAMPE ###

    Private Sub Print_ConfermaOrdine_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Print_ConfermaOrdine.PrintPage
        Stampe.ConfermaDOrdine(sender, e, Ordine, OrdineDS)
    End Sub
    Private Sub Print_Etichette_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Print_Etichette.PrintPage
        Static EtichetteStampate = 0

        Static EtichetteTotali As Integer = OrdineDS.Tables(0).Rows.Count - 1

        With OrdineDS.Tables(0).Rows(EtichetteStampate)
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
        Stampe.CheckList(sender, e, Ordine, OrdineDS)
    End Sub
End Class