Imports Bwl.Framework

Public Class MotorControllerTest
    Inherits FormAppBase
    Private _mc2 As New MotorControllerTwo

    Private Sub mc2set_Tick(sender As Object, e As EventArgs) Handles mc2set.Tick
        mc2state.Text = _mc2.BoardState.ToString + ", " + _mc2.BoardInfo
        If _mc2.IsConnected Then
            _mc2.BigMotor = mc2motor.Value
            _mc2.Servo0 = mc2servo0.Value
            _mc2.Servo1 = mc2servo1.Value
            _mc2.Servo2 = mc2servo2.Value
            _mc2.Servo3 = mc2servo3.Value
            _mc2.SendValues()
        End If
    End Sub
End Class
