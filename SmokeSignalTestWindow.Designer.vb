<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmokeSignalTestWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IPTXB = New System.Windows.Forms.TextBox()
        Me.PortTXB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RepliesTXB = New System.Windows.Forms.TextBox()
        Me.ClientMSGTXB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 607)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Remember to probably remove this from your application when you're done!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IP"
        '
        'IPTXB
        '
        Me.IPTXB.Location = New System.Drawing.Point(349, 14)
        Me.IPTXB.Name = "IPTXB"
        Me.IPTXB.Size = New System.Drawing.Size(100, 20)
        Me.IPTXB.TabIndex = 2
        Me.IPTXB.Text = "127.0.0.1"
        '
        'PortTXB
        '
        Me.PortTXB.Location = New System.Drawing.Point(349, 40)
        Me.PortTXB.Name = "PortTXB"
        Me.PortTXB.Size = New System.Drawing.Size(100, 20)
        Me.PortTXB.TabIndex = 4
        Me.PortTXB.Text = "797"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(317, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SmokeSignal Test Client"
        '
        'RepliesTXB
        '
        Me.RepliesTXB.Location = New System.Drawing.Point(12, 87)
        Me.RepliesTXB.Multiline = True
        Me.RepliesTXB.Name = "RepliesTXB"
        Me.RepliesTXB.ReadOnly = True
        Me.RepliesTXB.Size = New System.Drawing.Size(437, 482)
        Me.RepliesTXB.TabIndex = 6
        '
        'ClientMSGTXB
        '
        Me.ClientMSGTXB.Location = New System.Drawing.Point(12, 577)
        Me.ClientMSGTXB.Name = "ClientMSGTXB"
        Me.ClientMSGTXB.Size = New System.Drawing.Size(331, 20)
        Me.ClientMSGTXB.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Server Responses:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SmokeSignalTestWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 638)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ClientMSGTXB)
        Me.Controls.Add(Me.RepliesTXB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PortTXB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IPTXB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SmokeSignalTestWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SmokeSignal Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IPTXB As TextBox
    Friend WithEvents PortTXB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RepliesTXB As TextBox
    Friend WithEvents ClientMSGTXB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
