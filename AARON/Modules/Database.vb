Imports MySql.Data.MySqlClient

Module Database

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = "root"
    Private database As String = "hardware"
    Public con As MySqlConnection


    Public Function Connect() As Boolean
        Try
            Dim connectionString As String = $"Server={server};Database={database};User ID={username};Password={password};"
            con = New MySqlConnection(connectionString)
            con.Open()
            Return True

        Catch ex As Exception

            MessageBox.Show("Error connecting to the database: " & ex.Message)
            Return False

        End Try
    End Function

    Public Sub DeleteEmployee(employeeId As String)
        If Connect() Then
            If Not String.IsNullOrEmpty(employeeId) Then
                Try

                    Dim query As String = $"DELETE FROM employees WHERE  employees.id = '{employeeId}'"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show($"[{employeeId}]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception

                    MessageBox.Show("Error deleting employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally

                    con.Close()
                End Try
            End If
        End If
    End Sub

    Sub comboBoxLoadItems(tablename As String, comboName As ComboBox, columnName As String)
        If Connect() Then
            Try

                Dim query As String = $"SELECT * FROM {tablename}"

                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using

                comboName.Items.Clear()

                For Each row As DataRow In dataTable.Rows
                    comboName.Items.Add(row($"{columnName}"))
                Next

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End If
    End Sub

    'Public Sub updateEmployee(username As TextBox, fullname As TextBox)
    '    If Connect() Then
    '        Try
    '            Dim query As String = $"UPDATE employees SET fullname = '{fnameTBUpdate.Text}', username = '{usnameTxtBoxUpdate.Text}', email = '{emailTxtBoxUpdate.Text.Trim()}', password = '{pwTBUpdate.Text()}', designation = '{desigBoxUpdate.Text.Trim()}', department = '{depBoxUpdate.Text.Trim()}', status = '{statusBoxUpdate.Text.Trim()}', remarks = '{remarksBoxUpdate.Text.Trim()}' WHERE employee_id = '{idTBUpdate.Text.Trim()}'"

    '            Using cmd As New MySqlCommand(query, con)
    '                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

    '                If rowsAffected > 0 Then
    '                    MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Else
    '                    MessageBox.Show("Update failed. No rows were affected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End If
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("Error updating employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End If
    'End Sub

    Sub loadTable(table As DataGridView)
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM request_form"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                table.DataSource = dataTable
            Catch ex As Exception

            End Try
        End If
    End Sub

    Sub ComboBoxLoad(tablename As String, checkCombo As ComboBox, columnName As String)
        If Connect() Then
            Try

                Dim query As String = $"SELECT * FROM {tablename}"

                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using

                checkCombo.Items.Clear()

                For Each row As DataRow In dataTable.Rows
                    checkCombo.Items.Add(row($"{columnName}"))
                Next

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End If
    End Sub
End Module
