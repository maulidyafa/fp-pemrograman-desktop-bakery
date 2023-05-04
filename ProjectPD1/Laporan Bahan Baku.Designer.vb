<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Bahan
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
        Me.crvbahan = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvbahan
        '
        Me.crvbahan.ActiveViewIndex = -1
        Me.crvbahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvbahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvbahan.Location = New System.Drawing.Point(0, 0)
        Me.crvbahan.Name = "crvbahan"
        Me.crvbahan.SelectionFormula = ""
        Me.crvbahan.Size = New System.Drawing.Size(284, 262)
        Me.crvbahan.TabIndex = 0
        Me.crvbahan.ViewTimeSelectionFormula = ""
        '
        'Laporan_Bahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.crvbahan)
        Me.Name = "Laporan_Bahan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Bahan Baku"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvbahan As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
