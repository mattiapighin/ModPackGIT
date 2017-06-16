Public Class Form_Imballi

    Private Sub Form_Imballi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rinfresh()
    End Sub

    Private Sub Rinfresh()
        ImballiBindingSource.Filter = Nothing

        Me.IndiciTableAdapter.Fill(Me.ModPackDBDataSet.Indici)

        Me.DistintaTableAdapter.Fill(Me.ModPackDBDataSet.Distinta)

        Me.ImballiTableAdapter.Fill(Me.ModPackDBDataSet.Imballi)

    End Sub

    Private Sub Bt_Modifica_Click(sender As Object, e As EventArgs) Handles Bt_Modifica.Click
        Form_ModificaImballo.Show()
        Form_ModificaImballo.CbImballo.Text = DgwImballi.CurrentRow.Cells(1).Value
    End Sub

    Private Sub Bt_Refresh_Click(sender As Object, e As EventArgs) Handles Bt_Refresh.Click
        Rinfresh()
    End Sub

    Private Sub Bt_FiltroNome_Click(sender As Object, e As EventArgs) Handles Bt_FiltroNome.Click
        ImballiBindingSource.Filter = Nothing
        Dim Nome As String = InputBox("Ricerca imballo:", "Cerca per nome", "")
        If Not String.IsNullOrEmpty(Nome) Then
            ImballiBindingSource.Filter = "Imballo = '" & Nome & "'"
        End If
    End Sub

    Private Sub Bt_PulisciNuovi_Click(sender As Object, e As EventArgs) Handles Bt_PulisciNuovi.Click
        If MsgBox("Sei sicuro di voler pulire la lista dei nuovi imballi?", vbYesNo, "Pulisci lista nuovi") = MsgBoxResult.Yes Then
            Ordine.ListaNuovi.Clear()
            MsgBox("Pulizia effettuata!", vbInformation, "Pulisci lista nuovi")
            LOG.Write("Lista nuovi codici pulita")
        End If

    End Sub

    Private Sub Bt_MostraNuovi_Click(sender As Object, e As EventArgs) Handles Bt_MostraNuovi.Click
        Ordine.MostraNuovi()
    End Sub
End Class



