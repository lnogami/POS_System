Imports System.Threading

Public Class DashboardForm

    Dim frequentlySold As String
    Dim outOfStocks As String

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timerDateAndTime.Start()

        frequentlySold = "Most Frequently Sold Items" 'index 0
        outOfStocks = "Out of Stock Items"            'index 1

        cboxCategoryToDisplay.Items.AddRange(New String() {frequentlySold, outOfStocks})
        cboxCategoryToDisplay.SelectedIndex = cboxCategoryToDisplay.Items.IndexOf(frequentlySold)
        'Me.BackColor = Color.FromArgb(255, 64, 64, 64)

        'DatabaseModule.loadItemsFrequentlySold(dgvSold)

        'pang label rani timailhan nga this month og this year ang ginapasabot sa Monthly og Yearly
        lblThisMonth.Text = "(" & DateTime.Now.ToString("MMMM") & ")"
        lblThisYear.Text = "(" & DateTime.Now.ToString("yyyy") & ")"

        'for those mini features in the dashboard
        Dim yesterday As Integer = Integer.Parse(DateTime.Now.ToString("dd")) - 1   'to get yesterday's date
        lblYesterdayValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-MM-" & yesterday.ToString), DateTime.Now.ToString("yyyy-MM-" & yesterday.ToString))).ToString("C") 'ranges between yesterday up to this day
        lblTodayValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"))).ToString("C") 'ranges between yesterday up to this day

        'getting the total number of amount earned this current month
        lblMonthlyValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-MM-1"), DateTime.Now.ToString("yyyy-MM-dd"))).ToString("C")  'ranges within this month

        'getting the total number of amount earned this current year
        lblYearlyValue.Text = Double.Parse(calculateTotalAmountBaseOnSpecifiedDateSpan(DateTime.Now.ToString("yyyy-1-1"), DateTime.Now.ToString("yyyy-MM-dd"))).ToString("C")  'ranges within this year

        'para dili ma adjust sa user ang rows
        dgvSold.AllowUserToResizeRows = False
        dgvStocks.AllowUserToResizeRows = False
    End Sub

    Private Sub timerDateAndTime_Tick(sender As Object, e As EventArgs) Handles timerDateAndTime.Tick

        lblDateAndTime.Text = DateTime.Now.ToString("MMMM dd, yyyy (dddd)  hh:mm:ss tt")
    End Sub

    Private Sub cboxCategoryToDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCategoryToDisplay.SelectedIndexChanged

        If cboxCategoryToDisplay.SelectedItem = frequentlySold Then

            'DatabaseModule.loadItemsFrequentlySold(dgvSold)
            dgvSold.Visible = True
            dgvStocks.Visible = False
            DatabaseModule.loadItems(dgvSold, cboxCategoryToDisplay.SelectedItem)

        Else

            'DatabaseModule.loadItemsOutOfStock(dgvStocks)
            dgvSold.Visible = False
            dgvStocks.Visible = True
            DatabaseModule.loadItems(dgvStocks, cboxCategoryToDisplay.SelectedItem)

        End If


    End Sub
End Class