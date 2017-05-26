Namespace Ordine
    Public Class RigaOrdine
        Private _NumeroOrdine As String
        Public Property NumeroOrdine() As String
            Get
                Return _NumeroOrdine
            End Get
            Set(ByVal value As String)
                _NumeroOrdine = value
            End Set
        End Property

        Private _Riga As Integer
        Public Property Riga() As Integer
            Get
                Return _Riga
            End Get
            Set(ByVal value As Integer)
                _Riga = value
            End Set
        End Property

        Private _Imballo As String = ""
        Public Property Imballo() As String
            Get
                Return _Imballo
            End Get
            Set(ByVal value As String)
                _Imballo = value
            End Set
        End Property

        Private _Indice As Integer
        Public Property Indice() As Integer
            Get
                Return _Indice
            End Get
            Set(ByVal value As Integer)
                _Indice = value
            End Set
        End Property

        Private _Qt As Integer
        Public Property Qt() As Integer
            Get
                Return _Qt
            End Get
            Set(ByVal value As Integer)
                _Qt = value
            End Set
        End Property

        Private _Cliente As String
        Public Property Cliente() As String
            Get
                Return _Cliente
            End Get
            Set(ByVal value As String)
                _Cliente = value
            End Set
        End Property

        Private _Codice As String
        Public Property Codice() As String
            Get
                Return _Codice
            End Get
            Set(ByVal value As String)
                _Codice = value
            End Set
        End Property

        Private _Commessa As String
        Public Property Commessa() As String
            Get
                Return _Commessa
            End Get
            Set(ByVal value As String)
                _Commessa = value
            End Set
        End Property

        Private _L As Integer
        Public Property L() As Integer
            Get
                Return _L
            End Get
            Set(ByVal value As Integer)
                _L = value
            End Set
        End Property

        Private _P As Integer
        Public Property P() As Integer
            Get
                Return _P
            End Get
            Set(ByVal value As Integer)
                _P = value
            End Set
        End Property

        Private _H As Integer
        Public Property H() As Integer
            Get
                Return _H
            End Get
            Set(ByVal value As Integer)
                _H = value
            End Set
        End Property

        Private _Tipo As String
        Public Property Tipo() As String
            Get
                Return _Tipo
            End Get
            Set(ByVal value As String)
                _Tipo = value
            End Set
        End Property

        Private _Zoccoli As String
        Public Property Zoccoli() As String
            Get
                Return _Zoccoli
            End Get
            Set(ByVal value As String)
                _Zoccoli = value
            End Set
        End Property

        Private _Rivestimento As Boolean
        Public Property Rivestimento() As Boolean
            Get
                Return _Rivestimento
            End Get
            Set(ByVal value As Boolean)
                _Rivestimento = value
            End Set
        End Property

        Private _TipoRivestimento As String
        Public Property TipoRivestimento() As String
            Get
                Return _TipoRivestimento
            End Get
            Set(ByVal value As String)
                _TipoRivestimento = value
            End Set
        End Property

        Private _Note As String
        Public Property Note() As String
            Get
                Return _Note
            End Get
            Set(ByVal value As String)
                _Note = value
            End Set
        End Property

        Private _DataConsegna As Date
        Public Property DataConsegna() As Date
            Get
                Return _DataConsegna
            End Get
            Set(ByVal value As Date)
                _DataConsegna = value
            End Set
        End Property

        Private _HT As Boolean
        Public Property HT() As Boolean
            Get
                Return _HT
            End Get
            Set(ByVal value As Boolean)
                _HT = value
            End Set
        End Property

        Private _DT As Boolean
        Public Property DT() As Boolean
            Get
                Return _DT
            End Get
            Set(ByVal value As Boolean)
                _DT = value
            End Set
        End Property

        Private _BM As Boolean
        Public Property BM() As Boolean
            Get
                Return _BM
            End Get
            Set(ByVal value As Boolean)
                _BM = value
            End Set
        End Property

        Private _Rivest_Tot As String
        Public Property Rivest_Tot() As String
            Get
                Return _Rivest_Tot
            End Get
            Set(ByVal value As String)
                _Rivest_Tot = value
            End Set
        End Property

        Private _Magazzino As String
        Public Property Magazzino() As String
            Get
                Return _Magazzino
            End Get
            Set(ByVal value As String)
                _Magazzino = value
            End Set
        End Property

        Private _Diagonali As Boolean
        Public Property Diagonali() As Boolean
            Get
                Return _Diagonali
            End Get
            Set(ByVal value As Boolean)
                _Diagonali = value
            End Set
        End Property

        Private _Stampato As Boolean
        Public Property Stampato() As Boolean
            Get
                Return _Stampato
            End Get
            Set(ByVal value As Boolean)
                _Stampato = value
            End Set
        End Property

        Private _Produzione As Boolean
        Public Property Produzione() As Boolean
            Get
                Return _Produzione
            End Get
            Set(ByVal value As Boolean)
                _Produzione = value
            End Set
        End Property

        Private _Evaso As Boolean
        Public Property Evaso() As Boolean
            Get
                Return _Evaso
            End Get
            Set(ByVal value As Boolean)
                _Evaso = value
            End Set
        End Property
    End Class

    Public Class RigaOrdineINPUT
        Private _NumeroOrdine As String = ""
        Public Property NumeroOrdine() As String
            Get
                Return _NumeroOrdine
            End Get
            Set(ByVal value As String)
                _NumeroOrdine = value
            End Set
        End Property

        Private _Riga As Integer
        Public Property Riga() As Integer
            Get
                Return _Riga
            End Get
            Set(ByVal value As Integer)
                _Riga = value
            End Set
        End Property

        Private _Indice As Integer
        Public Property Indice() As Integer
            Get
                Return _Indice
            End Get
            Set(ByVal value As Integer)
                _Indice = value
            End Set
        End Property

        Private _Qt As Integer
        Public Property Qt() As Integer
            Get
                Return _Qt
            End Get
            Set(ByVal value As Integer)
                _Qt = value
            End Set
        End Property

        Private _Cliente As String = ""
        Public Property Cliente() As String
            Get
                Return _Cliente
            End Get
            Set(ByVal value As String)
                _Cliente = value
            End Set
        End Property

        Private _Codice As String = ""
        Public Property Codice() As String
            Get
                Return _Codice
            End Get
            Set(ByVal value As String)
                _Codice = value
            End Set
        End Property

        Private _Commessa As String = ""
        Public Property Commessa() As String
            Get
                Return _Commessa
            End Get
            Set(ByVal value As String)
                _Commessa = value
            End Set
        End Property

        Private _L As Integer
        Public Property L() As Integer
            Get
                Return _L
            End Get
            Set(ByVal value As Integer)
                _L = value
            End Set
        End Property

        Private _P As Integer
        Public Property P() As Integer
            Get
                Return _P
            End Get
            Set(ByVal value As Integer)
                _P = value
            End Set
        End Property

        Private _H As Integer
        Public Property H() As Integer
            Get
                Return _H
            End Get
            Set(ByVal value As Integer)
                _H = value
            End Set
        End Property

        Private _Tipo As String = ""
        Public Property Tipo() As String
            Get
                Return _Tipo
            End Get
            Set(ByVal value As String)
                _Tipo = value
            End Set
        End Property

        Private _Zoccoli As String = ""
        Public Property Zoccoli() As String
            Get
                Return _Zoccoli
            End Get
            Set(ByVal value As String)
                _Zoccoli = value
            End Set
        End Property

        Private _Rivestimento As Boolean
        Public Property Rivestimento() As Boolean
            Get
                Return _Rivestimento
            End Get
            Set(ByVal value As Boolean)
                _Rivestimento = value
            End Set
        End Property

        Private _TipoRivestimento As String = ""
        Public Property TipoRivestimento() As String
            Get
                Return _TipoRivestimento
            End Get
            Set(ByVal value As String)
                _TipoRivestimento = value
            End Set
        End Property

        Private _Note As String = ""
        Public Property Note() As String
            Get
                Return _Note
            End Get
            Set(ByVal value As String)
                _Note = value
            End Set
        End Property

        Private _DataConsegna As Date
        Public Property DataConsegna() As Date
            Get
                Return _DataConsegna
            End Get
            Set(ByVal value As Date)
                _DataConsegna = value
            End Set
        End Property

        Private _HT As Boolean
        Public Property HT() As Boolean
            Get
                Return _HT
            End Get
            Set(ByVal value As Boolean)
                _HT = value
            End Set
        End Property

        Private _DT As Boolean
        Public Property DT() As Boolean
            Get
                Return _DT
            End Get
            Set(ByVal value As Boolean)
                _DT = value
            End Set
        End Property

        Private _BM As Boolean
        Public Property BM() As Boolean
            Get
                Return _BM
            End Get
            Set(ByVal value As Boolean)
                _BM = value
            End Set
        End Property

        Private _Rivest_Tot As String = ""
        Public Property Rivest_Tot() As String
            Get
                Return _Rivest_Tot
            End Get
            Set(ByVal value As String)
                _Rivest_Tot = value
            End Set
        End Property

        Private _Diagonali As Boolean
        Public Property Diagonali() As Boolean
            Get
                Return _Diagonali
            End Get
            Set(ByVal value As Boolean)
                _Diagonali = value
            End Set
        End Property

    End Class

    Public Module Ordine

        Dim ImballoName As String
        Public ListaNuovi As New List(Of RigaOrdineINPUT)
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

                            ImballoName = ConvertIndiceToImballo(PACK.Indice)

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

                            End If

                        Else 'Se non esiste indice

                            ImballoName = NomeImballo.CreaNome(PACK.Tipo)

                            If CONFRONTO_IMBALLI(PACK) = False Then

                                'SE NON ESISTE IN MEMORIA UN IMBALLO CON LE STESSE CARATTERISTICHE LO CREA DA ZERO
                                Debug.WriteLine("Verrà creato il nuovo imballo " & PACK.Indice)

                                Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}

                                Nuovo.Crea(PACK, True, True, True)

                                'Aggiunge l'imballo alla lista dei nuovi
                                ListaNuovi.Add(PACK)

                                Dim RIGA_ORDINE As New RigaOrdine With {.NumeroOrdine = PACK.NumeroOrdine, .Riga = PACK.Riga, .Imballo = Nuovo.Nome, .Indice = PACK.Indice, .Qt = PACK.Qt, .Cliente = PACK.Cliente, .Codice = PACK.Codice, .Commessa = PACK.Commessa,
                                .L = PACK.L, .P = PACK.P, .H = PACK.H, .Tipo = PACK.Tipo, .Zoccoli = PACK.Zoccoli, .Rivestimento = PACK.Rivestimento, .TipoRivestimento = PACK.TipoRivestimento, .Note = PACK.Note, .DataConsegna = PACK.DataConsegna, .HT = PACK.HT, .DT = PACK.DT, .BM = PACK.BM, .Rivest_Tot = PACK.Rivest_Tot, .Magazzino = Magazzino, .Diagonali = PACK.Diagonali,
                                .Stampato = False, .Produzione = False, .Evaso = False}

                                SQL.InsertRigaOrdini(RIGA_ORDINE)
                            Else

                                'SE ESISTE UN IMBALLO SIMILE AGGIUNGE SOLO IL NOME ALLA TABELLA INDEX 

                                Debug.WriteLine("E' stato trovato un imballo corrispondente: " & PACK.Indice & " = " & ImballoName)

                                Dim Nuovo As New NuovoImballo With {.RigaOrdine = PACK, .Nome = ImballoName}

                                Nuovo.Crea(PACK, False, False, True)

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



        End Sub





    End Module

End Namespace
