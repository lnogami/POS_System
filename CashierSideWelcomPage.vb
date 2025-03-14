Public Class CashierSideWelcomPage

    'Still in observation
    Dim dashboard As New DashboardForm
    Dim cashier As New CashierForm
    Dim inventory As New CashierSideInventory

    Public Shared currentPage As String 'for knowing what page are we base on the button being clicked.

    Dim inventoryFormSubForms As New InventoryForm

    Dim buttonsClicked As New List(Of Button)

    Dim userNameLabel As String
    Dim userName As String

    Sub formInsidePanel(ByVal panelForm As Form)

        panelMain.Controls.Clear()
        panelForm.TopLevel = False
        panelForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panelForm.Dock = DockStyle.Fill
        panelMain.Controls.Add(panelForm)
        panelForm.Show()

        toShowOrHideInventorySubForms(panelForm)

    End Sub

    Private Sub toShowOrHideInventorySubForms(ByVal currentRunningForm As Form)

        If InventoryForm.poppedUpFormInitialized Then

            If currentRunningForm.Name <> InventoryForm.Name Then

                InventoryForm.formThatIsCurrentlyPoppedUp.Hide() 'taguan sa ang nag pop up na InventoryForm sub form, kay nibalhin man ka sa other page
            Else
                If Not InventoryForm.formThatIsCurrentlyPoppedUp.Visible Then
                    InventoryForm.formThatIsCurrentlyPoppedUp.Show() 'mo show og usab ang Inventory sub form kay nibalik man ka sa inventory na page
                End If
            End If
        End If
    End Sub

    Private Sub AdminWelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUserTypeLabel.Text = frmLoginPage.selectedUserType
        lblUserLastName.Text = DatabaseModule.retrievedLastName

        formInsidePanel(DashboardForm)

        buttonClicked(btnDashboard)
    End Sub

    Private Sub AdminWelcomePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim optionToCLose As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Notice!", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)

        'Closes the application if the choice in MessageDialog is OK
        If optionToCLose = DialogResult.OK Then

            frmLoginPage.Close()

        Else

            e.Cancel = True

        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        buttonClicked(btnDashboard)

        formInsidePanel(dashboard)
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click


        buttonClicked(btnCashier)

        formInsidePanel(cashier)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click


        buttonClicked(btnInventory)

        formInsidePanel(inventory)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click


        Dim optionToCLose As DialogResult = MessageBox.Show("Are you sure you want to Logout?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

        If optionToCLose = DialogResult.Yes Then

            frmLoginPage.Show()

            If InventoryForm.poppedUpFormInitialized Then

                If InventoryForm.formThatIsCurrentlyPoppedUp Is PopUpInventory_Add Then

                    PopUpInventory_Add.Dispose()

                ElseIf InventoryForm.formThatIsCurrentlyPoppedUp Is PopUpInventory_Update Then

                    PopUpInventory_Update.Dispose()

                End If
            End If

            InventoryForm.poppedUpFormInitialized = False
            Me.Dispose()
        End If


    End Sub

    Private Sub buttonClicked(ByVal button As Button)

        buttonsClicked.Add(button)

        ' Change the color of the newly clicked button
        button.BackColor = Color.FromArgb(255, 90, 90, 90) 'Active color

        'Reset the previous button's color if more than one button is clicked
        If buttonsClicked.Count > 1 Then
            Dim previousButton As Button = buttonsClicked(buttonsClicked.Count - 2)
            previousButton.BackColor = Color.FromArgb(255, 64, 64, 64)
        End If

        currentPage = button.Name

    End Sub

End Class