Public Class SmokeSignalTestWindow

    Public log As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clientmsg As String = ClientMSGTXB.Text
        If String.IsNullOrEmpty(clientmsg) Then Exit Sub
        log = log & "[SERVER] " & RawCommand(clientmsg, IPTXB.Text, PortTXB.Text) & vbNewLine
        RepliesTXB.Text = log
    End Sub

End Class
