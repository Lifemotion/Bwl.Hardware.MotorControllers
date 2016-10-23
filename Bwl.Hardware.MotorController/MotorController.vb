Imports Bwl.Hardware.Serial
Imports Bwl.Hardware.SimplSerial

Public Enum BoardState
    notFound
    connecting
    connected
End Enum

Public MustInherit Class MotorController
    Public Property SimplSerialNameToFind As String = ""
    Public Property BoardState As BoardState = BoardState.notFound
    Public Property BoardInfo As String = ""

    Protected _serial As New FastSerialPort
    Protected _ss As New SimplSerialBus(_serial)

    Public Sub New()
        Dim thread As New Threading.Thread(AddressOf WorkThread)
        thread.IsBackground = True
        thread.Start()
    End Sub

    Private Function FindPort() As String
        Dim devices = System.IO.Ports.SerialPort.GetPortNames
        For Each port In devices
            If port.ToLower.Contains("com") Or port.ToLower.Contains("ttyusb") Then
                Dim testSS As New SimplSerialBus(port)
                Dim result = ""
                testSS.SerialDevice.DeviceSpeed = 9600
                Try
                    testSS.Connect()
                    Dim info = testSS.RequestDeviceInfo(0)
                    If info.DeviceName.Contains(SimplSerialNameToFind) Then result = port
                Catch ex As Exception
                End Try
                Try
                    testSS.Disconnect()
                    testSS.SerialDevice.Disconnect()
                Catch ex As Exception
                End Try
                If result > "" Then Return result
            End If
        Next
        Return ""
    End Function

    Private Sub WorkThread()
        Do
            Threading.Thread.Sleep(1000)
            Try
                If _ss.IsConnected = False Then
                    _BoardInfo = ""
                    _BoardState = BoardState.connecting

                    _serial.DeviceAddress = FindPort()
                    If _serial.DeviceAddress = "" Then
                        _BoardState = BoardState.notFound
                        Threading.Thread.Sleep(10000)
                    Else
                        _BoardState = BoardState.connecting
                        _serial.DeviceSpeed = 9600
                        _ss.Connect()
                        _BoardInfo = _ss.RequestDeviceInfo(0).DeviceName
                    End If
                Else
                    _BoardState = BoardState.connected
                End If
            Catch ex As Exception
            End Try
        Loop
    End Sub

    Public ReadOnly Property SS As SimplSerialBus
        Get
            Return _ss
        End Get
    End Property

    Public ReadOnly Property IsConnected As Boolean
        Get
            Return BoardState = BoardState.connected
        End Get
    End Property

End Class
