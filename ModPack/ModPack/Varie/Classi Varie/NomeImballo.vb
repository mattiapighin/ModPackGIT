Namespace NomeImballo
    Module NomeImballo

        Public Function CreaNome(ByVal Tipo As String) As String
            Dim Imballo As String = ""

            Dim count As Integer
            Dim connString = My.Settings.ModPackDBConnectionString
            Using conn As New System.Data.SqlClient.SqlConnection(connString)

                Dim cmd As New System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM Imballi", conn)
                Try
                    conn.Open()
                    count = Convert.ToInt32(cmd.ExecuteScalar())

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using

            Imballo = "M" & Tipo(0) & count + 1

            Return Imballo
        End Function

    End Module
End Namespace