<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWalkingTour
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
        Me.lblNeededTickets = New System.Windows.Forms.Label()
        Me.txtNeededTickets = New System.Windows.Forms.TextBox()
        Me.lblWelcomeHeader = New System.Windows.Forms.Label()
        Me.lblTicketCost = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotalCostTourLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblBookingCost = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNeededTickets
        '
        Me.lblNeededTickets.AutoSize = True
        Me.lblNeededTickets.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNeededTickets.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNeededTickets.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNeededTickets.Location = New System.Drawing.Point(67, 104)
        Me.lblNeededTickets.Name = "lblNeededTickets"
        Me.lblNeededTickets.Size = New System.Drawing.Size(230, 19)
        Me.lblNeededTickets.TabIndex = 0
        Me.lblNeededTickets.Text = "Number of Tickets Needed: "
        '
        'txtNeededTickets
        '
        Me.txtNeededTickets.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeededTickets.Location = New System.Drawing.Point(294, 100)
        Me.txtNeededTickets.Name = "txtNeededTickets"
        Me.txtNeededTickets.Size = New System.Drawing.Size(42, 26)
        Me.txtNeededTickets.TabIndex = 1
        Me.txtNeededTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWelcomeHeader
        '
        Me.lblWelcomeHeader.AutoSize = True
        Me.lblWelcomeHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWelcomeHeader.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWelcomeHeader.Location = New System.Drawing.Point(59, 26)
        Me.lblWelcomeHeader.Name = "lblWelcomeHeader"
        Me.lblWelcomeHeader.Size = New System.Drawing.Size(307, 25)
        Me.lblWelcomeHeader.TabIndex = 2
        Me.lblWelcomeHeader.Text = "Seattle Walking Tour Tickets"
        '
        'lblTicketCost
        '
        Me.lblTicketCost.AutoSize = True
        Me.lblTicketCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTicketCost.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTicketCost.Location = New System.Drawing.Point(148, 51)
        Me.lblTicketCost.Name = "lblTicketCost"
        Me.lblTicketCost.Size = New System.Drawing.Size(128, 18)
        Me.lblTicketCost.TabIndex = 3
        Me.lblTicketCost.Text = "$14.99 per ticket"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SeattleWealkingTour.My.Resources.Resources.seattle
        Me.PictureBox1.Location = New System.Drawing.Point(403, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblTotalCostTourLabel
        '
        Me.lblTotalCostTourLabel.AutoSize = True
        Me.lblTotalCostTourLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalCostTourLabel.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostTourLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalCostTourLabel.Location = New System.Drawing.Point(87, 140)
        Me.lblTotalCostTourLabel.Name = "lblTotalCostTourLabel"
        Me.lblTotalCostTourLabel.Size = New System.Drawing.Size(156, 19)
        Me.lblTotalCostTourLabel.TabIndex = 5
        Me.lblTotalCostTourLabel.Text = "Total Cost of Tour:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalCost.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalCost.Location = New System.Drawing.Point(249, 140)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(69, 19)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "$888.88"
        '
        'lblBookingCost
        '
        Me.lblBookingCost.AutoSize = True
        Me.lblBookingCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBookingCost.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBookingCost.Location = New System.Drawing.Point(155, 67)
        Me.lblBookingCost.Name = "lblBookingCost"
        Me.lblBookingCost.Size = New System.Drawing.Size(114, 28)
        Me.lblBookingCost.TabIndex = 7
        Me.lblBookingCost.Text = "+ One time booking" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    fee: $1.99"
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(26, 184)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(106, 39)
        Me.btnDisplayCost.TabIndex = 8
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(150, 184)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 39)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(275, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 39)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmWalkingTour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(680, 234)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblBookingCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostTourLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTicketCost)
        Me.Controls.Add(Me.lblWelcomeHeader)
        Me.Controls.Add(Me.txtNeededTickets)
        Me.Controls.Add(Me.lblNeededTickets)
        Me.Name = "frmWalkingTour"
        Me.Text = "Seattle Walking Tour"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNeededTickets As Label
    Friend WithEvents txtNeededTickets As TextBox
    Friend WithEvents lblWelcomeHeader As Label
    Friend WithEvents lblTicketCost As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotalCostTourLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblBookingCost As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
