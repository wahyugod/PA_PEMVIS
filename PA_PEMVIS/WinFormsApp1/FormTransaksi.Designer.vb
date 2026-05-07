<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        dgvTransaksi = New Guna.UI2.WinForms.Guna2DataGridView()
        btnKembali = New Guna.UI2.WinForms.Guna2Button()
        btnLogout = New Guna.UI2.WinForms.Guna2Button()
        btnCetak = New Guna.UI2.WinForms.Guna2Button()
        lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        CType(dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("JetBrains Mono", 18F, FontStyle.Bold)
        lblTitle.Location = New Point(32, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(300, 33)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Data Transaksi Member"
        ' 
        ' btnKembali
        ' 
        btnKembali.BorderRadius = 8
        btnKembali.FillColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        btnKembali.Font = New Font("JetBrains Mono", 9F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(950, 24)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(120, 36)
        btnKembali.TabIndex = 1
        btnKembali.Text = "Kembali"
        ' 
        ' btnLogout
        ' 
        btnLogout.BorderRadius = 8
        btnLogout.FillColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnLogout.Font = New Font("JetBrains Mono", 9F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(1100, 24)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(120, 36)
        btnLogout.TabIndex = 2
        btnLogout.Text = "Logout"
        ' 
        ' btnCetak
        ' 
        btnCetak.BorderRadius = 8
        btnCetak.FillColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
        btnCetak.Font = New Font("JetBrains Mono", 9F, FontStyle.Bold)
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(800, 24)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(120, 36)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Cetak Laporan"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.White
        pnlMain.BorderRadius = 12
        pnlMain.Controls.Add(dgvTransaksi)
        pnlMain.Location = New Point(32, 80)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1200, 680)
        pnlMain.TabIndex = 3
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.AllowUserToAddRows = False
        dgvTransaksi.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvTransaksi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        DataGridViewCellStyle2.Font = New Font("JetBrains Mono", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTransaksi.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("JetBrains Mono", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTransaksi.DefaultCellStyle = DataGridViewCellStyle3
        dgvTransaksi.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvTransaksi.Location = New Point(32, 32)
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.ReadOnly = True
        dgvTransaksi.RowHeadersVisible = False
        dgvTransaksi.Size = New Size(1136, 616)
        dgvTransaksi.TabIndex = 0
        dgvTransaksi.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvTransaksi.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        dgvTransaksi.ThemeStyle.HeaderStyle.ForeColor = Color.White
        ' 
        ' FormTransaksi
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(255))
        ClientSize = New Size(1280, 800)
        Controls.Add(pnlMain)
        Controls.Add(btnKembali)
        Controls.Add(btnCetak)
        Controls.Add(btnLogout)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormTransaksi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormTransaksi"
        CType(dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTransaksi As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnKembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCetak As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel

End Class
