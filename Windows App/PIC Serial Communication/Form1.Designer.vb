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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ingoingDataList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.openPortButton = New System.Windows.Forms.Button()
        Me.serialPortsList = New System.Windows.Forms.ComboBox()
        Me.baudRateTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.serialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.freqTextbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ampTextbox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.offsetTextbox = New System.Windows.Forms.TextBox()
        Me.waveTypeList = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sendWdataButton = New System.Windows.Forms.Button()
        Me.receiveButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.wChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.clearGButton = New System.Windows.Forms.Button()
        CType(Me.wChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PIC Calibration"
        '
        'ingoingDataList
        '
        Me.ingoingDataList.FormattingEnabled = True
        Me.ingoingDataList.ItemHeight = 25
        Me.ingoingDataList.Location = New System.Drawing.Point(48, 470)
        Me.ingoingDataList.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ingoingDataList.Name = "ingoingDataList"
        Me.ingoingDataList.Size = New System.Drawing.Size(290, 179)
        Me.ingoingDataList.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 439)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "View Send Data"
        '
        'openPortButton
        '
        Me.openPortButton.Location = New System.Drawing.Point(45, 302)
        Me.openPortButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.openPortButton.Name = "openPortButton"
        Me.openPortButton.Size = New System.Drawing.Size(293, 44)
        Me.openPortButton.TabIndex = 7
        Me.openPortButton.Text = "Connect to Port"
        Me.openPortButton.UseVisualStyleBackColor = True
        '
        'serialPortsList
        '
        Me.serialPortsList.FormattingEnabled = True
        Me.serialPortsList.Location = New System.Drawing.Point(45, 255)
        Me.serialPortsList.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.serialPortsList.Name = "serialPortsList"
        Me.serialPortsList.Size = New System.Drawing.Size(289, 33)
        Me.serialPortsList.TabIndex = 8
        '
        'baudRateTextbox
        '
        Me.baudRateTextbox.Location = New System.Drawing.Point(45, 199)
        Me.baudRateTextbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.baudRateTextbox.Name = "baudRateTextbox"
        Me.baudRateTextbox.Size = New System.Drawing.Size(289, 31)
        Me.baudRateTextbox.TabIndex = 9
        Me.baudRateTextbox.Text = "9600"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(347, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Baud Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(347, 259)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Port"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Port Configuration"
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(43, 142)
        Me.refreshButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(293, 44)
        Me.refreshButton.TabIndex = 13
        Me.refreshButton.Text = "Load Ports"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1006, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(448, 44)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Waveform Customization"
        '
        'freqTextbox
        '
        Me.freqTextbox.Location = New System.Drawing.Point(1977, 194)
        Me.freqTextbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.freqTextbox.Name = "freqTextbox"
        Me.freqTextbox.Size = New System.Drawing.Size(136, 31)
        Me.freqTextbox.TabIndex = 16
        Me.freqTextbox.Text = "1000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2117, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Frequency (Hz)"
        '
        'ampTextbox
        '
        Me.ampTextbox.Location = New System.Drawing.Point(1977, 250)
        Me.ampTextbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ampTextbox.Name = "ampTextbox"
        Me.ampTextbox.Size = New System.Drawing.Size(136, 31)
        Me.ampTextbox.TabIndex = 18
        Me.ampTextbox.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2115, 254)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Amplitude (V)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2117, 309)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 25)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "DC offset (V)"
        '
        'offsetTextbox
        '
        Me.offsetTextbox.Location = New System.Drawing.Point(1977, 305)
        Me.offsetTextbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.offsetTextbox.Name = "offsetTextbox"
        Me.offsetTextbox.Size = New System.Drawing.Size(136, 31)
        Me.offsetTextbox.TabIndex = 21
        Me.offsetTextbox.Text = "0"
        '
        'waveTypeList
        '
        Me.waveTypeList.FormattingEnabled = True
        Me.waveTypeList.Items.AddRange(New Object() {"Sine", "Square", "Triangle", "Sawtooth"})
        Me.waveTypeList.Location = New System.Drawing.Point(1977, 142)
        Me.waveTypeList.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.waveTypeList.Name = "waveTypeList"
        Me.waveTypeList.Size = New System.Drawing.Size(136, 33)
        Me.waveTypeList.TabIndex = 22
        Me.waveTypeList.Text = "Sine"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2117, 145)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 25)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Type"
        '
        'sendWdataButton
        '
        Me.sendWdataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendWdataButton.Location = New System.Drawing.Point(1089, 964)
        Me.sendWdataButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.sendWdataButton.Name = "sendWdataButton"
        Me.sendWdataButton.Size = New System.Drawing.Size(291, 42)
        Me.sendWdataButton.TabIndex = 24
        Me.sendWdataButton.Text = "Send Data"
        Me.sendWdataButton.UseVisualStyleBackColor = True
        '
        'receiveButton
        '
        Me.receiveButton.Location = New System.Drawing.Point(48, 719)
        Me.receiveButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.receiveButton.Name = "receiveButton"
        Me.receiveButton.Size = New System.Drawing.Size(291, 42)
        Me.receiveButton.TabIndex = 26
        Me.receiveButton.Text = "Recieve Data"
        Me.receiveButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(48, 665)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(291, 42)
        Me.clearButton.TabIndex = 27
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'wChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.wChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.wChart.Legends.Add(Legend2)
        Me.wChart.Location = New System.Drawing.Point(503, 142)
        Me.wChart.Name = "wChart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.wChart.Series.Add(Series2)
        Me.wChart.Size = New System.Drawing.Size(1457, 797)
        Me.wChart.TabIndex = 29
        Me.wChart.Text = "Chart1"
        '
        'loadButton
        '
        Me.loadButton.Location = New System.Drawing.Point(1977, 375)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(127, 42)
        Me.loadButton.TabIndex = 30
        Me.loadButton.Text = "Load Graph"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'clearGButton
        '
        Me.clearGButton.Location = New System.Drawing.Point(1977, 437)
        Me.clearGButton.Name = "clearGButton"
        Me.clearGButton.Size = New System.Drawing.Size(127, 42)
        Me.clearGButton.TabIndex = 31
        Me.clearGButton.Text = "Clear"
        Me.clearGButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2295, 1060)
        Me.Controls.Add(Me.clearGButton)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.wChart)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.receiveButton)
        Me.Controls.Add(Me.sendWdataButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.waveTypeList)
        Me.Controls.Add(Me.offsetTextbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ampTextbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.freqTextbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.baudRateTextbox)
        Me.Controls.Add(Me.serialPortsList)
        Me.Controls.Add(Me.openPortButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ingoingDataList)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Form1"
        Me.Text = "Multi-Channel Waveform Generator"
        CType(Me.wChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ingoingDataList As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents openPortButton As System.Windows.Forms.Button
    Friend WithEvents serialPortsList As System.Windows.Forms.ComboBox
    Friend WithEvents baudRateTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents serialPort As System.IO.Ports.SerialPort
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As Label
    Friend WithEvents freqTextbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ampTextbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents offsetTextbox As TextBox
    Friend WithEvents waveTypeList As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents sendWdataButton As Button
    Friend WithEvents receiveButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents wChart As DataVisualization.Charting.Chart
    Friend WithEvents loadButton As Button
    Friend WithEvents clearGButton As Button
End Class
