<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomePage))
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelSideNavBar = New System.Windows.Forms.Panel()
        Me.panelSideNavBarIcon = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserTypeLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelLineBorder = New System.Windows.Forms.Panel()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnCashier = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.panelSideNavBar.SuspendLayout()
        Me.panelSideNavBarIcon.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelMain.Location = New System.Drawing.Point(346, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1032, 944)
        Me.panelMain.TabIndex = 1
        '
        'panelSideNavBar
        '
        Me.panelSideNavBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelSideNavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelSideNavBar.Controls.Add(Me.panelSideNavBarIcon)
        Me.panelSideNavBar.Controls.Add(Me.panelLineBorder)
        Me.panelSideNavBar.Controls.Add(Me.btnAccounts)
        Me.panelSideNavBar.Controls.Add(Me.btnSales)
        Me.panelSideNavBar.Controls.Add(Me.btnInventory)
        Me.panelSideNavBar.Controls.Add(Me.btnDashboard)
        Me.panelSideNavBar.Controls.Add(Me.btnCashier)
        Me.panelSideNavBar.Controls.Add(Me.btnLogout)
        Me.panelSideNavBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSideNavBar.Location = New System.Drawing.Point(0, 0)
        Me.panelSideNavBar.Margin = New System.Windows.Forms.Padding(0)
        Me.panelSideNavBar.Name = "panelSideNavBar"
        Me.panelSideNavBar.Size = New System.Drawing.Size(356, 944)
        Me.panelSideNavBar.TabIndex = 0
        '
        'panelSideNavBarIcon
        '
        Me.panelSideNavBarIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelSideNavBarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelSideNavBarIcon.Controls.Add(Me.lblUsername)
        Me.panelSideNavBarIcon.Controls.Add(Me.lblUserTypeLabel)
        Me.panelSideNavBarIcon.Controls.Add(Me.PictureBox1)
        Me.panelSideNavBarIcon.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSideNavBarIcon.Location = New System.Drawing.Point(0, 0)
        Me.panelSideNavBarIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.panelSideNavBarIcon.Name = "panelSideNavBarIcon"
        Me.panelSideNavBarIcon.Size = New System.Drawing.Size(356, 380)
        Me.panelSideNavBarIcon.TabIndex = 5
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblUsername.Location = New System.Drawing.Point(170, 313)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(111, 29)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Inogami"
        '
        'lblUserTypeLabel
        '
        Me.lblUserTypeLabel.AutoSize = True
        Me.lblUserTypeLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserTypeLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblUserTypeLabel.Location = New System.Drawing.Point(70, 313)
        Me.lblUserTypeLabel.Name = "lblUserTypeLabel"
        Me.lblUserTypeLabel.Size = New System.Drawing.Size(99, 29)
        Me.lblUserTypeLabel.TabIndex = 2
        Me.lblUserTypeLabel.Text = "Admin:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.POS_System.My.Resources.Resources.friomotors_logo1
        Me.PictureBox1.InitialImage = Global.POS_System.My.Resources.Resources.friomotors_logo1
        Me.PictureBox1.Location = New System.Drawing.Point(57, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'panelLineBorder
        '
        Me.panelLineBorder.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelLineBorder.Location = New System.Drawing.Point(-25, 855)
        Me.panelLineBorder.Margin = New System.Windows.Forms.Padding(0)
        Me.panelLineBorder.Name = "panelLineBorder"
        Me.panelLineBorder.Size = New System.Drawing.Size(382, 5)
        Me.panelLineBorder.TabIndex = 11
        '
        'btnAccounts
        '
        Me.btnAccounts.FlatAppearance.BorderSize = 0
        Me.btnAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounts.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAccounts.Image = Global.POS_System.My.Resources.Resources.account
        Me.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccounts.Location = New System.Drawing.Point(0, 753)
        Me.btnAccounts.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAccounts.Size = New System.Drawing.Size(357, 90)
        Me.btnAccounts.TabIndex = 9
        Me.btnAccounts.Text = "     Accounts"
        Me.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSales.Image = Global.POS_System.My.Resources.Resources.sales
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(0, 663)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSales.Size = New System.Drawing.Size(357, 90)
        Me.btnSales.TabIndex = 8
        Me.btnSales.Text = "     Sales"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnInventory.Image = Global.POS_System.My.Resources.Resources.inventory
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 574)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnInventory.Size = New System.Drawing.Size(357, 90)
        Me.btnInventory.TabIndex = 7
        Me.btnInventory.Text = "     Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDashboard.Image = Global.POS_System.My.Resources.Resources.dashboard_panel__1_
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 395)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(357, 90)
        Me.btnDashboard.TabIndex = 6
        Me.btnDashboard.Text = "     Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnCashier
        '
        Me.btnCashier.FlatAppearance.BorderSize = 0
        Me.btnCashier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashier.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCashier.Image = Global.POS_System.My.Resources.Resources.cash_register1
        Me.btnCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashier.Location = New System.Drawing.Point(0, 484)
        Me.btnCashier.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCashier.Name = "btnCashier"
        Me.btnCashier.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCashier.Size = New System.Drawing.Size(357, 90)
        Me.btnCashier.TabIndex = 1
        Me.btnCashier.Text = "     Cashier"
        Me.btnCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCashier.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogout.Image = Global.POS_System.My.Resources.Resources.sign_out
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 860)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(356, 84)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "     Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 944)
        Me.Controls.Add(Me.panelSideNavBar)
        Me.Controls.Add(Me.panelMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 80)
        Me.MaximumSize = New System.Drawing.Size(1400, 1000)
        Me.Name = "WelcomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FRIO MOTOHUB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelSideNavBar.ResumeLayout(False)
        Me.panelSideNavBarIcon.ResumeLayout(False)
        Me.panelSideNavBarIcon.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSideNavBar As Panel
    Friend WithEvents btnCashier As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelSideNavBarIcon As Panel
    Friend WithEvents btnSales As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents panelMain As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAccounts As Button
    Friend WithEvents panelLineBorder As Panel
    Friend WithEvents lblUserTypeLabel As Label
    Friend WithEvents lblUsername As Label
End Class
