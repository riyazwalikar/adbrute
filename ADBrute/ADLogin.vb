Public Class ADLogin

    Private Sub Loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loginbtn.Click
        If DomainName.Text.Length < 3 Or DomainName.Text.Split(".").Length < 2 Then
            MsgBox("Invalid Domain Name. Please try again.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Username.Text.Length < 1 Or Password.Text.Length < 1 Then
            MsgBox("Please Enter your Username and Password.", MsgBoxStyle.Critical, "Invalid")
            Exit Sub
        End If

        If Connect(DomainName.Text, Username.Text, Password.Text) Then
            dom = DomainName.Text
            dcuser = Username.Text
            dcpass = Password.Text
            LoginCount = 0
            ADBruteFrm.Show()
            Me.Close()
        End If
    End Sub

    Private Function Connect(ByVal dc As String, ByVal user As String, ByVal pass As String) As Boolean
        DE.Path = "LDAP://" + dc
        DE.Username = Username.Text
        DE.Password = Password.Text
        LoginCount = LoginCount + 1
        If LoginCount = 3 Then
            If MsgBox("This is your Third Attempt to connect to " & DomainName.Text & ". Your account may get locked if the maximum logon attempt has been reached. No furthur prompts will be issued. Do u want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "3rd Attempt") = MsgBoxResult.No Then
                Return False
            End If
        End If

        Try
            Dim tdc As DirectoryServices.DirectoryEntry = DE.Parent
        Catch Ex As Exception
            If InStr(Ex.Message.ToLower, BadLogon.ToLower, CompareMethod.Text) Then
                MsgBox(BadLogon, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Logon Error")
                Password.Text = ""
                Username.SelectAll()
                Err.Clear()
                Return False
            End If

            If InStr(Ex.Message.ToLower, BadDomain.ToLower, CompareMethod.Text) Then
                MsgBox(BadDomain, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Server Error")
                DomainName.SelectAll()
                Username.Text = ""
                Password.Text = ""
                Err.Clear()
                Return False
            End If
        End Try
        Return True
    End Function

    Private Sub ADLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "  [" & My.User.Name & "]"
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class