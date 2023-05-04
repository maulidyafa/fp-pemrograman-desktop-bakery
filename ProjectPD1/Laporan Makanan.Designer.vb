<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Makanan
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
        Me.crvmakanan = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvmakanan
        '
        Me.crvmakanan.ActiveViewIndex = -1
        Me.crvmakanan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvmakanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvmakanan.Location = New System.Drawing.Point(0, 0)
        Me.crvmakanan.Name = "crvmakanan"
        Me.crvmakanan.SelectionFormula = ""
        Me.crvmakanan.Size = New System.Drawing.Size(284, 262)
        Me.crvmakanan.TabIndex = 0
        Me.crvmakanan.ViewTimeSelectionFormula = ""
        '
        'Laporan_Makanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.crvmakanan)
        Me.Name = "Laporan_Makanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Makanan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvmakanan As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
