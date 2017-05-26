
Public Class Tipo
    Private _Tipo As String
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property
    Private _Descizione As String
    Public Property Descrizione() As String
        Get
            Return _Descizione
        End Get
        Set(ByVal value As String)
            _Descizione = value
        End Set
    End Property
    Private _intMax As Integer
    Public Property InterasseMax() As Integer
        Get
            Return _intMax
        End Get
        Set(ByVal value As Integer)
            _intMax = value
        End Set
    End Property
    Private _SpazioBTL As Integer
    Public Property SpazioBTL() As Integer
        Get
            Return _SpazioBTL
        End Get
        Set(ByVal value As Integer)
            _SpazioBTL = value
        End Set
    End Property
    Private _SpazioBTT As Integer
    Public Property SpazioBTT() As Integer
        Get
            Return _SpazioBTT
        End Get
        Set(ByVal value As Integer)
            _SpazioBTT = value
        End Set
    End Property
    Private _SpazioCTL As Integer
    Public Property SpazioCTL() As Integer
        Get
            Return _SpazioCTL
        End Get
        Set(ByVal value As Integer)
            _SpazioCTL = value
        End Set
    End Property
    Private _SpazioFTL As Integer
    Public Property SpazioFTL() As Integer
        Get
            Return _SpazioFTL
        End Get
        Set(ByVal value As Integer)
            _SpazioFTL = value
        End Set
    End Property
    Private _SpazioMT As Integer
    Public Property SpazioMT() As Integer
        Get
            Return _SpazioMT
        End Get
        Set(ByVal value As Integer)
            _SpazioMT = value
        End Set
    End Property
    Private _Info As String
    Public Property Info() As String
        Get
            Return _Info
        End Get
        Set(ByVal value As String)
            _Info = value
        End Set
    End Property
    Private _PrezzoM3 As Single
    Public Property PrezzoM3() As Single
        Get
            Return _PrezzoM3
        End Get
        Set(ByVal value As Single)
            _PrezzoM3 = value
        End Set
    End Property
End Class

Public Class Riga_Distinta
    Private _Part As String
    Public Property Part() As String
        Get
            Return _Part
        End Get
        Set(ByVal value As String)
            _Part = value
        End Set
    End Property
    Private _X As Single
    Public Property X() As Single
        Get
            Return _X
        End Get
        Set(ByVal value As Single)
            _X = value
        End Set
    End Property
    Private _Y As Single
    Public Property Y() As Single
        Get
            Return _Y
        End Get
        Set(ByVal value As Single)
            _Y = value
        End Set
    End Property
    Private _Z As Single
    Public Property Z() As Single
        Get
            Return _Z
        End Get
        Set(ByVal value As Single)
            _Z = value
        End Set
    End Property
    Private _N As Integer
    Public Property N() As Integer
        Get
            Return _N
        End Get
        Set(ByVal value As Integer)
            _N = value
        End Set
    End Property
    Private _Tag As String
    Public Property Tag() As String
        Get
            Return _Tag
        End Get
        Set(ByVal value As String)
            _Tag = value
        End Set
    End Property
End Class

