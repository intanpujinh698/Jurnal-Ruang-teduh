<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        dtpTanggal = New DateTimePicker()
        Label3 = New Label()
        rbBahagia = New RadioButton()
        rbTenang = New RadioButton()
        rbBiasa = New RadioButton()
        rbSedih = New RadioButton()
        rbCemas = New RadioButton()
        rbMarah = New RadioButton()
        GrpMood = New GroupBox()
        Label4 = New Label()
        rtbRefleksi = New RichTextBox()
        Label5 = New Label()
        rtbManifestasi = New RichTextBox()
        BtnSimpan = New Button()
        BtnBaca = New Button()
        BtnTutup = New Button()
        Label6 = New Label()
        tbSkalaMood = New TrackBar()
        lblAngka = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GrpMood.SuspendLayout()
        CType(tbSkalaMood, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.RosyBrown
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.GridColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(396, 94)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.RosyBrown
        Label1.Font = New Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightPink
        Label1.Location = New Point(45, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(294, 58)
        Label1.TabIndex = 1
        Label1.Text = "Ruang Teduh"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.RosyBrown
        Label2.Font = New Font("Rockwell", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Label2.Location = New Point(65, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(258, 27)
        Label2.TabIndex = 2
        Label2.Text = "Teman Jurnal Harianku"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(110, 126)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(200, 23)
        dtpTanggal.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.RosyBrown
        Label3.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 19)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal :"
        ' 
        ' rbBahagia
        ' 
        rbBahagia.AutoSize = True
        rbBahagia.Location = New Point(9, 22)
        rbBahagia.Name = "rbBahagia"
        rbBahagia.Size = New Size(74, 21)
        rbBahagia.TabIndex = 6
        rbBahagia.TabStop = True
        rbBahagia.Text = "Bahagia"
        rbBahagia.UseVisualStyleBackColor = True
        ' 
        ' rbTenang
        ' 
        rbTenang.AutoSize = True
        rbTenang.Location = New Point(96, 24)
        rbTenang.Name = "rbTenang"
        rbTenang.Size = New Size(70, 21)
        rbTenang.TabIndex = 7
        rbTenang.TabStop = True
        rbTenang.Text = "Tenang"
        rbTenang.UseVisualStyleBackColor = True
        ' 
        ' rbBiasa
        ' 
        rbBiasa.AutoSize = True
        rbBiasa.Location = New Point(179, 22)
        rbBiasa.Name = "rbBiasa"
        rbBiasa.Size = New Size(57, 21)
        rbBiasa.TabIndex = 8
        rbBiasa.TabStop = True
        rbBiasa.Text = "Biasa"
        rbBiasa.UseVisualStyleBackColor = True
        ' 
        ' rbSedih
        ' 
        rbSedih.AutoSize = True
        rbSedih.Location = New Point(9, 65)
        rbSedih.Name = "rbSedih"
        rbSedih.Size = New Size(59, 21)
        rbSedih.TabIndex = 9
        rbSedih.TabStop = True
        rbSedih.Text = "Sedih"
        rbSedih.UseVisualStyleBackColor = True
        ' 
        ' rbCemas
        ' 
        rbCemas.AutoSize = True
        rbCemas.Location = New Point(96, 65)
        rbCemas.Name = "rbCemas"
        rbCemas.Size = New Size(64, 21)
        rbCemas.TabIndex = 10
        rbCemas.TabStop = True
        rbCemas.Text = "Cemas"
        rbCemas.UseVisualStyleBackColor = True
        ' 
        ' rbMarah
        ' 
        rbMarah.AutoSize = True
        rbMarah.Location = New Point(179, 65)
        rbMarah.Name = "rbMarah"
        rbMarah.Size = New Size(64, 21)
        rbMarah.TabIndex = 11
        rbMarah.TabStop = True
        rbMarah.Text = "Marah"
        rbMarah.UseVisualStyleBackColor = True
        ' 
        ' GrpMood
        ' 
        GrpMood.Controls.Add(rbBahagia)
        GrpMood.Controls.Add(rbMarah)
        GrpMood.Controls.Add(rbTenang)
        GrpMood.Controls.Add(rbCemas)
        GrpMood.Controls.Add(rbBiasa)
        GrpMood.Controls.Add(rbSedih)
        GrpMood.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GrpMood.Location = New Point(35, 233)
        GrpMood.Name = "GrpMood"
        GrpMood.Size = New Size(252, 113)
        GrpMood.TabIndex = 12
        GrpMood.TabStop = False
        GrpMood.Text = "My mood"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.RosyBrown
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(35, 353)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 17)
        Label4.TabIndex = 13
        Label4.Text = "Refleksi hari ini"
        ' 
        ' rtbRefleksi
        ' 
        rtbRefleksi.Location = New Point(35, 373)
        rtbRefleksi.Name = "rtbRefleksi"
        rtbRefleksi.Size = New Size(325, 58)
        rtbRefleksi.TabIndex = 14
        rtbRefleksi.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.RosyBrown
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(35, 444)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 17)
        Label5.TabIndex = 15
        Label5.Text = "Manifestasi"
        ' 
        ' rtbManifestasi
        ' 
        rtbManifestasi.Location = New Point(35, 464)
        rtbManifestasi.Name = "rtbManifestasi"
        rtbManifestasi.Size = New Size(325, 64)
        rtbManifestasi.TabIndex = 16
        rtbManifestasi.Text = ""
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.Location = New Point(65, 534)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(75, 23)
        BtnSimpan.TabIndex = 17
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = True
        ' 
        ' BtnBaca
        ' 
        BtnBaca.Location = New Point(146, 534)
        BtnBaca.Name = "BtnBaca"
        BtnBaca.Size = New Size(75, 23)
        BtnBaca.TabIndex = 18
        BtnBaca.Text = "Baca"
        BtnBaca.UseVisualStyleBackColor = True
        ' 
        ' BtnTutup
        ' 
        BtnTutup.Location = New Point(227, 534)
        BtnTutup.Name = "BtnTutup"
        BtnTutup.Size = New Size(75, 23)
        BtnTutup.TabIndex = 19
        BtnTutup.Text = "Tutup"
        BtnTutup.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.RosyBrown
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(35, 162)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 17)
        Label6.TabIndex = 20
        Label6.Text = "Skala Mood"
        ' 
        ' tbSkalaMood
        ' 
        tbSkalaMood.Location = New Point(35, 182)
        tbSkalaMood.Name = "tbSkalaMood"
        tbSkalaMood.Size = New Size(186, 45)
        tbSkalaMood.TabIndex = 21
        ' 
        ' lblAngka
        ' 
        lblAngka.AutoSize = True
        lblAngka.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAngka.Location = New Point(227, 191)
        lblAngka.Name = "lblAngka"
        lblAngka.Size = New Size(17, 20)
        lblAngka.TabIndex = 22
        lblAngka.Text = "5"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(396, 581)
        Controls.Add(lblAngka)
        Controls.Add(tbSkalaMood)
        Controls.Add(Label6)
        Controls.Add(BtnTutup)
        Controls.Add(BtnBaca)
        Controls.Add(BtnSimpan)
        Controls.Add(rtbManifestasi)
        Controls.Add(Label5)
        Controls.Add(rtbRefleksi)
        Controls.Add(Label4)
        Controls.Add(GrpMood)
        Controls.Add(Label3)
        Controls.Add(dtpTanggal)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Ruang Teduh"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GrpMood.ResumeLayout(False)
        GrpMood.PerformLayout()
        CType(tbSkalaMood, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents rbBahagia As RadioButton
    Friend WithEvents rbTenang As RadioButton
    Friend WithEvents rbBiasa As RadioButton
    Friend WithEvents rbSedih As RadioButton
    Friend WithEvents rbCemas As RadioButton
    Friend WithEvents rbMarah As RadioButton
    Friend WithEvents GrpMood As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rtbRefleksi As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rtbManifestasi As RichTextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBaca As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbSkalaMood As TrackBar
    Friend WithEvents lblAngka As Label

End Class
