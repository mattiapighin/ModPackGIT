Imports System.Data.SqlClient

Namespace SQL
    Module Module_SQL
        Public Sub InsertRigaOrdini(ByVal ROW As RigaOrdine)

            Using TA As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter

                TA.Insert(ROW.NumeroOrdine, ROW.Riga, ROW.Imballo, ROW.Indice, ROW.Qt, ROW.Cliente, ROW.Codice, ROW.Commessa, ROW.L, ROW.P, ROW.H, ROW.Tipo, ROW.Zoccoli,
                          ROW.Rivestimento, ROW.TipoRivestimento, ROW.Note, ROW.DataConsegna, ROW.HT, ROW.DT, ROW.BM, ROW.Rivest_Tot, ROW.Magazzino, ROW.Diagonali,
                          ROW.Stampato, ROW.Produzione, ROW.Evaso, Date.Today.Date)

            End Using

        End Sub

        Public Function GetSQLValue(Query As String)
            Dim Value As Object = Nothing

            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)


                Using Cmd As New SqlCommand(Query, Con)

                    Try
                        Con.Open()  'Apre la connessione al db
                        Value = Cmd.ExecuteScalar()
                    Catch ex As System.Exception
                        MsgBox(ex.Message)
                    End Try

                End Using
            End Using

            Return Value
        End Function

        Public Sub Query(ByVal Query As String)

            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)


                Using Cmd As New SqlCommand(Query, Con)

                    Try
                        Con.Open()  'Apre la connessione al db
                        Cmd.ExecuteNonQuery()
                    Catch ex As System.Exception
                        MsgBox(ex.Message)
                    End Try

                End Using
            End Using


        End Sub

        Public Function ConvertIDLISTtoListRigaOrdine(ByVal IDlist As List(Of Integer)) As List(Of RigaOrdine)
            Dim Rows As New List(Of RigaOrdine)

            Dim DS As New ModPackDBDataSet.OrdiniDataTable

            Using DTA As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter
                DTA.Fill(DS)
            End Using

            For Each ID As Integer In IDlist
                For Each R As ModPackDBDataSet.OrdiniRow In DS.Rows
                    If R.Id = ID Then

                        Dim O As New RigaOrdine With {
                        .NumeroOrdine = R.Ordine, .Riga = R.Riga, .Imballo = R.Imballo, .Indice = R.Indice, .Qt = R.Qt, .Cliente = R.Cliente, .Codice = R.Codice,
                        .Commessa = R.Commessa, .L = R.L, .P = R.P, .H = R.H, .Tipo = R.Tipo, .Zoccoli = R.Zoccoli, .Rivestimento = R.Rivestimento, .TipoRivestimento = R.Tipo_Rivestimento,
                        .Note = R.Note, .DataConsegna = R.Data_Consegna, .HT = R.HT, .BM = R.BM, .DT = R.DT, .Rivest_Tot = R.Rivest_Tot, .Magazzino = R.Magazzino, .Diagonali = R.Diagonali,
                        .Stampato = R.Stampato, .Produzione = R.Produzione, .Evaso = R.Evaso, .Data_Ordine = R.Data_Ordine}

                        Rows.Add(O)
                    End If
                Next
            Next


            Return Rows
        End Function

        Public Function ImballoInOrdine(ByVal Imballo As String) As Boolean
            'Check on the OrdiniTable if the order was already loaded
            Dim Exist As Boolean = False
            Dim Count As Int16

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                Using Cmd As New System.Data.SqlClient.SqlCommand("SELECT COUNT(Imballo) FROM Ordini WHERE Imballo = '" & Imballo & "' AND Evaso = 'False'", Con)

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

        Public Sub FillDGW_SQL(Query As String, DGW As DataGridView)
            Dim DS As New DataSet
            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

                Try

                    Con.Open()   'Apre la connessione al db

                    Using adapter As New SqlDataAdapter(Query, Con)   'Crea la nuova tabella
                        adapter.Fill(DS)    'Riempie la tabella coi risultati della query
                    End Using

                    DGW.DataSource = DS.Tables(0)   'Assegna alla DGW la tabella creata

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try



            End Using
        End Sub

        Public Function GetPrezzoMateriale(ByVal Materiale As String) As Decimal
            Dim Prezzo As Decimal

            Using Table As New ModPackDBDataSetTableAdapters.MaterialiTableAdapter
                Using DS As New ModPackDBDataSet.MaterialiDataTable

                    Table.Fill(DS)

                    Dim Result() As DataRow = DS.Select("Materiale = '" & Materiale & "'")

                    Prezzo = Result(0)(4)

                End Using
            End Using


            Return Prezzo
        End Function

        Public Function GetInfoTipo(ByVal Tipo As String) As String
            Dim Info As String

            Using Table As New ModPackDBDataSetTableAdapters.TipiTableAdapter
                Using DS As New ModPackDBDataSet.TipiDataTable

                    Table.Fill(DS)

                    Dim Result() As DataRow = DS.Select("Tipo = '" & Tipo & "'")

                    If Not IsDBNull(Result(0)(9)) Then
                        Info = Result(0)(9)
                    Else
                        Info = ""
                    End If


                End Using
            End Using


            Return Info
        End Function

        Public Function GetImballInputFromImballoName(ByVal ImballoName As String) As RigaOrdineINPUT
            Dim Riga As New RigaOrdineINPUT

            Using Table As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                Using DS As New ModPackDBDataSet.ImballiDataTable
                    Table.Fill(DS)

                    Dim Valori() As DataRow = DS.Select("Imballo = '" & ImballoName & "'")

                    Riga.L = Valori(0)(2)
                    Riga.P = Valori(0)(3)
                    Riga.H = Valori(0)(4)
                    Riga.Tipo = Valori(0)(5)
                    Riga.Zoccoli = Valori(0)(6)
                    Riga.Rivestimento = Valori(0)(7)
                    Riga.TipoRivestimento = Valori(0)(8)
                    Riga.HT = Valori(0)(9)
                    Riga.DT = Valori(0)(10)
                    Riga.BM = Valori(0)(11)
                    Riga.Diagonali = Valori(0)(12)



                End Using
            End Using

            Return Riga
        End Function

        Public Sub SendIndex(ByVal Imballo As String, ByVal Indice As String, Optional Codice As String = "", Optional Note As String = "", Optional Rivest_Tot As String = "", Optional Note_BiC As String = "")
            Using DS As New ModPackDBDataSet

                Using IndexTable As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                    Using ImballiTable As New ModPackDBDataSetTableAdapters.ImballiTableAdapter

                        IndexTable.Fill(DS.Indici)
                        ImballiTable.Fill(DS.Imballi)

                        Dim RowImballo() As DataRow = DS.Imballi.Select("Imballo = '" & Imballo & "'")

                        'Prima di fare qualsiasi cosa controlla che esista l'imballo a cui si vuole inviare l'indice
                        If RowImballo.Length > 0 Then

                            Dim RowIndice() As DataRow = DS.Indici.Select("Indice = '" & Indice & "'")
                            If RowIndice.Length > 0 Then
                                For K = 0 To RowIndice.Length - 1
                                    'Se l'indice esisteva già nella tabella lo elimina prima di assegnarlo ad nuovo imballo
                                    IndexTable.Delete(RowIndice(K)(0), RowIndice(K)(1), RowIndice(K)(2), RowIndice(K)(3))
                                    LOG.Write("Eliminato indice (" & RowIndice(K)(2) & ") Da (" & RowIndice(K)(1) & ")")
                                Next
                            End If

                            'Invia l'indice al nuovo imballo
                            IndexTable.Insert(Imballo.ToUpper, Indice, Codice, Note, Rivest_Tot, Note_BiC)

                            IndexTable.Update(DS.Indici)
                            LOG.Write("Inviato indice (" & Indice & ") -> (" & Imballo & ")")

                        Else
                            MsgBox("Non esiste nessun imballo '" & Imballo & "'")
                        End If

                    End Using
                End Using
            End Using
        End Sub

        Public Function Get_NoteBic(ByVal Indice As Integer)
            Dim Nota As String = ""

            Using DS As New ModPackDBDataSet.IndiciDataTable
                Using Table As New ModPackDBDataSetTableAdapters.IndiciTableAdapter
                    Table.Fill(DS)

                    Dim Row() As DataRow = DS.Select("Indice = '" & Indice & "'")

                    If Row.Length > 0 Then
                        Nota = Row(0)(6)
                    End If


                End Using
            End Using

            Return Nota
        End Function

    End Module
End Namespace
