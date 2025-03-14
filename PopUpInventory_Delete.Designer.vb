<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopUpInventory_Delete
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSold = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.lblAddedBy = New System.Windows.Forms.Label()
        Me.lblDateAdded = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSearchLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 723)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(111, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Delete Item?"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.lblSold)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lblItemName)
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Controls.Add(Me.lblCost)
        Me.Panel2.Controls.Add(Me.lblQuantity)
        Me.Panel2.Controls.Add(Me.lblSerialNumber)
        Me.Panel2.Controls.Add(Me.lblAddedBy)
        Me.Panel2.Controls.Add(Me.lblDateAdded)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnAddItem)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblSearchLabel)
        Me.Panel2.Location = New System.Drawing.Point(12, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 628)
        Me.Panel2.TabIndex = 5
        '
        'lblSold
        '
        Me.lblSold.AutoSize = True
        Me.lblSold.BackColor = System.Drawing.Color.Transparent
        Me.lblSold.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSold.Location = New System.Drawing.Point(177, 299)
        Me.lblSold.Name = "lblSold"
        Me.lblSold.Size = New System.Drawing.Size(208, 29)
        Me.lblSold.TabIndex = 32
        Me.lblSold.Text = "_____________"
        Me.lblSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(27, 300)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 29)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Sold:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblItemName.Location = New System.Drawing.Point(177, 128)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(208, 29)
        Me.lblItemName.TabIndex = 30
        Me.lblItemName.Text = "_____________"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(177, 184)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(208, 29)
        Me.lblPrice.TabIndex = 29
        Me.lblPrice.Text = "_____________"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.BackColor = System.Drawing.Color.Transparent
        Me.lblCost.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCost.Location = New System.Drawing.Point(177, 240)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(208, 29)
        Me.lblCost.TabIndex = 28
        Me.lblCost.Text = "_____________"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblQuantity.Location = New System.Drawing.Point(177, 365)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(208, 29)
        Me.lblQuantity.TabIndex = 27
        Me.lblQuantity.Text = "_____________"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSerialNumber.Location = New System.Drawing.Point(252, 43)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(182, 29)
        Me.lblSerialNumber.TabIndex = 26
        Me.lblSerialNumber.Text = "_____________"
        Me.lblSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddedBy
        '
        Me.lblAddedBy.AutoSize = True
        Me.lblAddedBy.BackColor = System.Drawing.Color.Transparent
        Me.lblAddedBy.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddedBy.Location = New System.Drawing.Point(177, 477)
        Me.lblAddedBy.Name = "lblAddedBy"
        Me.lblAddedBy.Size = New System.Drawing.Size(208, 29)
        Me.lblAddedBy.TabIndex = 25
        Me.lblAddedBy.Text = "_____________"
        Me.lblAddedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateAdded
        '
        Me.lblDateAdded.AutoSize = True
        Me.lblDateAdded.BackColor = System.Drawing.Color.Transparent
        Me.lblDateAdded.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAdded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDateAdded.Location = New System.Drawing.Point(177, 423)
        Me.lblDateAdded.Name = "lblDateAdded"
        Me.lblDateAdded.Size = New System.Drawing.Size(208, 29)
        Me.lblDateAdded.TabIndex = 24
        Me.lblDateAdded.Text = "_____________"
        Me.lblDateAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!)
        Me.btnCancel.Location = New System.Drawing.Point(30, 543)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 48)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!)
        Me.btnAddItem.Location = New System.Drawing.Point(273, 543)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(156, 48)
        Me.btnAddItem.TabIndex = 22
        Me.btnAddItem.Text = "Delete"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(27, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 29)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Quantity:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(25, 477)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Added by:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(27, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 29)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Date Added:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cost:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(25, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(27, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchLabel
        '
        Me.lblSearchLabel.AutoSize = True
        Me.lblSearchLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchLabel.ForeColor = System.Drawing.Color.White
        Me.lblSearchLabel.Location = New System.Drawing.Point(26, 43)
        Me.lblSearchLabel.Name = "lblSearchLabel"
        Me.lblSearchLabel.Size = New System.Drawing.Size(220, 29)
        Me.lblSearchLabel.TabIndex = 2
        Me.lblSearchLabel.Text = "ID (Serial Number):"
        Me.lblSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PopUpInventory_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(478, 734)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(935, 90)
        Me.Name = "PopUpInventory_Delete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents lblAddedBy As Label
    Friend WithEvents lblDateAdded As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents lblSold As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblQuantity As Label
End Class
