<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageAccountsForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.lblSearchLabel = New System.Windows.Forms.Label()
        Me.panelGDVControlPanel = New System.Windows.Forms.Panel()
        Me.chckBoxApprovedAsAdmin = New System.Windows.Forms.CheckBox()
        Me.dgvUsersAccount = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboxFilter = New System.Windows.Forms.ComboBox()
        Me.lblManageUserAccounts = New System.Windows.Forms.Label()
        Me.panelGDVControlPanel.SuspendLayout()
        CType(Me.dgvUsersAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchBar
        '
        Me.txtSearchBar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBar.Location = New System.Drawing.Point(102, 14)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(224, 35)
        Me.txtSearchBar.TabIndex = 22
        '
        'lblSearchLabel
        '
        Me.lblSearchLabel.AutoSize = True
        Me.lblSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.lblSearchLabel.Location = New System.Drawing.Point(1, 16)
        Me.lblSearchLabel.Name = "lblSearchLabel"
        Me.lblSearchLabel.Size = New System.Drawing.Size(95, 29)
        Me.lblSearchLabel.TabIndex = 21
        Me.lblSearchLabel.Text = "Search:"
        '
        'panelGDVControlPanel
        '
        Me.panelGDVControlPanel.Controls.Add(Me.chckBoxApprovedAsAdmin)
        Me.panelGDVControlPanel.Controls.Add(Me.dgvUsersAccount)
        Me.panelGDVControlPanel.Controls.Add(Me.btnDelete)
        Me.panelGDVControlPanel.Controls.Add(Me.btnAdd)
        Me.panelGDVControlPanel.Controls.Add(Me.cboxFilter)
        Me.panelGDVControlPanel.Controls.Add(Me.txtSearchBar)
        Me.panelGDVControlPanel.Controls.Add(Me.lblSearchLabel)
        Me.panelGDVControlPanel.Location = New System.Drawing.Point(22, 161)
        Me.panelGDVControlPanel.Name = "panelGDVControlPanel"
        Me.panelGDVControlPanel.Size = New System.Drawing.Size(993, 781)
        Me.panelGDVControlPanel.TabIndex = 23
        '
        'chckBoxApprovedAsAdmin
        '
        Me.chckBoxApprovedAsAdmin.AutoSize = True
        Me.chckBoxApprovedAsAdmin.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckBoxApprovedAsAdmin.ForeColor = System.Drawing.SystemColors.Control
        Me.chckBoxApprovedAsAdmin.Location = New System.Drawing.Point(518, 19)
        Me.chckBoxApprovedAsAdmin.Name = "chckBoxApprovedAsAdmin"
        Me.chckBoxApprovedAsAdmin.Size = New System.Drawing.Size(102, 30)
        Me.chckBoxApprovedAsAdmin.TabIndex = 26
        Me.chckBoxApprovedAsAdmin.Text = "Admin"
        Me.chckBoxApprovedAsAdmin.UseVisualStyleBackColor = True
        Me.chckBoxApprovedAsAdmin.Visible = False
        '
        'dgvUsersAccount
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsersAccount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUsersAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsersAccount.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUsersAccount.Location = New System.Drawing.Point(0, 62)
        Me.dgvUsersAccount.Name = "dgvUsersAccount"
        Me.dgvUsersAccount.ReadOnly = True
        Me.dgvUsersAccount.RowHeadersWidth = 40
        Me.dgvUsersAccount.RowTemplate.Height = 33
        Me.dgvUsersAccount.Size = New System.Drawing.Size(992, 719)
        Me.dgvUsersAccount.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(682, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 47)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!)
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(801, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(177, 47)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add New User"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cboxFilter
        '
        Me.cboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFilter.FormattingEnabled = True
        Me.cboxFilter.Location = New System.Drawing.Point(335, 16)
        Me.cboxFilter.Name = "cboxFilter"
        Me.cboxFilter.Size = New System.Drawing.Size(138, 33)
        Me.cboxFilter.TabIndex = 23
        '
        'lblManageUserAccounts
        '
        Me.lblManageUserAccounts.AutoSize = True
        Me.lblManageUserAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManageUserAccounts.ForeColor = System.Drawing.SystemColors.Window
        Me.lblManageUserAccounts.Location = New System.Drawing.Point(267, 74)
        Me.lblManageUserAccounts.Name = "lblManageUserAccounts"
        Me.lblManageUserAccounts.Size = New System.Drawing.Size(503, 53)
        Me.lblManageUserAccounts.TabIndex = 26
        Me.lblManageUserAccounts.Text = "Manage User Accounts"
        '
        'ManageAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1027, 962)
        Me.Controls.Add(Me.lblManageUserAccounts)
        Me.Controls.Add(Me.panelGDVControlPanel)
        Me.Name = "ManageAccountsForm"
        Me.Text = "ManageAccountsForm"
        Me.panelGDVControlPanel.ResumeLayout(False)
        Me.panelGDVControlPanel.PerformLayout()
        CType(Me.dgvUsersAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents panelGDVControlPanel As Panel
    Friend WithEvents cboxFilter As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvUsersAccount As DataGridView
    Friend WithEvents lblManageUserAccounts As Label
    Friend WithEvents chckBoxApprovedAsAdmin As CheckBox
End Class
