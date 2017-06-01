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

    Dim RowOrdine As New List(Of RigaOrdine)
    Dim RowIndici As New List(Of Integer)

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "[" & System.Environment.UserName & "] - ModPack - V." & My.Application.Info.Version.ToString
        LOG.Write("Inizio sessione")
    End Sub

    Private Sub Bt_CaricaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_CaricaOrdine.Click
        ToolStrip.Text = "Selezione file ordine"
        ProgressBar.Visible = True
        Ordine.CaricaOrdine(ProgressBar, ToolStrip)
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


    Private Sub Bt_Preferenze_Click(sender As Object, e As EventArgs) Handles Bt_Preferenze.Click
        Form_Preferenze.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static PagineStampate = 0

        Static EtichetteTotali As Integer = RowOrdine.Count - 1

        Stampe.Stampa_Distinte(sender, e, RowOrdine.Item(PagineStampate))

        PagineStampate += 1

        If PagineStampate <= EtichetteTotali Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            PagineStampate = 0
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDocument1.DefaultPageSettings = My.Settings.FormatoStampa
        RowIndici.AddRange({1, 2, 3})
        RowOrdine = SQL.ConvertIDLISTtoListRigaOrdine(RowIndici)
        Dim L As New PrintPreviewDialog With {.Document = PrintDocument1}
        L.Show()
    End Sub
End Class
