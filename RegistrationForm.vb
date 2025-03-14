Public Class RegistrationForm

    Dim assignedUserType As String
    Dim sex As String

    Dim informationRequiredCompletelyFilled As Boolean
    Dim skipFormClosingEvent As Boolean

    'to determine kung ang form is sa Login page ba sya gitawag
    Dim isCalledFromLoginPage As Boolean

    'Contrsructor ni haha
    Public Sub New(ByVal userType As String, ByVal calledFromLogin As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        'mag assign rani sa userType, para auto filled nato na field di na need inputan pa
        assignedUserType = userType
        'magdetermin if ang formlogin ba is sa Login sya gitawag, kay kung dili it means sa Manage User Accounts sya na iterface gitawag
        isCalledFromLoginPage = calledFromLogin
    End Sub

    Private Sub RegitrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtAssignedUserType.Text = assignedUserType
    End Sub

    'magpasmooth rani sa pag scroll sa pane
    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles panelScrollablePanel.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            panelScrollablePanel.VerticalScroll.Value = e.NewValue
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim toCancel As DialogResult = MessageBox.Show("Are you sure you want to exit?" + vbNewLine + "Your progress will not be saved.", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If toCancel = DialogResult.No Then

            Exit Sub

        Else
            'if sa Login page ba ni na form gitawag
            If isCalledFromLoginPage Then

                frmLoginPage.Show()
                Me.Dispose()

            Else

                skipFormClosingEvent = True  'para dili na ma execute ang Closing na event
                Me.Dispose()
            End If
        End If

    End Sub

    'before mag close ang form ma execute ni siya na block
    Private Sub RegistrationForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'para dili na ni ma execute na method if pisliton ang Cancel na button kay para kaisa ra mag ask if sure na ba na eexit
        If skipFormClosingEvent Or Not isCalledFromLoginPage Then
            skipFormClosingEvent = False 'e revert lang
            Exit Sub
        End If

        Dim optionToCLose As DialogResult = MessageBox.Show("Are you sure you want to exit?" + vbNewLine + "Your data will not be save!", "Notice!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        'Closes the application if the choice in MessageDialog is OK
        If optionToCLose = DialogResult.OK Then

            If isCalledFromLoginPage Then

                frmLoginPage.Show()
                Me.Dispose()

            Else
                Me.Dispose()
            End If

        Else

            e.Cancel = True

        End If
    End Sub

    Private Sub radBtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles radBtnMale.CheckedChanged
        sex = "Male"
    End Sub

    Private Sub radBtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radBtnFemale.CheckedChanged
        sex = "Female"
    End Sub

    'prevent the user from inputting not numbers
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    'prevent the user from inputting not numbers
    Private Sub txtContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNo.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

        If DatabaseModule.usernameAlreadyExist(txtAssignedUserType.Text, txtUsername.Text) Then
            txtUsername.Enabled = False
            txtUsername.Enabled = True
            txtUsername.Focus()
            ShowTooltip(txtUsername, 3, -40, "Username '" & txtUsername.Text & "' already in use")
        End If

    End Sub

    Private Sub ShowTooltip(theObject As Object, xLocation As Integer, yLocation As Integer, message As String) 'magbuhat og object sa ToolTip class para pang notice sa user ang need niya buhaton

        Dim toolTip As New ToolTip()  'para murag dialog sa comics ang style sa mo pop up na message

        toolTip.IsBalloon = True 'e specify unsa og asa dapit mo gawas ang dialog
        toolTip.Show(message, theObject, xLocation, yLocation, 2000) ' Display for 2.5 seconds

        'toolTip.Show("Please select a value!", comboBox, comboBox.Width / 2, comboBox.Height / 2, 3000) ' Display for 3 seconds
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If DatabaseModule.usernameAlreadyExist(txtAssignedUserType.Text, txtUsername.Text) Then
            'MessageBox.Show("Naexecute pa ni")
            txtUsername.Focus()
            ShowTooltip(txtUsername, txtUsername.Location.X - 135, txtUsername.Location.Y - 40, "Username already in use")

            Exit Sub
        End If

        'mo check if na ckecked ba ang I Agree na checkbox
        If Not chckBoxIAgree.Checked Then

            Dim optionToCLose As DialogResult = MessageBox.Show("Please check the " + Chr(34) + "I Agree" + Chr(34) + " first" + vbNewLine + "to save.", "Notice!", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)

            Exit Sub
        End If

        'sorry spaghetti code
        If String.IsNullOrEmpty(txtUsername.Text) Then
            MessageBox.Show("username empty")
            txtUsername.Focus() 'tawagon niya ang attention sa user para mailhan nga kani ang ginamean na wala pa na fill upan
        ElseIf String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("password empty")
            txtPassword.Focus()
        ElseIf String.IsNullOrEmpty(txtFirstName.Text) Then
            MessageBox.Show("first name empty")
            txtFirstName.Focus()
        ElseIf String.IsNullOrEmpty(txtLastName.Text) Then
            MessageBox.Show("last name empty")
            txtLastName.Focus()
        ElseIf String.IsNullOrEmpty(txtAge.Text) Then
            MessageBox.Show("age empty")
            txtAge.Focus()
        ElseIf String.IsNullOrEmpty(sex) Then
            MessageBox.Show("sex empty")
            lblSex.Focus()
        ElseIf String.IsNullOrEmpty(dtPickerBirthDate.ToString) OrElse dtPickerBirthDate.Value.ToString("MM/dd/yyyy") = Date.Now.ToString("MM/dd/yyyy") Then
            MessageBox.Show("birthdate empty")
            dtPickerBirthDate.Focus()
        ElseIf String.IsNullOrEmpty(txtAddress.Text) Then
            MessageBox.Show("address empty")
            txtAddress.Focus()
        ElseIf String.IsNullOrEmpty(txtContactNo.Text) Then
            MessageBox.Show("contact no. empty")
            txtContactNo.Focus()
        Else
            MessageBox.Show("Completely filled!")
            informationRequiredCompletelyFilled = True
        End If

        'if completely filled ang mga required nga infomation ma execute ni siya na block
        If informationRequiredCompletelyFilled Then

            DatabaseModule.addUsers(txtUsername.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, Integer.Parse(txtAge.Text), sex, dtPickerBirthDate.Value.ToString("yyyy-MM-dd"), txtAddress.Text, txtContactNo.Text, txtAssignedUserType.Text, Date.Now.ToString("yyyy-MM-dd"))

            If isCalledFromLoginPage Then
                frmLoginPage.Show()
                Me.Dispose()

            Else
                Me.Dispose()
            End If

            loadUsers() 'e refresh niya ang page

        End If

    End Sub


    Dim passwordFieldClickedAtLeastOnce As Boolean = False 'pang ilhanan if naclick na ba sa user ang kaning password field
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        If String.IsNullOrEmpty(txtPassword.Text) Then

            ShowTooltip(txtPassword, 5, -40, "You cannot create an account with empty password..")
        Else

            If Len(txtPassword.Text) < 6 Then

                ShowTooltip(txtPassword, 5, -40, "Your password is too short, please reconsider..")
                Exit Sub

            End If

        End If

    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        passwordFieldClickedAtLeastOnce = True
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If passwordFieldClickedAtLeastOnce Then 'need ni sya para dili ni ma trigger nga event sa start pa lang

            If String.IsNullOrEmpty(txtPassword.Text) Then

                ShowTooltip(txtPassword, 5, -40, "You cannot create an account with empty password..")
            Else

                If Len(txtPassword.Text) < 6 Then

                    ShowTooltip(txtPassword, 5, -40, "Your password is too short, please reconsider..")
                    Exit Sub

                End If

            End If

        End If
    End Sub

End Class