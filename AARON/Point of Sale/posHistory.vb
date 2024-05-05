Imports MySql.Data.MySqlClient

Public Class posHistory

    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM transaction"

                Dim dataTable As New DataTable()
                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using


                historyTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub posHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub
End Class
