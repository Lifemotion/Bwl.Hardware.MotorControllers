Public Class MotorControllerFour
    Inherits MotorController
    Public Class PowerInfo
        Public Property Voltage As Single
        Public Property Current As Single
        Public Overrides Function ToString() As String
            Return "V = " + Voltage.ToString("0.0") + ", I = " + Current.ToString("0.00")
        End Function
    End Class


    Public Property MotorAB As Integer = 0
    Public Property MotorCD As Integer = 0
    Public Property MotorDriver As Integer = 255

    Public Property Servo1 As Integer = 50
    Public Property Servo2 As Integer = 50
    Public Property Servo3 As Integer = 50
    Public Property Servo4 As Integer = 50

    Public Sub New()
        SimplSerialNameToFind = "BwlMtrCntFour"
    End Sub

    Private Function FitTo100(val As Integer) As Byte
        If val < 0 Then val = 0
        If val > 100 Then val = 100
        Return val
    End Function

    Public Function GetPowerInfo() As PowerInfo
        Dim response = SS.Request(0, 88, {0})
        If response.ResponseState = SimplSerial.ResponseState.ok Then
            Dim result As New PowerInfo
            result.Voltage = (CInt(response.Data(0)) * 256 + CInt(response.Data(1))) / 1000.0
            result.Current = (CInt(response.Data(2)) * 256 + CInt(response.Data(3))) / 1000.0
            Return result
        Else
            Throw New Exception(response.ToString)
        End If
    End Function

    Public Function GetADCVoltage(channel As Integer, average As Integer) As Single
        Dim response = SS.Request(0, 99, {CByte(channel), CByte(average)})
        If response.ResponseState = SimplSerial.ResponseState.ok Then
            Dim result = (CInt(response.Data(0)) * 256 + CInt(response.Data(1))) / 1000.0
            Return result
        Else
            Throw New Exception(response.ToString)
        End If
    End Function

    Public Sub SendValues()
        Static lastMotorAB As Integer
        Static lastMotorCD As Integer
        Static lastMotorDriver As Integer
        Static lastServo1 As Integer
        Static lastServo2 As Integer
        Static lastServo3 As Integer
        Static lastServo4 As Integer

        Dim data As New List(Of Byte)

        If lastMotorAB <> MotorAB Then
            If MotorAB < 0 Then
                data.AddRange({10, 0, 0, 10, 1, FitTo100(-MotorAB)})
            Else
                data.AddRange({10, 0, 100, 10, 1, FitTo100(100 - MotorAB)})
            End If
        End If

        If lastMotorCD <> MotorCD Then
            If MotorCD < 0 Then
                data.AddRange({10, 2, 0, 10, 3, FitTo100(-MotorCD)})
            Else
                data.AddRange({10, 2, 100, 10, 3, FitTo100(100 - MotorCD)})
            End If
        End If

        If lastMotorDriver <> MotorDriver Then data.AddRange({30, FitTo100(MotorDriver), 0})

        If lastServo1 <> Servo1 Then data.AddRange({20, 1, FitTo100(Servo1)})
        If lastServo2 <> Servo2 Then data.AddRange({20, 2, FitTo100(Servo2)})
        If lastServo3 <> Servo3 Then data.AddRange({20, 3, FitTo100(Servo3)})
        If lastServo4 <> Servo4 Then data.AddRange({20, 4, FitTo100(Servo4)})

        If data.Count = 0 Then data.AddRange({0, 0, 0})

        If SS.IsConnected Then
            SS.Send(New SimplSerial.SSRequest(0, 77, data.ToArray))
            lastMotorAB = MotorAB
            lastMotorCD = MotorCD
            lastMotorDriver = MotorDriver
            lastServo1 = Servo1
            lastServo2 = Servo2
            lastServo3 = Servo3
            lastServo4 = Servo4
        End If
    End Sub

End Class
