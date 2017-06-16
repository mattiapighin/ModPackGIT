Imports System.ComponentModel

Public Class Main

    Dim C As Integer
    Dim H As Integer = 1



    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = My.Settings.Timer * 1000
        Timer1.Start()
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
        Dim Nuovi As Boolean = False

        Dim Selezionato As String = ListaFiles.SelectedItem

        ListaFiles.Items.Clear()
        If My.Computer.FileSystem.DirectoryExists(My.Settings.Folder) Then
            For Each File As String In My.Computer.FileSystem.GetFiles(My.Settings.Folder)
                ListaFiles.Items.Add(IO.Path.GetFileNameWithoutExtension(File))
                D += 1
            Next
        End If

        ListaFiles.Sorted = True
        ListaFiles.SelectedItem = Selezionato

        If D > C Then Nuovi = True
        C = D

        If My.Settings.Avviso = True Then
            If (Nuovi) Then Form_Avviso.ShowDialog()
        End If

        Nuovi = False


    End Sub

    Private Sub Bt_Mostra_Click(sender As Object, e As EventArgs) Handles Bt_Mostra.Click
        If ListaFiles.SelectedItems.Count > 0 Then
            DGW_Lista.Rows.Clear()

            Dim Lista() As String = IO.File.ReadAllLines(My.Settings.Folder & "\" & ListaFiles.SelectedItem & ".txt")

            For Each Riga As String In Lista
                Dim Cella() As String = Split(Riga, "|")

                Dim Stringa(2) As String

                Stringa(0) = Cella(0) & " [pz. " & Cella(1) & "]" & vbCrLf & Cella(2) & vbCrLf & Cella(3) & vbCrLf & Cella(4) & vbCrLf & Cella(5)
                ' Stringa(1) = Cella(6) 'Note1
                ' Stringa(2) = Cella(7) 'Note2
                DGW_Lista.Rows.Add(Stringa)
            Next

            Dim Font As New Font("Calibri", My.Settings.FontSize)
            DGW_Lista.DefaultCellStyle.Font = Font
            DGW_Lista.DefaultCellStyle.SelectionBackColor = My.Settings.ColoreSelezione
            DGW_Lista.DefaultCellStyle.SelectionForeColor = My.Settings.TestoSelezione
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
        Opzioni.ShowDialog()
    End Sub


    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.Nascondi = True Then
            If e.CloseReason = CloseReason.UserClosing Then
                e.Cancel = True
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub
End Class
