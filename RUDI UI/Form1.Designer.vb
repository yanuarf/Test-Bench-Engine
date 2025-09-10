<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupConnection = New System.Windows.Forms.GroupBox()
        Me.Connect = New System.Windows.Forms.Button()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.Scanport = New System.Windows.Forms.Button()
        Me.Disconnect = New System.Windows.Forms.Button()
        Me.GroupThrotle = New System.Windows.Forms.GroupBox()
        Me.ThrotleValue = New System.Windows.Forms.Label()
        Me.TrackBarThrotle = New System.Windows.Forms.TrackBar()
        Me.GroupData = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelRPM = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTorque = New System.Windows.Forms.Label()
        Me.LabelThrust = New System.Windows.Forms.Label()
        Me.LabelTemp = New System.Windows.Forms.Label()
        Me.LabelDaya = New System.Windows.Forms.Label()
        Me.LabelCurrent = New System.Windows.Forms.Label()
        Me.LabelVoltage = New System.Windows.Forms.Label()
        Me.GroupInfo = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ChartThrust = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartTemperature = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartRPM = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupConnection.SuspendLayout()
        Me.GroupThrotle.SuspendLayout()
        CType(Me.TrackBarThrotle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupData.SuspendLayout()
        Me.GroupInfo.SuspendLayout()
        CType(Me.ChartThrust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartTemperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartRPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupConnection
        '
        Me.GroupConnection.Controls.Add(Me.Connect)
        Me.GroupConnection.Controls.Add(Me.ComboBoxPort)
        Me.GroupConnection.Controls.Add(Me.Scanport)
        Me.GroupConnection.Controls.Add(Me.Disconnect)
        Me.GroupConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupConnection.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupConnection.Location = New System.Drawing.Point(112, 154)
        Me.GroupConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupConnection.Name = "GroupConnection"
        Me.GroupConnection.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupConnection.Size = New System.Drawing.Size(396, 123)
        Me.GroupConnection.TabIndex = 0
        Me.GroupConnection.TabStop = False
        Me.GroupConnection.Text = "Connection"
        '
        'Connect
        '
        Me.Connect.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Connect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Connect.Location = New System.Drawing.Point(275, 40)
        Me.Connect.Margin = New System.Windows.Forms.Padding(4)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(113, 34)
        Me.Connect.TabIndex = 2
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = False
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.BackColor = System.Drawing.SystemColors.Menu
        Me.ComboBoxPort.Cursor = System.Windows.Forms.Cursors.No
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(132, 46)
        Me.ComboBoxPort.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(129, 24)
        Me.ComboBoxPort.TabIndex = 1
        '
        'Scanport
        '
        Me.Scanport.BackColor = System.Drawing.Color.Orange
        Me.Scanport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scanport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Scanport.Location = New System.Drawing.Point(20, 41)
        Me.Scanport.Margin = New System.Windows.Forms.Padding(4)
        Me.Scanport.Name = "Scanport"
        Me.Scanport.Size = New System.Drawing.Size(100, 34)
        Me.Scanport.TabIndex = 1
        Me.Scanport.Text = "Scan Port"
        Me.Scanport.UseVisualStyleBackColor = False
        '
        'Disconnect
        '
        Me.Disconnect.BackColor = System.Drawing.Color.Firebrick
        Me.Disconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Disconnect.Location = New System.Drawing.Point(275, 41)
        Me.Disconnect.Margin = New System.Windows.Forms.Padding(4)
        Me.Disconnect.Name = "Disconnect"
        Me.Disconnect.Size = New System.Drawing.Size(113, 34)
        Me.Disconnect.TabIndex = 3
        Me.Disconnect.Text = "Disconnect"
        Me.Disconnect.UseVisualStyleBackColor = False
        '
        'GroupThrotle
        '
        Me.GroupThrotle.Controls.Add(Me.ThrotleValue)
        Me.GroupThrotle.Controls.Add(Me.TrackBarThrotle)
        Me.GroupThrotle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupThrotle.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupThrotle.Location = New System.Drawing.Point(112, 289)
        Me.GroupThrotle.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupThrotle.Name = "GroupThrotle"
        Me.GroupThrotle.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupThrotle.Size = New System.Drawing.Size(396, 123)
        Me.GroupThrotle.TabIndex = 4
        Me.GroupThrotle.TabStop = False
        Me.GroupThrotle.Text = "Throtle Control"
        '
        'ThrotleValue
        '
        Me.ThrotleValue.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ThrotleValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ThrotleValue.ForeColor = System.Drawing.Color.White
        Me.ThrotleValue.Location = New System.Drawing.Point(317, 41)
        Me.ThrotleValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ThrotleValue.Name = "ThrotleValue"
        Me.ThrotleValue.Padding = New System.Windows.Forms.Padding(8, 4, 0, 0)
        Me.ThrotleValue.Size = New System.Drawing.Size(60, 28)
        Me.ThrotleValue.TabIndex = 5
        Me.ThrotleValue.Text = "00"
        '
        'TrackBarThrotle
        '
        Me.TrackBarThrotle.Location = New System.Drawing.Point(20, 41)
        Me.TrackBarThrotle.Margin = New System.Windows.Forms.Padding(4)
        Me.TrackBarThrotle.Maximum = 100
        Me.TrackBarThrotle.Name = "TrackBarThrotle"
        Me.TrackBarThrotle.Size = New System.Drawing.Size(289, 56)
        Me.TrackBarThrotle.TabIndex = 5
        '
        'GroupData
        '
        Me.GroupData.Controls.Add(Me.Label14)
        Me.GroupData.Controls.Add(Me.Label13)
        Me.GroupData.Controls.Add(Me.Label12)
        Me.GroupData.Controls.Add(Me.Label11)
        Me.GroupData.Controls.Add(Me.Label10)
        Me.GroupData.Controls.Add(Me.Label9)
        Me.GroupData.Controls.Add(Me.Label8)
        Me.GroupData.Controls.Add(Me.Label7)
        Me.GroupData.Controls.Add(Me.Label6)
        Me.GroupData.Controls.Add(Me.Label5)
        Me.GroupData.Controls.Add(Me.Label3)
        Me.GroupData.Controls.Add(Me.Label2)
        Me.GroupData.Controls.Add(Me.Label1)
        Me.GroupData.Controls.Add(Me.LabelRPM)
        Me.GroupData.Controls.Add(Me.Label4)
        Me.GroupData.Controls.Add(Me.LabelTorque)
        Me.GroupData.Controls.Add(Me.LabelThrust)
        Me.GroupData.Controls.Add(Me.LabelTemp)
        Me.GroupData.Controls.Add(Me.LabelDaya)
        Me.GroupData.Controls.Add(Me.LabelCurrent)
        Me.GroupData.Controls.Add(Me.LabelVoltage)
        Me.GroupData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupData.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupData.Location = New System.Drawing.Point(112, 422)
        Me.GroupData.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupData.Name = "GroupData"
        Me.GroupData.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupData.Size = New System.Drawing.Size(396, 372)
        Me.GroupData.TabIndex = 6
        Me.GroupData.TabStop = False
        Me.GroupData.Text = "Live Data"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(285, 312)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 23)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Rpm"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(285, 266)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 23)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Nm"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(285, 223)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 23)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Gram"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(285, 132)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 23)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Watt"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(285, 178)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 23)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "°C"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(285, 84)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 23)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "A"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(285, 45)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "V"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(51, 308)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 28)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "RPM     :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(51, 262)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 28)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Torque  :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(51, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 28)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Thrust   :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(51, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 28)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Temp     :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(51, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 28)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Daya     :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(51, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 28)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Current  :"
        '
        'LabelRPM
        '
        Me.LabelRPM.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelRPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRPM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelRPM.Location = New System.Drawing.Point(163, 308)
        Me.LabelRPM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRPM.Name = "LabelRPM"
        Me.LabelRPM.Padding = New System.Windows.Forms.Padding(11, 4, 0, 0)
        Me.LabelRPM.Size = New System.Drawing.Size(104, 27)
        Me.LabelRPM.TabIndex = 16
        Me.LabelRPM.Text = "00"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(51, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 28)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Voltage  :"
        '
        'LabelTorque
        '
        Me.LabelTorque.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelTorque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTorque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelTorque.Location = New System.Drawing.Point(163, 262)
        Me.LabelTorque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTorque.Name = "LabelTorque"
        Me.LabelTorque.Padding = New System.Windows.Forms.Padding(11, 4, 0, 0)
        Me.LabelTorque.Size = New System.Drawing.Size(104, 27)
        Me.LabelTorque.TabIndex = 14
        Me.LabelTorque.Text = "00"
        '
        'LabelThrust
        '
        Me.LabelThrust.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelThrust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelThrust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelThrust.Location = New System.Drawing.Point(163, 219)
        Me.LabelThrust.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelThrust.Name = "LabelThrust"
        Me.LabelThrust.Padding = New System.Windows.Forms.Padding(11, 4, 0, 0)
        Me.LabelThrust.Size = New System.Drawing.Size(104, 27)
        Me.LabelThrust.TabIndex = 15
        Me.LabelThrust.Text = "00"
        '
        'LabelTemp
        '
        Me.LabelTemp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelTemp.Location = New System.Drawing.Point(163, 174)
        Me.LabelTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTemp.Name = "LabelTemp"
        Me.LabelTemp.Padding = New System.Windows.Forms.Padding(11, 4, 0, 0)
        Me.LabelTemp.Size = New System.Drawing.Size(104, 27)
        Me.LabelTemp.TabIndex = 14
        Me.LabelTemp.Text = "00"
        '
        'LabelDaya
        '
        Me.LabelDaya.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelDaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDaya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelDaya.Location = New System.Drawing.Point(163, 127)
        Me.LabelDaya.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDaya.Name = "LabelDaya"
        Me.LabelDaya.Padding = New System.Windows.Forms.Padding(11, 4, 0, 0)
        Me.LabelDaya.Size = New System.Drawing.Size(104, 27)
        Me.LabelDaya.TabIndex = 13
        Me.LabelDaya.Text = "00"
        '
        'LabelCurrent
        '
        Me.LabelCurrent.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelCurrent.Location = New System.Drawing.Point(163, 84)
        Me.LabelCurrent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCurrent.Name = "LabelCurrent"
        Me.LabelCurrent.Padding = New System.Windows.Forms.Padding(11, 4, 0, 0)
        Me.LabelCurrent.Size = New System.Drawing.Size(104, 27)
        Me.LabelCurrent.TabIndex = 12
        Me.LabelCurrent.Text = "00"
        '
        'LabelVoltage
        '
        Me.LabelVoltage.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelVoltage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVoltage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelVoltage.Location = New System.Drawing.Point(163, 41)
        Me.LabelVoltage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVoltage.Name = "LabelVoltage"
        Me.LabelVoltage.Padding = New System.Windows.Forms.Padding(11, 4, 0, 0)
        Me.LabelVoltage.Size = New System.Drawing.Size(104, 27)
        Me.LabelVoltage.TabIndex = 11
        Me.LabelVoltage.Text = "00"
        '
        'GroupInfo
        '
        Me.GroupInfo.Controls.Add(Me.Label16)
        Me.GroupInfo.Controls.Add(Me.Label15)
        Me.GroupInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupInfo.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupInfo.Location = New System.Drawing.Point(112, 797)
        Me.GroupInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupInfo.Name = "GroupInfo"
        Me.GroupInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupInfo.Size = New System.Drawing.Size(1139, 149)
        Me.GroupInfo.TabIndex = 7
        Me.GroupInfo.TabStop = False
        Me.GroupInfo.Text = "Device Info"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(39, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(176, 20)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Current Sensor : 100A"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(39, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(198, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Controller          :  ESP32"
        '
        'ChartThrust
        '
        Me.ChartThrust.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.Name = "ChartArea1"
        Me.ChartThrust.ChartAreas.Add(ChartArea1)
        Me.ChartThrust.ImeMode = System.Windows.Forms.ImeMode.Off
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Legend1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Legend1.InterlacedRows = True
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.ChartThrust.Legends.Add(Legend1)
        Me.ChartThrust.Location = New System.Drawing.Point(551, 151)
        Me.ChartThrust.Margin = New System.Windows.Forms.Padding(4)
        Me.ChartThrust.Name = "ChartThrust"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.LabelForeColor = System.Drawing.Color.DeepSkyBlue
        Series1.Legend = "Legend1"
        Series1.Name = "Thrust            "
        Me.ChartThrust.Series.Add(Series1)
        Me.ChartThrust.Size = New System.Drawing.Size(873, 204)
        Me.ChartThrust.TabIndex = 8
        Me.ChartThrust.Text = "Thrush"
        '
        'ChartTemperature
        '
        Me.ChartTemperature.BackColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX2.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX2.TitleForeColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisY.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.Name = "ChartArea1"
        Me.ChartTemperature.ChartAreas.Add(ChartArea2)
        Me.ChartTemperature.ImeMode = System.Windows.Forms.ImeMode.Off
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Legend2.ForeColor = System.Drawing.Color.SandyBrown
        Legend2.InterlacedRows = True
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.ChartTemperature.Legends.Add(Legend2)
        Me.ChartTemperature.Location = New System.Drawing.Point(547, 363)
        Me.ChartTemperature.Margin = New System.Windows.Forms.Padding(4)
        Me.ChartTemperature.Name = "ChartTemperature"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series2.LabelForeColor = System.Drawing.Color.SpringGreen
        Series2.Legend = "Legend1"
        Series2.Name = "Temperature"
        Me.ChartTemperature.Series.Add(Series2)
        Me.ChartTemperature.Size = New System.Drawing.Size(873, 204)
        Me.ChartTemperature.TabIndex = 9
        Me.ChartTemperature.Text = "Temperature"
        '
        'ChartRPM
        '
        Me.ChartRPM.BackColor = System.Drawing.Color.Transparent
        ChartArea3.AxisX.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisX2.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisX2.TitleForeColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisY.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.Name = "ChartArea1"
        Me.ChartRPM.ChartAreas.Add(ChartArea3)
        Me.ChartRPM.ImeMode = System.Windows.Forms.ImeMode.Off
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Legend3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Legend3.InterlacedRows = True
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.ChartRPM.Legends.Add(Legend3)
        Me.ChartRPM.Location = New System.Drawing.Point(533, 574)
        Me.ChartRPM.Margin = New System.Windows.Forms.Padding(4)
        Me.ChartRPM.Name = "ChartRPM"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series3.LabelForeColor = System.Drawing.Color.SpringGreen
        Series3.Legend = "Legend1"
        Series3.Name = "RPM               "
        Me.ChartRPM.Series.Add(Series3)
        Me.ChartRPM.Size = New System.Drawing.Size(893, 204)
        Me.ChartRPM.TabIndex = 10
        Me.ChartRPM.Text = "RPM"
        '
        'TimerSerial
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RUDI_UI.My.Resources.Resources.icon
        Me.PictureBox2.Location = New System.Drawing.Point(269, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(136, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RUDI_UI.My.Resources.Resources.heading
        Me.PictureBox1.Location = New System.Drawing.Point(431, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(715, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.RUDI_UI.My.Resources.Resources.icon
        Me.PictureBox3.Location = New System.Drawing.Point(1165, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(136, 94)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1532, 951)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ChartRPM)
        Me.Controls.Add(Me.ChartTemperature)
        Me.Controls.Add(Me.ChartThrust)
        Me.Controls.Add(Me.GroupInfo)
        Me.Controls.Add(Me.GroupData)
        Me.Controls.Add(Me.GroupThrotle)
        Me.Controls.Add(Me.GroupConnection)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "UI MOTOR TEST"
        Me.GroupConnection.ResumeLayout(False)
        Me.GroupThrotle.ResumeLayout(False)
        Me.GroupThrotle.PerformLayout()
        CType(Me.TrackBarThrotle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupData.ResumeLayout(False)
        Me.GroupInfo.ResumeLayout(False)
        Me.GroupInfo.PerformLayout()
        CType(Me.ChartThrust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartTemperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartRPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupConnection As GroupBox
    Friend WithEvents Connect As Button
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents Scanport As Button
    Friend WithEvents Disconnect As Button
    Friend WithEvents GroupThrotle As GroupBox
    Friend WithEvents TrackBarThrotle As TrackBar
    Friend WithEvents ThrotleValue As Label
    Friend WithEvents GroupData As GroupBox
    Friend WithEvents GroupInfo As GroupBox
    Friend WithEvents ChartThrust As DataVisualization.Charting.Chart
    Friend WithEvents ChartTemperature As DataVisualization.Charting.Chart
    Friend WithEvents ChartRPM As DataVisualization.Charting.Chart
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents LabelDaya As Label
    Friend WithEvents LabelCurrent As Label
    Friend WithEvents LabelVoltage As Label
    Friend WithEvents LabelTorque As Label
    Friend WithEvents LabelThrust As Label
    Friend WithEvents LabelTemp As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelRPM As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
