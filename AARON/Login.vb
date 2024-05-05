Imports MySql.Data.MySqlClient

Public Class Login
    Public username As String
    Private Sub usernameBox_Click(sender As Object, e As EventArgs) Handles usernameBox.Click
        usernameBox.Text = ""
    End Sub

    Private Sub passwordBox_Click(sender As Object, e As EventArgs) Handles passwordBox.Click
        passwordBox.Text = ""
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim username As String = usernameBox.Text.Trim()
        Dim password As String = passwordBox.Text.Trim()
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM admin WHERE username = @username AND `password` = @password"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            username = reader("fullname").ToString()

                        End While

                        MessageBox.Show($"WELCOME {username} ", "Authentication Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dashboard.isLogin = True
                        Dashboard.Show()
                        Me.Hide()



                    Else
                        MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    End If

                    reader.Close()

                End Using
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub LoginAuth_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Dashboard.isLogin = False Then
            Dashboard.Close()
        Else
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dashboard.Close()
            ElseIf result = DialogResult.No Then
                Me.Show()
            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class