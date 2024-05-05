Imports MySql.Data.MySqlClient

Public Class purchaseOrderForm

    Dim purchaseOrderID As String
    Dim purchaseReqID As String
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        savePO()

    End Sub

    Private Sub purchase_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        POID.Text = GeneratePOCode()
    End Sub

    Sub savePO()
        If Connect() Then
            Try
                Dim query As String = $"UPDATE approved_request SET po_id ='{POID.Text}' WHERE request_id= '{PRID.Text}'"
                Using cmd As New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Purchase Order Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadPurchaseOrder()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Public Sub loadPurchaseOrder()

        Dim vendor As New vendorSelection()

        vendor.Dock = DockStyle.Fill
        'If MainDashboard.DashboardContainer.Controls.Count >= 0 Then
        '    Dim existingForm = TryCast(MainDashboard.DashboardContainer.Controls(0), Form)
        '    If existingForm IsNot Nothing Then
        '        existingForm.Dispose()
        '    End If
        'End If
        Dashboard.MainContainer.Controls.Clear()
        Dashboard.MainContainer.Controls.Add(vendor)
        vendor.Show()

        vendor.PR = PRID.Text
        vendor.addSuppID.Text = GenerateVendorID()

        If Connect() Then
            Try
                Dim sql = $"SELECT * FROM approved_request WHERE request_id = '{PRID.Text}'"

                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()


                    If reader.HasRows Then
                        While reader.Read()
                            vendor.vendorPOID.Text = reader("po_id").ToString()
                            vendor.prVendorID.Text = reader("request_id").ToString()


                        End While

                    Else
                        'MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    End If

                    reader.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading purchase order: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Connection error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class
