Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public MustInherit Class pPersistente

    Public Shared mCadenaConexion As String
    Public Shared mCadenaConexionSQLSERVER As String
    Public Shared mCadenaConexionMySQL As String

    Protected Shared Function ConectarSQLSERVER() As SqlConnection
        Try
            Return New SqlConnection(mCadenaConexionSQLSERVER)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Protected Shared Function ConectarMySql() As MySqlConnection
        Try
            Return New MySqlConnection(mCadenaConexionMySQL)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Protected Shared Function Conectar() As OleDbConnection
        Try
            Return New OleDbConnection(mCadenaConexion)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>Ejecuta una sentencia y retorna el valor de la primer fila, primer columna</summary>
    Public Shared Function EjecutarNonQuery(ByVal cadenaSQL As String) As Object

        Dim Opcion As Integer = 0
        If Not mCadenaConexionSQLSERVER Is Nothing Then
            'SQLSERVER
            Opcion = 1
        End If

        If Not mCadenaConexionMySQL Is Nothing Then
            'MySQL
            Opcion = 2
        End If

        If Not mCadenaConexion Is Nothing Then
            'Access
            Opcion = 3
        End If

        Select Case Opcion
            Case 1
                'SQLSERVER
                Dim conn As SqlConnection
                Dim comm As New SqlCommand(cadenaSQL)
                Try
                    conn = ConectarSQLSERVER()
                    comm.Connection = conn
                    comm.Connection.Open()
                    comm.ExecuteNonQuery()
                Catch ex As OleDbException
                    Throw New Exception("Error al acceder a la base de datos", ex)
                Finally
                    conn.Close()
                    conn.Dispose()
                    comm.Dispose()
                End Try

            Case 2
                'MySQL
                Dim conn As MySqlConnection
                Dim comm As New MySqlCommand(cadenaSQL)
                Try
                    conn = ConectarMySql()
                    comm.Connection = conn
                    comm.Connection.Open()
                    comm.ExecuteNonQuery()
                Catch ex As OleDbException
                    Throw New Exception("Error al acceder a la base de datos", ex)
                Finally
                    conn.Close()
                    conn.Dispose()
                    comm.Dispose()
                End Try
            Case 3
                'Access
                Dim conn As OleDbConnection
                Dim comm As New OleDbCommand(cadenaSQL)
                Try
                    conn = Conectar()
                    comm.Connection = conn
                    comm.Connection.Open()
                    comm.ExecuteNonQuery()
                Catch ex As OleDbException
                    Throw New Exception("Error al acceder a la base de datos", ex)
                Finally
                    conn.Close()
                    conn.Dispose()
                    comm.Dispose()
                End Try
        End Select


    End Function


    Public Shared Function EjecutarSQL(ByVal cadenaSQL As String) As DataSet
        Dim Opcion As Integer = 0
        If Not mCadenaConexionSQLSERVER Is Nothing Then
            'SQLSERVER
            Opcion = 1
        End If

        If Not mCadenaConexionMySQL Is Nothing Then
            'MySQL
            Opcion = 2
        End If

        If Not mCadenaConexion Is Nothing Then
            'Access
            Opcion = 3
        End If

        Select Case Opcion
            Case 1

                ''SQL SERVER
                Dim unaC As SqlConnection
                Try
                    unaC = pPersistente.ConectarSQLSERVER
                    If unaC IsNot Nothing Then
                        Dim unDs As New DataSet
                        Dim unDataAdapter As SqlDataAdapter
                        unDataAdapter = _
                        New SqlDataAdapter _
                                         (cadenaSQL, unaC)
                        unDataAdapter.Fill(unDs)
                        unDataAdapter.Dispose()
                        unaC.Close()
                        unaC.Dispose()
                        Return unDs
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Return Nothing
                End Try
            Case 2

                'MySQL
                Dim unaC As MySqlConnection
                Try
                    unaC = pPersistente.ConectarMySql
                    If unaC IsNot Nothing Then
                        Dim unDs As New DataSet
                        Dim unDataAdapter As MySqlDataAdapter
                        unDataAdapter = _
                        New MySqlDataAdapter _
                                         (cadenaSQL, unaC)
                        unDataAdapter.Fill(unDs)
                        unDataAdapter.Dispose()
                        unaC.Close()
                        unaC.Dispose()
                        Return unDs
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Return Nothing
                End Try

            Case 3

                'ACCESS
                Dim unaC As OleDbConnection
                Try
                    unaC = pPersistente.Conectar
                    If unaC IsNot Nothing Then
                        Dim unDs As New DataSet
                        Dim unDataAdapter As OleDbDataAdapter
                        unDataAdapter = _
                        New OleDbDataAdapter _
                                         (cadenaSQL, unaC)
                        unDataAdapter.Fill(unDs)
                        unDataAdapter.Dispose()
                        unaC.Close()
                        unaC.Dispose()
                        Return unDs
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Return Nothing
                End Try

        End Select

      
    End Function


    Public Shared Function EjecutarSQLVariasTablas(ByVal pUnaListaCadenas As List(Of String), ByRef pDataSet As DataSet, ByVal pListaNombreTablas As List(Of String)) As DataSet
        Dim Opcion As Integer = 0
        If Not mCadenaConexionSQLSERVER Is Nothing Then
            'SQLSERVER
            Opcion = 1
        End If

        If Not mCadenaConexionMySQL Is Nothing Then
            'MySQL
            Opcion = 2
        End If

        If Not mCadenaConexion Is Nothing Then
            'Access
            Opcion = 3
        End If

        Select Case Opcion

            Case 1
                ''SQL SERVER
                Dim unaC As SqlConnection
                Try
                    unaC = pPersistente.ConectarSQLSERVER
                    If unaC IsNot Nothing Then
                        Dim unDataAdapter As SqlDataAdapter
                        If Not pUnaListaCadenas Is Nothing Then
                            If pUnaListaCadenas.Count > 0 Then
                                Dim i As Integer = 0
                                For i = 0 To pUnaListaCadenas.Count - 1
                                    Dim cadenaSQL As String = pUnaListaCadenas.Item(i)
                                    unDataAdapter = New SqlDataAdapter(cadenaSQL, unaC)
                                    Dim NombreTabla As String = pListaNombreTablas.Item(i)
                                    unDataAdapter.Fill(pDataSet, NombreTabla)
                                    unDataAdapter.Dispose()
                                Next
                                unaC.Close()
                                unaC.Dispose()
                                Return pDataSet
                            End If
                        End If
                    Else
                        Return Nothing
                    End If
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Return Nothing
                End Try

            Case 2
                'MYSQL
                Dim unaC As MySqlConnection
                Try
                    unaC = pPersistente.ConectarMySql
                    If unaC IsNot Nothing Then
                        Dim unDataAdapter As MySqlDataAdapter
                        If Not pUnaListaCadenas Is Nothing Then
                            If pUnaListaCadenas.Count > 0 Then
                                Dim i As Integer = 0
                                For i = 0 To pUnaListaCadenas.Count - 1
                                    Dim cadenaSQL As String = pUnaListaCadenas.Item(i)
                                    unDataAdapter = New MySqlDataAdapter(cadenaSQL, unaC)
                                    Dim NombreTabla As String = pListaNombreTablas.Item(i)
                                    unDataAdapter.Fill(pDataSet, NombreTabla)
                                    unDataAdapter.Dispose()
                                Next
                                unaC.Close()
                                unaC.Dispose()
                                Return pDataSet
                            End If
                        End If
                    End If

                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Return Nothing
                End Try

            Case 3
                'ACCESS
                Dim unaC As OleDbConnection
                Try
                    unaC = pPersistente.Conectar
                    If unaC IsNot Nothing Then
                        Dim unDataAdapter As OleDbDataAdapter
                        If Not pUnaListaCadenas Is Nothing Then
                            If pUnaListaCadenas.Count > 0 Then
                                Dim i As Integer = 0
                                For i = 0 To pUnaListaCadenas.Count - 1
                                    Dim cadenaSQL As String = pUnaListaCadenas.Item(i)
                                    unDataAdapter = New OleDbDataAdapter(cadenaSQL, unaC)
                                    Dim NombreTabla As String = pListaNombreTablas.Item(i)
                                    unDataAdapter.Fill(pDataSet, NombreTabla)
                                    unDataAdapter.Dispose()
                                Next
                                unaC.Close()
                                unaC.Dispose()
                                Return pDataSet
                            End If
                        End If
                    End If

                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                    Return Nothing
                End Try

        End Select
       
    End Function


#Region "Métodos abstractos"
    Public MustOverride Function Guardar( _
    ByVal objetoPersistente As DataRow) As Boolean
    Public MustOverride Function Modificar( _
   ByVal objeto As DataSet) As Boolean



#End Region

End Class

