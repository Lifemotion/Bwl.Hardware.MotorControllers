<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MotorControllerTest

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbMC2 = New System.Windows.Forms.GroupBox()
        Me.mc2servo7 = New System.Windows.Forms.TrackBar()
        Me.mc2servo6 = New System.Windows.Forms.TrackBar()
        Me.mc2servo5 = New System.Windows.Forms.TrackBar()
        Me.mc2servo4 = New System.Windows.Forms.TrackBar()
        Me.mc2servo3 = New System.Windows.Forms.TrackBar()
        Me.mc2servo2 = New System.Windows.Forms.TrackBar()
        Me.mc2servo1 = New System.Windows.Forms.TrackBar()
        Me.mc2servo0 = New System.Windows.Forms.TrackBar()
        Me.mc2motor = New System.Windows.Forms.TrackBar()
        Me.mc2state = New System.Windows.Forms.TextBox()
        Me.mc2set = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mc2motor3 = New System.Windows.Forms.TrackBar()
        Me.mc2motor2 = New System.Windows.Forms.TrackBar()
        Me.mc2motor1 = New System.Windows.Forms.TrackBar()
        Me.mc2motor0 = New System.Windows.Forms.TrackBar()
        Me.gbMC2.SuspendLayout()
        CType(Me.mc2servo7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2servo6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2servo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2servo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2servo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2servo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2servo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2servo0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2motor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2motor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2motor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2motor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mc2motor0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(0, 428)
        Me.logWriter.Size = New System.Drawing.Size(861, 191)
        '
        'gbMC2
        '
        Me.gbMC2.Controls.Add(Me.Label10)
        Me.gbMC2.Controls.Add(Me.Label11)
        Me.gbMC2.Controls.Add(Me.Label12)
        Me.gbMC2.Controls.Add(Me.Label13)
        Me.gbMC2.Controls.Add(Me.mc2motor3)
        Me.gbMC2.Controls.Add(Me.mc2motor2)
        Me.gbMC2.Controls.Add(Me.mc2motor1)
        Me.gbMC2.Controls.Add(Me.mc2motor0)
        Me.gbMC2.Controls.Add(Me.Label9)
        Me.gbMC2.Controls.Add(Me.Label8)
        Me.gbMC2.Controls.Add(Me.Label7)
        Me.gbMC2.Controls.Add(Me.Label6)
        Me.gbMC2.Controls.Add(Me.Label5)
        Me.gbMC2.Controls.Add(Me.Label4)
        Me.gbMC2.Controls.Add(Me.Label3)
        Me.gbMC2.Controls.Add(Me.Label2)
        Me.gbMC2.Controls.Add(Me.Label1)
        Me.gbMC2.Controls.Add(Me.mc2servo7)
        Me.gbMC2.Controls.Add(Me.mc2servo6)
        Me.gbMC2.Controls.Add(Me.mc2servo5)
        Me.gbMC2.Controls.Add(Me.mc2servo4)
        Me.gbMC2.Controls.Add(Me.mc2servo3)
        Me.gbMC2.Controls.Add(Me.mc2servo2)
        Me.gbMC2.Controls.Add(Me.mc2servo1)
        Me.gbMC2.Controls.Add(Me.mc2servo0)
        Me.gbMC2.Controls.Add(Me.mc2motor)
        Me.gbMC2.Controls.Add(Me.mc2state)
        Me.gbMC2.Location = New System.Drawing.Point(12, 27)
        Me.gbMC2.Name = "gbMC2"
        Me.gbMC2.Size = New System.Drawing.Size(346, 391)
        Me.gbMC2.TabIndex = 2
        Me.gbMC2.TabStop = False
        Me.gbMC2.Text = "MotorControllerTwo"
        '
        'mc2servo7
        '
        Me.mc2servo7.Location = New System.Drawing.Point(236, 228)
        Me.mc2servo7.Maximum = 100
        Me.mc2servo7.Name = "mc2servo7"
        Me.mc2servo7.Size = New System.Drawing.Size(104, 45)
        Me.mc2servo7.SmallChange = 5
        Me.mc2servo7.TabIndex = 9
        Me.mc2servo7.TickFrequency = 5
        Me.mc2servo7.Value = 50
        '
        'mc2servo6
        '
        Me.mc2servo6.Location = New System.Drawing.Point(236, 183)
        Me.mc2servo6.Maximum = 100
        Me.mc2servo6.Name = "mc2servo6"
        Me.mc2servo6.Size = New System.Drawing.Size(104, 45)
        Me.mc2servo6.SmallChange = 5
        Me.mc2servo6.TabIndex = 8
        Me.mc2servo6.TickFrequency = 5
        Me.mc2servo6.Value = 50
        '
        'mc2servo5
        '
        Me.mc2servo5.Location = New System.Drawing.Point(236, 138)
        Me.mc2servo5.Maximum = 100
        Me.mc2servo5.Name = "mc2servo5"
        Me.mc2servo5.Size = New System.Drawing.Size(104, 45)
        Me.mc2servo5.SmallChange = 5
        Me.mc2servo5.TabIndex = 7
        Me.mc2servo5.TickFrequency = 5
        Me.mc2servo5.Value = 50
        '
        'mc2servo4
        '
        Me.mc2servo4.Location = New System.Drawing.Point(236, 93)
        Me.mc2servo4.Maximum = 100
        Me.mc2servo4.Name = "mc2servo4"
        Me.mc2servo4.Size = New System.Drawing.Size(104, 45)
        Me.mc2servo4.SmallChange = 5
        Me.mc2servo4.TabIndex = 6
        Me.mc2servo4.TickFrequency = 5
        Me.mc2servo4.Value = 50
        '
        'mc2servo3
        '
        Me.mc2servo3.Location = New System.Drawing.Point(48, 228)
        Me.mc2servo3.Maximum = 100
        Me.mc2servo3.Name = "mc2servo3"
        Me.mc2servo3.Size = New System.Drawing.Size(104, 45)
        Me.mc2servo3.SmallChange = 5
        Me.mc2servo3.TabIndex = 5
        Me.mc2servo3.TickFrequency = 5
        Me.mc2servo3.Value = 50
        '
        'mc2servo2
        '
        Me.mc2servo2.Location = New System.Drawing.Point(48, 183)
        Me.mc2servo2.Maximum = 100
        Me.mc2servo2.Name = "mc2servo2"
        Me.mc2servo2.Size = New System.Drawing.Size(104, 45)
        Me.mc2servo2.SmallChange = 5
        Me.mc2servo2.TabIndex = 4
        Me.mc2servo2.TickFrequency = 5
        Me.mc2servo2.Value = 50
        '
        'mc2servo1
        '
        Me.mc2servo1.Location = New System.Drawing.Point(48, 138)
        Me.mc2servo1.Maximum = 100
        Me.mc2servo1.Name = "mc2servo1"
        Me.mc2servo1.Size = New System.Drawing.Size(104, 45)
        Me.mc2servo1.SmallChange = 5
        Me.mc2servo1.TabIndex = 3
        Me.mc2servo1.TickFrequency = 5
        Me.mc2servo1.Value = 50
        '
        'mc2servo0
        '
        Me.mc2servo0.Location = New System.Drawing.Point(48, 93)
        Me.mc2servo0.Maximum = 100
        Me.mc2servo0.Name = "mc2servo0"
        Me.mc2servo0.Size = New System.Drawing.Size(104, 45)
        Me.mc2servo0.SmallChange = 5
        Me.mc2servo0.TabIndex = 2
        Me.mc2servo0.TickFrequency = 5
        Me.mc2servo0.Value = 50
        '
        'mc2motor
        '
        Me.mc2motor.LargeChange = 20
        Me.mc2motor.Location = New System.Drawing.Point(48, 45)
        Me.mc2motor.Maximum = 100
        Me.mc2motor.Minimum = -100
        Me.mc2motor.Name = "mc2motor"
        Me.mc2motor.Size = New System.Drawing.Size(292, 45)
        Me.mc2motor.SmallChange = 5
        Me.mc2motor.TabIndex = 1
        Me.mc2motor.TickFrequency = 5
        '
        'mc2state
        '
        Me.mc2state.Location = New System.Drawing.Point(6, 19)
        Me.mc2state.Name = "mc2state"
        Me.mc2state.Size = New System.Drawing.Size(334, 20)
        Me.mc2state.TabIndex = 0
        '
        'mc2set
        '
        Me.mc2set.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Main"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Servo0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Servo1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Servo2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Servo3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Servo4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(189, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Servo5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(189, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Servo6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(189, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Servo7"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(189, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Motor3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(189, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Motor2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Motor1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Motor0"
        '
        'mc2motor3
        '
        Me.mc2motor3.Location = New System.Drawing.Point(236, 342)
        Me.mc2motor3.Maximum = 100
        Me.mc2motor3.Name = "mc2motor3"
        Me.mc2motor3.Size = New System.Drawing.Size(104, 45)
        Me.mc2motor3.SmallChange = 5
        Me.mc2motor3.TabIndex = 22
        Me.mc2motor3.TickFrequency = 5
        Me.mc2motor3.Value = 50
        '
        'mc2motor2
        '
        Me.mc2motor2.Location = New System.Drawing.Point(236, 297)
        Me.mc2motor2.Maximum = 100
        Me.mc2motor2.Name = "mc2motor2"
        Me.mc2motor2.Size = New System.Drawing.Size(104, 45)
        Me.mc2motor2.SmallChange = 5
        Me.mc2motor2.TabIndex = 21
        Me.mc2motor2.TickFrequency = 5
        Me.mc2motor2.Value = 50
        '
        'mc2motor1
        '
        Me.mc2motor1.Location = New System.Drawing.Point(48, 342)
        Me.mc2motor1.Maximum = 100
        Me.mc2motor1.Name = "mc2motor1"
        Me.mc2motor1.Size = New System.Drawing.Size(104, 45)
        Me.mc2motor1.SmallChange = 5
        Me.mc2motor1.TabIndex = 20
        Me.mc2motor1.TickFrequency = 5
        Me.mc2motor1.Value = 50
        '
        'mc2motor0
        '
        Me.mc2motor0.Location = New System.Drawing.Point(48, 297)
        Me.mc2motor0.Maximum = 100
        Me.mc2motor0.Name = "mc2motor0"
        Me.mc2motor0.Size = New System.Drawing.Size(104, 45)
        Me.mc2motor0.SmallChange = 5
        Me.mc2motor0.TabIndex = 19
        Me.mc2motor0.TickFrequency = 5
        Me.mc2motor0.Value = 50
        '
        'MotorControllerTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 617)
        Me.Controls.Add(Me.gbMC2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MotorControllerTest"
        Me.Text = "Bwl Motor Controller Test App"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.gbMC2, 0)
        Me.gbMC2.ResumeLayout(False)
        Me.gbMC2.PerformLayout()
        CType(Me.mc2servo7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2servo6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2servo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2servo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2servo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2servo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2servo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2servo0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2motor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2motor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2motor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2motor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mc2motor0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbMC2 As GroupBox
    Friend WithEvents mc2state As TextBox
    Friend WithEvents mc2servo7 As TrackBar
    Friend WithEvents mc2servo6 As TrackBar
    Friend WithEvents mc2servo5 As TrackBar
    Friend WithEvents mc2servo4 As TrackBar
    Friend WithEvents mc2servo3 As TrackBar
    Friend WithEvents mc2servo2 As TrackBar
    Friend WithEvents mc2servo1 As TrackBar
    Friend WithEvents mc2servo0 As TrackBar
    Friend WithEvents mc2motor As TrackBar
    Friend WithEvents mc2set As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents mc2motor3 As TrackBar
    Friend WithEvents mc2motor2 As TrackBar
    Friend WithEvents mc2motor1 As TrackBar
    Friend WithEvents mc2motor0 As TrackBar
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
