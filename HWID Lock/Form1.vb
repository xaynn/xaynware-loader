Imports System.Management
Imports System.IO
Imports System.Text
Imports System.Diagnostics
Imports AutoUpdate
Imports Ionic.Utils.Zip
Imports AutoUpdaterDotNET

Public Class Form1
    Dim directoryPath As String = My.Application.Info.DirectoryPath
    Dim tool As String = directoryPath + "\xaynware loader.exe"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForUpdates()
        If AlreadyRunning() Then
            Application.Exit()
        End If
        ' If My.Computer.FileSystem.FileExists("C:\Program Files\Wireshark\tshark.exe") Then
        'Application.Exit()
        ' End If

        '  If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\Wireshark\tshark.exe") Then
        ' Application.Exit()
        ' End If
        BlueLabel1.Visible = False
        Timer1.Interval = 3000
        Timer1.Enabled = True
        AntiTamper()
        Net.HttpWebRequest.DefaultWebProxy = New Net.WebProxy()
        Dim str As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 20
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(str.Substring(idx, 1))
        Next
        Me.Text = sb.ToString
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        CheckCheat()



        'Generate HWID

        Dim hw As New clsComputerInfo

        Dim hdd As String
        Dim cpu As String
        Dim mb As String
        Dim mac As String
        Dim hwid As String

        cpu = hw.GetProcessorId()
        hdd = hw.GetVolumeSerial("C")
        mb = hw.GetMotherBoardID()
        mac = hw.GetMACAddress()
        hwid = cpu + hdd + mb + mac

        Dim hwidEncrypted As String = Strings.UCase(hw.getMD5Hash(cpu & hdd & mb & mac))

        TextBox1.Text = hwidEncrypted

        'Check for internet
        Try
            My.Computer.Network.Ping("yoursite.com")
            BlueLabel1.ForeColor = Color.FromArgb(0, 100, 0)
            BlueLabel1.Text = "Server Online"
            BlueLabel1.Visible = Visible
        Catch
            BlueLabel1.ForeColor = Color.Red
            BlueLabel1.Text = "Server Offline"
            Application.Exit()
        End Try
    End Sub
    Private Sub CheckCheat()
        If My.Computer.FileSystem.FileExists("C:\Users\svnd.dll") Then
            On Error GoTo 1
            My.Computer.FileSystem.DeleteFile("C:\Users\svnd.dll")
