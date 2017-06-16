Namespace Liste
    Public Module Moduli_Liste
        Private _Ordine As String
        Public Property Ordine() As String
            Get
                Return _Ordine
            End Get
            Set(ByVal value As String)
                _Ordine = value
            End Set
        End Property
    End Module
End Namespace

Public Class Form_StampaListe

    Dim Titolo As String
    Dim Ordine As String = Liste.Ordine
    Dim Query As String = ""

    Private Sub Form_StampaListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Titolo.Text = Ordine
        DGW.DataSource = Nothing
        DGW.Rows.Clear()
    End Sub

    Private Sub Bt_MoraliHT_Click(sender As Object, e As EventArgs) Handles Bt_MoraliHT.Click
        Lbl_Titolo.Text = "Lista Morali HT - " & Ordine
        Query = "SELECT Distinta.X, Distinta.Y, Distinta.Z, SUM(Distinta.N * Ordini.QT) AS N FROM Ordini LEFT JOIN Distinta ON Ordini.Imballo = Distinta.Imballo WHERE Ordini.Ordine = '" & Ordine & "' AND Distinta.Tag = 'Mor' AND Ordini.HT = 'True' GROUP BY X, Y, Z ORDER BY Z DESC"
        SQL.FillDGW_SQL(Query, DGW)
    End Sub
    Private Sub Bt_Morali_Click(sender As Object, e As EventArgs) Handles Bt_Morali.Click
        Lbl_Titolo.Text = "Lista Morali FRESCO - " & Ordine
        Query = "SELECT Distinta.X, Distinta.Y, Distinta.Z, SUM(Distinta.N * Ordini.QT) AS N FROM Ordini LEFT JOIN Distinta ON Ordini.Imballo = Distinta.Imballo WHERE Ordini.Ordine = '" & Ordine & "' AND Distinta.Tag = 'Mor' AND Ordini.HT = 'False' GROUP BY X, Y, Z ORDER BY Z DESC"
        SQL.FillDGW_SQL(Query, DGW)
    End Sub

    Private Sub Bt_Esporta_Click(sender As Object, e As EventArgs) Handles Bt_Esporta.Click

        If Not DGW.Rows.Count = 0 Then
            Try

                Dim dgv As DataGridView = DGW

                Dim DTB = New DataTable, RWS As Integer, CLS As Integer

                For CLS = 0 To dgv.ColumnCount - 1 ' COLUMNS OF DTB
                    DTB.Columns.Add(dgv.Columns(CLS).Name.ToString)
                Next

                Dim DRW As DataRow

                For RWS = 0 To dgv.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                    DRW = DTB.NewRow

                    For CLS = 0 To dgv.ColumnCount - 1
                        Try
                            DRW(DTB.Columns(CLS).ColumnName.ToString) = dgv.Rows(RWS).Cells(CLS).Value.ToString
                        Catch ex As Exception
                        End Try
                    Next

                    DTB.Rows.Add(DRW)
                Next

                DTB.AcceptChanges()

                Dim DST As New DataSet
                DST.Tables.Add(DTB)
                Dim FLE As String = My.Computer.FileSystem.SpecialDirectories.Temp & "Output.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
                DTB.WriteXml(FLE)
                Dim EXL As String = My.Settings.ExcelPath ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub PrintMorali_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintMorali.PrintPage
        Stampe.ListaMorali(sender, e, Lbl_Titolo.Text, DGW)
    End Sub

    Private Sub Bt_Stampa_Click(sender As Object, e As EventArgs) Handles Bt_Stampa.Click
        Dim S As New PrintDialog

        If S.ShowDialog = DialogResult.OK Then
            PrintMorali.DocumentName = Lbl_Titolo.Text
            PrintMorali.DefaultPageSettings = My.Settings.FormatoStampa
            PrintMorali.PrinterSettings = S.PrinterSettings
            PrintMorali.Print()
        End If

    End Sub
End Class


