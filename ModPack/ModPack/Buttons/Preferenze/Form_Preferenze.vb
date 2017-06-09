Public Class Form_Preferenze

    Private Sub Bt_FormatoStampa_Click(sender As Object, e As EventArgs) Handles Bt_FormatoStampa.Click
        Dim PageFormat As New PageSetupDialog With {.Document = New Printing.PrintDocument, .EnableMetric = True}

        If Not My.Settings.FormatoStampa Is Nothing Then PageFormat.PageSettings = My.Settings.FormatoStampa

        If PageFormat.ShowDialog = DialogResult.OK Then
            My.Settings.FormatoStampa = PageFormat.PageSettings
            My.Settings.Save()
        End If


    End Sub
    Private Sub CaricaSettingsEtichette()
        With My.Settings
            Txt_MargineBottom.Text = .Etichette_MargineBottom
            Txt_MargineTop.Text = .Etichette_MargineTop
            Txt_MargineRight.Text = .Etichette_MargineRight
            Txt_MargineLeft.Text = .Etichette_MargineLeft
            Txt_mmX.Text = .Etichette_DimensioneX
            Txt_mmY.Text = .Etichette_DimensioneY
            Txt_NomeStampante.Text = .Etichette_Stampante
        End With
    End Sub
    Private Sub SalvaSettingsEtichette()
        With My.Settings
            .Etichette_MargineBottom = Txt_MargineBottom.Text
            .Etichette_MargineTop = Txt_MargineTop.Text
            .Etichette_MargineRight = Txt_MargineRight.Text
            .Etichette_MargineLeft = Txt_MargineLeft.Text
            .Etichette_DimensioneX = Txt_mmX.Text
            .Etichette_DimensioneY = Txt_mmY.Text
            .Etichette_Stampante = Txt_NomeStampante.Text
            My.Settings.Save()
        End With
    End Sub

    Private Sub CaricaSettingsCK()
        Ck_Evaso.Checked = My.Settings.CK_ConfermaEvaso
        Ck_ColoraScaduti.Checked = My.Settings.OrdiniAperti_ColoraScaduti
        Ck_ColoraEvasi.Checked = My.Settings.OrdiniAperti_ColoraEvasi
        Ck_CheckCaricamento.Checked = My.Settings.CheckInserimentoImballo
        Ck_BiancoNero.Checked = My.Settings.PrintBiancoNero
    End Sub
    Private Sub SalvaSettingsCK()
        My.Settings.CK_ConfermaEvaso = Ck_Evaso.Checked
        My.Settings.OrdiniAperti_ColoraScaduti = Ck_ColoraScaduti.Checked
        My.Settings.OrdiniAperti_ColoraEvasi = Ck_ColoraEvasi.Checked
        My.Settings.CheckInserimentoImballo = Ck_CheckCaricamento.Checked
        My.Settings.PrintBiancoNero = Ck_BiancoNero.Checked
    End Sub

    Private Sub CaricaSettingsDistinta()
        Ck_Barcode.Checked = My.Settings.StampaBarcodeDistinte
        CkBarcodeSoloCodice.Checked = My.Settings.StampaBarcodeSoloCodice
        Nu_FontDistinta.Value = My.Settings.DimensioneFontDistinta
        Nu_RigheDistinta.Value = My.Settings.NumeroRigheDistinta
    End Sub
    Private Sub SalvaSettingsDistinta()
        My.Settings.StampaBarcodeDistinte = Ck_Barcode.Checked
        My.Settings.StampaBarcodeSoloCodice = CkBarcodeSoloCodice.Checked
        My.Settings.DimensioneFontDistinta = Nu_FontDistinta.Value
        My.Settings.NumeroRigheDistinta = Nu_RigheDistinta.Value
    End Sub

    Private Sub CaricaRiferimenti()
        LblNuoviPath.Text = My.Settings.NuoviPath
        TxtScegliExcel.Text = My.Settings.ExcelPath
    End Sub
    Private Sub SalvaRiferimenti()
        My.Settings.NuoviPath = LblNuoviPath.Text
        My.Settings.ExcelPath = TxtScegliExcel.Text
    End Sub



    Private Sub Form_Preferenze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaSettingsEtichette()
        CaricaSettingsCK()
        CaricaSettingsDistinta()
        CaricaRiferimenti()

    End Sub
    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If MsgBox("Salvare le modifiche?", vbYesNo, "Preferenze") = MsgBoxResult.Yes Then
            SalvaSettingsEtichette()
            SalvaSettingsCK()
            SalvaSettingsDistinta()
            SalvaRiferimenti()

            MsgBox("Modifiche salvate", vbOKOnly, "Preferenze")
            LOG.Write("Modificate preferenze")

            If My.Settings.PrintBiancoNero = False Then
                My.Settings.FormatoStampa.Color = False
            Else
                My.Settings.FormatoStampa.Color = True
            End If
        End If

    End Sub

    Private Sub Ck_BiancoNero_CheckedChanged(sender As Object, e As EventArgs) Handles Ck_BiancoNero.CheckedChanged

    End Sub

    Private Sub Bt_PathNuovi_Click(sender As Object, e As EventArgs) Handles Bt_PathNuovi.Click
        Dim Dialog As New FolderBrowserDialog
        If Dialog.ShowDialog = DialogResult.OK Then
            LblNuoviPath.Text = Dialog.SelectedPath
        End If
    End Sub

    Private Sub Bt_SettingsEmail_Click(sender As Object, e As EventArgs) Handles Bt_SettingsEmail.Click
        Form_Preferenze_Email.Show()
    End Sub

    Private Sub Bt_TestConnessioni_Click(sender As Object, e As EventArgs) Handles Bt_TestConnessioni.Click
        Dim xml = XDocument.Load(My.Settings.XMLpath)
        Dim Ip_produzione As String = xml.<Data>.<IP_Produzione>.Value
        Dim Ip_sezionatrice As String = xml.<Data>.<IP_Sezionatrice>.Value

        If My.Computer.Network.Ping(Ip_produzione) Then
            MsgBox("PC Produzione connesso", vbOKOnly, "Test")
        Else
            MsgBox("PC Produzione disconnesso", vbCritical, "Test")
        End If


        If My.Computer.Network.Ping(Ip_sezionatrice) Then
            MsgBox("PC Sezionatrice connesso", vbOKOnly, "Test")
        Else
            MsgBox("PC Sezionatrice disconnesso", vbCritical, "Test")
        End If
    End Sub

    Private Sub Bt_ScegliExcel_Click(sender As Object, e As EventArgs) Handles Bt_ScegliExcel.Click
        Dim Dialog As New OpenFileDialog With {.Filter = ("Excel|*.exe"), .FileName = "Excel.exe", .Title = "Riferimento a Excel.exe"}
        If Dialog.ShowDialog = DialogResult.OK Then
            TxtScegliExcel.Text = Dialog.FileName
        End If
    End Sub
End Class