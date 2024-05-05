Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Dashboard
    Public isLogin As Boolean = False
    Public inv As New addNewStock
    Public pos As New pos
    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click
        Dim po As New polist
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(po)
        po.Show()
    End Sub

    Private Sub AccordionControlElement7_Click(sender As Object, e As EventArgs) Handles AccordionControlElement7.Click

    End Sub

    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click
        Dim request As New requestForm
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(request)
        request.Show()
    End Sub

    Private Sub AccordionControlElement3_Click(sender As Object, e As EventArgs) Handles AccordionControlElement3.Click
        Dim approval As New approvalForm
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(approval)
        approval.Show()
    End Sub

    Private Sub AccordionControlElement5_Click(sender As Object, e As EventArgs) Handles AccordionControlElement5.Click
        Dim status As New order_status
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(status)
        status.Show()
    End Sub

    Private Sub AccordionControlElement6_Click(sender As Object, e As EventArgs) Handles AccordionControlElement6.Click
        Dim recieve As New item_recieved
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(recieve)
        recieve.Show()
    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs) Handles AccordionControlElement10.Click

        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(inv)
        inv.Show()
    End Sub

    Private Sub AccordionControlElement1_Click(sender As Object, e As EventArgs) Handles AccordionControlElement1.Click

    End Sub

    Private Sub AccordionControlElement11_Click(sender As Object, e As EventArgs) Handles AccordionControlElement11.Click
        Dim catal As New catalog
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(catal)
        catal.Show()
    End Sub

    Private Sub AccordionControlElement12_Click(sender As Object, e As EventArgs) Handles AccordionControlElement12.Click
        Dim pos As New pos
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(pos)
        pos.Show()
    End Sub

    Private Sub AccordionControlElement13_Click(sender As Object, e As EventArgs) Handles AccordionControlElement13.Click
        Dim histo As New posHistory
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(histo)
        histo.Show()
    End Sub

    Private Sub AccordionControlElement14_Click(sender As Object, e As EventArgs) Handles AccordionControlElement14.Click
        Dim admin As New admin
        MainContainer.Controls.Clear()
        MainContainer.Controls.Add(admin)
        admin.Show()
    End Sub


    Private Sub Dashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If isLogin = False Then
            Me.Hide()
            Dim login As New Login
            login.Show()
        End If
    End Sub
End Class
