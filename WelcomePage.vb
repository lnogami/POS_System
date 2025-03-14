Imports System.Drawing.Drawing2D

Public Class WelcomePage

    'Still in observation
    Dim dashboard As New DashboardForm
    Dim cashier As New CashierForm
    Dim inventory As New InventoryForm
    Dim sales As New SalesForm
    Dim manageAccounts As New ManageAccountsForm

    Public Shared currentPage As String 'for knowing what page are we base on the button being clicked.

    Dim inventoryFormSubForms As New InventoryForm 'para ni sa mga mini windows na mag pop up sa Inventory na Form

    Dim buttonsClicked As New List(Of Button) 'pang ilhanan rani nga ang button kay na clicked, para ma highlightan ang button nga currently clicked

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
            'MessageBox.Show("Initialized!")
            If currentRunningForm.Name <> InventoryForm.Name Then
                'MessageBox.Show("Hello World!")
                InventoryForm.formThatIsCurrentlyPoppedUp.Hide() 'taguan sa ang nag pop up na InventoryForm sub form, kay nibalhin man ka sa other page
            Else
                If InventoryForm.formThatIsCurrentlyPoppedUp.IsDisposed Then
                    'MessageBox.Show("Already Disposed!")
                    Exit Sub
                ElseIf Not InventoryForm.formThatIsCurrentlyPoppedUp.Visible Then
                    'MessageBox.Show("Hllooeeee")
                    InventoryForm.formThatIsCurrentlyPoppedUp.Show() 'mo show og usab ang Inventory sub form kay nibalik man ka sa inventory na page
                End If
                'InventoryForm.formThatIsCurrentlyPoppedUp.Visible = False) AndAlso InventoryForm.formThatIsCurrentlyPoppedUp.IsDisposed Then
                'InventoryForm.formThatIsCurrentlyPoppedUp.Show() 'mo show og usab ang Inventory sub form kay nibalik man ka sa inventory na page
                '   
            End If
        Else
            'MessageBox.Show("Not yet initialized!: " + InventoryForm.poppedUpFormInitialized.ToString)
        End If
    End Sub

    Private Sub AdminWelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUserTypeLabel.Text = frmLoginPage.selectedUserType
        lblUsername.Text = DatabaseModule.retrievedLastName

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

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click

        buttonClicked(btnSales)

        formInsidePanel(sales)

    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click

        buttonClicked(btnAccounts)

        formInsidePanel(manageAccounts)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click


        Dim optionToCLose As DialogResult = MessageBox.Show("Are you sure you want to Logout?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)

        If optionToCLose = DialogResult.Yes Then

            frmLoginPage.Show()

            If InventoryForm.poppedUpFormInitialized Then

                If InventoryForm.formThatIsCurrentlyPoppedUp Is PopUpInventory_Add Then
                    'InventoryForm.toDisposePoppedUpForm(True)
                    'MessageBox.Show("The add form is showned")
                    PopUpInventory_Add.Dispose()

                ElseIf InventoryForm.formThatIsCurrentlyPoppedUp Is PopUpInventory_Update Then

                    'MessageBox.Show("The update form is showned")
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

        'MessageBox.Show("Current Page: " + currentPage)
        'MessageBox.Show("Button Name: " + button.Name)
        'MessageBox.Show("Inventory Name: " + Me.btnInventory.Name)

    End Sub

End Class