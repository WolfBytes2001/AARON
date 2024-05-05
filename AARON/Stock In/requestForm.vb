Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math

Public Class requestForm
    Private Sub requestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        requestID.Text = GenerateREUESTID()
        loadTable()
    End Sub
    Sub DeleteFromCart()

        Dim ColumnItemId As String = "item_id"

        If requestCart.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = requestCart.SelectedCells(0).RowIndex
            Dim id As String = requestCart.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"Remove item from cart Item ID: {id}?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                If Connect() Then
                    Try
                        Dim query As String = "DELETE FROM cart WHERE item_id = @id"
                        Using cmd As New MySqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Item deleted successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        loadTable()
                    Catch ex As Exception
                        MessageBox.Show("Error deleting item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try
                End If
            ElseIf result = DialogResult.Cancel Then ' DialogResult.Cancel corresponds to the "Cancel" button
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select an item to delete.", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub submit()


        Dim reqNum As String = requestID.Text
        Dim reqBy As String = officerBox.Text
        Dim itemDes As String = prodNameBox.Text
        Dim price As String = priceBox.Text
        Dim measure As String = measurementBox.Text
        Dim quantity As String = quantityBox.Text
        Dim prodType As String = categBox.Text
        Dim source As String = sourceBox.Text
        Dim purpose As String = purposeBox.Text
        Dim total As String = subtotalBox.Text

        If Connect() Then
            If String.IsNullOrEmpty(reqNum) OrElse
              String.IsNullOrEmpty(reqBy) OrElse
              String.IsNullOrEmpty(source) OrElse
              String.IsNullOrEmpty(purpose) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query As String = $"INSERT INTO request_form (request_id,request_by,item_description,price,measure,quantity,product_type,source_of_fund,purpose,total_amount) VALUES('{reqNum}','{reqBy}','{itemDes}','{price}','{measure}','{quantity}','{prodType}', '{source}', '{purpose}','{total}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Purchase Request Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearRequestForm()
                    requestID.Text = GenerateREUESTID()
                    loadTable()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

        End If

    End Sub

    Sub clearRequestForm()

        requestID.Text = ""
        officerBox.Text = ""
        prodNameBox.Text = ""
        measurementBox.Text = ""
        quantityBox.Text = ""
        categBox.Text = ""
        priceBox.Text = ""
        sourceBox.Text = ""
        purposeBox.Text = ""
        totalBox.Text = ""

    End Sub
    Sub addToCart()
        Dim pr As String = requestID.Text
        Dim des As String = prodNameBox.Text
        Dim mes As String = measurementBox.Text
        Dim cat As String = categBox.Text
        Dim price As String = priceBox.Text
        Dim quan As String = quantityBox.Text
        Dim Tot As String = totalBox.Text

        If String.IsNullOrEmpty(des) OrElse
                String.IsNullOrEmpty(des) OrElse
                String.IsNullOrEmpty(des) OrElse
                String.IsNullOrEmpty(des) OrElse
                String.IsNullOrEmpty(des) Then
            MessageBox.Show("Some Item fields are empty ")

        Else

            If Connect() Then
                Try
                    Dim query As String = $"INSERT INTO cart(request_id,item_description,measure,quantity,category,price,total)VALUES('{pr}','{des}','{mes}','{quan}','{cat}','{price}','{Tot}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Item added successfully added to cart!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearItemDetails()
                    loadTable()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If



        End If


    End Sub
    Sub clearItemDetails()

        prodNameBox.Text = ""
        measurementBox.Text = ""
        categBox.Text = ""
        priceBox.Text = ""
        quantityBox.Text = ""
        totalBox.Text = ""



    End Sub

    Sub clearAll()
        prodNameBox.Text = ""
        measurementBox.Text = ""
        categBox.Text = ""
        priceBox.Text = ""
        quantityBox.Text = ""
        totalBox.Text = ""
        officerBox.Text = ""
        officeBox.Text = ""

        totalBox.Text = ""
        purposeBox.Text = ""
        sourceBox.Text = ""
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        submit()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        addToCart()
    End Sub
    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = $"SELECT
                                        cart.item_id, 
                                        cart.request_id, 
                                        cart.item_description, 
                                        cart.measure, 
                                        cart.quantity, 
                                        cart.category, 
                                        cart.price, 
                                        cart.total
                                    FROM
                                        cart WHERE request_id = '{requestID.Text}' "
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                requestCart.DataSource = dataTable

                ' Calculate total price
                Dim totalPrice As Decimal = 0
                For Each row As DataRow In dataTable.Rows
                    totalPrice += Convert.ToDecimal(row("total"))
                Next

                ' Display total price
                subtotalBox.Text = totalPrice.ToString()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub calculateTotalPrice()
        Dim quantity As Integer
        Dim price As Double

        ' Convert text to integer for quantity
        If Integer.TryParse(quantityBox.Text, quantity) Then
            ' Text is a valid integer, proceed
            If Double.TryParse(priceBox.Text, price) Then
                ' Text is a valid double, proceed
                totalBox.Text = (quantity * price).ToString()
            Else
                ' Text in itemPriceBox is not a valid double
                totalBox.Text = "Invalid Price"
            End If
        Else
            ' Text in quantityBox is not a valid integer
            totalBox.Text = "Invalid Quantity"
        End If
    End Sub


    Private Sub quantityBox_ValueChanged(sender As Object, e As EventArgs) Handles quantityBox.ValueChanged
        calculateTotalPrice()
    End Sub

    Private Sub priceBox_TextChanged(sender As Object, e As EventArgs) Handles priceBox.TextChanged
        calculateTotalPrice()
    End Sub

    Private Sub requestCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles requestCart.CellContentClick
        DeleteFromCart()
    End Sub
End Class
