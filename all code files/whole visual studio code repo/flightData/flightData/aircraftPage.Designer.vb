<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aircraftPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aircraftPage))
        Me.ButtonCLEAR = New System.Windows.Forms.Button()
        Me.TextBoxPrimary = New System.Windows.Forms.TextBox()
        Me.BTNsearch = New System.Windows.Forms.Button()
        Me.PNLdata = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TXTalerts = New System.Windows.Forms.TextBox()
        Me.LBLalerts = New System.Windows.Forms.Label()
        Me.alertType = New System.Windows.Forms.TextBox()
        Me.Tlong = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Tlat = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Telev = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tlngth = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Thdg = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Tqfe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Tils = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ttacan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tfreq = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Ticao = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tiata = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTairfiedFound = New System.Windows.Forms.TextBox()
        Me.LBLtop = New System.Windows.Forms.Label()
        Me.BTN_home = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.backBlue = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_multi = New System.Windows.Forms.Button()
        Me.BTN_fast = New System.Windows.Forms.Button()
        Me.BTN_rotary = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PNLdata.SuspendLayout()
        CType(Me.backBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCLEAR
        '
        Me.ButtonCLEAR.BackColor = System.Drawing.Color.LightGray
        Me.ButtonCLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCLEAR.Location = New System.Drawing.Point(278, 64)
        Me.ButtonCLEAR.Name = "ButtonCLEAR"
        Me.ButtonCLEAR.Size = New System.Drawing.Size(44, 28)
        Me.ButtonCLEAR.TabIndex = 0
        Me.ButtonCLEAR.Text = "X"
        Me.ButtonCLEAR.UseVisualStyleBackColor = False
        Me.ButtonCLEAR.Visible = False
        '
        'TextBoxPrimary
        '
        Me.TextBoxPrimary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPrimary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrimary.Location = New System.Drawing.Point(33, 65)
        Me.TextBoxPrimary.MaxLength = 100
        Me.TextBoxPrimary.MinimumSize = New System.Drawing.Size(2, 30)
        Me.TextBoxPrimary.Name = "TextBoxPrimary"
        Me.TextBoxPrimary.Size = New System.Drawing.Size(244, 26)
        Me.TextBoxPrimary.TabIndex = 1
        Me.TextBoxPrimary.Visible = False
        '
        'BTNsearch
        '
        Me.BTNsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsearch.ForeColor = System.Drawing.Color.White
        Me.BTNsearch.Location = New System.Drawing.Point(33, 98)
        Me.BTNsearch.Name = "BTNsearch"
        Me.BTNsearch.Size = New System.Drawing.Size(289, 36)
        Me.BTNsearch.TabIndex = 0
        Me.BTNsearch.Text = "Search for Airfield..."
        Me.BTNsearch.UseVisualStyleBackColor = False
        Me.BTNsearch.Visible = False
        '
        'PNLdata
        '
        Me.PNLdata.Controls.Add(Me.TextBox1)
        Me.PNLdata.Controls.Add(Me.TXTalerts)
        Me.PNLdata.Controls.Add(Me.LBLalerts)
        Me.PNLdata.Controls.Add(Me.alertType)
        Me.PNLdata.Controls.Add(Me.Tlong)
        Me.PNLdata.Controls.Add(Me.Label16)
        Me.PNLdata.Controls.Add(Me.Tlat)
        Me.PNLdata.Controls.Add(Me.Label15)
        Me.PNLdata.Controls.Add(Me.Telev)
        Me.PNLdata.Controls.Add(Me.Label14)
        Me.PNLdata.Controls.Add(Me.Tlngth)
        Me.PNLdata.Controls.Add(Me.Label13)
        Me.PNLdata.Controls.Add(Me.Thdg)
        Me.PNLdata.Controls.Add(Me.Label12)
        Me.PNLdata.Controls.Add(Me.Tqfe)
        Me.PNLdata.Controls.Add(Me.Label11)
        Me.PNLdata.Controls.Add(Me.Tils)
        Me.PNLdata.Controls.Add(Me.Label10)
        Me.PNLdata.Controls.Add(Me.Ttacan)
        Me.PNLdata.Controls.Add(Me.Label9)
        Me.PNLdata.Controls.Add(Me.Tfreq)
        Me.PNLdata.Controls.Add(Me.Label17)
        Me.PNLdata.Controls.Add(Me.Label7)
        Me.PNLdata.Controls.Add(Me.Ticao)
        Me.PNLdata.Controls.Add(Me.Label8)
        Me.PNLdata.Controls.Add(Me.Tiata)
        Me.PNLdata.Controls.Add(Me.Label6)
        Me.PNLdata.Controls.Add(Me.TXTairfiedFound)
        Me.PNLdata.Controls.Add(Me.LBLtop)
        Me.PNLdata.Location = New System.Drawing.Point(31, 144)
        Me.PNLdata.Name = "PNLdata"
        Me.PNLdata.Size = New System.Drawing.Size(294, 453)
        Me.PNLdata.TabIndex = 4
        Me.PNLdata.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(227, 338)
        Me.TextBox1.MaxLength = 120
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(61, 17)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "REVIEW"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'TXTalerts
        '
        Me.TXTalerts.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTalerts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTalerts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTalerts.ForeColor = System.Drawing.Color.White
        Me.TXTalerts.Location = New System.Drawing.Point(5, 359)
        Me.TXTalerts.MaxLength = 1000
        Me.TXTalerts.Multiline = True
        Me.TXTalerts.Name = "TXTalerts"
        Me.TXTalerts.ReadOnly = True
        Me.TXTalerts.Size = New System.Drawing.Size(283, 86)
        Me.TXTalerts.TabIndex = 3
        '
        'LBLalerts
        '
        Me.LBLalerts.AutoSize = True
        Me.LBLalerts.BackColor = System.Drawing.Color.Transparent
        Me.LBLalerts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLalerts.ForeColor = System.Drawing.Color.White
        Me.LBLalerts.Location = New System.Drawing.Point(7, 339)
        Me.LBLalerts.Name = "LBLalerts"
        Me.LBLalerts.Size = New System.Drawing.Size(41, 16)
        Me.LBLalerts.TabIndex = 2
        Me.LBLalerts.Text = "Alerts"
        '
        'alertType
        '
        Me.alertType.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.alertType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.alertType.Cursor = System.Windows.Forms.Cursors.Default
        Me.alertType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alertType.ForeColor = System.Drawing.Color.White
        Me.alertType.Location = New System.Drawing.Point(51, 339)
        Me.alertType.MaxLength = 120
        Me.alertType.Name = "alertType"
        Me.alertType.ReadOnly = True
        Me.alertType.Size = New System.Drawing.Size(202, 15)
        Me.alertType.TabIndex = 3
        Me.alertType.Text = "for ERROR aircraft:"
        '
        'Tlong
        '
        Me.Tlong.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Tlong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tlong.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tlong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tlong.ForeColor = System.Drawing.Color.White
        Me.Tlong.Location = New System.Drawing.Point(104, 308)
        Me.Tlong.MaxLength = 120
        Me.Tlong.Name = "Tlong"
        Me.Tlong.ReadOnly = True
        Me.Tlong.Size = New System.Drawing.Size(184, 22)
        Me.Tlong.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(6, 310)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "LONGITUDE:"
        '
        'Tlat
        '
        Me.Tlat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Tlat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tlat.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tlat.ForeColor = System.Drawing.Color.White
        Me.Tlat.Location = New System.Drawing.Point(104, 280)
        Me.Tlat.MaxLength = 120
        Me.Tlat.Name = "Tlat"
        Me.Tlat.ReadOnly = True
        Me.Tlat.Size = New System.Drawing.Size(184, 22)
        Me.Tlat.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(6, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "LATITUDE:"
        '
        'Telev
        '
        Me.Telev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Telev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Telev.Cursor = System.Windows.Forms.Cursors.Default
        Me.Telev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telev.ForeColor = System.Drawing.Color.White
        Me.Telev.Location = New System.Drawing.Point(104, 252)
        Me.Telev.MaxLength = 120
        Me.Telev.Name = "Telev"
        Me.Telev.ReadOnly = True
        Me.Telev.Size = New System.Drawing.Size(184, 22)
        Me.Telev.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "RNY ELEV:"
        '
        'Tlngth
        '
        Me.Tlngth.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Tlngth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tlngth.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tlngth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tlngth.ForeColor = System.Drawing.Color.White
        Me.Tlngth.Location = New System.Drawing.Point(104, 224)
        Me.Tlngth.MaxLength = 120
        Me.Tlngth.Name = "Tlngth"
        Me.Tlngth.ReadOnly = True
        Me.Tlngth.Size = New System.Drawing.Size(184, 22)
        Me.Tlngth.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(6, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "RNY LNTH:"
        '
        'Thdg
        '
        Me.Thdg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Thdg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Thdg.Cursor = System.Windows.Forms.Cursors.Default
        Me.Thdg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thdg.ForeColor = System.Drawing.Color.White
        Me.Thdg.Location = New System.Drawing.Point(104, 196)
        Me.Thdg.MaxLength = 120
        Me.Thdg.Name = "Thdg"
        Me.Thdg.ReadOnly = True
        Me.Thdg.Size = New System.Drawing.Size(184, 22)
        Me.Thdg.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(6, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "RNY HDG:"
        '
        'Tqfe
        '
        Me.Tqfe.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Tqfe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tqfe.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tqfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tqfe.ForeColor = System.Drawing.Color.White
        Me.Tqfe.Location = New System.Drawing.Point(104, 168)
        Me.Tqfe.MaxLength = 120
        Me.Tqfe.Name = "Tqfe"
        Me.Tqfe.ReadOnly = True
        Me.Tqfe.Size = New System.Drawing.Size(184, 22)
        Me.Tqfe.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Baro. QFE:"
        '
        'Tils
        '
        Me.Tils.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Tils.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tils.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tils.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tils.ForeColor = System.Drawing.Color.White
        Me.Tils.Location = New System.Drawing.Point(104, 140)
        Me.Tils.MaxLength = 120
        Me.Tils.Name = "Tils"
        Me.Tils.ReadOnly = True
        Me.Tils.Size = New System.Drawing.Size(184, 22)
        Me.Tils.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "VOR/ILS:"
        '
        'Ttacan
        '
        Me.Ttacan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Ttacan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ttacan.Cursor = System.Windows.Forms.Cursors.Default
        Me.Ttacan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ttacan.ForeColor = System.Drawing.Color.White
        Me.Ttacan.Location = New System.Drawing.Point(104, 111)
        Me.Ttacan.MaxLength = 120
        Me.Ttacan.Name = "Ttacan"
        Me.Ttacan.ReadOnly = True
        Me.Ttacan.Size = New System.Drawing.Size(184, 22)
        Me.Ttacan.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(5, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "TACAN:"
        '
        'Tfreq
        '
        Me.Tfreq.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Tfreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tfreq.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tfreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tfreq.ForeColor = System.Drawing.Color.White
        Me.Tfreq.Location = New System.Drawing.Point(104, 83)
        Me.Tfreq.MaxLength = 120
        Me.Tfreq.Name = "Tfreq"
        Me.Tfreq.ReadOnly = True
        Me.Tfreq.Size = New System.Drawing.Size(184, 22)
        Me.Tfreq.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(5, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(287, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "--------------------------------------------------------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(5, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tower Freq:"
        '
        'Ticao
        '
        Me.Ticao.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Ticao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ticao.Cursor = System.Windows.Forms.Cursors.Default
        Me.Ticao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ticao.ForeColor = System.Drawing.Color.White
        Me.Ticao.Location = New System.Drawing.Point(51, 55)
        Me.Ticao.MaxLength = 120
        Me.Ticao.Name = "Ticao"
        Me.Ticao.ReadOnly = True
        Me.Ticao.Size = New System.Drawing.Size(87, 22)
        Me.Ticao.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ICAO:"
        '
        'Tiata
        '
        Me.Tiata.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Tiata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tiata.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tiata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiata.ForeColor = System.Drawing.Color.White
        Me.Tiata.Location = New System.Drawing.Point(190, 55)
        Me.Tiata.MaxLength = 120
        Me.Tiata.Name = "Tiata"
        Me.Tiata.ReadOnly = True
        Me.Tiata.Size = New System.Drawing.Size(98, 22)
        Me.Tiata.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(148, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "IATA:"
        '
        'TXTairfiedFound
        '
        Me.TXTairfiedFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTairfiedFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTairfiedFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.TXTairfiedFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTairfiedFound.ForeColor = System.Drawing.Color.White
        Me.TXTairfiedFound.Location = New System.Drawing.Point(104, 11)
        Me.TXTairfiedFound.MaxLength = 120
        Me.TXTairfiedFound.Name = "TXTairfiedFound"
        Me.TXTairfiedFound.ReadOnly = True
        Me.TXTairfiedFound.Size = New System.Drawing.Size(183, 22)
        Me.TXTairfiedFound.TabIndex = 3
        '
        'LBLtop
        '
        Me.LBLtop.AutoSize = True
        Me.LBLtop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLtop.ForeColor = System.Drawing.Color.White
        Me.LBLtop.Location = New System.Drawing.Point(8, 14)
        Me.LBLtop.Name = "LBLtop"
        Me.LBLtop.Size = New System.Drawing.Size(92, 16)
        Me.LBLtop.TabIndex = 2
        Me.LBLtop.Text = "Airfield Found:"
        '
        'BTN_home
        '
        Me.BTN_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTN_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_home.ForeColor = System.Drawing.Color.White
        Me.BTN_home.Location = New System.Drawing.Point(31, 24)
        Me.BTN_home.Name = "BTN_home"
        Me.BTN_home.Size = New System.Drawing.Size(107, 32)
        Me.BTN_home.TabIndex = 0
        Me.BTN_home.Text = "Home"
        Me.BTN_home.UseVisualStyleBackColor = False
        Me.BTN_home.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(40, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 48)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Agile Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "App for Aircrew"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please select an aircraft type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(41, 546)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOTICE: Please select ""Fast-Jet"" for drones (e.g.MQ-9),"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(44, 572)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Any contextual alerts are based on these aircraft types."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.UseWaitCursor = True
        '
        'backBlue
        '
        Me.backBlue.Location = New System.Drawing.Point(28, 12)
        Me.backBlue.Name = "backBlue"
        Me.backBlue.Size = New System.Drawing.Size(294, 124)
        Me.backBlue.TabIndex = 7
        Me.backBlue.TabStop = False
        Me.backBlue.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.flightData.My.Resources.Resources.raf_logo_reversed_203f876f8b
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(215, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 80)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BTN_multi
        '
        Me.BTN_multi.BackgroundImage = Global.flightData.My.Resources.Resources._1C00D4E6_8B3B_4F67_AD872B78FF5BABF8_600x300
        Me.BTN_multi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_multi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_multi.ForeColor = System.Drawing.Color.White
        Me.BTN_multi.Location = New System.Drawing.Point(34, 305)
        Me.BTN_multi.Name = "BTN_multi"
        Me.BTN_multi.Size = New System.Drawing.Size(286, 100)
        Me.BTN_multi.TabIndex = 1
        Me.BTN_multi.Text = "Multi-Engine"
        Me.BTN_multi.UseVisualStyleBackColor = True
        '
        'BTN_fast
        '
        Me.BTN_fast.BackgroundImage = Global.flightData.My.Resources.Resources.Typhoon1
        Me.BTN_fast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_fast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_fast.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_fast.ForeColor = System.Drawing.Color.White
        Me.BTN_fast.Location = New System.Drawing.Point(34, 183)
        Me.BTN_fast.Name = "BTN_fast"
        Me.BTN_fast.Size = New System.Drawing.Size(286, 100)
        Me.BTN_fast.TabIndex = 0
        Me.BTN_fast.Text = "Fast-Jet"
        Me.BTN_fast.UseVisualStyleBackColor = True
        '
        'BTN_rotary
        '
        Me.BTN_rotary.BackgroundImage = Global.flightData.My.Resources.Resources.Chinook_1
        Me.BTN_rotary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_rotary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_rotary.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_rotary.ForeColor = System.Drawing.Color.White
        Me.BTN_rotary.Location = New System.Drawing.Point(34, 428)
        Me.BTN_rotary.Name = "BTN_rotary"
        Me.BTN_rotary.Size = New System.Drawing.Size(286, 100)
        Me.BTN_rotary.TabIndex = 2
        Me.BTN_rotary.Text = "Rotary-Wing"
        Me.BTN_rotary.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.flightData.My.Resources.Resources.raf_logo_reversed_203f876f8b
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(239, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(92, 31)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'aircraftPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(355, 618)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BTNsearch)
        Me.Controls.Add(Me.BTN_home)
        Me.Controls.Add(Me.ButtonCLEAR)
        Me.Controls.Add(Me.TextBoxPrimary)
        Me.Controls.Add(Me.backBlue)
        Me.Controls.Add(Me.PNLdata)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_multi)
        Me.Controls.Add(Me.BTN_fast)
        Me.Controls.Add(Me.BTN_rotary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "aircraftPage"
        Me.Text = "Aicrew Agile Information App"
        Me.PNLdata.ResumeLayout(False)
        Me.PNLdata.PerformLayout()
        CType(Me.backBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_home As Button
    Friend WithEvents TextBoxPrimary As TextBox
    Friend WithEvents ButtonCLEAR As Button
    Friend WithEvents BTNsearch As Button
    Friend WithEvents LBLtop As Label
    Friend WithEvents TXTairfiedFound As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PNLdata As Panel
    Friend WithEvents TXTalerts As TextBox
    Friend WithEvents LBLalerts As Label
    Friend WithEvents Tfreq As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Tiata As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Ticao As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Telev As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Tlngth As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Thdg As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Tqfe As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Tils As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Ttacan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Tlong As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Tlat As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents alertType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_multi As Button
    Friend WithEvents BTN_rotary As Button
    Friend WithEvents BTN_fast As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents backBlue As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
