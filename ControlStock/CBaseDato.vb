Imports MySql.Data.MySqlClient
Imports System.Data
Public Class CBaseDato

    Public con As MySqlConnection
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public ds As New DataSet
    Public cb As MySqlCommandBuilder
    Public odatarow As DataRow
    Public iposfilaactual As Integer
    Dim appCfg As New CAppConfig

    Public Sub Conectar()
        con = New MySqlConnection(appCfg.GetValue("server", Type.GetType("System.String")))
        con.Open()
    End Sub

    Public Sub Desconectar()
        con.Close()
    End Sub

    Public Sub CrearComando(ByVal consulta As String)
        cmd = New MySqlCommand(consulta, con)
    End Sub
    Public Sub CrearProcedimiento()
        cmd.CommandType = CommandType.StoredProcedure
    End Sub

    Public Sub AsignarParametro(ByVal param As String, ByVal tipo As MySqlDbType, ByVal valor As Object)
        cmd.Parameters.Add(param, tipo).Value = valor
    End Sub

    Public Sub AsignarParametro(ByVal param As String, ByVal valor As Object)
        cmd.Parameters.AddWithValue(param, valor)
    End Sub

    Public Sub AsignarParametroSalida(ByVal param As String, ByVal tipo As MySqlDbType)
        cmd.Parameters.Add(param, tipo)
        cmd.Parameters(param).Direction = ParameterDirection.Output
    End Sub

    Public Function ParametroSalida(ByVal param As String) As Object
        Dim Salida As Object
        Salida = cmd.Parameters(param).Value
        Return Salida
    End Function

    Public Function EjecutarConsulta() As Integer
        Dim numReg As Integer
        numReg = cmd.ExecuteNonQuery()
        Return numReg
    End Function

    Public Function EjecutarReader() As MySqlDataReader
        Return cmd.ExecuteReader()
    End Function

    Public Function EjecutarDataTable() As DataTable
        dt = New DataTable
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
