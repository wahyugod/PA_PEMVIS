<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHistoriMember
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
        dgvHistori = New Guna.UI2.WinForms.Guna2DataGridView()
        btnKembali = New Guna.UI2.WinForms.Guna2Button()
        btnLogout = New Guna.UI2.WinForms.Guna2Button()
        lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        CType(dgvHistori, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lblTitle.Text = "Histori Pembelian"
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
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.White
        pnlMain.BorderRadius = 12
        pnlMain.Controls.Add(dgvHistori)
        pnlMain.Location = New Point(32, 80)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1200, 680)
        pnlMain.TabIndex = 3
        ' 
        ' dgvHistori
        ' 
        dgvHistori.AllowUserToAddRows = False
        dgvHistori.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvHistori.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        DataGridViewCellStyle2.Font = New Font("JetBrains Mono", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvHistori.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvHistori.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("JetBrains Mono", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvHistori.DefaultCellStyle = DataGridViewCellStyle3
        dgvHistori.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvHistori.Location = New Point(32, 32)
        dgvHistori.Name = "dgvHistori"
        dgvHistori.ReadOnly = True
        dgvHistori.RowHeadersVisible = False
        dgvHistori.Size = New Size(1136, 616)
        dgvHistori.TabIndex = 0
        dgvHistori.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvHistori.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(45), CByte(53), CByte(73))
        dgvHistori.ThemeStyle.HeaderStyle.ForeColor = Color.White
        ' 
        ' FormHistoriMember
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(255))
        ClientSize = New Size(1280, 800)
        Controls.Add(pnlMain)
        Controls.Add(btnKembali)
        Controls.Add(btnLogout)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormHistoriMember"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormHistoriMember"
        CType(dgvHistori, System.ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvHistori As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnKembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel

End Class
