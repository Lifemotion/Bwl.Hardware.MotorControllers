Public Class MotorControllerTwo
    Inherits MotorController

    Public Property BigMotor0 As Integer = 0
    Public Property Servo0 As Integer = 50
    Public Property Servo1 As Integer = 50
    Public Property Servo2 As Integer = 50
    Public Property Servo3 As Integer = 50
    Public Property Servo4 As Integer = 50
    Public Property Servo5 As Integer = 50
    Public Property Servo6 As Integer = 50
    Public Property Servo7 As Integer = 50
    Public Property Motor0 As Integer = 0
    Public Property Motor1 As Integer = 0
    Public Property Motor2 As Integer = 0
    Public Property Motor3 As Integer = 0

    Public Sub New()
        SimplSerialNameToFind = "BwlMtrCntTwo"
    End Sub

    Private Function FitTo100(val As Integer) As Byte
        If val < 0 Then val = 0
        If val > 100 Then val = 100
        Return val
    End Function

    Public Sub SendValues()
        Static lastBigMotor As Integer
        Static lastServo0 As Integer
        Static lastServo1 As Integer
        Static lastServo2 As Integer
        Static lastServo3 As Integer
        Static lastServo4 As Integer
        Static lastServo5 As Integer
        Static lastServo6 As Integer
        Static lastServo7 As Integer
        Static lastMotor0 As Integer
        Static lastMotor1 As Integer
        Static lastMotor2 As Integer
        Static lastMotor3 As Integer
        Dim data As New List(Of Byte)

        If lastBigMotor <> BigMotor0 Then
            If BigMotor0 < 0 Then
                data.AddRange({10, 0, 0, 10, 1, FitTo100(-BigMotor0)})
            Else
                data.AddRange({10, 0, 100, 10, 1, FitTo100(BigMotor0)})
            End If
        End If

        If lastServo0 <> Servo0 Then data.AddRange({20, 0, FitTo100(Servo0)})
        If lastServo1 <> Servo1 Then data.AddRange({20, 1, FitTo100(Servo1)})
        If lastServo2 <> Servo2 Then data.AddRange({20, 2, FitTo100(Servo2)})
        If lastServo3 <> Servo3 Then data.AddRange({20, 3, FitTo100(Servo3)})
        If lastServo4 <> Servo4 Then data.AddRange({20, 4, FitTo100(Servo4)})
        If lastServo5 <> Servo5 Then data.AddRange({20, 5, FitTo100(Servo5)})
        If lastServo6 <> Servo6 Then data.AddRange({20, 6, FitTo100(Servo6)})
        If lastServo7 <> Servo7 Then data.AddRange({20, 7, FitTo100(Servo7)})
        If lastMotor0 <> Motor0 Then data.AddRange({30, 0, FitTo100(Motor0)})
        If lastMotor1 <> Motor1 Then data.AddRange({30, 0, FitTo100(Motor1)})
        If lastMotor2 <> Motor2 Then data.AddRange({30, 0, FitTo100(Motor2)})
        If lastMotor3 <> Motor3 Then data.AddRange({30, 0, FitTo100(Motor3)})

        If data.Count = 0 Then data.AddRange({0, 0, 0})

        If SS.IsConnected Then
            SS.Send(New SimplSerial.SSRequest(0, 77, data.ToArray))
            lastBigMotor = BigMotor0
            lastServo0 = Servo0
            lastServo1 = Servo1
            lastServo2 = Servo2
            lastServo3 = Servo3
            lastServo4 = Servo4
            lastServo5 = Servo5
            lastServo6 = Servo6
            lastServo7 = Servo7
            lastMotor0 = Motor0
            lastMotor1 = Motor1
            lastMotor2 = Motor2
            lastMotor3 = Motor3
        End If
    End Sub

End Class
