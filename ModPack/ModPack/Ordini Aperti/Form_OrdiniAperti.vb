Imports System.Data.SqlClient

Public Class Form_OrdiniAperti

    Private Sub Form_OrdiniAperti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaListaOrdiniAperti()
    End Sub


    Private Sub CaricaListaOrdiniAperti()
        DGW_OrdiniAperti.DataSource = Nothing

        Dim DS As New DataSet
        Dim Query As String = "SELECT DISTINCT Ordine FROM Ordini WHERE Evaso = 'False'"
        Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

            Try

                Con.Open()   'Apre la connessione al db

                Dim adapter As New SqlDataAdapter(Query, Con)   'Crea la nuova tabella
                adapter.Fill(DS)    'Riempie la tabella coi risultati della query


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        DGW_OrdiniAperti.DataSource = DS.Tables(0)  'Assegna alla DGW la tabella creata
        DGW_OrdiniAperti.Columns(0).Width = DGW_OrdiniAperti.Width - 3
    End Sub
    Private Sub CaricaOrdineSelezionato(ByVal Ordine As String)
        Dgw_Ordine.DataSource = Nothing
        Dim DS As New DataSet
        Dim Query As String = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Ordini.Cliente, Ordini.Codice, Ordini.Commessa, Ordini.L, Ordini.P, Ordini.H, Ordini.indice, Ordini.Data_Consegna AS Consegna, Imballi.Prezzo, Ordini.Stampato FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & Ordine & "' AND Evaso = 'False'"
        Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

            Try

                Con.Open()   'Apre la connessione al db

                Dim adapter As New SqlDataAdapter(Query, Con)   'Crea la nuova tabella
                adapter.Fill(DS)    'Riempie la tabella coi risultati della query


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        Dgw_Ordine.DataSource = DS.Tables(0)  'Assegna alla DGW la tabella creata
        DGW_OrdiniAperti.Columns(0).Width = DGW_OrdiniAperti.Width - 3
    End Sub

    Private Sub Bt_Refresh_Click(sender As Object, e As EventArgs) Handles Bt_Refresh.Click
        CaricaOrdineSelezionato(DGW_OrdiniAperti.SelectedCells.Item(0).Value)
    End Sub
End Class