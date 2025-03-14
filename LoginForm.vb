Public Class frmLoginPage

    Dim isInitializing As Boolean = True
    Dim comboBoxLabel As String
    Dim hasSelectedUserType As Boolean
    Public Shared selectedUserType As String



    Private Sub frmLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comboBoxLabel = "Please select User Type"

        cboxEntitySelection.Items.AddRange(New String() {"Admin", "Cashier"}) ', "Customer"})
        cboxEntitySelection.Items.Add(comboBoxLabel)

        cboxEntitySelection.SelectedIndex = cboxEntitySelection.Items.IndexOf(comboBoxLabel)

        'Humanag initialize
        isInitializing = False

    End Sub

    Private Sub chckboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPassword.CheckedChanged

        'hides the password characters
        If chckboxShowPassword.Checked Then
            txtPassword.PasswordChar = "*"
            txtPassword.Font = New Font(txtPassword.Font.FontFamily, 14)
        Else
            txtPassword.PasswordChar = ""
            txtPassword.Font = New Font(txtPassword.Font.FontFamily, 11)
        End If

    End Sub

    Private Sub cboxEntity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxEntitySelection.SelectedIndexChanged

        'Exits sub kay ga initialize pa, which means dili sa itrigger dapat ang nasa ubos maon need e exit
        If isInitializing Then Exit Sub

        If cboxEntitySelection.SelectedIndex = cboxEntitySelection.Items.IndexOf(comboBoxLabel) Then

            hasSelectedUserType = True

        End If

        'Changes the link label of Register New Account
        If cboxEntitySelection.SelectedItem = "Admin" Then

            lblRegisterNewAccount.Text = "Register new Admin?"

        ElseIf cboxEntitySelection.SelectedItem = "Cashier" Then

            lblRegisterNewAccount.Text = "Register new Cashier?"

            'ElseIf cboxEntitySelection.SelectedItem = "Customer" Then

            '    lblRegisterNewAccount.Text = "Register new Customer?"

        End If

    End Sub


    Private Sub cboxEntitySelection_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboxEntitySelection.SelectionChangeCommitted
        'MessageBox.Show("helloooo")

        'comboBoxLabel = cboxEntitySelection.SelectedItem
        'cboxEntitySelection.SelectedIndex = cboxEntitySelection.Items.IndexOf(comboBoxLabel)

    End Sub

    Private Sub cboxEntity_DropDown(sender As Object, e As EventArgs) Handles cboxEntitySelection.DropDown

        If cboxEntitySelection.Items.Contains(comboBoxLabel) Then
            cboxEntitySelection.Items.Remove(comboBoxLabel)
            'cboxEntitySelection.Items.RemoveAt(0)
        End If

    End Sub

    Private Sub cboxEntity_DropDownClosed(sender As Object, e As EventArgs) Handles cboxEntitySelection.DropDownClosed

        If Not cboxEntitySelection.Items.Contains(comboBoxLabel) And Not hasSelectedUserType Then

            cboxEntitySelection.Items.Add(comboBoxLabel)

            'E paris jud ning duha para di dayun ma trigger ang cboxEntitySelection.SelectedIndexChanged na event
            isInitializing = True
            cboxEntitySelection.SelectedIndex = cboxEntitySelection.Items.IndexOf(comboBoxLabel)
            'Para pwede na ma trigger ang cboxEntitySelection.SelectedIndexChanged na event
            isInitializing = False
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        DatabaseModule.loginAutherntication(cboxEntitySelection.SelectedItem.ToString.ToLower, txtUserName.Text, txtPassword.Text)

        If DatabaseModule.accessGranted Then

            'For changing the lblUserTypeLabel (and maybe also not yet implemented lblUserName on all Welcome Pages
            selectedUserType = cboxEntitySelection.SelectedItem.ToString + ":"

            Select Case (cboxEntitySelection.SelectedItem)
                Case "Admin"
                    Dim mainForm As New WelcomePage
                    mainForm.Show()
                    Me.Hide()

                    'iya rang ipang reset ang value sa textbox og uban pa after mag log in
                    loginFieldValueReverter()

                Case "Cashier"
                    Dim cashierMainForm As New CashierSideWelcomPage
                    cashierMainForm.Show()
                    Me.Hide()

                    'iya rang ipang reset ang value sa textbox og uban pa after mag log in
                    loginFieldValueReverter()

                Case Else
                    MessageBox.Show("There must be a problem logging in..", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Select

        End If
    End Sub

    Private Sub lblRegisterNewAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegisterNewAccount.LinkClicked

        If cboxEntitySelection.SelectedItem = comboBoxLabel Then

            MessageBox.Show("Please select a User Type", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Exit Sub
        End If

        Dim registrationForm As New RegistrationForm(cboxEntitySelection.SelectedItem, True)
        registrationForm.Show()

        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub loginFieldValueReverter() 'igo rani mag reset sa value sa kada fields na nafill upan pag login

        cboxEntitySelection.Items.Add(comboBoxLabel)
        cboxEntitySelection.SelectedIndex = cboxEntitySelection.Items.IndexOf(comboBoxLabel)

        txtUserName.Text = ""
        txtPassword.Text = ""
        DatabaseModule.accessGranted = False
    End Sub

End Class
