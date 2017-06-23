Imports System.Windows.Forms

Public Class Form_Imballi_Filtro

    Private _Filtro As String
    Public Property Filtro() As String
        Get
            Return _Filtro
        End Get
        Set(ByVal value As String)
            _Filtro = value
        End Set
    End Property

    Private Sub CaricaDati()
        Using TABLE As New ModPackDBDataSetTableAdapters.ImballiTableAdapter
            Using DS As New ModPackDBDataSet.ImballiDataTable
                TABLE.Fill(DS)

                If DS.Count > 0 Then

                    Dim LMAX As Integer = DS.Compute("MAX(L)", "")
                    NU_L_Da.Maximum = LMAX
                    NU_L_Da.Value = 0
                    NU_L_A.Maximum = LMAX
                    NU_L_A.Value = LMAX

                    Dim PMAX As Integer = DS.Compute("MAX(P)", "")
                    NU_P_Da.Maximum = PMAX
                    NU_P_Da.Value = 0
                    NU_P_A.Maximum = PMAX
                    NU_P_A.Value = PMAX

                    Dim HMAX As Integer = DS.Compute("MAX(H)", "")
                    NU_H_Da.Maximum = HMAX
                    NU_H_Da.Value = 0
                    NU_H_A.Maximum = HMAX
                    NU_H_A.Value = HMAX

                    Dim PrezzoMAX As Decimal = DS.Compute("MAX(Prezzo)", "")
                    NU_Prezzo_DA.Maximum = PrezzoMAX
                    NU_Prezzo_DA.Value = 0
                    NU_Prezzo_A.Maximum = PrezzoMAX
                    NU_Prezzo_A.Value = PrezzoMAX

                    Dim IndiceMax As Integer = DS.Compute("MAX(Id)", "")
                    Nu_Indice_DA.Maximum = IndiceMax
                    Nu_Indice_DA.Value = 0
                    NU_Indice_A.Maximum = IndiceMax
                    NU_Indice_A.Value = IndiceMax

                    Dim Tipi As DataTable = DS.DefaultView.ToTable(True, "Tipo")
                    LST_Tipi.Items.Clear()
                    For k = 0 To Tipi.Rows.Count - 1
                        LST_Tipi.Items.Add(Tipi.Rows(k).Item(0))
                    Next

                    Dim Zoccoli As DataTable = DS.DefaultView.ToTable(True, "Zoccoli")
                    LST_Zoccoli.Items.Clear()
                    For k = 0 To Zoccoli.Rows.Count - 1
                        LST_Zoccoli.Items.Add(Zoccoli.Rows(k).Item(0))
                    Next

                    Dim Rivestimenti As DataTable = DS.DefaultView.ToTable(True, "Tipo_Rivestimento")
                    LST_Rivestimento.Items.Clear()
                    For k = 0 To Rivestimenti.Rows.Count - 1
                        LST_Rivestimento.Items.Add(Rivestimenti.Rows(k).Item(0))
                    Next

                End If

            End Using
        End Using
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim PrezzoDA As Integer = NU_Prezzo_DA.Value
        Dim PrezzoA As Integer = NU_Prezzo_A.Value

        _Filtro = "L >= " & NU_L_Da.Value & " AND L <= " & NU_L_A.Value
        _Filtro += " AND P >= " & NU_P_Da.Value & " AND P <= " & NU_P_A.Value
        _Filtro += " AND H >= " & NU_H_Da.Value & " AND H <= " & NU_H_A.Value

        If LST_Tipi.SelectedItems.Count > 0 Then
            _Filtro += " AND Tipo = '" & LST_Tipi.SelectedItem & "'"
        End If

        If LST_Zoccoli.SelectedItems.Count > 0 Then
            _Filtro += " AND Zoccoli = '" & LST_Zoccoli.SelectedItem & "'"
        End If

        If LST_Rivestimento.SelectedItems.Count > 0 Then
            _Filtro += " AND Tipo_Rivestimento = '" & LST_Rivestimento.SelectedItem & "'"
        End If

        _Filtro += " AND Prezzo >= " & PrezzoDA & " AND Prezzo <= " & PrezzoA
        _Filtro += " AND Id >= " & Nu_Indice_DA.Value & " AND Id <= " & NU_Indice_A.Value


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Form_Imballi_Filtro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaDati()
    End Sub
End Class
