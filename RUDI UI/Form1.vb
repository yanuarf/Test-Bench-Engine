Imports System
Imports System.IO.Ports
Imports System.IO

Public Class Form1
    Dim vpb_sy, vpb_ly As Integer
    Dim VoltageL, CurrentL, DayaL As Integer
    Dim TempL, RpmL, ThrustL, TorqueL As Integer
    Dim Voltage, Current, Daya, VoltageResult, CurrentResult, DayaResult As String
    Dim Temp, Rpm, Thrust, Torque, TempResult, RpmResult, ThrustResult, TorqueResult As String
    Dim TempToProgressBar As Single
    Dim ChartLimit As Integer = 30
    Dim StrSerialIn, StrSerialInRam As String
    Dim csvFilePath As String
    Dim csvWriter As StreamWriter = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        GroupConnection.Focus()
        GroupThrotle.Enabled = False
        GroupData.Enabled = False

        For i = 0 To 30 Step 1
            ChartThrust.Series("Thrust            ").Points.AddY(0)
            If ChartThrust.Series(0).Points.Count = ChartLimit Then
                ChartThrust.Series(0).Points.RemoveAt(0)
            End If

            ChartTemperature.Series("Temperature").Points.AddY(0)
            If ChartTemperature.Series(0).Points.Count = ChartLimit Then
                ChartTemperature.Series(0).Points.RemoveAt(0)
            End If

            ChartRPM.Series("RPM               ").Points.AddY(0)
            If ChartRPM.Series(0).Points.Count = ChartLimit Then
                ChartRPM.Series(0).Points.RemoveAt(0)
            End If
        Next

        ChartThrust.ChartAreas(0).AxisY.Maximum = 100
        ChartThrust.ChartAreas(0).AxisY.Minimum = 0
        ChartThrust.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        ChartTemperature.ChartAreas(0).AxisY.Maximum = 100
        ChartTemperature.ChartAreas(0).AxisY.Minimum = -10
        ChartTemperature.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        ChartRPM.ChartAreas(0).AxisY.Maximum = 10000
        ChartRPM.ChartAreas(0).AxisY.Minimum = 0
        ChartRPM.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

    End Sub

    Private Sub ComboBoxPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPort.SelectedIndexChanged
        GroupConnection.Focus()
    End Sub

    Private Sub ComboBoxPort_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPort.DropDown
        GroupConnection.Focus()
    End Sub

    Private Sub Scanport_Click(sender As Object, e As EventArgs) Handles Scanport.Click
        GroupConnection.Focus()
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            Connect.Enabled = True
        Catch ex As Exception
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        GroupConnection.Focus()
        GroupThrotle.Enabled = True
        GroupData.Enabled = True
        Try
            SerialPort1.BaudRate = 115200
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            SerialPort1.Open()
            TimerSerial.Start()

            ' Create unique CSV filename with datetime
            Dim timestampFile As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
            csvFilePath = $"data_log_{timestampFile}.csv"
            csvWriter = New StreamWriter(csvFilePath, False)
            ' Write header with timestamp and label names
            csvWriter.WriteLine("Timestamp,ThrotleValue,Voltage,Current,Daya,Temp,Thrust,Torque,RPM")
            csvWriter.Flush()

            Connect.SendToBack()
            Disconnect.BringToFront()
        Catch ex As Exception
            MsgBox("Please check the Hardware, COM, Baud Rate and try again.", MsgBoxStyle.Critical, "Connection failed !!!")
        End Try
    End Sub

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles Disconnect.Click
        GroupConnection.Focus()
        GroupThrotle.Enabled = False
        GroupData.Enabled = False
        TimerSerial.Stop()
        SerialPort1.Close()

        ' Stop CSV logging
        If csvWriter IsNot Nothing Then
            csvWriter.Close()
            csvWriter = Nothing
        End If

        Disconnect.SendToBack()
        Connect.BringToFront()
    End Sub


    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting  '--> Read incoming serial data

            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn   '--> Enter serial data into the textbox

            If TB.Lines.Count > 0 Then
                If TB.Lines(0) = "Failed to read from DHT sensor!" Then
                    TimerSerial.Stop()
                    SerialPort1.Close()
                    If csvWriter IsNot Nothing Then
                        csvWriter.Close()
                        csvWriter = Nothing
                    End If
                    Disconnect.SendToBack()
                    Connect.BringToFront()
                    MsgBox("Failed to read from DHT sensor !!!, Please check the Hardware and Please connect again.", MsgBoxStyle.Critical, "Connection failed !!!")
                    Return
                End If

                If TB.Lines.Length >= 6 Then
                    ' Ambil dan validasi Voltage (baris ke-0)
                    If TB.Lines(0).StartsWith("V") Then
                        Voltage = TB.Lines(0)
                        VoltageL = Voltage.Length
                        VoltageResult = Mid(Voltage, 2, VoltageL - 1)
                    End If

                    ' Ambil dan validasi Current (baris ke-1)
                    If TB.Lines(1).StartsWith("C") Then
                        Current = TB.Lines(1)
                        CurrentL = Current.Length
                        CurrentResult = Mid(Current, 2, CurrentL - 1)
                    End If

                    ' Ambil dan validasi Thrust (baris ke-2)
                    If TB.Lines(2).StartsWith("TR") Then
                        Thrust = TB.Lines(2)
                        ThrustL = Thrust.Length
                        ThrustResult = Mid(Thrust, 3, ThrustL - 2)
                    End If

                    ' Ambil dan validasi Torque (baris ke-3)
                    If TB.Lines(3).StartsWith("TO") Then
                        Torque = TB.Lines(3)
                        TorqueL = Torque.Length
                        TorqueResult = Mid(Torque, 3, TorqueL - 2)
                    End If

                    ' Ambil dan validasi Temperature (baris ke-4)
                    If TB.Lines(4).StartsWith("TP") Then
                        Temp = TB.Lines(4)
                        TempL = Temp.Length
                        TempResult = Mid(Temp, 3, TempL - 2)
                    End If

                    ' Ambil dan validasi RPM (baris ke-5)
                    If TB.Lines(5).StartsWith("R") Then
                        Rpm = TB.Lines(5)
                        RpmL = Rpm.Length
                        RpmResult = Mid(Rpm, 2, RpmL - 1)
                    End If
                    ' Ambil dan validasi Daya (baris ke-6)
                    If TB.Lines(6).StartsWith("D") Then
                        Daya = TB.Lines(6)
                        DayaL = Daya.Length
                        DayaResult = Mid(Daya, 2, DayaL - 1)
                    End If
                End If


                ThrotleValue.Text = TrackBarThrotle.Value
                LabelVoltage.Text = VoltageResult
                LabelCurrent.Text = CurrentResult
                LabelDaya.Text = DayaResult
                LabelTemp.Text = TempResult
                LabelThrust.Text = ThrustResult
                LabelTorque.Text = TorqueResult
                LabelRPM.Text = RpmResult

                '-----------Enter the temperature and humidity values into the chart-----------------------------------
                If Not String.IsNullOrEmpty(ThrustResult) Then
                    ChartThrust.Series("Thrust            ").Points.AddY(Val(ThrustResult))
                    If ChartThrust.Series(0).Points.Count = ChartLimit Then
                        ChartThrust.Series(0).Points.RemoveAt(0)
                    End If
                End If

                If Not String.IsNullOrEmpty(TempResult) Then
                    ChartTemperature.Series("Temperature").Points.AddY(Val(TempResult))
                    If ChartTemperature.Series(0).Points.Count = ChartLimit Then
                        ChartTemperature.Series(0).Points.RemoveAt(0)
                    End If
                End If

                If Not String.IsNullOrEmpty(RpmResult) Then
                    ChartRPM.Series("RPM               ").Points.AddY(Val(RpmResult))
                    If ChartRPM.Series(0).Points.Count = ChartLimit Then
                        ChartRPM.Series(0).Points.RemoveAt(0)
                    End If
                End If

                ' Log to CSV if logging is active
                If csvWriter IsNot Nothing Then
                    Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    Dim row As String = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", timestamp, ThrotleValue.Text, VoltageResult, CurrentResult, DayaResult, TempResult, ThrustResult, TorqueResult, RpmResult)
                    csvWriter.WriteLine(row)
                    csvWriter.Flush()
                End If
            End If
        Catch ex As Exception
            TimerSerial.Stop()
            SerialPort1.Close()
            If csvWriter IsNot Nothing Then
                csvWriter.Close()
                csvWriter = Nothing
            End If
            Disconnect.SendToBack()
            Connect.BringToFront()
            MsgBox("Please check the Hardware and Please connect LAGI." & ex.Message, MsgBoxStyle.Critical, "Connection failed !!!")
            Return
        End Try
    End Sub

    Private Sub TrackBarThrotle_Scroll(sender As Object, e As EventArgs) Handles TrackBarThrotle.Scroll
        If SerialPort1.IsOpen Then
            Dim int_degree As Integer = TrackBarThrotle.Value
            SerialPort1.Write(int_degree.ToString() & vbLf)

        End If
    End Sub
End Class
