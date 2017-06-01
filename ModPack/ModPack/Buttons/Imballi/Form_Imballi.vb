Public Class Form_Imballi

    Private Sub Form_Imballi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rinfresh()
    End Sub
    Private Sub Rinfresh()
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Indici'. È possibile spostarla o rimuoverla se necessario.
        Me.IndiciTableAdapter.Fill(Me.ModPackDBDataSet.Indici)
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Distinta'. È possibile spostarla o rimuoverla se necessario.
        Me.DistintaTableAdapter.Fill(Me.ModPackDBDataSet.Distinta)
        'TODO: questa riga di codice carica i dati nella tabella 'ModPackDBDataSet.Imballi'. È possibile spostarla o rimuoverla se necessario.
        Me.ImballiTableAdapter.Fill(Me.ModPackDBDataSet.Imballi)
        '  Dim DS As New ModPackDBDataSet
    End Sub

    Private Sub Bt_Modifica_Click(sender As Object, e As EventArgs) Handles Bt_Modifica.Click
        Form_ModificaImballo.Show()
    End Sub

    Private Sub Bt_Refresh_Click(sender As Object, e As EventArgs) Handles Bt_Refresh.Click
        Rinfresh()
    End Sub
End Class



