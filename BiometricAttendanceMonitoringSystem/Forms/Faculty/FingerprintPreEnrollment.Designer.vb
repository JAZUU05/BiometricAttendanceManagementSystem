<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FingerprintPreEnrollment
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
        Me.pbPicture = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblScannerStatus = New System.Windows.Forms.Label()
        Me.lblScannerStatusLabel = New System.Windows.Forms.Label()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbPicture
        '
        Me.pbPicture.Location = New System.Drawing.Point(281, 12)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(197, 254)
        Me.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPicture.TabIndex = 0
        Me.pbPicture.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(391, 288)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(281, 288)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(12, 12)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(246, 293)
        Me.txtMessage.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblScannerStatus)
        Me.Panel2.Controls.Add(Me.lblScannerStatusLabel)
        Me.Panel2.Location = New System.Drawing.Point(12, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 19)
        Me.Panel2.TabIndex = 36
        '
        'lblScannerStatus
        '
        Me.lblScannerStatus.AutoSize = True
        Me.lblScannerStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblScannerStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScannerStatus.Location = New System.Drawing.Point(67, 0)
        Me.lblScannerStatus.Name = "lblScannerStatus"
        Me.lblScannerStatus.Size = New System.Drawing.Size(80, 19)
        Me.lblScannerStatus.TabIndex = 35
        Me.lblScannerStatus.Text = "Connected"
        Me.lblScannerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScannerStatusLabel
        '
        Me.lblScannerStatusLabel.AutoSize = True
        Me.lblScannerStatusLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblScannerStatusLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScannerStatusLabel.Location = New System.Drawing.Point(0, 0)
        Me.lblScannerStatusLabel.Name = "lblScannerStatusLabel"
        Me.lblScannerStatusLabel.Size = New System.Drawing.Size(67, 19)
        Me.lblScannerStatusLabel.TabIndex = 33
        Me.lblScannerStatusLabel.Text = "Scanner:"
        Me.lblScannerStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FingerprintPreEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pbPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FingerprintPreEnrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FingerprintPreEnrollment"
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbPicture As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblScannerStatus As Label
    Friend WithEvents lblScannerStatusLabel As Label
End Class
