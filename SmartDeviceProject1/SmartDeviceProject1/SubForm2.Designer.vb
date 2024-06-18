<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SubForm2
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
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(148, 217)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(52, 23)
        Me.btnCancel.TabIndex = 50
        Me.btnCancel.Text = "Cancel"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(44, 217)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(52, 23)
        Me.btnClear.TabIndex = 49
        Me.btnClear.Text = "Clear"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(44, 184)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(156, 30)
        Me.btnAdd.TabIndex = 48
        Me.btnAdd.Text = "Add"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(66, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.Text = "Add Big Label"
        '
        'txtOrder
        '
        Me.txtOrder.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtOrder.Location = New System.Drawing.Point(98, 154)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(101, 20)
        Me.txtOrder.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label12.Location = New System.Drawing.Point(41, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 14)
        Me.Label12.Text = "OrderNr"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtQty.Location = New System.Drawing.Point(98, 133)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(101, 20)
        Me.txtQty.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label11.Location = New System.Drawing.Point(41, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 14)
        Me.Label11.Text = "Qtty"
        '
        'txtDNr
        '
        Me.txtDNr.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtDNr.Location = New System.Drawing.Point(98, 112)
        Me.txtDNr.Name = "txtDNr"
        Me.txtDNr.Size = New System.Drawing.Size(101, 20)
        Me.txtDNr.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label10.Location = New System.Drawing.Point(41, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 14)
        Me.Label10.Text = "D-Nr"
        '
        'txtPartNr
        '
        Me.txtPartNr.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtPartNr.Location = New System.Drawing.Point(98, 91)
        Me.txtPartNr.Name = "txtPartNr"
        Me.txtPartNr.Size = New System.Drawing.Size(101, 20)
        Me.txtPartNr.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label9.Location = New System.Drawing.Point(41, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 14)
        Me.Label9.Text = "PartNr"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtName.Location = New System.Drawing.Point(98, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(101, 20)
        Me.txtName.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.Location = New System.Drawing.Point(41, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 14)
        Me.Label8.Text = "C.Name"
        '
        'SubForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDNr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPartNr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label8)
        Me.Menu = Me.mainMenu1
        Me.Name = "SubForm2"
        Me.Text = "SubForm2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
End Class
