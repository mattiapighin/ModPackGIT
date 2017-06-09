Public Class Form_Opzioni
    Private Sub BT_Ok_Click(sender As Object, e As EventArgs) Handles BT_Ok.Click
        My.Settings.Folder = TxtFolder.Text
        My.Settings.Timer = Nu_Timer.Value * 1000
        My.Settings.Save()
        MsgBox("Salvato!", vbOKOnly, "Salva")
    End Sub

    Private Sub Form_Opzioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFolder.Text = My.Settings.Folder
        Nu_Timer.Value = My.Settings.Timer \ 1000
    End Sub

    Private Sub Bt_Browse_Click(sender As Object, e As EventArgs) Handles Bt_Browse.Click
        Dim G As New FolderBrowserDialog With {.Description = "Cartella in cui sono salvati i file rivestimento"}
        If G.ShowDialog = DialogResult.OK Then
            TxtFolder.Text = G.SelectedPath
        End If

    End Sub
End Class