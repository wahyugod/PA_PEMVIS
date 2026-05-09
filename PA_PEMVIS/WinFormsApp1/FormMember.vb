Imports System.Drawing
Imports System.Windows.Forms

Public Class FormMember
    Private selectedLaptopId As Integer?
    Private selectedHarga As Decimal = 0

    Private Sub FormMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLaptops.EnableHeadersVisualStyles = False
        dgvLaptops.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 53, 73)
        dgvLaptops.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Dim dt As DataTable = DataModule.GetAvailableLaptops()
        dgvLaptops.DataSource = dt
        If dgvLaptops.Columns.Contains("ID") Then
            dgvLaptops.Columns("ID").Visible = False
        End If
        ClearForm()
    End Sub

    Private Sub ClearForm()
        selectedLaptopId = Nothing
        selectedHarga = 0
        txtNama.Clear()
        txtMerk.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        numJumlah.Value = 1
    End Sub

    Private Sub dgvLaptops_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLaptops.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLaptops.Rows(e.RowIndex)
            Dim idValue As Integer
            If Integer.TryParse(row.Cells("ID").Value?.ToString(), idValue) Then
                selectedLaptopId = idValue
            Else
                selectedLaptopId = Nothing
            End If

            txtMerk.Text = row.Cells("Merk").Value?.ToString()
            txtNama.Text = row.Cells("Nama").Value?.ToString()
            txtHarga.Text = row.Cells("Harga").Value?.ToString()
            txtStok.Text = row.Cells("Stok").Value?.ToString()
            
            Decimal.TryParse(txtHarga.Text, selectedHarga)
            
            Dim stokAvailable As Integer = 0
            Integer.TryParse(txtStok.Text, stokAvailable)
            numJumlah.Maximum = Math.Max(1, stokAvailable)
        End If
    End Sub

    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        If Not selectedLaptopId.HasValue Then
            MessageBox.Show("Pilih laptop yang ingin dibeli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Integer = Convert.ToInt32(numJumlah.Value)
        Dim totalHarga As Decimal = selectedHarga * qty

        Dim confirmation As DialogResult = MessageBox.Show($"Total pembayaran: Rp {totalHarga:N0}. Lanjutkan pembelian?", "Konfirmasi Pembelian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If confirmation = DialogResult.Yes Then
            If DataModule.BuyLaptop(DataModule.LoggedInUserId, selectedLaptopId.Value, qty, totalHarga) Then
                MessageBox.Show("Pembelian berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            Else
                MessageBox.Show("Terjadi kesalahan saat pembelian. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New FormLogin()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnHistori_Click(sender As Object, e As EventArgs) Handles btnHistori.Click
        Dim historiForm As New FormHistoriMember()
        historiForm.Show()
        Me.Hide()
    End Sub
End Class
