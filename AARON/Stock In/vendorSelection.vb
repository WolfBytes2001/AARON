Imports MySql.Data.MySqlClient

Public Class vendorSelection

    Public vendorPO As String
    Public vendorPR As String
    Public PR As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub vendor_selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadVendorTable()
    End Sub

    Sub loadVendorTable()

        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM vendors"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                vendorsTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub placeOrderButton_Click(sender As Object, e As EventArgs) Handles placeOrderButton.Click
        Dim name As String = suppName.Text

        Dim courier As String = OrderCourier.Text
        Dim method As String = shippingMeth.Text
        Dim date1 As String = deliveryDate.Text
        vendorPO = vendorPOID.Text
        vendorPR = prVendorID.Text

        If Connect() Then
            If String.IsNullOrEmpty(name) OrElse
             String.IsNullOrEmpty(courier) OrElse
             String.IsNullOrEmpty(method) OrElse
             String.IsNullOrEmpty(date1) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                Try
                    Dim query As String = $"INSERT INTO purchase_order(po_id,pr_id,supplier_name,shipping_method,courier,delivery_date) VALUES('{vendorPO}','{vendorPR}','{name}','{method}','{courier}','{date1}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    Dim query2 As String = $"UPDATE approved_request SET status = 'Done' WHERE request_id = '{PR}'"
                    Using cmd As New MySqlCommand(query2, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show(" Order Placed Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearPO()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Sub clearPO()
        suppName.Text = ""

        OrderCourier.Text = ""
        shippingMeth.Text = ""
        deliveryDate.Text = ""
        vendorPOID.Text = ""
        prVendorID.Text = ""

    End Sub

    Private Sub addVendorButton_Click(sender As Object, e As EventArgs) Handles addVendorButton.Click
        If String.IsNullOrEmpty(addSuppName.Text) OrElse
            String.IsNullOrEmpty(addContact.Text) OrElse
            String.IsNullOrEmpty(addLoc.Text) OrElse
            String.IsNullOrEmpty(addSuppID.Text) OrElse
            String.IsNullOrEmpty(addType.Text) Then
            MessageBox.Show("Some fields are empty")
        Else
            If Connect() Then
                Try
                    Dim query As String = $"INSERT INTO vendors(supplier_id,supplier_name,type,contact,location) VALUES('{addSuppID.Text}','{addSuppName.Text}','{addType.Text}','{addContact.Text}','{addLoc.Text}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Vendor successfully added!")
                    loadVendorTable()
                    clearVendorForm()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        End If
    End Sub

    Private Sub suppName_Click(sender As Object, e As EventArgs) Handles suppName.Click
        comboBoxLoadItems("vendors", suppName, "supplier_name")
    End Sub


    Sub clearVendorForm()
        addSuppName.Text = ""
        addContact.Text = ""
        addLoc.Text = ""
        addSuppID.Text = ""
        addType.Text = ""
    End Sub
End Class


