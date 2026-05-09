<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMember
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
        dgvLaptops = New Guna.UI2.WinForms.Guna2DataGridView()
        txtMerk = New Guna.UI2.WinForms.Guna2TextBox()
        txtNama = New Guna.UI2.WinForms.Guna2TextBox()
        txtHarga = New Guna.UI2.WinForms.Guna2TextBox()
        txtStok = New Guna.UI2.WinForms.Guna2TextBox()
        numJumlah = New Guna.UI2.WinForms.Guna2NumericUpDown()
        btnBeli = New Guna.UI2.WinForms.Guna2Button()
        btnHistori = New Guna.UI2.WinForms.Guna2Button()
        btnLogout = New Guna.UI2.WinForms.Guna2Button()
        lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblMerk = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblNama = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblHarga = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblStok = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblJumlah = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        CType(dgvLaptops, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(numJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lblTitle.Text = "Member Dashboard"
        ' 
        ' btnLogout
        ' 
        btnLogout.BorderRadius = 8
        btnLogout.FillColor = Color.FromArgb(CByte(200), CByte(50), CByte(50))
        btnLogout.Font = New Font("JetBrains Mono", 9F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(1100, 24)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(120, 36)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        ' 
        ' btnHistori
        ' 
        btnHistori.BorderRadius = 8
        btnHistori.FillColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        btnHistori.Font = New Font("JetBrains Mono", 9F, FontStyle.Bold)
        btnHistori.ForeColor = Color.White
        btnHistori.Location = New Point(950, 24)
        btnHistori.Name = "btnHistori"
        btnHistori.Size = New Size(120, 36)
        btnHistori.TabIndex = 2
        btnHistori.Text = "Histori"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.White
        pnlMain.BorderRadius = 12
        pnlMain.Controls.Add(dgvLaptops)
        pnlMain.Controls.Add(lblMerk)
        pnlMain.Controls.Add(txtMerk)
        pnlMain.Controls.Add(lblNama)
        pnlMain.Controls.Add(txtNama)
        pnlMain.Controls.Add(lblHarga)
        pnlMain.Controls.Add(txtHarga)
        pnlMain.Controls.Add(lblStok)
        pnlMain.Controls.Add(txtStok)
        pnlMain.Controls.Add(lblJumlah)
        pnlMain.Controls.Add(numJumlah)
        pnlMain.Controls.Add(btnBeli)
        pnlMain.Location = New Point(32, 80)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1200, 680)
        pnlMain.TabIndex = 2
        ' 
        ' dgvLaptops
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvLaptops.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        DataGridViewCellStyle2.Font = New Font("JetBrains Mono", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvLaptops.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvLaptops.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("JetBrains Mono", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvLaptops.DefaultCellStyle = DataGridViewCellStyle3
        dgvLaptops.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvLaptops.Location = New Point(32, 32)
        dgvLaptops.Name = "dgvLaptops"
        dgvLaptops.ReadOnly = True
        dgvLaptops.RowHeadersVisible = False
        dgvLaptops.Size = New Size(700, 600)
        dgvLaptops.TabIndex = 0
        dgvLaptops.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvLaptops.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        dgvLaptops.ThemeStyle.HeaderStyle.ForeColor = Color.White
        ' 
        ' lblMerk
        ' 
        lblMerk.BackColor = Color.Transparent
        lblMerk.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Bold)
        lblMerk.Location = New Point(800, 32)
        lblMerk.Name = "lblMerk"
        lblMerk.Size = New Size(40, 19)
        lblMerk.TabIndex = 3
        lblMerk.Text = "Merk"
        ' 
        ' txtMerk
        ' 
        txtMerk.Enabled = False
        txtMerk.Font = New Font("JetBrains Mono", 9F)
        txtMerk.Location = New Point(800, 64)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(300, 36)
        txtMerk.TabIndex = 4
        ' 
        ' lblNama
        ' 
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Bold)
        lblNama.Location = New Point(800, 112)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(40, 19)
        lblNama.TabIndex = 5
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Enabled = False
        txtNama.Font = New Font("JetBrains Mono", 9F)
        txtNama.Location = New Point(800, 144)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 36)
        txtNama.TabIndex = 6
        ' 
        ' lblHarga
        ' 
        lblHarga.BackColor = Color.Transparent
        lblHarga.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Bold)
        lblHarga.Location = New Point(800, 192)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(48, 19)
        lblHarga.TabIndex = 7
        lblHarga.Text = "Harga"
        ' 
        ' txtHarga
        ' 
        txtHarga.Enabled = False
        txtHarga.Font = New Font("JetBrains Mono", 9F)
        txtHarga.Location = New Point(800, 224)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(300, 36)
        txtHarga.TabIndex = 8
        ' 
        ' lblStok
        ' 
        lblStok.BackColor = Color.Transparent
        lblStok.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Bold)
        lblStok.Location = New Point(800, 272)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(40, 19)
        lblStok.TabIndex = 9
        lblStok.Text = "Stok"
        ' 
        ' txtStok
        ' 
        txtStok.Enabled = False
        txtStok.Font = New Font("JetBrains Mono", 9F)
        txtStok.Location = New Point(800, 304)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(300, 36)
        txtStok.TabIndex = 10
        ' 
        ' lblJumlah
        ' 
        lblJumlah.BackColor = Color.Transparent
        lblJumlah.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Bold)
        lblJumlah.Location = New Point(800, 368)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(100, 19)
        lblJumlah.TabIndex = 11
        lblJumlah.Text = "Jumlah Beli"
        ' 
        ' numJumlah
        ' 
        numJumlah.Font = New Font("JetBrains Mono", 9F)
        numJumlah.Location = New Point(800, 400)
        numJumlah.Name = "numJumlah"
        numJumlah.Size = New Size(300, 36)
        numJumlah.TabIndex = 12
        numJumlah.Minimum = 1
        numJumlah.Value = 1
        ' 
        ' btnBeli
        ' 
        btnBeli.BorderRadius = 8
        btnBeli.FillColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        btnBeli.Font = New Font("JetBrains Mono", 9.75F, FontStyle.Bold)
        btnBeli.ForeColor = Color.White
        btnBeli.Location = New Point(800, 480)
        btnBeli.Name = "btnBeli"
        btnBeli.Size = New Size(300, 45)
        btnBeli.TabIndex = 13
        btnBeli.Text = "Beli Sekarang"
        ' 
        ' FormMember
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(255))
        ClientSize = New Size(1280, 800)
        Controls.Add(pnlMain)
        Controls.Add(btnHistori)
        Controls.Add(btnLogout)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormMember"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMember"
        CType(dgvLaptops, System.ComponentModel.ISupportInitialize).EndInit()
        CType(numJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvLaptops As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtMerk As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtHarga As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStok As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents numJumlah As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnBeli As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistori As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMerk As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNama As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblHarga As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStok As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblJumlah As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel

End Class
