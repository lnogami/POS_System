<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginPage))
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cboxEntitySelection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegisterNewAccount = New System.Windows.Forms.LinkLabel()
        Me.chckboxShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.imgboxHeaderImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.imgboxHeaderImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(188, 296)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.txtUserName.MaxLength = 30
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(297, 40)
        Me.txtUserName.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(188, 342)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(297, 40)
        Me.txtPassword.TabIndex = 3
        '
        'cboxEntitySelection
        '
        Me.cboxEntitySelection.DisplayMember = "Admin"
        Me.cboxEntitySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEntitySelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxEntitySelection.FormattingEnabled = True
        Me.cboxEntitySelection.Location = New System.Drawing.Point(54, 231)
        Me.cboxEntitySelection.Name = "cboxEntitySelection"
        Me.cboxEntitySelection.Size = New System.Drawing.Size(431, 33)
        Me.cboxEntitySelection.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(49, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(49, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password :"
        '
        'lblRegisterNewAccount
        '
        Me.lblRegisterNewAccount.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lblRegisterNewAccount.AutoSize = True
        Me.lblRegisterNewAccount.BackColor = System.Drawing.Color.Transparent
        Me.lblRegisterNewAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterNewAccount.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblRegisterNewAccount.Location = New System.Drawing.Point(50, 442)
        Me.lblRegisterNewAccount.Name = "lblRegisterNewAccount"
        Me.lblRegisterNewAccount.Size = New System.Drawing.Size(172, 24)
        Me.lblRegisterNewAccount.TabIndex = 8
        Me.lblRegisterNewAccount.TabStop = True
        Me.lblRegisterNewAccount.Tag = ""
        Me.lblRegisterNewAccount.Text = "Register new user?"
        '
        'chckboxShowPassword
        '
        Me.chckboxShowPassword.AutoSize = True
        Me.chckboxShowPassword.Checked = True
        Me.chckboxShowPassword.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckboxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chckboxShowPassword.Location = New System.Drawing.Point(452, 352)
        Me.chckboxShowPassword.Name = "chckboxShowPassword"
        Me.chckboxShowPassword.Size = New System.Drawing.Size(22, 21)
        Me.chckboxShowPassword.TabIndex = 10
        Me.chckboxShowPassword.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnLogin.BackgroundImage = Global.POS_System.My.Resources.Resources.metalic_gray
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogin.Location = New System.Drawing.Point(288, 428)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(197, 48)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'imgboxHeaderImage
        '
        Me.imgboxHeaderImage.Image = Global.POS_System.My.Resources.Resources.friomotors_logo_landscape
        Me.imgboxHeaderImage.Location = New System.Drawing.Point(-12, 39)
        Me.imgboxHeaderImage.Name = "imgboxHeaderImage"
        Me.imgboxHeaderImage.Size = New System.Drawing.Size(559, 144)
        Me.imgboxHeaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgboxHeaderImage.TabIndex = 9
        Me.imgboxHeaderImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 43)
        Me.Panel1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(6, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LOGIN"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.POS_System.My.Resources.Resources.x2
        Me.btnExit.Location = New System.Drawing.Point(468, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.btnExit.Size = New System.Drawing.Size(72, 43)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmLoginPage
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.POS_System.My.Resources.Resources.linear_gradient1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 516)
        Me.Controls.Add(Me.chckboxShowPassword)
        Me.Controls.Add(Me.imgboxHeaderImage)
        Me.Controls.Add(Me.lblRegisterNewAccount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxEntitySelection)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.imgboxHeaderImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cboxEntitySelection As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRegisterNewAccount As LinkLabel
    Friend WithEvents imgboxHeaderImage As PictureBox
    Friend WithEvents chckboxShowPassword As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
End Class
