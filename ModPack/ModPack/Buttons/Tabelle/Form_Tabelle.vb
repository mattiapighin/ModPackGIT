Public Class Form_Tabelle

    Dim FileQueries As String = My.Settings.Root & "\SQLQueries.txt"

    Private Sub CaricaTreeView()
        Dim DS As New ModPackDBDataSet

        Dim I As Integer = 0

        For Each Table As DataTable In DS.Tables
            Tree.Nodes.Add(Table.TableName)
            For Each Column As DataColumn In Table.Columns
                Tree.Nodes(I).Nodes.Add(Column.ColumnName)
            Next
            I += 1
        Next

    End Sub

    Private Sub Bt_Test_Click(sender As Object, e As EventArgs) Handles Bt_Test.Click
        If Not TxtQuery.Text.Contains("DELETE") Or TxtQuery.Text.Contains("TRUNCATE") Then
            SQL.FillDGW_SQL(TxtQuery.Text, DGW_Result)
        Else
            MsgBox("Non è possibile utilizzare i comandi DELETE e TRUNCATE da questa finestra")
        End If

    End Sub

    Private Sub Form_Stampe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaTreeView()
        SQL.FillDGW_SQL("SELECT Nome FROM Queries", DGW_queries)

    End Sub

    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        If Not TxtQuery.Text.Contains("DELETE") Or TxtQuery.Text.Contains("TRUNCATE") Then
            Dim Nome As String = InputBox("Nome della Query", "Query", "")

            If Not String.IsNullOrEmpty(Nome) Then

                Using Table As New ModPackDBDataSetTableAdapters.QueriesTableAdapter
                    Using DS As New ModPackDBDataSet.QueriesDataTable
                        Table.Insert(Nome, TxtQuery.Text)
                        Table.Update(DS)
                    End Using
                End Using
                MsgBox("Query Salvata!", vbInformation, "Salva")
                SQL.FillDGW_SQL("SELECT Nome FROM Queries", DGW_queries)
            End If
        Else
            MsgBox("Non è possibile utilizzare i comandi DELETE e TRUNCATE da questa finestra")
        End If
    End Sub

    Private Sub Bt_Esegui_Click(sender As Object, e As EventArgs) Handles Bt_Esegui.Click

        Using Table As New ModPackDBDataSetTableAdapters.QueriesTableAdapter
            Using DS As New ModPackDBDataSet.QueriesDataTable
                Table.Fill(DS)

                For Each Row As ModPackDBDataSet.QueriesRow In DS.Rows
                    If Row.Nome = DGW_queries.CurrentCell.Value Then
                        SQL.FillDGW_SQL(Row.Query, DGW_Result)
                    End If
                Next

            End Using
        End Using

    End Sub

    Private Sub Bt_Elimina_Click(sender As Object, e As EventArgs) Handles Bt_Elimina.Click
        If Not DGW_queries.SelectedRows.Count = 0 Then
            Dim Nome As String = DGW_queries.CurrentCell.Value
            If MsgBox("Eliminare la query '" & Nome & "'?", vbYesNo, "Elimina") Then
                SQL.Query("DELETE FROM Queries WHERE Nome ='" & Nome & "'")
                SQL.FillDGW_SQL("SELECT Nome FROM Queries", DGW_queries)
            End If
        End If
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

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub Bt_Info_Click(sender As Object, e As EventArgs) Handles Bt_Info.Click
        If SplitContainer1.Panel2Collapsed = True Then
            SplitContainer1.Panel2Collapsed = False
        Else
            SplitContainer1.Panel2Collapsed = True
        End If

    End Sub
End Class