Imports System.Data.SqlClient

Public Class Form_StoricoOrdini

    Private Sub CaricaOrdini()

        'Riempie la tabella OrdiniAperti con i numeri d'ordine di ordini con ancora righe non evase
        Using DS As New DataSet

            Dim Query As String

            If My.Settings.OrdiniNRecords > 0 Then
                Query = "SELECT DISTINCT TOP(" & My.Settings.OrdiniNRecords & ") Ordine, Data_Ordine FROM Ordini ORDER BY Data_Ordine DESC"
            Else
                Query = "SELECT DISTINCT Ordine, Data_Ordine FROM Ordini ORDER BY Data_Ordine DESC"
            End If

            Using Con As New SqlConnection(My.Settings.ModPackDBConnectionString)

                Try
                    Con.Open()
                    Dim adapter As New SqlDataAdapter(Query, Con)
                    adapter.Fill(DS)    '
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using

            DGW_Ordini.DataSource = DS.Tables(0)

        End Using
        OrdiniBindingSource.Filter = "Ordine = 'XXXX'"
    End Sub


    Private Sub Form_StoricoOrdini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Ordini'. È possibile spostarla o rimuoverla se necessario.
        Me.OrdiniTableAdapter.Fill(Me.ModPackDBDataSet.Ordini)

        Cb_Colonna.Items.Clear()
        For Each Column As DataColumn In ModPackDBDataSet.Ordini.Columns
            Cb_Colonna.Items.Add(Column.ColumnName)
        Next

        CaricaOrdini()
    End Sub

    Private Sub DGW_Ordini_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Ordini.CellClick
        OrdiniBindingSource.Filter = "Ordine = '" & DGW_Ordini.CurrentRow.Cells(0).Value & "'"
        DGW_Righe.Columns(1).Visible = False
    End Sub

    Private Sub Bt_Cerca_Click(sender As Object, e As EventArgs) Handles Bt_Cerca.Click
        If Not TxtCerca.Text = "" And Not Cb_Colonna.Text = "" Then
            OrdiniBindingSource.Filter = Cb_Colonna.Text & " LIKE '" & TxtCerca.Text & "'"
            DGW_Righe.Columns(1).Visible = True
        End If
    End Sub

    Private Sub Bt_CancellaFiltro_Click(sender As Object, e As EventArgs) Handles Bt_CancellaFiltro.Click
        TxtCerca.Text = ""
        Cb_Colonna.Text = ""
        OrdiniBindingSource.Filter = Nothing
        DGW_Righe.Columns(1).Visible = False
    End Sub
End Class