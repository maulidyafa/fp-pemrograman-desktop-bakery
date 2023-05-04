Public Class Formutama

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DataMakananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataMakananToolStripMenuItem.Click
        Formdtmakan.Show()
        Me.Hide()
    End Sub

    Private Sub DataCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPelangganToolStripMenuItem.Click
        Formdtcustomer.Show()
        Me.Hide()
    End Sub

    Private Sub DataBahanBakuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBahanBakuToolStripMenuItem.Click
        Formdtbahan.Show()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FormAbout.Show()
        Me.Hide()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        Transaksi_Penjualan.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanPengunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPengunaToolStripMenuItem.Click
        Laporan_Customer.Show()
    End Sub

    Private Sub BahanBakuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BahanBakuToolStripMenuItem.Click
        Laporan_Bahan.Show()
    End Sub

    Private Sub MakananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakananToolStripMenuItem.Click
        Laporan_Makanan.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem1.Click
        Laporan_Transaksi.Show()
    End Sub
End Class