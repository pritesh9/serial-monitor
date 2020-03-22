<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.connectionButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.sendButton = New System.Windows.Forms.Button()
        Me.comSelection = New System.Windows.Forms.ComboBox()
        Me.rxText = New System.Windows.Forms.RichTextBox()
        Me.txText = New System.Windows.Forms.TextBox()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.baudSelection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(12, 12)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(75, 23)
        Me.refreshButton.TabIndex = 0
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'connectionButton
        '
        Me.connectionButton.Location = New System.Drawing.Point(347, 12)
        Me.connectionButton.Name = "connectionButton"
        Me.connectionButton.Size = New System.Drawing.Size(75, 23)
        Me.connectionButton.TabIndex = 1
        Me.connectionButton.Text = "Connect"
        Me.connectionButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clearButton.Location = New System.Drawing.Point(697, 12)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'sendButton
        '
        Me.sendButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sendButton.Location = New System.Drawing.Point(697, 41)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(75, 23)
        Me.sendButton.TabIndex = 3
        Me.sendButton.Text = "Send"
        Me.sendButton.UseVisualStyleBackColor = True
        '
        'comSelection
        '
        Me.comSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSelection.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comSelection.FormattingEnabled = True
        Me.comSelection.Location = New System.Drawing.Point(93, 13)
        Me.comSelection.Name = "comSelection"
        Me.comSelection.Size = New System.Drawing.Size(121, 21)
        Me.comSelection.TabIndex = 4
        '
        'rxText
        '
        Me.rxText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rxText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rxText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rxText.EnableAutoDragDrop = True
        Me.rxText.HideSelection = False
        Me.rxText.Location = New System.Drawing.Point(12, 70)
        Me.rxText.Name = "rxText"
        Me.rxText.Size = New System.Drawing.Size(760, 455)
        Me.rxText.TabIndex = 5
        Me.rxText.Text = ""
        '
        'txText
        '
        Me.txText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txText.Location = New System.Drawing.Point(12, 43)
        Me.txText.Name = "txText"
        Me.txText.Size = New System.Drawing.Size(679, 20)
        Me.txText.TabIndex = 6
        '
        'Timer1
        '
        '
        'baudSelection
        '
        Me.baudSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baudSelection.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.baudSelection.FormattingEnabled = True
        Me.baudSelection.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200", "230400", "500000", "1000000"})
        Me.baudSelection.Location = New System.Drawing.Point(220, 13)
        Me.baudSelection.Name = "baudSelection"
        Me.baudSelection.Size = New System.Drawing.Size(121, 21)
        Me.baudSelection.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 539)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Created by PRITESH PATEL. Find out more on blog.pritesh9.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.baudSelection)
        Me.Controls.Add(Me.txText)
        Me.Controls.Add(Me.rxText)
        Me.Controls.Add(Me.comSelection)
        Me.Controls.Add(Me.sendButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.connectionButton)
        Me.Controls.Add(Me.refreshButton)
        Me.MinimumSize = New System.Drawing.Size(530, 530)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serial Monitor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents refreshButton As Button
    Friend WithEvents connectionButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents sendButton As Button
    Friend WithEvents comSelection As ComboBox
    Friend WithEvents rxText As RichTextBox
    Friend WithEvents txText As TextBox
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents baudSelection As ComboBox
    Friend WithEvents Label1 As Label
End Class
