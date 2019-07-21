<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Bloom1 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom2 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom3 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom4 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom5 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom6 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom7 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom8 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom9 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom10 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom11 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom12 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom13 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom14 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom15 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom16 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom17 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim Bloom18 As HWID_Lock.Bloom = New HWID_Lock.Bloom()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSignature = New System.Windows.Forms.Label()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.lblNetwork = New System.Windows.Forms.Label()
        Me.txtHWID = New System.Windows.Forms.TextBox()
        Me.BlueTheme1 = New HWID_Lock.BlueTheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BlueLabel3 = New HWID_Lock.BlueLabel()
        Me.BlueLabel2 = New HWID_Lock.BlueLabel()
        Me.BlueButtonC3 = New HWID_Lock.BlueButtonC()
        Me.BlueButtonC2 = New HWID_Lock.BlueButtonC()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BlueButtonC1 = New HWID_Lock.BlueButtonC()
        Me.BlueLabel1 = New HWID_Lock.BlueLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BlueTheme1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(156, 55)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "HWID"
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.Location = New System.Drawing.Point(174, 20)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(98, 29)
        Me.lblSignature.TabIndex = 1
        Me.lblSignature.Text = "System"
        '
        'btnUnlock
        '
        Me.btnUnlock.Location = New System.Drawing.Point(69, 88)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(119, 64)
        Me.btnUnlock.TabIndex = 2
        Me.btnUnlock.Text = "Unlock"
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'lblNetwork
        '
        Me.lblNetwork.AutoSize = True
        Me.lblNetwork.Location = New System.Drawing.Point(12, 195)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(0, 13)
        Me.lblNetwork.TabIndex = 3
        '
        'txtHWID
        '
        Me.txtHWID.Location = New System.Drawing.Point(12, 158)
        Me.txtHWID.Name = "txtHWID"
        Me.txtHWID.ReadOnly = True
        Me.txtHWID.Size = New System.Drawing.Size(229, 20)
        Me.txtHWID.TabIndex = 4
        '
        'BlueTheme1
        '
        Me.BlueTheme1.BackColor = System.Drawing.Color.Black
        Me.BlueTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Bloom1.Name = "BackColor"
        Bloom1.Value = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Bloom2.Name = "HeaderColor"
        Bloom2.Value = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(180, Byte), Integer))
        Bloom3.Name = "UpperColor"
        Bloom3.Value = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Bloom4.Name = "SideColor"
        Bloom4.Value = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Bloom5.Name = "DownColor"
        Bloom5.Value = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Bloom6.Name = "DownColor2"
        Bloom6.Value = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BlueTheme1.Colors = New HWID_Lock.Bloom() {Bloom1, Bloom2, Bloom3, Bloom4, Bloom5, Bloom6}
        Me.BlueTheme1.Controls.Add(Me.Panel1)
        Me.BlueTheme1.Controls.Add(Me.BlueButtonC3)
        Me.BlueTheme1.Controls.Add(Me.BlueButtonC2)
        Me.BlueTheme1.Controls.Add(Me.TextBox1)
        Me.BlueTheme1.Controls.Add(Me.BlueButtonC1)
        Me.BlueTheme1.Controls.Add(Me.BlueLabel1)
        Me.BlueTheme1.Customization = "/////7SEbf+YWTv/VVVV//Ly8v/MzMz/"
        Me.BlueTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlueTheme1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BlueTheme1.Image = Nothing
        Me.BlueTheme1.Location = New System.Drawing.Point(0, 0)
        Me.BlueTheme1.Movable = True
        Me.BlueTheme1.Name = "BlueTheme1"
        Me.BlueTheme1.NoRounding = False
        Me.BlueTheme1.Sizable = False
        Me.BlueTheme1.Size = New System.Drawing.Size(317, 249)
        Me.BlueTheme1.TabIndex = 5
        Me.BlueTheme1.Text = "xaynware Loader"
        Me.BlueTheme1.TransparencyKey = System.Drawing.Color.Empty
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BlueLabel3)
        Me.Panel1.Controls.Add(Me.BlueLabel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 17)
        Me.Panel1.TabIndex = 5
        '
        'BlueLabel3
        '
        Me.BlueLabel3.AutoSize = True
        Me.BlueLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BlueLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BlueLabel3.ForeColor = System.Drawing.Color.White
        Me.BlueLabel3.Location = New System.Drawing.Point(212, 0)
        Me.BlueLabel3.Name = "BlueLabel3"
        Me.BlueLabel3.Size = New System.Drawing.Size(105, 13)
        Me.BlueLabel3.TabIndex = 6
        Me.BlueLabel3.Text = "https://xaynware.cf"
        '
        'BlueLabel2
        '
        Me.BlueLabel2.AutoSize = True
        Me.BlueLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BlueLabel2.Font = New System.Drawing.Font("Tahoma", 8.2!)
        Me.BlueLabel2.ForeColor = System.Drawing.Color.White
        Me.BlueLabel2.Location = New System.Drawing.Point(-3, 0)
        Me.BlueLabel2.Name = "BlueLabel2"
        Me.BlueLabel2.Size = New System.Drawing.Size(196, 13)
        Me.BlueLabel2.TabIndex = 0
        Me.BlueLabel2.Text = "© 2019 xaynware. All rights reserved. "
        '
        'BlueButtonC3
        '
        Bloom7.Name = "BackColor"
        Bloom7.Value = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(173, Byte), Integer))
        Bloom8.Name = "BackColor2"
        Bloom8.Value = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(183, Byte), Integer))
        Bloom9.Name = "BorderColor"
        Bloom9.Value = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(136, Byte), Integer))
        Bloom10.Name = "CornerColor"
        Bloom10.Value = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BlueButtonC3.Colors = New HWID_Lock.Bloom() {Bloom7, Bloom8, Bloom9, Bloom10}
        Me.BlueButtonC3.Customization = "rXpi/7eGbf+IQB3/tIRt/w=="
        Me.BlueButtonC3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BlueButtonC3.Image = Nothing
        Me.BlueButtonC3.Location = New System.Drawing.Point(278, 3)
        Me.BlueButtonC3.Name = "BlueButtonC3"
        Me.BlueButtonC3.NoRounding = False
        Me.BlueButtonC3.Size = New System.Drawing.Size(34, 21)
        Me.BlueButtonC3.TabIndex = 4
        Me.BlueButtonC3.Text = "X"
        Me.BlueButtonC3.Transparent = False
        '
        'BlueButtonC2
        '
        Bloom11.Name = "BackColor"
        Bloom11.Value = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(173, Byte), Integer))
        Bloom12.Name = "BackColor2"
        Bloom12.Value = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(183, Byte), Integer))
        Bloom13.Name = "BorderColor"
        Bloom13.Value = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(136, Byte), Integer))
        Bloom14.Name = "CornerColor"
        Bloom14.Value = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BlueButtonC2.Colors = New HWID_Lock.Bloom() {Bloom11, Bloom12, Bloom13, Bloom14}
        Me.BlueButtonC2.Customization = "rXpi/7eGbf+IQB3/tIRt/w=="
        Me.BlueButtonC2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BlueButtonC2.Image = Nothing
        Me.BlueButtonC2.Location = New System.Drawing.Point(112, 59)
        Me.BlueButtonC2.Name = "BlueButtonC2"
        Me.BlueButtonC2.NoRounding = False
        Me.BlueButtonC2.Size = New System.Drawing.Size(76, 23)
        Me.BlueButtonC2.TabIndex = 3
        Me.BlueButtonC2.Text = "Register"
        Me.BlueButtonC2.Transparent = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(51, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(221, 24)
        Me.TextBox1.TabIndex = 2
        '
        'BlueButtonC1
        '
        Bloom15.Name = "BackColor"
        Bloom15.Value = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(173, Byte), Integer))
        Bloom16.Name = "BackColor2"
        Bloom16.Value = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(183, Byte), Integer))
        Bloom17.Name = "BorderColor"
        Bloom17.Value = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(136, Byte), Integer))
        Bloom18.Name = "CornerColor"
        Bloom18.Value = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BlueButtonC1.Colors = New HWID_Lock.Bloom() {Bloom15, Bloom16, Bloom17, Bloom18}
        Me.BlueButtonC1.Customization = "rXpi/7eGbf+IQB3/tIRt/w=="
        Me.BlueButtonC1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BlueButtonC1.Image = Nothing
        Me.BlueButtonC1.Location = New System.Drawing.Point(112, 149)
        Me.BlueButtonC1.Name = "BlueButtonC1"
        Me.BlueButtonC1.NoRounding = False
        Me.BlueButtonC1.Size = New System.Drawing.Size(76, 29)
        Me.BlueButtonC1.TabIndex = 1
        Me.BlueButtonC1.Text = "Load"
        Me.BlueButtonC1.Transparent = False
        '
        'BlueLabel1
        '
        Me.BlueLabel1.AutoSize = True
        Me.BlueLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BlueLabel1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.BlueLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BlueLabel1.Location = New System.Drawing.Point(196, 9)
        Me.BlueLabel1.Name = "BlueLabel1"
        Me.BlueLabel1.Size = New System.Drawing.Size(62, 13)
        Me.BlueLabel1.TabIndex = 0
        Me.BlueLabel1.Text = "Unassigned"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 249)
        Me.Controls.Add(Me.BlueTheme1)
        Me.Controls.Add(Me.txtHWID)
        Me.Controls.Add(Me.lblNetwork)
        Me.Controls.Add(Me.btnUnlock)
        Me.Controls.Add(Me.lblSignature)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "HWID Lock"
        Me.BlueTheme1.ResumeLayout(False)
        Me.BlueTheme1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSignature As Label
    Friend WithEvents btnUnlock As Button
    Friend WithEvents lblNetwork As Label
    Friend WithEvents txtHWID As TextBox
    Friend WithEvents BlueTheme1 As BlueTheme
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BlueButtonC1 As BlueButtonC
    Friend WithEvents BlueLabel1 As BlueLabel
    Friend WithEvents BlueButtonC2 As BlueButtonC
    Friend WithEvents BlueButtonC3 As BlueButtonC
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BlueLabel3 As BlueLabel
    Friend WithEvents BlueLabel2 As BlueLabel
End Class
