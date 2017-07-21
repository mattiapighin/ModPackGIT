Namespace Rivestimenti
    Module Invio_Rivestimenti

        Dim BC As String
        Dim F As String
        Dim T As String
        Dim Note1 As String
        Dim Note2 As String


        Public Sub Invia(ByVal Ordine As String)

            Dim xml = XDocument.Load(My.Settings.XMLpath)
            Dim Ip_sezionatrice As String = xml.<Data>.<IP_Sezionatrice>.Value

            'Controlla che il pc della sezionatrice sia connesso
            If My.Computer.Network.Ping(Ip_sezionatrice) Then

                Try

                    ' Dim Path As String = "\\" & Ip_sezionatrice & "\sezionatrice\ModPack"

                    Dim Path As String = My.Computer.FileSystem.SpecialDirectories.Desktop

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

                                        Dim Imballo As String = Row.Imballo & " (" & Row.Codice & ")"
                                        Dim Qt As String = Row.Qt
                                        Dim Rivestimento As String = ""
                                        If Not Row.IsTipo_RivestimentoNull Then Rivestimento = SQL.GetSQLValue("SELECT Descrizione FROM Rivestimenti WHERE Tipo_Rivestimento = '" & Row.Tipo_Rivestimento & "'")


                                        BC = ""
                                        F = ""
                                        T = ""
                                        Note1 = ""
                                        Note2 = ""

                                        RiempiStringa(Row)

                                        If Not Row.IsNoteNull Then Note1 = Row.Note
                                        If Not Row.IsRivest_TotNull Then Note2 = Row.Rivest_Tot

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


        End Sub

        Public Sub RiempiStringa(Row As ModPackDBDataSet.OrdiniRow)
            BC = ""
            F = ""
            T = ""

            Select Case Row.Tipo
                Case "GST"
                    BC = (Row.L + 3) & " x " & (Row.P + 3) & " = " & (Row.Qt) & "( + " & (Row.Qt) & " FAESITE)"
                    F = (Row.L - 1) & " x " & (Row.H - 2) & " = " & (Row.Qt * 2)
                    T = (Row.P - 5) & " x " & (Row.H - 2) & " = " & (Row.Qt * 2)

                Case Else
                    BC = (Row.L - 5) & " x " & (Row.P - 5) & " = " & (Row.Qt * 2)
                    F = (Row.L - 5) & " x " & (Row.H - 10) & " = " & (Row.Qt * 2)
                    T = (Row.P - 5) & " x " & (Row.H - 10) & " = " & (Row.Qt * 2)

            End Select

        End Sub

    End Module
End Namespace