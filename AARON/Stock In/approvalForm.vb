Imports MySql.Data.MySqlClient

Public Class approvalForm
    Public requestID As String
    Sub loadTableRequestApproval(table As DataGridView)

        If Connect() Then
            Try
                Dim query As String = "SELECT
	                                        request_form.request_id, 
	                                        request_form.request_by, 
	                                        request_form.source_of_fund, 
	                                        request_form.purpose, 
	                                        request_form.total_amount, 
	                                        request_form.requested_at
                                        FROM
	                                        request_form WHERE status = 'Pending'"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                table.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RequestApprovalControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTableRequestApproval(forApprovalTable)
    End Sub


    Sub Approve()

        Dim reqID As String = "request_id"

        If forApprovalTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = forApprovalTable.SelectedCells(0).RowIndex
            requestID = forApprovalTable.Rows(selectedRowIndex).Cells(reqID).Value?.ToString()

            If Not String.IsNullOrEmpty(incharge.Text) Then
                Dim result As DialogResult = MessageBox.Show($"Proceed to approve Request ID:{requestID}", "APPROVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                If result = DialogResult.OK Then
                    If Connect() Then
                        Try
                            Dim query As String = $"UPDATE request_form SET status = 'Approved' WHERE request_id = '{requestID}'"

                            Using cmd As New MySqlCommand(query, con)
                                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                                If rowsAffected > 0 Then
                                    MessageBox.Show("Request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    saveData()
                                Else
                                    MessageBox.Show("Approval  failed. No rows were affected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End Using
                        Catch ex As Exception
                            MessageBox.Show("Update failed" & ex.Message)
                        End Try
                    End If


                Else
                    MessageBox.Show("Update operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'Else
                '    MessageBox.Show("EMPTY")
            Else
                MessageBox.Show("Please fill up approval officer detail ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Else
            MessageBox.Show("Select a row")
        End If
    End Sub

    Sub DisApprove()

        Dim reqID As String = "request_id"

        If forApprovalTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = forApprovalTable.SelectedCells(0).RowIndex
            requestID = forApprovalTable.Rows(selectedRowIndex).Cells(reqID).Value?.ToString()

            If Not String.IsNullOrEmpty(incharge.Text) Then
                Dim result As DialogResult = MessageBox.Show($"Proceed to approve Request ID:{requestID}", "APPROVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                If result = DialogResult.OK Then
                    If Connect() Then
                        Try
                            Dim query As String = $"UPDATE request_form SET status = 'Rejected' WHERE request_id = '{requestID}'"

                            Using cmd As New MySqlCommand(query, con)
                                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                                If rowsAffected > 0 Then
                                    MessageBox.Show("Request Rejected!", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                Else
                                    MessageBox.Show("Approval  failed. No rows were affected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End Using
                        Catch ex As Exception
                            MessageBox.Show("Update failed" & ex.Message)
                        End Try
                    End If


                Else
                    MessageBox.Show("Update operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'Else
                '    MessageBox.Show("EMPTY")
            Else
                MessageBox.Show("Please fill up approval officer detail ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Else
            MessageBox.Show("Select a row")
        End If
    End Sub
    Sub saveData()
        Dim approvalOff As String = incharge.Text

        If Connect() Then

            If String.IsNullOrEmpty(approvalOff) Then
                MessageBox.Show("Please fill up approval officer details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query As String = $"INSERT INTO approved_request(request_id,approved_by)
                VALUES ('{requestID}','{inchargeTxt.Text}')"


                    Using cmd As New MySqlCommand(query, con)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Saved  failed. No rows were affected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Saved failed" & ex.Message)
                End Try
            End If



        End If

    End Sub


    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If String.IsNullOrEmpty(inchargeTxt.Text) Then
            MessageBox.Show("Identify who is incharge")
        Else
            Approve()
            loadTableRequestApproval(forApprovalTable)
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DisApprove()
        loadTableRequestApproval(forApprovalTable)
    End Sub
End Class
