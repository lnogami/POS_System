Public Class SalesForm

    Dim defaultDisplay As String

    Public itemSoldDGV As DataGridView 'para ma access ang itemSold na table sa bisan asa

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        defaultDisplay = "Timely"

        cboxFilter.Items.AddRange(New String() {defaultDisplay, "Totalities"})
        cboxFilter.SelectedItem = defaultDisplay

        itemSoldDGV = dgvItemsSold 'e assign ang dgvItemSold sa variable nga accessable publicly

        DatabaseModule.loadItemsSold(dgvItemsSold)

        'disable sa ni kay naka unchecked ang Filter Date by default
        dtpFromDate.Enabled = False
        dtpToDate.Enabled = False

        dgvItemsSold.AllowUserToResizeRows = False 'para dili ma adjust sa user ang rows

        calculateTotalities() 'to calculate all the totalities
        calculateTimelyAmount() 'to calculate daily amounts (sales)

    End Sub

    Private Sub cboxFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxFilter.SelectedIndexChanged

        If cboxFilter.SelectedItem = defaultDisplay Then

            panelTimely.Visible = True
            panelTotality.Visible = False

        Else

            panelTimely.Visible = False
            panelTotality.Visible = True

        End If

    End Sub
    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged

        If chckBoxDateFilter.Checked Then

            DatabaseModule.loadItemsSold(dgvItemsSold, txtSearchBar.Text, dtpFromDate.Value, dtpToDate.Value)

            'magcheck if ang search bar ba kay naay sulod and dili space key ang value
        ElseIf Not String.IsNullOrEmpty(txtSearchBar.Text) AndAlso Not txtSearchBar.Text = " " Then

            DatabaseModule.loadItemsSold(dgvItemsSold, txtSearchBar.Text)
        Else
            DatabaseModule.loadItemsSold(dgvItemsSold)
        End If
    End Sub

    Private Sub dtpFromDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFromDate.ValueChanged

        DatabaseModule.loadItemsSold(dgvItemsSold, txtSearchBar.Text, dtpFromDate.Value, dtpToDate.Value)

        lblTotalGainsValue.Text = DatabaseModule.getTotalCostForTotalGains(dtpFromDate.Value.ToString("yyyy-MM-dd"), dtpToDate.Value.ToString("yyyy-MM-dd"))

    End Sub

    Private Sub dtpToDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpToDate.ValueChanged

        DatabaseModule.loadItemsSold(dgvItemsSold, txtSearchBar.Text, dtpFromDate.Value, dtpToDate.Value)

        lblTotalGainsValue.Text = DatabaseModule.getTotalCostForTotalGains(dtpFromDate.Value.ToString("yyyy-MM-dd"), dtpToDate.Value.ToString("yyyy-MM-dd"))

    End Sub

    Private Sub chckBoxDateFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chckBoxDateFilter.CheckedChanged

        If chckBoxDateFilter.Checked Then

            dtpFromDate.Enabled = True
            dtpToDate.Enabled = True

            DatabaseModule.loadItemsSold(dgvItemsSold, txtSearchBar.Text, dtpFromDate.Value, dtpToDate.Value)

            lblTotalGainsValue.Text = DatabaseModule.getTotalCostForTotalGains(dtpFromDate.Value.ToString("yyyy-MM-dd"), dtpToDate.Value.ToString("yyyy-MM-dd"))

        Else

            dtpFromDate.Enabled = False
            dtpToDate.Enabled = False

            If Not String.IsNullOrEmpty(txtSearchBar.Text) AndAlso Not txtSearchBar.Text = " " Then

                DatabaseModule.loadItemsSold(dgvItemsSold, txtSearchBar.Text)
            Else

                DatabaseModule.loadItemsSold(dgvItemsSold)
            End If

            lblTotalGainsValue.Text = DatabaseModule.getTotalCostForTotalGains()


        End If

    End Sub

    Public Sub calculateTotalities()

        Dim totalItems, totalQuantityOfEachItems, totalAmount As Double

        For i = 0 To dgvItemsSold.RowCount - 2

            totalQuantityOfEachItems += Double.Parse(dgvItemsSold.Rows(i).Cells("quantity").Value)
            totalAmount += Double.Parse(dgvItemsSold.Rows(i).Cells("amount").Value)

        Next

        totalItems = dgvItemsSold.Rows.Count - 1


        lblTotalItemsValue.Text = totalItems.ToString
        lblTotalQuantityValue.Text = totalQuantityOfEachItems.ToString
        lblTotalAmountValue.Text = totalAmount.ToString("C")
        lblTotalGainsValue.Text = DatabaseModule.getTotalCostForTotalGains()

    End Sub

    Public Sub calculateTimelyAmount()

        'for those mini features in the dashboard
        Dim yesterday As Integer = Integer.Parse(DateTime.Now.ToString("dd")) - 1   'to get yesterday's date
        lblTodayValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-MM-" & yesterday.ToString), DateTime.Now.ToString("yyyy-MM-dd"))).ToString("C") 'ranges between yesterday up to this day

        Dim today As DateTime = DateTime.Now
        Dim diffToMonday As Integer = today.DayOfWeek - DayOfWeek.Monday  'Calculate the difference to find Monday (DayOfWeek.Monday = 1)

        If diffToMonday < 0 Then     ' Adjust for cases where today is Sunday
            diffToMonday += 7
        End If

        ' Find Monday and Sunday of the current week
        Dim mondayOfThisWeek As DateTime = today.AddDays(-diffToMonday).Date
        Dim sundayOfThisWeek As DateTime = mondayOfThisWeek.AddDays(6).Date

        'getting the total number of amount earned today
        lblTodayValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"))).ToString("C")
        'getting the total number of amount earned yesterday
        lblYesterdayValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-MM-" & yesterday.ToString), DateTime.Now.ToString("yyyy-MM-" & yesterday.ToString))).ToString("C")
        'getting the total number of amount earned this current week
        lblWeeklyValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(mondayOfThisWeek.ToString("yyyy-MM-dd"), sundayOfThisWeek.ToString("yyyy-MM-dd"))).ToString("C")  'ranges within this month
        'getting the total number of amount earned this current month
        lblMonthlyValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-MM-1"), DateTime.Now.ToString("yyyy-MM-dd"))).ToString("C")  'ranges within this month
        'getting the total number of amount earned this current year
        lblYearlyValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-1-1"), DateTime.Now.ToString("yyyy-MM-dd"))).ToString("C")  'ranges within this year

    End Sub

    Private Sub dgvItemsSold_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvItemsSold.RowsAdded

        'to recalculate these if naay bag ong nasold nga item
        calculateTimelyAmount()
        calculateTotalities()

    End Sub
End Class