<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.txtQtty = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtParts = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtScanned = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkScan = New System.Windows.Forms.CheckBox
        Me.txtScanned1 = New System.Windows.Forms.TextBox
        Me.txtOrder = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDNr = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPartNr = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.txtAddSmall = New System.Windows.Forms.ListBox
        Me.btnSmall = New System.Windows.Forms.Button
        Me.txtAddBig = New System.Windows.Forms.ListBox
        Me.btnBig = New System.Windows.Forms.Button
        Me.btnFetchData = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtQtty
        '
        Me.txtQtty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQtty.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtQtty.Location = New System.Drawing.Point(42, 150)
        Me.txtQtty.Name = "txtQtty"
        Me.txtQtty.Size = New System.Drawing.Size(66, 18)
        Me.txtQtty.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(14, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 14)
        Me.Label7.Text = "Qtty"
        '
        'txtD
        '
        Me.txtD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtD.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtD.Location = New System.Drawing.Point(42, 132)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(66, 18)
        Me.txtD.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(13, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 14)
        Me.Label6.Text = "D-Nr"
        '
        'txtParts
        '
        Me.txtParts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtParts.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtParts.Location = New System.Drawing.Point(42, 114)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(66, 18)
        Me.txtParts.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(13, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 14)
        Me.Label5.Text = "PartNr"
        '
        'txtCt
        '
        Me.txtCt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCt.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtCt.Location = New System.Drawing.Point(42, 96)
        Me.txtCt.Name = "txtCt"
        Me.txtCt.Size = New System.Drawing.Size(66, 18)
        Me.txtCt.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(13, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 14)
        Me.Label4.Text = "Ct.Nr"
        '
        'txtScanned
        '
        Me.txtScanned.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScanned.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtScanned.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.txtScanned.ForeColor = System.Drawing.Color.White
        Me.txtScanned.Location = New System.Drawing.Point(63, 67)
        Me.txtScanned.Name = "txtScanned"
        Me.txtScanned.Size = New System.Drawing.Size(41, 21)
        Me.txtScanned.TabIndex = 18
        Me.txtScanned.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.Text = "Scanned"
        '
        'lblResult
        '
        Me.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblResult.ForeColor = System.Drawing.Color.Black
        Me.lblResult.Location = New System.Drawing.Point(42, 4)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(125, 11)
        Me.lblResult.Text = "SCAN  LABEL"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkScan)
        Me.Panel1.Controls.Add(Me.lblResult)
        Me.Panel1.Location = New System.Drawing.Point(17, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 20)
        '
        'chkScan
        '
        Me.chkScan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkScan.Checked = True
        Me.chkScan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScan.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chkScan.Location = New System.Drawing.Point(1, 3)
        Me.chkScan.Name = "chkScan"
        Me.chkScan.Size = New System.Drawing.Size(53, 15)
        Me.chkScan.TabIndex = 1
        Me.chkScan.Text = "Scan"
        '
        'txtScanned1
        '
        Me.txtScanned1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtScanned1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtScanned1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.txtScanned1.ForeColor = System.Drawing.Color.White
        Me.txtScanned1.Location = New System.Drawing.Point(182, 67)
        Me.txtScanned1.Name = "txtScanned1"
        Me.txtScanned1.Size = New System.Drawing.Size(41, 21)
        Me.txtScanned1.TabIndex = 43
        Me.txtScanned1.Text = "0"
        '
        'txtOrder
        '
        Me.txtOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOrder.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtOrder.Location = New System.Drawing.Point(163, 168)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(61, 18)
        Me.txtOrder.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label12.Location = New System.Drawing.Point(121, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 14)
        Me.Label12.Text = "OrderNr"
        '
        'txtQty
        '
        Me.txtQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQty.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtQty.Location = New System.Drawing.Point(163, 150)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(61, 18)
        Me.txtQty.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label11.Location = New System.Drawing.Point(121, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 14)
        Me.Label11.Text = "Qtty"
        '
        'txtDNr
        '
        Me.txtDNr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDNr.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtDNr.Location = New System.Drawing.Point(163, 132)
        Me.txtDNr.Name = "txtDNr"
        Me.txtDNr.Size = New System.Drawing.Size(61, 18)
        Me.txtDNr.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label10.Location = New System.Drawing.Point(121, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 14)
        Me.Label10.Text = "Cust-Nr"
        '
        'txtPartNr
        '
        Me.txtPartNr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPartNr.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtPartNr.Location = New System.Drawing.Point(163, 114)
        Me.txtPartNr.Name = "txtPartNr"
        Me.txtPartNr.Size = New System.Drawing.Size(61, 18)
        Me.txtPartNr.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label9.Location = New System.Drawing.Point(121, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 14)
        Me.Label9.Text = "PartNr"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtName.Location = New System.Drawing.Point(163, 96)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(61, 18)
        Me.txtName.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.Location = New System.Drawing.Point(121, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 14)
        Me.Label8.Text = "C.Name"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(136, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.Text = "Scanned"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnQuit.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular)
        Me.btnQuit.Location = New System.Drawing.Point(168, 279)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(48, 19)
        Me.btnQuit.TabIndex = 53
        Me.btnQuit.Text = "Quit"
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular)
        Me.btnReset.Location = New System.Drawing.Point(93, 279)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(48, 19)
        Me.btnReset.TabIndex = 52
        Me.btnReset.Text = "Reset"
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular)
        Me.btnNew.Location = New System.Drawing.Point(18, 279)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(48, 19)
        Me.btnNew.TabIndex = 51
        Me.btnNew.Text = "New"
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNext.Enabled = False
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular)
        Me.btnNext.Location = New System.Drawing.Point(13, 241)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(207, 21)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "NEXT"
        '
        'txtAddSmall
        '
        Me.txtAddSmall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddSmall.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtAddSmall.Location = New System.Drawing.Point(20, 193)
        Me.txtAddSmall.Name = "txtAddSmall"
        Me.txtAddSmall.Size = New System.Drawing.Size(68, 35)
        Me.txtAddSmall.TabIndex = 54
        '
        'btnSmall
        '
        Me.btnSmall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSmall.Location = New System.Drawing.Point(92, 192)
        Me.btnSmall.Name = "btnSmall"
        Me.btnSmall.Size = New System.Drawing.Size(15, 21)
        Me.btnSmall.TabIndex = 55
        Me.btnSmall.Text = "+"
        '
        'txtAddBig
        '
        Me.txtAddBig.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddBig.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtAddBig.Location = New System.Drawing.Point(131, 192)
        Me.txtAddBig.Name = "txtAddBig"
        Me.txtAddBig.Size = New System.Drawing.Size(68, 35)
        Me.txtAddBig.TabIndex = 54
        '
        'btnBig
        '
        Me.btnBig.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBig.Enabled = False
        Me.btnBig.Location = New System.Drawing.Point(205, 192)
        Me.btnBig.Name = "btnBig"
        Me.btnBig.Size = New System.Drawing.Size(16, 21)
        Me.btnBig.TabIndex = 55
        Me.btnBig.Text = "+"
        '
        'btnFetchData
        '
        Me.btnFetchData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFetchData.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Regular)
        Me.btnFetchData.Location = New System.Drawing.Point(13, 237)
        Me.btnFetchData.Name = "btnFetchData"
        Me.btnFetchData.Size = New System.Drawing.Size(207, 19)
        Me.btnFetchData.TabIndex = 9
        Me.btnFetchData.Text = "MATCH DATA FROM DB"
        Me.btnFetchData.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(240, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBig)
        Me.Controls.Add(Me.btnSmall)
        Me.Controls.Add(Me.txtAddBig)
        Me.Controls.Add(Me.txtAddSmall)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtScanned1)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDNr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPartNr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQtty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCt)
        Me.Controls.Add(Me.txtScanned)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFetchData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "MainForm"
        Me.Text = "QR MATCHER"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtQtty As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtScanned As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtScanned1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDNr As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPartNr As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents txtAddSmall As System.Windows.Forms.ListBox
    Friend WithEvents btnSmall As System.Windows.Forms.Button
    Friend WithEvents txtAddBig As System.Windows.Forms.ListBox
    Friend WithEvents btnBig As System.Windows.Forms.Button
    Friend WithEvents chkScan As System.Windows.Forms.CheckBox
    Friend WithEvents btnFetchData As System.Windows.Forms.Button

End Class
