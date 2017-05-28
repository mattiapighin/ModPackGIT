Public Class Main

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '                                                                        '
    '       ███╗   ███╗ ██████╗ █████╗  ██████╗  █████╗  ██████╗██╗  ██╗     '
    '       ████╗ ████║██╔═══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██║ ██╔╝     '
    '       ██╔████╔██║██║   ██║██║  ██║██████╔╝███████║██║     █████╔╝      ' 
    '       ██║╚██╔╝██║██║   ██║██║  ██║██╔═══╝ ██╔══██║██║     ██╔═██╗      '
    '       ██║ ╚═╝ ██║╚██████╔╝█████╔╝ ██║     ██║  ██║╚██████╗██║  ██╗     '
    '       ╚═╝     ╚═╝ ╚═════╝ ╚════╝  ╚═╝     ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝     '
    '                                                                        '
    '                       © 2017 - Mattia Pighin                           '
    '                                                                        ' 
    '                             *Disclaimer*                               '
    '   When I wrote this code, only God and I understood what I was doing   '
    '                         Now, God only knows                            '
    '                                                                        '   
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "[" & System.Environment.UserName & "] - ModPack - V." & My.Application.Info.Version.ToString
        LOG.Write("Inizio sessione")
    End Sub

    Private Sub Bt_CaricaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_CaricaOrdine.Click
        ToolStrip.Text = "Caricamento ordine ..."
        ProgressBar.Visible = True
        Ordine.CaricaOrdine(ProgressBar)
        ToolStrip.Text = ""
        ProgressBar.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQL.Query("TRUNCATE TABLE Distinta")
        SQL.Query("TRUNCATE TABLE Imballi")
        SQL.Query("TRUNCATE TABLE Indici")
        SQL.Query("TRUNCATE TABLE Ordini")
        Debug.WriteLine("Truncato tutto")
    End Sub

    Private Sub Bt_OrdiniAperti_Click(sender As Object, e As EventArgs) Handles Bt_OrdiniAperti.Click
        Form_OrdiniAperti.Show()
    End Sub

    Private Sub Bt_Imballi_Click(sender As Object, e As EventArgs) Handles Bt_Imballi.Click
        Form_Imballi.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Stampe.ConfermaDOrdine(sender, e, ScegliOrdine.Ordine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ScegliOrdine.ShowDialog = DialogResult.OK Then
            Dim r As New PrintPreviewDialog
            Stampe.CaricaDSConfermaOrdine(ScegliOrdine.Ordine)
            r.Document = PrintDocument1
            r.ShowDialog()
        End If
    End Sub
End Class
