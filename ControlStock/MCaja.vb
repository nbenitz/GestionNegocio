Option Strict On
Option Explicit On

Module MCaja
    Private EmpleadoCIValue As String = ""

    Public Property EmpleadoCI() As String
        Get
            Return EmpleadoCIValue
        End Get
        Set(ByVal value As String)
            EmpleadoCIValue = value
        End Set
    End Property
End Module
