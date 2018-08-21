Option Strict On

Imports MySql.Data.MySqlClient
Public Class CUsuario

    Private ObjCon As New BaseDato()

    Public Function Insertar(ByVal Usu As String, ByVal Pass As String, ByVal Priv As Integer, ByVal Emple As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zusuario_ins")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@Usu", Usu)
            ObjCon.AsignarParametro("@Pass", Pass)
            ObjCon.AsignarParametro("@Priv", Priv)
            ObjCon.AsignarParametro("@Emple", Emple)
            If ObjCon.EjecutarConsulta() > 0 Then
                inserto = True
            Else
                inserto = False
            End If
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function Actualizar(ByVal IdUsu As Integer, ByVal Usu As String, ByVal Pass As String, ByVal IdPriv As Integer, ByVal IdEmple As Integer) As Boolean
        Dim actualizo As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zusuario_update")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@idUsu", IdUsu)
            ObjCon.AsignarParametro("@Usu", Usu)
            ObjCon.AsignarParametro("@Pas", Pass)
            ObjCon.AsignarParametro("@idPriv", IdPriv)
            ObjCon.AsignarParametro("@idEmple", IdEmple)
            If ObjCon.EjecutarConsulta() > 0 Then
                actualizo = True
            Else
                actualizo = False
            End If
            ObjCon.Desconectar()
        Catch
            actualizo = False
        End Try
        Return actualizo
    End Function

    Public Function Eliminar(ByVal IdUsu As Integer) As Boolean
        Dim elimino As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("DELETE FROM Usuario WHERE IdUsuario = ?id")
            ObjCon.AsignarParametro("?id", MySqlDbType.Int64, IdUsu)
            If ObjCon.EjecutarConsulta() > 0 Then
                elimino = True
            Else
                elimino = False
            End If
            ObjCon.Desconectar()
        Catch
            elimino = False
        End Try
        Return elimino
    End Function

    Public Function Buscar(ByVal Usu As String) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zusuario_buscarxusu")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@Usu", Usu)
        Buscar = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function Buscar(ByVal CI As Integer) As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zusuario_buscarxci")
        ObjCon.CrearProcedimiento()
        ObjCon.AsignarParametro("@CI", CI)
        Buscar = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

    Public Function Verificar(ByVal usu As String, ByVal pass As String) As Boolean
        Dim verifico As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("SELECT * FROM usuario WHERE Usuario = ?usu AND pass = ?pass")
            ObjCon.AsignarParametro("?usu", MySqlDbType.VarChar, usu)
            ObjCon.AsignarParametro("?pass", MySqlDbType.VarChar, pass)
            ObjCon.dr = ObjCon.EjecutarReader()
            If ObjCon.dr.Read() Then
                verifico = True
            Else
                verifico = False
            End If
            ObjCon.dr.Close()
            ObjCon.Desconectar()
        Catch
            verifico = False
        End Try
        Return verifico
    End Function

    Public Function ConsultaUsuario() As DataTable
        Dim datble As New DataTable()
        datble.Dispose()
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT Username, Password FROM Usuario")
        datble = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
        Return datble
    End Function

    Public Function IdUsuario(ByVal nom As String) As Integer
        Dim id As Integer
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("SELECT IdUsuario FROM Usuario WHERE Username = ?nom")
            ObjCon.AsignarParametro("?nom", MySqlDbType.VarChar, nom)
            ObjCon.dr = ObjCon.EjecutarReader()
            If ObjCon.dr.Read() Then
                id = ObjCon.dr.GetInt32(0)
            Else
                id = 0
            End If
            ObjCon.dr.Close()
            ObjCon.Desconectar()
        Catch
            id = 0
        End Try
        Return id
    End Function

    Public Function ConsultaPrivilegio(ByVal IdPriv As Integer) As DataTable
        Dim datble As New DataTable()
        datble.Dispose()
        ObjCon.Conectar()
        ObjCon.CrearComando("SELECT * FROM Privilegio " +
                            "WHERE idPrivilegio = ?idp")
        ObjCon.AsignarParametro("?idp", MySqlDbType.UInt64, IdPriv)
        datble = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
        Return datble
    End Function

    Public Function InsertPrivilegio(ByVal Rol As String,
                                    ByVal ProdConsult As Boolean,
                                    ByVal ProdReg As Boolean,
                                    ByVal ProdEdit As Boolean,
                                    ByVal ProdEliminar As Boolean,
                                    ByVal VentasConsult As Boolean,
                                    ByVal VentasReg As Boolean,
                                    ByVal ComprasConsult As Boolean,
                                    ByVal ComprasReg As Boolean,
                                    ByVal ProvConsult As Boolean,
                                    ByVal ProvReg As Boolean,
                                    ByVal ProvEdit As Boolean,
                                    ByVal ProvEliminar As Boolean,
                                    ByVal EmpleAdmin As Boolean,
                                    ByVal UsuAdmin As Boolean,
                                    ByVal FinanzasAdmin As Boolean,
                                    ByVal HabAdmin As Boolean,
                                    ByVal CuentasAdmin As Boolean,
                                    ByVal DevolAutoriCli As Boolean,
                                    ByVal DevolAutoriProv As Boolean) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zprivilegio_insert")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@Rol_", Rol)
            ObjCon.AsignarParametro("@ProdConsult_", ProdConsult)
            ObjCon.AsignarParametro("@ProdReg_", ProdReg)
            ObjCon.AsignarParametro("@ProdActualiz_", ProdEdit)
            ObjCon.AsignarParametro("@ProdEliminar_", ProdEliminar)
            ObjCon.AsignarParametro("@VentasConsult_", VentasConsult)
            ObjCon.AsignarParametro("@VentasReg_", VentasReg)
            ObjCon.AsignarParametro("@ComprasConsult_", ComprasConsult)
            ObjCon.AsignarParametro("@ComprasReg_", ComprasReg)
            ObjCon.AsignarParametro("@ProvConsult_", ProvConsult)
            ObjCon.AsignarParametro("@ProvReg_", ProvReg)
            ObjCon.AsignarParametro("@ProvActualiz_", ProvEdit)
            ObjCon.AsignarParametro("@ProvEliminar_", ProvEliminar)
            ObjCon.AsignarParametro("@EmpleAdmin_", EmpleAdmin)
            ObjCon.AsignarParametro("@UsuAdmin_", UsuAdmin)
            ObjCon.AsignarParametro("@FinanzasAdmin_", FinanzasAdmin)
            ObjCon.AsignarParametro("@HabAdmin_", HabAdmin)
            ObjCon.AsignarParametro("@CuentasAdmin_", CuentasAdmin)
            ObjCon.AsignarParametro("@DevolAutoriCli_", DevolAutoriCli)
            ObjCon.AsignarParametro("@DevolAutoriProv_", DevolAutoriProv)
            If ObjCon.EjecutarConsulta() > 0 Then
                inserto = True
            Else
                inserto = False
            End If
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function UpdatePrivilegio(ByVal Rol As String,
                                    ByVal ProdConsult As Boolean,
                                    ByVal ProdReg As Boolean,
                                    ByVal ProdEdit As Boolean,
                                    ByVal ProdEliminar As Boolean,
                                    ByVal VentasConsult As Boolean,
                                    ByVal VentasReg As Boolean,
                                    ByVal ComprasConsult As Boolean,
                                    ByVal ComprasReg As Boolean,
                                    ByVal ProvConsult As Boolean,
                                    ByVal ProvReg As Boolean,
                                    ByVal ProvEdit As Boolean,
                                    ByVal ProvEliminar As Boolean,
                                    ByVal EmpleAdmin As Boolean,
                                    ByVal UsuAdmin As Boolean,
                                    ByVal FinanzasAdmin As Boolean,
                                    ByVal HabAdmin As Boolean,
                                    ByVal CuentasAdmin As Boolean,
                                    ByVal DevolAutoriCli As Boolean,
                                    ByVal DevolAutoriProv As Boolean,
                                    ByVal IdPrivilegio As Integer) As Boolean
        Dim inserto As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zprivilegio_update")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@Rol_", Rol)
            ObjCon.AsignarParametro("@ProdConsult_", ProdConsult)
            ObjCon.AsignarParametro("@ProdReg_", ProdReg)
            ObjCon.AsignarParametro("@ProdActualiz_", ProdEdit)
            ObjCon.AsignarParametro("@ProdEliminar_", ProdEliminar)
            ObjCon.AsignarParametro("@VentasConsult_", VentasConsult)
            ObjCon.AsignarParametro("@VentasReg_", VentasReg)
            ObjCon.AsignarParametro("@ComprasConsult_", ComprasConsult)
            ObjCon.AsignarParametro("@ComprasReg_", ComprasReg)
            ObjCon.AsignarParametro("@ProvConsult_", ProvConsult)
            ObjCon.AsignarParametro("@ProvReg_", ProvReg)
            ObjCon.AsignarParametro("@ProvActualiz_", ProvEdit)
            ObjCon.AsignarParametro("@ProvEliminar_", ProvEliminar)
            ObjCon.AsignarParametro("@EmpleAdmin_", EmpleAdmin)
            ObjCon.AsignarParametro("@UsuAdmin_", UsuAdmin)
            ObjCon.AsignarParametro("@FinanzasAdmin_", FinanzasAdmin)
            ObjCon.AsignarParametro("@HabAdmin_", HabAdmin)
            ObjCon.AsignarParametro("@CuentasAdmin_", CuentasAdmin)
            ObjCon.AsignarParametro("@DevolAutoriCli_", DevolAutoriCli)
            ObjCon.AsignarParametro("@DevolAutoriProv_", DevolAutoriProv)
            ObjCon.AsignarParametro("@idPrivilegio_", IdPrivilegio)
            If ObjCon.EjecutarConsulta() > 0 Then
                inserto = True
            Else
                inserto = False
            End If
            ObjCon.Desconectar()
        Catch mierror As MySqlException
            inserto = False
        End Try
        Return inserto
    End Function

    Public Function EliminarPriv(ByVal IdPriv As Integer) As Boolean
        Dim elimino As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("zprivilegio_delete")
            ObjCon.CrearProcedimiento()
            ObjCon.AsignarParametro("@IdPriv", IdPriv)
            If ObjCon.EjecutarConsulta() > 0 Then
                elimino = True
            Else
                elimino = False
            End If
            ObjCon.Desconectar()
        Catch
            elimino = False
        End Try
        Return elimino
    End Function

    Public Function IdEmpleFK(ByVal usu As String) As Integer
        Dim id As Integer
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("SELECT IdEmpleadoFK FROM Usuario WHERE Usuario = ?usu")
            ObjCon.AsignarParametro("?usu", MySqlDbType.VarChar, usu)
            ObjCon.dr = ObjCon.EjecutarReader()
            If ObjCon.dr.Read() Then
                id = ObjCon.dr.GetInt32(0)
            Else
                id = 0
            End If
            ObjCon.dr.Close()
            ObjCon.Desconectar()
        Catch
            id = 0
        End Try
        Return id
    End Function

    Public Function VerificarCI(ByVal CI As Integer) As Boolean
        Dim verifico As Boolean = False
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("SELECT * FROM usuario WHERE idEmpleadoFK = ?ci")
            ObjCon.AsignarParametro("?ci", MySqlDbType.VarChar, CI)
            ObjCon.dr = ObjCon.EjecutarReader()
            If ObjCon.dr.Read() Then
                verifico = True
            Else
                verifico = False
            End If
            ObjCon.dr.Close()
            ObjCon.Desconectar()
        Catch
            verifico = False
        End Try
        Return verifico
    End Function

    Public Function IdPrivFK(ByVal usu As String) As Integer
        Dim id As Integer
        Try
            ObjCon.Conectar()
            ObjCon.CrearComando("SELECT IdPrivilegioFK FROM Usuario WHERE Usuario = ?usu")
            ObjCon.AsignarParametro("?usu", MySqlDbType.VarChar, usu)
            ObjCon.dr = ObjCon.EjecutarReader()
            If ObjCon.dr.Read() Then
                id = ObjCon.dr.GetInt32(0)
            Else
                id = 0
            End If
            ObjCon.dr.Close()
            ObjCon.Desconectar()
        Catch
            id = 0
        End Try
        Return id
    End Function

    Public Function ListarPrivilegio() As DataTable
        ObjCon.Conectar()
        ObjCon.CrearComando("zprivilegio_listar")
        ObjCon.CrearProcedimiento()
        ListarPrivilegio = ObjCon.EjecutarDataTable()
        ObjCon.Desconectar()
    End Function

End Class
