Imports MySql.Data.MySqlClient

Public Class order_status
    Private Sub orde_status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtableOnProcess()
        loadDelivered()
    End Sub

    Sub loadtableOnProcess()

        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM purchase_order WHERE status = 'Processing' ORDER BY issued_at DESC"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                onProcessTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub loadDelivered()

        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM purchase_order WHERE status = 'Delivered'"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                DeliveredTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class
