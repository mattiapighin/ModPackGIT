Namespace Ordine
    Public Module Ordine

        Dim ImballoName As String
        Public ListaNuovi As New List(Of String)
        Public Lista As New List(Of RigaOrdineINPUT)

        Public Function OrdineEXIST(ByVal Ordine As String) As Boolean

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

                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT * FROM Imballi", Con)
                    Using MYREADER As System.Data.SqlClient.SqlDataReader = Cmd.ExecuteReader()

                        Do While MYREADER.Read

                            If MYREADER.GetValue(2) = Riga.L And MYREADER.GetValue(3) = Riga.P And MYREADER.GetValue(4) = Riga.H _
                                And MYREADER.GetValue(5) = Riga.Tipo And MYREADER.GetValue(6) = Riga.Zoccoli And MYREADER.GetValue(7) = Riga.Rivestimento _
                                And MYREADER.GetValue(8) = Riga.TipoRivestimento And MYREADER.GetValue(9) = Riga.HT And MYREADER.GetValue(10) = Riga.DT _
                                And MYREADER.GetValue(11) = Riga.BM And MYREADER.GetValue(12) = Riga.Diagonali Then

                                Esiste = True
                                ImballoName = MYREADER.GetValue(1)
                                Exit Do

                            End If

                        Loop

                    End Using
                End Using
            End Using

            Return Esiste
        End Function

        Public Sub CaricaOrdine()

            Dim OpenFile As New OpenFileDialog With {.Filter = "Ordine modine|*.txt", .Title = "Carica Ordine", .Multiselect = False, .FileName = "Ordine"}

            If OpenFile.ShowDialog = DialogResult.OK Then

                Try

                    Dim NumeroOrdine As String = IO.Path.GetFileNameWithoutExtension(OpenFile.FileName)
                    LOG.Write("Presa in carico ordine " & NumeroOrdine)

                    If Ordine.OrdineEXIST(IO.Path.GetFileNameWithoutExtension(OpenFile.FileName)) = True Then
                        'Controlla che l'ordine che si sta caricando non sia già inserito
                        LOG.Write("Ordine " & NumeroOrdine & " è già stato caricato")
                        MsgBox("L'ordine che si stà cercando di caricare è già presente!", vbInformation, "Carica ordine")
                        Exit Sub
                    End If

                    Lista.Clear()
                    ListaNuovi.Clear()


                    'Legge le righe dell'ordine
                    Dim RIGHE() As String = IO.File.ReadAllLines(OpenFile.FileName)

                    For Each Record As String In RIGHE

                        Dim R() As String = Split(Record, ";")
                        'Legge la riga dal file e la trasforma in oggetto RIGAORDINEINPUT
                        Dim Riga_INPUT As New RigaOrdineINPUT With
                            {.Riga = R(0), .Indice = R(1), .Qt = R(2), .Cliente = R(3), .Codice = R(4), .Commessa = R(5), .L = R(6), .P = R(7), .H = R(8), .Tipo = R(9), .Zoccoli = R(10),
                            .Rivestimento = R(11), .TipoRivestimento = R(12), .Note = R(13), .DataConsegna = R(14), .HT = R(15), .DT = R(16), .BM = R(17), .Rivest_Tot = R(18), .Diagonali = R(19),
                            .NumeroOrdine = NumeroOrdine}

                        'Scrive sul file di log l'avvenuta lettura della riga
                        LOG.Write("Elaborazione codice " & Riga_INPUT.Codice)

                        'Aggiunge la rigaordineinput alla lista
                        Lista.Add(Riga_INPUT)
                    Next

                    Debug.WriteLine("Fine carico ordine in lista, numero totale di elementi: " & Lista.Count)

                Catch ex As Exception
                    MsgBox("Problema con la lettura dell'ordine" & vbCrLf & ex.Message)
                End Try

                '################################# ELABORA LA LISTA APPENA CREATA ###############################

                Try

                    Dim Magazzino As Integer = InputBox("Magazzino:", "Carica ordine", "1")


                    'Controlla la lista input e associa index con relativi imballi se esistono
                    For Each PACK As RigaOrdineINPUT In Lista

                        Debug.WriteLine("Controllo su indice " & PACK.Indice)

                        If IndiceEXIST(PACK.Indice) Then

                            ImballoName = ConvertIndiceToImballo(PACK.Indice) '## IL NOME RELATIVO AL SUO INDICE

                            Debug.WriteLine("L'indice " & PACK.Indice & " è presente in memoria : " & ImballoName)

                            If ImballoNomeEXIST(ImballoName) Then

                                Debug.WriteLine("L'imballo " & ImballoName & " è presente in memoria")
                                'Se esiste sia l'indice che la riga imballi carica la riga negli ordini
                                Dim RIGA_ORDINE As New RigaOrdine With {.NumeroOrdine = PACK.NumeroOrdine, .Riga = PACK.Riga, .Imballo = ImballoName, .Indice = PACK.Indice, .Qt = PACK.Qt, .Cliente = PACK.Cliente, .Codice = PACK.Codice, .Commessa = PACK.Commessa,
                                    .L = PACK.L, .P = PACK.P, .H = PACK.H, .Tipo = PACK.Tipo, .Zoccoli = PACK.Zoccoli, .Rivestimento = PACK.Rivestimento, .TipoRivestimento = PACK.TipoRivestimento, .Note = PACK.Note, .DataConsegna = PACK.DataConsegna, .HT = PACK.HT, .DT = PACK.DT, .BM = PACK.BM, .Rivest_Tot = PACK.Rivest_Tot, .Magazzino = Magazzino, .Diagonali = PACK.Diagonali,
                                    .Stampato = False, .Produzione = False, .Evaso = False}
                                'Inserisce la riga nella tabella Ordini
                                SQL.InsertRigaOrdini(RIGA_ORDINE)

                            Else 'Imballo non esiste nella tabella imballi

                                MsgBox("Errore relativo al codice " & ImballoName & "." & vbCrLf & "E' stato trovato il suo indice di riferimento ma non la riga relativa all'imballo" & vbCrLf & "La riga verrà ora ricreata dinamicamente")
                                'NON ESISTE LA RIGA IMBALLO RELATIVA AL CODICE (CANCELLATA?) NE VIENE CREATA UNA NUOVA CON IL SUO VECCHIO NOME
                                Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}

                                If DistintaEXIST(ImballoName) = True Then
                                    'LA DISTINTA ESISTE, VIENE CREATA SOLO LA RIGA IMBALLO
                                    Nuovo.CreaDaOrdine(PACK, False, True, False)
                                Else
                                    'NON ESISTE NEANCHE LA DISTINTA, VIENE CREATA SIA RIGA IMBALLO CHE DISTINTA
                                    Nuovo.CreaDaOrdine(PACK, True, True, False)
                                End If

                            End If

                        Else 'Se non esiste indice

                            ImballoName = NomeImballo.CreaNome(PACK.Tipo)

                            If CONFRONTO_IMBALLI(PACK) = False Then

                                'SE NON ESISTE IN MEMORIA UN IMBALLO CON LE STESSE CARATTERISTICHE LO CREA DA ZERO
                                Debug.WriteLine("Verrà creato il nuovo imballo " & PACK.Indice)

                                Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}

                                Nuovo.CreaDaOrdine(PACK, True, True, True)

                                'Aggiunge l'imballo alla lista dei nuovi

                                Dim RIGA_ORDINE As New RigaOrdine With {.NumeroOrdine = PACK.NumeroOrdine, .Riga = PACK.Riga, .Imballo = Nuovo.Nome, .Indice = PACK.Indice, .Qt = PACK.Qt, .Cliente = PACK.Cliente, .Codice = PACK.Codice, .Commessa = PACK.Commessa,
                                .L = PACK.L, .P = PACK.P, .H = PACK.H, .Tipo = PACK.Tipo, .Zoccoli = PACK.Zoccoli, .Rivestimento = PACK.Rivestimento, .TipoRivestimento = PACK.TipoRivestimento, .Note = PACK.Note, .DataConsegna = PACK.DataConsegna, .HT = PACK.HT, .DT = PACK.DT, .BM = PACK.BM, .Rivest_Tot = PACK.Rivest_Tot, .Magazzino = Magazzino, .Diagonali = PACK.Diagonali,
                                .Stampato = False, .Produzione = False, .Evaso = False}

                                ListaNuovi.Add(ImballoName)

                                SQL.InsertRigaOrdini(RIGA_ORDINE)
                            Else

                                'SE ESISTE UN IMBALLO SIMILE AGGIUNGE SOLO IL NOME ALLA TABELLA INDEX 

                                Debug.WriteLine("E' stato trovato un imballo corrispondente: " & PACK.Indice & " = " & ImballoName)

                                Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}

                                Nuovo.CreaDaOrdine(PACK, False, False, True)

                                Dim RIGA_ORDINE As New RigaOrdine With {.NumeroOrdine = PACK.NumeroOrdine, .Riga = PACK.Riga, .Imballo = Nuovo.Nome, .Indice = PACK.Indice, .Qt = PACK.Qt, .Cliente = PACK.Cliente, .Codice = PACK.Codice, .Commessa = PACK.Commessa,
                                .L = PACK.L, .P = PACK.P, .H = PACK.H, .Tipo = PACK.Tipo, .Zoccoli = PACK.Zoccoli, .Rivestimento = PACK.Rivestimento, .TipoRivestimento = PACK.TipoRivestimento, .Note = PACK.Note, .DataConsegna = PACK.DataConsegna, .HT = PACK.HT, .DT = PACK.DT, .BM = PACK.BM, .Rivest_Tot = PACK.Rivest_Tot, .Magazzino = Magazzino, .Diagonali = PACK.Diagonali,
                                .Stampato = False, .Produzione = False, .Evaso = False}

                                SQL.InsertRigaOrdini(RIGA_ORDINE)

                            End If

                        End If
                    Next

                Catch ex As Exception

                    MsgBox("Problema con l'elaborazione dell'ordine" & vbCrLf & ex.Message)

                End Try



            End If

            StampaListaNuovi(ListaNuovi)

        End Sub

        Private Sub StampaListaNuovi(ByVal Lista As List(Of String))

            If Not Lista.Count = 0 Then
                If MsgBox("Sono stati trovati dei codici nuovi, stampare la lista?", vbYesNo, "Codici Nuovi") = MsgBoxResult.Yes Then

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
