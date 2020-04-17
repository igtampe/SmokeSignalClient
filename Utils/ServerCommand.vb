Imports System.IO
Imports System.Net.Sockets

''' <summary>ServerCommand is a utility that sends a command to a SmokeSignal server. </summary>
Public Class ServerCommand

    'REMEMBER TO OVERRIDE THE DEFAULT IP AND PORT!

    'Also consider not using this class *directly* when creating projects, rather create classes that hold the commands, and parse their arguements for sending.

    ''' <summary> Sends a bit of text to a SmokeSignal server </summary>
    ''' <param name="ClientMSG">Message to send to the server</param>
    ''' <param name="IP">IP of the server</param>
    ''' <param name="Port">Port of the server</param>
    ''' <returns>
    ''' NOCONNECT if ServerCommand was unbale to connect to the Server
    ''' CRASH if ServerCommand's connection to the server was abruptly cut
    ''' Otherwise, an actual message from the server.
    ''' </returns>
    Public Shared Function RawCommand(ByVal ClientMSG As String, Optional IP As String = "127.0.0.1", Optional Port As Integer = 797) As String

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerMSG As String

        ServerMSG = "E"

        'Check if the ClientMSG is blank, and if it is return an error flag
        If String.IsNullOrEmpty(ClientMSG.Trim) Then
            Throw New Exception("It is vacio. Why did u send something vacio")
        End If

        Try
            tc.Connect(IP, Port)
        Catch
            MsgBox("Unable to connect to the server.", MsgBoxStyle.Exclamation, "SmokeSignal Error")
            Return "NOCONNECT"
        End Try

        If tc.Connected = True Then
            ns = tc.GetStream
            br = New BinaryReader(ns)
            bw = New BinaryWriter(ns)

            bw.Write(ClientMSG)

            Try
                ServerMSG = br.ReadString()
            Catch
                MsgBox("Seems like the server might've crashed! Contact CHOPO!", MsgBoxStyle.Exclamation, "SmokeSignal Error")
                Return "CRASH"
            End Try

            tc.Close()
        End If

        Return ServerMSG

    End Function
End Class
