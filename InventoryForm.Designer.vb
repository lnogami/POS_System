<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.lblSearchLabel = New System.Windows.Forms.Label()
        Me.panelDGVControlPanel = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDGVControlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInventory
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInventory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvInventory.Location = New System.Drawing.Point(0, 61)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersWidth = 35
        Me.dgvInventory.RowTemplate.Height = 28
        Me.dgvInventory.Size = New System.Drawing.Size(971, 834)
        Me.dgvInventory.TabIndex = 0
        '
        'txtSearchBar
        '
        Me.txtSearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBar.Location = New System.Drawing.Point(121, 13)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(281, 35)
        Me.txtSearchBar.TabIndex = 0
        '
        'lblSearchLabel
        '
        Me.lblSearchLabel.AutoSize = True
        Me.lblSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSearchLabel.Location = New System.Drawing.Point(3, 16)
        Me.lblSearchLabel.Name = "lblSearchLabel"
        Me.lblSearchLabel.Size = New System.Drawing.Size(112, 32)
        Me.lblSearchLabel.TabIndex = 2
        Me.lblSearchLabel.Text = "Search:"
        '
        'panelDGVControlPanel
        '
        Me.panelDGVControlPanel.BackColor = System.Drawing.Color.DarkGray
        Me.panelDGVControlPanel.Controls.Add(Me.btnDelete)
        Me.panelDGVControlPanel.Controls.Add(Me.btnUpdate)
        Me.panelDGVControlPanel.Controls.Add(Me.btnAdd)
        Me.panelDGVControlPanel.Controls.Add(Me.dgvInventory)
        Me.panelDGVControlPanel.Controls.Add(Me.lblSearchLabel)
        Me.panelDGVControlPanel.Controls.Add(Me.txtSearchBar)
        Me.panelDGVControlPanel.Location = New System.Drawing.Point(32, 32)
        Me.panelDGVControlPanel.Name = "panelDGVControlPanel"
        Me.panelDGVControlPanel.Size = New System.Drawing.Size(971, 895)
        Me.panelDGVControlPanel.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(574, 7)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 48)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(706, 7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(126, 48)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!)
        Me.btnAdd.Location = New System.Drawing.Point(838, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 48)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1027, 962)
        Me.Controls.Add(Me.panelDGVControlPanel)
        Me.Name = "InventoryForm"
        Me.Text = "Inventory"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDGVControlPanel.ResumeLayout(False)
        Me.panelDGVControlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents panelDGVControlPanel As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents col_ID As DataGridViewTextBoxColumn
    Friend WithEvents col_ItemName As DataGridViewTextBoxColumn
    Friend WithEvents col_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents col_Price As DataGridViewTextBoxColumn
    Friend WithEvents col_DateAdded As DataGridViewTextBoxColumn
    Friend WithEvents col_AddedBy As DataGridViewTextBoxColumn
    Friend WithEvents col_Stock As DataGridViewTextBoxColumn
    Friend WithEvents col_Sold As DataGridViewTextBoxColumn
    Public WithEvents dgvInventory As DataGridView
    Public WithEvents txtSearchBar As TextBox
End Class
