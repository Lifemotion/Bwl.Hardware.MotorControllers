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
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(2, 518)
        Me.logWriter.Size = New System.Drawing.Size(861, 191)
        '
        'gbMC2
        '
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
        Me.gbMC2.Size = New System.Drawing.Size(232, 472)
        Me.gbMC2.TabIndex = 2
        Me.gbMC2.TabStop = False
        Me.gbMC2.Text = "MotorControllerTwo"
        '
        'mc2servo7
        '
        Me.mc2servo7.Location = New System.Drawing.Point(6, 414)
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
        Me.mc2servo6.Location = New System.Drawing.Point(6, 369)
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
        Me.mc2servo5.Location = New System.Drawing.Point(6, 324)
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
        Me.mc2servo4.Location = New System.Drawing.Point(6, 279)
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
        Me.mc2servo3.Location = New System.Drawing.Point(6, 234)
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
        Me.mc2servo2.Location = New System.Drawing.Point(6, 189)
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
        Me.mc2servo1.Location = New System.Drawing.Point(6, 144)
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
        Me.mc2servo0.Location = New System.Drawing.Point(6, 99)
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
        Me.mc2motor.Location = New System.Drawing.Point(6, 45)
        Me.mc2motor.Maximum = 100
        Me.mc2motor.Minimum = -100
        Me.mc2motor.Name = "mc2motor"
        Me.mc2motor.Size = New System.Drawing.Size(220, 45)
        Me.mc2motor.SmallChange = 5
        Me.mc2motor.TabIndex = 1
        Me.mc2motor.TickFrequency = 5
        '
        'mc2state
        '
        Me.mc2state.Location = New System.Drawing.Point(6, 19)
        Me.mc2state.Name = "mc2state"
        Me.mc2state.Size = New System.Drawing.Size(220, 20)
        Me.mc2state.TabIndex = 0
        '
        'mc2set
        '
        Me.mc2set.Enabled = True
        '
        'MotorControllerTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 707)
        Me.Controls.Add(Me.gbMC2)
        Me.Name = "MotorControllerTest"
        Me.Text = "MotorControllerTest"
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
End Class
