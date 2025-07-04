Imports System.IO.Ports
Imports System.Drawing
Imports System.Diagnostics
Imports System.IO
Imports System.Linq

Public Class Form1

    Dim vpb_sy As Integer
    Dim SpeedResult As String
    Dim BatteryResult As String
    Dim TempResult As String
    Dim AmperResult As String ' Bu değişkenin içeriğinin doğrudan Wh olduğu varsayılıyor
    Dim StrSerialIn As String
    Dim ChartLimit As Integer = 30

    Dim CsvFolderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "arduinogui")
    Dim CsvFilePath As String = Path.Combine(CsvFolderPath, "TelemetryData.csv")

    Private Const TemperatureSeriesName As String = "Sıcaklık"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ConnectionPanel.Focus()
        CircularProgressBarSpeed.Value = 0
        ComboBoxBaudRate.SelectedIndex = 0

        If Not Directory.Exists(CsvFolderPath) Then
            Try
                Directory.CreateDirectory(CsvFolderPath)
            Catch ex As Exception
                MsgBox("Hedef klasör oluşturulamadı: " & ex.Message & Environment.NewLine & "Dosya uygulamayla aynı dizine kaydedilecektir.", MsgBoxStyle.Exclamation, "Klasör Oluşturma Hatası")
                CsvFilePath = "TelemetryData.csv"
                CsvFolderPath = ""
            End Try
        End If

        If Not File.Exists(CsvFilePath) OrElse New FileInfo(CsvFilePath).Length = 0 Then
            Using sw As New StreamWriter(CsvFilePath, True)
                sw.WriteLine("Timestamp,Speed(km/h),Voltage(V),Temperature(C),Watt-Hour(Wh)")
            End Using
        End If

        For i = 0 To ChartLimit Step 1
            If Not ChartTemperature.Series.Any(Function(s) s.Name = TemperatureSeriesName) Then
                ChartTemperature.Series.Add(TemperatureSeriesName)
                ChartTemperature.Series(TemperatureSeriesName).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                ChartTemperature.Series(TemperatureSeriesName).BorderWidth = 2
            End If
            ChartTemperature.Series(TemperatureSeriesName).Points.AddY(0)
            If ChartTemperature.Series(TemperatureSeriesName).Points.Count = ChartLimit Then
                ChartTemperature.Series(TemperatureSeriesName).Points.RemoveAt(0)
            End If
        Next
        ChartTemperature.ChartAreas(0).AxisY.Maximum = 40
        ChartTemperature.ChartAreas(0).AxisY.Minimum = 0
        ChartTemperature.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ConnectionPanel.Focus()
        If LabelStatus.Text = "Durum : Bağlı" Then
            MsgBox("Bağlantı devam ediyor, lütfen yeni portu taramak için bağlantıyı kesin.", MsgBoxStyle.Critical, "Uyarı !!!")
            Return
        End If

        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)

        If ComboBoxPort.Items.Count > 0 Then
            Try
                ComboBoxPort.SelectedIndex = 0
                ButtonConnect.Enabled = True
            Catch ex As Exception
                MsgBox("COM portu seçilirken bir hata oluştu: " & ex.Message, MsgBoxStyle.Critical, "Hata !!!")
                ComboBoxPort.Text = ""
                ComboBoxPort.Items.Clear()
                ButtonConnect.Enabled = False
            End Try
        Else
            MsgBox("COM port algılanamadı.", MsgBoxStyle.Critical, "Uyarı !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            ButtonConnect.Enabled = False
        End If
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ComboBoxPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPort.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub

    Private Sub ComboBoxPort_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPort.DropDown
        ConnectionPanel.Focus()
    End Sub

    Private Sub LinkLabel_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://deam.com.tr/")
    End Sub

    Private Sub TempBox_Click(sender As Object, e As EventArgs) Handles TempBox.Click

    End Sub

    Private Sub ComboBoxPort_Click(sender As Object, e As EventArgs) Handles ComboBoxPort.Click
        If LabelStatus.Text = "Durum : Bağlı" Then
            MsgBox("Bağlantı devam ediyor, COM portunu değiştirmek için lütfen bağlantıyı kesin.", MsgBoxStyle.Critical, "Uyarı !!!")
            Return
        End If
    End Sub

    Private Sub ComboBoxBaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub

    Private Sub ComboBoxBaudRate_DropDown(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.DropDown
        ConnectionPanel.Focus()
    End Sub

    Private Sub ComboBoxBaudRate_Click(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.Click
        If LabelStatus.Text = "Durum : Bağlı" Then
            MsgBox("Bağlantı devam ediyor, Baud Hızını değiştirmek için lütfen bağlantıyı kesin.", MsgBoxStyle.Critical, "Uyarı !!!")
            Return
        End If
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        ConnectionPanel.Focus()
        Try
            SerialPort1.BaudRate = CInt(ComboBoxBaudRate.SelectedItem)
            SerialPort1.PortName = ComboBoxPort.SelectedItem.ToString()
            SerialPort1.Open()
            TimerSerial.Start()

            LabelStatus.Text = "Durum : Bağlı"
            ButtonConnect.SendToBack()
            ButtonDisconnect.BringToFront()
            PictureBoxConnectionStatus.BackColor = Color.Green
        Catch ex As Exception
            MsgBox("Lütfen Donanımı, COM'u, Baud Hızını kontrol edin ve tekrar deneyin." & Environment.NewLine & "Hata: " & ex.Message, MsgBoxStyle.Critical, "Bağlantı başarısız !!!")
        End Try
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        ConnectionPanel.Focus()
        TimerSerial.Stop()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        ButtonDisconnect.SendToBack()
        ButtonConnect.BringToFront()
        LabelStatus.Text = "Durum : Bağlantı Kesildi"
        PictureBoxConnectionStatus.Visible = True
        PictureBoxConnectionStatus.BackColor = Color.Red
    End Sub

    Function MapBatt(ByVal X As Single, ByVal In_min As Single, ByVal In_max As Single, ByVal Out_min As Single, ByVal Out_max As Single) As Integer
        Dim mappedValue As Single
        mappedValue = ((X - In_min) * (Out_max - Out_min) / (In_max - In_min)) + Out_min
        Return CInt(mappedValue)
    End Function

    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            If Not SerialPort1.IsOpen Then
                TimerSerial.Stop()
                MsgBox("Seri port beklenmedik şekilde kapandı. Lütfen tekrar bağlanın.", MsgBoxStyle.Critical, "Seri Port Hatası")
                ButtonDisconnect_Click(Me, EventArgs.Empty)
                Return
            End If

            StrSerialIn = SerialPort1.ReadExisting

            Dim TB As New System.Windows.Forms.TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn

            SpeedResult = "0"
            BatteryResult = "0.0"
            TempResult = "0.0"
            AmperResult = "0" ' Bu değişkenin içeriği doğrudan Wh olarak kabul ediliyor

            If TB.Lines.Count > 0 Then
                If TB.Lines(0) = "Failed to read from Your Bot !" Then
                    TimerSerial.Stop()
                    If SerialPort1.IsOpen Then SerialPort1.Close()
                    LabelStatus.Text = "Durum : Bağlantı Kesildi"
                    ButtonDisconnect.SendToBack()
                    ButtonConnect.BringToFront()
                    PictureBoxConnectionStatus.BackColor = Color.Red
                    MsgBox("Bottan okuma başarısız !!! Lütfen Donanımı kontrol edin ve tekrar bağlanın.", MsgBoxStyle.Critical, "Bağlantı başarısız !!!")
                    Return
                End If

                For Each line As String In TB.Lines
                    If line.Length > 0 Then
                        Dim prefix As String = line.Substring(0, 1)
                        Select Case prefix
                            Case "S"
                                SpeedResult = line.Substring(1)
                            Case "B"
                                BatteryResult = line.Substring(1)
                            Case "T"
                                TempResult = line.Substring(1)
                            Case "M"
                                AmperResult = line.Substring(1)
                        End Select
                    End If
                Next

                If IsNumeric(SpeedResult) Then
                    CircularProgressBarSpeed.Value = CInt(SpeedResult)
                    CircularProgressBarSpeed.Text = CircularProgressBarSpeed.Value & " km/h"
                Else
                    CircularProgressBarSpeed.Value = 0
                    CircularProgressBarSpeed.Text = "0 km/h"
                End If

                If IsNumeric(TempResult) Then
                    If ChartTemperature.Series.Any(Function(s) s.Name = TemperatureSeriesName) Then
                        ChartTemperature.Series(TemperatureSeriesName).Points.AddY(CDbl(TempResult))
                        If ChartTemperature.Series(TemperatureSeriesName).Points.Count = ChartLimit Then
                            ChartTemperature.Series(TemperatureSeriesName).Points.RemoveAt(0)
                        End If
                    End If
                Else
                    If ChartTemperature.Series.Any(Function(s) s.Name = TemperatureSeriesName) Then
                        ChartTemperature.Series(TemperatureSeriesName).Points.AddY(0)
                        If ChartTemperature.Series(TemperatureSeriesName).Points.Count = ChartLimit Then
                            ChartTemperature.Series(TemperatureSeriesName).Points.RemoveAt(0)
                        End If
                    End If
                End If

                TempBox.Text = TempResult & " *C"

                Dim batteryVolts As Single = 0
                If IsNumeric(BatteryResult) Then
                    batteryVolts = CSng(BatteryResult)
                    BatteryVolt.Text = BatteryResult & " V"
                Else
                    BatteryVolt.Text = "0.0 V"
                End If

                If IsNumeric(AmperResult) Then
                    LabelAmper.Text = AmperResult & " Wh"
                Else
                    LabelAmper.Text = "0 Wh"
                End If

                vpb_sy = MapBatt(batteryVolts, 0, 24, 0, 120)

                If vpb_sy > 120 Then
                    vpb_sy = 120
                ElseIf vpb_sy < 0 Then
                    vpb_sy = 0
                End If

                PictureBoxBatteryFront.Height = CInt(PictureBoxBatteryBack.Height * vpb_sy / 120)
                PictureBoxBatteryFront.Location = New Point(PictureBoxBatteryFront.Location.X, PictureBoxBatteryBack.Location.Y)

                If PictureBoxConnectionStatus.Visible = True Then
                    PictureBoxConnectionStatus.Visible = False
                ElseIf PictureBoxConnectionStatus.Visible = False Then
                    PictureBoxConnectionStatus.Visible = True
                End If

                If SerialPort1.IsOpen AndAlso IsNumeric(SpeedResult) AndAlso IsNumeric(BatteryResult) AndAlso IsNumeric(TempResult) AndAlso IsNumeric(AmperResult) Then
                    Try
                        Using sw As New StreamWriter(CsvFilePath, True)
                            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            Dim dataLine As String = String.Format("{0},{1},{2},{3},{4}", timestamp, SpeedResult, BatteryResult, TempResult, AmperResult.ToString(System.Globalization.CultureInfo.InvariantCulture))
                            sw.WriteLine(dataLine)
                        End Using
                    Catch ex As Exception
                    End Try
                End If

            End If
        Catch ex As Exception
            TimerSerial.Stop()
            If SerialPort1.IsOpen Then SerialPort1.Close()
            LabelStatus.Text = "Durum : Bağlantı Kesildi"
            ButtonDisconnect.SendToBack()
            ButtonConnect.BringToFront()
            PictureBoxConnectionStatus.BackColor = Color.Red
            MsgBox("Lütfen Donanımı kontrol edin ve tekrar bağlanın." & Environment.NewLine & "Hata Mesajı: " & ex.Message, MsgBoxStyle.Critical, "Bağlantı başarısız !!!")
        End Try
    End Sub
End Class