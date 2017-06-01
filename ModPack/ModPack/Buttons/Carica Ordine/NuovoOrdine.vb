Namespace Ordine
    Public Module Ordine

        Dim ImballoName As String
        Public ListaNuovi As New List(Of String)
        Public Lista As New List(Of RigaOrdineINPUT)

        Public Function OrdineEXIST(ByVal Ordine As String) As Boolean
            'Check on the OrdiniTable if the order was already loaded
            Dim Exist As Boolean = False
            Dim Count As Int16

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT COUNT(Ordine) FROM Ordini WHERE Ordine = '" & Ordine & "'", Con)

                    Try
                        Con.Open()

                        Count = Convert.ToInt16(Cmd.ExecuteScalar())
                        If Count > 0 Then Exist = True

                    Catch ex As System.Exception
                        MsgBox(ex.Message & vbCrLf & "OrdineEXIST")
                    End Try

                End Using
            End Using

            Return Exist
        End Function
        Public Function IndiceEXIST(ByVal Indice As Integer) As Boolean
            'Check on IndiciTable if the indice was already loaded
            Dim Exist As Boolean = False

            Dim Count As Int16

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT COUNT(indice) FROM indici WHERE indice = '" & Indice & "'", Con)

                    Try
                        Con.Open()

                        Count = Convert.ToInt16(Cmd.ExecuteScalar())
                        If Count > 0 Then Exist = True

                    Catch ex As System.Exception
                        MsgBox(ex.Message & vbCrLf & "IndiceEXIST")
                    End Try

                End Using
            End Using


            Return Exist
        End Function
        Public Function ConvertIndiceToImballo(ByVal Indice As Integer) As String
            Dim Imballo As String = ""

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT Imballo FROM Indici WHERE Indice = '" & Indice & "'", Con)

                    Try
                        Con.Open()

                        Imballo = Cmd.ExecuteScalar

                    Catch ex As System.Exception
                        MsgBox(ex.Message & vbCrLf & "ConvertIndiceToImballo")
                    End Try

                End Using
            End Using

            Return Imballo
        End Function
        Public Function ImballoNomeEXIST(ByVal Imballo As String) As Boolean
            Dim Exist As Boolean = False

            Dim Count As Int16

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT COUNT(Imballo) FROM Imballi WHERE Imballo = '" & Imballo & "'", Con)

                    Try
                        Con.Open()

                        Count = Convert.ToInt16(Cmd.ExecuteScalar())
                        If Count > 0 Then Exist = True

                    Catch ex As System.Exception
                        MsgBox(ex.Message & vbCrLf & "ImballoExist")
                    End Try

                End Using
            End Using


            Return Exist
        End Function
        Public Function DistintaEXIST(ByVal Imballo As String) As Boolean
            Dim Exist As Boolean = False

            Dim Count As Int16

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT COUNT(Imballo) FROM Distinta WHERE Imballo = '" & Imballo & "'", Con)

                    Try
                        Con.Open()

                        Count = Convert.ToInt16(Cmd.ExecuteScalar())
                        If Count > 0 Then Exist = True

                    Catch ex As System.Exception
                        MsgBox(ex.Message & vbCrLf & "ImballoExist")
                    End Try

                End Using
            End Using


            Return Exist
        End Function
        Public Function CONFRONTO_IMBALLI(ByVal Riga As RigaOrdineINPUT) As Boolean
            Dim Esiste As Boolean = False

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                Con.Open()
                'Get a row from the order and checks if in table imballi exist a corresponding one
                'If so it returns the name of the found one

                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT L, P, H, Tipo, Zoccoli, Rivestimento, Tipo_Rivestimento, HT, DT, BM, Diagonali, Imballo FROM Imballi", Con)
                    Using MYREADER As System.Data.SqlClient.SqlDataReader = Cmd.ExecuteReader()

                        Do While MYREADER.Read

                            If MYREADER.GetValue(0) = Riga.L And MYREADER.GetValue(1) = Riga.P And MYREADER.GetValue(2) = Riga.H _
                                And MYREADER.GetValue(3) = Riga.Tipo And MYREADER.GetValue(4) = Riga.Zoccoli And MYREADER.GetValue(5) = Riga.Rivestimento _
                                And MYREADER.GetValue(6) = Riga.TipoRivestimento And MYREADER.GetValue(7) = Riga.HT And MYREADER.GetValue(8) = Riga.DT _
                                And MYREADER.GetValue(9) = Riga.BM And MYREADER.GetValue(10) = Riga.Diagonali Then

                                Esiste = True
                                ImballoName = MYREADER.GetValue(11)
                                Exit Do

                            End If
                        Loop

                    End Using
                End Using
            End Using

            Return Esiste
        End Function
        Public Function Check_Riga(ByVal Riga As RigaOrdineINPUT, ByVal Nome As String) As Boolean
            Dim Esiste As Boolean = False

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                Con.Open()
                'Get a row from the order and checks if in table imballi exist a corresponding one
                'If so it returns the name of the found one

                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT L, P, H, Tipo, Zoccoli, Rivestimento, Tipo_Rivestimento, HT, DT, BM, Diagonali, Imballo FROM Imballi WHERE Imballo = '" & Nome & "'", Con)
                    Using MYREADER As System.Data.SqlClient.SqlDataReader = Cmd.ExecuteReader()

                        Do While MYREADER.Read

                            If MYREADER.GetValue(0) = Riga.L And MYREADER.GetValue(1) = Riga.P And MYREADER.GetValue(2) = Riga.H _
                                And MYREADER.GetValue(3) = Riga.Tipo And MYREADER.GetValue(4) = Riga.Zoccoli And MYREADER.GetValue(5) = Riga.Rivestimento _
                                And MYREADER.GetValue(6) = Riga.TipoRivestimento And MYREADER.GetValue(7) = Riga.HT And MYREADER.GetValue(8) = Riga.DT _
                                And MYREADER.GetValue(9) = Riga.BM And MYREADER.GetValue(10) = Riga.Diagonali Then

                                Esiste = True
                                ImballoName = MYREADER.GetValue(11)
                                Exit Do

                            End If
                        Loop

                    End Using
                End Using
            End Using

            Return Esiste
        End Function

        Public Sub CaricaOrdine(Optional Progressbar As ToolStripProgressBar = Nothing, Optional Label As ToolStripStatusLabel = Nothing)

            '   Quando ha finito di cercare di ottimizzare questa sub
            '   E ti sei accorto che è stata una pessima idea
            '   Per cortesia aggiorna il contatore qui sotto
            '   Che funga da monito al prossimo

            Dim Ore_Perse_Su_Questa_Routine As Integer = 22

            '   Let the suffering begin

            '0 - Prende in input l'ordine come file .txt
            Dim OpenFile As New OpenFileDialog With {.Filter = "Ordine modine|*.txt", .Title = "Carica Ordine", .Multiselect = False, .FileName = "Ordine"}

            If OpenFile.ShowDialog = DialogResult.OK Then

                Try
                    If Not Label Is Nothing Then Label.Text = "Caricamento ordine"
                    Dim NumeroOrdine As String = IO.Path.GetFileNameWithoutExtension(OpenFile.FileName)
                    LOG.Write("Presa in carico ordine " & NumeroOrdine)
                    '1 - Controlla che l'ordine non sia già stato caricato (in base al nome del file)
                    If Ordine.OrdineEXIST(IO.Path.GetFileNameWithoutExtension(OpenFile.FileName)) = True Then
                        LOG.Write("Ordine " & NumeroOrdine & " è già stato caricato")
                        MsgBox("L'ordine che si stà cercando di caricare è già presente!", vbInformation, "Carica ordine")
                        Exit Sub
                    End If

                    '2 - Pulisce le liste "imballi da caricare" e "nuovi imballi trovati da codificare"
                    Lista.Clear()
                    ListaNuovi.Clear()

                    '3 - Legge tutte le righe del file ordine e le inserisce in array RIGHE()
                    Dim RIGHE() As String = IO.File.ReadAllLines(OpenFile.FileName)

                    For Each Record As String In RIGHE

                        '4 - Trasforma ogni riga letta in un oggetto RigaOrdineINPUT
                        Dim R() As String = Split(Record, ";")
                        Dim Riga_INPUT As New RigaOrdineINPUT With
                            {.Riga = R(0), .Indice = R(1), .Qt = R(2), .Cliente = R(3), .Codice = R(4), .Commessa = R(5), .L = R(6), .P = R(7), .H = R(8), .Tipo = R(9), .Zoccoli = R(10),
                            .Rivestimento = R(11), .TipoRivestimento = R(12), .Note = R(13), .DataConsegna = R(14), .HT = R(15), .DT = R(16), .BM = R(17), .Rivest_Tot = R(18), .Diagonali = R(19),
                            .NumeroOrdine = NumeroOrdine}

                        '5 - Aggiunge l'oggetto appena creato alla lista "imballi da caricare"
                        Lista.Add(Riga_INPUT)
                    Next

                    Debug.WriteLine("Fine presa in carico ordine " & IO.Path.GetFileNameWithoutExtension(OpenFile.FileName) & " numero totale di elementi:  " & Lista.Count)
                    If Not Progressbar Is Nothing Then
                        Progressbar.Value = 0
                        Progressbar.Maximum = Lista.Count
                    End If
                    If Not Label Is Nothing Then Label.Text = "Caricamento ordine"

                Catch ex As Exception
                    MsgBox("Problema con la presa in carico dell'ordine" & vbCrLf & ex.Message)
                End Try

                '################################# ELABORA LA LISTA APPENA CREATA ###############################

                Try
                    If Not Label Is Nothing Then Label.Text = "Preparazione elaborazione ordine"
                    Dim Magazzino As String = InputBox("Magazzino:", "Carica ordine", "1")
                    If String.IsNullOrEmpty(Magazzino) Then Magazzino = 0

                    '6 - Legge la lista appena creata e controlla se esistono in memoria imballi corrispondenti

                    For Each PACK As RigaOrdineINPUT In Lista
                        If Not Progressbar Is Nothing Then Progressbar.Value += 1
                        Debug.WriteLine("Controllo su indice " & PACK.Indice)
                        If Not Label Is Nothing Then Label.Text = "Elaborazione indice " & PACK.Indice

                        Dim IndiceEsiste As Boolean = IndiceEXIST(PACK.Indice)

                        If IndiceEsiste = True Then

                            '6.1 - Prima controlla che sia già stato caricato in passato uno uguale (in base al suo indice)
                            ImballoName = ConvertIndiceToImballo(PACK.Indice)
                            Debug.WriteLine("L'indice " & PACK.Indice & " è presente in memoria : " & ImballoName)

                            If ImballoNomeEXIST(ImballoName) Then

                                '6.1.1 - Se trova un indice corrispondente controlla che esista effettivamente anche un imballo
                                '        corrispondente, se è tutto a posto carica la riga nella OrdiniTable

                                If Check_Riga(PACK, ImballoName) Then
                                    Debug.WriteLine("L'imballo " & ImballoName & " è presente in memoria")
                                    Dim RIGA_ORDINE As New RigaOrdine With {.NumeroOrdine = PACK.NumeroOrdine, .Riga = PACK.Riga, .Imballo = ImballoName, .Indice = PACK.Indice, .Qt = PACK.Qt, .Cliente = PACK.Cliente, .Codice = PACK.Codice, .Commessa = PACK.Commessa,
                                    .L = PACK.L, .P = PACK.P, .H = PACK.H, .Tipo = PACK.Tipo, .Zoccoli = PACK.Zoccoli, .Rivestimento = PACK.Rivestimento, .TipoRivestimento = PACK.TipoRivestimento, .Note = PACK.Note, .DataConsegna = PACK.DataConsegna, .HT = PACK.HT, .DT = PACK.DT, .BM = PACK.BM, .Rivest_Tot = PACK.Rivest_Tot, .Magazzino = Magazzino, .Diagonali = PACK.Diagonali,
                                    .Stampato = False, .Produzione = False, .Evaso = False}
                                    SQL.InsertRigaOrdini(RIGA_ORDINE)
                                Else

                                    '6.1.1 - L'indice esiste, l'imballo esiste ma le righe non corrispondono. Elimina l'indice si comporta come se fosse una nuovariga
                                    If MsgBox("ATTENZIONE: L'indice " & PACK.Indice & " non corrisponde alla riga imballo " & ImballoName & " a cui era associato" & vbCrLf & "Vuoi creare una imballo nuovo?", vbYesNo, "Carica Ordine") = MsgBoxResult.Yes Then
                                        ImballoName = NomeImballo.CreaNome(PACK.Tipo, PACK.HT)
                                        SQL.Query("DELETE FROM Indici WHERE indice = '" & PACK.Indice & "'")
                                        IndiceEsiste = False
                                    End If

                                End If

                                    Else

                                '6.1.1 - Se esiste in memoria un indice, ma non la riga imballo qualcuno ha messo mani dove non doveva
                                '        Permette comunque di aggiustare le cose CREANDO una riga imballo e una distinta con il vecchio
                                '        Nome dell'imballo

                                MsgBox("Errore relativo al codice " & ImballoName & "." & vbCrLf & "E' stato trovato il suo indice di riferimento ma non la riga relativa all'imballo" & vbCrLf & "La riga verrà ora ricreata dinamicamente")

                                Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}
                                If DistintaEXIST(ImballoName) = True Then
                                    '6.1.1 - Esiste la distinta ma non la riga imballo - Viene creata solo la riga imballo
                                    Nuovo.CreaDaOrdine(PACK, False, True, False)
                                Else
                                    '6.1.1 - Non esiste nè distinta nè riga imballo - Vengono create entrambe
                                    Nuovo.CreaDaOrdine(PACK, True, True, False)
                                End If

                            End If

                        End If

                        If IndiceEsiste = False Then

                            '6.2 - Non esiste in memoria un indice come quello della riga dell'ordine

                            '6.3 - Associa il nome progressivo disponibile all'imballo che si sta creando (potrebbe anche non essere
                            '      Utilizzato, in caso venga trovato un imballo corrispondente

                            ImballoName = NomeImballo.CreaNome(PACK.Tipo, PACK.HT)

                            '7 - Confronta le caratteristiche dell'imballo in input con gli altri in memoria e cerca un'imballo corrispondente

                            If CONFRONTO_IMBALLI(PACK) = False Then
                                '7.1 - Se non trova niente, crea l'imballo da zero con il codice creato in precedenza
                                If Not Label Is Nothing Then Label.Text = "Creazione imballo " & ImballoName
                                Debug.WriteLine("Verrà creato il nuovo imballo: " & PACK.Indice & " = " & ImballoName)

                                Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}
                                Nuovo.CreaDaOrdine(PACK, True, True, True) ' INSERT in Distinta, Imballi, Indici

                                '7.1.1 - L'imballo appena creato viene trasformato in oggetto RigaOrdine
                                Dim RIGA_ORDINE As New RigaOrdine With {.NumeroOrdine = PACK.NumeroOrdine, .Riga = PACK.Riga, .Imballo = Nuovo.Nome, .Indice = PACK.Indice, .Qt = PACK.Qt, .Cliente = PACK.Cliente, .Codice = PACK.Codice, .Commessa = PACK.Commessa,
                                .L = PACK.L, .P = PACK.P, .H = PACK.H, .Tipo = PACK.Tipo, .Zoccoli = PACK.Zoccoli, .Rivestimento = PACK.Rivestimento, .TipoRivestimento = PACK.TipoRivestimento, .Note = PACK.Note, .DataConsegna = PACK.DataConsegna, .HT = PACK.HT, .DT = PACK.DT, .BM = PACK.BM, .Rivest_Tot = PACK.Rivest_Tot, .Magazzino = Magazzino, .Diagonali = PACK.Diagonali,
                                .Stampato = False, .Produzione = False, .Evaso = False}
                                ListaNuovi.Add(ImballoName)

                                '7.1.2 - Limballo appena creato viene inserito nella OrdiniTable
                                SQL.InsertRigaOrdini(RIGA_ORDINE)
                            Else
                                '7.2 - Se trova un imballo corrispondente associa il nome di quell'imballo all'indice di quello in input

                                Debug.WriteLine("E' stato trovato un imballo corrispondente: " & PACK.Indice & " = " & ImballoName)

                                Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}
                                Nuovo.CreaDaOrdine(PACK, False, False, True) 'INSERT in Indici

                                '7.2.1 - L'imballo appena creato viene trasformato in oggetto RigaOrdine
                                Dim RIGA_ORDINE As New RigaOrdine With {.NumeroOrdine = PACK.NumeroOrdine, .Riga = PACK.Riga, .Imballo = Nuovo.Nome, .Indice = PACK.Indice, .Qt = PACK.Qt, .Cliente = PACK.Cliente, .Codice = PACK.Codice, .Commessa = PACK.Commessa,
                                .L = PACK.L, .P = PACK.P, .H = PACK.H, .Tipo = PACK.Tipo, .Zoccoli = PACK.Zoccoli, .Rivestimento = PACK.Rivestimento, .TipoRivestimento = PACK.TipoRivestimento, .Note = PACK.Note, .DataConsegna = PACK.DataConsegna, .HT = PACK.HT, .DT = PACK.DT, .BM = PACK.BM, .Rivest_Tot = PACK.Rivest_Tot, .Magazzino = Magazzino, .Diagonali = PACK.Diagonali,
                                .Stampato = False, .Produzione = False, .Evaso = False}

                                '7.2.2 - Limballo appena creato viene inserito nella OrdiniTable
                                SQL.InsertRigaOrdini(RIGA_ORDINE)

                            End If
                        End If
                    Next

                Catch ex As Exception
                    MsgBox("Problema con l'elaborazione dell'ordine" & vbCrLf & ex.Message)
                End Try
            End If

            '8 - Se la lista dei nuovi imballi non è vuota permette di stamparla 
            StampaListaNuovi(ListaNuovi)
            If Not Progressbar Is Nothing Then Progressbar.Value = 0
            If Not Label Is Nothing Then Label.Text = "Caricamento completato"
        End Sub

        Private Sub StampaListaNuovi(ByVal Lista As List(Of String))

            If Not Lista.Count = 0 Then
                'Se la lista contiene imballi nuovi permette la stampa degli stessi
                If MsgBox("Durante la presa in carico dell'ordine sono stati creati" & vbCrLf &
                          "degli imballi nuovi. Vuoi stampare la lista?", vbYesNo, "Imballi Nuovi") = MsgBoxResult.Yes Then

                    Dim TABLE As New ModPackDBDataSet.ImballiDataTable

                    Using DA As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                        DA.Fill(TABLE)
                    End Using

                    Dim ListaNuovi As New List(Of RigaImballi)

                    For Each N As String In Lista
                        For Each R As ModPackDBDataSet.ImballiRow In TABLE
                            If R.Imballo = N Then

                                Dim Nuovo As New RigaImballi With {
                                    .Nome = R.Imballo,
                                    .L = R.L,
                                    .P = R.P,
                                    .H = R.H,
                                    .TIpo = R.Tipo,
                                    .Zoccoli = R.Zoccoli,
                                    .Rivestimento = R.Rivestimento,
                                    .TipoRivestimento = R.Tipo,
                                    .HT = R.HT,
                                    .DT = R.DT,
                                    .BM = R.BM,
                                    .Diagonali = R.Diagonali,
                                    .GradiF = R.Gradi_F,
                                    .GradiT = R.Gradi_T,
                                    .PrimoMorale = R.Primo_Morale,
                                    .M2 = R.M2,
                                    .M3 = R.M3,
                                    .Prezzo = R.Prezzo,
                                    .DataCreazione = R.Data_Creazione}

                                ListaNuovi.Add(Nuovo)

                                'Creare un nuovo printdocument
                                'Creare modulo per stampa lista codici


                            End If

                        Next
                    Next
                End If
            End If
        End Sub

    End Module
End Namespace
