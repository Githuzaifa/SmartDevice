<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SubForm1
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
        Me.txtQtty = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtParts = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtQtty
        '
        Me.txtQtty.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular)
        Me.txtQtty.Location = New System.Drawing.Point(90, 138)
        Me.txtQtty.Name = "txtQtty"
        Me.txtQtty.Size = New System.Drawing.Size(96, 20)
        Me.txtQtty.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(50, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 14)
        Me.Label7.Text = "Qtty"
        '
        'txtD
        '
        Me.txtD.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular)
        Me.txtD.Location = New System.Drawing.Point(90, 116)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(96, 20)
        Me.txtD.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(49, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 14)
        Me.Label6.Text = "D-Nr"
        '
        'txtParts
        '
        Me.txtParts.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular)
        Me.txtParts.Location = New System.Drawing.Point(90, 94)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(96, 20)
        Me.txtParts.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(49, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.Text = "PartNr"
        '
        'txtCt
        '
        Me.txtCt.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular)
        Me.txtCt.Location = New System.Drawing.Point(90, 72)
        Me.txtCt.Name = "txtCt"
        Me.txtCt.Size = New System.Drawing.Size(96, 20)
        Me.txtCt.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(49, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 14)
        Me.Label4.Text = "Ct.Nr"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(140, 210)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(52, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(52, 210)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(52, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(49, 170)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(143, 34)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(49, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.Text = "Add Small Label"
        '
        'SubForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.txtQtty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "SubForm1"
        Me.Text = "SubForm1"
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
