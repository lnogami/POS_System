<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpInventory_Update
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chckboxAddQuantityEnabler = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddStock = New System.Windows.Forms.TextBox()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.lblSearchLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(134, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Update Item"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.chckboxAddQuantityEnabler)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtAddStock)
        Me.Panel2.Controls.Add(Me.lblSerialNumber)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnUpdateItem)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtCost)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtItemName)
        Me.Panel2.Controls.Add(Me.lblSearchLabel)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(12, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 628)
        Me.Panel2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(26, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Notice: check 'Add Stock' to only add stock."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chckboxAddQuantityEnabler
        '
        Me.chckboxAddQuantityEnabler.AutoSize = True
        Me.chckboxAddQuantityEnabler.Location = New System.Drawing.Point(413, 420)
        Me.chckboxAddQuantityEnabler.Name = "chckboxAddQuantityEnabler"
        Me.chckboxAddQuantityEnabler.Size = New System.Drawing.Size(22, 21)
        Me.chckboxAddQuantityEnabler.TabIndex = 31
        Me.chckboxAddQuantityEnabler.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(27, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 26)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Add Stock:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAddStock
        '
        Me.txtAddStock.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtAddStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddStock.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddStock.Location = New System.Drawing.Point(179, 411)
        Me.txtAddStock.Name = "txtAddStock"
        Me.txtAddStock.ReadOnly = True
        Me.txtAddStock.Size = New System.Drawing.Size(226, 39)
        Me.txtAddStock.TabIndex = 1
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSerialNumber.Location = New System.Drawing.Point(252, 43)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(167, 30)
        Me.lblSerialNumber.TabIndex = 26
        Me.lblSerialNumber.Text = "___________"
        Me.lblSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btnUpdateItem
        '
        Me.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnUpdateItem.FlatAppearance.BorderColor = System.Drawing.Color.Olive
        Me.btnUpdateItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUpdateItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!)
        Me.btnUpdateItem.Location = New System.Drawing.Point(273, 543)
        Me.btnUpdateItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnUpdateItem.Size = New System.Drawing.Size(156, 48)
        Me.btnUpdateItem.TabIndex = 22
        Me.btnUpdateItem.Text = "Update Item"
        Me.btnUpdateItem.UseVisualStyleBackColor = False
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(30, 441)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(403, 29)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "__________________________"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(30, 368)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(403, 29)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "__________________________"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PopUpInventory_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(478, 734)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(935, 90)
        Me.Name = "PopUpInventory_Update"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PopUpInventory_Update"
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
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAddStock As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chckboxAddQuantityEnabler As CheckBox
    Friend WithEvents Label5 As Label
End Class
