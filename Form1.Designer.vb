<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnModul = New System.Windows.Forms.Button()
        Me.BtnSuhu = New System.Windows.Forms.Button()
        Me.BtnMotor = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Minus = New System.Windows.Forms.PictureBox()
        Me.Close1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TBCOM = New System.Windows.Forms.ComboBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.BtnMati = New System.Windows.Forms.Button()
        Me.BtnNyala = New System.Windows.Forms.Button()
        Me.BtnKirim = New System.Windows.Forms.Button()
        Me.BtnHubung = New System.Windows.Forms.Button()
        Me.DataAktual = New System.Windows.Forms.TextBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.LKA = New System.Windows.Forms.Label()
        Me.SetPoint = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.LSK = New System.Windows.Forms.Label()
        Me.TBKD = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBKI = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBKP = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBBR = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TBPerbesar = New System.Windows.Forms.Button()
        Me.TbPerkecil = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Minus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnModul)
        Me.Panel1.Controls.Add(Me.BtnSuhu)
        Me.Panel1.Controls.Add(Me.BtnMotor)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 473)
        Me.Panel1.TabIndex = 0
        '
        'BtnModul
        '
        Me.BtnModul.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModul.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModul.Location = New System.Drawing.Point(16, 369)
        Me.BtnModul.Name = "BtnModul"
        Me.BtnModul.Size = New System.Drawing.Size(168, 45)
        Me.BtnModul.TabIndex = 4
        Me.BtnModul.Text = "MODUL"
        Me.BtnModul.UseVisualStyleBackColor = False
        '
        'BtnSuhu
        '
        Me.BtnSuhu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSuhu.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuhu.Location = New System.Drawing.Point(16, 318)
        Me.BtnSuhu.Name = "BtnSuhu"
        Me.BtnSuhu.Size = New System.Drawing.Size(168, 45)
        Me.BtnSuhu.TabIndex = 3
        Me.BtnSuhu.Text = "KONTROL SUHU"
        Me.BtnSuhu.UseVisualStyleBackColor = False
        '
        'BtnMotor
        '
        Me.BtnMotor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnMotor.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMotor.Location = New System.Drawing.Point(16, 267)
        Me.BtnMotor.Name = "BtnMotor"
        Me.BtnMotor.Size = New System.Drawing.Size(168, 45)
        Me.BtnMotor.TabIndex = 2
        Me.BtnMotor.Text = "KONTROL MOTOR"
        Me.BtnMotor.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(0, 192)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 52)
        Me.Panel5.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRAINER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PID CONTROLLER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TrainerPID.My.Resources.Resources.Logo_Besar
        Me.PictureBox1.Location = New System.Drawing.Point(30, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Minus)
        Me.Panel2.Controls.Add(Me.Close1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 25)
        Me.Panel2.TabIndex = 1
        '
        'Minus
        '
        Me.Minus.Image = Global.TrainerPID.My.Resources.Resources.minus_button
        Me.Minus.Location = New System.Drawing.Point(555, 3)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(18, 18)
        Me.Minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Minus.TabIndex = 19
        Me.Minus.TabStop = False
        '
        'Close1
        '
        Me.Close1.Image = Global.TrainerPID.My.Resources.Resources.close__1_
        Me.Close1.Location = New System.Drawing.Point(577, 2)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(20, 20)
        Me.Close1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close1.TabIndex = 17
        Me.Close1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(200, 468)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 5)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TBCOM)
        Me.Panel4.Controls.Add(Me.Status)
        Me.Panel4.Controls.Add(Me.BtnMati)
        Me.Panel4.Controls.Add(Me.BtnNyala)
        Me.Panel4.Controls.Add(Me.BtnKirim)
        Me.Panel4.Controls.Add(Me.BtnHubung)
        Me.Panel4.Controls.Add(Me.DataAktual)
        Me.Panel4.Controls.Add(Me.Panel12)
        Me.Panel4.Controls.Add(Me.SetPoint)
        Me.Panel4.Controls.Add(Me.Panel13)
        Me.Panel4.Controls.Add(Me.TBKD)
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Controls.Add(Me.TBKI)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Controls.Add(Me.TBKP)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Controls.Add(Me.TBBR)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Location = New System.Drawing.Point(206, 31)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(582, 181)
        Me.Panel4.TabIndex = 3
        '
        'TBCOM
        '
        Me.TBCOM.FormattingEnabled = True
        Me.TBCOM.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10"})
        Me.TBCOM.Location = New System.Drawing.Point(78, 30)
        Me.TBCOM.Name = "TBCOM"
        Me.TBCOM.Size = New System.Drawing.Size(100, 21)
        Me.TBCOM.TabIndex = 17
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(480, 161)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(99, 15)
        Me.Status.TabIndex = 4
        Me.Status.Text = "TIDAK TERHUBUNG"
        '
        'BtnMati
        '
        Me.BtnMati.BackColor = System.Drawing.Color.Red
        Me.BtnMati.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMati.Location = New System.Drawing.Point(272, 146)
        Me.BtnMati.Name = "BtnMati"
        Me.BtnMati.Size = New System.Drawing.Size(79, 20)
        Me.BtnMati.TabIndex = 16
        Me.BtnMati.Text = "MATI"
        Me.BtnMati.UseVisualStyleBackColor = False
        '
        'BtnNyala
        '
        Me.BtnNyala.BackColor = System.Drawing.Color.Lime
        Me.BtnNyala.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNyala.Location = New System.Drawing.Point(187, 146)
        Me.BtnNyala.Name = "BtnNyala"
        Me.BtnNyala.Size = New System.Drawing.Size(79, 20)
        Me.BtnNyala.TabIndex = 15
        Me.BtnNyala.Text = "NYALA"
        Me.BtnNyala.UseVisualStyleBackColor = False
        '
        'BtnKirim
        '
        Me.BtnKirim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnKirim.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKirim.Location = New System.Drawing.Point(462, 94)
        Me.BtnKirim.Name = "BtnKirim"
        Me.BtnKirim.Size = New System.Drawing.Size(98, 46)
        Me.BtnKirim.TabIndex = 14
        Me.BtnKirim.Text = "KIRIM"
        Me.BtnKirim.UseVisualStyleBackColor = False
        '
        'BtnHubung
        '
        Me.BtnHubung.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnHubung.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHubung.Location = New System.Drawing.Point(184, 30)
        Me.BtnHubung.Name = "BtnHubung"
        Me.BtnHubung.Size = New System.Drawing.Size(98, 46)
        Me.BtnHubung.TabIndex = 5
        Me.BtnHubung.Text = "HUBUNGKAN"
        Me.BtnHubung.UseVisualStyleBackColor = False
        '
        'DataAktual
        '
        Me.DataAktual.Enabled = False
        Me.DataAktual.Location = New System.Drawing.Point(356, 120)
        Me.DataAktual.Name = "DataAktual"
        Me.DataAktual.Size = New System.Drawing.Size(100, 20)
        Me.DataAktual.TabIndex = 13
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Black
        Me.Panel12.Controls.Add(Me.LKA)
        Me.Panel12.Location = New System.Drawing.Point(187, 120)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(170, 20)
        Me.Panel12.TabIndex = 12
        '
        'LKA
        '
        Me.LKA.AutoSize = True
        Me.LKA.ForeColor = System.Drawing.Color.White
        Me.LKA.Location = New System.Drawing.Point(10, 4)
        Me.LKA.Name = "LKA"
        Me.LKA.Size = New System.Drawing.Size(149, 13)
        Me.LKA.TabIndex = 0
        Me.LKA.Text = "KECEPATAN AKTUAL (RPM)"
        '
        'SetPoint
        '
        Me.SetPoint.Location = New System.Drawing.Point(356, 94)
        Me.SetPoint.Name = "SetPoint"
        Me.SetPoint.Size = New System.Drawing.Size(100, 20)
        Me.SetPoint.TabIndex = 11
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Black
        Me.Panel13.Controls.Add(Me.LSK)
        Me.Panel13.Location = New System.Drawing.Point(187, 94)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(170, 20)
        Me.Panel13.TabIndex = 10
        '
        'LSK
        '
        Me.LSK.AutoSize = True
        Me.LSK.ForeColor = System.Drawing.Color.White
        Me.LSK.Location = New System.Drawing.Point(20, 4)
        Me.LSK.Name = "LSK"
        Me.LSK.Size = New System.Drawing.Size(128, 13)
        Me.LSK.TabIndex = 0
        Me.LSK.Text = "SET KECEPATAN (RPM)"
        '
        'TBKD
        '
        Me.TBKD.Location = New System.Drawing.Point(78, 146)
        Me.TBKD.Name = "TBKD"
        Me.TBKD.Size = New System.Drawing.Size(100, 20)
        Me.TBKD.TabIndex = 9
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Black
        Me.Panel11.Controls.Add(Me.Label7)
        Me.Panel11.Location = New System.Drawing.Point(3, 146)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(76, 20)
        Me.Panel11.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(28, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TD"
        '
        'TBKI
        '
        Me.TBKI.Location = New System.Drawing.Point(78, 120)
        Me.TBKI.Name = "TBKI"
        Me.TBKI.Size = New System.Drawing.Size(100, 20)
        Me.TBKI.TabIndex = 7
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Black
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Location = New System.Drawing.Point(3, 120)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(76, 20)
        Me.Panel10.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(28, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "TI"
        '
        'TBKP
        '
        Me.TBKP.Location = New System.Drawing.Point(78, 94)
        Me.TBKP.Name = "TBKP"
        Me.TBKP.Size = New System.Drawing.Size(100, 20)
        Me.TBKP.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Black
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Location = New System.Drawing.Point(3, 94)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(76, 20)
        Me.Panel9.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "KP"
        '
        'TBBR
        '
        Me.TBBR.Location = New System.Drawing.Point(78, 56)
        Me.TBBR.Name = "TBBR"
        Me.TBBR.Size = New System.Drawing.Size(100, 20)
        Me.TBBR.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Location = New System.Drawing.Point(3, 56)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(76, 20)
        Me.Panel8.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BAUDRATE"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(3, 30)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(76, 20)
        Me.Panel7.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "COM"
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(206, 218)
        Me.Chart1.Name = "Chart1"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series7.Legend = "Legend1"
        Series7.Name = "Setpoint"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series8.Legend = "Legend1"
        Series8.Name = "Data"
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Size = New System.Drawing.Size(582, 246)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "PERKECIL"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(206, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(154, 24)
        Me.Panel6.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "KONTROL MOTOR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'SerialPort1
        '
        '
        'TBPerbesar
        '
        Me.TBPerbesar.BackColor = System.Drawing.Color.White
        Me.TBPerbesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TBPerbesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TBPerbesar.Location = New System.Drawing.Point(677, 384)
        Me.TBPerbesar.Name = "TBPerbesar"
        Me.TBPerbesar.Size = New System.Drawing.Size(96, 45)
        Me.TBPerbesar.TabIndex = 4
        Me.TBPerbesar.Text = "PERBESAR"
        Me.TBPerbesar.UseVisualStyleBackColor = False
        '
        'TbPerkecil
        '
        Me.TbPerkecil.BackColor = System.Drawing.Color.White
        Me.TbPerkecil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TbPerkecil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TbPerkecil.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TbPerkecil.Location = New System.Drawing.Point(677, 384)
        Me.TbPerkecil.Name = "TbPerkecil"
        Me.TbPerkecil.Size = New System.Drawing.Size(96, 45)
        Me.TbPerkecil.TabIndex = 5
        Me.TbPerkecil.Text = "PERKECIL"
        Me.TbPerkecil.UseVisualStyleBackColor = False
        Me.TbPerkecil.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.TBPerbesar)
        Me.Controls.Add(Me.TbPerkecil)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Minus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents BtnModul As Button
    Friend WithEvents BtnSuhu As Button
    Friend WithEvents BtnMotor As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Close1 As PictureBox
    Friend WithEvents BtnMati As Button
    Friend WithEvents BtnNyala As Button
    Friend WithEvents BtnKirim As Button
    Friend WithEvents BtnHubung As Button
    Friend WithEvents DataAktual As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents LKA As Label
    Friend WithEvents SetPoint As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents LSK As Label
    Friend WithEvents TBKD As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TBKI As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TBKP As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TBBR As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Minus As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Status As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TBCOM As ComboBox
    Friend WithEvents TBPerbesar As Button
    Friend WithEvents TbPerkecil As Button
End Class
