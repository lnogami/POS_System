Public Class PopUpInventory_Add

    Dim dateTime As Date = DateTime.Now

    Private Sub PopUpInventory_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDateAdded.Text = dateTime.ToString("yyyy-MM-dd")

        lblAddedBy.Text = DatabaseModule.retrievedLastName

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        DatabaseModule.addInventoryItem(txtItemName.Text, txtQuantity.Text, txtCost.Text, txtPrice.Text, lblDateAdded.Text)

        txtItemName.Text = ""
        txtQuantity.Text = ""
        txtCost.Text = ""
        txtPrice.Text = ""

        'pang debug ra ni tanan
        'InventoryForm.txtSearchBar.Text = "refreshing"
        'DatabaseModule.loadItemsWithSearchFeature(InventoryForm.dgvInventory, InventoryForm.txtSearchBar.Text & "refreshing", "inventory")
        'MessageBox.Show(InventoryForm.dgvInventory.RowCount.ToString)
        'Dim inventoryDGV As New InventoryForm
        'inventoryDGV.Show()
        'InventoryForm.dgvInventory.Dispose()
        'DatabaseModule.loadItemsWithSearchFeature(InventoryForm.dgvInventory, "rfreshing...", "inventory")

        'InventoryForm.txtSearchBar.Text = "Refreshing.."

    End Sub


    'prevent the user from inputting not numbers --------------------------------------------
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

            e.Handled = True
        End If
    End Sub
    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

End Class