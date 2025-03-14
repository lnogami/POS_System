<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelDailyHeaderContainer = New System.Windows.Forms.Panel()
        Me.panelDailyValueContainer = New System.Windows.Forms.Panel()
        Me.lblTodayValue = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.panelTimely = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblYesterdayValue = New System.Windows.Forms.Label()
        Me.lblYesterday = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.panelTotalYearlyValueContainer = New System.Windows.Forms.Panel()
        Me.lblYearlyValue = New System.Windows.Forms.Label()
        Me.lblYearly = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelTotalMonthlyValueContainer = New System.Windows.Forms.Panel()
        Me.lblMonthlyValue = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelTotalWeeklyValueContainer = New System.Windows.Forms.Panel()
        Me.lblWeeklyValue = New System.Windows.Forms.Label()
        Me.lblWeekly = New System.Windows.Forms.Label()
        Me.dgvItemsSold = New System.Windows.Forms.DataGridView()
        Me.cboxFilter = New System.Windows.Forms.ComboBox()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.panelDGVControlPanel = New System.Windows.Forms.Panel()
        Me.chckBoxDateFilter = New System.Windows.Forms.CheckBox()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.lblSearchLabel = New System.Windows.Forms.Label()
        Me.panelDateFilters = New System.Windows.Forms.Panel()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.lblTotalQuantity = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.panelTotality = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.panelTotalItemsValueContainer = New System.Windows.Forms.Panel()
        Me.lblTotalItemsValue = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.lblTotalGains = New System.Windows.Forms.Label()
        Me.panelTotalGainsValueContainer = New System.Windows.Forms.Panel()
        Me.lblTotalGainsValue = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.panelTotalSoldValueContainer = New System.Windows.Forms.Panel()
        Me.lblTotalAmountValue = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.panelQuantityItemsValueContainer = New System.Windows.Forms.Panel()
        Me.lblTotalQuantityValue = New System.Windows.Forms.Label()
        Me.panelDailyHeaderContainer.SuspendLayout()
        Me.panelDailyValueContainer.SuspendLayout()
        Me.panelTimely.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.panelTotalYearlyValueContainer.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panelTotalMonthlyValueContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelTotalWeeklyValueContainer.SuspendLayout()
        CType(Me.dgvItemsSold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDGVControlPanel.SuspendLayout()
        Me.panelTotality.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.panelTotalItemsValueContainer.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.panelTotalGainsValueContainer.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.panelTotalSoldValueContainer.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.panelQuantityItemsValueContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelDailyHeaderContainer
        '
        Me.panelDailyHeaderContainer.BackColor = System.Drawing.Color.Gray
        Me.panelDailyHeaderContainer.Controls.Add(Me.panelDailyValueContainer)
        Me.panelDailyHeaderContainer.Controls.Add(Me.lblToday)
        Me.panelDailyHeaderContainer.Location = New System.Drawing.Point(11, 4)
        Me.panelDailyHeaderContainer.Name = "panelDailyHeaderContainer"
        Me.panelDailyHeaderContainer.Size = New System.Drawing.Size(175, 118)
        Me.panelDailyHeaderContainer.TabIndex = 12
        '
        'panelDailyValueContainer
        '
        Me.panelDailyValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelDailyValueContainer.Controls.Add(Me.lblTodayValue)
        Me.panelDailyValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelDailyValueContainer.Location = New System.Drawing.Point(0, 36)
        Me.panelDailyValueContainer.Name = "panelDailyValueContainer"
        Me.panelDailyValueContainer.Size = New System.Drawing.Size(175, 82)
        Me.panelDailyValueContainer.TabIndex = 1
        '
        'lblTodayValue
        '
        Me.lblTodayValue.AutoSize = True
        Me.lblTodayValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTodayValue.Location = New System.Drawing.Point(18, 28)
        Me.lblTodayValue.Name = "lblTodayValue"
        Me.lblTodayValue.Size = New System.Drawing.Size(154, 26)
        Me.lblTodayValue.TabIndex = 4
        Me.lblTodayValue.Text = "Today's sales"
        '
        'lblToday
        '
        Me.lblToday.AutoSize = True
        Me.lblToday.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblToday.Location = New System.Drawing.Point(3, 5)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(79, 28)
        Me.lblToday.TabIndex = 0
        Me.lblToday.Text = "Today"
        '
        'panelTimely
        '
        Me.panelTimely.Controls.Add(Me.Panel1)
        Me.panelTimely.Controls.Add(Me.panelDailyHeaderContainer)
        Me.panelTimely.Controls.Add(Me.Panel6)
        Me.panelTimely.Controls.Add(Me.Panel4)
        Me.panelTimely.Controls.Add(Me.Panel2)
        Me.panelTimely.Location = New System.Drawing.Point(824, 76)
        Me.panelTimely.Name = "panelTimely"
        Me.panelTimely.Size = New System.Drawing.Size(200, 821)
        Me.panelTimely.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lblYesterday)
        Me.Panel1.Location = New System.Drawing.Point(11, 136)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 118)
        Me.Panel1.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.lblYesterdayValue)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(175, 82)
        Me.Panel3.TabIndex = 1
        '
        'lblYesterdayValue
        '
        Me.lblYesterdayValue.AutoSize = True
        Me.lblYesterdayValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYesterdayValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYesterdayValue.Location = New System.Drawing.Point(18, 28)
        Me.lblYesterdayValue.Name = "lblYesterdayValue"
        Me.lblYesterdayValue.Size = New System.Drawing.Size(130, 26)
        Me.lblYesterdayValue.TabIndex = 4
        Me.lblYesterdayValue.Text = "Yeseterday"
        '
        'lblYesterday
        '
        Me.lblYesterday.AutoSize = True
        Me.lblYesterday.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYesterday.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYesterday.Location = New System.Drawing.Point(3, 5)
        Me.lblYesterday.Name = "lblYesterday"
        Me.lblYesterday.Size = New System.Drawing.Size(121, 28)
        Me.lblYesterday.TabIndex = 0
        Me.lblYesterday.Text = "Yesterday"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Controls.Add(Me.panelTotalYearlyValueContainer)
        Me.Panel6.Controls.Add(Me.lblYearly)
        Me.Panel6.Location = New System.Drawing.Point(11, 534)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(175, 118)
        Me.Panel6.TabIndex = 13
        '
        'panelTotalYearlyValueContainer
        '
        Me.panelTotalYearlyValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelTotalYearlyValueContainer.Controls.Add(Me.lblYearlyValue)
        Me.panelTotalYearlyValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelTotalYearlyValueContainer.Location = New System.Drawing.Point(0, 36)
        Me.panelTotalYearlyValueContainer.Name = "panelTotalYearlyValueContainer"
        Me.panelTotalYearlyValueContainer.Size = New System.Drawing.Size(175, 82)
        Me.panelTotalYearlyValueContainer.TabIndex = 1
        '
        'lblYearlyValue
        '
        Me.lblYearlyValue.AutoSize = True
        Me.lblYearlyValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearlyValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblYearlyValue.Location = New System.Drawing.Point(18, 28)
        Me.lblYearlyValue.Name = "lblYearlyValue"
        Me.lblYearlyValue.Size = New System.Drawing.Size(139, 26)
        Me.lblYearlyValue.TabIndex = 4
        Me.lblYearlyValue.Text = "Yearly sales"
        '
        'lblYearly
        '
        Me.lblYearly.AutoSize = True
        Me.lblYearly.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearly.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYearly.Location = New System.Drawing.Point(3, 6)
        Me.lblYearly.Name = "lblYearly"
        Me.lblYearly.Size = New System.Drawing.Size(80, 28)
        Me.lblYearly.TabIndex = 0
        Me.lblYearly.Text = "Yearly"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Controls.Add(Me.panelTotalMonthlyValueContainer)
        Me.Panel4.Controls.Add(Me.lblMonthly)
        Me.Panel4.Location = New System.Drawing.Point(11, 401)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(175, 118)
        Me.Panel4.TabIndex = 13
        '
        'panelTotalMonthlyValueContainer
        '
        Me.panelTotalMonthlyValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelTotalMonthlyValueContainer.Controls.Add(Me.lblMonthlyValue)
        Me.panelTotalMonthlyValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelTotalMonthlyValueContainer.Location = New System.Drawing.Point(0, 36)
        Me.panelTotalMonthlyValueContainer.Name = "panelTotalMonthlyValueContainer"
        Me.panelTotalMonthlyValueContainer.Size = New System.Drawing.Size(175, 82)
        Me.panelTotalMonthlyValueContainer.TabIndex = 1
        '
        'lblMonthlyValue
        '
        Me.lblMonthlyValue.AutoSize = True
        Me.lblMonthlyValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMonthlyValue.Location = New System.Drawing.Point(18, 28)
        Me.lblMonthlyValue.Name = "lblMonthlyValue"
        Me.lblMonthlyValue.Size = New System.Drawing.Size(156, 26)
        Me.lblMonthlyValue.TabIndex = 4
        Me.lblMonthlyValue.Text = "Monthly sales"
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthly.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMonthly.Location = New System.Drawing.Point(3, 6)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(100, 28)
        Me.lblMonthly.TabIndex = 0
        Me.lblMonthly.Text = "Monthly"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.panelTotalWeeklyValueContainer)
        Me.Panel2.Controls.Add(Me.lblWeekly)
        Me.Panel2.Location = New System.Drawing.Point(11, 268)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 118)
        Me.Panel2.TabIndex = 13
        '
        'panelTotalWeeklyValueContainer
        '
        Me.panelTotalWeeklyValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelTotalWeeklyValueContainer.Controls.Add(Me.lblWeeklyValue)
        Me.panelTotalWeeklyValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelTotalWeeklyValueContainer.Location = New System.Drawing.Point(0, 36)
        Me.panelTotalWeeklyValueContainer.Name = "panelTotalWeeklyValueContainer"
        Me.panelTotalWeeklyValueContainer.Size = New System.Drawing.Size(175, 82)
        Me.panelTotalWeeklyValueContainer.TabIndex = 1
        '
        'lblWeeklyValue
        '
        Me.lblWeeklyValue.AutoSize = True
        Me.lblWeeklyValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklyValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWeeklyValue.Location = New System.Drawing.Point(18, 28)
        Me.lblWeeklyValue.Name = "lblWeeklyValue"
        Me.lblWeeklyValue.Size = New System.Drawing.Size(150, 26)
        Me.lblWeeklyValue.TabIndex = 4
        Me.lblWeeklyValue.Text = "Weekly sales"
        '
        'lblWeekly
        '
        Me.lblWeekly.AutoSize = True
        Me.lblWeekly.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeekly.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWeekly.Location = New System.Drawing.Point(3, 5)
        Me.lblWeekly.Name = "lblWeekly"
        Me.lblWeekly.Size = New System.Drawing.Size(92, 28)
        Me.lblWeekly.TabIndex = 0
        Me.lblWeekly.Text = "Weekly"
        '
        'dgvItemsSold
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemsSold.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemsSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemsSold.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItemsSold.Location = New System.Drawing.Point(33, 149)
        Me.dgvItemsSold.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvItemsSold.Name = "dgvItemsSold"
        Me.dgvItemsSold.RowHeadersWidth = 35
        Me.dgvItemsSold.RowTemplate.Height = 28
        Me.dgvItemsSold.RowTemplate.ReadOnly = True
        Me.dgvItemsSold.Size = New System.Drawing.Size(785, 778)
        Me.dgvItemsSold.TabIndex = 14
        '
        'cboxFilter
        '
        Me.cboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFilter.FormattingEnabled = True
        Me.cboxFilter.Location = New System.Drawing.Point(835, 33)
        Me.cboxFilter.Name = "cboxFilter"
        Me.cboxFilter.Size = New System.Drawing.Size(175, 33)
        Me.cboxFilter.TabIndex = 15
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtpFromDate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dtpFromDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(373, 69)
        Me.dtpFromDate.MinDate = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(173, 32)
        Me.dtpFromDate.TabIndex = 16
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(596, 69)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(173, 32)
        Me.dtpToDate.TabIndex = 17
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblFrom.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFrom.Location = New System.Drawing.Point(305, 77)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(64, 26)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.BackColor = System.Drawing.Color.Transparent
        Me.lblTo.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTo.Location = New System.Drawing.Point(557, 78)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(36, 26)
        Me.lblTo.TabIndex = 18
        Me.lblTo.Text = "To"
        '
        'panelDGVControlPanel
        '
        Me.panelDGVControlPanel.BackColor = System.Drawing.Color.DarkGray
        Me.panelDGVControlPanel.Controls.Add(Me.chckBoxDateFilter)
        Me.panelDGVControlPanel.Controls.Add(Me.txtSearchBar)
        Me.panelDGVControlPanel.Controls.Add(Me.lblSearchLabel)
        Me.panelDGVControlPanel.Controls.Add(Me.lblTo)
        Me.panelDGVControlPanel.Controls.Add(Me.lblFrom)
        Me.panelDGVControlPanel.Controls.Add(Me.dtpFromDate)
        Me.panelDGVControlPanel.Controls.Add(Me.dtpToDate)
        Me.panelDGVControlPanel.Controls.Add(Me.panelDateFilters)
        Me.panelDGVControlPanel.Location = New System.Drawing.Point(33, 33)
        Me.panelDGVControlPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.panelDGVControlPanel.Name = "panelDGVControlPanel"
        Me.panelDGVControlPanel.Size = New System.Drawing.Size(785, 116)
        Me.panelDGVControlPanel.TabIndex = 19
        '
        'chckBoxDateFilter
        '
        Me.chckBoxDateFilter.AutoSize = True
        Me.chckBoxDateFilter.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckBoxDateFilter.Location = New System.Drawing.Point(96, 72)
        Me.chckBoxDateFilter.Name = "chckBoxDateFilter"
        Me.chckBoxDateFilter.Size = New System.Drawing.Size(154, 32)
        Me.chckBoxDateFilter.TabIndex = 21
        Me.chckBoxDateFilter.Text = "Filter Date"
        Me.chckBoxDateFilter.UseVisualStyleBackColor = True
        '
        'txtSearchBar
        '
        Me.txtSearchBar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBar.Location = New System.Drawing.Point(96, 14)
        Me.txtSearchBar.Multiline = True
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(673, 38)
        Me.txtSearchBar.TabIndex = 20
        '
        'lblSearchLabel
        '
        Me.lblSearchLabel.AutoSize = True
        Me.lblSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.lblSearchLabel.Location = New System.Drawing.Point(3, 23)
        Me.lblSearchLabel.Name = "lblSearchLabel"
        Me.lblSearchLabel.Size = New System.Drawing.Size(95, 29)
        Me.lblSearchLabel.TabIndex = 19
        Me.lblSearchLabel.Text = "Search:"
        '
        'panelDateFilters
        '
        Me.panelDateFilters.Location = New System.Drawing.Point(301, 59)
        Me.panelDateFilters.Name = "panelDateFilters"
        Me.panelDateFilters.Size = New System.Drawing.Size(468, 55)
        Me.panelDateFilters.TabIndex = 22
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalItems.Location = New System.Drawing.Point(3, 5)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(139, 28)
        Me.lblTotalItems.TabIndex = 2
        Me.lblTotalItems.Text = "Total Items"
        '
        'lblTotalQuantity
        '
        Me.lblTotalQuantity.AutoSize = True
        Me.lblTotalQuantity.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalQuantity.Location = New System.Drawing.Point(2, 3)
        Me.lblTotalQuantity.Name = "lblTotalQuantity"
        Me.lblTotalQuantity.Size = New System.Drawing.Size(170, 28)
        Me.lblTotalQuantity.TabIndex = 3
        Me.lblTotalQuantity.Text = "Total Quantity"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalAmount.Location = New System.Drawing.Point(6, 5)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(161, 28)
        Me.lblTotalAmount.TabIndex = 3
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'panelTotality
        '
        Me.panelTotality.Controls.Add(Me.Panel14)
        Me.panelTotality.Controls.Add(Me.Panel16)
        Me.panelTotality.Controls.Add(Me.Panel20)
        Me.panelTotality.Controls.Add(Me.Panel24)
        Me.panelTotality.Location = New System.Drawing.Point(824, 76)
        Me.panelTotality.Name = "panelTotality"
        Me.panelTotality.Size = New System.Drawing.Size(200, 851)
        Me.panelTotality.TabIndex = 16
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Controls.Add(Me.panelTotalItemsValueContainer)
        Me.Panel14.Controls.Add(Me.lblTotalItems)
        Me.Panel14.Location = New System.Drawing.Point(11, 4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(175, 118)
        Me.Panel14.TabIndex = 12
        '
        'panelTotalItemsValueContainer
        '
        Me.panelTotalItemsValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelTotalItemsValueContainer.Controls.Add(Me.lblTotalItemsValue)
        Me.panelTotalItemsValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelTotalItemsValueContainer.Location = New System.Drawing.Point(0, 36)
        Me.panelTotalItemsValueContainer.Name = "panelTotalItemsValueContainer"
        Me.panelTotalItemsValueContainer.Size = New System.Drawing.Size(175, 82)
        Me.panelTotalItemsValueContainer.TabIndex = 1
        '
        'lblTotalItemsValue
        '
        Me.lblTotalItemsValue.AutoSize = True
        Me.lblTotalItemsValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItemsValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalItemsValue.Location = New System.Drawing.Point(16, 24)
        Me.lblTotalItemsValue.Name = "lblTotalItemsValue"
        Me.lblTotalItemsValue.Size = New System.Drawing.Size(139, 28)
        Me.lblTotalItemsValue.TabIndex = 3
        Me.lblTotalItemsValue.Text = "Total Items"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Gray
        Me.Panel16.Controls.Add(Me.lblTotalGains)
        Me.Panel16.Controls.Add(Me.panelTotalGainsValueContainer)
        Me.Panel16.Location = New System.Drawing.Point(11, 403)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(175, 118)
        Me.Panel16.TabIndex = 15
        '
        'lblTotalGains
        '
        Me.lblTotalGains.AutoSize = True
        Me.lblTotalGains.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGains.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalGains.Location = New System.Drawing.Point(6, 5)
        Me.lblTotalGains.Name = "lblTotalGains"
        Me.lblTotalGains.Size = New System.Drawing.Size(136, 28)
        Me.lblTotalGains.TabIndex = 4
        Me.lblTotalGains.Text = "Total Gains"
        '
        'panelTotalGainsValueContainer
        '
        Me.panelTotalGainsValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelTotalGainsValueContainer.Controls.Add(Me.lblTotalGainsValue)
        Me.panelTotalGainsValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelTotalGainsValueContainer.Location = New System.Drawing.Point(0, 36)
        Me.panelTotalGainsValueContainer.Name = "panelTotalGainsValueContainer"
        Me.panelTotalGainsValueContainer.Size = New System.Drawing.Size(175, 82)
        Me.panelTotalGainsValueContainer.TabIndex = 1
        '
        'lblTotalGainsValue
        '
        Me.lblTotalGainsValue.AutoSize = True
        Me.lblTotalGainsValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGainsValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalGainsValue.Location = New System.Drawing.Point(18, 28)
        Me.lblTotalGainsValue.Name = "lblTotalGainsValue"
        Me.lblTotalGainsValue.Size = New System.Drawing.Size(136, 28)
        Me.lblTotalGainsValue.TabIndex = 4
        Me.lblTotalGainsValue.Text = "Total Gains"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Gray
        Me.Panel20.Controls.Add(Me.panelTotalSoldValueContainer)
        Me.Panel20.Controls.Add(Me.lblTotalAmount)
        Me.Panel20.Location = New System.Drawing.Point(11, 268)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(175, 118)
        Me.Panel20.TabIndex = 13
        '
        'panelTotalSoldValueContainer
        '
        Me.panelTotalSoldValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelTotalSoldValueContainer.Controls.Add(Me.lblTotalAmountValue)
        Me.panelTotalSoldValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelTotalSoldValueContainer.Location = New System.Drawing.Point(0, 36)
        Me.panelTotalSoldValueContainer.Name = "panelTotalSoldValueContainer"
        Me.panelTotalSoldValueContainer.Size = New System.Drawing.Size(175, 82)
        Me.panelTotalSoldValueContainer.TabIndex = 1
        '
        'lblTotalAmountValue
        '
        Me.lblTotalAmountValue.AutoSize = True
        Me.lblTotalAmountValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalAmountValue.Location = New System.Drawing.Point(18, 28)
        Me.lblTotalAmountValue.Name = "lblTotalAmountValue"
        Me.lblTotalAmountValue.Size = New System.Drawing.Size(153, 26)
        Me.lblTotalAmountValue.TabIndex = 4
        Me.lblTotalAmountValue.Text = "Total Amount"
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Gray
        Me.Panel24.Controls.Add(Me.panelQuantityItemsValueContainer)
        Me.Panel24.Controls.Add(Me.lblTotalQuantity)
        Me.Panel24.Location = New System.Drawing.Point(11, 136)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(175, 118)
        Me.Panel24.TabIndex = 13
        '
        'panelQuantityItemsValueContainer
        '
        Me.panelQuantityItemsValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelQuantityItemsValueContainer.Controls.Add(Me.lblTotalQuantityValue)
        Me.panelQuantityItemsValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelQuantityItemsValueContainer.Location = New System.Drawing.Point(0, 36)
        Me.panelQuantityItemsValueContainer.Name = "panelQuantityItemsValueContainer"
        Me.panelQuantityItemsValueContainer.Size = New System.Drawing.Size(175, 82)
        Me.panelQuantityItemsValueContainer.TabIndex = 1
        '
        'lblTotalQuantityValue
        '
        Me.lblTotalQuantityValue.AutoSize = True
        Me.lblTotalQuantityValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuantityValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalQuantityValue.Location = New System.Drawing.Point(16, 25)
        Me.lblTotalQuantityValue.Name = "lblTotalQuantityValue"
        Me.lblTotalQuantityValue.Size = New System.Drawing.Size(114, 28)
        Me.lblTotalQuantityValue.TabIndex = 4
        Me.lblTotalQuantityValue.Text = "Total Qty"
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1027, 962)
        Me.Controls.Add(Me.panelTotality)
        Me.Controls.Add(Me.panelTimely)
        Me.Controls.Add(Me.cboxFilter)
        Me.Controls.Add(Me.dgvItemsSold)
        Me.Controls.Add(Me.panelDGVControlPanel)
        Me.Name = "SalesForm"
        Me.Text = "SalesForm"
        Me.panelDailyHeaderContainer.ResumeLayout(False)
        Me.panelDailyHeaderContainer.PerformLayout()
        Me.panelDailyValueContainer.ResumeLayout(False)
        Me.panelDailyValueContainer.PerformLayout()
        Me.panelTimely.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panelTotalYearlyValueContainer.ResumeLayout(False)
        Me.panelTotalYearlyValueContainer.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.panelTotalMonthlyValueContainer.ResumeLayout(False)
        Me.panelTotalMonthlyValueContainer.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelTotalWeeklyValueContainer.ResumeLayout(False)
        Me.panelTotalWeeklyValueContainer.PerformLayout()
        CType(Me.dgvItemsSold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDGVControlPanel.ResumeLayout(False)
        Me.panelDGVControlPanel.PerformLayout()
        Me.panelTotality.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.panelTotalItemsValueContainer.ResumeLayout(False)
        Me.panelTotalItemsValueContainer.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.panelTotalGainsValueContainer.ResumeLayout(False)
        Me.panelTotalGainsValueContainer.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.panelTotalSoldValueContainer.ResumeLayout(False)
        Me.panelTotalSoldValueContainer.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.panelQuantityItemsValueContainer.ResumeLayout(False)
        Me.panelQuantityItemsValueContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelDailyHeaderContainer As Panel
    Friend WithEvents panelDailyValueContainer As Panel
    Friend WithEvents lblToday As Label
    Friend WithEvents panelTimely As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents panelTotalYearlyValueContainer As Panel
    Friend WithEvents lblYearly As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelTotalMonthlyValueContainer As Panel
    Friend WithEvents lblMonthly As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelTotalWeeklyValueContainer As Panel
    Friend WithEvents lblWeekly As Label
    Friend WithEvents dgvItemsSold As DataGridView
    Friend WithEvents cboxFilter As ComboBox
    Friend WithEvents dtpFromDate As DateTimePicker
    Friend WithEvents dtpToDate As DateTimePicker
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents panelDGVControlPanel As Panel
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents lblTotalQuantity As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents panelTotality As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents panelTotalItemsValueContainer As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents panelTotalGainsValueContainer As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents panelTotalSoldValueContainer As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents panelQuantityItemsValueContainer As Panel
    Friend WithEvents lblTotalGains As Label
    Friend WithEvents chckBoxDateFilter As CheckBox
    Friend WithEvents panelDateFilters As Panel
    Friend WithEvents lblTotalItemsValue As Label
    Friend WithEvents lblTotalGainsValue As Label
    Friend WithEvents lblTotalAmountValue As Label
    Friend WithEvents lblTotalQuantityValue As Label
    Friend WithEvents lblTodayValue As Label
    Friend WithEvents lblYearlyValue As Label
    Friend WithEvents lblMonthlyValue As Label
    Friend WithEvents lblWeeklyValue As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblYesterdayValue As Label
    Friend WithEvents lblYesterday As Label
End Class
