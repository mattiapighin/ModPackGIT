Imports System.Xml

Namespace NomeImballo
    Module NomeImballo

        Dim Count As String

        Private Sub CreaXML()
            If IO.File.Exists(My.Settings.XMLpath) = False Then

                Dim settings As New XmlWriterSettings()
                settings.Indent = True
                Dim XmlWrt As XmlWriter = XmlWriter.Create(My.Settings.XMLpath, settings)

                With XmlWrt

                    ' Write the Xml declaration.
                    .WriteStartDocument()

                    ' Write a comment.
                    .WriteComment("Configurazioni ModPack")

                    ' Write the root element.
                    .WriteStartElement("Data")

                    ' Start our first person.
                    .WriteStartElement("CodeCount")

                    .WriteValue("0")
                    ' The end of this person.
                    .WriteEndElement()

                    ' Close the XmlTextWriter.
                    .WriteEndDocument()
                    .Close()

                    MessageBox.Show("XML configurazioni creato")

                End With


            End If
        End Sub

        Public Function CreaNome(ByVal Tipo As String, ByVal HT As Boolean) As String

            CreaXML()

            Dim xml = XDocument.Load(My.Settings.XMLpath)

            Count = xml.<Data>.<CodeCount>.Value + 1
            Dim Imballo As String = ""

            Dim Lettera As String = Tipo(0)

            'Eccezioni
            If Lettera = "T" Then Lettera = "P"
            Imballo = "M" & Lettera & Count
            If HT = True Then Imballo += "HT"



            'Funzia ma ogni volta che si apre va su il conteggio anche se non salva il codice

            Return Imballo
        End Function
        Public Sub AggiornaConteggio()
            Dim xml = XDocument.Load(My.Settings.XMLpath)
            xml.<Data>.<CodeCount>.Value = Count
            xml.Save(My.Settings.XMLpath)
        End Sub

    End Module
End Namespace