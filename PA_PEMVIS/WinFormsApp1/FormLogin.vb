Imports System.Drawing
Imports System.Windows

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ValidationModule.IsEmpty(txtUsername.Text, txtPassword.Text) Then
            MessageBox.Show("Username dan Password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DataModule.LoginUser(txtUsername.Text, txtPassword.Text) Then
            If DataModule.LoggedInRole = "admin" Then
                Dim dashboard As New FormProduk()
                dashboard.Show()
                Me.Hide()
            Else
                Dim memberForm As New FormMember()
                memberForm.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Kredensial tidak valid. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnGoToRegister_Click(sender As Object, e As EventArgs) Handles btnGoToRegister.Click
        Dim registerForm As New FormRegister()
        registerForm.Show()
        Me.Hide()
    End Sub

End Class