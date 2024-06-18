Public Class SubForm1

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearControl()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        MaInForm.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim csum As Double = Convert.ToDouble(MaInForm.txtQtty.Text) + Convert.ToDouble(txtQtty.Text)
        MaInForm.txtQtty.Text = csum.ToString
        MainForm.txtAddSmall.Items.Add(txtD.Text + " x " + txtQtty.Text)
        MaInForm.Match()
        MaInForm.BringToFront()

        Me.Hide()
        MaInForm.Show()
    End Sub

    Sub ClearControl()
        txtCt.Text = ""
        txtD.Text = ""
        txtParts.Text = ""
        txtQtty.Text = ""
    End Sub

    Private Sub SubForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCt.KeyUp

        If e.KeyCode = Keys.Enter Then
            If txtCt.Text.Contains(";") Then
                GetFirstPartData()
            Else
                txtParts.Focus()
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

                txtParts.Focus()
            End If
        End If
    End Sub

    Private Sub txtParts_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParts.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtD.Focus()
        End If
    End Sub

    Private Sub txtD_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtD.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtQtty.Focus()
        End If

    End Sub

    Private Sub txtQtty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtty.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        End If

    End Sub
End Class