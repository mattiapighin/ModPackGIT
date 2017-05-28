Namespace Stampe
    Module Modulo_Stampe

        Dim DS As New DataSet

        Public Sub ImmagineInRettangolo(Immagine As Image, Rettangolo As Rectangle, e As Printing.PrintPageEventArgs)
            Dim IMGScalata As New Size(((Rettangolo.Height * Immagine.Width) / Immagine.Height), Rettangolo.Height)
            Dim IMGScalataPoint As New Point((Rettangolo.X + (Rettangolo.Width / 2) - (IMGScalata.Width / 2)), Rettangolo.Y)
            e.Graphics.DrawImage(Immagine, IMGScalataPoint.X + 5, IMGScalataPoint.Y + 5, IMGScalata.Width - 10, IMGScalata.Height - 10)
        End Sub

        Public FMT As New StringFormat With {.Alignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .LineAlignment = StringAlignment.Center}

        Public Sub CaricaDSConfermaOrdine(ordine)
            DS.Clear()
            Dim Query As String = "SELECT Ordini.Riga, Ordini.Imballo, Ordini.Qt, Imballi.Tipo, Imballi.L, Imballi.P, Imballi.H, Ordini.indice, Imballi.m3, Imballi.Tipo_Rivestimento, Imballi.Prezzo, (Imballi.Prezzo * Ordini.Qt) AS Totale FROM Ordini LEFT JOIN Imballi ON Ordini.Imballo = Imballi.Imballo WHERE Ordine = '" & ordine & "'"
            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)

                Try
                    Con.Open()
                    Dim adapter As New System.Data.SqlClient.SqlDataAdapter(Query, Con)
                    adapter.Fill(DS)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Sub
        Public Sub ConfermaDOrdine(sender As Object, e As Printing.PrintPageEventArgs, Ordine As String)



            Dim FontTitoloBold As New Font("Calibri", 16, FontStyle.Bold)
            Dim FontTitolo As New Font("Calibri", 16)
            Dim FontRighe As New Font("Calibri", 8)

            Dim RectLogo As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top, 200, 50)
            Dim RectTitolo As New Rectangle(RectLogo.Right, e.MarginBounds.Top, e.MarginBounds.Width - 350, 50)
            Dim RectData As New Rectangle(RectTitolo.Right, e.MarginBounds.Top, 150, 50)

            e.Graphics.DrawRectangles(New Pen(Color.LightGray, 2), {RectLogo, RectTitolo, RectData})

            ImmagineInRettangolo(My.Resources.Logo, RectLogo, e)
            e.Graphics.DrawString("CONFERMA D'ORDINE", FontTitolo, Brushes.Gray, RectTitolo, FMT)
            e.Graphics.DrawString(Date.Today.Date, FontTitolo, Brushes.Gray, RectData, FMT)

            e.Graphics.FillRectangle(Brushes.LightGray, e.MarginBounds.Left, e.MarginBounds.Top + 55, e.MarginBounds.Width, 5)

            Dim RectNumeroOrdine As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Top + 65, e.MarginBounds.Width, 30)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectNumeroOrdine)
            e.Graphics.DrawString(Ordine, FontTitolo, Brushes.Gray, RectNumeroOrdine, FMT)

            Dim RectTitoli As New Rectangle(e.MarginBounds.Left, RectNumeroOrdine.Bottom + 5, e.MarginBounds.Width, 20)
            e.Graphics.FillRectangle(Brushes.LightBlue, RectTitoli)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectTitoli)

            Dim RectSotto As New Rectangle(e.MarginBounds.Left, e.MarginBounds.Bottom - 30, e.MarginBounds.Width, 30)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectSotto)

            Dim RectTabella As New Rectangle(e.MarginBounds.Left, RectNumeroOrdine.Bottom + 30, e.MarginBounds.Width, e.MarginBounds.Height - 125 - 35)
            'e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), RectTabella)

            Dim U As Single = RectTitoli.Width / 20

            Dim RectTitoloRiga As New Rectangle(RectTitoli.X, RectTitoli.Y, U, RectTitoli.Height)
            Dim RectTitoloImballo As New Rectangle(RectTitoloRiga.Right, RectTitoli.Y, U * 3, RectTitoli.Height)
            Dim RectTitoloQt As New Rectangle(RectTitoloImballo.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloDescrizione As New Rectangle(RectTitoloQt.Right, RectTitoli.Y, U * 5, RectTitoli.Height)
            Dim RectTitoloIndice As New Rectangle(RectTitoloDescrizione.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloM3 As New Rectangle(RectTitoloIndice.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloRivestimento As New Rectangle(RectTitoloM3.Right, RectTitoli.Y, U, RectTitoli.Height)
            Dim RectTitoloPrezzo As New Rectangle(RectTitoloRivestimento.Right, RectTitoli.Y, U * 2, RectTitoli.Height)
            Dim RectTitoloPrezzoTot As New Rectangle(RectTitoloPrezzo.Right, RectTitoli.Y, U * 2, RectTitoli.Height)

            e.Graphics.DrawRectangles(Pens.Black, {RectTitoloRiga, RectTitoloImballo, RectTitoloQt, RectTitoloDescrizione, RectTitoloIndice, RectTitoloM3, RectTitoloRivestimento, RectTitoloPrezzo, RectTitoloPrezzoTot})

            e.Graphics.DrawString("Riga", FontRighe, Brushes.Black, RectTitoloRiga, FMT)
            e.Graphics.DrawString("Imballo", FontRighe, Brushes.Black, RectTitoloImballo, FMT)
            e.Graphics.DrawString("Qt", FontRighe, Brushes.Black, RectTitoloQt, FMT)
            e.Graphics.DrawString("Descrizione", FontRighe, Brushes.Black, RectTitoloDescrizione, FMT)
            e.Graphics.DrawString("Indice", FontRighe, Brushes.Black, RectTitoloIndice, FMT)
            e.Graphics.DrawString("M³", FontRighe, Brushes.Black, RectTitoloM3, FMT)
            e.Graphics.DrawString("Riv.", FontRighe, Brushes.Black, RectTitoloRivestimento, FMT)
            e.Graphics.DrawString("Prezzo", FontRighe, Brushes.Black, RectTitoloPrezzo, FMT)
            e.Graphics.DrawString("Totale", FontRighe, Brushes.Black, RectTitoloPrezzoTot, FMT)

            '--- FINE INTESTAZIONE

            Static TotaleEuro As Single = 0
            Static TotaleRighe As Integer = DS.Tables(0).Rows.Count
            Static RigheStampate As Integer = 0
            Static PagineStampate As Integer = 0

            Dim PosX = RectTabella.Left
            Dim PosY = RectTabella.Top
            Dim Hriga = 25

            'Numero di righe che possono essere stampate in una pagina
            Dim righePerPagina As Integer = Math.Ceiling(RectTabella.Height / Hriga) 'Altezza righe

            'Calcola il numero di pagine che verranno stampate
            Dim nPagine As Integer

            If TotaleRighe Mod righePerPagina > 0 Then
                nPagine = (TotaleRighe \ righePerPagina) + 1
            Else
                nPagine = (TotaleRighe \ righePerPagina)
            End If

            PagineStampate += 1

            For i As Integer = RigheStampate To RigheStampate + righePerPagina - 2

                Dim RectRiga As New Rectangle(PosX, PosY, U, Hriga)
                Dim RectImballo As New Rectangle(RectTitoloRiga.Right, PosY, U * 3, Hriga)
                Dim RectQt As New Rectangle(RectTitoloImballo.Right, PosY, U * 2, Hriga)
                Dim RectDescrizione As New Rectangle(RectTitoloQt.Right, PosY, U * 5, Hriga)
                Dim RectIndice As New Rectangle(RectTitoloDescrizione.Right, PosY, U * 2, Hriga)
                Dim RectM3 As New Rectangle(RectTitoloIndice.Right, PosY, U * 2, Hriga)
                Dim RectRivestimento As New Rectangle(RectTitoloM3.Right, PosY, U, Hriga)
                Dim RectPrezzo As New Rectangle(RectTitoloRivestimento.Right, PosY, U * 2, Hriga)
                Dim RectPrezzoTot As New Rectangle(RectTitoloPrezzo.Right, PosY, U * 2, Hriga)

                If RigheStampate Mod 2 <> 0 Then e.Graphics.FillRectangle(Brushes.LightBlue, PosX, PosY, RectTabella.Width, 25)
                e.Graphics.DrawRectangles(Pens.LightGray, {RectRiga, RectImballo, RectQt, RectDescrizione, RectIndice, RectM3, RectRivestimento, RectPrezzo, RectPrezzoTot})

                With DS.Tables(0).Rows(RigheStampate)

                    Dim Descrizione As String = .Item(3) & " Cm " & .Item(4) & " x " & .Item(5) & " x " & .Item(6)

                    e.Graphics.DrawString(.Item(0), FontRighe, Brushes.Black, RectRiga, FMT)
                    e.Graphics.DrawString(.Item(1), FontRighe, Brushes.Black, RectImballo, FMT)
                    e.Graphics.DrawString(.Item(2), FontRighe, Brushes.Black, RectQt, FMT)
                    e.Graphics.DrawString(Descrizione, FontRighe, Brushes.Black, RectDescrizione, FMT)
                    e.Graphics.DrawString(.Item(7), FontRighe, Brushes.Black, RectIndice, FMT)
                    e.Graphics.DrawString(.Item(8), FontRighe, Brushes.Black, RectM3, FMT)
                    e.Graphics.DrawString(.Item(9), FontRighe, Brushes.Black, RectRivestimento, FMT)
                    e.Graphics.DrawString("€ " & .Item(10), FontRighe, Brushes.Black, RectPrezzo, FMT)
                    e.Graphics.DrawString("€ " & .Item(11), FontRighe, Brushes.Black, RectPrezzoTot, FMT)

                    TotaleEuro += .Item(11)

                End With

                Dim RectTotaleEuro As New Rectangle(RectPrezzoTot.X, RectSotto.Y, RectPrezzoTot.Width, RectSotto.Height)
                Dim RectTotaleEuroTitolo As New Rectangle(RectTotaleEuro.X - 50, RectSotto.Y, 50, RectSotto.Height)
                Dim RectPagine As New Rectangle(RectSotto.X, RectSotto.Y, 100, RectSotto.Height)

                e.Graphics.DrawString("Pag. " & PagineStampate & "/" & nPagine, FontRighe, Brushes.Gray, RectPagine, FMT)

                'Se le righe stampate sono tutte interrompe il ciclo For…Next
                If i = TotaleRighe - 1 Then
                    e.Graphics.DrawRectangle(Pens.LightGray, RectTotaleEuro)
                    e.Graphics.DrawString("TOTALE", FontRighe, Brushes.Gray, RectTotaleEuroTitolo, FMT)
                    e.Graphics.DrawString("€ " & TotaleEuro, FontRighe, Brushes.Black, RectTotaleEuro, FMT)
                    e.HasMorePages = False
                    Exit For
                End If

                'stampa della riga

                RigheStampate += 1
                PosY += Hriga

            Next

            'Controlla se vi sono altre pagine da stampare
            If PagineStampate < nPagine Then
                e.HasMorePages = True
                PosY = e.MarginBounds.Top
            Else
                e.HasMorePages = False
                RigheStampate = 0
                PagineStampate = 0
            End If

        End Sub

    End Module
End Namespace