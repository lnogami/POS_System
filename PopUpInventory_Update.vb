Public Class PopUpInventory_Update


    Private Sub PopUpInventory_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'by default naka enable ang add quantity
        chckboxAddQuantityEnabler.Checked = True

        lblSerialNumber.Text = DatabaseModule.retrievedItemSerialNumber
        txtItemName.Text = DatabaseModule.retrievedItemName
        txtPrice.Text = DatabaseModule.retrievedItemPrice
        txtCost.Text = DatabaseModule.retrievedItemCost
        txtQuantity.Text = DatabaseModule.retrievedItemQuantity

        btnUpdateItem.Focus()

    End Sub

    Private Sub setReadOnly(ByVal quantityTextBox As TextBox, addQuantityTextBox As TextBox)

        If quantityTextBox.ReadOnly = True Then

            txtItemName.BackColor = SystemColors.ScrollBar
            txtItemName.BorderStyle = BorderStyle.FixedSingle
            txtPrice.BackColor = SystemColors.ScrollBar
            txtPrice.BorderStyle = BorderStyle.FixedSingle
            txtCost.BackColor = SystemColors.ScrollBar
            txtCost.BorderStyle = BorderStyle.FixedSingle

            quantityTextBox.BackColor = SystemColors.ScrollBar
            quantityTextBox.BorderStyle = BorderStyle.FixedSingle

            addQuantityTextBox.BackColor = SystemColors.Window
        Else

            txtItemName.BackColor = SystemColors.Window
            txtPrice.BackColor = SystemColors.Window
            txtCost.BackColor = SystemColors.Window

            quantityTextBox.BackColor = SystemColors.Window
            addQuantityTextBox.Text = "" 'removes the current value a textbox has

            addQuantityTextBox.BackColor = SystemColors.ScrollBar
        End If
    End Sub

    Private Sub cboxAddQuantityEnabler_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxAddQuantityEnabler.CheckedChanged

        If chckboxAddQuantityEnabler.Checked Then

            txtItemName.ReadOnly = True
            txtPrice.ReadOnly = True
            txtCost.ReadOnly = True
            txtQuantity.ReadOnly = True

            txtAddStock.ReadOnly = False
        Else

            txtItemName.ReadOnly = False
            txtPrice.ReadOnly = False
            txtCost.ReadOnly = False
            txtQuantity.ReadOnly = False

            txtAddStock.ReadOnly = True

        End If

        setReadOnly(txtQuantity, txtAddStock)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click

        'dili maka proceed if ang supposed to be inputtan og value is Add Quantity, mao ni ginamean sa first nga logical operation
        If (String.IsNullOrEmpty(txtAddStock.Text) AndAlso chckboxAddQuantityEnabler.Checked) OrElse (String.IsNullOrEmpty(txtItemName.Text) OrElse String.IsNullOrEmpty(txtPrice.Text) OrElse String.IsNullOrEmpty(txtCost.Text)) Then

            MessageBox.Show("Cannot update!" & vbNewLine & "Do not leave empty space!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        Else
            If chckboxAddQuantityEnabler.Checked Then 'if checked it means nga ang tandogon ani is add quantity instead of ang quatity jud
                'add quantity na textbox ang ipadala as argument
                DatabaseModule.updateInventoryItem(chckboxAddQuantityEnabler, retrievedItemSerialNumber, txtItemName.Text, txtPrice.Text, txtCost.Text, txtAddStock.Text)

                MessageBox.Show("Added new stock successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                'quantity ang ipada as argument
                DatabaseModule.updateInventoryItem(chckboxAddQuantityEnabler, retrievedItemSerialNumber, txtItemName.Text, txtPrice.Text, txtCost.Text, txtQuantity.Text)

                MessageBox.Show("Updated quantity successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If

            lblSerialNumber.Text = ""
            txtItemName.Text = ""
            txtPrice.Text = ""
            txtCost.Text = ""
            txtQuantity.Text = ""
            txtAddStock.Text = ""

        End If



    End Sub

    'prevent the user from inputting not numbers ------------------------------------------
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

    Private Sub txtAddQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddStock.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

End Class