<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackAttendance
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
        Me.components = New System.ComponentModel.Container()
        Me.pbFingerprint = New System.Windows.Forms.PictureBox()
        Me.pbEmployeeImage = New System.Windows.Forms.PictureBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtOut_PM = New System.Windows.Forms.TextBox()
        Me.txtIn_PM = New System.Windows.Forms.TextBox()
        Me.txtOut_AM = New System.Windows.Forms.TextBox()
        Me.txtIn_AM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEmployeeIdLabel = New System.Windows.Forms.Label()
        Me.lblFirstNameLabel = New System.Windows.Forms.Label()
        Me.lblMiddleNameLabel = New System.Windows.Forms.Label()
        Me.lblLastNameLabel = New System.Windows.Forms.Label()
        Me.lblEmployeeId = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbFingerprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmployeeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbFingerprint
        '
        Me.pbFingerprint.Location = New System.Drawing.Point(12, 12)
        Me.pbFingerprint.Name = "pbFingerprint"
        Me.pbFingerprint.Size = New System.Drawing.Size(153, 205)
        Me.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFingerprint.TabIndex = 0
        Me.pbFingerprint.TabStop = False
        '
        'pbEmployeeImage
        '
        Me.pbEmployeeImage.Location = New System.Drawing.Point(676, 12)
        Me.pbEmployeeImage.Name = "pbEmployeeImage"
        Me.pbEmployeeImage.Size = New System.Drawing.Size(153, 205)
        Me.pbEmployeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEmployeeImage.TabIndex = 1
        Me.pbEmployeeImage.TabStop = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldate.Location = New System.Drawing.Point(171, 12)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(188, 21)
        Me.lbldate.TabIndex = 11
        Me.lbldate.Text = "Monday, 10 August 2022"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(540, 12)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(99, 21)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "10:32:00 AM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblMessage, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 336)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(817, 33)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMessage.Location = New System.Drawing.Point(3, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(811, 33)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "MESSAGE"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOut_PM
        '
        Me.txtOut_PM.Enabled = False
        Me.txtOut_PM.Location = New System.Drawing.Point(552, 95)
        Me.txtOut_PM.Name = "txtOut_PM"
        Me.txtOut_PM.ReadOnly = True
        Me.txtOut_PM.Size = New System.Drawing.Size(104, 23)
        Me.txtOut_PM.TabIndex = 20
        '
        'txtIn_PM
        '
        Me.txtIn_PM.Enabled = False
        Me.txtIn_PM.Location = New System.Drawing.Point(437, 95)
        Me.txtIn_PM.Name = "txtIn_PM"
        Me.txtIn_PM.ReadOnly = True
        Me.txtIn_PM.Size = New System.Drawing.Size(93, 23)
        Me.txtIn_PM.TabIndex = 19
        '
        'txtOut_AM
        '
        Me.txtOut_AM.Enabled = False
        Me.txtOut_AM.Location = New System.Drawing.Point(309, 95)
        Me.txtOut_AM.Name = "txtOut_AM"
        Me.txtOut_AM.ReadOnly = True
        Me.txtOut_AM.Size = New System.Drawing.Size(106, 23)
        Me.txtOut_AM.TabIndex = 18
        '
        'txtIn_AM
        '
        Me.txtIn_AM.Enabled = False
        Me.txtIn_AM.Location = New System.Drawing.Point(194, 95)
        Me.txtIn_AM.Name = "txtIn_AM"
        Me.txtIn_AM.ReadOnly = True
        Me.txtIn_AM.Size = New System.Drawing.Size(95, 23)
        Me.txtIn_AM.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(552, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Time out-PM"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(437, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Time in-PM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(309, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Time out-AM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(194, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Time in-AM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblEmployeeIdLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFirstNameLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMiddleNameLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblLastNameLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblEmployeeId, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFirstName, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMiddleName, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblLastName, 1, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(171, 161)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(499, 129)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'lblEmployeeIdLabel
        '
        Me.lblEmployeeIdLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployeeIdLabel.AutoSize = True
        Me.lblEmployeeIdLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEmployeeIdLabel.Location = New System.Drawing.Point(3, 0)
        Me.lblEmployeeIdLabel.Name = "lblEmployeeIdLabel"
        Me.lblEmployeeIdLabel.Size = New System.Drawing.Size(143, 32)
        Me.lblEmployeeIdLabel.TabIndex = 0
        Me.lblEmployeeIdLabel.Text = "Employee ID:"
        Me.lblEmployeeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstNameLabel
        '
        Me.lblFirstNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFirstNameLabel.AutoSize = True
        Me.lblFirstNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFirstNameLabel.Location = New System.Drawing.Point(3, 32)
        Me.lblFirstNameLabel.Name = "lblFirstNameLabel"
        Me.lblFirstNameLabel.Size = New System.Drawing.Size(143, 32)
        Me.lblFirstNameLabel.TabIndex = 0
        Me.lblFirstNameLabel.Text = "First Name"
        Me.lblFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMiddleNameLabel
        '
        Me.lblMiddleNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMiddleNameLabel.AutoSize = True
        Me.lblMiddleNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMiddleNameLabel.Location = New System.Drawing.Point(3, 64)
        Me.lblMiddleNameLabel.Name = "lblMiddleNameLabel"
        Me.lblMiddleNameLabel.Size = New System.Drawing.Size(143, 32)
        Me.lblMiddleNameLabel.TabIndex = 0
        Me.lblMiddleNameLabel.Text = "Middle Name"
        Me.lblMiddleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastNameLabel
        '
        Me.lblLastNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastNameLabel.AutoSize = True
        Me.lblLastNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLastNameLabel.Location = New System.Drawing.Point(3, 96)
        Me.lblLastNameLabel.Name = "lblLastNameLabel"
        Me.lblLastNameLabel.Size = New System.Drawing.Size(143, 33)
        Me.lblLastNameLabel.TabIndex = 0
        Me.lblLastNameLabel.Text = "Last Name"
        Me.lblLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeId
        '
        Me.lblEmployeeId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployeeId.AutoSize = True
        Me.lblEmployeeId.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEmployeeId.Location = New System.Drawing.Point(152, 0)
        Me.lblEmployeeId.Name = "lblEmployeeId"
        Me.lblEmployeeId.Size = New System.Drawing.Size(344, 32)
        Me.lblEmployeeId.TabIndex = 0
        Me.lblEmployeeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstName
        '
        Me.lblFirstName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFirstName.Location = New System.Drawing.Point(152, 32)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(344, 32)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMiddleName
        '
        Me.lblMiddleName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMiddleName.Location = New System.Drawing.Point(152, 64)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(344, 32)
        Me.lblMiddleName.TabIndex = 0
        Me.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLastName.Location = New System.Drawing.Point(152, 96)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(344, 33)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 100)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee ID:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(3, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 42)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Position:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(12, 375)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(90, 40)
        Me.btnLogin.TabIndex = 22
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TimerClock
        '
        Me.TimerClock.Interval = 1000
        '
        'TrackAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 424)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.txtOut_PM)
        Me.Controls.Add(Me.txtIn_PM)
        Me.Controls.Add(Me.txtOut_AM)
        Me.Controls.Add(Me.txtIn_AM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.pbEmployeeImage)
        Me.Controls.Add(Me.pbFingerprint)
        Me.Name = "TrackAttendance"
        Me.Text = "TrackAttendance"
        CType(Me.pbFingerprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmployeeImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbFingerprint As PictureBox
    Friend WithEvents pbEmployeeImage As PictureBox
    Friend WithEvents lbldate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtOut_PM As TextBox
    Friend WithEvents txtIn_PM As TextBox
    Friend WithEvents txtOut_AM As TextBox
    Friend WithEvents txtIn_AM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblEmployeeIdLabel As Label
    Friend WithEvents lblPositionLabel As Label
    Friend WithEvents lblFirstNameLabel As Label
    Friend WithEvents lblMiddleNameLabel As Label
    Friend WithEvents lblLastNameLabel As Label
    Friend WithEvents lblEmployeeId As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimerClock As Timer
End Class
