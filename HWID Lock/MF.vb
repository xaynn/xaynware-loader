Imports System.IO.Directory
Imports System.Management
Imports System.Text
Imports System.Threading

Public Class MF

    Private TargetProcessHandle As Integer
    Private pfnStartAddr As Integer
    Private pszLibFileRemote As String
    Private TargetBufferSize As Integer

    Public Const PROCESS_VM_READ = &H10
    Public Const TH32CS_SNAPPROCESS = &H2
    Public Const MEM_COMMIT = 4096
    Public Const PAGE_READWRITE = 4
    Public Const PROCESS_CREATE_THREAD = (&H2)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_VM_WRITE = (&H20)
    Dim DLLFileName As String
    Public Declare Function ReadProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (
    ByVal lpLibFileName As String) As Integer

    Public Declare Function VirtualAllocEx Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpAddress As Integer,
    ByVal dwSize As Integer,
    ByVal flAllocationType As Integer,
    ByVal flProtect As Integer) As Integer

    Public Declare Function WriteProcessMemory Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As String,
    ByVal nSize As Integer,
    ByRef lpNumberOfBytesWritten As Integer) As Integer

    Public Declare Function GetProcAddress Lib "kernel32" (
    ByVal hModule As Integer, ByVal lpProcName As String) As Integer

    Private Declare Function GetModuleHandle Lib "Kernel32" Alias "GetModuleHandleA" (
    ByVal lpModuleName As String) As Integer

    Public Declare Function CreateRemoteThread Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpThreadAttributes As Integer,
    ByVal dwStackSize As Integer,
    ByVal lpStartAddress As Integer,
    ByVal lpParameter As Integer,
    ByVal dwCreationFlags As Integer,
    ByRef lpThreadId As Integer) As Integer

    Public Declare Function OpenProcess Lib "kernel32" (
    ByVal dwDesiredAccess As Integer,
    ByVal bInheritHandle As Integer,
    ByVal dwProcessId As Integer) As Integer

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As Integer

    Private Declare Function CloseHandle Lib "kernel32" Alias "CloseHandleA" (
    ByVal hObject As Integer) As Integer

    Private Sub Inject()




        If My.Computer.FileSystem.FileExists("C:\Users\svnd.dll") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\svnd.dll")
        End If

        My.Computer.Network.DownloadFile(
    "https://yourlink.com/cheat/installlegit.dll",
    "C:\Users\svnd.dll")
        IO.File.SetAttributes("C:\Users\svnd.dll", IO.FileAttributes.Hidden)
        Dim name As String = "C:\Users\svnd.dll"
        On Error GoTo 1
        Timer1.Stop()
        Dim TargetProcess As Process() = Process.GetProcessesByName("csgo")
        TargetProcessHandle = OpenProcess(PROCESS_CREATE_THREAD Or PROCESS_VM_OPERATION Or PROCESS_VM_WRITE, False, TargetProcess(0).Id)
        pszLibFileRemote = name
        pfnStartAddr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
        TargetBufferSize = 1 + Len(pszLibFileRemote)
        Dim Rtn As Integer
        Dim LoadLibParamAdr As Integer
        LoadLibParamAdr = VirtualAllocEx(TargetProcessHandle, 0, TargetBufferSize, MEM_COMMIT, PAGE_READWRITE)
        Rtn = WriteProcessMemory(TargetProcessHandle, LoadLibParamAdr, pszLibFileRemote, TargetBufferSize, 0)
        CreateRemoteThread(TargetProcessHandle, 0, 0, pfnStartAddr, LoadLibParamAdr, 0, 0)
        MsgBox("Injected")
        Application.Exit()
        My.Computer.FileSystem.DeleteFile("C:\Users\svnd.dll")
        CloseHandle(TargetProcessHandle)



