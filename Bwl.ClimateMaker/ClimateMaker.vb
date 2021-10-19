Imports Bwl.Framework
Imports Bwl.Hardware.MotorController

Public Class ClimateMaker
    Inherits FormAppBase
    Private _mc4 As New MotorControllerFour

    Private Sub ClimateMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mc2set_Tick(sender As Object, e As EventArgs) Handles cameraSet.Tick
        mc4state.Text = _mc4.BoardState.ToString + ", " + _mc4.BoardInfo
        If _mc4.IsConnected Then
            If cbCoolPump.Checked Then
                _mc4.SS.RequestPinSet(0, 1, 5, 1, 1)
            Else
                _mc4.SS.RequestPinSet(0, 1, 5, 1, 0)
            End If
            If cbHeatPump.Checked Then
                _mc4.SS.RequestPinSet(0, 1, 6, 1, 1)
            Else
                _mc4.SS.RequestPinSet(0, 1, 6, 1, 0)
            End If
            If cbWater1.Checked Or cbWater2.Checked Then
                _mc4.MotorDriver = 1
                If cbWater1.Checked Then
                    _mc4.MotorAB = udWaterLevel.Value * 10
                Else
                    _mc4.MotorAB = 0
                End If
                If cbWater2.Checked Then
                    _mc4.MotorCD = udWaterLevel.Value * 10
                Else
                    _mc4.MotorCD = 0
                End If
            Else
                _mc4.MotorDriver = 5
                _mc4.MotorAB = udHeatFan.Value * 10
                _mc4.MotorCD = udCoolFan.Value * 10
            End If
            _mc4.SendValues()
        End If
    End Sub

    Public Property Camera1Temp As Single
    Public Property Camera1Humi As Single
    Public Property Camera2Temp As Single
    Public Property Camera2Humi As Single
    Public Property ColdWaterTemp As Single
    Public Property HotWaterTemp As Single
    Private Sub bUpdate_Click(sender As Object, e As EventArgs) Handles bUpdate.Click, cameraGet.Tick
        If _mc4.IsConnected Then
            Try
                ColdWaterTemp = _mc4.GetExternalDs18b20(1)
                HotWaterTemp = _mc4.GetExternalDs18b20(2)
                Dim val1 = _mc4.GetExternalDHT22(3)
                Dim val2 = _mc4.GetExternalDHT22(4)
                Camera1Temp = val1(0)
                Camera1Humi = val1(1)
                Camera2Temp = val2(0)
                Camera2Humi = val2(1)

                tbCamera1.Text = Camera1Temp.ToString("0.0") + ", " + Camera1Humi.ToString("0") + "%"
                tbCamera2.Text = Camera2Temp.ToString("0.0") + ", " + Camera2Humi.ToString("0") + "%"
                tbColdWater.Text = ColdWaterTemp.ToString("0.0")
                tbHotWater.Text = HotWaterTemp.ToString("0.0")
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class
