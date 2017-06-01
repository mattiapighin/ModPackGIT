
Namespace BarCode
    Module Module_BarCode

        Public Function Genera(ByVal Valore As String, Optional Testo As Boolean = False, Optional Height As Integer = 100) As System.Drawing.Image
            Try
                Dim Code As System.Drawing.Image
                Dim Estensione As String = Nothing

                Dim barcode As New iTextSharp.text.pdf.Barcode128() With {.BarHeight = Height, .AltText = Valore, .ChecksumText = True, .GenerateChecksum = True, .Code = Valore}

                Code = barcode.CreateDrawingImage(Color.Black, Color.White)

                If Testo = True Then

                    Dim FMT As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}


                    Dim G As Graphics
                    G = Graphics.FromImage(Code)

                    Dim MS As SizeF
                    MS = G.MeasureString(Valore, New Font(FontFamily.GenericMonospace, 10))
                    MS.Width += 20
                    Dim Sfondo As New Rectangle(Code.Width / 2 - (MS.Width / 2), Code.Height - (MS.Height), MS.Width, MS.Height)

                    G.FillRectangle(Brushes.White, Sfondo)
                    G.DrawString(Valore, New Font(FontFamily.GenericMonospace, 10), Brushes.Black, Sfondo, FMT)

                End If


                Return Code
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

    End Module
End Namespace