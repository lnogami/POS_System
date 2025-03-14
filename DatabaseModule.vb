
Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Bcpg

Module DatabaseModule

    'an INOGAMI creations                       Created: 12-12-24 
    '                                           Updated: 12-18-24
    '                                      Last Updated: 12-24-24


    'connection String, for database connectivity requirements ni
    Dim connectionString As String = "Server=localhost;Database=pos_system;Uid=root;Pwd=umtc"

    'in order to access the program this must be true
    Public accessGranted As Boolean

    'mag store og data sa currently ni log in
    Dim retrievedUserType As String
    Dim retrievedUsername As String
    Dim retrievedPassword As String
    Public retrievedLastName As String 'this is used for a label in WelcomePage Form
    Private retrievdedIsApprovedAsAdmin As Boolean

    'para sa item database ni nga mga variables, diri isulod ang mga gipang retrieve na data
    Public retrievedItemSerialNumber, retrievedItemName, retrievedItemPrice, retrievedItemCost, retrievedItemQuantity, retrievedItemDateAdded, retrievedItemAddedBy, retrievedItemStock, retrievedItemSold As String

    'para ni pang update sa dgv sa Inventory Form if naay ma change sa mga PopUpInventoryForm
    Private moduleInventoryDGV As DataGridView

    'para ni pang update sa dgv sa Accounts Form if naay ma change sa mga sa user accounts
    Private moduleUsersDGV As DataGridView

    '========================================================================================

    Public Sub loginAutherntication(userType As String, username As String, password As String) 'mag authenticate sa user na mag log in

        Try
            'object nga maghandle sa MySqlConnection
            Using connection As New MySqlConnection(connectionString)
                'e open ang object para ma access nato
                connection.Open()

                'MessageBox.Show("Successfully connected!")

                'mao ni query nga mo pangita sa mga na input nga value sa log in interface, ang mga naka @ is kumbaga variables na sila na which is giset sa may MySqlCommand na part
                Dim query As String = "SELECT username, password, usertype, last_name, approved_as_admin FROM users WHERE usertype = @userType AND username = @username AND password = @password"

                'magbuhat tag object sa MySqlCommand para asikasohon niya ang query in associate sa current database na connection
                Using command As New MySqlCommand(query, connection)
                    'mag assign sa value sa mga parameter ani na method into sa variable nga nasa query which is naka indicate by @
                    command.Parameters.AddWithValue("@usertype", userType)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    'magbuhat og object sa MySqlAdpater para mag execute sa query, and mag fetch sa mga value nga associate sa na execute na query
                    Dim adapter As New MySqlDataAdapter(command)

                    'magbuhat tag object sa DataTable para naa tay kasudlan sa mga values nga na fetch sa adapter, if walay nag match na record (walay na fetch ang adapter) automatic 0 ang Rows.Count
                    Dim table As New DataTable()
                    'diri na isulod sa adapater iyang mga na fetch na data into the data container which is anf DataTable
                    adapter.Fill(table)

                    'condition if naa bay na fetch na data ang adapater, kay if wala, it means walay nag match na data na gi query
                    If table.Rows.Count > 0 Then

                        'mag retrieve sa data sa kada fields nga na fetch gikan sa database
                        retrievedUserType = table.Rows(0)("usertype".ToString) 'table.Rows(0) means ang pinaka una nga Row, and ang "usertype" is name sa field nga kuhaan sa data sa kani na row.
                        retrievedUsername = table.Rows(0)("username".ToString)
                        retrievedPassword = table.Rows(0)("password".ToString)
                        retrievedLastName = table.Rows(0)("last_name".ToString)
                        retrievdedIsApprovedAsAdmin = table.Rows(0)("approved_as_admin")

                        'if admin nga na approved na as admin or cashier ang makalog in
                        If retrievdedIsApprovedAsAdmin OrElse retrievedUserType = "cashier" Then

                            'condition rani na if ang na fetch o retrieve na mga data is sakto bajud or same ba jud sa parameter
                            If retrievedUserType = userType AndAlso retrievedUsername = username AndAlso retrievedPassword = password Then
                                'e set ang accessability, para ni sa log in nga interface, kay if True ni it means maka proceed ang user sa program.
                                accessGranted = True
                            Else
                                accessGranted = False
                            End If

                        Else

                            MessageBox.Show("Cannot log in! Pending approval as admin..", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                        End If
                    Else
                        'mag notify rani na walay nag match na user base sa gi query
                        MessageBox.Show("No matching user found!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If

                End Using

                'e close ang MySqlConnection kay humana man sya sa iyang purpose.
                connection.Close()

            End Using

            'mag handle sa mga potential errors
        Catch ex As Exception
            'mag notify na naay problema in associate sa database
            MessageBox.Show("Unable to Connect to Database " + vbNewLine + "Something went wrong!" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    'tig detect rani if available pa ba ang username (like wala pa bay nakagamit na username)
    Public Function usernameAlreadyExist(userType As String, username As String) As Boolean 'mag authenticate sa user na mag log in

        Try
            'object nga maghandle sa MySqlConnection
            Using connection As New MySqlConnection(connectionString)
                'e open ang object para ma access nato
                connection.Open()
                'mao ni query nga mo pangita sa mga na input nga value sa log in interface, ang mga naka @ is kumbaga variables na sila na which is giset sa may MySqlCommand na part
                Dim query As String = "SELECT username, password, usertype, last_name FROM users WHERE usertype = @userType"

                'magbuhat tag object sa MySqlCommand para asikasohon niya ang query in associate sa current database na connection
                Using command As New MySqlCommand(query, connection)
                    'mag assign sa value sa mga parameter ani na method into sa variable nga nasa query which is naka indicate by @
                    command.Parameters.AddWithValue("@usertype", userType)

                    'magbuhat og object sa MySqlAdpater para mag execute sa query, and mag fetch sa mga value nga associate sa na execute na query
                    Dim adapter As New MySqlDataAdapter(command)

                    'magbuhat tag object sa DataTable para naa tay kasudlan sa mga values nga na fetch sa adapter, if walay nag match na record (walay na fetch ang adapter) automatic 0 ang Rows.Count
                    Dim table As New DataTable()
                    'diri na isulod sa adapater iyang mga na fetch na data into the data container which is anf DataTable
                    adapter.Fill(table)

                    'condition if naa bay na fetch na data ang adapater, kay if wala, it means walay nag match na data na gi query
                    If table.Rows.Count > 0 Then

                        For i = 0 To table.Rows.Count

                            If username = table.Rows(i)("username".ToString) Then
                                Return True
                            End If
                        Next
                    Else
                        'mag notify rani na walay nag match na user base sa gi query
                        MessageBox.Show("There is a problem retrieving user data!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If

                End Using

                'e close ang MySqlConnection kay humana man sya sa iyang purpose.
                connection.Close()

            End Using

            'mag handle sa mga potential errors
        Catch ex As Exception
        End Try

        Return False

    End Function


    'obviously mag add nig user
    Public Sub addUsers(userName As String, passWord As String, firstName As String, lastName As String, Age As Integer, Sex As String, birthDate As String, Address As String, contactNumber As String, userType As String, accountCreation As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                'mao ni ang e query sa database
                Dim query As String = "INSERT INTO users (username, `password`, first_name, last_name, age, sex, birthdate, address, contact_no, usertype, account_creation, approved_as_admin) VALUES (@userName,@passWord,@firstName,@lastName,@Age,@Sex,@birthDate,@Address,@contactNumber,@userType,@accountCreation, 0)" '0 by default false ang approval sa admin, maong need pa sya e approve

                'buhat og object nga mag execute og parameter variable
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@userName", userName)
                    command.Parameters.AddWithValue("@passWord", passWord)
                    command.Parameters.AddWithValue("@firstName", firstName)
                    command.Parameters.AddWithValue("@lastName", lastName)
                    command.Parameters.AddWithValue("@Age", Age)
                    command.Parameters.AddWithValue("@Sex", Sex)
                    command.Parameters.AddWithValue("@birthDate", birthDate)
                    command.Parameters.AddWithValue("@Address", Address)
                    command.Parameters.AddWithValue("@contactNumber", contactNumber)
                    command.Parameters.AddWithValue("@userType", userType.ToLower)
                    command.Parameters.AddWithValue("@accountCreation", accountCreation)

                    'pang debug rani
                    'MessageBox.Show($"Parameters: Username={userName}, Password={passWord}, FName={firstName}, LName={lastName}, Age={Age}, Sex={Sex}, BirthDate={birthDate}, Address={Address}, Contact={contactNumber}, Usertype={userType}, Account Creation={accountCreation}")

                    command.ExecuteNonQuery()

                End Using

                MessageBox.Show("New user was added successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                If userType.ToLower = "admin" Then 'if admin ang gibuhat na account mo pop up ni para mag remind

                    MessageBox.Show("In order to log in as an Admin," & vbNewLine & "Please wait for admin approval..", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                End If

                connection.Close()

            End Using
        Catch ex As Exception

            MessageBox.Show("An error occured while accessing database " + ex.Message + " " + ex.StackTrace)

        End Try

    End Sub


    Public Sub makeACopyOfUsersDGV(ByRef dgv As DataGridView) 'purpose ani is mag assign og mo act as dgv, kay ang dgv sa lain class is dili man nimo directly ma access from another class thats why giingani nako

        moduleUsersDGV = dgv  'ang moduleDGV ang mag act as dgvUsersAccount (dgv from another account)

    End Sub


    'Method Overload: default na loadUsers
    Public Sub loadUsers()

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                'magbuhat og query para e execute sa adapter
                Dim query As String = "SELECT id AS ID, first_name AS `First Name`, last_name AS `Last Name`, age AS Age, sex AS Sex, birthdate AS Birthdate, address AS Address, contact_no AS `Contact Number`, usertype AS `Position`, account_creation AS `Account Creation` FROM users"

                'magbuhat og object sa MySqlDataAdapter para mag execute sa query in releation sa kung asa na database naka connect
                Dim adapter As New MySqlDataAdapter(query, connection)

                'butanganan sa mga data nga na fetch o na retrive sa adapter from the database
                Dim table As New DataTable()
                'isulod sa table ang mga nafetch sa adapter
                adapter.Fill(table)

                'ang mga na store na data sa DataTable kay ibutang na sa displayhanan which is ang DataGridView
                moduleUsersDGV.DataSource = table

                'e close ang connection
                connection.Close()

            End Using
        Catch ex As Exception

            'MessageBox.Show("Something went wrong..   " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End Try
    End Sub


    'Method Overload: loadUsers na accepting 2 parameteres
    Public Sub loadUsers(dgvUsers As DataGridView, searchSpecification As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                'mao ni ang query
                Dim query As String = "SELECT id AS ID, first_name AS `First Name`, last_name AS `Last Name`, age AS Age, sex AS Sex, birthdate AS Birthdate, address AS Address, contact_no AS `Contact Number`, usertype AS `Position`, account_creation AS `Account Creation` FROM users WHERE (first_name LIKE @searchSpecification OR last_name LIKE @searchSpecification) AND (userType = 'admin' or userType = 'cashier')"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@searchSpecification", "%" & searchSpecification & "%")
                    command.ExecuteNonQuery()

                    Dim adapter As New MySqlDataAdapter(command)

                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvUsers.DataSource = table
                    dgvUsers.Refresh()

                End Using

                connection.Close()

            End Using
        Catch ex As Exception

            'MessageBox.Show("Something went wrong..   " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End Try
    End Sub


    'Method Overload: loadUsers na accepting 3 parameters
    Public Sub loadUsers(dgvUsers As DataGridView, userType As String, searchSpecification As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                'mao ni ang query
                Dim query As String = "SELECT id AS ID, first_name AS `First Name`, last_name AS `Last Name`, age AS Age, sex AS Sex, birthdate AS Birthdate, address AS Address, contact_no AS `Contact Number`, usertype AS `Position`, account_creation AS `Account Creation` FROM users WHERE (first_name LIKE @searchSpecification OR last_name LIKE @searchSpecification) AND userType = @userType;"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@searchSpecification", "%" & searchSpecification & "%")
                    command.Parameters.AddWithValue("@userType", userType.ToLower)
                    command.ExecuteNonQuery()

                    Dim adapter As New MySqlDataAdapter(command)

                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvUsers.DataSource = table
                    dgvUsers.Refresh()

                End Using

                connection.Close()

            End Using
        Catch ex As Exception

            'MessageBox.Show("Something went wrong..   " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End Try
    End Sub

    Public Function isApprovedAsAdmin(id As Integer) 'mag return ni sya og 1 (true) or 0 (false)

        Dim countIfThereIsStillAnAdmin As Integer 'ilhanan nga dapat naay isa nga admin mabilin

        Try
            Dim tableOfUsers As New DataTable

            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT id, usertype, approved_as_admin FROM users"

                Using adapter As New MySqlDataAdapter(query, connection)

                    adapter.Fill(tableOfUsers)

                End Using

            End Using

            For i = 0 To tableOfUsers.Rows.Count - 1

                'If tableOfUsers.Rows(i)("usertype") = "admin" Then     'counter kung ang admin

                '    countIfThereIsStillAnAdmin += 1

                'End If

                If tableOfUsers.Rows(i)("id") = id AndAlso tableOfUsers.Rows(i)("usertype") = "admin" Then

                    Return tableOfUsers.Rows(i)("approved_as_admin")

                End If

            Next

        Catch ex As Exception

            'MessageBox.Show("An error occured here on determining is the user is approved" & vbNewLine & ex.Message & vbNewLine & vbNewLine & ex.StackTrace)

        End Try

        Return -1   'sentinel value

    End Function

    'wala pa ni na implement
    Public Function leftAtleastOneAdmin() 'timailhan nga naa pa bay approved admin

        Try
            Dim table As New DataTable
            Dim approvedAdminCount As Integer

            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = " SELECT approved_as_admin FROM users"

                Using adapter As New MySqlDataAdapter(query, connection)

                    adapter.Fill(table)

                End Using

            End Using

            For i = 0 To table.Rows.Count - 1

                If table.Rows(i)("approved_as_admin") = 1 Then

                    approvedAdminCount += 1

                End If

            Next

            If approvedAdminCount > 0 Then

                Return True

            Else

                Return False

            End If

        Catch ex As Exception
            'MessageBox.Show("Something went wrongggggg" & vbNewLine & ex.Message & vbNewLine & vbNewLine & ex.StackTrace)
        End Try

    End Function

    Public Sub toApproveAnAdmin(id As Integer, checkBox As CheckBox)

        Try
            'if checked ang Approved na checkbox 1 ang value ani, else 0
            Dim approveAsAdmin As Integer

            If checkBox.Checked Then

                approveAsAdmin = 1 '1 means true

            Else

                approveAsAdmin = 0 '0 means false

            End If

            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "UPDATE users SET approved_as_admin = @appredAsAdmin WHERE id = @id;"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@id", id)
                    command.Parameters.AddWithValue("@appredAsAdmin", approveAsAdmin)
                    command.ExecuteNonQuery()

                    'MessageBox.Show("Successfully approved as admin!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                End Using

            End Using

        Catch ex As Exception

        End Try

    End Sub


    Public Sub deleteUsers(dgv As DataGridView)

        Try
            'condition nga dapat naay pilion nga user account sa DataGridView ang user
            If dgv.SelectedRows.Count > 0 Then

                'ensures nga isa ra jud ang e select na user sa DataGridView
                If dgv.SelectedRows.Count > 1 Then
                    MessageBox.Show("Please select only one user, one at a time.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit Sub
                End If

                Dim selectedRow = dgv.SelectedRows(0)
                Dim userId = selectedRow.Cells("id").Value

                Dim confirmDeletion As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete user?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmDeletion = DialogResult.Yes Then

                    Dim query As String = "DELETE FROM users WHERE id = @userId"

                    Using connection As New MySqlConnection(connectionString)

                        connection.Open()

                        Using command As New MySqlCommand(query, connection)

                            command.Parameters.AddWithValue("@userid", userId)
                            command.ExecuteNonQuery()

                        End Using

                        connection.Close()
                        'e refresh niya ang DataGridView
                        loadUsers()

                    End Using

                    MessageBox.Show("Successfully deleted user", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                End If
            Else

                'MessageBox.Show("Please select a user to delete..", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If

        Catch ex As Exception

        End Try

    End Sub


    Public Sub makeACopyOfIventoryDGV(ByRef dgv As DataGridView)  'purpose ani is mag assign og mo act as dgv, kay ang dgv sa lain class is dili man nimo directly ma access from another class thats why giingani nako

        moduleInventoryDGV = dgv  'ang moduleDGV ang mag act as dgvUsersAccount (dgv from another account)

    End Sub


    Public Sub loadItems() 'default nga load user, para ni sya sa mo access nga class aside sa class kung asa ang mismong dgv nag exist

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT id AS ID, item_name AS `Item`, quantity AS `Quantity`, cost AS `Cost`, price AS `Price`, date_added AS `Date Added`, added_by AS `Added by`, stock AS `Stock`, sold AS `Sold` FROM items"

                'magbuhat og object sa MySqlDataAdapter para mag execute sa query in releation sa kung asa na database naka connect
                Dim adapter As New MySqlDataAdapter(query, connection)
                'butanganan sa mga data nga na fetch o na retrive sa adapter from the database
                Dim table As New DataTable()
                'isulod sa table ang mga nafetch sa adapter
                adapter.Fill(table)

                'ang mga na store na data sa DataTable kay ibutang na sa displayhanan which is ang DataGridView
                moduleInventoryDGV.DataSource = table

                'e close ang connection
                connection.Close()

            End Using
        Catch ex As Exception

            'MessageBox.Show("Something went wrong..   " + ex.Message & vbNewLine & ex.StackTrace, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End Try
    End Sub

    'Method Overload: loadItems na mag base sa ComboBox selected value          '//sa may Dashboard ni sya nagamit
    Public Sub loadItems(dgvItems As DataGridView, dropDownSelection As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String

                'MessageBox.Show(dropDownSelection.ToString)
                If dropDownSelection = "Most Frequently Sold Items" Then

                    'magbuhat og query para e execute sa adapter
                    query = "SELECT id AS ID, item_name AS `Item`, quantity AS `Quantity`, cost AS `Cost`, price AS `Price`, sold AS `Sold`, date_added AS `Date Added`, added_by AS `Added by`, stock AS `Stock` FROM items  ORDER BY sold DESC"

                ElseIf dropDownSelection = "Out of Stock Items" Then

                    'magbuhat og query para e execute sa adapter
                    query = "SELECT id AS ID, item_name AS `Item`, quantity AS `Quantity`, cost AS `Cost`, price AS `Price`, stock AS `Stock`, date_added AS `Date Added`, added_by AS `Added by`, sold AS `Sold` FROM items ORDER BY stock"

                End If

                'magbuhat og object sa MySqlDataAdapter para mag execute sa query in releation sa kung asa na database naka connect
                Dim adapter As New MySqlDataAdapter(query, connection)
                'butanganan sa mga data nga na fetch o na retrive sa adapter from the database
                Dim table As New DataTable()
                'isulod sa table ang mga nafetch sa adapter
                adapter.Fill(table)

                'ang mga na store na data sa DataTable kay ibutang na sa displayhanan which is ang DataGridView
                dgvItems.DataSource = table

                'e close ang connection
                connection.Close()

            End Using
        Catch ex As Exception

            'MessageBox.Show("Something went wrong..   " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End Try
    End Sub

    'sa inventory ni sya nagamit
    Public Sub loadItemsWithSearchFeature(ByRef dgv As DataGridView, itemSearch As String, querySpecificFor As String)

        Try

            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String

                'to determine who calls this function, because lahi lahi og focus ang pagkadeisplay sa kada page, dependi sa purpose
                If querySpecificFor = "cashier" Then
                    'sa cashier anf focus na e display o ipakita is ang ID, Item, og Stock para madetermine sa cashier kung pila pay stocks nabilin sa item
                    query = "SELECT id AS ID, item_name AS `Item`, stock AS `Stock`, price AS `Price`, quantity AS `Quantity`, cost AS `Cost`, date_added AS `Date Added`, added_by AS `Added by`, sold AS `Sold` FROM items WHERE item_name LIKE @itemSearch OR id LIKE @itemSearch"

                ElseIf querySpecificFor = "inventory" Then
                    'bali mao ni ang default nga pagkapasunod sa field nga e display sa DataGridView
                    query = "SELECT id AS ID, item_name AS `Item`, quantity AS `Quantity`, cost AS `Cost`, price AS `Price`, date_added AS `Date Added`, added_by AS `Added by`, stock AS `Stock`, sold AS `Sold` FROM items WHERE item_name LIKE @itemSearch OR id LIKE @itemSearch"

                End If

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@itemSearch", "%" & itemSearch & "%")

                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgv.DataSource = table

                    'MessageBox.Show("Current Row count after asiging value: " & dgv.RowCount.ToString)

                End Using


            End Using
        Catch ex As Exception

            MessageBox.Show("An error occured!" & ex.Message)

        End Try

    End Sub

    Public Sub getDataFromSpecificRowInItems(ByRef dgv As DataGridView)

        'pang popUpInventoryForm ni kay wala man silay kaugalingong access sa dgv sa Inventory
        moduleInventoryDGV = dgv

        Try
            If dgv.SelectedRows.Count > 0 Then

                'MessageBox.Show(dgv.SelectedRows.Count.ToString)
                Dim selectedRow As DataGridViewRow = dgv.SelectedRows(0)

                'ingani iyang name sa fields diri kay gikan mani sa dgvInventory gikuha gud, naka alias mani `AS ID` maong ID instead of id (id jud iyang field name sa database)
                retrievedItemSerialNumber = selectedRow.Cells("ID").Value
                retrievedItemName = selectedRow.Cells("Item").Value
                retrievedItemPrice = selectedRow.Cells("Price").Value
                retrievedItemCost = selectedRow.Cells("Cost").Value
                retrievedItemQuantity = selectedRow.Cells("Quantity").Value
                retrievedItemDateAdded = selectedRow.Cells("Date Added").Value
                retrievedItemAddedBy = selectedRow.Cells("Added by").Value
                retrievedItemStock = selectedRow.Cells("Stock").Value
                retrievedItemSold = selectedRow.Cells("Sold").Value

            End If
        Catch ex As Exception
            'MessageBox.Show("Something went wrong sa pag retrieve sa mga data..  " & ex.Message
            'MessageBox.Show("No data here.." & vbNewLine & ex.StackTrace, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    Public Sub toTransferDataIntoInvoiceTotal(ByRef dgvItems As DataGridView, ByRef dgvInvoice As DataGridView, ByRef rowNumber As Integer)

        Try

            If dgvItems.SelectedRows.Count > 0 Then

                Dim selectedRow As DataGridViewRow = dgvItems.SelectedRows(0)

                dgvInvoice.Rows.Add()

                dgvInvoice.Rows(rowNumber).Cells("invoiceQuantity").Value = 1.ToString
                dgvInvoice.Rows(rowNumber).Cells("invoiceItemName").Value = selectedRow.Cells("Item").Value
                dgvInvoice.Rows(rowNumber).Cells("invoicePrice").Value = selectedRow.Cells("Price").Value
                dgvInvoice.Rows(rowNumber).Cells("invoiceAmount").Value = selectedRow.Cells("Price").Value

                rowNumber = rowNumber + 1

            End If
        Catch ex As Exception
            'MessageBox.Show("Error " & ex.Message)
        End Try

    End Sub


    Public Sub addInventoryItem(itemName As String, quantity As String, cost As String, price As String, dateAdded As String)

        Try
            'Dim confirmToAdd As DialogResult = MessageBox.Show("Confirm to add items?" & vbNewLine & "item name: " & itemName & vbNewLine & "quantity: " & quantity & vbNewLine & "cost: " & cost & vbNewLine & "price: " & price & vbNewLine & "added by: " & retrievedLastName, "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            Dim confirmToAdd As DialogResult = MessageBox.Show("Confirm to add items?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            'if no, dili na niya ni ipadayun ang pag execute sa query
            If confirmToAdd = DialogResult.No Then

                Exit Sub
            End If

            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "INSERT INTO items(item_name, quantity, cost, price, date_added, added_by, stock, sold) VALUES(@itemName,@quantity,@cost, @price, @dateAdded, @addedBy, @quantity, 0)"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@itemName", itemName)
                    command.Parameters.AddWithValue("@quantity", quantity)
                    command.Parameters.AddWithValue("@cost", cost)
                    command.Parameters.AddWithValue("@price", price)
                    command.Parameters.AddWithValue("@dateAdded", dateAdded)
                    command.Parameters.AddWithValue("@addedBy", retrievedLastName)
                    command.ExecuteNonQuery()
                End Using

                'MessageBox.Show("Searchbar 1: " & InventoryForm.txtSearchBar.Text)
                'InventoryForm.txtSearchBar.Text = "Refreshing!"
                'InventoryForm.txtSearchBar.Focus()
                'Dim var As String = InventoryForm.txtSearchBar.Text
                'MessageBox.Show("Searchbar 2: " & InventoryForm.txtSearchBar.Text)

                MessageBox.Show("Item successfully Added!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End Using
        Catch ex As Exception
            'MessageBox.Show("An error occured, cannot add the item. " & ex.Message)
        End Try

        loadItems()

    End Sub

    Public Sub updateInventoryItem(ByRef allowedToAddStock As CheckBox, serialNumber As String, itemName As String, price As String, cost As String, quantity As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String

                If allowedToAddStock.Checked Then

                    query = "UPDATE items SET item_name = @itemName, price = @price, cost = @cost, stock = @quantity WHERE id = @serialNumber"

                Else

                    query = "UPDATE items SET item_name = @itemName, price = @price, cost = @cost, quantity = @quantity WHERE id = @serialNumber"


                End If

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@itemName", itemName)
                    command.Parameters.AddWithValue("@price", price)
                    command.Parameters.AddWithValue("@cost", cost)

                    If allowedToAddStock.Checked Then

                        command.Parameters.AddWithValue("@quantity", quantity)  'allow quantity being added

                        'e refresh ra niya ang dgv sa Invetory
                        loadItems()
                    Else

                        command.Parameters.AddWithValue("@quantity", quantity) 'to just edit the actual quantity

                    End If


                    command.Parameters.AddWithValue("@serialNumber", serialNumber)
                    command.ExecuteNonQuery()

                End Using

                'mao ni mag reset sa values nga makuha sa selected row, una e unselect nato ang row, tapos e reset ang mga naka saved sa variables nga mga nafetch before na values sa selected row
                'moduleInventoryDGV.SelectedRows(0).Selected = False
                retrievedItemSerialNumber = ""
                retrievedItemName = ""
                retrievedItemPrice = ""
                retrievedItemCost = ""
                retrievedItemQuantity = ""
                retrievedItemDateAdded = ""
                retrievedItemAddedBy = ""
                retrievedItemStock = ""
                retrievedItemSold = ""


                'retrievedItemSerialNumber = ""
                'retrievedItemPrice = ""
                'retrievedItemQuantity = ""
                'retrievedItemSold = ""

                connection.Close()
            End Using

            'e refresh ra niya ang dgv sa Invetory
            loadItems()

        Catch ex As Exception

            'MessageBox.Show("An error occured " & ex.Message & vbNewLine & ex.StackTrace)

        End Try

    End Sub

    Public Sub toMinusStockAndAddSoldOnItem(serialNumber As String, stock As String, sold As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "UPDATE items SET stock = @stock, sold = @sold WHERE id = @serialNumber"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@stock", stock)
                    command.Parameters.AddWithValue("@sold", sold)
                    command.Parameters.AddWithValue("@serialNumber", serialNumber)
                    command.ExecuteNonQuery()

                End Using

                connection.Close()
            End Using

            'e refresh ra niya ang dgv sa Invetory
            loadItems()

            'MessageBox.Show("Item updated Successfully!")
        Catch ex As Exception

            'MessageBox.Show("An error occured " & ex.Message)

        End Try

    End Sub

    Public Sub deleteInventoryItem(itemSerialNumber As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "DELETE FROM items WHERE id = @serialNumber"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@serialNumber", itemSerialNumber)
                    command.ExecuteNonQuery()

                End Using

                'e refresh ra niya ang dgv sa Invetory
                loadItems()

                'mao ni mag reset sa values nga makuha sa selected row, una e unselect nato ang row, tapos e reset ang mga naka saved sa variables nga mga nafetch before na values sa selected row
                retrievedItemSerialNumber = ""
                retrievedItemName = ""
                retrievedItemPrice = ""
                retrievedItemCost = ""
                retrievedItemQuantity = ""
                retrievedItemDateAdded = ""
                retrievedItemAddedBy = ""
                retrievedItemStock = ""
                retrievedItemSold = ""

                MessageBox.Show("Item successfully deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End Using

        Catch ex As Exception

            'MessageBox.Show("An error occured while deleting an item! ," & vbNewLine & ex.Message & vbNewLine & ex.StackTrace, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Public Function isItemAlreadyAddedToInvoice(dgvItems As DataGridView, ByRef dgvInnvoice As DataGridView)

        Try

            Dim selectedItem As DataGridViewRow = dgvItems.SelectedRows(0)

            Dim itemToLookFor As String = selectedItem.Cells("Item").Value

            For i = 0 To dgvInnvoice.RowCount - 1

                If itemToLookFor = dgvInnvoice.Rows(i).Cells("invoiceItemName").Value Then

                    dgvInnvoice.Rows(i).Cells("invoiceQuantity").Value = Integer.Parse(dgvInnvoice.Rows(i).Cells("invoiceQuantity").Value) + 1
                    dgvInnvoice.Rows(i).Cells("invoiceAmount").Value = Double.Parse(dgvInnvoice.Rows(i).Cells("invoiceAmount").Value) + Double.Parse(dgvItems.SelectedRows(0).Cells("Price").Value)

                    Return True

                    'MessageBox.Show("Naa najud ni nga item")
                End If

            Next

        Catch ex As Exception
            'MessageBox.Show("Wait lang.. " & ex.Message & vbNewLine & ex.StackTrace)
        End Try

        Return False
    End Function

    Public Sub loadItemsSold(ByRef dgv As DataGridView)

        Try

            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT item_id AS `Item ID`, item_name AS `Item`, quantity AS `Quantity`, price AS Price, amount AS `Amount`, official_receipt AS `OR`, cashier AS `Cashier`, date_bought AS `Date`, time_bought AS `Time` FROM item_sold ORDER BY date_bought DESC, time_bought DESC"

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgv.DataSource = Nothing
                dgv.DataSource = table


            End Using
        Catch ex As Exception

            'MessageBox.Show("An error occured!" & ex.Message)

        End Try

    End Sub


    Public Sub loadItemsSold(dgv As DataGridView, itemSearch As String)

        Try

            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT item_id AS `Item ID`, item_name AS `Item`, quantity AS `Quantity`, price AS Price, amount AS `Amount`, official_receipt AS `OR`, cashier AS `Cashier`, date_bought AS `Date`, time_bought AS `Time` FROM item_sold WHERE item_name LIKE @itemSearch OR item_id LIKE @itemSearch ORDER BY date_bought DESC, time_bought DESC"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@itemSearch", "%" & itemSearch & "%")

                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgv.DataSource = table
                End Using


            End Using
        Catch ex As Exception

            'MessageBox.Show("An error occured!" & ex.Message)

        End Try

    End Sub

    Public Sub loadItemsSold(dgv As DataGridView, itemSearch As String, fromDate As Date, toDate As Date)

        Try

            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT item_id AS `Item ID`, item_name AS `Item`, quantity AS `Quantity`, price AS Price, amount AS `Amount`, official_receipt AS `OR`, cashier AS `Cashier`, date_bought AS `Date`, time_bought AS `Time` FROM item_sold WHERE (item_name LIKE @itemSearch OR item_id LIKE @itemSearch) AND (date_bought BETWEEN @fromDate and @todate) ORDER BY date_bought DESC, time_bought DESC"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@itemSearch", "%" & itemSearch & "%")
                    command.Parameters.AddWithValue("@fromDate", fromDate.ToString("yyyy-MM-dd"))
                    command.Parameters.AddWithValue("@toDate", toDate.ToString("yyyy-MM-dd"))
                    command.ExecuteNonQuery()

                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgv.DataSource = table

                End Using

            End Using
        Catch ex As Exception

            'MessageBox.Show("An error occured!" & ex.Message)

        End Try

    End Sub

    Public Function calculateTotalAmountBaseOnSpecifiedDateSpan(fromStartDate As String, toEndDate As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT quantity, amount FROM item_sold WHERE date_bought BETWEEN @fromDate and @toDate"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@fromDate", fromStartDate)
                    command.Parameters.AddWithValue("@toDate", toEndDate)
                    command.ExecuteNonQuery()

                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable
                    adapter.Fill(table)

                    Dim total As Integer

                    For i = 0 To table.Rows.Count - 1

                        total += Integer.Parse(table.Rows(i)("amount"))  'ipang add up ang value sa kada amount nga column

                    Next

                    Return total.ToString

                End Using

                connection.Close()

            End Using



        Catch ex As Exception

            'MessageBox.Show("An error occured!" & ex.Message & vbNewLine & ex.StackTrace)

        End Try

        Return 0 'just in case walay ma balik na value

    End Function


    Private Sub addAnItemToItemSold(itemID As String, itemName As String, quantity As String, price As String, amount As String, officialReceipt As String, cashier As String, dateBought As String, timeBought As String)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "INSERT INTO item_sold(item_id, item_name, quantity, price, amount, official_receipt, cashier, date_bought, time_bought) VALUES(@itemID, @itemName, @quantity, @price, @amount, @officialReceipt, @cashier, @dateBought, @timeBought)"

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@itemID", itemID)
                    command.Parameters.AddWithValue("@itemName", itemName)
                    command.Parameters.AddWithValue("@quantity", quantity)
                    command.Parameters.AddWithValue("@price", price)
                    command.Parameters.AddWithValue("@amount", amount)
                    command.Parameters.AddWithValue("@officialReceipt", officialReceipt)
                    command.Parameters.AddWithValue("@cashier", cashier)
                    command.Parameters.AddWithValue("@dateBought", dateBought)
                    command.Parameters.AddWithValue("@timeBought", timeBought)
                    command.ExecuteNonQuery()

                    'Dim adapter As New MySqlDataAdapter(command)
                    'Dim table As New DataTable()

                    'adapter.Fill(table)

                End Using

            End Using
        Catch ex As Exception

            'MessageBox.Show("Errorrr " & ex.Message & vbNewLine & ex.StackTrace)

        End Try

    End Sub


    'mao ni procedure nga mag transfer sa item gikan sa item table padulong sa item_sold nga table
    Public Sub toReceipt(fromDGV As DataGridView, invoiceDGV As DataGridView, toDGV As DataGridView)

        Dim listOfItems As New List(Of String) 'mao ni mag act as key
        Dim listOfItemQuantity As New SortedList() 'SortedList para dali ra nato makuha ang value which is ang quantity

        'Dim listOfColumnNames As New List(Of String) 'amo ni iyang expected contents: item_id, item_name, quantity, price, amount, official_receipt, cashier, date_bought, time_bought

        Dim itemID, itemName, quantity, price, amount, officialReceipt, cashier, dateBought, timeBought As String

        officialReceipt = ORGenerator.ToString 'magbuhat og number sa resibo

        'Dim totalCost As Double 'para ni sa pagkuha sa totalGain nga nasa Sales form

        Try
            'purpose ani is kuhaon nato ang sulod sa invoiceDGV, para gamiton unya sa pagkuha pud og rows from item table to itemSold table
            For i = 0 To invoiceDGV.RowCount - 2  ' -2 kay ang DGV naay isa ka blank na row daan (-1), and rule jud sa For loop sa vb.net nga -1 ang upperBound. Maong -2 tanan

                listOfItems.Add(invoiceDGV.Rows(i).Cells("invoiceItemName").Value)
                listOfItemQuantity.Add(listOfItems(i), invoiceDGV.Rows(i).Cells("invoiceQuantity").Value) 'key: invoiceItemName, value: invoiceQuantity

            Next

            'mao nani mag transfer sa kung unsay naa sa invoiceDGV into itemSold table (magkuha una og data sa item table gamit ang kung unsay sulod sa invoiceDGV, then e transfer sa itemSold na table
            For i = 0 To listOfItems.Count - 1

                For j = 0 To fromDGV.RowCount - 1

                    If fromDGV.Rows(j).Cells("Item").Value = listOfItems(i) Then

                        'toDGV.Rows(i).Cells("item_id").Value = fromDGV.Rows(i).Cells("Item").Value

                        itemID = fromDGV.Rows(j).Cells("id").Value
                        itemName = fromDGV.Rows(j).Cells("Item").Value
                        quantity = listOfItemQuantity(listOfItems(i))
                        price = fromDGV.Rows(j).Cells("price").Value
                        amount = price * quantity
                        cashier = retrievedLastName
                        dateBought = DateTime.Now.ToString("yyyy-MM-dd")
                        timeBought = DateTime.Now.ToString("HH:mm:ss")

                        'totalCost += fromDGV.Rows(j).Cells("cost").Value

                        addAnItemToItemSold(itemID, itemName, quantity, price, amount, officialReceipt, cashier, dateBought, timeBought)

                        Dim stock As Integer = fromDGV.Rows(j).Cells("stock").Value
                        Dim sold As Integer = fromDGV.Rows(j).Cells("sold").Value
                        'para ma minusan ang stock og ma plusan ang sold
                        toMinusStockAndAddSoldOnItem(itemID, (stock - Integer.Parse(quantity)).ToString, (sold + Integer.Parse(quantity)).ToString)

                    End If

                Next

            Next

        Catch ex As Exception

            'MessageBox.Show("Error: " & ex.Message & vbNewLine & ex.StackTrace)

        End Try

    End Sub

    Public Function ORGenerator() 'mag generate ranig OR (Official Receipt)

        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT official_receipt FROM item_sold"

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                Dim lastORNumber As Integer

                If table.Rows.Count = 0 Then
                    lastORNumber = 1000000
                Else
                    lastORNumber = table.Rows(0)("official_receipt")
                End If

                For i = 0 To table.Rows.Count - 1

                    If Integer.Parse(table.Rows(i)("official_receipt".ToString)) > lastORNumber Then

                        lastORNumber = table.Rows(i)("official_receipt".ToString)

                    End If
                Next


                Return lastORNumber + 1
                'MessageBox.Show("Last OR is: " & lastORNumber)

                connection.Close()

            End Using
        Catch ex As Exception

            MessageBox.Show("Error when retrieving OR number" & ex.Message & vbNewLine & ex.StackTrace)

        End Try

        Return 0

    End Function

    Public Function getTotalCostForTotalGains()

        Dim itemsTable, itemSoldTable As New DataTable

        'obtaining particular data phase
        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                'query for items table
                Dim queryForItems As String = "SELECT item_name, cost FROM items"

                Using adapter1 As New MySqlDataAdapter(queryForItems, connection)

                    adapter1.Fill(itemsTable)
                    'MessageBox.Show("Item table: " & itemsTable.Rows.Count)

                End Using

                'query for item_sold table
                Dim queryForItemSold As String = "SELECT item_name, quantity, amount FROM item_sold"
                'Dim queryForItemSold As String = "SELECT item_name, quantity, amount FROM item_sold WHERE date_bought = '2024-12-23'"

                Using adapter2 As New MySqlDataAdapter(queryForItemSold, connection)

                    adapter2.Fill(itemSoldTable)
                    'MessageBox.Show("Item Sold table: " & itemSoldTable.Rows.Count)

                End Using

                connection.Close()

            End Using

        Catch ex As Exception

            'MessageBox.Show("Error at " & vbNewLine & ex.Message & vbNewLine & vbNewLine & ex.StackTrace)

        End Try

        'calculation phase
        Try
            Dim totalCost As Double

            For i = 0 To itemSoldTable.Rows.Count - 1

                For j = 0 To itemsTable.Rows.Count - 1

                    If itemSoldTable.Rows(i)("item_name") = itemsTable.Rows(j)("item_name") Then

                        totalCost += (Double.Parse(itemSoldTable.Rows(i)("amount")) - (Double.Parse(itemSoldTable.Rows(i)("quantity")) * Double.Parse(itemsTable.Rows(j)("cost"))))

                    End If

                Next

            Next

            Return totalCost.ToString("C")

        Catch ex As Exception

            MessageBox.Show("An error occured when retrieving the total cost" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace)

        End Try

        Return 0 'incase nag error

    End Function

    Public Function getTotalCostForTotalGains(fromDate As String, toDate As String)

        Dim itemsTable, itemSoldTable As New DataTable

        'obtaining particular data phase
        Try
            Using connection As New MySqlConnection(connectionString)

                connection.Open()

                'query for items table
                Dim queryForItems As String = "SELECT item_name, cost FROM items"

                Using adapter1 As New MySqlDataAdapter(queryForItems, connection)

                    adapter1.Fill(itemsTable)
                    'MessageBox.Show("Item table: " & itemsTable.Rows.Count)

                End Using

                'query for item_sold table
                'Dim queryForItemSold As String = "SELECT item_name, quantity, amount FROM item_sold"
                Dim queryForItemSold As String = "SELECT item_name, quantity, amount FROM item_sold WHERE date_bought BETWEEN @fromDate and @toDate"

                Using command As New MySqlCommand(queryForItemSold, connection)

                    command.Parameters.AddWithValue("@fromDate", fromDate)
                    command.Parameters.AddWithValue("@toDate", toDate)
                    command.ExecuteNonQuery()

                    Using adapter As New MySqlDataAdapter(command)

                        adapter.Fill(itemSoldTable)

                    End Using

                End Using

                connection.Close()

            End Using

        Catch ex As Exception

            'MessageBox.Show("Error at " & vbNewLine & ex.Message & vbNewLine & vbNewLine & ex.StackTrace)

        End Try

        'calculation phase
        Try
            Dim totalCost As Double

            For i = 0 To itemSoldTable.Rows.Count - 1

                For j = 0 To itemsTable.Rows.Count - 1

                    If itemSoldTable.Rows(i)("item_name") = itemsTable.Rows(j)("item_name") Then

                        totalCost += (Double.Parse(itemSoldTable.Rows(i)("amount")) - (Double.Parse(itemSoldTable.Rows(i)("quantity")) * Double.Parse(itemsTable.Rows(j)("cost"))))

                    End If

                Next

            Next

            Return totalCost.ToString("C")

        Catch ex As Exception

            'MessageBox.Show("An error occured when retrieving the total cost" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace)

        End Try

        Return 0 'incase nag error

    End Function

End Module
