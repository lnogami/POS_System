Public Class PopUpInventory_Delete
    Private Sub PopUpInventory_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblSerialNumber.Text = DatabaseModule.retrievedItemSerialNumber
        lblItemName.Text = DatabaseModule.retrievedItemName
        lblPrice.Text = DatabaseModule.retrievedItemPrice
        lblCost.Text = DatabaseModule.retrievedItemCost
        lblSold.Text = DatabaseModule.retrievedItemSold
        lblQuantity.Text = DatabaseModule.retrievedItemQuantity
        lblDateAdded.Text = DatabaseModule.retrievedItemDateAdded
        lblAddedBy.Text = DatabaseModule.retrievedItemAddedBy
    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        Dim confirmation As DialogResult = MessageBox.Show("Once deleted it cannot be undone!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirmation = DialogResult.Yes Then

            DatabaseModule.deleteInventoryItem(lblSerialNumber.Text)
            Me.Dispose()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose
    End Sub

End Class