Namespace NomeImballo
    Module NomeImballo

        Public Function CreaNome(ByVal Tipo As String, ByVal HT As Boolean) As String
            Dim Imballo As String = ""

            Dim count As Integer
            Dim connString = My.Settings.ModPackDBConnectionString
            Using conn As New System.Data.SqlClient.SqlConnection(connString)

                'LE PRIME DUE RIGHE INSERITE HANNO TUTTE LO STESSO CODICE
                Dim cmd As New System.Data.SqlClient.SqlCommand("SELECT IDENT_CURRENT('Imballi')", conn)
                Try
                    conn.Open()
                    count = cmd.ExecuteScalar()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using


            'Prende la prima lettera del "tipo", se è T (pallet con termoretraibile) diventa P
            Dim Lettera As String = Tipo(0)
            If Lettera = "T" Then Lettera = "P"

            Imballo = "M" & Tipo(0) & count

            If HT = True Then Imballo += "HT"

            Return Imballo
        End Function

    End Module
End Namespace