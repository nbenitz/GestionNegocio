Option Strict On
Option Explicit On

Module MAcceso
    Private UserIDValue As Integer = -1

    Public Property UserID() As Integer
        Get
            Return UserIDValue
        End Get
        Set(ByVal value As Integer)
            UserIDValue = value
        End Set
    End Property

End Module
