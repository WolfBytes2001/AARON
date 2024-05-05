Imports MySql.Data.MySqlClient

Public Class admin
    Dim admin_id As String
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adminID.Text = GenerateAdminID()
        loadTable()
    End Sub

    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM admin WHERE isDeleted = 0"
                Dim dataTable As New DataTable()
                Using cmd As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                allAdminsTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub update()




        Dim ColumnItemId As String = "admin_id"

        If allAdminsTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = allAdminsTable.SelectedCells(0).RowIndex
            admin_id = allAdminsTable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"UPDATE Item ID: {admin_id}?", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

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
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        add()
    End Sub
    Sub search()
        Dim keyword As String = SearchControl1.Text.Trim()

        If Not String.IsNullOrEmpty(keyword) Then
            If Connect() Then
                Try
                    Dim query As String = $"SELECT * FROM admin WHERE employee_id LIKE '%{keyword}%' OR fullname LIKE '%{keyword}%'"
                    Dim dataTable As New DataTable()

                    Using cmd As New MySqlCommand(query, con)

                        Dim adapter As New MySqlDataAdapter(cmd)


                        adapter.Fill(dataTable)
                        allAdminsTable.DataSource = dataTable

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
    Sub add()
        Dim full As String = fullnameBox.Text
        Dim username As String = usernameBox.Text
        Dim password As String = passwordBox.Text
        Dim id As String = emploIDBOX.Text
        Dim admin As String = adminID.Text


        If String.IsNullOrEmpty(full) OrElse
           String.IsNullOrEmpty(username) OrElse
           String.IsNullOrEmpty(password) OrElse
           String.IsNullOrEmpty(id) OrElse
           String.IsNullOrEmpty(admin) Then
            MessageBox.Show("Some fields are empty")
        Else
            Try
                If Connect() Then
                    Dim query As String = $"INSERT INTO admin(admin_id,employee_id,fullname,username,password)VALUES ('{admin}','{id}','{full}','{username}','{password}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Added to admins successfully")
                    clear()
                    loadTable()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Sub clear()
        fullnameBox.Text = ""
        usernameBox.Text = ""
        passwordBox.Text = ""
        emploIDBOX.Text = ""
        adminID.Text = GenerateAdminID()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        update()
    End Sub

    Public Sub loadToInventory()
        'invID.Text = inventory_id
        If Connect() Then
            Try
                Dim sql = $"SELECT * FROM admin WHERE admin_id = '{admin_id}' "


                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()


                            fullnameBox.Text = reader("fullname").ToString()
                            adminID.Text = reader("admin_id").ToString
                            emploIDBOX.Text = reader("employee_id").ToString

                            usernameBox.Text = reader("username").ToString
                            passwordBox.Text = reader("password").ToString



                            'generate Inventory ID
                            'If Dashboard.inv.cateBox.Text.ToLower = "supplies" Then
                            '    Dashboard.inv.invID.Text = GenerateInventoryID("SUP")
                            'ElseIf Dashboard.inv.cateBox.Text.ToLower = "equipment" Then
                            '    Dashboard.inv.invID.Text = GenerateInventoryID("EQ")
                            '    'ElseIf review.categoryR.Text.ToLower = "technology" Then
                            '    '	review.inventoryID.Text = GenerateTechInventoryID()
                            '    'ElseIf review.categoryR.Text.ToLower = "furniture" Then
                            '    '	review.inventoryID.Text = GenerateFurnitureInventoryID()
                            '    'ElseIf review.categoryR.Text.ToLower = "equipment" Then
                            '    '	review.inventoryID.Text = GenerateEquipmentInventoryID()
                            '    'ElseIf review.categoryR.Text.ToLower = "tools" Then
                            '    '	review.inventoryID.Text = GenerateToolsInventoryID()
                            '    'ElseIf review.categoryR.Text.ToLower = "instrument" Then
                            '    '	review.inventoryID.Text = GenerateInstrumentInventoryID()
                            '    'ElseIf review.categoryR.Text.ToLower = "vehicle" Then
                            '    '	review.inventoryID.Text = GenerateVehiclesInventoryID()
                            'End If
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
        Dim full As String = fullnameBox.Text
        Dim username As String = usernameBox.Text
        Dim password As String = passwordBox.Text
        Dim id As String = emploIDBOX.Text
        Dim admin As String = adminID.Text


        If String.IsNullOrEmpty(full) OrElse
           String.IsNullOrEmpty(username) OrElse
           String.IsNullOrEmpty(password) OrElse
           String.IsNullOrEmpty(id) OrElse
           String.IsNullOrEmpty(admin) Then

            MessageBox.Show("Some fields are empty")
        Else
            Try
                If Connect() Then
                    Dim query As String = $"UPDATE admin set fullname = '{full}', username = '{username}',password = '{password}', employee_id = '{id}' WHERE admin_id ='{admin_id}'"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Admin account updated succesfully!")
                    clear()
                    loadTable()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If Connect() Then
            Try
                Dim query As String = $"UPDATE admin SET isDeleted = 1 WHERE admin_id = '{admin_id}'"
                Using cmd As New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Admin account DELETED succesfully!")
                clear()
                loadTable()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles emploIDBOX.EditValueChanged

    End Sub

    Private Sub SearchControl1_TextChanged(sender As Object, e As EventArgs) Handles SearchControl1.TextChanged
        search()
    End Sub
End Class
