Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math

Public Class request
    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

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
        Dim total As String = totalBox.Text

        If Connect() Then
            If String.IsNullOrEmpty(reqNum) OrElse
              String.IsNullOrEmpty(reqBy) OrElse
              String.IsNullOrEmpty(itemDes) OrElse
              String.IsNullOrEmpty(price) OrElse
              String.IsNullOrEmpty(measure) OrElse
              String.IsNullOrEmpty(quantity) OrElse
              String.IsNullOrEmpty(prodType) OrElse
              String.IsNullOrEmpty(source) OrElse
              String.IsNullOrEmpty(purpose) OrElse
              String.IsNullOrEmpty(total) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query As String = $"INSERT INTO request_form (request_id,request_by,item_description,price,measure,quantity,product_type,source_of_fund,purpose,total_amount) VALUES('{reqNum}','{reqBy}','{itemDes}','{price}','{measure}','{quantity}','{prodType}', '{source}', '{purpose}','{total}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Purchase Request Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearRequestForm()
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
                    'clearItemDetails()
                    'loadTable()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If



        End If


    End Sub
End Class