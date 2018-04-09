Public Class CFE
    Private _TipoCFE As Integer
    Private _Serie As String
    Private _Nro As Long
    Private _FchEmis As Date
    Private _MntBruto As Single
    Private _FmaPago As Integer
    Private _FchVenc As Date

    Private _RUCEmisor As String
    Private _RznSoc As String
    Private _CdgDGISucur As Integer
    Private _DomFiscal As String
    Private _Ciudad As String
    Private _Departamento As String

    Private _TipoDocRecep As Integer
    Private _CodPaisRecep As String
    Private _DocRecep As Long
    Private _RznSocRecep As String
    Private _DirRecep As String
    Private _CiudadRecep As String
    Private _DeptoRecep As String

    Private _TpoMoneda As String
    Private _MntNoGrv As Single
    Private _MntNetoIvaTasaMin As Single
    Private _MntNetoIVATasaBasica As Single
    Private _IVATasaMin As Single
    Private _IVATasaBasica As Single
    Private _MntIVATasaMin As Single
    Private _MntIVATasaBasica As Single
    Private _MntTotal As Single
    Private _CantLinDet As Integer
    Private _MntPagar As Single


    Public Property TipoCFE() As Integer
        Get
            Return Me._TipoCFE
        End Get
        Set(ByVal value As Integer)
            Me._TipoCFE = value
        End Set
    End Property

    Public Property Serie() As Integer
        Get
            Return Me._Serie
        End Get
        Set(ByVal value As Integer)
            Me._Serie = value
        End Set
    End Property

    Public Property MntBruto() As Integer
        Get
            Return Me._MntBruto
        End Get
        Set(ByVal value As Integer)
            Me._MntBruto = value
        End Set
    End Property

    Public Property FmaPago() As Integer
        Get
            Return Me._FmaPago
        End Get
        Set(ByVal value As Integer)
            Me._FmaPago = value
        End Set
    End Property

    Public Property FchVenc() As Date
        Get
            Return Me._FchVenc
        End Get
        Set(ByVal value As Date)
            Me._FchVenc = value
        End Set
    End Property

    Public Property RUCEmisor() As Integer
        Get
            Return Me._RUCEmisor
        End Get
        Set(ByVal value As Integer)
            Me._RUCEmisor = value
        End Set
    End Property

    Public Property RznSoc() As String
        Get
            Return Me._RznSoc
        End Get
        Set(ByVal value As String)
            Me._RznSoc = value
        End Set
    End Property

    Public Property CdgDGISucur() As Integer
        Get
            Return Me._CdgDGISucur
        End Get
        Set(ByVal value As Integer)
            Me._CdgDGISucur = value
        End Set
    End Property

    Public Property DomFiscal() As String
        Get
            Return Me._DomFiscal
        End Get
        Set(ByVal value As String)
            Me._DomFiscal = value
        End Set
    End Property

    Public Property Ciudad() As String
        Get
            Return Me._Ciudad
        End Get
        Set(ByVal value As String)
            Me._Ciudad = value
        End Set
    End Property

    Public Property Departamento() As String
        Get
            Return Me._Departamento
        End Get
        Set(ByVal value As String)
            Me._Departamento = value
        End Set
    End Property

    Public Property TipoDocRecep() As Integer
        Get
            Return Me._TipoDocRecep
        End Get
        Set(ByVal value As Integer)
            Me._TipoDocRecep = value
        End Set
    End Property

    Public Property CodPaisRecep() As String
        Get
            Return Me._CodPaisRecep
        End Get
        Set(ByVal value As String)
            Me._CodPaisRecep = value
        End Set
    End Property

    Public Property DocRecep() As Long
        Get
            Return Me._DocRecep
        End Get
        Set(ByVal value As Long)
            Me._DocRecep = value
        End Set
    End Property

    Public Property RznSocRecep() As String
        Get
            Return Me._RznSocRecep
        End Get
        Set(ByVal value As String)
            Me._RznSocRecep = value
        End Set
    End Property

    Public Property DirRecep() As String
        Get
            Return Me._DirRecep
        End Get
        Set(ByVal value As String)
            Me._DirRecep = value
        End Set
    End Property

    Public Property CiudadRecep() As String
        Get
            Return Me._CiudadRecep
        End Get
        Set(ByVal value As String)
            Me._CiudadRecep = value
        End Set
    End Property

    Public Property DeptoRecep() As String
        Get
            Return Me._DeptoRecep
        End Get
        Set(ByVal value As String)
            Me._DeptoRecep = value
        End Set
    End Property

    Public Property TpoMoneda() As String
        Get
            Return Me._TpoMoneda
        End Get
        Set(ByVal value As String)
            Me._TpoMoneda = value
        End Set
    End Property

    Public Property MntNoGrv() As Single
        Get
            Return Me._MntNoGrv
        End Get
        Set(ByVal value As Single)
            Me._MntNoGrv = value
        End Set
    End Property

    Public Property MntNetoIvaTasaMin() As Single
        Get
            Return Me._MntNetoIvaTasaMin
        End Get
        Set(ByVal value As Single)
            Me._MntNetoIvaTasaMin = value
        End Set
    End Property

    Public Property MntNetoIVATasaBasica() As Single
        Get
            Return Me._MntNetoIVATasaBasica
        End Get
        Set(ByVal value As Single)
            Me._MntNetoIVATasaBasica = value
        End Set
    End Property

    Public Property IVATasaMin() As Single
        Get
            Return Me._IVATasaMin
        End Get
        Set(ByVal value As Single)
            Me._IVATasaMin = value
        End Set
    End Property

    Public Property IVATasaBasica() As Single
        Get
            Return Me._IVATasaBasica
        End Get
        Set(ByVal value As Single)
            Me._IVATasaBasica = value
        End Set
    End Property

    Public Property MntIVATasaMin() As Single
        Get
            Return Me._MntIVATasaMin
        End Get
        Set(ByVal value As Single)
            Me._MntIVATasaMin = value
        End Set
    End Property

    Public Property MntIVATasaBasica() As Single
        Get
            Return Me._MntIVATasaBasica
        End Get
        Set(ByVal value As Single)
            Me._MntIVATasaBasica = value
        End Set
    End Property

    Public Property MntTotal() As Single
        Get
            Return Me._MntTotal
        End Get
        Set(ByVal value As Single)
            Me._MntTotal = value
        End Set
    End Property

    Public Property CantLinDet() As Integer
        Get
            Return Me._CantLinDet
        End Get
        Set(ByVal value As Integer)
            Me._CantLinDet = value
        End Set
    End Property

    Public Property MntPagar() As Single
        Get
            Return Me._MntPagar
        End Get
        Set(ByVal value As Single)
            Me._MntPagar = value
        End Set
    End Property

End Class



