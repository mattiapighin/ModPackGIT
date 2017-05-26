Namespace Imballo
    Module Funzioni_Distinte

        Public Function GetTipo(ByVal Tipo As String) As Tipo
            'Popola un oggetto TIPO con le sue proprietà in base alla stringa passata (es. G, P, GDA)
            Dim Oggetto As New Tipo
            Dim Query As String = "SELECT * FROM Tipi WHERE Tipo = '" & Tipo & "'"

            Using Con As New System.Data.SqlClient.SqlConnection(My.Settings.ModPackDBConnectionString)
                Using CMD As New System.Data.SqlClient.SqlCommand(Query, Con)

                    Con.Open()
                    Dim Reader As SqlClient.SqlDataReader = CMD.ExecuteReader()

                    If Reader.Read() Then
                        Oggetto.Tipo = Reader.GetValue(1)
                        If Not IsDBNull(Reader.GetValue(2)) Then Oggetto.Descrizione = Reader.GetValue(2) Else Oggetto.Descrizione = ""
                        Oggetto.InterasseMax = Reader.GetValue(3)
                        Oggetto.SpazioBTL = Reader.GetValue(4)
                        Oggetto.SpazioBTT = Reader.GetValue(5)
                        Oggetto.SpazioCTL = Reader.GetValue(6)
                        Oggetto.SpazioFTL = Reader.GetValue(7)
                        Oggetto.SpazioMT = Reader.GetValue(8)
                        If Not IsDBNull(Reader.GetValue(9)) Then Oggetto.Info = Reader.GetValue(9) Else Oggetto.Info = ""
                        Oggetto.PrezzoM3 = Reader.GetValue(10)
                    End If


                End Using
            End Using
            Return Oggetto
        End Function

        Public Function CalcoloPrimoMorale(L)
            'Calcola la quota del primo morale in base alla lunghezza della gabbia
            Dim Quota As Integer

            If L <= 50 Then Quota = 0
            If L > 50 And L < 100 Then Quota = 10
            If L >= 100 Then Quota = 20

            Return Quota

        End Function
        Public Function NumeroMorali(BTL, PrimoMorale, interasseMAX)
            Dim N As Integer
            Dim CentroEsterni As Single = BTL - (PrimoMorale * 2)
            N = Math.Ceiling((CentroEsterni / interasseMAX) + 1)
            Return N
        End Function
        Public Function NumeroTavole(Superficie, SpazioMAX, Ltav)
            Dim N As Integer = 1
            Dim Spazio As Single = SpazioMAX + 100

            Do Until Spazio < SpazioMAX
                N += 1
                Spazio = (Superficie - (N * Ltav)) / (N - 1)
            Loop

            Return N
        End Function

        Function Diagonali_lunghezza(Base, Altezza, Ltav)
            Dim IPO As Object
            Dim Ltav1 As Object
            Dim radIPO As Object
            Dim radTAV As Object
            Dim radTOT As Object
            Dim GRADI As Object

            Dim A As Integer = Altezza

            IPO = Math.Sqrt((A ^ 2) + (Base ^ 2))
            Ltav1 = Math.Sqrt((IPO ^ 2) - (Ltav ^ 2))
            radIPO = Math.Atan(Base / A)
            radTAV = Math.Atan(Ltav / Ltav1)
            radTOT = radIPO - radTAV

            GRADI = radTOT * 180 / Math.PI
            Return Ltav1
        End Function
        Function Diagonali_gradi(Base, Altezza, Ltav)
            Dim IPO As Object
            Dim Ltav1 As Object
            Dim radIPO As Object
            Dim radTAV As Object
            Dim radTOT As Object
            Dim GRADI As Object

            Dim A As Integer = Altezza

            IPO = Math.Sqrt((A ^ 2) + (Base ^ 2))
            Ltav1 = Math.Sqrt((IPO ^ 2) - (Ltav ^ 2))
            radIPO = Math.Atan(Base / A)
            radTAV = Math.Atan(Ltav / Ltav1)
            radTOT = radIPO - radTAV

            GRADI = radTOT * 180 / Math.PI
            Return GRADI
        End Function



    End Module
End Namespace
