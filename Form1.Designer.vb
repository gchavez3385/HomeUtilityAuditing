<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gregory_Chavez_Home_Utility_Auditing_Program
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
        Me.txtCostPerKWH = New System.Windows.Forms.TextBox()
        Me.txtApplianceKWH = New System.Windows.Forms.TextBox()
        Me.txtHoursPerDay = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cboSelectAppliance = New System.Windows.Forms.ComboBox()
        Me.lblSelectAppliance = New System.Windows.Forms.Label()
        Me.lblCostPerKWH = New System.Windows.Forms.Label()
        Me.lblApplianceKWH = New System.Windows.Forms.Label()
        Me.lblHoursPerDay = New System.Windows.Forms.Label()
        Me.lblCalculateDailyCost = New System.Windows.Forms.Label()
        Me.txtDailyCost = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCostPerKWH
        '
        Me.txtCostPerKWH.Location = New System.Drawing.Point(153, 72)
        Me.txtCostPerKWH.Name = "txtCostPerKWH"
        Me.txtCostPerKWH.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPerKWH.TabIndex = 1
        '
        'txtApplianceKWH
        '
        Me.txtApplianceKWH.Location = New System.Drawing.Point(153, 108)
        Me.txtApplianceKWH.Name = "txtApplianceKWH"
        Me.txtApplianceKWH.Size = New System.Drawing.Size(100, 20)
        Me.txtApplianceKWH.TabIndex = 2
        '
        'txtHoursPerDay
        '
        Me.txtHoursPerDay.Location = New System.Drawing.Point(153, 143)
        Me.txtHoursPerDay.Name = "txtHoursPerDay"
        Me.txtHoursPerDay.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursPerDay.TabIndex = 3
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(40, 217)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cboSelectAppliance
        '
        Me.cboSelectAppliance.FormattingEnabled = True
        Me.cboSelectAppliance.Items.AddRange(New Object() {"Refridgerator", "Microwave", "Coffee Maker", "Oven", "Blender"})
        Me.cboSelectAppliance.Location = New System.Drawing.Point(153, 34)
        Me.cboSelectAppliance.Name = "cboSelectAppliance"
        Me.cboSelectAppliance.Size = New System.Drawing.Size(100, 21)
        Me.cboSelectAppliance.TabIndex = 0
        '
        'lblSelectAppliance
        '
        Me.lblSelectAppliance.AutoSize = True
        Me.lblSelectAppliance.Location = New System.Drawing.Point(37, 42)
        Me.lblSelectAppliance.Name = "lblSelectAppliance"
        Me.lblSelectAppliance.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectAppliance.TabIndex = 5
        Me.lblSelectAppliance.Text = "Select Appliance:"
        '
        'lblCostPerKWH
        '
        Me.lblCostPerKWH.AutoSize = True
        Me.lblCostPerKWH.Location = New System.Drawing.Point(37, 79)
        Me.lblCostPerKWH.Name = "lblCostPerKWH"
        Me.lblCostPerKWH.Size = New System.Drawing.Size(80, 13)
        Me.lblCostPerKWH.TabIndex = 6
        Me.lblCostPerKWH.Text = "Cost per k/Wh:"
        '
        'lblApplianceKWH
        '
        Me.lblApplianceKWH.AutoSize = True
        Me.lblApplianceKWH.Location = New System.Drawing.Point(37, 115)
        Me.lblApplianceKWH.Name = "lblApplianceKWH"
        Me.lblApplianceKWH.Size = New System.Drawing.Size(88, 13)
        Me.lblApplianceKWH.TabIndex = 7
        Me.lblApplianceKWH.Text = "Appliance k/Wh:"
        '
        'lblHoursPerDay
        '
        Me.lblHoursPerDay.AutoSize = True
        Me.lblHoursPerDay.Location = New System.Drawing.Point(39, 146)
        Me.lblHoursPerDay.Name = "lblHoursPerDay"
        Me.lblHoursPerDay.Size = New System.Drawing.Size(76, 13)
        Me.lblHoursPerDay.TabIndex = 8
        Me.lblHoursPerDay.Text = "Hours per day:"
        '
        'lblCalculateDailyCost
        '
        Me.lblCalculateDailyCost.AutoSize = True
        Me.lblCalculateDailyCost.Location = New System.Drawing.Point(39, 176)
        Me.lblCalculateDailyCost.Name = "lblCalculateDailyCost"
        Me.lblCalculateDailyCost.Size = New System.Drawing.Size(57, 13)
        Me.lblCalculateDailyCost.TabIndex = 10
        Me.lblCalculateDailyCost.Text = "Daily Cost:"
        '
        'txtDailyCost
        '
        Me.txtDailyCost.Location = New System.Drawing.Point(153, 176)
        Me.txtDailyCost.Name = "txtDailyCost"
        Me.txtDailyCost.Size = New System.Drawing.Size(100, 20)
        Me.txtDailyCost.TabIndex = 11
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(178, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Gregory_Chavez_Home_Utility_Auditing_Program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtDailyCost)
        Me.Controls.Add(Me.lblCalculateDailyCost)
        Me.Controls.Add(Me.lblHoursPerDay)
        Me.Controls.Add(Me.lblApplianceKWH)
        Me.Controls.Add(Me.lblCostPerKWH)
        Me.Controls.Add(Me.lblSelectAppliance)
        Me.Controls.Add(Me.cboSelectAppliance)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtHoursPerDay)
        Me.Controls.Add(Me.txtApplianceKWH)
        Me.Controls.Add(Me.txtCostPerKWH)
        Me.Name = "Gregory_Chavez_Home_Utility_Auditing_Program"
        Me.Text = "Home Utility Auditing Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCostPerKWH As TextBox
    Friend WithEvents txtApplianceKWH As TextBox
    Friend WithEvents txtHoursPerDay As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents cboSelectAppliance As ComboBox
    Friend WithEvents lblSelectAppliance As Label
    Friend WithEvents lblCostPerKWH As Label
    Friend WithEvents lblApplianceKWH As Label
    Friend WithEvents lblHoursPerDay As Label
    Friend WithEvents lblCalculateDailyCost As Label
    Friend WithEvents txtDailyCost As TextBox
    Friend WithEvents btnExit As Button
End Class
