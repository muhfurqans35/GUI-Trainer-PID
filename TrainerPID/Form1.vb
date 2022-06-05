Public Class Form1
    'variable inti
    Dim data_masuk As String
    Dim speed As String
    Dim temps As String
    Dim i As Integer
    'variable untuk panel
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    'PROGRAM INTI

    Public Sub New()
        InitializeComponent()
        DataAktual.Enabled = False

    End Sub

    Private Sub BtnHubung_Click(sender As Object, e As EventArgs) Handles BtnHubung.Click
        Try
            SerialPort1.BaudRate = Val(TBBR.Text)
            SerialPort1.PortName = TBCOM.SelectedItem()
            SerialPort1.Open()
            Timer1.Start()
            i = 300
            If SerialPort1.IsOpen() Then
                Status.Text = "TERHUBUNG"
            End If

        Catch ex As Exception
            If Status.Text = "TIDAK TERHUBUNG" Then
                MessageBox.Show("Komunikasi Gagal..!")
            Else
                MessageBox.Show("Komunikasi Sudah Terhubung..!")
            End If

        End Try

    End Sub
    Private Sub BtnNyala_Click(sender As Object, e As EventArgs) Handles BtnNyala.Click
        SerialPort1.WriteLine("vs_start")
    End Sub

    Private Sub BtnMati_Click(sender As Object, e As EventArgs) Handles BtnMati.Click
        SerialPort1.WriteLine("vs_stop")
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        data_masuk = SerialPort1.ReadLine()
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim length As String
        length = data_masuk.Length.ToString
        If (Convert.ToInt32(length) > 5) Then
            If (data_masuk.Substring(0, 5) = "speed") Then
                speed = data_masuk.Substring(5, Convert.ToInt32(length) - 6)
                DataAktual.Text = speed
                Me.Chart1.Series("Data").Points.AddXY(i, Convert.ToDouble(speed))
                i += 1
                Me.Chart1.ChartAreas("ChartArea1").AxisX.Minimum = i - 300   'shift x-axis
                Me.Chart1.ChartAreas("ChartArea1").AxisY.Maximum = 500 'adjust y-axis max value
                Me.Chart1.ChartAreas("ChartArea1").AxisY.Minimum = 0
                Me.Chart1.Series("Setpoint").Points.AddXY(i, SetPoint.Text)
            ElseIf (data_masuk.Substring(0, 5) = "temps") Then
                temps = data_masuk.Substring(5, Convert.ToInt32(length) - 6)
                DataAktual.Text = temps
                Me.Chart1.Series("Data").Points.AddXY(i, Convert.ToDouble(temps))
                i += 1
                Me.Chart1.ChartAreas("ChartArea1").AxisX.Minimum = i - 300  'shift x-axis
                Me.Chart1.ChartAreas("ChartArea1").AxisY.Maximum = 60 'adjust y-axis max value
                Me.Chart1.ChartAreas("ChartArea1").AxisY.Minimum = 20
                Me.Chart1.Series("Setpoint").Points.AddXY(i, SetPoint.Text)
            End If
        End If

    End Sub

    Private Sub BtnKirim_Click(sender As Object, e As EventArgs) Handles BtnKirim.Click
        SerialPort1.WriteLine("vs_set_point" + SetPoint.Text)
        SerialPort1.WriteLine("vs_kp" + TBKP.Text)
        SerialPort1.WriteLine("vs_ki" + TBKI.Text)
        SerialPort1.WriteLine("vs_kd" + TBKD.Text)
    End Sub

    Private Sub Close1_Click(sender As Object, e As EventArgs) Handles Close1.Click
        Dim response As Integer
        response = MessageBox.Show("Apakah anda ingin mematikan aplikasi?", "Matikan aplikasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnModul_Click(sender As Object, e As EventArgs) Handles BtnModul.Click
        Process.Start("www.youtube.com")
    End Sub

    Private Sub BtnMotor_Click(sender As Object, e As EventArgs) Handles BtnMotor.Click
        LSK.Text = "SET KECEPATAN (RPM)"
        LKA.Text = "KECEPATAN AKTUAL (RPM)"
        Label2.Text = "KONTROL MOTOR"
        LSK.Location = New Point(20, 4)
        LKA.Location = New Point(10, 4)
        Label2.Location = New Point(3, 3)
        BtnNyala.Visible = True
        BtnMati.Visible = True
    End Sub

    Private Sub BtnSuhu_Click(sender As Object, e As EventArgs) Handles BtnSuhu.Click
        LSK.Text = "SET SUHU (°C)"
        LKA.Text = "SUHU AKTUAL (°C)"
        Label2.Text = "KONTROL SUHU"
        LSK.Location = New Point(43, 4)
        LKA.Location = New Point(33, 4)
        Label2.Location = New Point(9, 3)
        BtnNyala.Visible = False
        BtnMati.Visible = False


    End Sub
    '---PROGRAM INTI
    'BAGIAN PANEL
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub

    Private Sub TBPerbesar_Click(sender As Object, e As EventArgs) Handles TBPerbesar.Click
        Chart1.Size = New Size(800, 473)
        Chart1.Location = New Point(0, 0)
        TbPerkecil.Visible = True
        TBPerbesar.Visible = False

    End Sub

    Private Sub TbPerkecil_Click(sender As Object, e As EventArgs) Handles TbPerkecil.Click
        Chart1.Size = New Size(582, 246)
        Chart1.Location = New Point(206, 215)
        TbPerkecil.Visible = False
        TBPerbesar.Visible = True
    End Sub

    '---BAGIAN PANEL

End Class
