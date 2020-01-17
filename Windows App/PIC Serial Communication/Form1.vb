Imports System
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Math

Public Class Form1
    Dim com1 As IO.Ports.SerialPort = Nothing

    ' REFRESH THE PORT LIST
    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        serialPortsList.Items.Clear()
        For Each item As String In My.Computer.Ports.SerialPortNames
            serialPortsList.Items.Add(item)
        Next
    End Sub

    ' OPEN SELECTED COM PORT WITH BAUD RATE
    Private Sub openPortButton_Click(sender As Object, e As EventArgs) Handles openPortButton.Click
        Try
            Dim baudRate = Convert.ToInt32(baudRateTextbox.Text)
            Dim portName = serialPortsList.SelectedItem
            com1 = My.Computer.Ports.OpenSerialPort(portName, baudRate)
        Catch ex As Exception
            MsgBox("Cannot open the port, reselect port and try again.")
        End Try
    End Sub

    ' CLEAR DATA LIST
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ingoingDataList.Items.Clear()
    End Sub

    ' RECEIVE TEST STRING DATA TO PC
    Private Sub receiveButton_Click(sender As Object, e As EventArgs) Handles receiveButton.Click
        Try
            com1.ReadTimeout = 3000
            ingoingDataList.Items.Add(com1.ReadLine())
        Catch ex As Exception
            MsgBox("Serial port has timed out, open port and try again.")
            com1.Close()
        End Try
    End Sub

    ' SEND WAVEFORM DATA
    Private Sub sendWdataButton_Click(sender As Object, e As EventArgs) Handles sendWdataButton.Click
        Try
            com1.WriteLine(waveTypeList.SelectedItem)
            com1.WriteLine(freqTextbox.Text)
            com1.WriteLine(ampTextbox.Text)
            com1.WriteLine(offsetTextbox.Text)
        Catch ex As Exception
            MsgBox("Port is not open, open port and try again.")
        End Try

    End Sub

    ' LOAD WAVEFORM GRAPH
    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        wChart.Series.Clear()
        Dim s As New Series
        s.ChartType = SeriesChartType.Line
        s.IsVisibleInLegend = False
        s.BorderWidth = 3
        wChart.ChartAreas(0).AxisX.Title = "Time (s)"
        wChart.ChartAreas(0).AxisY.Title = "Voltage (V)"
        Dim amp, freq, offset
        Try
            amp = Convert.ToInt32(ampTextbox.Text)
            freq = Convert.ToInt32(freqTextbox.Text)
            offset = Convert.ToInt32(offsetTextbox.Text)
        Catch ex As Exception
            MessageBox.Show("Incorrect data format type, please enter numeric data.")
            Exit Sub
        End Try
        Dim x As Double
        Dim y As Double
        ' Sampling frequency > 2 input frequency, use 1000x to get accurate data and then correct to step size (period)
        Dim sampleStep As Double = 1 / (freq * 1000)
        ' Use any number in denom to see that many wave cycles
        Dim period As Double = 4 / freq
        ' Max = adjust to height of the wave and any offset, either +/-
        wChart.ChartAreas(0).AxisY.Maximum = amp + offset
        ' Min = adjust to  the opposite knowing amp is height and offset moves up/down
        wChart.ChartAreas(0).AxisY.Minimum = amp * -1 + offset
        ' Max = 4 full wave cycles
        wChart.ChartAreas(0).AxisX.Maximum = period
        ' Min = 0 since we are using time
        wChart.ChartAreas(0).AxisX.Minimum = 0
        ' X int so we can see 13% of period or each cycle sliced in half
        wChart.ChartAreas(0).AxisX.Interval = period / 8
        ' Y int so we can see 25% or 4 slices for the amplitude
        wChart.ChartAreas(0).AxisY.Interval = amp * 0.25

        If waveTypeList.SelectedItem = "Sine" Then
            For i As Double = 0 To period Step sampleStep
                x = i
                y = (amp * (Math.Sin(x * freq * 2 * Math.PI))) + offset
                s.Points.AddXY(x, y)
            Next i
        ElseIf waveTypeList.SelectedItem = "Square" Then
            ' Since square starts at 0, we don't need to see the negative amplitude
            wChart.ChartAreas(0).AxisY.Minimum = offset
            Dim tempY As Double
            Dim sign As Double
            For i As Double = 0 To period Step sampleStep
                x = i
                tempY = Math.Sin(x * freq * 2 * Math.PI)
                If (tempY < 0) Then
                    sign = -1
                ElseIf (tempY > 0) Then
                    sign = 1
                ElseIf (tempY = 0) Then
                    sign = 0
                End If
                y = ((amp / 2) * sign + (amp / 2)) + offset
                s.Points.AddXY(x, y)
            Next i
        ElseIf waveTypeList.SelectedItem = "Triangle" Then
            For i As Double = 0 To period Step sampleStep
                x = i
                y = (((2 * amp) / Math.PI) * (Math.Asin(Math.Sin(x * freq * 2 * Math.PI)))) + offset
                s.Points.AddXY(x, y)
            Next i
        ElseIf waveTypeList.SelectedItem = "Sawtooth" Then
            For i As Double = 0 To period Step sampleStep
                x = i
                y = (((-1 * 2 * amp) / Math.PI) * (Math.Atan(1 / (Math.Tan(x * freq * Math.PI))))) + offset
                s.Points.AddXY(x, y)
            Next i
        End If
        wChart.Series.Add(s)
    End Sub

    ' CLEAR WAVEFORM GRAPH
    Private Sub clearGButton_Click(sender As Object, e As EventArgs) Handles clearGButton.Click
        wChart.Series.Clear()
    End Sub

End Class
