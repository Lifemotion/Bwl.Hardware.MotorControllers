<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClimateMaker

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
        Me.mc4state = New System.Windows.Forms.TextBox()
        Me.cameraSet = New System.Windows.Forms.Timer(Me.components)
        Me.cbHeatPump = New System.Windows.Forms.CheckBox()
        Me.udHeatFan = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.udWaterLevel = New System.Windows.Forms.NumericUpDown()
        Me.cbWater2 = New System.Windows.Forms.CheckBox()
        Me.cbWater1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.udCoolFan = New System.Windows.Forms.NumericUpDown()
        Me.cbCoolPump = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCamera1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bUpdate = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbHotWater = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbColdWater = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbCamera2 = New System.Windows.Forms.TextBox()
        Me.cameraGet = New System.Windows.Forms.Timer(Me.components)
        CType(Me.udHeatFan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.udWaterLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udCoolFan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(0, 653)
        Me.logWriter.Size = New System.Drawing.Size(859, 171)
        '
        'mc4state
        '
        Me.mc4state.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mc4state.Location = New System.Drawing.Point(12, 27)
        Me.mc4state.Name = "mc4state"
        Me.mc4state.Size = New System.Drawing.Size(835, 20)
        Me.mc4state.TabIndex = 2
        '
        'cameraSet
        '
        Me.cameraSet.Enabled = True
        Me.cameraSet.Interval = 1000
        '
        'cbHeatPump
        '
        Me.cbHeatPump.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbHeatPump.AutoSize = True
        Me.cbHeatPump.Location = New System.Drawing.Point(18, 98)
        Me.cbHeatPump.Name = "cbHeatPump"
        Me.cbHeatPump.Size = New System.Drawing.Size(199, 43)
        Me.cbHeatPump.TabIndex = 3
        Me.cbHeatPump.Text = "Циркуляция "
        Me.cbHeatPump.UseVisualStyleBackColor = True
        '
        'udHeatFan
        '
        Me.udHeatFan.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.udHeatFan.Location = New System.Drawing.Point(137, 173)
        Me.udHeatFan.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udHeatFan.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.udHeatFan.Name = "udHeatFan"
        Me.udHeatFan.Size = New System.Drawing.Size(80, 80)
        Me.udHeatFan.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.udWaterLevel)
        Me.GroupBox1.Controls.Add(Me.cbWater2)
        Me.GroupBox1.Controls.Add(Me.cbWater1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.udCoolFan)
        Me.GroupBox1.Controls.Add(Me.cbCoolPump)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbHeatPump)
        Me.GroupBox1.Controls.Add(Me.udHeatFan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 275)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Управление"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 33)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Вент"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 33)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Вент"
        '
        'udWaterLevel
        '
        Me.udWaterLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.udWaterLevel.Location = New System.Drawing.Point(756, 173)
        Me.udWaterLevel.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udWaterLevel.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.udWaterLevel.Name = "udWaterLevel"
        Me.udWaterLevel.Size = New System.Drawing.Size(73, 80)
        Me.udWaterLevel.TabIndex = 12
        '
        'cbWater2
        '
        Me.cbWater2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbWater2.AutoSize = True
        Me.cbWater2.Location = New System.Drawing.Point(678, 98)
        Me.cbWater2.Name = "cbWater2"
        Me.cbWater2.Size = New System.Drawing.Size(151, 43)
        Me.cbWater2.TabIndex = 11
        Me.cbWater2.Text = "Впрыск 2"
        Me.cbWater2.UseVisualStyleBackColor = True
        '
        'cbWater1
        '
        Me.cbWater1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbWater1.AutoSize = True
        Me.cbWater1.Location = New System.Drawing.Point(503, 98)
        Me.cbWater1.Name = "cbWater1"
        Me.cbWater1.Size = New System.Drawing.Size(159, 43)
        Me.cbWater1.TabIndex = 10
        Me.cbWater1.Text = "Впрыск 1 "
        Me.cbWater1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Впрыск воды"
        '
        'udCoolFan
        '
        Me.udCoolFan.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.udCoolFan.Location = New System.Drawing.Point(377, 173)
        Me.udCoolFan.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udCoolFan.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.udCoolFan.Name = "udCoolFan"
        Me.udCoolFan.Size = New System.Drawing.Size(73, 80)
        Me.udCoolFan.TabIndex = 8
        '
        'cbCoolPump
        '
        Me.cbCoolPump.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbCoolPump.AutoSize = True
        Me.cbCoolPump.Location = New System.Drawing.Point(251, 98)
        Me.cbCoolPump.Name = "cbCoolPump"
        Me.cbCoolPump.Size = New System.Drawing.Size(199, 43)
        Me.cbCoolPump.TabIndex = 7
        Me.cbCoolPump.Text = "Циркуляция "
        Me.cbCoolPump.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(253, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Охлаждение"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Нагрев"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 33)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Камера 1:"
        '
        'tbCamera1
        '
        Me.tbCamera1.Location = New System.Drawing.Point(227, 43)
        Me.tbCamera1.Name = "tbCamera1"
        Me.tbCamera1.Size = New System.Drawing.Size(250, 40)
        Me.tbCamera1.TabIndex = 16
        Me.tbCamera1.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bUpdate)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbHotWater)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbColdWater)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbCamera2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbCamera1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(494, 316)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Датчики"
        '
        'bUpdate
        '
        Me.bUpdate.Location = New System.Drawing.Point(227, 259)
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.Size = New System.Drawing.Size(250, 41)
        Me.bUpdate.TabIndex = 23
        Me.bUpdate.Text = "Обновить"
        Me.bUpdate.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 33)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Нагреватель:"
        '
        'tbHotWater
        '
        Me.tbHotWater.Location = New System.Drawing.Point(227, 213)
        Me.tbHotWater.Name = "tbHotWater"
        Me.tbHotWater.Size = New System.Drawing.Size(250, 40)
        Me.tbHotWater.TabIndex = 22
        Me.tbHotWater.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 33)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Холодильник:"
        '
        'tbColdWater
        '
        Me.tbColdWater.Location = New System.Drawing.Point(227, 156)
        Me.tbColdWater.Name = "tbColdWater"
        Me.tbColdWater.Size = New System.Drawing.Size(250, 40)
        Me.tbColdWater.TabIndex = 20
        Me.tbColdWater.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 33)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Камера 2:"
        '
        'tbCamera2
        '
        Me.tbCamera2.Location = New System.Drawing.Point(227, 99)
        Me.tbCamera2.Name = "tbCamera2"
        Me.tbCamera2.Size = New System.Drawing.Size(250, 40)
        Me.tbCamera2.TabIndex = 18
        Me.tbCamera2.Text = "0"
        '
        'cameraGet
        '
        Me.cameraGet.Enabled = True
        Me.cameraGet.Interval = 5000
        '
        'ClimateMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 822)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mc4state)
        Me.Name = "ClimateMaker"
        Me.Text = "ClimateMaker"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.mc4state, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        CType(Me.udHeatFan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.udWaterLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udCoolFan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mc4state As TextBox
    Friend WithEvents cameraSet As Timer
    Friend WithEvents cbHeatPump As CheckBox
    Friend WithEvents udHeatFan As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents udWaterLevel As NumericUpDown
    Friend WithEvents cbWater2 As CheckBox
    Friend WithEvents cbWater1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents udCoolFan As NumericUpDown
    Friend WithEvents cbCoolPump As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCamera1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbHotWater As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbColdWater As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCamera2 As TextBox
    Friend WithEvents cameraGet As Timer
    Friend WithEvents bUpdate As Button
End Class
