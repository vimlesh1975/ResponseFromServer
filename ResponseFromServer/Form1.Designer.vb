<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdPlayRedColor = New System.Windows.Forms.Button()
        Me.cmdSendCommand = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.cmbCommand = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdPlayRedColor
        '
        Me.cmdPlayRedColor.Location = New System.Drawing.Point(12, 12)
        Me.cmdPlayRedColor.Name = "cmdPlayRedColor"
        Me.cmdPlayRedColor.Size = New System.Drawing.Size(105, 23)
        Me.cmdPlayRedColor.TabIndex = 1
        Me.cmdPlayRedColor.Text = "Play red color"
        Me.cmdPlayRedColor.UseVisualStyleBackColor = True
        '
        'cmdSendCommand
        '
        Me.cmdSendCommand.Location = New System.Drawing.Point(269, 42)
        Me.cmdSendCommand.Name = "cmdSendCommand"
        Me.cmdSendCommand.Size = New System.Drawing.Size(123, 23)
        Me.cmdSendCommand.TabIndex = 3
        Me.cmdSendCommand.Text = "Send Command"
        Me.cmdSendCommand.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Command"
        '
        'txtResponse
        '
        Me.txtResponse.Location = New System.Drawing.Point(12, 86)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResponse.Size = New System.Drawing.Size(380, 553)
        Me.txtResponse.TabIndex = 5
        '
        'cmbCommand
        '
        Me.cmbCommand.FormattingEnabled = True
        Me.cmbCommand.Items.AddRange(New Object() {"version Server", "info 1", "info 1-1", "INFO CONFIG"})
        Me.cmbCommand.Location = New System.Drawing.Point(81, 48)
        Me.cmbCommand.Name = "cmbCommand"
        Me.cmbCommand.Size = New System.Drawing.Size(157, 21)
        Me.cmbCommand.TabIndex = 6
        Me.cmbCommand.Text = "INFO CONFIG"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 651)
        Me.Controls.Add(Me.cmbCommand)
        Me.Controls.Add(Me.txtResponse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSendCommand)
        Me.Controls.Add(Me.cmdPlayRedColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPlayRedColor As Button
    Friend WithEvents cmdSendCommand As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResponse As TextBox
    Friend WithEvents cmbCommand As ComboBox
End Class
