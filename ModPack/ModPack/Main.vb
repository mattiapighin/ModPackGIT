Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "[" & System.Environment.UserName & "] - ModPack - V." & My.Application.Info.Version.ToString
        LOG.Write("Inizio sessione")
    End Sub

    Private Sub Bt_CaricaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_CaricaOrdine.Click
        Ordine.CaricaOrdine()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQL.Query("TRUNCATE TABLE Distinta")
        SQL.Query("TRUNCATE TABLE Imballi")
        SQL.Query("TRUNCATE TABLE Indici")
        SQL.Query("TRUNCATE TABLE Ordini")
        Debug.WriteLine("Truncato tutto")
    End Sub
End Class
