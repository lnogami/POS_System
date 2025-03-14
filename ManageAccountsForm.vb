Public Class ManageAccountsForm

    Dim defaultUser As String = "(All)"

    Private Sub ManageAccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboxFilter.Items.AddRange(New String() {defaultUser, "Admin", "Cashier"}) '"Customer"})
        cboxFilter.SelectedItem = defaultUser

        makeACopyOfUsersDGV(dgvUsersAccount) 'para ma access ang dgvUsersAccount anywhere through module through this procedure
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If cboxFilter.SelectedItem <> defaultUser Then

            'ang una nga parameter is para automatic magpasa og value sa cboxUserType, and ang ikaduha is kung sa Login page ba ni na form gitawag
            Dim addUser As New RegistrationForm(cboxFilter.SelectedItem, False)

            'e show ang RegisterForm
            addUser.ShowDialog()

            cboxFilter.SelectedItem = defaultUser 'para ma reset into "all" ang filter, para ma view tanan users automatically once maka add na og new user

        Else
            'mag display og message somewhere sa screen para mahibal an sa user na kani na part ang gipasabot sa notice
            ShowTooltip(cboxFilter, cboxFilter.Location.X - 170, cboxFilter.Location.Y - 48, "Please select a value!")

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        'condition nga magpagawas og message if walay na select na user data (row) ang user
        If dgvUsersAccount.SelectedRows.Count <= 0 Then

            'mag display og message somewhere sa screen para mahibal an sa user na kani na part ang gipasabot sa notice
            ShowTooltip(lblSearchLabel, lblSearchLabel.Location.X + 3, lblSearchLabel.Location.Y - 18, "Please select a user!")
            Exit Sub

        End If

        'shows a message that indicates you cannot delete yourself kay ikaw mana
        If dgvUsersAccount.SelectedRows(0).Cells("Last Name").Value = retrievedLastName Then

            MessageBox.Show("You cannot delete yourself!")
            Exit Sub

        End If

        DatabaseModule.deleteUsers(dgvUsersAccount)

        DatabaseModule.loadUsers() 'e refresh ra niya ang dgv

    End Sub

    'Mag show og message somewhere sa screen para mahibal an sa user na kani ang gipasabot sa Notice
    Private Sub ShowTooltip(theObject As Object, xLocation As Integer, yLocation As Integer, message As String) 'magbuhat og object sa ToolTip class para pang notice sa user ang need niya buhaton

        Dim toolTip As New ToolTip()  'para murag dialog sa comics ang style sa mo pop up na message

        toolTip.IsBalloon = True 'e specify unsa nga style ang dialog
        toolTip.Show(message, theObject, xLocation, yLocation, 2000) ' Display for 2.5 seconds

        'toolTip.Show("Please select a value!", comboBox, comboBox.Width / 2, comboBox.Height / 2, 3000) ' Display for 3 seconds
    End Sub

    Private Sub cboxFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxFilter.SelectedIndexChanged

        If cboxFilter.SelectedItem = cboxFilter.Items.Item(1) Then 'ginamean ani is ang Admin na value
            'loadUsers(dgvUsersAccount, cboxFilter.Items.Item(1))

            DatabaseModule.loadUsers(dgvUsersAccount, cboxFilter.SelectedItem.ToString, txtSearchBar.Text)

        ElseIf cboxFilter.SelectedItem = cboxFilter.Items.Item(2) Then 'ginamean ani is ang Cashier na value
            'loadUsers(dgvUsersAccount, cboxFilter.Items.Item(2))

            DatabaseModule.loadUsers(dgvUsersAccount, cboxFilter.SelectedItem.ToString, txtSearchBar.Text)

        Else
            DatabaseModule.loadUsers(dgvUsersAccount, txtSearchBar.Text) 'default query, e load tanan maliban sa username og password
        End If
    End Sub

    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged
        'MessageBox.Show(cboxFilter.SelectedItem.ToString)

        DatabaseModule.loadUsers(dgvUsersAccount, txtSearchBar.Text)
    End Sub

    Private Sub chckBoxApprovedAdAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles chckBoxApprovedAsAdmin.CheckedChanged

        If dgvUsersAccount.SelectedRows.Count > 0 Then

            If dgvUsersAccount.SelectedRows(0).Cells("Last Name").Value = retrievedLastName Then

                MessageBox.Show("This is you," & vbNewLine & "and you cannot demote yourself!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                chckBoxApprovedAsAdmin.Checked = True
                Exit Sub

            End If

            toApproveAnAdmin(dgvUsersAccount.SelectedRows(0).Cells("id").Value, chckBoxApprovedAsAdmin)

        End If

    End Sub

    Private Sub dgvUsersAccount_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsersAccount.RowHeaderMouseClick

        'para if dili admin ang naclick na user dili mo appear ang check box
        If dgvUsersAccount.SelectedRows(0).Cells("Position").Value = "admin" Then

            chckBoxApprovedAsAdmin.Visible = True

            'to check the 'Approved' checkebox
            If dgvUsersAccount.SelectedRows.Count > 0 Then
                'MessageBox.Show(DatabaseModule.isApprovedAsAdmin(dgvUsersAccount.SelectedRows(0).Cells("id").Value).ToString)

                If DatabaseModule.isApprovedAsAdmin(dgvUsersAccount.SelectedRows(0).Cells("id").Value) Then  '1 mean true

                    chckBoxApprovedAsAdmin.Checked = True

                Else

                    chckBoxApprovedAsAdmin.Checked = False

                End If
            End If

        Else

            chckBoxApprovedAsAdmin.Visible = False

        End If

    End Sub


End Class