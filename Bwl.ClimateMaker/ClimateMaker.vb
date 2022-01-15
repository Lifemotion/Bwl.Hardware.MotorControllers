Imports Bwl.Framework
Imports Bwl.Hardware.MotorController

Public Class ClimateMaker
    Inherits FormAppBase
    Private _mc4 As New MotorControllerFour

    Private Sub ClimateMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mc2set_Tick(sender As Object, e As EventArgs) Handles cameraSet.Tick
        If _mc4.IsConnected Then
            Try
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
                    _mc4.MotorDrivers = MotorControllerFour.MotorDriver.Driver1
                    _mc4.MotorAB = 100
                    _mc4.MotorCD = 100
                    If cbWater1.Checked Then _mc4.MotorAB = 0
                    If cbWater2.Checked Then _mc4.MotorCD = 0
                Else
                    _mc4.MotorDrivers = MotorControllerFour.MotorDriver.Driver5
                    _mc4.MotorAB = udHeatFan.Value * 10
                    _mc4.MotorCD = udCoolFan.Value * 10
                End If
                _mc4.SendValues()
            Catch ex As Exception
                _logger.AddError(ex.Message)
            End Try
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
                Dim pi = _mc4.GetPowerInfo()
                mc4state.Text = _mc4.BoardState.ToString + ", " + _mc4.BoardInfo + ", " + pi.Voltage.ToString("0.0") + "V, " + pi.Current.ToString("0.0") + "A"
                'Dim sb As New stringbuilder
                '_logger.AddInformation("")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub bHp_Click(sender As Object, e As EventArgs) Handles bHp.Click
        If udHeatFan.Value <= 8 Then udHeatFan.Value += 2
    End Sub
    Private Sub bHm_Click(sender As Object, e As EventArgs) Handles bHm.Click
        If udHeatFan.Value >= -8 Then udHeatFan.Value -= 2
    End Sub
    Private Sub bCm_Click(sender As Object, e As EventArgs) Handles bCm.Click
        If udCoolFan.Value >= -8 Then udCoolFan.Value -= 2
    End Sub

    Private Sub bCp_Click(sender As Object, e As EventArgs) Handles bCp.Click
        If udCoolFan.Value <= 8 Then udCoolFan.Value += 2
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        udHumi.Value = 20
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        udHumi.Value = 40
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        udHumi.Value = 60

    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        udHumi.Value = 80
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        udTemp.Value = 0
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        udTemp.Value = 10
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        udTemp.Value = 20
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        udTemp.Value = 40
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        udTemp.Value = -40
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        udTemp.Value = -20
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        udTemp.Value = -10
    End Sub

    Dim lastWater As DateTime = Now
    Private Sub timerAuto_Tick(sender As Object, e As EventArgs) Handles timerAuto.Tick
        If cbAuto1.Checked Or cbAuto2.Checked Then
            Dim humi = Camera1Humi
            Dim temp = Camera1Temp
            If cbAuto2.Checked Then
                humi = Camera2Humi
                temp = Camera2Temp
            End If

            If humi < udHumi.Value And (Now - lastWater).TotalSeconds > 60 Then
                cbWater1.Checked = True
                lastWater = Now
                timerAuto.Stop()
                For i = 1 To 30
                    Application.DoEvents()
                    Threading.Thread.Sleep(100)
                Next
                timerAuto.Start()
            Else
                cbWater1.Checked = 0
                cbWater2.Checked = 0
            End If



            If udTemp.Value > temp + 3 Then
                cbHeatPump.Checked = True
                If udHeatFan.Value <= 8 Then udHeatFan.Value += 2
            End If

            If udTemp.Value < temp Then
                cbHeatPump.Checked = False
                udHeatFan.Value = 0
            End If

            If udTemp.Value < temp - 3 Then
                cbCoolPump.Checked = True
                If udCoolFan.Value <= 8 Then udCoolFan.Value += 2
            End If

            If udTemp.Value > temp Then
                cbCoolPump.Checked = False
                udCoolFan.Value = 0
            End If


        End If
    End Sub

    Private Sub cbAuto2_CheckedChanged(sender As Object, e As EventArgs) Handles cbAuto2.CheckedChanged
        If cbAuto2.Checked And cbAuto1.Checked Then cbAuto1.Checked = False
    End Sub

    Private Sub cbAuto1_CheckedChanged(sender As Object, e As EventArgs) Handles cbAuto1.CheckedChanged
        If cbAuto2.Checked And cbAuto1.Checked Then cbAuto2.Checked = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
