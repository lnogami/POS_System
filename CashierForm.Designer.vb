<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblQuantityLabel = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblChangeValue = New System.Windows.Forms.Label()
        Me.lblChangeLabel = New System.Windows.Forms.Label()
        Me.lblCashLabel = New System.Windows.Forms.Label()
        Me.lblTotalValue = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnClearAllOrder = New System.Windows.Forms.Button()
        Me.lblCashieringDateAndTime = New System.Windows.Forms.Label()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.invoiceQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoicePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timerDateAndTime = New System.Windows.Forms.Timer(Me.components)
        Me.dgvCashierItemView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelUserCashier = New System.Windows.Forms.Panel()
        Me.lblUserCashierLastName = New System.Windows.Forms.Label()
        Me.lblUserCashierLabel = New System.Windows.Forms.Label()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.lblSearchLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCashierItemView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelUserCashier.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.lblQuantityLabel)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.btnPlaceOrder)
        Me.Panel2.Controls.Add(Me.txtCash)
        Me.Panel2.Controls.Add(Me.lblChangeValue)
        Me.Panel2.Controls.Add(Me.lblChangeLabel)
        Me.Panel2.Controls.Add(Me.lblCashLabel)
        Me.Panel2.Controls.Add(Me.lblTotalValue)
        Me.Panel2.Controls.Add(Me.lblTotalLabel)
        Me.Panel2.Controls.Add(Me.btnDeleteOrder)
        Me.Panel2.Controls.Add(Me.btnClearAllOrder)
        Me.Panel2.Controls.Add(Me.lblCashieringDateAndTime)
        Me.Panel2.Controls.Add(Me.dgvInvoice)
        Me.Panel2.Location = New System.Drawing.Point(572, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(449, 893)
        Me.Panel2.TabIndex = 1
        '
        'lblQuantityLabel
        '
        Me.lblQuantityLabel.AutoSize = True
        Me.lblQuantityLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuantityLabel.Location = New System.Drawing.Point(184, 545)
        Me.lblQuantityLabel.Name = "lblQuantityLabel"
        Me.lblQuantityLabel.Size = New System.Drawing.Size(68, 18)
        Me.lblQuantityLabel.TabIndex = 11
        Me.lblQuantityLabel.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(179, 496)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(88, 45)
        Me.txtQuantity.TabIndex = 10
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnPlaceOrder.FlatAppearance.BorderSize = 0
        Me.btnPlaceOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnPlaceOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPlaceOrder.Location = New System.Drawing.Point(225, 788)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(188, 58)
        Me.btnPlaceOrder.TabIndex = 9
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(137, 647)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(294, 39)
        Me.txtCash.TabIndex = 5
        '
        'lblChangeValue
        '
        Me.lblChangeValue.AutoSize = True
        Me.lblChangeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeValue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblChangeValue.Location = New System.Drawing.Point(135, 702)
        Me.lblChangeValue.Name = "lblChangeValue"
        Me.lblChangeValue.Size = New System.Drawing.Size(30, 32)
        Me.lblChangeValue.TabIndex = 8
        Me.lblChangeValue.Text = "0"
        '
        'lblChangeLabel
        '
        Me.lblChangeLabel.AutoSize = True
        Me.lblChangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblChangeLabel.Location = New System.Drawing.Point(10, 702)
        Me.lblChangeLabel.Name = "lblChangeLabel"
        Me.lblChangeLabel.Size = New System.Drawing.Size(122, 32)
        Me.lblChangeLabel.TabIndex = 7
        Me.lblChangeLabel.Text = "Change:"
        '
        'lblCashLabel
        '
        Me.lblCashLabel.AutoSize = True
        Me.lblCashLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCashLabel.Location = New System.Drawing.Point(10, 650)
        Me.lblCashLabel.Name = "lblCashLabel"
        Me.lblCashLabel.Size = New System.Drawing.Size(88, 32)
        Me.lblCashLabel.TabIndex = 6
        Me.lblCashLabel.Text = "Cash:"
        '
        'lblTotalValue
        '
        Me.lblTotalValue.AutoSize = True
        Me.lblTotalValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalValue.Location = New System.Drawing.Point(133, 601)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(30, 32)
        Me.lblTotalValue.TabIndex = 5
        Me.lblTotalValue.Text = "0"
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalLabel.Location = New System.Drawing.Point(10, 601)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(86, 32)
        Me.lblTotalLabel.TabIndex = 4
        Me.lblTotalLabel.Text = "Total:"
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.BackColor = System.Drawing.Color.DarkGray
        Me.btnDeleteOrder.FlatAppearance.BorderSize = 0
        Me.btnDeleteOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnDeleteOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteOrder.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrder.Location = New System.Drawing.Point(273, 496)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(158, 45)
        Me.btnDeleteOrder.TabIndex = 3
        Me.btnDeleteOrder.Text = "Delete Order"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'btnClearAllOrder
        '
        Me.btnClearAllOrder.BackColor = System.Drawing.Color.DarkGray
        Me.btnClearAllOrder.FlatAppearance.BorderSize = 0
        Me.btnClearAllOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnClearAllOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnClearAllOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAllOrder.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAllOrder.Location = New System.Drawing.Point(15, 496)
        Me.btnClearAllOrder.Name = "btnClearAllOrder"
        Me.btnClearAllOrder.Size = New System.Drawing.Size(158, 45)
        Me.btnClearAllOrder.TabIndex = 2
        Me.btnClearAllOrder.Text = "Clear All Order"
        Me.btnClearAllOrder.UseVisualStyleBackColor = False
        '
        'lblCashieringDateAndTime
        '
        Me.lblCashieringDateAndTime.AutoSize = True
        Me.lblCashieringDateAndTime.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashieringDateAndTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCashieringDateAndTime.Location = New System.Drawing.Point(8, 18)
        Me.lblCashieringDateAndTime.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblCashieringDateAndTime.Name = "lblCashieringDateAndTime"
        Me.lblCashieringDateAndTime.Size = New System.Drawing.Size(171, 32)
        Me.lblCashieringDateAndTime.TabIndex = 1
        Me.lblCashieringDateAndTime.Text = "Date and Time"
        '
        'dgvInvoice
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInvoice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invoiceQuantity, Me.invoiceItemName, Me.invoicePrice, Me.invoiceAmount})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInvoice.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInvoice.Location = New System.Drawing.Point(15, 74)
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.RowHeadersWidth = 35
        Me.dgvInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvInvoice.RowTemplate.Height = 28
        Me.dgvInvoice.Size = New System.Drawing.Size(416, 416)
        Me.dgvInvoice.TabIndex = 0
        '
        'invoiceQuantity
        '
        Me.invoiceQuantity.HeaderText = "Qty"
        Me.invoiceQuantity.MinimumWidth = 8
        Me.invoiceQuantity.Name = "invoiceQuantity"
        Me.invoiceQuantity.Width = 35
        '
        'invoiceItemName
        '
        Me.invoiceItemName.HeaderText = "Item"
        Me.invoiceItemName.MinimumWidth = 8
        Me.invoiceItemName.Name = "invoiceItemName"
        '
        'invoicePrice
        '
        Me.invoicePrice.HeaderText = "Price"
        Me.invoicePrice.MinimumWidth = 8
        Me.invoicePrice.Name = "invoicePrice"
        Me.invoicePrice.ReadOnly = True
        Me.invoicePrice.Width = 45
        '
        'invoiceAmount
        '
        Me.invoiceAmount.HeaderText = "Amount"
        Me.invoiceAmount.MinimumWidth = 8
        Me.invoiceAmount.Name = "invoiceAmount"
        Me.invoiceAmount.ReadOnly = True
        Me.invoiceAmount.Width = 60
        '
        'timerDateAndTime
        '
        Me.timerDateAndTime.Interval = 1000
        '
        'dgvCashierItemView
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCashierItemView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCashierItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCashierItemView.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCashierItemView.Location = New System.Drawing.Point(12, 115)
        Me.dgvCashierItemView.Name = "dgvCashierItemView"
        Me.dgvCashierItemView.RowHeadersWidth = 30
        Me.dgvCashierItemView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCashierItemView.RowTemplate.Height = 28
        Me.dgvCashierItemView.Size = New System.Drawing.Size(554, 819)
        Me.dgvCashierItemView.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.panelUserCashier)
        Me.Panel1.Controls.Add(Me.txtSearchBar)
        Me.Panel1.Controls.Add(Me.lblSearchLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 68)
        Me.Panel1.TabIndex = 2
        '
        'panelUserCashier
        '
        Me.panelUserCashier.Controls.Add(Me.lblUserCashierLastName)
        Me.panelUserCashier.Controls.Add(Me.lblUserCashierLabel)
        Me.panelUserCashier.Location = New System.Drawing.Point(301, 24)
        Me.panelUserCashier.Name = "panelUserCashier"
        Me.panelUserCashier.Size = New System.Drawing.Size(257, 41)
        Me.panelUserCashier.TabIndex = 4
        '
        'lblUserCashierLastName
        '
        Me.lblUserCashierLastName.AutoSize = True
        Me.lblUserCashierLastName.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserCashierLastName.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblUserCashierLastName.Location = New System.Drawing.Point(109, 7)
        Me.lblUserCashierLastName.Name = "lblUserCashierLastName"
        Me.lblUserCashierLastName.Size = New System.Drawing.Size(139, 29)
        Me.lblUserCashierLastName.TabIndex = 3
        Me.lblUserCashierLastName.Text = "Last Name"
        '
        'lblUserCashierLabel
        '
        Me.lblUserCashierLabel.AutoSize = True
        Me.lblUserCashierLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserCashierLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblUserCashierLabel.Location = New System.Drawing.Point(10, 7)
        Me.lblUserCashierLabel.Name = "lblUserCashierLabel"
        Me.lblUserCashierLabel.Size = New System.Drawing.Size(102, 29)
        Me.lblUserCashierLabel.TabIndex = 2
        Me.lblUserCashierLabel.Text = "Cashier:"
        '
        'txtSearchBar
        '
        Me.txtSearchBar.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBar.Location = New System.Drawing.Point(109, 24)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(186, 37)
        Me.txtSearchBar.TabIndex = 1
        '
        'lblSearchLabel
        '
        Me.lblSearchLabel.AutoSize = True
        Me.lblSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSearchLabel.Location = New System.Drawing.Point(2, 26)
        Me.lblSearchLabel.Name = "lblSearchLabel"
        Me.lblSearchLabel.Size = New System.Drawing.Size(101, 30)
        Me.lblSearchLabel.TabIndex = 0
        Me.lblSearchLabel.Text = "Search:"
        '
        'CashierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1027, 962)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvCashierItemView)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "CashierForm"
        Me.Text = "Cashier"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCashierItemView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelUserCashier.ResumeLayout(False)
        Me.panelUserCashier.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvInvoice As DataGridView
    Friend WithEvents lblCashieringDateAndTime As Label
    Friend WithEvents timerDateAndTime As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents lblUserCashierLabel As Label
    Friend WithEvents lblUserCashierLastName As Label
    Friend WithEvents panelUserCashier As Panel
    Friend WithEvents btnClearAllOrder As Button
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lblChangeValue As Label
    Friend WithEvents lblChangeLabel As Label
    Friend WithEvents lblCashLabel As Label
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantityLabel As Label
    Friend WithEvents invoiceQuantity As DataGridViewTextBoxColumn
    Friend WithEvents invoiceItemName As DataGridViewTextBoxColumn
    Friend WithEvents invoicePrice As DataGridViewTextBoxColumn
    Friend WithEvents invoiceAmount As DataGridViewTextBoxColumn
    Public WithEvents dgvCashierItemView As DataGridView
End Class
