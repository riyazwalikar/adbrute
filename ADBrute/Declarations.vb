Imports System.DirectoryServices

Module Declarations

    Public DE As New DirectoryEntry()
    Public BadLogon As String = "Logon failure: unknown user name or bad password."
    Public BadDomain As String = "The server is not operational."
    Public LoginCount As Integer
    Public dom As String
    Public dcuser As String
    Public dcpass As String
    Public listuser As String
End Module
