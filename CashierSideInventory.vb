Public Class CashierSideInventory
    Public Class InventoryForm

        Public Shared formThatIsCurrentlyPoppedUp As Form 'will contain the current clicked form
        Public Shared poppedUpFormInitialized As Boolean 'to indicate if there is a popped up form

    End Class
    Private Sub CashierSideInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DatabaseModule.loadItemsWithSearchFeature(dgvCashierSideInventory, txtSearchBar.Text, "inventory")

        dgvCashierSideInventory.AllowUserToResizeRows = False  'para dili ma adjust sa user ang rows

    End Sub

    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged

        DatabaseModule.loadItemsWithSearchFeature(dgvCashierSideInventory, txtSearchBar.Text, "inventory")
    End Sub

End Class