<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeachBikeRental
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picBike = New System.Windows.Forms.PictureBox()
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(79, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(247, 27)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Beach Bike Rentals"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(145, 55)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(114, 20)
        Me.lblCostHeading.TabIndex = 1
        Me.lblCostHeading.Text = "$X.XX per Day"
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDays.Location = New System.Drawing.Point(56, 100)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(192, 21)
        Me.lblNumberOfDays.TabIndex = 2
        Me.lblNumberOfDays.Text = "Number of Rental Days:"
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDays.Location = New System.Drawing.Point(285, 94)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(32, 27)
        Me.txtNumberOfDays.TabIndex = 3
        Me.txtNumberOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(56, 138)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(201, 21)
        Me.lblTotalCostLabel.TabIndex = 4
        Me.lblTotalCostLabel.Text = "Total Cost of Bike Rental:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(281, 138)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(68, 21)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "$888.88"
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.Gold
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(48, 172)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(95, 40)
        Me.btnCost.TabIndex = 7
        Me.btnCost.Text = "Find Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(154, 172)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 40)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gold
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(262, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 40)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picBike
        '
        Me.picBike.Image = Global.beachBikeRental.My.Resources.Resources.bike
        Me.picBike.Location = New System.Drawing.Point(-6, 245)
        Me.picBike.Name = "picBike"
        Me.picBike.Size = New System.Drawing.Size(415, 222)
        Me.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBike.TabIndex = 10
        Me.picBike.TabStop = False
        '
        'frmBeachBikeRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.picBike)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmBeachBikeRental"
        Me.Text = "Beach Bike Rental"
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblNumberOfDays As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents lblTotalCostLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picBike As PictureBox
End Class
