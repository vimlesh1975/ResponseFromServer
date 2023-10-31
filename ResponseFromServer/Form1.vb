Imports Microsoft.SqlServer
Imports Svt.Caspar
Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Dim casparDevice As New CasparDevice
    Dim tcpclient As New TcpClient()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect general client to the server
        casparDevice.Connect("127.0.0.1", 5250)

        ' Connect tcpclient to the server
        tcpclient.Connect("127.0.0.1", 5250)
    End Sub

    Sub sendStringAndgetResponse(str)
        ' Get the network stream for reading and writing
        Dim stream As NetworkStream = tcpclient.GetStream()

        ' Send a request to the server
        Dim request As String = str + vbCrLf
        Dim requestBytes As Byte() = Encoding.ASCII.GetBytes(request)
        stream.Write(requestBytes, 0, requestBytes.Length)

        ' Receive a response from the server
        Dim buffer(10024) As Byte
        Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)
        Dim response As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)

        Me.txtResponse.Text = response
    End Sub

    Private Sub cmdPlayRedColor_Click(sender As Object, e As EventArgs) Handles cmdPlayRedColor.Click
        casparDevice.SendString("play 1-1 red")
    End Sub

    Private Sub cmdSendCommand_Click(sender As Object, e As EventArgs) Handles cmdSendCommand.Click
        sendStringAndgetResponse(cmbCommand.Text)

    End Sub
End Class
