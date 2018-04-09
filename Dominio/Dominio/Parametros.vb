Imports dac.DsParametro, System.Data.OleDb
Imports Persistencia
Public Class Parametros
    Private _NombreParametro As String
    Private _ValorParametro As String
    Private _DescripcionParametro As String


    Public Property NombreParametro() As String
        Get
            Return Me._NombreParametro
        End Get
        Set(ByVal value As String)
            Me._NombreParametro = value
        End Set
    End Property

    Public Property ValorParametro() As String
        Get
            Return Me._ValorParametro
        End Get
        Set(ByVal value As String)
            Me._ValorParametro = value
        End Set
    End Property

    Public Property DescripcionParametro() As String
        Get
            Return Me._DescripcionParametro
        End Get
        Set(ByVal value As String)
            Me._DescripcionParametro = value
        End Set
    End Property


    Sub New(ByVal pNombreParametro As String, ByVal pValorParametro As String, ByVal pDescripcionParametro As String)
        Me._NombreParametro = pNombreParametro
        Me._ValorParametro = pValorParametro
        Me._DescripcionParametro = pDescripcionParametro
    End Sub

    Sub New()

    End Sub

#Region "Métodos para persistencia"

    Public Function Guardar() As Boolean
        Dim unpParametro As New pParametro
        Return unpParametro.Guardar(Me.ToDatarow)
    End Function

    Public Function Modificar() As Boolean
        Dim unpParametro As New pParametro
        Try
            Return unpParametro.Modificar(Me.ToDataSet)
        Catch ex As Exception
            MsgBox("Error al cargar los datos extras", MsgBoxStyle.Critical)
        End Try
    End Function

#End Region

#Region "Métodos para llevar y traer datos del dataset"

    Sub FromDataRow(ByVal unaFila As DataRow)
        Dim miFila As parametrosRow = CType(unaFila, parametrosRow)
        Try
            If Not miFila Is Nothing Then
                Me.NombreParametro = miFila.NombreParametro
                Me.ValorParametro = miFila.ValorParametro
                Me.DescripcionParametro = miFila.DescripcionParametro

            End If
        Catch ex As Exception
        End Try
    End Sub

    Function ToDatarow() As DataRow
        'Dim tabla As New parametrosDataTable
        'Dim unaFila As parametrosRow = tabla.NewparametrosRow()
        'unaFila.NombreParametro = Me.NombreParametro
        'unaFila.ValorParametro = Me.ValorParametro
        'unaFila.DescripcionParametro = Me.DescripcionParametro
        'Return unaFila
    End Function


    Public Function ToDataSet() As DataSet
        'Dim ds As New Dac.DsParametro
        'Dim nuevoparametros As Dac.DsParametro.ParametrosRow
        'nuevoparametros = ds.parametros.NewparametrosRow
        'nuevoparametros.NombreParametro = Me.NombreParametro
        'nuevoparametros.ValorParametro = Me.ValorParametro
        'nuevoparametros.DescripcionParametro = Me.DescripcionParametro
        'ds.Parametros.Rows.Add(nuevoparametros)
        'Return ds
        'Copmentariio

    End Function

#End Region



    Public Overrides Function ToString() As String
        Return Me.NombreParametro & ":" & " " & Me.ValorParametro
    End Function



End Class




