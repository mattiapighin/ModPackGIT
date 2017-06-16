Imports System.Xml

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

    Dim ListaMemo As New List(Of Memo)
    Dim RowOrdine As New List(Of RigaOrdine)
    Dim RowIndici As New List(Of Integer)




    Public Sub CaricaMemo()

        Using MemoTable As New ModPackDBDataSetTableAdapters.MemoTableAdapter
            Using MemoDT As New ModPackDBDataSet.MemoDataTable
                MemoTable.Fill(MemoDT)

                ListaMemo.Clear()

                For Each Row As ModPackDBDataSet.MemoRow In MemoDT.Rows
                    Dim Riga As New Memo
                    If Not Row.IsDataNull Then Riga.Data = Row.Data
                    If Not Row.IsMemoNull Then Riga.Memo = Row.Memo
                    If Not Row.IsImballoNull Then Riga.Imballo = Row.Imballo
                    ListaMemo.Add(Riga)
                Next

            End Using
        End Using

        MostraMemo()


    End Sub
    Private Sub MostraMemo()
        DGW_Memo.Rows.Clear()
        For Each Row As Memo In (From Riga In ListaMemo Where Riga.Data = Calendario.SelectionStart)
            DGW_Memo.Rows.Add(Row.Memo)
        Next
    End Sub
    Private Sub OperazioniPreliminari()
        XML.CreaXML()
        Me.Text = "[" & System.Environment.UserName & "] - ModPack - V." & My.Application.Info.Version.ToString
        LOG.Write("Inizio sessione")
        CaricaMemo()
        My.Settings.Scarto = SQL.GetPrezzoMateriale("SCART")
        My.Settings.Save()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OperazioniPreliminari()
    End Sub

    Private Sub Bt_CaricaOrdine_Click(sender As Object, e As EventArgs) Handles Bt_CaricaOrdine.Click
        ToolStrip.Text = "Selezione file ordine"
        ProgressBar.Visible = True
        'Ordine.CaricaOrdine(ProgressBar, ToolStrip, Notify)
        Ordine.CaricaFileOrdine(ProgressBar, ToolStrip, Notify)
        ToolStrip.Text = ""
        ProgressBar.Visible = False

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
    Private Sub Bt_Memo_Click(sender As Object, e As EventArgs) Handles Bt_Memo.Click
        Form_Memo.Show()
    End Sub
    Private Sub Bt_Stampe_Click(sender As Object, e As EventArgs) Handles Bt_Stampe.Click
        Form_Tabelle.Show()
    End Sub

    Private Sub Calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendario.DateChanged
        MostraMemo()
    End Sub
    Private Sub DGW_Memo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_Memo.CellContentClick
        DGW_Memo.ClearSelection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQL.Query("TRUNCATE TABLE Distinta")
        SQL.Query("TRUNCATE TABLE Imballi")
        SQL.Query("TRUNCATE TABLE Indici")
        SQL.Query("TRUNCATE TABLE Ordini")
        IO.File.Delete(My.Settings.XMLpath)
        Debug.WriteLine("Truncato tutto")
        XML.CreaXML()
    End Sub

    Private Sub Main_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub Main_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each FileOrdine In files
            If MsgBox("Caricare ordine '" & IO.Path.GetFileNameWithoutExtension(FileOrdine) & "' ?", vbYesNo, "Carica ordine") = MsgBoxResult.Yes Then
                ProgressBar.Visible = True
                Ordine.CaricaOrdine(FileOrdine, ProgressBar, ToolStrip, Notify)
                ToolStrip.Text = ""
                ProgressBar.Visible = False
            End If
        Next
    End Sub
End Class
