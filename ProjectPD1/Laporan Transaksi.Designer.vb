<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Transaksi
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
        Me.crvtransaksi = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvtransaksi
        '
        Me.crvtransaksi.ActiveViewIndex = -1
        Me.crvtransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvtransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvtransaksi.Location = New System.Drawing.Point(0, 0)
        Me.crvtransaksi.Name = "crvtransaksi"
        Me.crvtransaksi.SelectionFormula = ""
        Me.crvtransaksi.Size = New System.Drawing.Size(284, 262)
        Me.crvtransaksi.TabIndex = 0
        Me.crvtransaksi.ViewTimeSelectionFormula = ""
        '
        'Laporan_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.crvtransaksi)
        Me.Name = "Laporan_Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Transaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvtransaksi As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
