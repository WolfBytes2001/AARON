Imports MySql.Data.MySqlClient

Public Class productList
    Public catalog_id As String
    Public transaction_number As String
    Private Sub posSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Sub LoadTable()
        If Connect() Then
            Try
                Dim query As String = "SELECT inventory.inventory_id, inventory.description, inventory.srp, inventory.measurement FROM inventory"
                Dim dataTable As New DataTable()
                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                searchTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles posSearchQuantity.ValueChanged
        CalculateTotalAmount()
    End Sub

    Sub CalculateTotalAmount()
        Dim totalAmount As Decimal = 0
        Dim selectedItemPrice As Decimal = 0

        If searchTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = searchTable.SelectedCells(0).RowIndex
            Dim selectedRow As DataGridViewRow = searchTable.Rows(selectedRowIndex)

            ' Assuming the price is in the third column (index 2)
            If Decimal.TryParse(selectedRow.Cells(2).Value?.ToString(), selectedItemPrice) Then
                totalAmount = posSearchQuantity.Value * selectedItemPrice
            End If
        End If

        ' Assuming there's a TextBox named 'totalAmountTextBox' to display the total amount
        poSearchTotal.Text = totalAmount.ToString()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        addToCart()
        Dashboard.pos.LoadTable()
    End Sub


    Sub addToCart()
        Dim ColumnItemId As String = "inventory_id"

        If searchTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = searchTable.SelectedCells(0).RowIndex
            catalog_id = searchTable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            If Connect() Then
                Try
                    ' Retrieve item details
                    Dim itemDescription As String = searchTable.Rows(selectedRowIndex).Cells("description").Value?.ToString()
                    Dim itemPrice As Decimal = Convert.ToDecimal(searchTable.Rows(selectedRowIndex).Cells("srp").Value)

                    ' Insert item into poscart database
                    Dim query As String = $"INSERT INTO pos_cart (catalog_id, description, price, quantity,transaction_number,total) VALUES (@catalog_id, @description, @price, @quantity,@transaction_number,@total)"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@catalog_id", catalog_id)
                        cmd.Parameters.AddWithValue("@description", itemDescription)
                        cmd.Parameters.AddWithValue("@price", itemPrice)
                        ' Assuming you have a separate numericUpDown control for specifying quantity named numericUpDownQuantity
                        cmd.Parameters.AddWithValue("@quantity", posSearchQuantity.Value)
                        cmd.Parameters.AddWithValue("@transaction_number", transaction_number)
                        cmd.Parameters.AddWithValue("@total", poSearchTotal.Text)

                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Item added to cart successfully.")
                    Dashboard.pos.LoadTable()
                Catch ex As Exception
                    MessageBox.Show("Failed to add item to cart: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub poSearchBar_TextChanged(sender As Object, e As EventArgs) Handles poSearchBar.TextChanged
        Dim keyword As String = poSearchBar.Text.Trim()

        If Not String.IsNullOrEmpty(keyword) Then
            If Connect() Then
                Try
                    Dim query As String = $"SELECT * FROM catalog WHERE catalog_id LIKE '%{keyword}%' OR category LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"
                    Dim dataTable As New DataTable()

                    Using cmd As New MySqlCommand(query, con)

                        Dim adapter As New MySqlDataAdapter(cmd)


                        adapter.Fill(dataTable)
                        searchTable.DataSource = dataTable

                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub
End Class