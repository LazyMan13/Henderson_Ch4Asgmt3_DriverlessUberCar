<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDriverlessUberCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDriverlessUberCar))
        Me.picUberCar = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblNumMiles = New System.Windows.Forms.Label()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumMiles = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnDisplayFare = New System.Windows.Forms.Button()
        CType(Me.picUberCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picUberCar
        '
        Me.picUberCar.Image = CType(resources.GetObject("picUberCar.Image"), System.Drawing.Image)
        Me.picUberCar.Location = New System.Drawing.Point(-38, -90)
        Me.picUberCar.Name = "picUberCar"
        Me.picUberCar.Size = New System.Drawing.Size(711, 400)
        Me.picUberCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picUberCar.TabIndex = 0
        Me.picUberCar.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(119, 230)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(399, 40)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Driverless Uber Fare Estimator"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCost.Location = New System.Drawing.Point(119, 285)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(320, 25)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblNumMiles
        '
        Me.lblNumMiles.AutoSize = True
        Me.lblNumMiles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumMiles.Location = New System.Drawing.Point(119, 336)
        Me.lblNumMiles.Name = "lblNumMiles"
        Me.lblNumMiles.Size = New System.Drawing.Size(127, 21)
        Me.lblNumMiles.TabIndex = 3
        Me.lblNumMiles.Text = "Number of Miles"
        '
        'lblTotalText
        '
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalText.Location = New System.Drawing.Point(119, 390)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(113, 21)
        Me.lblTotalText.TabIndex = 4
        Me.lblTotalText.Text = "Total Fare Cost:"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(263, 459)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 39)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(405, 459)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 39)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNumMiles
        '
        Me.txtNumMiles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumMiles.Location = New System.Drawing.Point(405, 333)
        Me.txtNumMiles.Name = "txtNumMiles"
        Me.txtNumMiles.Size = New System.Drawing.Size(100, 29)
        Me.txtNumMiles.TabIndex = 8
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalCost.Location = New System.Drawing.Point(405, 390)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(79, 21)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "$8,888.88"
        '
        'btnDisplayFare
        '
        Me.btnDisplayFare.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDisplayFare.Location = New System.Drawing.Point(119, 459)
        Me.btnDisplayFare.Name = "btnDisplayFare"
        Me.btnDisplayFare.Size = New System.Drawing.Size(113, 39)
        Me.btnDisplayFare.TabIndex = 10
        Me.btnDisplayFare.Text = "Display Fare"
        Me.btnDisplayFare.UseVisualStyleBackColor = True
        '
        'frmDriverlessUberCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 578)
        Me.Controls.Add(Me.btnDisplayFare)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtNumMiles)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotalText)
        Me.Controls.Add(Me.lblNumMiles)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picUberCar)
        Me.Name = "frmDriverlessUberCar"
        Me.Text = "Driverless Uber Car"
        CType(Me.picUberCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picUberCar As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblNumMiles As Label
    Friend WithEvents lblTotalText As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtNumMiles As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDisplayFare As Button
End Class