1:          MsgBox("You cant run loader, if you injected the cheat (reopen csgo).") : Application.Exit()
        End If
    End Sub

    Public Sub CheckForUpdates()
        If My.Computer.FileSystem.FileExists("C:\Users\Public\Desktop\xaynware loader new.exe") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Public\Desktop\xaynware loader new.exe")
        End If
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://yourlink.com/hwid/vv.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
        Else
            Me.Opacity = 0
            MsgBox("There is a new update we will download it now for you.")
            My.Computer.Network.DownloadFile(
    "https://yourlink.com/hwid/update/xaynware loader.exe",
    "C:\Users\Public\Desktop\xaynware loader new.exe")
            MsgBox("New Version of the loader is in Desktop.")
        End If
    End Sub


    Private Function AlreadyRunning() As Boolean
        Dim aModuleName As String = Diagnostics.Process.GetCurrentProcess.MainModule.ModuleName

        Dim aProcName As String = System.IO.Path.GetFileNameWithoutExtension(aModuleName)

        If Process.GetProcessesByName(aProcName).Length > 1 Then
            Me.Opacity = 0
            Application.Exit()
        End If
    End Function



    Public Class clsComputerInfo

        Friend Function GetProcessorId() As String
            Dim strProcessorId As String = String.Empty
            Dim query As New SelectQuery("Win32_processor")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject

            For Each info In search.Get()
                strProcessorId = info("processorId").ToString()
            Next
            Return strProcessorId

        End Function

        Friend Function GetMACAddress() As String

            Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            Dim MACAddress As String = String.Empty
            For Each mo As ManagementObject In moc

                If (MACAddress.Equals(String.Empty)) Then
                    If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()

                    mo.Dispose()
                End If
                MACAddress = MACAddress.Replace(":", String.Empty)

            Next
            Return MACAddress
        End Function

        Friend Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String

            Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
            disk.Get()
            Return disk("VolumeSerialNumber").ToString()
        End Function

        Friend Function GetMotherBoardID() As String

            Dim strMotherBoardID As String = String.Empty
            Dim query As New SelectQuery("Win32_BaseBoard")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject
            For Each info In search.Get()

                strMotherBoardID = info("product").ToString()

            Next
            Return strMotherBoardID

        End Function


        Friend Function getMD5Hash(ByVal strToHash As String) As String
            Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

            bytesToHash = md5Obj.ComputeHash(bytesToHash)

            Dim strResult As String = ""

            For Each b As Byte In bytesToHash
                strResult += b.ToString("x2")
            Next

            Return strResult
        End Function

    End Class

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click


    End Sub
    Dim p() As Process
    Private Sub AntiTamper()
        Dim WC As New System.Net.WebClient
        Dim ip As String = WC.DownloadString("http://icanhazip.com/")
        p = Process.GetProcessesByName("dnSpy")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=dnSpy")
            Application.Exit()
        End If

        p = Process.GetProcessesByName("Fiddler")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=Fiddler")
            Application.Exit()
        End If


        p = Process.GetProcessesByName("Reflector")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=.NET Reflector")
            Application.Exit()
        End If

        p = Process.GetProcessesByName("ilSpy")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=ilSpy")
            Application.Exit()
        End If


        p = Process.GetProcessesByName("Wireshark")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=Wireshark")
            Application.Exit()
        End If

    End Sub







    Private Sub BlueButtonC1_Click(sender As Object, e As EventArgs) Handles BlueButtonC1.Click
        'Network login

        Dim WC As New System.Net.WebClient
        Dim ip As String = WC.DownloadString("http://icanhazip.com/")
        Try
            Dim http3 As String = WC.DownloadString("https://yourlink.com/hwid/auth.php?hwid=" + TextBox1.Text)
            If http3 = "success" Then
                WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=login&extra=success")
                MsgBox("Access Granted")
                MF.Show()
                Me.Hide()

            Else
                WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=login&extra=invalid")
                MsgBox("Access Denied")
            End If
        Catch ex As Exception
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=report&extra=" + ex.ToString())
            MsgBox("Access Denied")

        End Try
    End Sub

    Private Sub BlueTheme1_Click(sender As Object, e As EventArgs) Handles BlueTheme1.Click

    End Sub

    Private Sub BlueButtonC2_Click(sender As Object, e As EventArgs) Handles BlueButtonC2.Click
        MsgBox("This function in this moment is disabled, contact at discord to register. https://discord.gg/tesCnTv")
    End Sub

    Private Sub BlueButtonC3_Click(sender As Object, e As EventArgs) Handles BlueButtonC3.Click
        Application.Exit()
    End Sub

    Private Sub BlueLabel1_Click(sender As Object, e As EventArgs) Handles BlueLabel1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim WC As New System.Net.WebClient

        Dim ip As String = WC.DownloadString("http://icanhazip.com/")
        p = Process.GetProcessesByName("dnSpy")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=dnSpy")
            Application.Exit()

        End If
        p = Process.GetProcessesByName("Fiddler")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=Fiddler")
            Application.Exit()
        End If


        p = Process.GetProcessesByName("Reflector")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=.NET Reflector")
            Application.Exit()
        End If

        p = Process.GetProcessesByName("ilSpy")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=ilSpy")
            Application.Exit()
        End If


        p = Process.GetProcessesByName("Wireshark")
        If p.Count > 0 Then
            WC.DownloadString("https://yourlink.com/hwid/log.php?hwid=" + TextBox1.Text + "&ip=" + ip + "&action=debug&extra=Wireshark")
            Application.Exit()
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class