<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierSideInventory
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
        Me.panelDGVControlPanel = New System.Windows.Forms.Panel()
        Me.dgvCashierSideInventory = New System.Windows.Forms.DataGridView()
        Me.lblSearchLabel = New System.Windows.Forms.Label()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.panelDGVControlPanel.SuspendLayout()
        CType(Me.dgvCashierSideInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDGVControlPanel
        '
        Me.panelDGVControlPanel.BackColor = System.Drawing.Color.DarkGray
        Me.panelDGVControlPanel.Controls.Add(Me.dgvCashierSideInventory)
        Me.panelDGVControlPanel.Controls.Add(Me.lblSearchLabel)
        Me.panelDGVControlPanel.Controls.Add(Me.txtSearchBar)
        Me.panelDGVControlPanel.Location = New System.Drawing.Point(30, 43)
        Me.panelDGVControlPanel.Name = "panelDGVControlPanel"
        Me.panelDGVControlPanel.Size = New System.Drawing.Size(971, 886)
        Me.panelDGVControlPanel.TabIndex = 5
        '
        'dgvCashierSideInventory
        '
        Me.dgvCashierSideInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCashierSideInventory.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCashierSideInventory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCashierSideInventory.Location = New System.Drawing.Point(0, 54)
        Me.dgvCashierSideInventory.Name = "dgvCashierSideInventory"
        Me.dgvCashierSideInventory.RowHeadersVisible = False
        Me.dgvCashierSideInventory.RowHeadersWidth = 35
        Me.dgvCashierSideInventory.RowTemplate.Height = 28
        Me.dgvCashierSideInventory.Size = New System.Drawing.Size(971, 832)
        Me.dgvCashierSideInventory.TabIndex = 0
        '
        'lblSearchLabel
        '
        Me.lblSearchLabel.AutoSize = True
        Me.lblSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSearchLabel.Location = New System.Drawing.Point(3, 12)
        Me.lblSearchLabel.Name = "lblSearchLabel"
        Me.lblSearchLabel.Size = New System.Drawing.Size(112, 32)
        Me.lblSearchLabel.TabIndex = 2
        Me.lblSearchLabel.Text = "Search:"
        '
        'txtSearchBar
        '
        Me.txtSearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBar.Location = New System.Drawing.Point(121, 9)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(306, 35)
        Me.txtSearchBar.TabIndex = 0
        '
        'CashierSideInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1027, 962)
        Me.Controls.Add(Me.panelDGVControlPanel)
        Me.Name = "CashierSideInventory"
        Me.Text = "CashierSideInventory"
        Me.panelDGVControlPanel.ResumeLayout(False)
        Me.panelDGVControlPanel.PerformLayout()
        CType(Me.dgvCashierSideInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelDGVControlPanel As Panel
    Friend WithEvents dgvCashierSideInventory As DataGridView
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents txtSearchBar As TextBox
End Class
