Public Class Main_Form

    Dim C As Integer
    Dim H As Integer = 1




    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = My.Settings.Timer

        ListaFiles.Items.Clear()

        If My.Computer.FileSystem.DirectoryExists(My.Settings.Folder) Then
            For Each File As String In My.Computer.FileSystem.GetFiles(My.Settings.Folder)
                ListaFiles.Items.Add(IO.Path.GetFileNameWithoutExtension(File))
                C += 1
            Next
        End If

        ListaFiles.Sorted = True



    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim D As Integer = 0
        Dim Selezionato As String = ListaFiles.SelectedItem

        ListaFiles.Items.Clear()
        For Each File As String In My.Computer.FileSystem.GetFiles(My.Settings.Folder)
            ListaFiles.Items.Add(IO.Path.GetFileNameWithoutExtension(File))
            D += 1
        Next

        ListaFiles.Sorted = True
        ListaFiles.SelectedItem = Selezionato

        If D > C Then MsgBox("nuovi file!")

        C = D

    End Sub

    Private Sub Bt_Mostra_Click(sender As Object, e As EventArgs) Handles Bt_Mostra.Click
        If ListaFiles.SelectedItems.Count > 0 Then
            DGW_Lista.Rows.Clear()

            Dim Lista() As String = IO.File.ReadAllLines(My.Settings.Folder & "\" & ListaFiles.SelectedItem & ".txt")

            For Each Riga As String In Lista
                Dim Cella() As String = Split(Riga, "|")

                Dim Stringa As String = Cella(0) & " [pz. " & Cella(1) & "]" & vbCrLf & Cella(2) & vbCrLf & Cella(3) & vbCrLf & Cella(4) & vbCrLf & Cella(5)
                DGW_Lista.Rows.Add(Stringa)
            Next

            Dim Font As New Font("Calibri", My.Settings.FontSize)
            DGW_Lista.DefaultCellStyle.Font = Font
        End If
    End Sub

    Private Sub DGW_Lista_KeyDown(sender As Object, e As KeyEventArgs) Handles DGW_Lista.KeyDown
        If e.KeyCode = Keys.Delete Then DGW_Lista.Rows.Remove(DGW_Lista.CurrentRow)
    End Sub

    Private Sub Bt_Elimina_Click(sender As Object, e As EventArgs) Handles Bt_Elimina.Click

        If IO.File.Exists(My.Settings.Folder & "\" & ListaFiles.SelectedItem & ".txt") Then

            IO.File.Delete(My.Settings.Folder & "\" & ListaFiles.SelectedItem & ".txt")

            C = 0
            ListaFiles.Items.Clear()
            If My.Computer.FileSystem.DirectoryExists(My.Settings.Folder) Then
                For Each File As String In My.Computer.FileSystem.GetFiles(My.Settings.Folder)
                    ListaFiles.Items.Add(IO.Path.GetFileNameWithoutExtension(File))
                    C += 1
                Next
            End If

            ListaFiles.Sorted = True

        End If
    End Sub

    Private Sub Bt_Opzioni_Click(sender As Object, e As EventArgs) Handles Bt_Opzioni.Click
        Form_Opzioni.ShowDialog()
    End Sub
End Class
