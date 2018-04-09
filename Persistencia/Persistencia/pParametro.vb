Imports Dac.DsParametro
Imports System.Data.OleDb, DAC
Public Class pParametro : Inherits Persistencia.pPersistente


    Public Overrides Function Guardar(ByVal datospersistente As DataRow) As Boolean
        '' Verificar el tipo de objeto
        'Try
        '    Dim filaDatos As ParametrosRow = CType(datospersistente, ParametrosRow)
        '    'Instanciar una conexión
        '    Dim unaConexion As OleDbConnection
        '    unaConexion = New OleDbConnection _
        '              (pParametro.mCadenaConexion)
        '    ' Crear un data adapter
        '    Dim unDataAdapter As OleDbDataAdapter = _
        '       New OleDbDataAdapter("Select * from Parametros", _
        '          unaConexion)
        '    ' Crear un command builder para ese data adapter
        '    Dim unComando As New _
        '    OleDb.OleDbCommandBuilder(unDataAdapter)
        '    ' Pedirle que llene un dataset (incluye nombre tabla)
        '    Dim unDataset As New DsParametro
        '    unDataAdapter.Fill(unDataset, "Parametros")
        '    ' Crear una nueva fila con la estructura de la tabla
        '    Dim unaTabla As DsParametro.ParametrosDataTable = unDataset.Parametros
        '    Dim nuevaFila As ParametrosRow = unaTabla.NewParametrosRow()
        '    nuevaFila.NombreParametro = filaDatos.NombreParametro
        '    nuevaFila.ValorParametro = filaDatos.ValorParametro
        '    nuevaFila.DescripcionParametro = filaDatos.DescripcionParametro
        '    unaTabla.AddParametrosRow(nuevaFila)

        '    ' Que el data adapter actualice la BD con los cambios
        '    unDataAdapter.Update(unDataset, "Parametros")
        '    ' Cerrar todo
        '    unDataAdapter.Dispose()
        '    unaConexion.Close()
        '    unaConexion.Dispose()
        '    Return True
        'Catch ex As Exception
        '    Debug.WriteLine(ex.Message)
        '    Return False
        'End Try
    End Function

    Public Overrides Function Modificar(ByVal objeto As DataSet) As Boolean
        'Dim dsparametros As DsParametro
        'Dim filaDeParametro As DsParametro.ParametrosRow
        'dsparametros = CType(objeto, DsParametro)
        'filaDeParametro = CType(dsparametros.Parametros.Rows(0), DsParametro.ParametrosRow)
        'Dim cadenaActualizacion As String
        'cadenaActualizacion = "UPDATE Parametros SET ValorParametro= '" & filaDeParametro.ValorParametro.ToString() & "' , DescripcionParametro =" & "'" & filaDeParametro.DescripcionParametro.ToString() & "'" & " where NombreParametro =" & "'" & filaDeParametro.NombreParametro & "'"
        'Try
        '    pPersistente.EjecutarNonQuery(cadenaActualizacion)
        '    Return True
        'Catch ex As SqlClient.SqlException
        '    Throw New Exception("Error al acceder a la BD para modificar el parametros.")
        'Catch ex As Exception
        '    Throw New Exception("Error Inesperado al modificar el cliente")
        'End Try
        'Return False
    End Function

    Public Sub EliminarTabla(ByVal ptabla As String)
        Dim conn As OleDbConnection
        Dim comm As New OleDbCommand("DROP TABLE " & ptabla)
        Try
            conn = Conectar()
            comm.Connection = conn
            comm.Connection.Open()
            comm.ExecuteNonQuery()
        Catch ex As OleDbException
            'Throw New Exception("Error al acceder a la base de datos", ex)
        Finally
            conn.Close()
            conn.Dispose()
            comm.Dispose()
        End Try
    End Sub

End Class



