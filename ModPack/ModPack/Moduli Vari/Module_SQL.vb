Imports System.Data.SqlClient

Namespace SQL
    Module Module_SQL
        Public Sub InsertRigaOrdini(ByVal ROW As Ordine.RigaOrdine)

            Using TA As New ModPackDBDataSetTableAdapters.OrdiniTableAdapter

                TA.Insert(ROW.NumeroOrdine, ROW.Riga, ROW.Imballo, ROW.Indice, ROW.Qt, ROW.Cliente, ROW.Codice, ROW.Commessa, ROW.L, ROW.P, ROW.H, ROW.Tipo, ROW.Zoccoli,
                          ROW.Rivestimento, ROW.TipoRivestimento, ROW.Note, ROW.DataConsegna, ROW.HT, ROW.DT, ROW.BM, ROW.Rivest_Tot, ROW.Magazzino, ROW.Diagonali,
                          ROW.Stampato, ROW.Produzione, ROW.Evaso)

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


    End Module
End Namespace
