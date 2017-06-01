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

    End Module
End Namespace
