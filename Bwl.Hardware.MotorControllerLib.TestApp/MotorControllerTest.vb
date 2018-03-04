Imports Bwl.Framework

Public Class MotorControllerTest
    Inherits FormAppBase
    Private _mc2 As New MotorControllerTwo

    Private Sub mc2set_Tick(sender As Object, e As EventArgs) Handles mc2set.Tick
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
End Class
