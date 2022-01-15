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
        Me.bCm = New System.Windows.Forms.Button()
        Me.bCp = New System.Windows.Forms.Button()
        Me.bHm = New System.Windows.Forms.Button()
        Me.bHp = New System.Windows.Forms.Button()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbAuto2 = New System.Windows.Forms.CheckBox()
        Me.cbAuto1 = New System.Windows.Forms.CheckBox()
        Me.udHumi = New System.Windows.Forms.NumericUpDown()
        Me.udTemp = New System.Windows.Forms.NumericUpDown()
        Me.timerAuto = New System.Windows.Forms.Timer(Me.components)
        CType(Me.udHeatFan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.udWaterLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udCoolFan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.udHumi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(0, 892)
        Me.logWriter.Size = New System.Drawing.Size(784, 171)
        '
        'mc4state
        '
        Me.mc4state.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mc4state.Location = New System.Drawing.Point(12, 27)
        Me.mc4state.Name = "mc4state"
        Me.mc4state.Size = New System.Drawing.Size(760, 20)
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
        Me.cbHeatPump.Location = New System.Drawing.Point(18, 78)
        Me.cbHeatPump.Name = "cbHeatPump"
        Me.cbHeatPump.Size = New System.Drawing.Size(199, 80)
        Me.cbHeatPump.TabIndex = 3
        Me.cbHeatPump.Text = "Циркуляция "
        Me.cbHeatPump.UseVisualStyleBackColor = True
        '
        'udHeatFan
        '
        Me.udHeatFan.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.udHeatFan.Location = New System.Drawing.Point(91, 164)
        Me.udHeatFan.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udHeatFan.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.udHeatFan.Name = "udHeatFan"
        Me.udHeatFan.Size = New System.Drawing.Size(126, 80)
        Me.udHeatFan.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bCm)
        Me.GroupBox1.Controls.Add(Me.bCp)
        Me.GroupBox1.Controls.Add(Me.bHm)
        Me.GroupBox1.Controls.Add(Me.bHp)
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
        Me.GroupBox1.Size = New System.Drawing.Size(764, 325)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Управление"
        '
        'bCm
        '
        Me.bCm.Location = New System.Drawing.Point(354, 250)
        Me.bCm.Name = "bCm"
        Me.bCm.Size = New System.Drawing.Size(85, 69)
        Me.bCm.TabIndex = 27
        Me.bCm.Text = "-"
        Me.bCm.UseVisualStyleBackColor = True
        '
        'bCp
        '
        Me.bCp.Location = New System.Drawing.Point(240, 250)
        Me.bCp.Name = "bCp"
        Me.bCp.Size = New System.Drawing.Size(85, 69)
        Me.bCp.TabIndex = 26
        Me.bCp.Text = "+"
        Me.bCp.UseVisualStyleBackColor = True
        '
        'bHm
        '
        Me.bHm.Location = New System.Drawing.Point(132, 250)
        Me.bHm.Name = "bHm"
        Me.bHm.Size = New System.Drawing.Size(85, 69)
        Me.bHm.TabIndex = 25
        Me.bHm.Text = "-"
        Me.bHm.UseVisualStyleBackColor = True
        '
        'bHp
        '
        Me.bHp.Location = New System.Drawing.Point(18, 250)
        Me.bHp.Name = "bHp"
        Me.bHp.Size = New System.Drawing.Size(85, 69)
        Me.bHp.TabIndex = 24
        Me.bHp.Text = "+"
        Me.bHp.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 33)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Вент"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 33)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Вент"
        '
        'udWaterLevel
        '
        Me.udWaterLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.udWaterLevel.Location = New System.Drawing.Point(627, 78)
        Me.udWaterLevel.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udWaterLevel.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.udWaterLevel.Name = "udWaterLevel"
        Me.udWaterLevel.Size = New System.Drawing.Size(126, 80)
        Me.udWaterLevel.TabIndex = 12
        Me.udWaterLevel.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'cbWater2
        '
        Me.cbWater2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbWater2.Location = New System.Drawing.Point(462, 164)
        Me.cbWater2.Name = "cbWater2"
        Me.cbWater2.Size = New System.Drawing.Size(159, 80)
        Me.cbWater2.TabIndex = 11
        Me.cbWater2.Text = "Впрыск 2"
        Me.cbWater2.UseVisualStyleBackColor = True
        '
        'cbWater1
        '
        Me.cbWater1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbWater1.Location = New System.Drawing.Point(462, 78)
        Me.cbWater1.Name = "cbWater1"
        Me.cbWater1.Size = New System.Drawing.Size(159, 80)
        Me.cbWater1.TabIndex = 10
        Me.cbWater1.Text = "Впрыск 1 "
        Me.cbWater1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(467, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Впрыск воды"
        '
        'udCoolFan
        '
        Me.udCoolFan.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.udCoolFan.Location = New System.Drawing.Point(313, 164)
        Me.udCoolFan.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udCoolFan.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.udCoolFan.Name = "udCoolFan"
        Me.udCoolFan.Size = New System.Drawing.Size(126, 80)
        Me.udCoolFan.TabIndex = 8
        '
        'cbCoolPump
        '
        Me.cbCoolPump.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbCoolPump.Location = New System.Drawing.Point(240, 78)
        Me.cbCoolPump.Name = "cbCoolPump"
        Me.cbCoolPump.Size = New System.Drawing.Size(199, 80)
        Me.cbCoolPump.TabIndex = 7
        Me.cbCoolPump.Text = "Циркуляция "
        Me.cbCoolPump.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Охлаждение"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 42)
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
        Me.tbCamera1.Location = New System.Drawing.Point(172, 46)
        Me.tbCamera1.Name = "tbCamera1"
        Me.tbCamera1.Size = New System.Drawing.Size(196, 40)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 384)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 202)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Датчики"
        '
        'bUpdate
        '
        Me.bUpdate.Location = New System.Drawing.Point(588, 148)
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.Size = New System.Drawing.Size(154, 48)
        Me.bUpdate.TabIndex = 23
        Me.bUpdate.Text = "Обновить"
        Me.bUpdate.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(376, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 33)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Нагреватель:"
        '
        'tbHotWater
        '
        Me.tbHotWater.Location = New System.Drawing.Point(588, 102)
        Me.tbHotWater.Name = "tbHotWater"
        Me.tbHotWater.Size = New System.Drawing.Size(154, 40)
        Me.tbHotWater.TabIndex = 22
        Me.tbHotWater.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(376, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 33)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Холодильник:"
        '
        'tbColdWater
        '
        Me.tbColdWater.Location = New System.Drawing.Point(588, 45)
        Me.tbColdWater.Name = "tbColdWater"
        Me.tbColdWater.Size = New System.Drawing.Size(154, 40)
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
        Me.tbCamera2.Location = New System.Drawing.Point(172, 102)
        Me.tbCamera2.Name = "tbCamera2"
        Me.tbCamera2.Size = New System.Drawing.Size(196, 40)
        Me.tbCamera2.TabIndex = 18
        Me.tbCamera2.Text = "0"
        '
        'cameraGet
        '
        Me.cameraGet.Enabled = True
        Me.cameraGet.Interval = 5000
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cbAuto2)
        Me.GroupBox3.Controls.Add(Me.cbAuto1)
        Me.GroupBox3.Controls.Add(Me.udHumi)
        Me.GroupBox3.Controls.Add(Me.udTemp)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 611)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(772, 278)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Автоматический режим"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(683, 87)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(70, 69)
        Me.Button11.TabIndex = 34
        Me.Button11.Text = "80"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(684, 169)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(70, 69)
        Me.Button10.TabIndex = 33
        Me.Button10.Text = "60"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(415, 169)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(70, 69)
        Me.Button9.TabIndex = 32
        Me.Button9.Text = "40"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(339, 169)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 69)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "20"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(263, 169)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 69)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "10"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(187, 169)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 69)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "0"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(416, 89)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 69)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "-10"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(608, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 69)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "40"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(532, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 69)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "20"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(340, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 69)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "-20"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(264, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 69)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "-40"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(526, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 33)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Влажность"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(139, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 33)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Температура"
        '
        'cbAuto2
        '
        Me.cbAuto2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbAuto2.Location = New System.Drawing.Point(12, 147)
        Me.cbAuto2.Name = "cbAuto2"
        Me.cbAuto2.Size = New System.Drawing.Size(109, 91)
        Me.cbAuto2.TabIndex = 11
        Me.cbAuto2.Text = "Кам 2"
        Me.cbAuto2.UseVisualStyleBackColor = True
        '
        'cbAuto1
        '
        Me.cbAuto1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbAuto1.Location = New System.Drawing.Point(10, 39)
        Me.cbAuto1.Name = "cbAuto1"
        Me.cbAuto1.Size = New System.Drawing.Size(109, 91)
        Me.cbAuto1.TabIndex = 10
        Me.cbAuto1.Text = "Кам 1"
        Me.cbAuto1.UseVisualStyleBackColor = True
        '
        'udHumi
        '
        Me.udHumi.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.udHumi.Location = New System.Drawing.Point(532, 89)
        Me.udHumi.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.udHumi.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udHumi.Name = "udHumi"
        Me.udHumi.Size = New System.Drawing.Size(121, 67)
        Me.udHumi.TabIndex = 8
        Me.udHumi.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'udTemp
        '
        Me.udTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.udTemp.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.udTemp.Location = New System.Drawing.Point(156, 90)
        Me.udTemp.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.udTemp.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.udTemp.Name = "udTemp"
        Me.udTemp.Size = New System.Drawing.Size(101, 67)
        Me.udTemp.TabIndex = 4
        Me.udTemp.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'timerAuto
        '
        Me.timerAuto.Enabled = True
        Me.timerAuto.Interval = 3000
        '
        'ClimateMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 1061)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mc4state)
        Me.Name = "ClimateMaker"
        Me.Text = "ClimateMaker 1.1"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.mc4state, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        CType(Me.udHeatFan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.udWaterLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udCoolFan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.udHumi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udTemp, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bCm As Button
    Friend WithEvents bCp As Button
    Friend WithEvents bHm As Button
    Friend WithEvents bHp As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbAuto2 As CheckBox
    Friend WithEvents cbAuto1 As CheckBox
    Friend WithEvents udHumi As NumericUpDown
    Friend WithEvents udTemp As NumericUpDown
    Friend WithEvents timerAuto As Timer
End Class
