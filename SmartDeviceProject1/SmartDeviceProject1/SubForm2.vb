Public Class SubForm2

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearControl()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        MaInForm.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        Dim csum As Double = Convert.ToDouble(MaInForm.txtQty.Text) + Convert.ToDouble(txtQty.Text)
        MainForm.txtQty.Text = csum.ToString
        MainForm.txtAddBig.Items.Add(txtDNr.Text + " x " + txtQty.Text)

        MaInForm.Match()
        MaInForm.BringToFront()

        Me.Hide()
        MaInForm.Show()
    End Sub

    Private Sub SubForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub ClearControl()
        txtName.Text = ""
        txtOrder.Text = ""
        txtPartNr.Text = ""
        txtDNr.Text = ""
        txtQty.Text = ""
    End Sub

    Private Sub txtName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtName.Text.Contains(";") Then
                GetSecondPartData()
            Else
                txtPartNr.Focus()
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
                txtPartNr.Focus()
            End If
        End If
    End Sub

    Private Sub txtPartNr_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPartNr.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtDNr.Focus()
        End If
    End Sub

    Private Sub txtDNr_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDNr.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtQty.Focus()
        End If
    End Sub

    Private Sub txtQty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtOrder.Focus()
        End If
    End Sub

    Private Sub txtOrder_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrder.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        End If
    End Sub
End Class