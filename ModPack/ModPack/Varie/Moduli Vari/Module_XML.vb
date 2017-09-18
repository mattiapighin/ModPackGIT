﻿Namespace XML
    Module Module_XML


        'Dim xml = XDocument.Load(My.Settings.XMLpath)
        'Valore = xml.<Data>.<CodeCount>.Value

        Public Sub CreaXML()
            If IO.File.Exists(My.Settings.XMLpath) = False Then

                Dim settings As New System.Xml.XmlWriterSettings() With {.Indent = True}

                Dim XmlWrt As System.Xml.XmlWriter = System.Xml.XmlWriter.Create(My.Settings.XMLpath, settings)

                With XmlWrt


                    .WriteStartDocument()
                    .WriteComment("Configurazioni ModPack")
                    .WriteStartElement("Data")

                    .WriteStartElement("DefaultPath")
                    .WriteValue("Z:\ModPack")
                    .WriteEndElement()

                    'Conteggio dei codici salvati
                    .WriteStartElement("CodeCount")
                    .WriteValue("0")
                    .WriteEndElement()

                    'Tipo di scala Immagine
                    ' 0 = Scala solo Y
                    ' 1 = Scala XY
                    .WriteStartElement("TipoScalaIMG")
                    .WriteValue("1")
                    .WriteEndElement()

                    .WriteStartElement("IP_Sezionatrice")
                    .WriteValue("192.168.1.23")
                    .WriteEndElement()

                    .WriteStartElement("IP_Produzione")
                    .WriteValue("192.168.1.101")
                    .WriteEndElement()

                    .WriteStartElement("IP_Riserva")
                    .WriteValue("0")
                    .WriteEndElement()

                    .WriteStartElement("Dist_Zoccoli")
                    .WriteValue("45")
                    .WriteEndElement()

                    .WriteStartElement("MultiUtente")
                    .WriteValue("False")
                    .WriteEndElement()

                    .WriteStartElement("Pulizia_Ordine")
                    .WriteValue("True")
                    .WriteEndElement()

                    .WriteStartElement("Giorni_Memoria_Ordine")
                    .WriteValue("60")
                    .WriteEndElement()

                    .WriteStartElement("Max_LOG")
                    .WriteValue("1048576")
                    .WriteEndElement()

                    .WriteStartElement("Diagonali")
                    .WriteStartElement("Max_Gradi")
                    .WriteValue("45")
                    .WriteEndElement()
                    .WriteStartElement("Inverti")
                    .WriteValue("True")
                    .WriteEndElement()
                    .WriteEndElement()

                    .WriteEndDocument()
                    .Close()

                    LOG.Write("PRIMO AVVIO - Creazione file di configurazione")
                    MsgBox("XML di configurazione creato", vbInformation, "Primo avvio")

                End With


            End If
        End Sub

        Public Function ContaImballi() As Integer
            Dim Conta As Integer
            Dim X = XDocument.Load(My.Settings.XMLpath)
            Conta = X.<Data>.<CodeCount>.Value
            Return Conta
        End Function

    End Module
End Namespace
