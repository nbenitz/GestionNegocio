Option Strict On
Option Explicit On

Imports System.Xml

Public Enum ConfigFileType
    WebConfig
    AppConfig
End Enum

Public Class CAppConfig
    Inherits System.Configuration.AppSettingsReader

    Public docName As String = String.Empty
    Private node As XmlNode = Nothing
    Private _configType As Integer

    Public Property ConfigType() As Integer
        Get
            Return _configType
        End Get
        Set(ByVal Value As Integer)
            _configType = Value
        End Set
    End Property

    Public Function SetValue(ByVal key As String, ByVal value As String) As Boolean
        Dim cfgdoc As New XmlDocument()
        Call loadConfigDoc(cfgdoc)

        node = cfgdoc.SelectSingleNode("//appSettings")
        If node Is Nothing Then
            Throw New InvalidOperationException("appSettings section not found")
        End If

        Try
            Dim addElem As XmlElement = CType(node.SelectSingleNode("//add[@key='" + key + "']"), XmlElement)

            If Not addElem Is Nothing Then
                addElem.SetAttribute("value", value)
            Else
                Dim enTry As XmlElement = cfgdoc.CreateElement("add")
                enTry.SetAttribute("key", key)
                enTry.SetAttribute("value", value)
                node.AppendChild(enTry)
            End If
            Call saveConfigDoc(cfgdoc, docName)
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function SetConnStrValue(ByVal name As String, ByVal connectionString As String) As Boolean
        Dim cfgdoc As New XmlDocument()
        Call loadConfigDoc(cfgdoc)

        node = cfgdoc.SelectSingleNode("//connectionStrings")
        If node Is Nothing Then
            Throw New InvalidOperationException("connectionStrings section not found")
        End If

        Try
            Dim addElem As XmlElement = CType(node.SelectSingleNode("//add[@name='" + name + "']"), XmlElement)

            If Not addElem Is Nothing Then
                addElem.SetAttribute("connectionString", connectionString)
            Else
                Dim enTry As XmlElement = cfgdoc.CreateElement("add")
                enTry.SetAttribute("name", name)
                enTry.SetAttribute("connectionString", connectionString)
                node.AppendChild(enTry)
            End If
            Call saveConfigDoc(cfgdoc, docName)
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub saveConfigDoc(ByVal cfgDoc As XmlDocument, ByVal cfgDocPath As String)
        Try
            Dim writer As XmlTextWriter = New XmlTextWriter(cfgDocPath, Nothing)
            writer.Formatting = Formatting.Indented
            cfgDoc.WriteTo(writer)
            writer.Flush()
            writer.Close()
            Return
        Catch
            Throw
        End Try
    End Sub

    Public Function removeElement(ByVal elementKey As String) As Boolean
        Try
            Dim cfgDoc As XmlDocument = New XmlDocument()
            loadConfigDoc(cfgDoc)
            ' recupero el nodo appSettings
            node = cfgDoc.SelectSingleNode("//appSettings")
            If node Is Nothing Then
                Throw New System.InvalidOperationException("appSettings section not found")
            End If
            ' XPath selecionamos el elemento "add" que contiene la clave a remover
            node.RemoveChild(node.SelectSingleNode("//add[@key='" + elementKey + "']"))

            saveConfigDoc(cfgDoc, docName)
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Function loadConfigDoc(ByVal cfgDoc As XmlDocument) As XmlDocument
        Dim Asm As System.Reflection.Assembly
        ' cargamos el archivo de configuración
        If Convert.ToInt32(ConfigType) = Convert.ToInt32(ConfigFileType.AppConfig) Then
            docName = ((Asm.GetEntryAssembly()).GetName()).Name
            docName += ".exe.config"
        Else
            'docName = Web.HttpContext.Current.Server.MapPath("web.config")
        End If
        cfgDoc.Load(docName)
        Return cfgDoc
    End Function
End Class
