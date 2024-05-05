Imports MySql.Data.MySqlClient

Public Class item_recieved

    Private Sub recieveButton_Click(sender As Object, e As EventArgs) Handles recieveButton.Click
        Dim poId As String = recPOID.Text
        Dim personnel As String = personnelDe.Text
        Dim vehicle As String = vehicleType.Text
        Dim recievedBy As String = InspectedBy.Text
        Dim dateRecieved As String = recieveOn.Text
        Dim item_condition As String = condition.Text

        If Connect() Then

            If String.IsNullOrEmpty(poId) OrElse
               String.IsNullOrEmpty(personnel) OrElse
               String.IsNullOrEmpty(vehicle) OrElse
               String.IsNullOrEmpty(recievedBy) OrElse
               String.IsNullOrEmpty(item_condition) OrElse
               String.IsNullOrEmpty(dateRecieved) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query = $"INSERT INTO item_recieve (po_id, personnel, vehicle, date_recieved,recieved_by,item_condition) VALUES   ('{poId}', '{personnel}', '{vehicle}', '{dateRecieved}','{recievedBy}', '{item_condition}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Order recieved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearForm()
                    Dim updateQuery = $"UPDATE purchase_order SET status = 'Delivered' WHERE po_id = '{poId}' "
                    Using updateCmd As New MySqlCommand(updateQuery, con)
                        updateCmd.ExecuteNonQuery()
                    End Using



                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Sub clearForm()
        recPOID.Text = ""
        personnelDe.Text = ""
        InspectedBy.Text = ""
        recieveOn.Text = ""
        vehicleType.Text = ""
        condition.Text = " "
    End Sub
End Class
