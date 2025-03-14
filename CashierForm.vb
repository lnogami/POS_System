Imports Google.Protobuf.WellKnownTypes
Imports System.Text.RegularExpressions

Public Class CashierForm

    Dim rowNumber As Integer = 0

    Dim invoiceItemQuantity As Integer = 1


    'Mag show og message somewhere sa screen para mahibal an sa user na kani ang gipasabot sa Notice
    Private Sub ShowTooltip(theObject As Object, xLocation As Integer, yLocation As Integer, message As String) 'magbuhat og object sa ToolTip class para pang notice sa user ang need niya buhaton

        Dim toolTip As New ToolTip()  'para murag dialog sa comics ang style sa mo pop up na message

        toolTip.IsBalloon = True 'e specify unsa og asa dapit mo gawas ang dialog
        toolTip.Show(message, theObject, xLocation, yLocation, 2000) ' Display for 2.5 seconds

        'toolTip.Show("Please select a value!", comboBox, comboBox.Width / 2, comboBox.Height / 2, 3000) ' Display for 3 seconds
    End Sub

    Private Sub CashierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timerDateAndTime.Start()

        lblUserCashierLastName.Text = DatabaseModule.retrievedLastName


        DatabaseModule.loadItemsWithSearchFeature(dgvCashierItemView, txtSearchBar.Text, "cashier")

        'para dili ma adjust sa user ang rows
        dgvCashierItemView.AllowUserToResizeRows = False
        dgvInvoice.AllowUserToResizeRows = False

    End Sub

    Private Sub timerDateAndTime_Tick(sender As Object, e As EventArgs) Handles timerDateAndTime.Tick

        lblCashieringDateAndTime.Text = DateTime.Now.ToString("MM-dd-yyyy (dddd)  hh:mm:ss tt")
    End Sub

    'prevent the user from inputting not numbers
    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

            e.Handled = True
        End If
    End Sub

    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged

        DatabaseModule.loadItemsWithSearchFeature(dgvCashierItemView, txtSearchBar.Text, "cashier")

    End Sub

    Private Sub dgvCashierItemView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCashierItemView.RowHeaderMouseClick

        'MessageBox.Show(dgvCashierItemView.Rows(dgvCashierItemView.SelectedRows).Cells("stock").Value)

        'if 0 na ang stock sa item dili na niya ma process ang item para paliton sa customer
        Dim selectedRow As DataGridViewRow = dgvCashierItemView.SelectedRows(0)

        'kuhaon niya ang sected cell, automatic nani pag naay ang SelectedRow
        Dim selectedCell As DataGridViewCell = dgvCashierItemView.SelectedCells(0)

        ' Get the display rectangle of the selected cell
        Dim cellRectangle As Rectangle = dgvCashierItemView.GetCellDisplayRectangle(selectedCell.ColumnIndex, selectedCell.RowIndex, True)

        ' Get the vertical position from the top
        Dim verticalPosition As Integer = cellRectangle.Y

        'MessageBox.Show("The vertical position of the selected cell from the top is: " & verticalPosition.ToString())

        If selectedRow.Cells("stock").Value = 0 Then
            'to display a message in a dialog style og porma
            ShowTooltip(lblUserCashierLastName, -38, verticalPosition - 10, "Currently out of stock!")
            Exit Sub

        End If

        'ang kaning function call sa condition is mag retrun og True if ang item sa dgvCashier is naa na sa dgvInvoice
        If DatabaseModule.isItemAlreadyAddedToInvoice(dgvCashierItemView, dgvInvoice) Then

            calculateInvoiceTotal() 'para e calculate niyag usab ang total sa invoice
            Exit Sub

        End If

        DatabaseModule.toTransferDataIntoInvoiceTotal(dgvCashierItemView, dgvInvoice, rowNumber)

        calculateInvoiceTotal() 'para e calculate niyag usab ang total sa invoice

    End Sub


    Private Sub dgvInvoice_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInvoice.RowHeaderMouseClick

        Dim row = dgvInvoice.SelectedRows(0)
        txtQuantity.Text = row.Cells("invoiceQuantity").Value

    End Sub

    Private Sub txtQunatity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

        Try
            'If dgvInvoice.Rows.Count = 0 Then
            '    MessageBox.Show("0 row")
            '    Exit Sub
            'End If

            'If dgvInvoice.SelectedRows.Count = 0 Then
            '    MessageBox.Show("0 selected")
            'End If

            If dgvInvoice.SelectedRows.Count > 0 Then

                Dim row = dgvInvoice.SelectedRows(0) 'diri ma store ang napili nga row

                'If Integer.Parse(txtQuantity.Text) > Integer.Parse(dgvCashierItemView.SelectedRows(0).Cells("Stock").Value) AndAlso String.IsNullOrEmpty(txtQuantity.Text) Then

                '    txtQuantity.Text = dgvCashierItemView.SelectedRows(0).Cells("Stock").Value

                'End If
                'MessageBox.Show("Stock " & dgvCashierItemView.SelectedRows(0).Cells("Stock").Value)

                If String.IsNullOrEmpty(txtQuantity.Text) Then 'para dili magka null value ang quantity

                    row.Cells("invoiceQuantity").Value = 1.ToString
                    row.Cells("invoiceAmount").Value = row.Cells("invoicePrice").Value

                ElseIf Integer.Parse(txtQuantity.Text) < 1 Then 'para dili magka 0 value ang Quantity

                    row.Cells("invoiceQuantity").Value = 1.ToString
                    row.Cells("invoiceAmount").Value = row.Cells("invoicePrice").Value

                Else

                    row.Cells("invoiceQuantity").Value = txtQuantity.Text
                    row.Cells("invoiceAmount").Value *= Integer.Parse(txtQuantity.Text)

                End If

                If Not String.IsNullOrEmpty(txtQuantity.Text) Then
                    If (Integer.Parse(txtQuantity.Text)) > (Integer.Parse(dgvCashierItemView.SelectedRows(0).Cells("Stock").Value)) Then

                        txtQuantity.Text = dgvCashierItemView.SelectedRows(0).Cells("Stock").Value
                        row.Cells("invoiceQuantity").Value = txtQuantity.Text
                        row.Cells("invoiceAmount").Value = Integer.Parse(txtQuantity.Text) * Integer.Parse(row.Cells("invoicePrice").Value)

                        calculateInvoiceTotal() 'recalculate ang total

                        'if 0 na ang stock sa item dili na niya ma process ang item para paliton sa customer
                        Dim selectedRow As DataGridViewRow = dgvCashierItemView.SelectedRows(0)

                        'kuhaon niya ang sected cell, automatic nani pag naay ang SelectedRow
                        Dim selectedCell As DataGridViewCell = dgvCashierItemView.SelectedCells(0)

                        ' Get the display rectangle of the selected cell
                        Dim cellRectangle As Rectangle = dgvCashierItemView.GetCellDisplayRectangle(selectedCell.ColumnIndex, selectedCell.RowIndex, True)

                        ' Get the vertical position from the top
                        Dim verticalPosition As Integer = cellRectangle.Y

                        ShowTooltip(lblUserCashierLabel, 15, verticalPosition - 10, "unfurtunately " & dgvCashierItemView.SelectedRows(0).Cells("Stock").Value & " is the current stock available")

                    End If

                End If
            End If


            calculateInvoiceTotal() 'para e calculate niyag usab ang total sa invoice

        Catch ex As Exception
            MessageBox.Show("Error.. " & ex.Message & vbNewLine & ex.StackTrace, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    'prevents inputting not numeric data in txtQuantity
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click

        Try
            'dapat naay pilion na row in order na makadelete ang user og isa ka item
            If dgvInvoice.SelectedRows.Count > 0 Then

                Dim confirmation As DialogResult = MessageBox.Show("Are you sure you to remove this item?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmation = DialogResult.Yes Then

                    dgvInvoice.Rows.Remove(dgvInvoice.SelectedRows(0))
                    rowNumber -= 1  'bawasan og isa para equal siya sa giremove na Row

                    calculateInvoiceTotal() 'to recalculate the invoice total

                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClearAllOrder_Click(sender As Object, e As EventArgs) Handles btnClearAllOrder.Click
        Try
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you to remove all item?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmation = DialogResult.Yes Then

                'e clear ang Row
                dgvInvoice.Rows.Clear()

                'e reset ang rowNumber para mag tugma sya sa actual number of Rows after nagclear which is 0
                rowNumber = 0

                ' e reset ang value sa quantity
                txtQuantity.Text = ""

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvInvoice_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvInvoice.RowsAdded

        calculateInvoiceTotal() 'para e calculate niyag usab ang total sa invoice

        'naa may row daan ang gdvInvoice nga walay sulod maong dapat greater than 1 ang e condition
        If dgvInvoice.RowCount > 1 Then

            dgvInvoice.ClearSelection()

            '- 2 kay naa namay row nga walay sulod daan ang dgvInvoice, and also index mani, nag start sa 0 so minus 1 jud sya. Maong - 2 in total.
            dgvInvoice.Rows(dgvInvoice.RowCount - 2).Selected = True  'to make the latest added row highlighted, for fast editing of quantity

            ' Optionally, scroll to the newly added row
            dgvInvoice.FirstDisplayedScrollingRowIndex = dgvInvoice.Rows.Count - 1
        End If
    End Sub

    Private Sub dgvInvoice_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvInvoice.CurrentCellDirtyStateChanged

        calculateInvoiceTotal() 'para e calculate niyag usab ang total sa invoice

    End Sub

    Private Sub calculateInvoiceTotal()  'to calculate invoice total

        Try
            If dgvCashierItemView.SelectedRows.Count > 0 Then
                Dim total As Double = 0

                For i = 0 To dgvInvoice.RowCount - 1

                    total += dgvInvoice.Rows(i).Cells("invoiceAmount").Value

                Next

                lblTotalValue.Text = total.ToString("C")

                caculateChangeForInvoiceTotal() 'recalculates the invoice Change if the invoice total changes

            End If

        Catch ex As Exception

            MessageBox.Show("An error occured when calculating for total invoice" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace)

        End Try

    End Sub

    Private Sub caculateChangeForInvoiceTotal()

        Try
            'ma calculate lang ang invoice change if dili null or empty ang txtCash.Text
            If Not String.IsNullOrEmpty(txtCash.Text) Then

                Dim cleanTotalValue As String = Regex.Replace(lblTotalValue.Text, "[^\d.]", "") 'mo tanggal sa peso sign

                lblChangeValue.Text = (Double.Parse(txtCash.Text) - Double.Parse(cleanTotalValue)).ToString("C")

                Dim cleanChangeValue As String = Regex.Replace(lblChangeValue.Text, "[^\d.]", "") 'mo tanggal sa peso sign

                'additional feature rani, nga if kulang ang cash na gibayad is iyang butangag indication just to make it more obvious
                If Double.Parse(cleanTotalValue) > Double.Parse(txtCash.Text) Then

                    'e convert ang - nga value into positive, then add ang word na (kulang) to indicate na kulang ang cash na gibayad
                    lblChangeValue.Text = "(" & (Double.Parse(cleanChangeValue) * -1).ToString("C") & " kulang)"
                    lblChangeValue.ForeColor = Color.FromArgb(180, 200, 10, 5)
                    lblChangeLabel.Font = New Font(lblChangeLabel.Font, FontStyle.Strikeout)

                Else
                    'e revert back ra niya balik sa default color
                    lblChangeValue.ForeColor = SystemColors.ControlLightLight
                    lblChangeLabel.Font = New Font(lblChangeLabel.Font, FontStyle.Regular)

                End If

            Else

                lblChangeValue.Text = ""

            End If

        Catch ex As Exception

            MessageBox.Show("An error occured when calculating for total invoice" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace)

        End Try

    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged

        caculateChangeForInvoiceTotal()

    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click

        If String.IsNullOrEmpty(txtCash.Text) AndAlso dgvInvoice.RowCount = 1 Then  ' = 1 instead na 0, kay naa may sulod blank row daan ang invoiceDGV

            'to display a message in a dialog style og porma
            ShowTooltip(lblSearchLabel, 2, 5, "Please select an item first!")
            Exit Sub

        End If

        If String.IsNullOrEmpty(txtCash.Text) Then 'e cancel niya ang pag process sa order if walay payment amount

            ShowTooltip(txtCash, 15, -35, "Don't forget to input payment amount!")
            Exit Sub

        End If

        Dim confirmation As DialogResult = MessageBox.Show("Once confirmed it cannot be undone!", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then

            DatabaseModule.toReceipt(dgvCashierItemView, dgvInvoice, SalesForm.itemSoldDGV)

            'resets all of their values
            dgvInvoice.Rows.Clear()
            lblTotalValue.Text = "0"
            txtCash.Text = ""
            lblChangeValue.Text = "0"
            txtQuantity.Text = ""
            rowNumber = 0

            DatabaseModule.loadItemsWithSearchFeature(dgvCashierItemView, "", "cashier")

            MessageBox.Show("Successful transaction!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

End Class