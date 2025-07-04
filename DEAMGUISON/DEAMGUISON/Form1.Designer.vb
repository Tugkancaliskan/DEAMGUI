<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ConnectionPanel = New System.Windows.Forms.Panel()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.LabelBaudRate = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ConnectionTitle = New System.Windows.Forms.Label()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.SpeedPanel = New System.Windows.Forms.Panel()
        Me.CircularProgressBarSpeed = New CircularProgressBar.CircularProgressBar()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.BatteryPanel = New System.Windows.Forms.Panel()
        Me.LabelAmper = New System.Windows.Forms.Label()
        Me.BatteryVolt = New System.Windows.Forms.Label()
        Me.PictureBoxBatteryFront = New System.Windows.Forms.PictureBox()
        Me.PictureBoxBatteryBack = New System.Windows.Forms.PictureBox()
        Me.BatteryLabel = New System.Windows.Forms.Label()
        Me.BatteryTop = New System.Windows.Forms.PictureBox()
        Me.ChartTemperature = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.PictureBoxConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.TempBox = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConnectionPanel.SuspendLayout()
        Me.SpeedPanel.SuspendLayout()
        Me.BatteryPanel.SuspendLayout()
        CType(Me.PictureBoxBatteryFront, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBatteryBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatteryTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartTemperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionPanel
        '
        Me.ConnectionPanel.BackColor = System.Drawing.Color.White
        Me.ConnectionPanel.Controls.Add(Me.ComboBoxBaudRate)
        Me.ConnectionPanel.Controls.Add(Me.LabelBaudRate)
        Me.ConnectionPanel.Controls.Add(Me.ComboBoxPort)
        Me.ConnectionPanel.Controls.Add(Me.ButtonScanPort)
        Me.ConnectionPanel.Controls.Add(Me.ConnectionTitle)
        Me.ConnectionPanel.Controls.Add(Me.ButtonConnect)
        Me.ConnectionPanel.Controls.Add(Me.ButtonDisconnect)
        Me.ConnectionPanel.Location = New System.Drawing.Point(12, 12)
        Me.ConnectionPanel.Name = "ConnectionPanel"
        Me.ConnectionPanel.Size = New System.Drawing.Size(220, 187)
        Me.ConnectionPanel.TabIndex = 0
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.BackColor = System.Drawing.Color.DimGray
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxBaudRate.ForeColor = System.Drawing.Color.White
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(92, 90)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxBaudRate.TabIndex = 4
        '
        'LabelBaudRate
        '
        Me.LabelBaudRate.AutoSize = True
        Me.LabelBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBaudRate.Location = New System.Drawing.Point(11, 93)
        Me.LabelBaudRate.Name = "LabelBaudRate"
        Me.LabelBaudRate.Size = New System.Drawing.Size(80, 16)
        Me.LabelBaudRate.TabIndex = 3
        Me.LabelBaudRate.Text = "Baud Rate"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.BackColor = System.Drawing.Color.DimGray
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxPort.ForeColor = System.Drawing.Color.White
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(92, 55)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxPort.TabIndex = 2
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.Color.DimGray
        Me.ButtonScanPort.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonScanPort.Location = New System.Drawing.Point(11, 54)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 25)
        Me.ButtonScanPort.TabIndex = 1
        Me.ButtonScanPort.Text = "Tara"
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'ConnectionTitle
        '
        Me.ConnectionTitle.AutoSize = True
        Me.ConnectionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ConnectionTitle.Location = New System.Drawing.Point(36, 14)
        Me.ConnectionTitle.Name = "ConnectionTitle"
        Me.ConnectionTitle.Size = New System.Drawing.Size(156, 25)
        Me.ConnectionTitle.TabIndex = 0
        Me.ConnectionTitle.Text = "Bağlantı Paneli"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.White
        Me.ButtonConnect.Location = New System.Drawing.Point(36, 124)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(143, 42)
        Me.ButtonConnect.TabIndex = 5
        Me.ButtonConnect.Text = "Bağlan"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ButtonDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonDisconnect.ForeColor = System.Drawing.Color.White
        Me.ButtonDisconnect.Location = New System.Drawing.Point(36, 124)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(143, 39)
        Me.ButtonDisconnect.TabIndex = 6
        Me.ButtonDisconnect.Text = "Bağlantıyı Kes"
        Me.ButtonDisconnect.UseVisualStyleBackColor = False
        '
        'SpeedPanel
        '
        Me.SpeedPanel.BackColor = System.Drawing.Color.White
        Me.SpeedPanel.Controls.Add(Me.CircularProgressBarSpeed)
        Me.SpeedPanel.Controls.Add(Me.LabelSpeed)
        Me.SpeedPanel.Location = New System.Drawing.Point(238, 12)
        Me.SpeedPanel.Name = "SpeedPanel"
        Me.SpeedPanel.Size = New System.Drawing.Size(208, 187)
        Me.SpeedPanel.TabIndex = 1
        '
        'CircularProgressBarSpeed
        '
        Me.CircularProgressBarSpeed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBarSpeed.AnimationSpeed = 500
        Me.CircularProgressBarSpeed.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBarSpeed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBarSpeed.InnerColor = System.Drawing.Color.White
        Me.CircularProgressBarSpeed.InnerMargin = 2
        Me.CircularProgressBarSpeed.InnerWidth = -1
        Me.CircularProgressBarSpeed.Location = New System.Drawing.Point(39, 31)
        Me.CircularProgressBarSpeed.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBarSpeed.Name = "CircularProgressBarSpeed"
        Me.CircularProgressBarSpeed.OuterColor = System.Drawing.Color.Gray
        Me.CircularProgressBarSpeed.OuterMargin = -25
        Me.CircularProgressBarSpeed.OuterWidth = 26
        Me.CircularProgressBarSpeed.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBarSpeed.ProgressWidth = 25
        Me.CircularProgressBarSpeed.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBarSpeed.Size = New System.Drawing.Size(135, 135)
        Me.CircularProgressBarSpeed.StartAngle = 270
        Me.CircularProgressBarSpeed.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarSpeed.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBarSpeed.SubscriptText = ""
        Me.CircularProgressBarSpeed.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarSpeed.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBarSpeed.SuperscriptText = ""
        Me.CircularProgressBarSpeed.TabIndex = 1
        Me.CircularProgressBarSpeed.Text = "00 km/h"
        Me.CircularProgressBarSpeed.TextMargin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.CircularProgressBarSpeed.Value = 68
        '
        'LabelSpeed
        '
        Me.LabelSpeed.AutoSize = True
        Me.LabelSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSpeed.Location = New System.Drawing.Point(75, 7)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(43, 25)
        Me.LabelSpeed.TabIndex = 0
        Me.LabelSpeed.Text = "Hız"
        '
        'BatteryPanel
        '
        Me.BatteryPanel.BackColor = System.Drawing.Color.White
        Me.BatteryPanel.Controls.Add(Me.LabelAmper)
        Me.BatteryPanel.Controls.Add(Me.BatteryVolt)
        Me.BatteryPanel.Controls.Add(Me.PictureBoxBatteryFront)
        Me.BatteryPanel.Controls.Add(Me.PictureBoxBatteryBack)
        Me.BatteryPanel.Controls.Add(Me.BatteryLabel)
        Me.BatteryPanel.Controls.Add(Me.BatteryTop)
        Me.BatteryPanel.Location = New System.Drawing.Point(452, 12)
        Me.BatteryPanel.Name = "BatteryPanel"
        Me.BatteryPanel.Size = New System.Drawing.Size(288, 186)
        Me.BatteryPanel.TabIndex = 2
        '
        'LabelAmper
        '
        Me.LabelAmper.AutoSize = True
        Me.LabelAmper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAmper.Location = New System.Drawing.Point(126, 114)
        Me.LabelAmper.Name = "LabelAmper"
        Me.LabelAmper.Size = New System.Drawing.Size(58, 24)
        Me.LabelAmper.TabIndex = 5
        Me.LabelAmper.Text = "0 Wh"
        '
        'BatteryVolt
        '
        Me.BatteryVolt.AutoSize = True
        Me.BatteryVolt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BatteryVolt.Location = New System.Drawing.Point(126, 85)
        Me.BatteryVolt.Name = "BatteryVolt"
        Me.BatteryVolt.Size = New System.Drawing.Size(41, 24)
        Me.BatteryVolt.TabIndex = 4
        Me.BatteryVolt.Text = "0 V"
        '
        'PictureBoxBatteryFront
        '
        Me.PictureBoxBatteryFront.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBoxBatteryFront.Location = New System.Drawing.Point(63, 60)
        Me.PictureBoxBatteryFront.Name = "PictureBoxBatteryFront"
        Me.PictureBoxBatteryFront.Size = New System.Drawing.Size(46, 103)
        Me.PictureBoxBatteryFront.TabIndex = 3
        Me.PictureBoxBatteryFront.TabStop = False
        '
        'PictureBoxBatteryBack
        '
        Me.PictureBoxBatteryBack.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBoxBatteryBack.Location = New System.Drawing.Point(63, 44)
        Me.PictureBoxBatteryBack.Name = "PictureBoxBatteryBack"
        Me.PictureBoxBatteryBack.Size = New System.Drawing.Size(46, 119)
        Me.PictureBoxBatteryBack.TabIndex = 1
        Me.PictureBoxBatteryBack.TabStop = False
        '
        'BatteryLabel
        '
        Me.BatteryLabel.AutoSize = True
        Me.BatteryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BatteryLabel.Location = New System.Drawing.Point(45, 11)
        Me.BatteryLabel.Name = "BatteryLabel"
        Me.BatteryLabel.Size = New System.Drawing.Size(86, 25)
        Me.BatteryLabel.TabIndex = 0
        Me.BatteryLabel.Text = "Batarya"
        '
        'BatteryTop
        '
        Me.BatteryTop.BackColor = System.Drawing.Color.DarkGray
        Me.BatteryTop.Location = New System.Drawing.Point(77, 38)
        Me.BatteryTop.Name = "BatteryTop"
        Me.BatteryTop.Size = New System.Drawing.Size(18, 10)
        Me.BatteryTop.TabIndex = 2
        Me.BatteryTop.TabStop = False
        '
        'ChartTemperature
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartTemperature.ChartAreas.Add(ChartArea2)
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Legend2.ForeColor = System.Drawing.Color.DimGray
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.ChartTemperature.Legends.Add(Legend2)
        Me.ChartTemperature.Location = New System.Drawing.Point(12, 205)
        Me.ChartTemperature.Name = "ChartTemperature"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series2.Legend = "Legend1"
        Series2.Name = "Sıcaklık"
        Me.ChartTemperature.Series.Add(Series2)
        Me.ChartTemperature.Size = New System.Drawing.Size(728, 180)
        Me.ChartTemperature.TabIndex = 3
        Me.ChartTemperature.Text = "Chart1"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(20, 399)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(119, 15)
        Me.LabelStatus.TabIndex = 4
        Me.LabelStatus.Text = "Durum: Bağlantı Yok"
        '
        'PictureBoxConnectionStatus
        '
        Me.PictureBoxConnectionStatus.BackColor = System.Drawing.Color.Red
        Me.PictureBoxConnectionStatus.Location = New System.Drawing.Point(148, 404)
        Me.PictureBoxConnectionStatus.Name = "PictureBoxConnectionStatus"
        Me.PictureBoxConnectionStatus.Size = New System.Drawing.Size(503, 10)
        Me.PictureBoxConnectionStatus.TabIndex = 5
        Me.PictureBoxConnectionStatus.TabStop = False
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'TimerSerial
        '
        '
        'TempBox
        '
        Me.TempBox.AutoSize = True
        Me.TempBox.BackColor = System.Drawing.Color.White
        Me.TempBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TempBox.Location = New System.Drawing.Point(624, 282)
        Me.TempBox.Name = "TempBox"
        Me.TempBox.Size = New System.Drawing.Size(51, 25)
        Me.TempBox.TabIndex = 6
        Me.TempBox.Text = "0 *C"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(615, 428)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(46, 16)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "DEAM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(561, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 487)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TempBox)
        Me.Controls.Add(Me.PictureBoxConnectionStatus)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.ChartTemperature)
        Me.Controls.Add(Me.BatteryPanel)
        Me.Controls.Add(Me.SpeedPanel)
        Me.Controls.Add(Me.ConnectionPanel)
        Me.Name = "Form1"
        Me.Text = "Telemetri İzleme Sistemi"
        Me.ConnectionPanel.ResumeLayout(False)
        Me.ConnectionPanel.PerformLayout()
        Me.SpeedPanel.ResumeLayout(False)
        Me.SpeedPanel.PerformLayout()
        Me.BatteryPanel.ResumeLayout(False)
        Me.BatteryPanel.PerformLayout()
        CType(Me.PictureBoxBatteryFront, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBatteryBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatteryTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartTemperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectionPanel As Panel
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ConnectionTitle As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents LabelBaudRate As Label
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents SpeedPanel As Panel
    Friend WithEvents LabelSpeed As Label
    Friend WithEvents CircularProgressBarSpeed As CircularProgressBar.CircularProgressBar
    Friend WithEvents BatteryPanel As Panel
    Friend WithEvents PictureBoxBatteryBack As PictureBox
    Friend WithEvents BatteryLabel As Label
    Friend WithEvents PictureBoxBatteryFront As PictureBox
    Friend WithEvents BatteryTop As PictureBox
    Friend WithEvents BatteryVolt As Label
    Friend WithEvents ChartTemperature As DataVisualization.Charting.Chart
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PictureBoxConnectionStatus As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents TempBox As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LabelAmper As Label
    Friend WithEvents Label1 As Label
End Class