1:      Application.Exit()
        My.Computer.FileSystem.DeleteFile("C:\Users\svnd.dll")

    End Sub



    Public Function IsProcessRunning(name As String) As Boolean

        'here we're going to get a list of all running processes on

        'the computer

        For Each clsProcess As Process In Process.GetProcesses()

            If clsProcess.ProcessName.StartsWith(name) Then

                'process found so it's running so return true

                Return True

            End If

        Next

        'process not found, return false
        MsgBox("I dont found csgo.")
        Application.Exit()
        If My.Computer.FileSystem.FileExists("C:\Users\svnd.dll") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\svnd.dll")
        End If
        Return False

    End Function


    Private Sub MF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Generate HWID
        BlueLabel10.Text = SystemInformation.UserName
        Timer2.Interval = 1000
        Timer2.Start()
        TextBox1.Visible = False
        Timer1.Interval = 3000
        Timer1.Enabled = True
        AntiTamper()
        Net.HttpWebRequest.DefaultWebProxy = New Net.WebProxy() ' protection from fiddler
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

        Dim Wclient As New System.Net.WebClient


        'Info
        Try
            Dim result68 As String = Wclient.DownloadString("https://yourlink.com/hwid/view_changelog.php")
            RichTextBox1.Text = result68
        Catch
            Application.Exit()
        End Try



        'Build info
        Try
            Dim result69 As String = Wclient.DownloadString("http://yourlink.com/hwid/builddate.txt")
            'BlueLabel7.ForeColor = Color.Blue
            BlueLabel7.Text = result69
            BlueLabel7.Visible = True
        Catch
            Application.Exit()
        End Try




        'status cheat
        Dim result As String = Wclient.DownloadString("http://yourlink.com/hwid/status.txt")
        If result = "undetected" Then
            BlueLabel2.ForeColor = Color.FromArgb(0, 100, 0)
            BlueLabel2.Text = "Undetected"

        ElseIf result = "detected" Then
            BlueLabel2.ForeColor = Color.Red
            BlueLabel2.Text = "Detected"
        Else result = "outdated"
            BlueLabel2.ForeColor = Color.Orange
            BlueLabel2.Text = "Outdated"
        End If

        'version cheat
        Dim result1 As String = Wclient.DownloadString("http://yourlink.com/hwid/version.txt")
        'BlueLabel4.ForeColor = Color.Blue
        BlueLabel4.Text = result1

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



        'If My.Computer.FileSystem.FileExists("C:\Program Files\Wireshark\tshark.exe") Then
        ' Application.Exit()
        'End If

        'If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\Wireshark\tshark.exe") Then
        'Application.Exit()
        'End If






    End Sub
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

    Private Sub BlueTheme1_Click(sender As Object, e As EventArgs) Handles BlueTheme1.Click

    End Sub

    Private Sub BlueLabel2_Click(sender As Object, e As EventArgs) Handles BlueLabel2.Click

    End Sub

    Private Sub BlueButtonC1_Click(sender As Object, e As EventArgs) Handles BlueButtonC1.Click
        If BlueLabel2.Text = "Undetected" Then
            IsProcessRunning("csgo")
            Inject()
        ElseIf BlueLabel2.Text = "Detected" Then
            MsgBox("You cant inject detected cheat.")
        Else
            BlueLabel2.Text = "Outdated"
            MsgBox("You cant inject outdated cheat.")
        End If
    End Sub



    Private Sub BlueLabel4_Click(sender As Object, e As EventArgs) Handles BlueLabel4.Click

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

    Private Sub BlueLabel5_Click(sender As Object, e As EventArgs) Handles BlueLabel5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BlueLabel7_Click(sender As Object, e As EventArgs) Handles BlueLabel7.Click

    End Sub

    Private Sub BlueButtonC3_Click(sender As Object, e As EventArgs) Handles BlueButtonC3.Click
        Application.Exit()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        BlueLabel5.Text = "Date: " + DateTime.Now.ToString()
    End Sub

    Private Sub BlueLabel10_Click(sender As Object, e As EventArgs) Handles BlueLabel10.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class