Imports MySql.Data.MySqlClient

Public Class pos

    Public transaction_number As String


    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posTRNUM.Text = GenerateTransactionID()
        LoadTable()

    End Sub

    Sub emptyCart()
        If Connect() Then
            Try
                Dim query As String = "DELETE FROM pos_cart WHERE isCommitted='Pending'"
                Using cmd As New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using
                ' Refresh the table data after emptying the cart
                LoadTable()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Sub LoadTable()


        If Connect() Then
            Try
                Dim query As String = $"SELECT
	inventory.inventory_id, 
	pos_cart.description, 
	pos_cart.quantity, 
	pos_cart.price, 
	pos_cart.total
FROM
	pos_cart
	INNER JOIN
	inventory
	ON 
		pos_cart.catalog_id = inventory.inventory_id WHERE transaction_number = '{posTRNUM.Text}'
                                    AND isCommitted ='Pending'"
                Dim dataTable As New DataTable()
                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using

                ' Bind the data to the DataGridView
                cartTable.DataSource = dataTable

                ' Calculate subtotal
                Dim subtotal As Decimal = 0
                For Each row As DataRow In dataTable.Rows
                    subtotal += Convert.ToDecimal(row("total"))
                Next

                ' Apply discount if the discount checkbox is checked
                Dim discount As Decimal = 0
                If posDiscount.Checked Then
                    ' Apply your discount logic here, for example:
                    discount = subtotal * 0.05 ' Assuming a 10% discount
                End If

                ' Apply tax
                Dim tax As Decimal = Convert.ToDecimal(posTax.Text)

                ' Calculate total amount
                Dim totalAmount As Decimal = (subtotal - discount) * (1 + tax / 100)

                ' Update UI
                posSubTotal.Text = subtotal.ToString()

                posTotal.Text = totalAmount.ToString()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub posDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles posDiscount.CheckedChanged
        ' Recalculate total amount whenever the discount checkbox is checked or unchecked
        CalculateTotalAmount()
    End Sub

    Private Sub CalculateTotalAmount()
        Dim subtotal As Decimal = Convert.ToDecimal(posSubTotal.Text)
        Dim originalSubtotal As Decimal = subtotal ' Store the original subtotal

        If posDiscount.Checked Then
            Dim disc As Decimal = subtotal * 0.05 ' Assuming a 5% discount
            subtotal -= disc ' Apply the discount
        End If

        ' Apply tax
        Dim tax As Decimal = Convert.ToDecimal(posTax.Text)
        Dim totalAmount As Decimal = subtotal * (1 + tax / 100)

        ' Update UI
        posTotal.Text = totalAmount.ToString()

        ' If discount is unchecked, revert to the original subtotal
        If Not posDiscount.Checked Then
            posSubTotal.Text = originalSubtotal.ToString()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Save()
    End Sub


    Sub Save()
        Dim tran As String = posTRNUM.Text
        Dim tot As String = posTotal.Text
        Dim name As String = buyerName.Text
        Dim contact As String = contactInfo.Text
        If String.IsNullOrEmpty(tran) OrElse String.IsNullOrEmpty(tot) Then
            MessageBox.Show("Add an item first")
        Else
            If Connect() Then
                Try
                    ' Begin a transaction to ensure atomicity
                    Dim transaction As MySqlTransaction = con.BeginTransaction()

                    ' Insert the transaction details into the transaction table
                    Dim query As String = $"INSERT INTO transaction(transaction_id,total_amount,buyerName,buyerContact)VALUES('{tran}',{tot},'{name}','{contact}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Update the quantities of products in the cart
                    For Each row As DataGridViewRow In cartTable.Rows
                        Dim catalog_id As String = If(row.Cells("inventory_id").Value IsNot Nothing, row.Cells("inventory_id").Value.ToString(), "")

                        Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value)

                        ' Update the quantity in the database
                        Dim updateQuery As String = $"UPDATE inventory SET quantity = quantity - {quantity} WHERE inventory_id = '{catalog_id}'"
                        Using cmd As New MySqlCommand(updateQuery, con)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    ' Update the status of the cart items to 'Done'
                    Dim query2 As String = $"UPDATE pos_cart SET isCommitted = 'Done' WHERE transaction_number = '{tran}'"
                    Using cmd As New MySqlCommand(query2, con)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Commit the transaction
                    transaction.Commit()

                    MessageBox.Show("Transaction saved successfully")

                    ' Refresh the table data after saving the transaction
                    LoadTable()
                    emptyCart()
                    buyerName.Text = ""
                    contactInfo.Text = ""
                    posTRNUM.Text = GenerateTransactionID()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        emptyCart()
        LoadTable()
        posSubTotal.Text = ""
        posTotal.Text = ""
    End Sub

    Private Sub cartTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles cartTable.CellContentClick
        delete()
    End Sub

    Sub delete()




        Dim ColumnItemId As String = "inventory_id"
        Dim catalog_id As String

        If cartTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = cartTable.SelectedCells(0).RowIndex
            catalog_id = cartTable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"DELETE Item with catalog id: {catalog_id}?", "DELETE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                If Connect() Then
                    Try
                        Dim query As String = $"DELETE FROM pos_cart WHERE catalog_id = '{catalog_id}'"
                        Using cmd As New MySqlCommand(query, con)
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Deleted Successfully")
                        LoadTable()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            ElseIf result = DialogResult.No Then

            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Else
            MessageBox.Show("///")
        End If
    End Sub

    Private Sub SearchControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim search As New productList
        search.LoadTable()
        search.transaction_number = posTRNUM.Text
        search.Show()
    End Sub
End Class
