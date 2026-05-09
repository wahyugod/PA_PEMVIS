Imports System.Drawing
Imports System.Windows.Forms

Public Class FormHistoriMember
    Private Sub FormHistoriMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvHistori.EnableHeadersVisualStyles = False
        dgvHistori.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 53, 73)
        dgvHistori.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Try
            Dim dt As DataTable = DataModule.GetHistoriMember(DataModule.LoggedInUserId)
            dgvHistori.DataSource = dt
            If dgvHistori.Columns.Contains("ID") Then
                dgvHistori.Columns("ID").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat histori transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim memberForm As New FormMember()
        memberForm.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New FormLogin()
        loginForm.Show()
        Me.Close()
    End Sub
End Class
