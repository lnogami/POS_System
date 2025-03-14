<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Me.cboxCategoryToDisplay = New System.Windows.Forms.ComboBox()
        Me.panelDisplayDropDown = New System.Windows.Forms.Panel()
        Me.panelDailyHeaderContainer = New System.Windows.Forms.Panel()
        Me.panelDailyValueContainer = New System.Windows.Forms.Panel()
        Me.lblYesterdayValue = New System.Windows.Forms.Label()
        Me.lblTodayValue = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.lblYesterday = New System.Windows.Forms.Label()
        Me.lblDaily = New System.Windows.Forms.Label()
        Me.panelMonthlyHeaderContainer = New System.Windows.Forms.Panel()
        Me.lblThisMonth = New System.Windows.Forms.Label()
        Me.panelMonthlyValueContainer = New System.Windows.Forms.Panel()
        Me.lblMonthlyValue = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.panelYearlyHeaderContainer = New System.Windows.Forms.Panel()
        Me.lblThisYear = New System.Windows.Forms.Label()
        Me.panelYearlyValueContainer = New System.Windows.Forms.Panel()
        Me.lblYearlyValue = New System.Windows.Forms.Label()
        Me.lblYearly = New System.Windows.Forms.Label()
        Me.panelInnerDateTimeContainer = New System.Windows.Forms.Panel()
        Me.lblDateAndTime = New System.Windows.Forms.Label()
        Me.timerDateAndTime = New System.Windows.Forms.Timer(Me.components)
        Me.panelOuterDateTimeContainer = New System.Windows.Forms.Panel()
        Me.dgvSold = New System.Windows.Forms.DataGridView()
        Me.panelDGV = New System.Windows.Forms.Panel()
        Me.dgvStocks = New System.Windows.Forms.DataGridView()
        Me.picboxJustAWrenchImage = New System.Windows.Forms.PictureBox()
        Me.panelDisplayDropDown.SuspendLayout()
        Me.panelDailyHeaderContainer.SuspendLayout()
        Me.panelDailyValueContainer.SuspendLayout()
        Me.panelMonthlyHeaderContainer.SuspendLayout()
        Me.panelMonthlyValueContainer.SuspendLayout()
        Me.panelYearlyHeaderContainer.SuspendLayout()
        Me.panelYearlyValueContainer.SuspendLayout()
        Me.panelInnerDateTimeContainer.SuspendLayout()
        Me.panelOuterDateTimeContainer.SuspendLayout()
        CType(Me.dgvSold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDGV.SuspendLayout()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxJustAWrenchImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxCategoryToDisplay
        '
        Me.cboxCategoryToDisplay.DropDownHeight = 90
        Me.cboxCategoryToDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCategoryToDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCategoryToDisplay.FormattingEnabled = True
        Me.cboxCategoryToDisplay.IntegralHeight = False
        Me.cboxCategoryToDisplay.Location = New System.Drawing.Point(5, 5)
        Me.cboxCategoryToDisplay.Margin = New System.Windows.Forms.Padding(5)
        Me.cboxCategoryToDisplay.Name = "cboxCategoryToDisplay"
        Me.cboxCategoryToDisplay.Size = New System.Drawing.Size(517, 37)
        Me.cboxCategoryToDisplay.TabIndex = 7
        '
        'panelDisplayDropDown
        '
        Me.panelDisplayDropDown.BackColor = System.Drawing.Color.Gray
        Me.panelDisplayDropDown.Controls.Add(Me.cboxCategoryToDisplay)
        Me.panelDisplayDropDown.Location = New System.Drawing.Point(39, 410)
        Me.panelDisplayDropDown.Name = "panelDisplayDropDown"
        Me.panelDisplayDropDown.Size = New System.Drawing.Size(527, 53)
        Me.panelDisplayDropDown.TabIndex = 9
        '
        'panelDailyHeaderContainer
        '
        Me.panelDailyHeaderContainer.BackColor = System.Drawing.Color.Gray
        Me.panelDailyHeaderContainer.Controls.Add(Me.panelDailyValueContainer)
        Me.panelDailyHeaderContainer.Controls.Add(Me.lblDaily)
        Me.panelDailyHeaderContainer.Location = New System.Drawing.Point(39, 167)
        Me.panelDailyHeaderContainer.Name = "panelDailyHeaderContainer"
        Me.panelDailyHeaderContainer.Size = New System.Drawing.Size(288, 190)
        Me.panelDailyHeaderContainer.TabIndex = 11
        '
        'panelDailyValueContainer
        '
        Me.panelDailyValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelDailyValueContainer.Controls.Add(Me.lblYesterdayValue)
        Me.panelDailyValueContainer.Controls.Add(Me.lblTodayValue)
        Me.panelDailyValueContainer.Controls.Add(Me.lblToday)
        Me.panelDailyValueContainer.Controls.Add(Me.lblYesterday)
        Me.panelDailyValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelDailyValueContainer.Location = New System.Drawing.Point(0, 46)
        Me.panelDailyValueContainer.Name = "panelDailyValueContainer"
        Me.panelDailyValueContainer.Size = New System.Drawing.Size(288, 144)
        Me.panelDailyValueContainer.TabIndex = 1
        '
        'lblYesterdayValue
        '
        Me.lblYesterdayValue.AutoSize = True
        Me.lblYesterdayValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYesterdayValue.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblYesterdayValue.Location = New System.Drawing.Point(91, 3)
        Me.lblYesterdayValue.Name = "lblYesterdayValue"
        Me.lblYesterdayValue.Size = New System.Drawing.Size(32, 33)
        Me.lblYesterdayValue.TabIndex = 0
        Me.lblYesterdayValue.Text = "0"
        '
        'lblTodayValue
        '
        Me.lblTodayValue.AutoSize = True
        Me.lblTodayValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayValue.Location = New System.Drawing.Point(71, 52)
        Me.lblTodayValue.Name = "lblTodayValue"
        Me.lblTodayValue.Size = New System.Drawing.Size(43, 45)
        Me.lblTodayValue.TabIndex = 3
        Me.lblTodayValue.Text = "0"
        '
        'lblToday
        '
        Me.lblToday.AutoSize = True
        Me.lblToday.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.Location = New System.Drawing.Point(7, 62)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(65, 23)
        Me.lblToday.TabIndex = 2
        Me.lblToday.Text = "Today"
        '
        'lblYesterday
        '
        Me.lblYesterday.AutoSize = True
        Me.lblYesterday.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYesterday.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblYesterday.Location = New System.Drawing.Point(7, 9)
        Me.lblYesterday.Name = "lblYesterday"
        Me.lblYesterday.Size = New System.Drawing.Size(84, 21)
        Me.lblYesterday.TabIndex = 1
        Me.lblYesterday.Text = "Yesterday"
        '
        'lblDaily
        '
        Me.lblDaily.AutoSize = True
        Me.lblDaily.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaily.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDaily.Location = New System.Drawing.Point(6, 4)
        Me.lblDaily.Name = "lblDaily"
        Me.lblDaily.Size = New System.Drawing.Size(77, 29)
        Me.lblDaily.TabIndex = 0
        Me.lblDaily.Text = "Daily"
        '
        'panelMonthlyHeaderContainer
        '
        Me.panelMonthlyHeaderContainer.BackColor = System.Drawing.Color.Gray
        Me.panelMonthlyHeaderContainer.Controls.Add(Me.lblThisMonth)
        Me.panelMonthlyHeaderContainer.Controls.Add(Me.panelMonthlyValueContainer)
        Me.panelMonthlyHeaderContainer.Controls.Add(Me.lblMonthly)
        Me.panelMonthlyHeaderContainer.Location = New System.Drawing.Point(371, 167)
        Me.panelMonthlyHeaderContainer.Name = "panelMonthlyHeaderContainer"
        Me.panelMonthlyHeaderContainer.Size = New System.Drawing.Size(288, 190)
        Me.panelMonthlyHeaderContainer.TabIndex = 11
        '
        'lblThisMonth
        '
        Me.lblThisMonth.AutoSize = True
        Me.lblThisMonth.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThisMonth.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblThisMonth.Location = New System.Drawing.Point(124, 6)
        Me.lblThisMonth.Name = "lblThisMonth"
        Me.lblThisMonth.Size = New System.Drawing.Size(35, 29)
        Me.lblThisMonth.TabIndex = 3
        Me.lblThisMonth.Text = "()"
        Me.lblThisMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelMonthlyValueContainer
        '
        Me.panelMonthlyValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelMonthlyValueContainer.Controls.Add(Me.lblMonthlyValue)
        Me.panelMonthlyValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelMonthlyValueContainer.Location = New System.Drawing.Point(0, 46)
        Me.panelMonthlyValueContainer.Name = "panelMonthlyValueContainer"
        Me.panelMonthlyValueContainer.Size = New System.Drawing.Size(288, 144)
        Me.panelMonthlyValueContainer.TabIndex = 2
        '
        'lblMonthlyValue
        '
        Me.lblMonthlyValue.AutoSize = True
        Me.lblMonthlyValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyValue.Location = New System.Drawing.Point(14, 52)
        Me.lblMonthlyValue.Name = "lblMonthlyValue"
        Me.lblMonthlyValue.Size = New System.Drawing.Size(43, 45)
        Me.lblMonthlyValue.TabIndex = 1
        Me.lblMonthlyValue.Text = "0"
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthly.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMonthly.Location = New System.Drawing.Point(3, 6)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(114, 29)
        Me.lblMonthly.TabIndex = 1
        Me.lblMonthly.Text = "Monthly"
        '
        'panelYearlyHeaderContainer
        '
        Me.panelYearlyHeaderContainer.BackColor = System.Drawing.Color.Gray
        Me.panelYearlyHeaderContainer.Controls.Add(Me.lblThisYear)
        Me.panelYearlyHeaderContainer.Controls.Add(Me.panelYearlyValueContainer)
        Me.panelYearlyHeaderContainer.Controls.Add(Me.lblYearly)
        Me.panelYearlyHeaderContainer.Location = New System.Drawing.Point(704, 167)
        Me.panelYearlyHeaderContainer.Name = "panelYearlyHeaderContainer"
        Me.panelYearlyHeaderContainer.Size = New System.Drawing.Size(288, 190)
        Me.panelYearlyHeaderContainer.TabIndex = 11
        '
        'lblThisYear
        '
        Me.lblThisYear.AutoSize = True
        Me.lblThisYear.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThisYear.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblThisYear.Location = New System.Drawing.Point(103, 6)
        Me.lblThisYear.Name = "lblThisYear"
        Me.lblThisYear.Size = New System.Drawing.Size(35, 29)
        Me.lblThisYear.TabIndex = 4
        Me.lblThisYear.Text = "()"
        Me.lblThisYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelYearlyValueContainer
        '
        Me.panelYearlyValueContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelYearlyValueContainer.Controls.Add(Me.lblYearlyValue)
        Me.panelYearlyValueContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelYearlyValueContainer.Location = New System.Drawing.Point(0, 46)
        Me.panelYearlyValueContainer.Name = "panelYearlyValueContainer"
        Me.panelYearlyValueContainer.Size = New System.Drawing.Size(288, 144)
        Me.panelYearlyValueContainer.TabIndex = 3
        '
        'lblYearlyValue
        '
        Me.lblYearlyValue.AutoSize = True
        Me.lblYearlyValue.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearlyValue.Location = New System.Drawing.Point(15, 52)
        Me.lblYearlyValue.Name = "lblYearlyValue"
        Me.lblYearlyValue.Size = New System.Drawing.Size(43, 45)
        Me.lblYearlyValue.TabIndex = 2
        Me.lblYearlyValue.Text = "0"
        '
        'lblYearly
        '
        Me.lblYearly.AutoSize = True
        Me.lblYearly.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearly.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblYearly.Location = New System.Drawing.Point(3, 6)
        Me.lblYearly.Name = "lblYearly"
        Me.lblYearly.Size = New System.Drawing.Size(92, 29)
        Me.lblYearly.TabIndex = 2
        Me.lblYearly.Text = "Yearly"
        '
        'panelInnerDateTimeContainer
        '
        Me.panelInnerDateTimeContainer.AutoSize = True
        Me.panelInnerDateTimeContainer.BackColor = System.Drawing.Color.DarkGray
        Me.panelInnerDateTimeContainer.Controls.Add(Me.lblDateAndTime)
        Me.panelInnerDateTimeContainer.Location = New System.Drawing.Point(37, 5)
        Me.panelInnerDateTimeContainer.Name = "panelInnerDateTimeContainer"
        Me.panelInnerDateTimeContainer.Size = New System.Drawing.Size(622, 69)
        Me.panelInnerDateTimeContainer.TabIndex = 12
        '
        'lblDateAndTime
        '
        Me.lblDateAndTime.AutoSize = True
        Me.lblDateAndTime.Font = New System.Drawing.Font("Yu Gothic UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAndTime.Location = New System.Drawing.Point(5, 9)
        Me.lblDateAndTime.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblDateAndTime.Name = "lblDateAndTime"
        Me.lblDateAndTime.Size = New System.Drawing.Size(238, 46)
        Me.lblDateAndTime.TabIndex = 0
        Me.lblDateAndTime.Text = "Date and Time"
        '
        'timerDateAndTime
        '
        Me.timerDateAndTime.Interval = 1000
        '
        'panelOuterDateTimeContainer
        '
        Me.panelOuterDateTimeContainer.AutoSize = True
        Me.panelOuterDateTimeContainer.BackColor = System.Drawing.Color.Gray
        Me.panelOuterDateTimeContainer.Controls.Add(Me.panelInnerDateTimeContainer)
        Me.panelOuterDateTimeContainer.Location = New System.Drawing.Point(0, 35)
        Me.panelOuterDateTimeContainer.Name = "panelOuterDateTimeContainer"
        Me.panelOuterDateTimeContainer.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.panelOuterDateTimeContainer.Size = New System.Drawing.Size(667, 80)
        Me.panelOuterDateTimeContainer.TabIndex = 13
        '
        'dgvSold
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSold.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSold.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSold.Location = New System.Drawing.Point(3, 3)
        Me.dgvSold.Name = "dgvSold"
        Me.dgvSold.RowHeadersWidth = 35
        Me.dgvSold.RowTemplate.Height = 28
        Me.dgvSold.RowTemplate.ReadOnly = True
        Me.dgvSold.Size = New System.Drawing.Size(947, 454)
        Me.dgvSold.TabIndex = 0
        '
        'panelDGV
        '
        Me.panelDGV.BackColor = System.Drawing.Color.Gray
        Me.panelDGV.Controls.Add(Me.dgvStocks)
        Me.panelDGV.Controls.Add(Me.dgvSold)
        Me.panelDGV.Location = New System.Drawing.Point(39, 460)
        Me.panelDGV.Name = "panelDGV"
        Me.panelDGV.Size = New System.Drawing.Size(953, 460)
        Me.panelDGV.TabIndex = 7
        '
        'dgvStocks
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStocks.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStocks.Location = New System.Drawing.Point(3, 3)
        Me.dgvStocks.Name = "dgvStocks"
        Me.dgvStocks.RowHeadersWidth = 35
        Me.dgvStocks.RowTemplate.Height = 28
        Me.dgvStocks.RowTemplate.ReadOnly = True
        Me.dgvStocks.Size = New System.Drawing.Size(947, 454)
        Me.dgvStocks.TabIndex = 1
        '
        'picboxJustAWrenchImage
        '
        Me.picboxJustAWrenchImage.BackColor = System.Drawing.Color.Transparent
        Me.picboxJustAWrenchImage.BackgroundImage = Global.POS_System.My.Resources.Resources.wrench_removebg_preview
        Me.picboxJustAWrenchImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxJustAWrenchImage.Location = New System.Drawing.Point(909, 35)
        Me.picboxJustAWrenchImage.Name = "picboxJustAWrenchImage"
        Me.picboxJustAWrenchImage.Size = New System.Drawing.Size(182, 107)
        Me.picboxJustAWrenchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxJustAWrenchImage.TabIndex = 2
        Me.picboxJustAWrenchImage.TabStop = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1027, 962)
        Me.Controls.Add(Me.panelDGV)
        Me.Controls.Add(Me.panelOuterDateTimeContainer)
        Me.Controls.Add(Me.panelYearlyHeaderContainer)
        Me.Controls.Add(Me.panelMonthlyHeaderContainer)
        Me.Controls.Add(Me.panelDailyHeaderContainer)
        Me.Controls.Add(Me.panelDisplayDropDown)
        Me.Controls.Add(Me.picboxJustAWrenchImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.Text = "Form1"
        Me.panelDisplayDropDown.ResumeLayout(False)
        Me.panelDailyHeaderContainer.ResumeLayout(False)
        Me.panelDailyHeaderContainer.PerformLayout()
        Me.panelDailyValueContainer.ResumeLayout(False)
        Me.panelDailyValueContainer.PerformLayout()
        Me.panelMonthlyHeaderContainer.ResumeLayout(False)
        Me.panelMonthlyHeaderContainer.PerformLayout()
        Me.panelMonthlyValueContainer.ResumeLayout(False)
        Me.panelMonthlyValueContainer.PerformLayout()
        Me.panelYearlyHeaderContainer.ResumeLayout(False)
        Me.panelYearlyHeaderContainer.PerformLayout()
        Me.panelYearlyValueContainer.ResumeLayout(False)
        Me.panelYearlyValueContainer.PerformLayout()
        Me.panelInnerDateTimeContainer.ResumeLayout(False)
        Me.panelInnerDateTimeContainer.PerformLayout()
        Me.panelOuterDateTimeContainer.ResumeLayout(False)
        Me.panelOuterDateTimeContainer.PerformLayout()
        CType(Me.dgvSold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDGV.ResumeLayout(False)
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxJustAWrenchImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboxCategoryToDisplay As ComboBox
    Friend WithEvents panelDisplayDropDown As Panel
    Friend WithEvents panelDailyHeaderContainer As Panel
    Friend WithEvents panelMonthlyHeaderContainer As Panel
    Friend WithEvents panelYearlyHeaderContainer As Panel
    Friend WithEvents panelInnerDateTimeContainer As Panel
    Friend WithEvents lblDateAndTime As Label
    Friend WithEvents timerDateAndTime As Timer
    Friend WithEvents panelOuterDateTimeContainer As Panel
    Friend WithEvents lblDaily As Label
    Friend WithEvents lblMonthly As Label
    Friend WithEvents lblYearly As Label
    Friend WithEvents panelDailyValueContainer As Panel
    Friend WithEvents panelMonthlyValueContainer As Panel
    Friend WithEvents panelYearlyValueContainer As Panel
    Friend WithEvents picboxJustAWrenchImage As PictureBox
    Friend WithEvents panelDGV As Panel
    Friend WithEvents dgvSold As DataGridView
    Friend WithEvents dgvStocks As DataGridView
    Friend WithEvents lblYesterdayValue As Label
    Friend WithEvents lblMonthlyValue As Label
    Friend WithEvents lblYearlyValue As Label
    Friend WithEvents lblTodayValue As Label
    Friend WithEvents lblToday As Label
    Friend WithEvents lblYesterday As Label
    Friend WithEvents lblThisMonth As Label
    Friend WithEvents lblThisYear As Label
End Class
