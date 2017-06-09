Imports System.Net.Mail
Imports iTextSharp.text.pdf

Public Class Form_Preferenze_Email
    Private Sub Form_Preferenze_Email_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Mail_Username.Text = My.Settings.MAIL_username
        Txt_Mail_Password.Text = My.Settings.MAIL_password
        Txt_Mail_PortaSMTP.Text = My.Settings.MAIL_port
        Txt_Mail_ServerSMTP.Text = My.Settings.MAIL_server
        Txt_Dest1.Text = My.Settings.MAIL_Destinatario1
        Txt_Dest2.Text = My.Settings.MAIL_Destinatario2
        Txt_Dest3.Text = My.Settings.MAIL_Destinatario3
        Txt_Dest4.Text = My.Settings.MAIL_Destinatario4
        Txt_DefaultPathCO.Text = My.Settings.MAIL_DefaultPathCO
        TxtPDFPrinter.Text = My.Settings.MAIL_PDFPrinter
    End Sub
    Private Sub Bt_Salva_Click(sender As Object, e As EventArgs) Handles Bt_Salva.Click
        My.Settings.MAIL_username = Txt_Mail_Username.Text
        My.Settings.MAIL_password = Txt_Mail_Password.Text
        My.Settings.MAIL_port = Txt_Mail_PortaSMTP.Text
        My.Settings.MAIL_server = Txt_Mail_ServerSMTP.Text

        My.Settings.MAIL_Destinatario1 = Txt_Dest1.Text
        My.Settings.MAIL_Destinatario2 = Txt_Dest2.Text
        My.Settings.MAIL_Destinatario3 = Txt_Dest3.Text
        My.Settings.MAIL_Destinatario4 = Txt_Dest4.Text
        My.Settings.MAIL_PDFPrinter = TxtPDFPrinter.Text
        My.Settings.MAIL_DefaultPathCO = Txt_DefaultPathCO.Text
        My.Settings.Save()
        MsgBox("Impostazioni aggiornate!", vbInformation, "Opzioni email")

    End Sub

    Private Sub Bt_TestMail_Click(sender As Object, e As EventArgs) Handles Bt_TestMail.Click
        If MsgBox("Inviare mail di prova a 'imballaggi@bicciatoserafino.com' ?", vbYesNo, "Test") = MsgBoxResult.Yes Then

            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            Try
                SmtpServer.Credentials = New Net.NetworkCredential(My.Settings.MAIL_username, My.Settings.MAIL_password)
                SmtpServer.Port = My.Settings.MAIL_port
                SmtpServer.Host = My.Settings.MAIL_server
                mail = New MailMessage()
                mail.From = New MailAddress(My.Settings.MAIL_username)
                mail.To.Add("imballaggi@bicciatoserafino.com")
                mail.Subject = "Test Mail"
                mail.Body = "Test Mail"
                SmtpServer.Send(mail)
                MsgBox("Email Inviata!", vbInformation, "Test")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub Bt_StampantePDF_Click(sender As Object, e As EventArgs) Handles Bt_StampantePDF.Click
        Dim G As New PrintDialog
        If G.ShowDialog = DialogResult.OK Then
            TxtPDFPrinter.Text = G.PrinterSettings.PrinterName
        End If
    End Sub

    Private Sub Bt_DefaultPathCO_Click(sender As Object, e As EventArgs) Handles Bt_DefaultPathCO.Click
        Dim G As New FolderBrowserDialog
        If G.ShowDialog = DialogResult.OK Then
            Txt_DefaultPathCO.Text = G.SelectedPath
        End If

    End Sub
End Class