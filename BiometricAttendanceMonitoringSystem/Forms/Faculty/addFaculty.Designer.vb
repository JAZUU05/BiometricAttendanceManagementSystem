<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addFaculty
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.employeeImage = New System.Windows.Forms.PictureBox()
        Me.btnuploadImage = New System.Windows.Forms.Button()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRightStatus = New System.Windows.Forms.Label()
        Me.lblLeftStatus = New System.Windows.Forms.Label()
        Me.btnAddLeftFingerprint = New System.Windows.Forms.Button()
        Me.btnAddRightFingerprint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.employeeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'employeeImage
        '
        Me.employeeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.employeeImage.Location = New System.Drawing.Point(17, 12)
        Me.employeeImage.Name = "employeeImage"
        Me.employeeImage.Size = New System.Drawing.Size(191, 211)
        Me.employeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.employeeImage.TabIndex = 0
        Me.employeeImage.TabStop = False
        '
        'btnuploadImage
        '
        Me.btnuploadImage.BackColor = System.Drawing.Color.LightGray
        Me.btnuploadImage.FlatAppearance.BorderSize = 0
        Me.btnuploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuploadImage.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnuploadImage.ForeColor = System.Drawing.Color.Black
        Me.btnuploadImage.Location = New System.Drawing.Point(17, 233)
        Me.btnuploadImage.Name = "btnuploadImage"
        Me.btnuploadImage.Size = New System.Drawing.Size(191, 44)
        Me.btnuploadImage.TabIndex = 1
        Me.btnuploadImage.Text = "Upload Image"
        Me.btnuploadImage.UseVisualStyleBackColor = False
        '
        'txtLname
        '
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLname.Location = New System.Drawing.Point(133, 151)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(167, 23)
        Me.txtLname.TabIndex = 4
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.Location = New System.Drawing.Point(133, 74)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(167, 23)
        Me.txtFname.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(17, 290)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(90, 40)
        Me.btnadd.TabIndex = 9
        Me.btnadd.Text = "SAVE"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.LightGray
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cancel.Location = New System.Drawing.Point(118, 289)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(90, 40)
        Me.cancel.TabIndex = 10
        Me.cancel.Text = "CANCEL"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(34, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "LAST NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(31, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "FIRST NAME:"
        '
        'txtMname
        '
        Me.txtMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMname.Location = New System.Drawing.Point(133, 113)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(167, 23)
        Me.txtMname.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(13, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "MIDDLE NAME:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRightStatus)
        Me.GroupBox1.Controls.Add(Me.lblLeftStatus)
        Me.GroupBox1.Controls.Add(Me.btnAddLeftFingerprint)
        Me.GroupBox1.Controls.Add(Me.btnAddRightFingerprint)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 133)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fingerprints"
        '
        'lblRightStatus
        '
        Me.lblRightStatus.AutoSize = True
        Me.lblRightStatus.Location = New System.Drawing.Point(203, 92)
        Me.lblRightStatus.Name = "lblRightStatus"
        Me.lblRightStatus.Size = New System.Drawing.Size(48, 19)
        Me.lblRightStatus.TabIndex = 16
        Me.lblRightStatus.Text = "Empty"
        '
        'lblLeftStatus
        '
        Me.lblLeftStatus.AutoSize = True
        Me.lblLeftStatus.Location = New System.Drawing.Point(203, 47)
        Me.lblLeftStatus.Name = "lblLeftStatus"
        Me.lblLeftStatus.Size = New System.Drawing.Size(48, 19)
        Me.lblLeftStatus.TabIndex = 16
        Me.lblLeftStatus.Text = "Empty"
        '
        'btnAddLeftFingerprint
        '
        Me.btnAddLeftFingerprint.BackColor = System.Drawing.Color.LightGray
        Me.btnAddLeftFingerprint.FlatAppearance.BorderSize = 0
        Me.btnAddLeftFingerprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLeftFingerprint.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddLeftFingerprint.ForeColor = System.Drawing.Color.Black
        Me.btnAddLeftFingerprint.Location = New System.Drawing.Point(38, 36)
        Me.btnAddLeftFingerprint.Name = "btnAddLeftFingerprint"
        Me.btnAddLeftFingerprint.Size = New System.Drawing.Size(149, 39)
        Me.btnAddLeftFingerprint.TabIndex = 15
        Me.btnAddLeftFingerprint.Text = "ADD LEFT"
        Me.btnAddLeftFingerprint.UseVisualStyleBackColor = False
        '
        'btnAddRightFingerprint
        '
        Me.btnAddRightFingerprint.BackColor = System.Drawing.Color.LightGray
        Me.btnAddRightFingerprint.FlatAppearance.BorderSize = 0
        Me.btnAddRightFingerprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRightFingerprint.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddRightFingerprint.ForeColor = System.Drawing.Color.Black
        Me.btnAddRightFingerprint.Location = New System.Drawing.Point(38, 81)
        Me.btnAddRightFingerprint.Name = "btnAddRightFingerprint"
        Me.btnAddRightFingerprint.Size = New System.Drawing.Size(149, 39)
        Me.btnAddRightFingerprint.TabIndex = 15
        Me.btnAddRightFingerprint.Text = "ADD RIGHT"
        Me.btnAddRightFingerprint.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cancel)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btnuploadImage)
        Me.Panel1.Controls.Add(Me.employeeImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 342)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMname)
        Me.GroupBox2.Controls.Add(Me.txtLname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFname)
        Me.GroupBox2.Controls.Add(Me.txtEmployeeID)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(227, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 188)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Information"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeID.Location = New System.Drawing.Point(133, 36)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(167, 23)
        Me.txtEmployeeID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "EMPLOYEE ID:"
        '
        'addFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 342)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addFaculty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Faculty"
        CType(Me.employeeImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents employeeImage As PictureBox
    Friend WithEvents btnuploadImage As Button
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents cancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblRightStatus As Label
    Friend WithEvents lblLeftStatus As Label
    Friend WithEvents btnAddLeftFingerprint As Button
    Friend WithEvents btnAddRightFingerprint As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
