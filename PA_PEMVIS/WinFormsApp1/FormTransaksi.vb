Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class FormTransaksi
    Private WithEvents PrintDocument1 As New PrintDocument()
    Private PrintPreviewDialog1 As New PrintPreviewDialog()
    Private dtLaporan As DataTable
    Private totalPendapatan As Decimal = 0
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTransaksi.EnableHeadersVisualStyles = False
        dgvTransaksi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 53, 73)
        dgvTransaksi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Try
            dgvTransaksi.DataSource = DataModule.GetTransaksi()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim form2 As New FormProduk()
        form2.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New FormLogin()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            dtLaporan = DataModule.GetLaporanPenjualan()
            totalPendapatan = 0
            For Each row As DataRow In dtLaporan.Rows
                totalPendapatan += Convert.ToDecimal(row("TotalHarga"))
            Next
            
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.WindowState = FormWindowState.Maximized
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat laporan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontHeader As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSub As New Font("Arial", 10, FontStyle.Regular)
        Dim fontBold As New Font("Arial", 10, FontStyle.Bold)
        Dim fontRegular As New Font("Arial", 10, FontStyle.Regular)
        Dim fontLogo As New Font("Impact", 36, FontStyle.Bold)
        
        Dim x As Integer = 50
        Dim y As Integer = 50
        
        ' Logo Kanan Atas
        e.Graphics.DrawString("WT", fontLogo, Brushes.DarkRed, e.PageBounds.Width - 150, 40)
        
        ' Header
        e.Graphics.DrawString("TOKO WAHYU TECH", fontHeader, Brushes.Black, x, y)
        y += 30
        e.Graphics.DrawString("Jl. Batu Cermin, Samarinda, Kalimantan Timur, 75123", fontSub, Brushes.Black, x, y)
        y += 20
        e.Graphics.DrawString("Telp: 085753039151", fontSub, Brushes.Black, x, y)
        y += 30
        
        ' Line
        e.Graphics.DrawLine(Pens.Black, x, y, e.PageBounds.Width - 50, y)
        e.Graphics.DrawLine(Pens.Black, x, y + 2, e.PageBounds.Width - 50, y + 2)
        y += 20
        
        ' Title & Total
        Dim titleStr As String = "LAPORAN PENJUALAN"
        Dim titleSize As SizeF = e.Graphics.MeasureString(titleStr, fontHeader)
        e.Graphics.DrawString(titleStr, fontHeader, Brushes.Black, (e.PageBounds.Width - titleSize.Width) / 2, y)
        y += 40
        
        e.Graphics.DrawString("Total Pendapatan: Rp " & totalPendapatan.ToString("N0"), fontBold, Brushes.Black, e.PageBounds.Width - 300, y)
        y += 30
        
        ' Table Header
        e.Graphics.FillRectangle(Brushes.LightGray, x, y, e.PageBounds.Width - 100, 30)
        e.Graphics.DrawRectangle(Pens.Black, x, y, e.PageBounds.Width - 100, 30)
        e.Graphics.DrawString("No", fontBold, Brushes.Black, x + 10, y + 5)
        e.Graphics.DrawString("Produk", fontBold, Brushes.Black, x + 50, y + 5)
        e.Graphics.DrawString("Total Unit", fontBold, Brushes.Black, x + 400, y + 5)
        e.Graphics.DrawString("Total Penjualan", fontBold, Brushes.Black, x + 550, y + 5)
        y += 30
        
        ' Table Data
        Dim no As Integer = 1
        If dtLaporan IsNot Nothing Then
            For Each row As DataRow In dtLaporan.Rows
                e.Graphics.DrawRectangle(Pens.Black, x, y, e.PageBounds.Width - 100, 25)
                e.Graphics.DrawString(no.ToString(), fontRegular, Brushes.Black, x + 10, y + 5)
                e.Graphics.DrawString(row("Produk").ToString(), fontRegular, Brushes.Black, x + 50, y + 5)
                e.Graphics.DrawString(row("TotalUnit").ToString(), fontRegular, Brushes.Black, x + 400, y + 5)
                
                Dim totalH As Decimal = Convert.ToDecimal(row("TotalHarga"))
                e.Graphics.DrawString("Rp " & totalH.ToString("N0"), fontRegular, Brushes.Black, x + 550, y + 5)
                
                y += 25
                no += 1
            Next
        End If
    End Sub
End Class
