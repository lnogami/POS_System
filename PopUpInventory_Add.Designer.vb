<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopUpInventory_Add
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
        Me.lblSearchLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.lblAddedBy = New System.Windows.Forms.Label()
        Me.lblDateAdded = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 723)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(111, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Add New Item"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.lblSerialNumber)
        Me.Panel2.Controls.Add(Me.lblAddedBy)
        Me.Panel2.Controls.Add(Me.lblDateAdded)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnAddItem)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtCost)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtItemName)
        Me.Panel2.Controls.Add(Me.lblSearchLabel)
        Me.Panel2.Location = New System.Drawing.Point(12, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 628)
        Me.Panel2.TabIndex = 5
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblSerialNumber.Location = New System.Drawing.Point(236, 43)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(193, 29)
        Me.lblSerialNumber.TabIndex = 27
        Me.lblSerialNumber.Text = "(auto-generated)"
        Me.lblSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddedBy
        '
        Me.lblAddedBy.AutoSize = True
        Me.lblAddedBy.BackColor = System.Drawing.Color.Transparent
        Me.lblAddedBy.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddedBy.Location = New System.Drawing.Point(174, 409)
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
        Me.lblDateAdded.Location = New System.Drawing.Point(174, 355)
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
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!)
        Me.btnAddItem.Location = New System.Drawing.Point(273, 543)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(156, 48)
        Me.btnAddItem.TabIndex = 22
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(27, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 29)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Quantity:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(179, 292)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(250, 39)
        Me.txtQuantity.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(27, 409)
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
        Me.Label8.Location = New System.Drawing.Point(27, 355)
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
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(179, 236)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(250, 39)
        Me.txtCost.TabIndex = 9
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
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(179, 180)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(250, 39)
        Me.txtPrice.TabIndex = 7
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
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(179, 124)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(250, 39)
        Me.txtItemName.TabIndex = 5
        '
        'PopUpInventory_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(478, 734)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(935, 90)
        Me.Name = "PopUpInventory_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Add Item"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblAddedBy As Label
    Friend WithEvents lblDateAdded As Label
    Friend WithEvents lblSerialNumber As Label
End Class
