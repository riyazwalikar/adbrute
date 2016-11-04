Imports System.DirectoryServices

Public Class ADBruteFrm
    Dim BadLogon As String = "Logon failure: unknown user name or bad password."
    Dim BadDomain As String = "The server is not operational."
    Dim k As Integer, z As Integer
    Dim textbuffer As String = ""
    Dim DSSearch As New DirectorySearcher()
    Dim sortColumn As Integer = -1
    Dim scaninprog As Integer
    Dim j As Integer

    Private Sub EnumBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnumBtn.Click
        If Password.Text.Length = 0 Then
            If MsgBox(" No Password was specified. Do you want to continue scanning with a blank password for all " & SysList.Items.Count & " user(s)?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Important!!") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        If EnumBtn.Text = "&Start" Then
            If MsgBox("This will cause the program to test all the " & SysList.Items.Count & " user(s) to be tested for the default password entered. Running this scan multiple times may cause a mass account lockout if the maximum logon attempt has been reached for the respective accounts. Are you sure you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Important!!") = MsgBoxResult.No Then
                MsgBox("Scan Aborted by user!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aborted!!")
                Exit Sub
            End If

            Dim lines As Integer = SysList.Items.Count   'IO.File.ReadAllLines(OpenFileDlg.FileName).Length
            If lines < 1 Then Exit Sub
            LoginCount = LoginCount + 1
            If LoginCount = 3 Then
                If MsgBox("This is your third scan with the userlist. Running the scan again may cause multiple accounts to get locked if the maximum logon attempt has been reached for the respective accounts. No furthur prompts will be issued. Do you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Important!! - 3rd Attempt") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            EnumBtn.Text = "&Stop"
            StartToolStripMenuItem.Name = "&Stop"
            ExSyslist.Items.Clear()
            ViewAllBtn.Visible = False
            SysList.Visible = False
            Application.DoEvents()
            ExSyslist.Visible = True
            TotUsercountlbl.Text = ""

            Application.DoEvents()
            Application.DoEvents()
            Threading.Thread.Sleep(50)
            Application.DoEvents()
            Application.DoEvents()

            scaninprog = 1
            
            z = lines
            k = 0
            j = 0
            textbuffer = ""

            ExportBtn.Enabled = False
            'ExSysList.Enabled = False
            DE.Close()
            DE.Path = "LDAP://" + DomainName.Text
            Domainlbl.Text = DomainName.Text

            'ExSysList.Enabled = True
            While j < lines
                UpdateUser(j)
                If TotUsercountlbl.Text = "Finished!" = False Then
                    TotUsercountlbl.Text = "Testing user " & j.ToString & " of " & SysList.Items.Count
                End If
                Application.DoEvents()
                ADBrute()
                j = j + 1
            End While

            EnumBtn.Text = "&Start"
            StartToolStripMenuItem.Name = "&Start"
            j = SysList.Items.Count + 1
            ExportBtn.Enabled = True
            ExSysList.Enabled = True
            'ExSysList.Visible = True
            SysList.Visible = False
            ViewAllBtn.Visible = True
        Else
            scaninprog = 0
            EnumBtn.Text = "&Start"
            StartToolStripMenuItem.Name = "&Start"
            j = SysList.Items.Count
            ExportBtn.Enabled = True
            ExSysList.Enabled = True
            SysList.Visible = False
            ViewAllBtn.Visible = True
            Username.Text = "<username>"
            TotUsercountlbl.Text = "Finished!"
            Application.DoEvents()

        End If
    End Sub

    Private Sub UpdateUser(ByVal i As Integer)
        Username.Text = SysList.Items(i).SubItems(1).Text
        Application.DoEvents()
    End Sub

    Private Function ADBrute()
        DE.Username = Username.Text
        DE.Password = Password.Text
        Application.DoEvents()
        Threading.Thread.Sleep(100) 'to diffuse connectivity issues...

        Try
            Dim tdc As DirectoryServices.DirectoryEntry = DE.Parent 'will throw an error if username or password is wrong...
            ExSysList.Items.Insert(0, Username.Text)
            Application.DoEvents()
            ExSysList.Items(0).SubItems.Add(Password.Text)
            Application.DoEvents()
            k = k + 1
            Countlbl.Text = k.ToString & " of " & z.ToString
            Application.DoEvents()
            tdc.Close()
        Catch ex As Exception
            If InStr(ex.Message.ToLower, BadDomain.ToLower, CompareMethod.Text) Then
                MsgBox(BadDomain, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Server Error")
                Username.Text = ""
                Password.Text = ""
                j = z + 2
            End If
            Err.Clear()
            EnumBtn.Enabled = True
        End Try
        Return 0
    End Function

    Private Sub DomainName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DomainName.Text.Length > 0 Then EnumBtn.Enabled = True Else EnumBtn.Enabled = False
    End Sub

    Private Sub ExportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportBtn.Click
        With SaveDlg
            .CheckPathExists = True
            .AddExtension = True
            .ShowDialog()
        End With
    End Sub

    Private Sub SaveDlg_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveDlg.FileOk
        Application.DoEvents()
        Application.DoEvents()
        If ExSysList.Visible = True And SysList.Visible = False Then
            Dim info As String = "ADBrute v1.2" & vbCrLf & "Enumerated by: " & My.User.Name & vbCrLf & vbCrLf
            info = info & Countlbl.Text & " Users" & vbCrLf & "Default Password Tested: " & Password.Text & vbCrLf
            Dim p As Integer
            textbuffer = ""
            For p = 0 To ExSysList.Items.Count - 1
                textbuffer = textbuffer & ExSysList.Items(p).Text & vbCrLf
            Next
            Application.DoEvents()
            textbuffer = info & vbCrLf & textbuffer
            Application.DoEvents()
            My.Computer.FileSystem.WriteAllText(SaveDlg.FileName, textbuffer, False)
            Application.DoEvents()
            MsgBox("File saved as " & SaveDlg.FileName & " at " & Now.ToString & ".", MsgBoxStyle.Exclamation, "Saved!!")

        ElseIf ExSysList.Visible = False And SysList.Visible = True Then
            Dim info As String = "ADBrute v1.2" & vbCrLf & "Enumerated by: " & My.User.Name & vbCrLf & vbCrLf
            info = info & Countlbl.Text & " Users" & vbCrLf & "(All Users)" & vbCrLf
            Dim p As Integer
            textbuffer = ""
            For p = 0 To SysList.Items.Count - 1
                textbuffer = textbuffer & SysList.Items(p).Text & "," & SysList.Items(p).SubItems(1).Text & vbCrLf
            Next
            Application.DoEvents()
            textbuffer = info & vbCrLf & textbuffer
            Application.DoEvents()
            My.Computer.FileSystem.WriteAllText(SaveDlg.FileName, textbuffer, False)
            Application.DoEvents()
            MsgBox("File saved as " & SaveDlg.FileName & " at " & Now.ToString & ".", MsgBoxStyle.Exclamation, "Saved!!")
        End If
    End Sub

    Private Sub LDAPEnum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "  [" & My.User.Name & "]"
        Timer.Enabled = True
        DomainName.Text = dom
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        EnumBtn.Enabled = False
        SysList.Enabled = False
        ExportBtn.Enabled = False
        Timer.Enabled = False
        scaninprog = 1

        Dim j As Long
        SysList.Items.Clear()
        DSSearch.SearchRoot = DE
        DSSearch.PageSize = 5000
        DSSearch.Filter = "(&(objectClass=user)(objectCategory=person))"
        DSSearch.PropertiesToLoad.Add("CN")
        DSSearch.PropertiesToLoad.Add("samaccountname")

        Domainlbl.Text = DomainName.Text
        ListViewItemComparer.stat = 0
        Try
            Dim srcol As SearchResultCollection = DSSearch.FindAll
            Dim z As Long = srcol.Count


            For Each sr As SearchResult In srcol
                Try
                    System.Threading.Thread.Sleep(10)
                    SysList.Items.Insert(0, sr.Properties("CN").Item(0).ToString)
                    SysList.Items(0).SubItems.Add(sr.Properties("samaccountname").Item(0).ToString)
                    Application.DoEvents()
                    j = j + 1
                    Countlbl.Text = j.ToString & " of " & z
                    Application.DoEvents()
                Catch
                    EnumBtn.Enabled = True
                    SysList.Enabled = True
                    Return
                End Try
            Next

        Catch ex As Exception
            EnumBtn.Enabled = True
            SysList.Enabled = True
            Timer.Enabled = False
            Return
        End Try
        EnumBtn.Enabled = True
        SysList.Enabled = True
        ExportBtn.Enabled = True
        Timer.Enabled = False
        scaninprog = 0
    End Sub

    Private Sub SysList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles SysList.ColumnClick
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            SysList.Sorting = SortOrder.Ascending
        Else
            If SysList.Sorting = SortOrder.Ascending Then
                SysList.Sorting = SortOrder.Descending
            Else
                SysList.Sorting = SortOrder.Ascending
            End If
        End If
        SysList.Sort()
        SysList.ListViewItemSorter = New ListViewItemComparer(e.Column, SysList.Sorting)
    End Sub

    Private Sub SysList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SysList.MouseDoubleClick
        Dim i As Long
        Dim ds As New DirectorySearcher()

        DE.Username = dcuser
        DE.Password = dcpass

        ds.SearchRoot = DE
        ds.Filter = "samaccountname=" & SysList.FocusedItem.SubItems(1).Text
        ds.PageSize = 10000

        Dim s As SearchResult = ds.FindOne()
        Dim arr(s.Properties.Count) As Object

        s.Properties.PropertyNames.CopyTo(arr, 0)
        PropertyWindow.Show()
        For i = 0 To arr.Length - 2
            Dim objval As Object
            PropertyWindow.AttribList.Items.Insert(0, (arr(i).ToString))
            objval = s.Properties(arr(i))
            PropertyWindow.AttribList.Items(0).SubItems.Add(objval.Item(0).ToString)
            objval = Nothing
        Next
        PropertyWindow.Countlbl.Text = PropertyWindow.AttribList.Items.Count
        s = Nothing
        ds = Nothing
        PropertyWindow.ObjNamelbl.Text = SysList.FocusedItem.SubItems(0).Text
        PropertyWindow.Text = "PropertyWindow for " & PropertyWindow.ObjNamelbl.Text
    End Sub

    Private Sub ViewAllBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllBtn.Click
        If ExSysList.Visible = True And SysList.Visible = False And ViewAllBtn.Text = "&View All Users" Then
            ExSysList.Visible = False
            SysList.Visible = True
            ViewAllBtn.Text = "&View Scan Result"
        ElseIf ExSysList.Visible = False And SysList.Visible = True And ViewAllBtn.Text = "&View Scan Result" Then
            ExSysList.Visible = True
            SysList.Visible = False
            ViewAllBtn.Text = "&View All Users"
        End If
    End Sub

    Private Sub ExSysList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            ExSysList.Sorting = SortOrder.Ascending
        Else
            If ExSysList.Sorting = SortOrder.Ascending Then
                ExSysList.Sorting = SortOrder.Descending
            Else
                ExSysList.Sorting = SortOrder.Ascending
            End If
        End If
        ExSysList.Sort()
        ExSysList.ListViewItemSorter = New ListViewItemComparer(e.Column, ExSysList.Sorting)
    End Sub

    Private Sub ExSysList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim i As Long
        PropertyWindow.Show()
        Dim ds As New DirectorySearcher()

        ds.SearchRoot = DE
        ds.Filter = "CN=" & ExSyslist.FocusedItem.Text

        Dim s As SearchResult = ds.FindOne
        Dim arr(s.Properties.Count) As Object
        s.Properties.PropertyNames.CopyTo(arr, 0)

        For i = 0 To arr.Length - 2
            Dim objval As Object
            PropertyWindow.AttribList.Items.Insert(0, (arr(i).ToString))
            objval = s.Properties(arr(i))
            PropertyWindow.AttribList.Items(0).SubItems.Add(objval.Item(0).ToString)
            objval = Nothing
        Next
        PropertyWindow.Countlbl.Text = PropertyWindow.AttribList.Items.Count
        s = Nothing
        ds = Nothing
        listuser = ExSyslist.FocusedItem.Text
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If scaninprog = 1 Then Exit Sub
        Me.Close()
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        If EnumBtn.Enabled = True Then
            EnumBtn_Click(sender, e)
        End If
    End Sub

    Private Sub ExportToFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToFileToolStripMenuItem.Click
        If ExportBtn.Enabled = True Then
            ExportBtn_Click(sender, e)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        If scaninprog = 1 Then
            j = SysList.Items.Count + 1
            End
        End If
        End

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub
End Class
