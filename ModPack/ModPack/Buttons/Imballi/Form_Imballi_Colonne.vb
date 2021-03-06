﻿Imports System.Windows.Forms

Public Class Form_Imballi_Colonne

    Private Function Check(Value As String) As Boolean
        Dim Checked As Boolean = False

        If Value = "0" Then
            Checked = False
        Else
            Checked = True
        End If

        Return Checked
    End Function
    Private Function Value(CheckBox As CheckBox) As String
        Dim Valore As String = ""
        If CheckBox.Checked = True Then
            Valore = "1"
        Else
            Valore = "0"
        End If
        Return Valore
    End Function

    Private Sub CaricaValori()
        Dim Filtro As String = My.Settings.FiltroColonneImballi

        If Filtro.Length = 21 Then
            C0.Checked = Check(Filtro(0))
            C1.Checked = Check(Filtro(1))
            C2.Checked = Check(Filtro(2))
            C3.Checked = Check(Filtro(3))
            C4.Checked = Check(Filtro(4))
            C5.Checked = Check(Filtro(5))
            C6.Checked = Check(Filtro(6))
            C7.Checked = Check(Filtro(7))
            C8.Checked = Check(Filtro(8))
            C9.Checked = Check(Filtro(9))
            C10.Checked = Check(Filtro(10))
            C11.Checked = Check(Filtro(11))
            C12.Checked = Check(Filtro(12))
            C13.Checked = Check(Filtro(13))
            C14.Checked = Check(Filtro(14))
            C15.Checked = Check(Filtro(15))
            C16.Checked = Check(Filtro(16))
            C17.Checked = Check(Filtro(17))
            C18.Checked = Check(Filtro(18))
            C19.Checked = Check(Filtro(19))
            C20.Checked = Check(Filtro(20))
        End If
    End Sub
    Private Sub SalvaValori()
        Dim Filtro As String = ""

        Filtro += Value(C0)
        Filtro += Value(C1)
        Filtro += Value(C2)
        Filtro += Value(C3)
        Filtro += Value(C4)
        Filtro += Value(C5)
        Filtro += Value(C6)
        Filtro += Value(C7)
        Filtro += Value(C8)
        Filtro += Value(C9)
        Filtro += Value(C10)
        Filtro += Value(C11)
        Filtro += Value(C12)
        Filtro += Value(C13)
        Filtro += Value(C14)
        Filtro += Value(C15)
        Filtro += Value(C16)
        Filtro += Value(C17)
        Filtro += Value(C18)
        Filtro += Value(C19)
        Filtro += Value(C20)

        My.Settings.FiltroColonneImballi = Filtro
        My.Settings.Save()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        SalvaValori()
        My.Settings.ImballiNRecords = TxtNRecord.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Form_Imballi_Colonne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaValori()
        TxtNRecord.Text = My.Settings.ImballiNRecords
    End Sub
End Class
