Public Class Form_ListaElementi

    Private Sub CaricaElementi()

    End Sub

    Private Sub Form_ListaElementi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.FillDGW_SQL("SELECT DISTINCT Ordine FROM Ordini WHERE Evaso = 'False'", DGW_Ordini)
    End Sub

    Private Sub Bt_ListaMorali_Click(sender As Object, e As EventArgs) Handles Bt_ListaMorali.Click
        Dim Lista As New List(Of String)
        Dim StringaOrdini As String = "Ordini: "


        For Each row As DataGridViewCell In DGW_Ordini.SelectedCells
            Lista.Add(row.Value)
            StringaOrdini += row.Value & " "
        Next

        SQL.ListaMorali(Lista, DGW_Result)
        LOG.Write("Stampa lista Morali " & StringaOrdini)
    End Sub

    Private Sub Bt_DiagonaliF_Click(sender As Object, e As EventArgs) Handles Bt_DiagonaliF.Click
        Dim Lista As New List(Of String)
        Dim StringaOrdini As String = "Ordini: "

        For Each row As DataGridViewCell In DGW_Ordini.SelectedCells
            Lista.Add(row.Value)
            StringaOrdini += row.Value & " "
        Next

        SQL.ListaDiagonaliF(Lista, DGW_Result)
        LOG.Write("Stampa lista diagonali fiancate " & StringaOrdini)
    End Sub

    Private Sub Bt_DiagonaliT_Click(sender As Object, e As EventArgs) Handles Bt_DiagonaliT.Click
        Dim Lista As New List(Of String)
        Dim StringaOrdini As String = "Ordini: "

        For Each row As DataGridViewCell In DGW_Ordini.SelectedCells
            Lista.Add(row.Value)
            StringaOrdini += row.Value & " "
        Next

        SQL.ListaDiagonaliT(Lista, DGW_Result)
        LOG.Write("Stampa lista diagonali teste " & StringaOrdini)
    End Sub

    Private Sub Bt_DiagonaliTutte_Click(sender As Object, e As EventArgs) Handles Bt_DiagonaliTutte.Click
        Dim Lista As New List(Of String)
        Dim StringaOrdini As String = "Ordini: "

        For Each row As DataGridViewCell In DGW_Ordini.SelectedCells
            Lista.Add(row.Value)
            StringaOrdini += row.Value & " "
        Next

        SQL.ListaDiagonaliTOT(Lista, DGW_Result)
        LOG.Write("Stampa lista diagonali completa " & StringaOrdini)
    End Sub

    Private Sub Bt_Esporta_Click(sender As Object, e As EventArgs) Handles Bt_Esporta.Click
        If Not DGW_Result.Rows.Count = 0 Then
            Try

                Dim dgv As DataGridView = DGW_Result

                Dim DTB = New DataTable, RWS As Integer, CLS As Integer

                For CLS = 0 To dgv.ColumnCount - 1 ' COLUMNS OF DTB
                    DTB.Columns.Add(dgv.Columns(CLS).Name.ToString)
                Next

                Dim DRW As DataRow

                For RWS = 0 To dgv.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                    DRW = DTB.NewRow

                    For CLS = 0 To dgv.ColumnCount - 1
                        Try

                            Dim Valore As String = dgv.Rows(RWS).Cells(CLS).Value.ToString

                            If Valore = "False" Then Valore = ""
                            If Valore = "True" Then Valore = "HT"

                            DRW(DTB.Columns(CLS).ColumnName.ToString) = Valore
                        Catch ex As Exception
                        End Try
                    Next

                    DTB.Rows.Add(DRW)
                Next

                DTB.AcceptChanges()

                Dim DST As New DataSet
                DST.Tables.Add(DTB)
                Dim FLE As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\Output.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
                DTB.WriteXml(FLE)
                Dim EXL As String = My.Settings.ExcelPath ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
                Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class