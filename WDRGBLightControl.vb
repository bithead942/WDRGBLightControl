Module Module1

    Sub Main(ByVal CmdArgs() As String)
        Dim strR, strG, strB As String
        Dim iR, iG, iB As Integer
        Dim serialPort1 As System.IO.Ports.SerialPort

        If CmdArgs.Length = 3 Then
            Try
                iR = CInt(CmdArgs(0))
                iG = CInt(CmdArgs(1))
                iB = CInt(CmdArgs(2))

                If iR <= 255 And iR >= 0 Then
                    strR = iR.ToString
                Else
                    End
                End If
                If iG <= 255 And iG >= 0 Then
                    strG = iG.ToString
                Else
                    End
                End If
                If iB <= 255 And iB >= 0 Then
                    strB = iB.ToString
                Else
                    End
                End If

                serialPort1 = New System.IO.Ports.SerialPort("COM5")
                serialPort1.BaudRate = 9600
                serialPort1.DataBits = 8
                serialPort1.Parity = Parity.None
                serialPort1.StopBits = StopBits.One

                serialPort1.Open()
                serialPort1.Write("r=" & strR & ", g=" & strG & ", b=" & strB & Chr(13))
                serialPort1.Close()

            Catch ex As Exception
                'Do nothing
            End Try
        End If

    End Sub

End Module
