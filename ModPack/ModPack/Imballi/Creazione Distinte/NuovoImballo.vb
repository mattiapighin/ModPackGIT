Public Class NuovoImballo

    '1. CREARE DISTINTA
    '2. CREARE RIGA IMBALLO
    '3. CREARE RIGA INDICE

    Private _RigaOrdine As Ordine.RigaOrdineINPUT
    Public Property RigaOrdine() As Ordine.RigaOrdineINPUT
        Get
            Return _RigaOrdine
        End Get
        Set(ByVal value As Ordine.RigaOrdineINPUT)
            _RigaOrdine = value
        End Set
    End Property

    Dim Distinta As New List(Of Riga_Distinta)

    Private R_NomeImballo As String
    Public Property Nome() As String
        Get
            Return R_NomeImballo
        End Get
        Set(value As String)
            R_NomeImballo = value
        End Set
    End Property

    Private R_Riga As Integer
    Private R_Indice As Integer
    Private R_Qt As Integer
    Private R_Cliente As String
    Private R_Codice As String
    Private R_Commessa As String
    Private R_Lunghezza As Integer
    Private R_Profondità As Integer
    Private R_Altezza As Integer
    Private R_Type As String
    Private R_Zoccoli As String
    Private R_Rivestimento As Boolean
    Private R_TipoRivestimento As String
    Private R_Note As String
    Private R_DataConsegna As String
    Private R_HT As Boolean
    Private R_DT As Boolean
    Private R_BM As Boolean
    Private R_Rivest_Tot As String
    Private R_Diagonali As Boolean
    Private R_GradiF As Integer
    Private R_GradiT As Integer
    Private R_PrimoMOR As Integer
    Private R_M2 As Single
    Private R_M3 As Single
    Private R_Prezzo As Single

    Private Sub CaricaVariabili()

        ' R_NomeImballo = NomeImballo.CreaNome(_RigaOrdine.Tipo)
        R_Riga = _RigaOrdine.Riga
        R_Indice = _RigaOrdine.Indice
        R_Qt = _RigaOrdine.Qt
        R_Cliente = _RigaOrdine.Cliente
        R_Codice = _RigaOrdine.Codice
        R_Commessa = _RigaOrdine.Commessa
        R_Lunghezza = _RigaOrdine.L
        R_Profondità = _RigaOrdine.P
        R_Altezza = _RigaOrdine.H
        R_Type = _RigaOrdine.Tipo
        R_Zoccoli = _RigaOrdine.Zoccoli
        R_Rivestimento = _RigaOrdine.Rivestimento
        R_TipoRivestimento = _RigaOrdine.TipoRivestimento
        R_Note = _RigaOrdine.Note
        R_DataConsegna = _RigaOrdine.DataConsegna
        R_HT = _RigaOrdine.HT
        R_DT = _RigaOrdine.DT
        R_BM = _RigaOrdine.BM
        R_Rivest_Tot = _RigaOrdine.Rivest_Tot
        R_Diagonali = _RigaOrdine.Diagonali
    End Sub

    Public Sub Crea(ByVal RigaOrdine As Ordine.RigaOrdineINPUT, Optional _InsertDistinta As Boolean = True, Optional _InsertImballo As Boolean = True, Optional _InsertIndice As Boolean = True)
        Debug.WriteLine("##### imballo " & _RigaOrdine.Indice & " #####")
        Debug.WriteLine("Carico Variabili")
        CaricaVariabili()

        Debug.WriteLine("Elaboro tipo")
        Select Case R_Type
            Case "GDA"
                Distinta = Crea_GDA(R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_DT, R_BM, R_Diagonali, R_HT)
        End Select

        Debug.WriteLine("Creo distinta")
        If _InsertDistinta = True Then InsertDistinta()
        Debug.WriteLine("Creo imballo")
        If _InsertImballo = True Then InsertImballo()
        Debug.WriteLine("Creo indice")
        If _InsertIndice = True Then InsertIndice()

    End Sub

    Private Sub InsertDistinta()
        Try
            Using DA As New ModPackDBDataSetTableAdapters.DistintaTableAdapter

                Dim I As Integer = 1
                For Each R As Riga_Distinta In Distinta
                    DA.Insert(R_NomeImballo, I, R.Part, R.X, R.Y, R.Z, R.N, R.Tag)
                    I += 1
                Next

                I = 0
                Distinta.Clear()

            End Using
        Catch ex As Exception

            MsgBox("Errore in INSERT DISTINTA" & R_NomeImballo & vbCrLf & ex.Message)

        End Try

    End Sub
    Private Sub InsertImballo()
        Try

            Using DA As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
                DA.Insert(R_NomeImballo, R_Lunghezza, R_Profondità, R_Altezza, R_Type, R_Zoccoli, R_Rivestimento, R_TipoRivestimento, R_HT, R_DT, R_BM, R_Diagonali, R_GradiF, R_GradiT, R_PrimoMOR, R_M2, R_M3, R_Prezzo, Nothing, Date.Today.Date)
            End Using

        Catch ex As Exception
            MsgBox("Errore in INSERT DISTINTA" & R_NomeImballo & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub InsertIndice()
        Try

            Using DT As New ModPackDBDataSetTableAdapters.IndiciTableAdapter

                DT.Insert(R_NomeImballo, R_Indice, R_Codice, R_Note)
                LOG.Write("INSERT NEW Indice " & R_NomeImballo & " " & R_Indice & " " & R_Codice)
            End Using

        Catch ex As Exception
            MsgBox("Errore in INSERT DISTINTA" & R_NomeImballo & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Function CalcoloM3(ByVal LIST As List(Of Riga_Distinta)) As Single
        Dim M3 As Single

        Try


            For Each R As Riga_Distinta In LIST
                M3 += (R.X * R.Y * R.Z * R.N)
            Next

            M3 = M3 * 10 ^ (-6)

        Catch ex As Exception
            MsgBox("Errore nel calcolo M3 - " & R_NomeImballo & vbCrLf & ex.Message)
        End Try


        Return M3
    End Function
    Private Function CalcoloM2(L, P, H) As Single
        Dim M2 As Single

        Try

            M2 = ((L * P) + (L * H) + (P * H)) * 2
            M2 = M2 * 10 ^ (-4)

        Catch EX As Exception
            MsgBox("Errore nel calcolo M2 - " & R_NomeImballo & vbCrLf & EX.Message)
        End Try


        Return M2
    End Function
    Private Function CalcoloPrezzo(M3, M2, PrezzoMateriale, PrezzoRivestimento, Rivestimento, HT) As Single
        Dim Prezzo As Single = 0

        Try

            Dim Pmat As Single = 0
            Dim Priv As Single = 0

            Pmat = PrezzoMateriale * M3
            If Rivestimento = True Then Priv = PrezzoRivestimento * M2

            Prezzo = Pmat + Priv
            Debug.WriteLine(Prezzo)

            Prezzo = Math.Round(Prezzo, 1)

        Catch ex As Exception
            MsgBox("Errore nel calcolo del prezzo - " & R_NomeImballo & vbCrLf & ex.Message)
        End Try


        Return Prezzo
    End Function


    '############################# CREAZIONE DISTINTE #############################
    Private Function Crea_GDA(L, P, H, Type, Zoccoli, DT, BM, Diagonali, HT) As List(Of Riga_Distinta)
        Dim D As New List(Of Riga_Distinta)

        D.Clear()

        Dim TIPO As Tipo = Imballo.GetTipo(Type)

        Dim Ltav As Integer = 10
        If L <= 200 Then Ltav = 8

        Dim MontanteSottoF As Integer = 11
        Dim MontanteSottoT As Integer = 4

        '############ BANCALE ############

        Dim Primomorale As Integer = Imballo.CalcoloPrimoMorale(L + 4)
        Dim NMorali As Integer = Imballo.NumeroMorali(L + 4, Primomorale, TIPO.InterasseMax)
        Dim NBTL As Integer = Imballo.NumeroTavole(P + 4, TIPO.SpazioBTL, Ltav)

        Select Case Zoccoli
            Case "2V"
                Dim Mor As New Riga_Distinta With {.X = 5, .Y = 10, .Z = (P + 4), .N = NMorali, .Tag = "Mor", .Part = "B"}
                D.Add(Mor)

            Case "EUR"
                Dim TTB As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali, .Tag = "TTB", .Part = "B"}
                Dim ZOC As New Riga_Distinta With {.X = 10, .Y = 8, .Z = 10, .N = NMorali * 3, .Tag = "ZOC", .Part = "B"}
                Dim TTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali, .Tag = "TTT", .Part = "B"}
                D.AddRange({TTB, ZOC, TTT})
        End Select

        Dim BTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (L + 4), .N = NBTL, .Tag = "BTL", .Part = "B"}

        If DT = True Then
            BTL.N *= 2
            MontanteSottoF += 1
            MontanteSottoT += 1
        End If

        If BM = True Then
            BTL.Y = 5
            MontanteSottoF += 2
            MontanteSottoT += 2
        End If

        D.Add(BTL)

        Dim BTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (P + 4), .N = NMorali * 3, .Tag = "BTT", .Part = "B"}
        D.Add(BTT)


        '############ COPERCHIO ############

        Dim CTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 4, .N = Imballo.NumeroTavole(P + 4, TIPO.SpazioCTL, Ltav), .Tag = "CTL", .Part = "C"}
        Dim CTT As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P + 4, .N = NMorali, .Tag = "CTT", .Part = "C"}

        D.AddRange({CTL, CTT})

        'Calcoli per Diagonali

        Dim SpazioFraMontantiF As Integer = (((L + 8) - (Primomorale * 2)) / (NMorali - 1)) - Ltav
        Dim SpazioFraMontantiT As Integer = P - (Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * Ltav)

        Dim LdiagF As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiF, H, Ltav)
        Dim GRADIdiagF As Single = Imballo.Diagonali_gradi(SpazioFraMontantiF, H, Ltav)
        Dim NdiagF As Integer = (NMorali - 1) * 2

        Dim LdiagT As Integer = Imballo.Diagonali_lunghezza(SpazioFraMontantiT, H, Ltav)
        Dim GRADIdiagT As Single = Imballo.Diagonali_gradi(SpazioFraMontantiT, H, Ltav)
        Dim NdiagT As Single = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav)

        If Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) Mod 2 <> 0 Then
            NdiagT = 0
        End If

        '############ FIANCATE ############

        '-- TODO -- Diagonali e gradi diagonali

        Dim FTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = L + 8, .N = Imballo.NumeroTavole(H - (Ltav * 2), TIPO.SpazioFTL, Ltav) * 2, .Tag = "FTL", .Part = "F"}
        Dim FM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = (H + MontanteSottoF + 4), .N = NMorali * 2, .Tag = "FM", .Part = "F"}
        Dim FD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagF, .N = NdiagF, .Tag = "FD", .Part = "F"}
        D.AddRange({FTL, FM, FD})

        '############ TESTE ############

        '-- TODO -- Diagonali e gradi diagonali

        Dim TTL As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = P, .N = FTL.N - 2, .Tag = "TTL", .Part = "T"}
        Dim TM As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = H + MontanteSottoT + 2, .N = Imballo.NumeroTavole(P, TIPO.SpazioMT, Ltav) * 2, .Tag = "TM", .Part = "T"}
        Dim TD As New Riga_Distinta With {.X = Ltav, .Y = 1.8, .Z = LdiagT, .N = NdiagT, .Tag = "TD", .Part = "T"}
        D.AddRange({TTL, TM, TD})

        '############ INFO ############

        Dim Prezzo_Materiale As Single = 0
        Dim Prezzo_Rivestimento As Single
        If HT = False Then
            Prezzo_Materiale = SQL.GetSQLValue("SELECT PrezzoM3 FROM Tipi WHERE Tipo = '" & Type & "'")
        Else
            Prezzo_Materiale = SQL.GetSQLValue("SELECT PrezzoM3HT FROM Tipi WHERE Tipo = '" & Type & "'")
        End If

        Prezzo_Rivestimento = SQL.GetSQLValue("SELECT Prezzo_m2 FROM Rivestimenti WHERE Tipo_Rivestimento = '" & R_TipoRivestimento & "'")

        R_GradiF = GRADIdiagF
            R_GradiT = GRADIdiagT
            R_PrimoMOR = Primomorale
            R_M2 = CalcoloM2(L, P, H)
            R_M3 = CalcoloM3(D)
            R_Prezzo = CalcoloPrezzo(R_M3, R_M2, Prezzo_Materiale, Prezzo_Rivestimento, R_Rivestimento, R_HT)

            Return D

    End Function


End Class
