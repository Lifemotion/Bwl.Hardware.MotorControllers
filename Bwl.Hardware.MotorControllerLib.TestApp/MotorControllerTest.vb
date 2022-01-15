Imports Bwl.Framework

Public Class MotorControllerTest
    Inherits FormAppBase
    Private _mc2 As MotorControllerTwo
    Private _mc4 As New MotorControllerFour

    Private Sub mc2set_Tick(sender As Object, e As EventArgs) Handles mc2set.Tick
        If _mc2 Is Nothing Then Return
        mc2state.Text = _mc2.BoardState.ToString + ", " + _mc2.BoardInfo
        If _mc2.IsConnected Then
            _mc2.BigMotor0 = mc2motor.Value
            _mc2.Servo0 = mc2servo0.Value
            _mc2.Servo1 = mc2servo1.Value
            _mc2.Servo2 = mc2servo2.Value
            _mc2.Servo3 = mc2servo3.Value
            _mc2.Servo4 = mc2servo4.Value
            _mc2.Servo5 = mc2servo5.Value
            _mc2.Servo6 = mc2servo6.Value
            _mc2.Servo7 = mc2servo7.Value
            _mc2.Motor0 = mc2motor0.Value
            _mc2.Motor1 = mc2motor1.Value
            _mc2.Motor2 = mc2motor2.Value
            _mc2.Motor3 = mc2motor3.Value
            _mc2.SendValues()
        End If
    End Sub

    Private Sub MotorControllerTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mc4set_Tick(sender As Object, e As EventArgs) Handles mc4set.Tick
        mc4state.Text = _mc4.BoardState.ToString + ", " + _mc4.BoardInfo
        If _mc4.IsConnected Then
            _mc4.MotorAB = mc4pwmAB.Value
            _mc4.MotorCD = mc4pwmCD.Value
            If mc4ch1.Checked Then _mc4.MotorDrivers = 1
            If mc4ch2.Checked Then _mc4.MotorDrivers = 2
            If mc4ch3.Checked Then _mc4.MotorDrivers = 4
            If mc4ch4.Checked Then _mc4.MotorDrivers = 8
            If mc4ch5.Checked Then _mc4.MotorDrivers = 16
            _mc4.Servo1 = mc4servo1.Value
            _mc4.Servo2 = mc4servo2.Value
            _mc4.Servo3 = mc4servo3.Value
            _mc4.Servo4 = mc4servo4.Value
            _mc4.SendValues()
        End If
    End Sub

    Private Sub mc4info_Tick(sender As Object, e As EventArgs) Handles mc4info.Tick
        If _mc4.IsConnected Then
            Try
                Dim info = _mc4.GetPowerInfo
                mc4power.Text = info.ToString
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub mc4adcGet_Click(sender As Object, e As EventArgs) Handles mc4adcGet.Click
        Try
            mc4adcResult.Text = ""
            Dim result = _mc4.GetADCVoltage(Val(mc4adcChan.Text), Val(mc4adcAvg.Text))
            mc4adcResult.Text = result.ToString("0.000")
        Catch ex As Exception
            _logger.AddError(ex.Message)
        End Try
    End Sub

    Private Sub mc4getSens_Click(sender As Object, e As EventArgs) Handles mc4getSens.Click
        Try
            mc4adcResult.Text = ""
            Dim result = _mc4.GetExternalSensor(Val(mc4snsType.Text), Val(mc4adcChan.Text))
            mc4senRes.Text = result(0).ToString("0.000") + " " + result(1).ToString("0.000")
        Catch ex As Exception
            _logger.AddError(ex.Message)
        End Try
    End Sub
End Class
