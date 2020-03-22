Public Class mainForm

    Dim serial As IO.Ports.SerialPort
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baudSelection.SelectedIndex = 11
        sendButton.Enabled = False
        comSelection.Items.Clear()
        ' Show all available COM ports.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comSelection.Items.Add(sp)
        Next
        comSelection.SelectedIndex = 0
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        If (connectionButton.Text Is "Connect") Then
            comSelection.Items.Clear()
            ' Show all available COM ports.
            For Each sp As String In My.Computer.Ports.SerialPortNames
                comSelection.Items.Add(sp)
            Next
            comSelection.SelectedIndex = 0
        End If
    End Sub

    Private Sub connectionButton_Click(sender As Object, e As EventArgs) Handles connectionButton.Click
        If (connectionButton.Text Is "Connect") Then
            If (comSelection.Text IsNot "") Then
                Try
                    serial = My.Computer.Ports.OpenSerialPort(comSelection.Text)
                    serial.BaudRate = baudSelection.Text
                    Timer1.Interval = 500
                    Timer1.Start()
                Catch ex As Exception
                    MessageBox.Show("Error!")
                    Return
                End Try
                connectionButton.Text = "Disconnect"
                sendButton.Enabled = True
                comSelection.Enabled = False
                baudSelection.Enabled = False
            End If

        ElseIf (connectionButton.Text Is "Disconnect") Then

            Try
                serial.Close()
                Timer1.Stop()
            Catch ex As Exception
                MessageBox.Show("Error!")
            End Try
            connectionButton.Text = "Connect"
            sendButton.Enabled = False
            comSelection.Enabled = True
            baudSelection.Enabled = True
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        rxText.ResetText()
    End Sub

    Private Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        If (connectionButton.Text Is "Disconnect") Then

            Try
                serial.Write(txText.Text)
            Catch ex As Exception
                MessageBox.Show("Error!")
                Return
            End Try

            txText.ResetText()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (serial.IsOpen) Then
            Try
                If (serial.ReadBufferSize >= 0) Then
                    rxText.AppendText(serial.ReadExisting())
                End If
            Catch ex As Exception
                MessageBox.Show("Error!")
            End Try

        End If
    End Sub

End Class
