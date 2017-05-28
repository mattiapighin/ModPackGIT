Public Class Form_Imballi
    Private Sub Form_Imballi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Indici'. È possibile spostarla o rimuoverla se necessario.
        Me.IndiciTableAdapter.Fill(Me.ModPackDBDataSet.Indici)
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Distinta'. È possibile spostarla o rimuoverla se necessario.
        Me.DistintaTableAdapter.Fill(Me.ModPackDBDataSet.Distinta)
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Imballi'. È possibile spostarla o rimuoverla se necessario.
        Me.ImballiTableAdapter.Fill(Me.ModPackDBDataSet.Imballi)
        Dim DS As New ModPackDBDataSet



    End Sub

    Private Sub DgwDistinta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgwDistinta.CellContentClick

    End Sub


End Class