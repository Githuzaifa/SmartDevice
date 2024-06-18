Imports System.IO
Imports System.Reflection
Imports System
Imports System.Drawing.Bitmap
Imports System.Text

Public Class MainForm
    Private loadedData As String()
    Dim filePath As String = ""
    Dim cScannedFirst As Double = 0
    Dim cScannedSecond As Double = 0
    Dim cFilepath As String = ""
    Private scanCount As Integer = 0
    Private currentlyFocusedControl As Control
    Private Sub IncrementScanCount()
        scanCount += 1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSmall.Click
        Me.Hide()

        Dim SubForm1 As New SubForm1()

        SubForm1.Show()
        'SubForm1.txtCt.Text = txtCt.Text
        'SubForm1.txtD.Text = txtD.Text
        'SubForm1.txtParts.Text = txtParts.Text
        'SubForm1.txtQtty.Text = txtQtty.Text

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBig.Click
        Me.Hide()

        Dim SubForm2 As New SubForm2()
        SubForm2.Show()

        'SubForm2.txtName.Text = txtName.Text
        'SubForm2.txtDNr.Text = txtDNr.Text
        'SubForm2.txtPartNr.Text = txtPartNr.Text
        'SubForm2.txtQty.Text = txtQty.Text
        'SubForm2.txtOrder.Text = txtOrder.Text

    End Sub

    Private Sub GenerateBeep(ByVal beepCount As Integer, ByVal frequency As Integer, ByVal duration As Integer)
        For i As Integer = 1 To beepCount
            '   Windows.Forms.I.Beep(frequency, duration)
            '  Thread.Sleep(duration + 100) ' Pause between beeps
        Next
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim result As New CheckNTRResult()
        result = CheckCTNR()
        If result._Found = True And result._Msg = "Yes" Then
            cScannedFirst = cScannedFirst + 1
            txtScanned.Text = cScannedFirst
            cScannedSecond = cScannedSecond + 1
            txtScanned1.Text = cScannedSecond
            Dim cSno As Decimal = 0
            Dim prefix As String = (cSno + 1).ToString().PadLeft(3, "0"c) ' Adjust the +1 and variable accordingly
           
            Dim header As String = "CURRENT DATE | CURRENT TIME | SCANNED|CT.Nr   |PartNr      |D-Nr        |QTTY  || SCANNED |C.Name    | Part Nr.     | Cust Nr.    | QTTY | OrderNr"
            Dim dataLine As String = Environment.NewLine + String.Format("{0} | {1} | {2} | {3} | {4} | {5} | {6} || {7} | {8} | {9} | {10} | {11} | {12} ", DateTime.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToString("hh:mm:ss"), prefix.ToString(), txtCt.Text, txtParts.Text, txtD.Text, txtQtty.Text, prefix.ToString(), txtName.Text, txtPartNr.Text, txtDNr.Text, txtQty.Text, txtOrder.Text)

            ' Check if the header is already present in the file
            Dim headerExists As Boolean = False

            If File.Exists(cFilepath) Then
                Using reader As New StreamReader(cFilepath)
                    Dim line As String
                    While Not reader.EndOfStream
                        line = reader.ReadLine()
                        If line = header Then
                            headerExists = True
                            Exit While
                        End If
                    End While
                End Using
            End If

            Using writer As New StreamWriter(cFilepath, True)
                If Not headerExists Then
                    writer.WriteLine(header)
                End If
                writer.WriteLine(dataLine)
            End Using


            ClearControls()
            txtPartNr.BackColor = Color.White
            txtParts.BackColor = Color.White
            txtQtty.BackColor = Color.White
            txtQty.BackColor = Color.White
            lblResult.Text = "SCAN  LABEL"

        ElseIf result._Found = True And result._Msg = "No" Then
            Exit Sub
        Else
            cScannedFirst = cScannedFirst + 1
            txtScanned.Text = cScannedFirst
            cScannedSecond = cScannedSecond + 1
            txtScanned1.Text = cScannedSecond
            Dim cSno As Decimal = 0
            Dim prefix As String = (cSno + 1).ToString().PadLeft(3, "0"c) ' Adjust the +1 and variable accordingly

            Dim header As String = "CURRENT DATE | CURRENT TIME | SCANNED|CT.Nr   |PartNr      |D-Nr        |QTTY  || SCANNED |C.Name    | Part Nr.     | Cust Nr.    | QTTY | OrderNr"
            Dim dataLine As String = Environment.NewLine + String.Format("{0} | {1} | {2} | {3} | {4} | {5} | {6} || {7} | {8} | {9} | {10} | {11} | {12} ", DateTime.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToString("hh:mm:ss"), prefix.ToString(), txtCt.Text, txtParts.Text, txtD.Text, txtQtty.Text, prefix.ToString(), txtName.Text, txtPartNr.Text, txtDNr.Text, txtQty.Text, txtOrder.Text)

            ' Check if the header is already present in the file
            Dim headerExists As Boolean = False

            If File.Exists(cFilepath) Then
                Using reader As New StreamReader(cFilepath)
                    Dim line As String
                    While Not reader.EndOfStream
                        line = reader.ReadLine()
                        If line = header Then
                            headerExists = True
                            Exit While
                        End If
                    End While
                End Using
            End If

            Using writer As New StreamWriter(cFilepath, True)
                If Not headerExists Then
                    writer.WriteLine(header)
                End If
                writer.WriteLine(dataLine)
            End Using


            ClearControls()
            txtPartNr.BackColor = Color.White
            txtParts.BackColor = Color.White
            txtQtty.BackColor = Color.White
            txtQty.BackColor = Color.White
            lblResult.Text = "SCAN  LABEL"

        End If

       
    End Sub

    Private Function CheckCTNR(Optional ByRef msg As Boolean = False) As CheckNTRResult
        Dim result As New CheckNTRResult()
        result._Found = False

        Using reader As New StreamReader(cFilepath)
            Dim line As String
            While Not reader.EndOfStream
                line = reader.ReadLine()
                Dim columns As String() = line.Split("|"c)
                If columns.Length >= 7 AndAlso columns(3).Trim() = txtCt.Text.Trim() Then
                    result._Found = True
                    Exit While ' Exit loop once data is found
                End If
            End While
        End Using

        If result._Found = True Then
            If MsgBox("CT Nr. Already Exists, Continue ?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                result._Msg = "Yes"
            Else
                result._Msg = "No"

            End If
        End If

        
        Return result
    End Function
    Structure CheckNTRResult
        Public _Found As Boolean
        Public _Msg As String
    End Structure
    
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearControls()
    End Sub

    Sub ClearControls()

        txtQty.Text = String.Empty
        txtQtty.Text = String.Empty
        txtParts.Text = String.Empty
        txtPartNr.Text = String.Empty
        txtOrder.Text = String.Empty
        txtName.Text = String.Empty
        txtDNr.Text = String.Empty
        txtD.Text = String.Empty
        txtCt.Text = String.Empty
        txtAddSmall.Items.Clear()
        txtAddBig.Items.Clear()
        If cScannedFirst = 0 Then
            cScannedFirst = 0
        End If
        txtQtty.BackColor = Color.White
        txtQtty.ForeColor = Color.Black
        txtQty.BackColor = Color.White
        txtQty.ForeColor = Color.Black
        txtParts.BackColor = Color.White
        txtParts.ForeColor = Color.Black
        txtPartNr.BackColor = Color.White
        txtPartNr.ForeColor = Color.Black
        lblResult.Text = "SCAN LABEL"
        lblResult.BackColor = Color.White
        lblResult.ForeColor = Color.Black

        txtCt.Focus()
        'Match()
    End Sub

    Private Sub Label1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResult.TextChanged
        If lblResult.Text = "NOT MATCH !" Then
            btnSmall.Enabled = True
            btnBig.Enabled = True
            btnNext.Enabled = False
        ElseIf lblResult.Text = "MATCH" Then
            btnSmall.Enabled = False
            btnBig.Enabled = False
            btnNext.Enabled = True

        End If
    End Sub

    Private Sub txtParts_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Public Sub GetSection1Data()

        If txtParts.Text <> "" Then

            Dim cFound As Boolean = False
            If Not File.Exists(cFilepath) Then
                MessageBox.Show("File not found in directory  " + filePath)
                Return
            End If

            Using reader As New StreamReader(cFilepath)
                Dim line As String
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    Dim columns As String() = line.Split("|"c)
                    If columns.Length >= 7 AndAlso columns(3).Trim() = txtCt.Text.Trim() Then
                        cFound = True
                        txtParts.Text = columns(4).Trim()
                        txtQtty.Text = columns(6).Trim()
                        txtD.Text = columns(5).Trim()
                        txtCt.Text = columns(9).Trim()
                        Exit While ' Exit loop once data is found
                    End If
                End While
            End Using


            txtName.Focus()

            If cFound = False Then
                MsgBox("Data NOt Found Against # :  " + txtCt.Text)
                Exit Sub
            End If
        End If


    End Sub

    Private Sub txtPartNr_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call GetSection2Data()
    End Sub

    Sub Match()
        If txtParts.Text <> txtPartNr.Text Then
            txtParts.BackColor = Color.Maroon
            txtParts.ForeColor = Color.White
        Else
            txtParts.BackColor = Color.Green
            txtParts.ForeColor = Color.White
        End If
        If txtPartNr.Text <> txtParts.Text Then
            txtPartNr.BackColor = Color.Maroon
            txtPartNr.ForeColor = Color.White
        Else
            txtPartNr.BackColor = Color.Green
            txtPartNr.ForeColor = Color.White
        End If

        If txtQtty.Text <> "" Or txtQty.Text <> "" Then

            If Convert.ToDouble(txtQtty.Text) <> Convert.ToDouble(txtQty.Text) Then
                txtQtty.BackColor = Color.Maroon
                txtQtty.ForeColor = Color.White
            Else
                txtQtty.BackColor = Color.Green
                txtQtty.ForeColor = Color.White
            End If
        Else
            txtQtty.Text = 0
            txtQty.Text = 0
        End If

        If Convert.ToDouble(txtQty.Text) <> Convert.ToDouble(txtQtty.Text) Then
            txtQty.BackColor = Color.Maroon
            txtQty.ForeColor = Color.White
        Else
            txtQty.BackColor = Color.Green
            txtQty.ForeColor = Color.White
        End If


        If txtParts.Text = txtPartNr.Text And Convert.ToDouble(txtQtty.Text) = Convert.ToDouble(txtQty.Text) Then

            lblResult.Text = "MATCH"
            lblResult.BackColor = Color.Green
            lblResult.ForeColor = Color.White
            txtQtty.BackColor = Color.Green
            txtQtty.ForeColor = Color.White
            txtQty.BackColor = Color.Green
            txtQty.ForeColor = Color.White
            txtParts.BackColor = Color.Green
            txtParts.ForeColor = Color.White
            txtPartNr.BackColor = Color.Green
            txtPartNr.ForeColor = Color.White
            GenerateBeep(1, 500, 200) ' One short beep




        Else
            lblResult.Text = "NOT MATCH !"
            lblResult.BackColor = Color.Maroon
            lblResult.ForeColor = Color.White
            GenerateBeep(2, 500, 400) ' Two long beeps
        End If

    End Sub

    Public Sub GetSection2Data()
        If txtParts.Text = "" Then
            MsgBox("Select First Section Parts ")
            txtParts.Text = ""
            Exit Sub
        Else
            If txtPartNr.Text <> "" Then

                Dim assembly As Assembly = assembly.GetExecutingAssembly()
                Dim assemblyPath As String = assembly.GetName().CodeBase
                Dim binPath As String = System.IO.Path.GetDirectoryName(assemblyPath)



                Dim cFound2 As Boolean = False
                If Not File.Exists(cFilepath) Then
                    MessageBox.Show("File not found in directory  " + cFilepath)
                    Return
                End If

                Using reader As New StreamReader(cFilepath)
                    Dim line As String
                    While Not reader.EndOfStream
                        line = reader.ReadLine()
                        Dim columns2 As String() = line.Split("|"c)
                        If columns2.Length >= 7 AndAlso columns2(9).Trim() = txtName.Text.Trim() Then
                            cFound2 = True
                            txtName.Text = columns2(9).Trim()
                            txtDNr.Text = columns2(11).Trim()
                            txtPartNr.Text = columns2(10).Trim()
                            txtQty.Text = columns2(12).Trim()
                            txtOrder.Text = columns2(13).Trim()
                            Exit While ' Exit loop once data is found
                        End If
                    End While
                End Using

                ' Search for a line that contains the provided PartNr


                If cFound2 = False Then
                    MsgBox("Data NOt Found Against  Parts :  " + txtPartNr.Text)
                    txtName.Focus()
                    Exit Sub
                Else
                    Call Match()
                    txtCt.Focus()
                End If

            End If


        End If

    End Sub

    Sub GetFirstPartData()

        Dim result As String = txtCt.Text

        If result IsNot Nothing Then
            ' Split the decoded result into fields

            Dim fields As String() = txtCt.Text.Split(";"c)



            ' Populate the textboxes with extracted fields
            If fields.Length >= 4 Then
                txtCt.Text = fields(0)
                txtParts.Text = fields(1)
                txtD.Text = fields(2)
                txtQtty.Text = fields(3)


                txtName.Focus()
            End If
        End If
    End Sub


    Sub GetSecondPartData()
        Dim result As String = txtName.Text

        If result IsNot Nothing Then
            ' Split the decoded result into fields
            Dim fields As String() = txtName.Text.Split(";"c)

            ' Populate the textboxes with extracted fields
            If fields.Length >= 5 Then
                txtName.Text = fields(0)
                txtPartNr.Text = fields(1)
                txtDNr.Text = fields(2)
                txtQty.Text = fields(3)
                txtOrder.Text = fields(4)
                txtOrder.Focus()
            End If
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        scanCount = 0
        AddHandler Me.GotFocus, AddressOf Form_GotFocus

      
        txtCt.Focus()
        txtScanned.TextAlign = HorizontalAlignment.Center
        txtScanned1.TextAlign = HorizontalAlignment.Center

        Dim platform As PlatformID = System.Environment.OSVersion.Platform

        Dim appPath As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
        appPath = New Uri(appPath).LocalPath
        Dim debugFolderPath As String = Path.GetDirectoryName(appPath)
        Dim cPath As String = debugFolderPath.ToString() + "\Storage Card"

        ' Check if the folder already exists; if not, create it
        If Not Directory.Exists(cPath) Then
            Directory.CreateDirectory(cPath)
        End If
        cFilepath = cPath + "\data.txt"

        If Not File.Exists(cFilepath) Then

            Using File.Create(cFilepath)
            End Using

        End If

        If platform = PlatformID.Win32NT OrElse platform = PlatformID.Win32Windows Then
            cFilepath = cFilepath

            Console.WriteLine("Running on Windows")
        ElseIf platform = PlatformID.WinCE Then
            cFilepath = cFilepath

            '            cFilepath = "\Storage Card\data.txt"
            Console.WriteLine("Running on Pocket PC (Windows Mobile)")
        Else
            Console.WriteLine("Running on an unknown platform")
        End If
    End Sub
    Private Sub Form_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
        ' Update the currently focused control when the form receives focus
        currentlyFocusedControl = sender
    End Sub

    ' Function to get the currently focused control
    Private Function GetActiveControl() As Control
        Return currentlyFocusedControl
    End Function

    Private Sub txtName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = True Then
                GetSecondPartData()
                txtOrder.Focus()

            Else
                GetSecondPartData()
                txtPartNr.Focus()
            End If
        End If

         
    End Sub


    Private Sub txtCt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCt.KeyUp

        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = True Then
                GetFirstPartData()
                txtName.Focus()
            Else
                GetFirstPartData()
                txtParts.Focus()
            End If
        End If
    End Sub

    Private Sub MainForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
         

    End Sub

    Private Sub txtOrder_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrder.GotFocus
        If txtOrder.Text.Length > 0 Then
            Match()
            btnNext.Focus()
        End If
    End Sub
    
    Private Sub btnFetchData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFetchData.Click

        If lblResult.Text = "MATCH" Then
            GetSection1Data()
            GetSection2Data()
            Match()
        End If

    End Sub


    Private Sub txtParts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParts.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = False Then
                txtD.Focus()
            End If
        End If

    End Sub

    Private Sub txtD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = False Then
                txtQtty.Focus()
            End If
        End If
    End Sub

    Private Sub txtQtty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = False Then
                txtName.Focus()
            End If
        End If
    End Sub


    Private Sub txtPartNr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPartNr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = False Then
                txtDNr.Focus()
            End If
        End If
    End Sub

    Private Sub txtDNr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDNr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = False Then
                txtQty.Focus()
            End If
        End If
    End Sub
    Private Sub txtQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = False Then
                txtOrder.Focus()
            End If
        End If
    End Sub
    Private Sub txtOrder_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrder.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chkScan.Checked = False Then
                btnNext.Focus()
            End If
        End If
    End Sub 

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        
        ClearControls()
        txtScanned.Text = 0
        txtScanned1.Text = 0
    End Sub
End Class
