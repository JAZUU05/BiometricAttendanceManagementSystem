<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class time_sheet_form
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
        Me.time_sheet = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'time_sheet
        '
        Me.time_sheet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.time_sheet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.time_sheet.LocalReport.ReportPath = ""
        Me.time_sheet.Location = New System.Drawing.Point(0, 0)
        Me.time_sheet.Name = "ReportViewer"
        Me.time_sheet.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.time_sheet.ServerReport.BearerToken = Nothing
        Me.time_sheet.Size = New System.Drawing.Size(883, 450)
        Me.time_sheet.TabIndex = 0
        '
        'time_sheet_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 450)
        Me.Controls.Add(Me.time_sheet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "time_sheet_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Sheet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents time_sheet As Microsoft.Reporting.WinForms.ReportViewer
End Class
