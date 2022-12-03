<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.dateTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbAddFaculty = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbAbout = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addUser = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbAttendanceList = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbFacultyList = New System.Windows.Forms.PictureBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pbAddFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttendanceList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFacultyList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateTime
        '
        Me.dateTime.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbAddFaculty)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.pbAbout)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.addUser)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.pbAttendanceList)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.pbFacultyList)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 235)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(135, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ADD FACULTY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbAddFaculty
        '
        Me.pbAddFaculty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbAddFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAddFaculty.Image = Global.BiometricAttendanceMonitoringSystem.My.Resources.Resources.working
        Me.pbAddFaculty.Location = New System.Drawing.Point(135, 86)
        Me.pbAddFaculty.Name = "pbAddFaculty"
        Me.pbAddFaculty.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.pbAddFaculty.Size = New System.Drawing.Size(121, 73)
        Me.pbAddFaculty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAddFaculty.TabIndex = 31
        Me.pbAddFaculty.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(842, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 21)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "ABOUT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbAbout
        '
        Me.pbAbout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAbout.Image = Global.BiometricAttendanceMonitoringSystem.My.Resources.Resources.about
        Me.pbAbout.Location = New System.Drawing.Point(813, 86)
        Me.pbAbout.Name = "pbAbout"
        Me.pbAbout.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.pbAbout.Size = New System.Drawing.Size(121, 73)
        Me.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAbout.TabIndex = 43
        Me.pbAbout.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(653, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "MANAGE USER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addUser
        '
        Me.addUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addUser.Image = Global.BiometricAttendanceMonitoringSystem.My.Resources.Resources.add_group
        Me.addUser.Location = New System.Drawing.Point(652, 86)
        Me.addUser.Name = "addUser"
        Me.addUser.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.addUser.Size = New System.Drawing.Size(121, 73)
        Me.addUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addUser.TabIndex = 41
        Me.addUser.TabStop = False
        Me.addUser.WaitOnLoad = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(463, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "ATTENDANCE LIST"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbAttendanceList
        '
        Me.pbAttendanceList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbAttendanceList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbAttendanceList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAttendanceList.Image = Global.BiometricAttendanceMonitoringSystem.My.Resources.Resources.calendar
        Me.pbAttendanceList.Location = New System.Drawing.Point(474, 86)
        Me.pbAttendanceList.Name = "pbAttendanceList"
        Me.pbAttendanceList.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.pbAttendanceList.Size = New System.Drawing.Size(121, 73)
        Me.pbAttendanceList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAttendanceList.TabIndex = 39
        Me.pbAttendanceList.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(304, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "FACULTY LIST"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbFacultyList
        '
        Me.pbFacultyList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbFacultyList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFacultyList.Image = Global.BiometricAttendanceMonitoringSystem.My.Resources.Resources.man
        Me.pbFacultyList.Location = New System.Drawing.Point(304, 86)
        Me.pbFacultyList.Name = "pbFacultyList"
        Me.pbFacultyList.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.pbFacultyList.Size = New System.Drawing.Size(121, 73)
        Me.pbFacultyList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFacultyList.TabIndex = 35
        Me.pbFacultyList.TabStop = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(14, 29)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(128, 30)
        Me.lbldate.TabIndex = 34
        Me.lbldate.Text = "05:14:00 PM"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(972, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 30)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "LOGOUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1089, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbAddFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttendanceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFacultyList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dateTime As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pbAddFaculty As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pbAbout As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents addUser As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbAttendanceList As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pbFacultyList As PictureBox
    Friend WithEvents lbldate As Label
    Friend WithEvents Button1 As Button
End Class
