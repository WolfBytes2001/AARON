Imports MySql.Data.MySqlClient

Public Class addNewStock
    Public item_id As String
    Public inventory_id
    Dim forsale As Int16

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Dim addItem As New arrivedStockss
        addItem.Show()
    End Sub
    Sub update()




        Dim ColumnItemId As String = "inventory_id"

        If allItemsTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = allItemsTable.SelectedCells(0).RowIndex
            inventory_id = allItemsTable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"UPDATE Item ID: {inventory_id}?", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                loadToInventory()
            ElseIf result = DialogResult.No Then

            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Else
            MessageBox.Show("///")
        End If
    End Sub

    Public Sub loadToInventory()
        invID.Text = inventory_id
        If Connect() Then
            Try
                Dim sql = $"SELECT
	                            inventory.*
                            FROM
	                            inventory WHERE inventory.inventory_id = '{inventory_id}'"


                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()

                            Dashboard.inv.PO_ID.Text = reader("po_id").ToString()
                            Dashboard.inv.retailPrice.Text = reader("srp").ToString()
                            Dashboard.inv.quantiBox.Text = reader("quantity").ToString()
                            Dashboard.inv.descripBox.Text = reader("description").ToString
                            Dashboard.inv.cateBox.Text = reader("category").ToString()
                            Dashboard.inv.measBox.Text = reader("measurement").ToString()
                            Dashboard.inv.priceBox.Text = reader("price").ToString()

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
        Dim keyword As String = SearchControl1.Text.Trim()

        If Not String.IsNullOrEmpty(keyword) Then
            If Connect() Then
                Try
                    Dim query As String = $"SELECT * FROM inventory WHERE po_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"
                    Dim dataTable As New DataTable()

                    Using cmd As New MySqlCommand(query, con)

                        Dim adapter As New MySqlDataAdapter(cmd)


                        adapter.Fill(dataTable)
                        allItemsTable.DataSource = dataTable

                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        saveToInventory()
    End Sub

    Sub saveToInventory()

        Dim srp As String = retailPrice.Text
        Dim po As String = PO_ID.Text
        Dim inv As String = invID.Text
        Dim des As String = descripBox.Text
        Dim quan As String = quantiBox.Text
        Dim cat As String = cateBox.Text
        Dim meas As String = measBox.Text
        Dim price As String = priceBox.Text
        Dim total As String = totBox.Text
        Dim sale As Int16
        If isForSaleBox.Checked Then
            sale = 1
        Else
            sale = 0
        End If

        If String.IsNullOrEmpty(po) OrElse
           String.IsNullOrEmpty(inv) OrElse
           String.IsNullOrEmpty(des) OrElse
           String.IsNullOrEmpty(inv) OrElse
           String.IsNullOrEmpty(quan) OrElse
           String.IsNullOrEmpty(cat) OrElse
           String.IsNullOrEmpty(meas) OrElse
           String.IsNullOrEmpty(price) OrElse
            String.IsNullOrEmpty(sale) Then
            MessageBox.Show("Some fields are empty!")

        Else
            If Connect() Then
                Try
                    Dim query As String = $"INSERT INTO inventory(inventory_id,po_id,description,quantity,category,price,measurement,isForSale, srp) VALUES('{inv}','{po}','{des}','{quan}','{cat}','{price}','{meas}','{sale}', '{srp}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    Dim query2 As String = $"UPDATE cart SET item_status = 'Added' WHERE item_id = '{itemIDD.Text}'"
                    Using cmd As New MySqlCommand(query2, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Successfully inserted to inventory")
                    loadTable()
                    clearForm()
                Catch ex As Exception
                    Try
                        If Connect() Then
                            Dim query As String = $"UPDATE inventory SET description = '{des}', quantity = '{quan}', category = '{cat}', price = '{price}', measurement = '{meas}', srp ='{srp}' WHERE inventory_id = '{inventory_id}'"
                            Using cmd As New MySqlCommand(query, con)
                                cmd.ExecuteNonQuery()
                            End Using
                            MessageBox.Show("Update success")
                            loadTable()
                        End If
                    Catch ex1 As Exception
                        MessageBox.Show(ex1.Message)
                    End Try
                End Try
            End If


        End If
    End Sub

    Private Sub isForSaleBox_CheckedChanged(sender As Object, e As EventArgs)
        forsale = 1
    End Sub

    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM inventory WHERE isDeleted = 0"
                Dim dataTable As New DataTable()
                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                allItemsTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub clearForm()

        PO_ID.Text = ""
        invID.Text = " "
        descripBox.Text = ""
        quantiBox.Text = ""
        cateBox.Text = ""
        measBox.Text = ""
        priceBox.Text = " "
        totBox.Text = " "
        isForSaleBox.Checked = False
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        update()
    End Sub
    Sub search()
        Dim keyword As String = SearchControl1.Text.Trim()

        If Not String.IsNullOrEmpty(keyword) Then
            If Connect() Then
                Try
                    Dim query As String = $"SELECT * FROM inventory WHERE po_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"
                    Dim dataTable As New DataTable()

                    Using cmd As New MySqlCommand(query, con)

                        Dim adapter As New MySqlDataAdapter(cmd)


                        adapter.Fill(dataTable)
                        allItemsTable.DataSource = dataTable

                    End Using


                Catch ex As Exception

                    MessageBox.Show("Error searching data: " & ex.Message)

                Finally
                    con.Close()
                End Try
            End If
            'Else
            '    MessageBox.Show("Please enter a search keyword.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub priceBox_TextChanged(sender As Object, e As EventArgs)
        Dim quantity As Integer
        Dim price As Double

        ' Convert text to integer for quantity
        If Integer.TryParse(quantiBox.Text, quantity) Then
            ' Text is a valid integer, proceed
            If Double.TryParse(priceBox.Text, price) Then
                ' Text is a valid double, proceed
                totBox.Text = (quantity * price).ToString()
            Else
                ' Text in itemPriceBox is not a valid double
                totBox.Text = "Invalid Price"
            End If
        Else
            ' Text in quantityBox is not a valid integer
            totBox.Text = "Invalid Quantity"
        End If
    End Sub

    Private Sub quantiBox_TextChanged(sender As Object, e As EventArgs)
        Dim quantity As Integer
        Dim price As Double

        ' Convert text to integer for quantity
        If Integer.TryParse(quantiBox.Text, quantity) Then
            ' Text is a valid integer, proceed
            If Double.TryParse(priceBox.Text, price) Then
                ' Text is a valid double, proceed
                totBox.Text = (quantity * price).ToString()
            Else
                ' Text in itemPriceBox is not a valid double
                totBox.Text = "Invalid Price"
            End If
        Else
            ' Text in quantityBox is not a valid integer
            totBox.Text = "Invalid Quantity"
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        delete()
    End Sub

    Sub delete()




        Dim ColumnItemId As String = "inventory_id"

        If allItemsTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = allItemsTable.SelectedCells(0).RowIndex
            inventory_id = allItemsTable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"DELETE Item ID: {inventory_id}?", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                If Connect() Then
                    Try
                        Dim query As String = $"UPDATE inventory SET isDeleted = 1 WHERE inventory_id = '{inventory_id}'"
                        Using cmd As New MySqlCommand(query, con)
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Deleted Successfully")
                        loadTable()
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

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        update()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim addItem As New arrivedStockss
        addItem.Show()
    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click

    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        delete()
    End Sub

    Private Sub SearchControl1_TextChanged_1(sender As Object, e As EventArgs) Handles SearchControl1.TextChanged
        search()
    End Sub

    Private Sub isForSaleBox_CheckedChanged_1(sender As Object, e As EventArgs) Handles isForSaleBox.CheckedChanged
        If isForSaleBox.Checked Then
            invID.Text = generateCATID()
        Else
            invID.Text = GenerateInventoryID()
        End If
    End Sub
End Class
