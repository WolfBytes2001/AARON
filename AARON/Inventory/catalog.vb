Imports MySql.Data.MySqlClient

Public Class catalog
    Dim catalog_id As String

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        add()
    End Sub


    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM inventory WHERE isDeleted = 0 and isForSale = 1"
                Dim dataTable As New DataTable()
                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                allICatalogable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub clearForm()


        descripBox.Text = ""
        quantiBox.Text = ""
        cateBox.Text = ""
        measBox.Text = ""
        priceBox.Text = " "


    End Sub
    Sub add()
        Dim cat As String = cat_ID.Text
        Dim srp As String = retailPriceBox.Text
        Dim des As String = descripBox.Text
        Dim quan As String = quantiBox.Text
        Dim cate As String = cateBox.Text
        Dim meas As String = measBox.Text
        Dim price As String = priceBox.Text



        If String.IsNullOrEmpty(cat) OrElse
           String.IsNullOrEmpty(des) OrElse
           String.IsNullOrEmpty(quan) OrElse
           String.IsNullOrEmpty(cat) OrElse
           String.IsNullOrEmpty(meas) OrElse
           String.IsNullOrEmpty(price) Then

            MessageBox.Show("Some fields are empty!")

        Else
            Try
                If Connect() Then
                    Dim query As String = $"INSERT INTO inventory(inventory_id,description,quantity,category,price,measurement, isForSale,srp)VALUES ('{cat}','{des}','{quan}','{cate}','{price}','{meas}', 1, '{srp}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Added to catalog successfully")
                    cat_ID.Text = GenerateCatalogID()
                    clearForm()
                    loadTable()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub catalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cat_ID.Text = generateCATID()
        loadTable()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        update()
    End Sub
    Sub update()




        Dim ColumnItemId As String = "inventory_id"

        If allICatalogable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = allICatalogable.SelectedCells(0).RowIndex
            catalog_id = allICatalogable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"UPDATE CATALOG ID: {catalog_id}?", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

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
        cat_ID.Text = catalog_id
        If Connect() Then
            Try
                Dim sql = $"SELECT
	                            *
                            FROM
	                            inventory WHERE inventory_id = '{catalog_id}'"


                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()

                            retailPriceBox.Text = reader("srp").ToString()
                            quantiBox.Text = reader("quantity").ToString()
                            descripBox.Text = reader("description").ToString
                            cateBox.Text = reader("category").ToString()
                            measBox.Text = reader("measurement").ToString()
                            priceBox.Text = reader("price").ToString()


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

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim srp As String = retailPriceBox.Text
        Dim des As String = descripBox.Text
        Dim quan As String = quantiBox.Text
        Dim cat As String = cateBox.Text
        Dim meas As String = measBox.Text
        Dim price As String = priceBox.Text




        If String.IsNullOrEmpty(des) OrElse
           String.IsNullOrEmpty(quan) OrElse
           String.IsNullOrEmpty(cat) OrElse
           String.IsNullOrEmpty(meas) OrElse
           String.IsNullOrEmpty(price) Then

            MessageBox.Show("Some fields are empty!")

        Else
            If Connect() Then
                Try
                    If Connect() Then
                        Dim query As String = $"UPDATE inventory set description = '{des}', quantity = '{quan}',category = '{cat}', price = '{price}', measurement = '{meas}', srp = '{srp}' WHERE inventory_id ='{catalog_id}'"
                        Using cmd As New MySqlCommand(query, con)
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Item in catalog updated succesfully!")
                        clearForm()
                        loadTable()
                        cat_ID.Text = GenerateCatalogID()
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If


        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Dim ColumnItemId As String = "inventory_id"

        If allICatalogable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = allICatalogable.SelectedCells(0).RowIndex
            catalog_id = allICatalogable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"UPDATE CATALOG ID: {catalog_id}?", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                If Connect() Then
                    Try
                        Dim query As String = $"UPDATE inventory SET isDeleted = 1 WHERE inventory_id = '{catalog_id}'"
                        Using cmd As New MySqlCommand(query, con)
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Catalog item DELETED succesfully!")
                        clearForm()
                        loadTable()
                        cat_ID.Text = GenerateCatalogID()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            ElseIf result = DialogResult.No Then

            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Else
            MessageBox.Show("Table is empty")
        End If
    End Sub

    Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click

    End Sub
End Class
