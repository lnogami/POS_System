<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.imgboxHeaderImage = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblNotice1 = New System.Windows.Forms.Label()
        Me.panelScrollablePanel = New System.Windows.Forms.Panel()
        Me.dtPickerBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.radBtnFemale = New System.Windows.Forms.RadioButton()
        Me.radBtnMale = New System.Windows.Forms.RadioButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblNotice3 = New System.Windows.Forms.Label()
        Me.chckBoxIAgree = New System.Windows.Forms.CheckBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblSubCategory2 = New System.Windows.Forms.Label()
        Me.lblLineBorder2 = New System.Windows.Forms.Label()
        Me.lblSubCategory1 = New System.Windows.Forms.Label()
        Me.lblLineBorder1 = New System.Windows.Forms.Label()
        Me.panelBottomPanel = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblNotice4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtAssignedUserType = New System.Windows.Forms.TextBox()
        Me.lblYouAreHereAs = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        CType(Me.imgboxHeaderImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelScrollablePanel.SuspendLayout()
        Me.panelBottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgboxHeaderImage
        '
        Me.imgboxHeaderImage.Image = Global.POS_System.My.Resources.Resources.friomotors_logo_landscape
        Me.imgboxHeaderImage.Location = New System.Drawing.Point(49, 61)
        Me.imgboxHeaderImage.Name = "imgboxHeaderImage"
        Me.imgboxHeaderImage.Size = New System.Drawing.Size(537, 140)
        Me.imgboxHeaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgboxHeaderImage.TabIndex = 10
        Me.imgboxHeaderImage.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(44, 223)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(357, 29)
        Me.lblWelcome.TabIndex = 11
        Me.lblWelcome.Text = "Welcome to FRIO MOTOHUB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblNotice1
        '
        Me.lblNotice1.AutoSize = True
        Me.lblNotice1.BackColor = System.Drawing.Color.Transparent
        Me.lblNotice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice1.Location = New System.Drawing.Point(44, 264)
        Me.lblNotice1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNotice1.Name = "lblNotice1"
        Me.lblNotice1.Size = New System.Drawing.Size(474, 50)
        Me.lblNotice1.TabIndex = 12
        Me.lblNotice1.Text = "Notice: You are required to enter valid data in each of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the following fields in" &
    " this form, thanks." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'panelScrollablePanel
        '
        Me.panelScrollablePanel.AutoScroll = True
        Me.panelScrollablePanel.Controls.Add(Me.dtPickerBirthDate)
        Me.panelScrollablePanel.Controls.Add(Me.radBtnFemale)
        Me.panelScrollablePanel.Controls.Add(Me.radBtnMale)
        Me.panelScrollablePanel.Controls.Add(Me.Label20)
        Me.panelScrollablePanel.Controls.Add(Me.lblNotice3)
        Me.panelScrollablePanel.Controls.Add(Me.chckBoxIAgree)
        Me.panelScrollablePanel.Controls.Add(Me.txtContactNo)
        Me.panelScrollablePanel.Controls.Add(Me.lblContactNo)
        Me.panelScrollablePanel.Controls.Add(Me.txtAddress)
        Me.panelScrollablePanel.Controls.Add(Me.lblAddress)
        Me.panelScrollablePanel.Controls.Add(Me.lblBirthdate)
        Me.panelScrollablePanel.Controls.Add(Me.txtAge)
        Me.panelScrollablePanel.Controls.Add(Me.lblSex)
        Me.panelScrollablePanel.Controls.Add(Me.lblAge)
        Me.panelScrollablePanel.Controls.Add(Me.txtFirstName)
        Me.panelScrollablePanel.Controls.Add(Me.txtLastName)
        Me.panelScrollablePanel.Controls.Add(Me.lblFirstName)
        Me.panelScrollablePanel.Controls.Add(Me.lblLastName)
        Me.panelScrollablePanel.Controls.Add(Me.lblSubCategory2)
        Me.panelScrollablePanel.Controls.Add(Me.lblLineBorder2)
        Me.panelScrollablePanel.Controls.Add(Me.lblSubCategory1)
        Me.panelScrollablePanel.Controls.Add(Me.lblLineBorder1)
        Me.panelScrollablePanel.Controls.Add(Me.panelBottomPanel)
        Me.panelScrollablePanel.Controls.Add(Me.txtPassword)
        Me.panelScrollablePanel.Controls.Add(Me.txtUsername)
        Me.panelScrollablePanel.Controls.Add(Me.txtAssignedUserType)
        Me.panelScrollablePanel.Controls.Add(Me.lblYouAreHereAs)
        Me.panelScrollablePanel.Controls.Add(Me.lblPassword)
        Me.panelScrollablePanel.Controls.Add(Me.lblUsername)
        Me.panelScrollablePanel.Location = New System.Drawing.Point(0, 339)
        Me.panelScrollablePanel.Name = "panelScrollablePanel"
        Me.panelScrollablePanel.Size = New System.Drawing.Size(631, 366)
        Me.panelScrollablePanel.TabIndex = 13
        '
        'dtPickerBirthDate
        '
        Me.dtPickerBirthDate.CustomFormat = " MM / dd / yyyy     (MMMM,dddd)"
        Me.dtPickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerBirthDate.Location = New System.Drawing.Point(224, 599)
        Me.dtPickerBirthDate.Name = "dtPickerBirthDate"
        Me.dtPickerBirthDate.Size = New System.Drawing.Size(362, 26)
        Me.dtPickerBirthDate.TabIndex = 52
        '
        'radBtnFemale
        '
        Me.radBtnFemale.AutoSize = True
        Me.radBtnFemale.Location = New System.Drawing.Point(307, 551)
        Me.radBtnFemale.Name = "radBtnFemale"
        Me.radBtnFemale.Size = New System.Drawing.Size(87, 24)
        Me.radBtnFemale.TabIndex = 51
        Me.radBtnFemale.TabStop = True
        Me.radBtnFemale.Text = "Female"
        Me.radBtnFemale.UseVisualStyleBackColor = True
        '
        'radBtnMale
        '
        Me.radBtnMale.AutoSize = True
        Me.radBtnMale.Location = New System.Drawing.Point(232, 551)
        Me.radBtnMale.Name = "radBtnMale"
        Me.radBtnMale.Size = New System.Drawing.Size(68, 24)
        Me.radBtnMale.TabIndex = 50
        Me.radBtnMale.TabStop = True
        Me.radBtnMale.Text = "Male"
        Me.radBtnMale.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(44, 773)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(507, 25)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "_____________________________________________"
        '
        'lblNotice3
        '
        Me.lblNotice3.AutoSize = True
        Me.lblNotice3.BackColor = System.Drawing.Color.Transparent
        Me.lblNotice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice3.Location = New System.Drawing.Point(39, 806)
        Me.lblNotice3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNotice3.Name = "lblNotice3"
        Me.lblNotice3.Size = New System.Drawing.Size(552, 44)
        Me.lblNotice3.TabIndex = 15
        Me.lblNotice3.Text = "Notice: Please review every data you input, ensuring that everything" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           " &
    "  is accurate. Thanks!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'chckBoxIAgree
        '
        Me.chckBoxIAgree.AutoSize = True
        Me.chckBoxIAgree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckBoxIAgree.Location = New System.Drawing.Point(43, 887)
        Me.chckBoxIAgree.Name = "chckBoxIAgree"
        Me.chckBoxIAgree.Size = New System.Drawing.Size(98, 29)
        Me.chckBoxIAgree.TabIndex = 11
        Me.chckBoxIAgree.Text = "I agree"
        Me.chckBoxIAgree.UseVisualStyleBackColor = True
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(224, 681)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtContactNo.MaxLength = 30
        Me.txtContactNo.Multiline = True
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(362, 40)
        Me.txtContactNo.TabIndex = 10
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.BackColor = System.Drawing.Color.Transparent
        Me.lblContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNo.Location = New System.Drawing.Point(44, 695)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(121, 25)
        Me.lblContactNo.TabIndex = 48
        Me.lblContactNo.Text = "Contact No.:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(224, 633)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtAddress.MaxLength = 30
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(362, 40)
        Me.txtAddress.TabIndex = 9
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(44, 647)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(91, 25)
        Me.lblAddress.TabIndex = 45
        Me.lblAddress.Text = "Address:"
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdate.Location = New System.Drawing.Point(44, 600)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(95, 25)
        Me.lblBirthdate.TabIndex = 44
        Me.lblBirthdate.Text = "Birthdate:"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(224, 489)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtAge.MaxLength = 30
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(362, 40)
        Me.txtAge.TabIndex = 6
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.Transparent
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(44, 551)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(53, 25)
        Me.lblSex.TabIndex = 41
        Me.lblSex.Text = "Sex:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(44, 503)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(54, 25)
        Me.lblAge.TabIndex = 40
        Me.lblAge.Text = "Age:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(224, 349)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(362, 40)
        Me.txtFirstName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(224, 396)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(362, 40)
        Me.txtLastName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(44, 363)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(109, 25)
        Me.lblFirstName.TabIndex = 35
        Me.lblFirstName.Text = "First name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(44, 410)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(109, 25)
        Me.lblLastName.TabIndex = 34
        Me.lblLastName.Text = "Last name:"
        '
        'lblSubCategory2
        '
        Me.lblSubCategory2.AutoSize = True
        Me.lblSubCategory2.BackColor = System.Drawing.Color.Transparent
        Me.lblSubCategory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubCategory2.Location = New System.Drawing.Point(45, 311)
        Me.lblSubCategory2.Name = "lblSubCategory2"
        Me.lblSubCategory2.Size = New System.Drawing.Size(96, 22)
        Me.lblSubCategory2.TabIndex = 32
        Me.lblSubCategory2.Text = "About you:"
        '
        'lblLineBorder2
        '
        Me.lblLineBorder2.AutoSize = True
        Me.lblLineBorder2.BackColor = System.Drawing.Color.Transparent
        Me.lblLineBorder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineBorder2.Location = New System.Drawing.Point(44, 311)
        Me.lblLineBorder2.Name = "lblLineBorder2"
        Me.lblLineBorder2.Size = New System.Drawing.Size(507, 25)
        Me.lblLineBorder2.TabIndex = 33
        Me.lblLineBorder2.Text = "_____________________________________________"
        '
        'lblSubCategory1
        '
        Me.lblSubCategory1.AutoSize = True
        Me.lblSubCategory1.BackColor = System.Drawing.Color.Transparent
        Me.lblSubCategory1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubCategory1.Location = New System.Drawing.Point(45, 121)
        Me.lblSubCategory1.Name = "lblSubCategory1"
        Me.lblSubCategory1.Size = New System.Drawing.Size(237, 22)
        Me.lblSubCategory1.TabIndex = 30
        Me.lblSubCategory1.Text = "Setup your login credentials "
        '
        'lblLineBorder1
        '
        Me.lblLineBorder1.AutoSize = True
        Me.lblLineBorder1.BackColor = System.Drawing.Color.Transparent
        Me.lblLineBorder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineBorder1.Location = New System.Drawing.Point(44, 121)
        Me.lblLineBorder1.Name = "lblLineBorder1"
        Me.lblLineBorder1.Size = New System.Drawing.Size(507, 25)
        Me.lblLineBorder1.TabIndex = 31
        Me.lblLineBorder1.Text = "_____________________________________________"
        '
        'panelBottomPanel
        '
        Me.panelBottomPanel.Controls.Add(Me.btnCancel)
        Me.panelBottomPanel.Controls.Add(Me.lblNotice4)
        Me.panelBottomPanel.Controls.Add(Me.btnSave)
        Me.panelBottomPanel.Location = New System.Drawing.Point(3, 919)
        Me.panelBottomPanel.Name = "panelBottomPanel"
        Me.panelBottomPanel.Size = New System.Drawing.Size(599, 187)
        Me.panelBottomPanel.TabIndex = 23
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancel.Location = New System.Drawing.Point(179, 98)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(183, 48)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblNotice4
        '
        Me.lblNotice4.AutoSize = True
        Me.lblNotice4.BackColor = System.Drawing.Color.Transparent
        Me.lblNotice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice4.Location = New System.Drawing.Point(36, 0)
        Me.lblNotice4.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNotice4.Name = "lblNotice4"
        Me.lblNotice4.Size = New System.Drawing.Size(524, 60)
        Me.lblNotice4.TabIndex = 14
        Me.lblNotice4.Text = "I hereby agree that all information I have given are correct and valid, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and giv" &
    "e permission to use my data for this job, and in this job ONLY." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSave.BackgroundImage = Global.POS_System.My.Resources.Resources.metalic_gray
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(391, 98)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(197, 48)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(224, 205)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(362, 40)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(224, 158)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(362, 40)
        Me.txtUsername.TabIndex = 1
        '
        'txtAssignedUserType
        '
        Me.txtAssignedUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssignedUserType.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtAssignedUserType.Location = New System.Drawing.Point(224, 34)
        Me.txtAssignedUserType.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtAssignedUserType.MaxLength = 30
        Me.txtAssignedUserType.Multiline = True
        Me.txtAssignedUserType.Name = "txtAssignedUserType"
        Me.txtAssignedUserType.ReadOnly = True
        Me.txtAssignedUserType.Size = New System.Drawing.Size(362, 40)
        Me.txtAssignedUserType.TabIndex = 13
        Me.txtAssignedUserType.TabStop = False
        '
        'lblYouAreHereAs
        '
        Me.lblYouAreHereAs.AutoSize = True
        Me.lblYouAreHereAs.BackColor = System.Drawing.Color.Transparent
        Me.lblYouAreHereAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYouAreHereAs.Location = New System.Drawing.Point(44, 41)
        Me.lblYouAreHereAs.Name = "lblYouAreHereAs"
        Me.lblYouAreHereAs.Size = New System.Drawing.Size(156, 25)
        Me.lblYouAreHereAs.TabIndex = 12
        Me.lblYouAreHereAs.Text = "You are here as:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(44, 215)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(109, 25)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(44, 173)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(113, 25)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username :"
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 705)
        Me.Controls.Add(Me.panelScrollablePanel)
        Me.Controls.Add(Me.lblNotice1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.imgboxHeaderImage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        CType(Me.imgboxHeaderImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelScrollablePanel.ResumeLayout(False)
        Me.panelScrollablePanel.PerformLayout()
        Me.panelBottomPanel.ResumeLayout(False)
        Me.panelBottomPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgboxHeaderImage As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblNotice1 As Label
    Friend WithEvents panelScrollablePanel As Panel
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblYouAreHereAs As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtAssignedUserType As TextBox
    Friend WithEvents panelBottomPanel As Panel
    Friend WithEvents lblSubCategory1 As Label
    Friend WithEvents lblLineBorder1 As Label
    Friend WithEvents lblSubCategory2 As Label
    Friend WithEvents lblLineBorder2 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents lblContactNo As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblNotice4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents chckBoxIAgree As CheckBox
    Friend WithEvents lblNotice3 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents radBtnFemale As RadioButton
    Friend WithEvents radBtnMale As RadioButton
    Friend WithEvents dtPickerBirthDate As DateTimePicker
End Class
