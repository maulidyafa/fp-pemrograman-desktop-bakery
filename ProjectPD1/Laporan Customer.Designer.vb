<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvcust = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvcust
        '
        Me.crvcust.ActiveViewIndex = -1
        Me.crvcust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvcust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvcust.Location = New System.Drawing.Point(0, 0)
        Me.crvcust.Name = "crvcust"
        Me.crvcust.SelectionFormula = ""
        Me.crvcust.Size = New System.Drawing.Size(343, 282)
        Me.crvcust.TabIndex = 0
        Me.crvcust.ViewTimeSelectionFormula = ""
        '
        'Laporan_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 282)
        Me.Controls.Add(Me.crvcust)
        Me.Name = "Laporan_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvcust As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
