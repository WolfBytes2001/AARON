Imports MySql.Data.MySqlClient

Public Class arrivedStockss
    Public itemId As String
    Private Sub add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTab()
    End Sub
    Public Sub LoadTab()
        If Connect() Then
            Try
                Dim query As String = $"SELECT
	cart.item_id, 
	purchase_order.po_id, 
	cart.item_description, 
	cart.measure, 
	cart.quantity, 
	cart.category, 
	cart.price, 
	item_recieve.date_recieved
FROM
	purchase_order
	INNER JOIN
	request_form
	ON 
		purchase_order.pr_id = request_form.request_id
	INNER JOIN
	item_recieve
	ON 
		purchase_order.po_id = item_recieve.po_id
	INNER JOIN
	cart
	ON 
		request_form.request_id = cart.request_id
WHERE
	purchase_order.`status` = 'Delivered' AND
	cart.item_status = 'Not added'
																				"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                addTable.DataSource = dataTable
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Sub Add()
        Dim ColumnItemId As String = "item_id"

        If addTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = addTable.SelectedCells(0).RowIndex
            itemId = addTable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"Proceed to add item in inventory Item ID:{itemId}?", "APPROVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                'loadItemReview()
                'isSellable = False
                loadToInventory()
            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Only approved requests are allowed to be generated")
        End If
    End Sub

    Private Sub addTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles addTable.CellContentClick
        Add()
    End Sub


    Public Sub loadToInventory()

        If Connect() Then
            Try
                Dim sql = $"SELECT
	cart.item_id, 
	purchase_order.po_id, 
	cart.item_description, 
	cart.measure, 
	cart.quantity, 
	cart.category, 
	cart.price, 
	cart.total
FROM
	purchase_order
	INNER JOIN
	request_form
	ON 
		purchase_order.pr_id = request_form.request_id
	INNER JOIN
	cart
	ON 
		request_form.request_id = cart.request_id WHERE cart.item_id = '{itemId}' AND cart.item_status = 'Not added' "

                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()

                            Dashboard.inv.PO_ID.Text = reader("po_id").ToString()
                            Dashboard.inv.quantiBox.Text = reader("quantity").ToString()
                            Dashboard.inv.descripBox.Text = reader("item_description").ToString()
                            Dashboard.inv.cateBox.Text = reader("category").ToString()
                            Dashboard.inv.measBox.Text = reader("measure").ToString()
                            Dashboard.inv.priceBox.Text = reader("price").ToString()
                            Dashboard.inv.totBox.Text = reader("total").ToString
                            Dashboard.inv.itemIDD.Text = reader("item_id").ToString

                            If Dashboard.inv.isForSaleBox.Checked Then
                                Dashboard.inv.invID.Text = generateCATID()
                            Else
                                Dashboard.inv.invID.Text = GenerateInventoryID()
                            End If

                        End While
                    End If

                    reader.Close()
                End Using
                'LoadTabs()
            Catch ex As Exception
                MessageBox.Show("Error loading purchase order: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Connection error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub SearchControl1_TextChanged(sender As Object, e As EventArgs)
        'Dim keyword As String = SearchControl1.Text.Trim()

        'If Not String.IsNullOrEmpty(keyword) Then
        '    If Connect() Then
        '        Try
        '            Dim query As String = $"SELECT * FROM supplies WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"
        '            Dim dataTable As New DataTable()

        '            Using cmd As New MySqlCommand(query, con)

        '                Dim adapter As New MySqlDataAdapter(cmd)


        '                adapter.Fill(dataTable)
        '                addTable.DataSource = dataTable

        '            End Using
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message)
        '        End Try

        '    End If
        'End If
    End Sub
End Class