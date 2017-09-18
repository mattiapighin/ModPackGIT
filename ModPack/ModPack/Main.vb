﻿Imports System.ComponentModel
Imports System.Xml

Public Class Main

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '                                                                        '
    '       ███╗   ███╗ ██████╗ █████╗  ██████╗  █████╗  ██████╗██╗  ██╗     '
    '       ████╗ ████║██╔═══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██║ ██╔╝     '
    '       ██╔████╔██║██║   ██║██║  ██║██████╔╝███████║██║     █████╔╝      ' 
    '       ██║╚██╔╝██║██║   ██║██║  ██║██╔═══╝ ██╔══██║██║     ██╔═██╗      '
    '       ██║ ╚═╝ ██║╚██████╔╝█████╔╝ ██║     ██║  ██║╚██████╗██║  ██╗     '
    '       ╚═╝     ╚═╝ ╚═════╝ ╚════╝  ╚═╝     ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝     '
    '                                                                        '
    '                       © 2017 - Mattia Pighin                           '
    '                                                                        ' 
    '                             *Disclaimer*                               '
    '   When I wrote this code, only God and I understood what I was doing   '
    '                         Now, God only knows                            '
    '                                                                        '   
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Dim ListaMemo As New List(Of Memo)
    Dim RowOrdine As New List(Of RigaOrdine)
    Dim RowIndici As New List(Of Integer)

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OperazioniPreliminari()
    End Sub

    Private Sub Mostra_Nascondi_Testo()
        If My.Settings.TestoIconeMain = False Then
            TS_Ordini.DisplayStyle = ToolStripItemDisplayStyle.Image
            TS_Imballi.DisplayStyle = ToolStripItemDisplayStyle.Image
            TS_Tools.DisplayStyle = ToolStripItemDisplayStyle.Image
            TS_Tabelle.DisplayStyle = ToolStripItemDisplayStyle.Image
            TS_Memo.DisplayStyle = ToolStripItemDisplayStyle.Image
            Ts_Preferenze.DisplayStyle = ToolStripItemDisplayStyle.Image
        Else
            TS_Ordini.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            TS_Imballi.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            TS_Tools.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            TS_Tabelle.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            TS_Memo.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            Ts_Preferenze.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        End If
    End Sub

    Public Sub CaricaMemo()
        Try
            Using MemoTable As New ModPackDBDataSetTableAdapters.MemoTableAdapter
                Using MemoDT As New ModPackDBDataSet.MemoDataTable
                    MemoTable.Fill(MemoDT)

                    ListaMemo.Clear()

                    For Each Row As ModPackDBDataSet.MemoRow In MemoDT.Rows
                        Dim Riga As New Memo
                        If Not Row.IsDataNull Then Riga.Data = Row.Data
                        If Not Row.IsMemoNull Then Riga.Memo = Row.Memo
                        If Not Row.IsImballoNull Then Riga.Imballo = Row.Imballo
                        ListaMemo.Add(Riga)
                    Next

                End Using
            End Using

        Catch ex As Exception
            Errore.Show("CaricaMemo \ Main", ex.Message)
        End Try

        MostraMemo()


    End Sub
    Private Sub MostraMemo()
        Try
            DGW_Memo.Rows.Clear()
            For Each Row As Memo In (From Riga In ListaMemo Where Riga.Data = Calendario.SelectionStart)
                DGW_Memo.Rows.Add(Row.Memo)
            Next

        Catch ex As Exception
            Errore.Show("MostraMemo \ Main", ex.Message)
        End Try
    End Sub
    Private Sub OperazioniPreliminari()
        Try

            Mostra_Nascondi_Testo()

            If My.Settings.Utente = "Nuovo Utente" Then
                'Quando nuova installazione oppure se si vuole resettare le impostazioni
                Dim Utente As String = ""
                Utente = InputBox("Inserire nome utente", "Nuovo Utente", System.Environment.UserName)
                If Not String.IsNullOrEmpty(Utente) Then My.Settings.Utente = Utente

                If MsgBox("Azzerare formato stampa?", vbYesNo, "Nuovo Utente") = MsgBoxResult.Yes Then
                    Dim PageSetupDialog As New PageSetupDialog With {.Document = New Printing.PrintDocument, .EnableMetric = True}
                    If PageSetupDialog.ShowDialog = DialogResult.OK Then
                        My.Settings.FormatoStampa = PageSetupDialog.PageSettings
                    End If
                End If

                With My.Settings
                    .LogType = "normal"
                    .NumeroRigheDistinta = 15
                    .DimensioneFontDistinta = 12
                    .Developer = False
                    .Etichette_DimensioneX = 110
                    .Etichette_DimensioneY = 69
                    .Etichette_MargineBottom = 5
                    .Etichette_MargineLeft = 5
                    .Etichette_MargineRight = 5
                    .Etichette_MargineTop = 5
                End With

                My.Settings.Save()
                If MsgBox("Impostare subito le preferenze?", vbYesNo, "Preferenze") = MsgBoxResult.Yes Then Form_Preferenze.ShowDialog()
            End If

            If Not My.Computer.FileSystem.DirectoryExists(My.Settings.Root & "\Disegni") Then My.Computer.FileSystem.CreateDirectory(My.Settings.Root & "\Disegni")

            If Not My.Computer.FileSystem.FileExists(My.Settings.FileLogPath) Then
                IO.File.Create(My.Settings.FileLogPath)
            End If

            If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
                With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                    Me.Text = "Modpack [ " & System.Environment.UserName & " ] - " & "V" & .Major & "." & .Minor & "." & .Build & "." & .Revision
                End With
            End If


            XML.CreaXML()

            LOG.Write("Inizio sessione " & System.Environment.UserName)
            CaricaMemo()
            SQL.PuliziaOrdini() 'Se attivo elimina tutti gli ordini prima di una certa data (default false)
            My.Settings.Scarto = SQL.GetPrezzoMateriale("SCART") 'salva in memoria la percentuale di scarto in modo da non dover fare la query ogni volta
            My.Settings.Save()

        Catch ex As Exception
            Errore.Show("Operazioni Preliminari \ Main", ex.Message)
        End Try

    End Sub

    Private Sub Calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendario.DateChanged
        MostraMemo()
    End Sub
    Private Sub DGW_Memo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Memo.CellContentClick
        DGW_Memo.ClearSelection()
    End Sub

    Private Sub Main_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                e.Effect = DragDropEffects.All
            End If

        Catch ex As Exception
            Errore.Show("Drag&Drop \ Main", ex.Message)
        End Try
    End Sub
    Private Sub Main_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each FileOrdine In files
                If MsgBox("Caricare ordine '" & IO.Path.GetFileNameWithoutExtension(FileOrdine) & "' ?", vbYesNo, "Carica ordine") = MsgBoxResult.Yes Then
                    ProgressBar.Visible = True
                    Ordine.CaricaOrdine(FileOrdine, ProgressBar, ToolStrip, Notify)
                    ToolStrip.Text = ""
                    ProgressBar.Visible = False
                End If
            Next


        Catch ex As Exception
            Errore.Show("Drag&Drop \ Main", ex.Message)
        End Try
    End Sub

    Private Sub CaricaOrdiniAperti()
        OrdiniTree.Nodes.Clear()
        Try
            Using Table As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                Using DS As New ModPackDBDataSet.OrdiniDataTable
                    Table.Fill(DS)

                    Dim Ordini = From row In DS.AsEnumerable()
                                 Select row.Field(Of String)("Ordine") Distinct

                    Dim I As Integer = 0

                    For Each Ordine As String In Ordini

                        Dim Evaso = True
                        Dim row() As DataRow = DS.Select("Ordine = '" & Ordine & "'")

                        For K = 0 To row.Length - 1
                            'Se in tutto l'ordine c'è almeno un imballo inevaso prosegue
                            If row(K)(26) = False Then Evaso = False
                        Next

                        If Evaso = False Then
                            'Se esiste un imballo inevaso carica il nodo Ordine
                            OrdiniTree.Nodes.Add(Ordine)

                            For K = 0 To row.Length - 1
                                'E poi carica gli imballi inevasi
                                If row(K)(26) = False Then
                                    OrdiniTree.Nodes(I).Nodes.Add(row(K)(3) & "  (" & row(K)(5) & ")" & "  (" & row(K)(7) & ")  (" & row(K)(8) & ")")
                                    OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.Black

                                    If row(K)(24) = False Then
                                        'Se non è stampato icona "new"
                                        OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.SaddleBrown
                                        OrdiniTree.Nodes(I).Nodes(K).ImageIndex = 4
                                        OrdiniTree.Nodes(I).Nodes(K).SelectedImageIndex = 4
                                    Else
                                        'Se è stampato icona "attesa"
                                        OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.Blue
                                        OrdiniTree.Nodes(I).Nodes(K).ImageIndex = 1
                                        OrdiniTree.Nodes(I).Nodes(K).SelectedImageIndex = 1
                                    End If

                                    If row(K)(25) = True Then
                                        'Se è in produzione icona "lavoro"
                                        OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.Black
                                        OrdiniTree.Nodes(I).Nodes(K).ImageIndex = 2
                                        OrdiniTree.Nodes(I).Nodes(K).SelectedImageIndex = 2
                                    End If

                                Else
                                    OrdiniTree.Nodes(I).Nodes.Add(row(K)(3) & "  (" & row(K)(5) & ")" & "  (" & row(K)(7) & ")  (" & row(K)(8) & ")")
                                    OrdiniTree.Nodes(I).Nodes(K).ForeColor = Color.Green
                                    'Se è evaso icona check
                                    OrdiniTree.Nodes(I).Nodes(K).ImageIndex = 3
                                    OrdiniTree.Nodes(I).Nodes(K).SelectedImageIndex = 3
                                End If
                            Next
                            I += 1
                        End If

                    Next
                End Using
            End Using

        Catch ex As Exception
            Errore.Show("CaricaOrdiniAperti \ Main", ex.Message)
        End Try

    End Sub

    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CaricaOrdiniAperti()
    End Sub
    Private Sub OrdiniTree_DoubleClick(sender As Object, e As EventArgs) Handles OrdiniTree.DoubleClick
        Try
            If Not OrdiniTree.SelectedNode Is Nothing Then
                Dim Imballo() As String = Split(OrdiniTree.SelectedNode.Text, "  ")
                If Imballo.Length = 4 Then
                    Form_Imballi.ImballiBindingSource.Filter = Nothing
                    Form_Imballi.Show()
                    Form_Imballi.ImballiBindingSource.Filter = "Imballo = '" & Imballo(0) & "'"
                End If
            End If
        Catch ex As Exception
            Errore.Show("OrdiniTree_DoubleClick \ Main", ex.Message)
        End Try
    End Sub

    '### TOOLSTRIP ###
    Private Sub TS_CaricaOrdine_Click(sender As Object, e As EventArgs) Handles TS_CaricaOrdine.Click
        ToolStrip.Text = "Selezione file ordine"
        ProgressBar.Visible = True
        'Ordine.CaricaOrdine(ProgressBar, ToolStrip, Notify)
        Ordine.CaricaFileOrdine(ProgressBar, ToolStrip, Notify)
        ToolStrip.Text = ""
        ProgressBar.Visible = False
    End Sub
    Private Sub TS_OrdiniAperti_Click(sender As Object, e As EventArgs) Handles TS_OrdiniAperti.Click
        Form_OrdiniAperti.Show()
    End Sub
    Private Sub TS_StoricoOrdini_Click(sender As Object, e As EventArgs) Handles TS_StoricoOrdini.Click
        Form_StoricoOrdini.Show()
    End Sub
    Private Sub TS_Archivio_Click(sender As Object, e As EventArgs) Handles TS_Archivio.Click
        Form_Imballi.Show()
    End Sub
    Private Sub TS_Crea_Click(sender As Object, e As EventArgs) Handles TS_Crea.Click
        Form_Crea_Manuale.Show()
    End Sub
    Private Sub TS_Tabelle_Click(sender As Object, e As EventArgs) Handles TS_Tabelle.Click
        Form_Tabelle.Show()
    End Sub
    Private Sub TS_Memo_Click(sender As Object, e As EventArgs) Handles TS_Memo.Click
        Form_Memo.Show()
    End Sub
    Private Sub Ts_Preferenze_Click(sender As Object, e As EventArgs) Handles Ts_Preferenze.Click
        Form_Preferenze.ShowDialog()
    End Sub
    Private Sub TS_ControlloOrdine_Click(sender As Object, e As EventArgs) Handles TS_ControlloOrdine.Click
        Form_ControlloOrdineInput.Show()
    End Sub
    Private Sub TS_ListaElementi_Click(sender As Object, e As EventArgs) Handles TS_ListaElementi.Click
        Form_ListaElementi.Show()
    End Sub

    Private Sub Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LOG.CheckSize()
    End Sub

    Private Sub TS_Listino_Click(sender As Object, e As EventArgs) Handles TS_Listino.Click
        Form_Listino.Show()
    End Sub

End Class
