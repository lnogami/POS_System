Public Class InventoryForm

    Public Shared formThatIsCurrentlyPoppedUp As Form 'will contain the current clicked form
    Public Shared poppedUpFormInitialized As Boolean 'to indicate if there is a popped up form

    Public dgvInventoryPublicVariablle As DataGridView = dgvInventory

    Private Sub poppedUpForm(ByRef form As Form)

        If form.IsDisposed Then
            MessageBox.Show("Is currently disposed")
        Else
            If form IsNot PopUpInventory_Add And PopUpInventory_Add.Visible Then 'the selected is "update"
                PopUpInventory_Add.Dispose()
            End If
            If form IsNot PopUpInventory_Update And PopUpInventory_Update.Visible Then 'the selected is "delete"
                PopUpInventory_Update.Dispose()
            End If
            If form IsNot PopUpInventory_Delete And PopUpInventory_Delete.Visible Then 'the selected is "add"
                PopUpInventory_Delete.Dispose()
            End If
        End If

        form.Show()
        formThatIsCurrentlyPoppedUp = form
        poppedUpFormInitialized = True

    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DatabaseModule.loadItemsWithSearchFeature(dgvInventory, txtSearchBar.Text, "inventory")

        DatabaseModule.getDataFromSpecificRowInItems(dgvInventory)

        dgvInventory.AllowUserToResizeRows = False 'para dili ma adjust sa user ang rows

        makeACopyOfIventoryDGV(dgvInventory) 'to make the dgvInventory accessable to anywhere in the module

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        poppedUpForm(PopUpInventory_Add)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        poppedUpForm(PopUpInventory_Update)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        poppedUpForm(PopUpInventory_Delete)
    End Sub

    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged, txtSearchBar.TextChanged

        DatabaseModule.loadItemsWithSearchFeature(dgvInventory, txtSearchBar.Text, "inventory")

    End Sub

    Private Sub dgvInventory_RowHeaderMouseClick(sender As Object, e As EventArgs) Handles dgvInventory.RowHeaderMouseClick

        'para mag collect mga data sa selected Row sa dgvInventory
        DatabaseModule.getDataFromSpecificRowInItems(dgvInventory)

        If PopUpInventory_Update.Visible Then

            PopUpInventory_Update.Dispose()
            PopUpInventory_Update.Show()


        ElseIf PopUpInventory_Delete.Visible Then

            PopUpInventory_Delete.Dispose()
            PopUpInventory_Delete.Show()

        End If
    End Sub
End Class