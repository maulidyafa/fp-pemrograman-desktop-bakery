Imports System.Data.OracleClient

Public Class Transaksi_Penjualan
    Dim conn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim da As OracleDataAdapter
    Dim dr As OracleDataReader
    Dim ds As New DataSet

    Sub koneksi()
        conn.Close()
        conn = New OracleConnection("data source =(DESCRIPTION = " & _
    "(ADDRESS = (PROTOCOL = TCP)(HOST = owner-PC)(PORT = 1521)) " & _
    "(CONNECT_DATA = " & _
      "(SERVER = DEDICATED) " & _
      "(SERVICE_NAME = XE) " & _
    ") " & _
  ") ; user id=hr; password=hr;")
        conn.Open()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        labeljam.Text = TimeOfDay
    End Sub

    Sub kondisiawal()
        txt_nmcust.Text = ""
        txt_nota.Text = ""
        labeltgl.Text = Today
        txt_namamkn.Text = ""
        txt_harga.Text = ""
        txt_jumlah.Text = ""
        comb_idcust.Text = ""
        comb_idmkn.Text = ""
        txt_bayar.Text = ""
        txt_kembalian.Text = ""
    End Sub

    Sub munculdata()
        Call koneksi()
        da = New OracleDataAdapter("select * from tbl_transaksi order by nota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_transaksi")
        DataGridView1.DataSource = (ds.Tables("tbl_transaksi")).DefaultView
        DataGridView1.ReadOnly = True
    End Sub

    Sub munculdatacustomer()
        Call koneksi()
        cmd = New OracleCommand("select * from tbl_cust order by id_cust", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                comb_idcust.Items.Add(dr(0))
            Loop
        End If
    End Sub

    Sub munculdatamakanan()
        Call koneksi()
        cmd = New OracleCommand("select * from tbmakanan order by id_makanan", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                comb_idmkn.Items.Add(dr(0))
            Loop
        End If
    End Sub

    Private Sub Transaksi_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call munculdata()
        Call kondisiawal()
        Call munculdatacustomer()
        Call munculdatamakanan()
        Label6.Text = "0"
    End Sub

    Private Sub comb_idcust_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comb_idcust.SelectedIndexChanged
        Call koneksi()
        cmd = New OracleCommand("select * from tbl_cust where id_cust ='" & comb_idcust.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txt_nmcust.Text = dr.Item(1)
        End If
    End Sub

    Private Sub comb_idmkn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comb_idmkn.SelectedIndexChanged
        Call koneksi()
        cmd = New OracleCommand("select * from tbmakanan where id_makanan ='" & comb_idmkn.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txt_namamkn.Text = dr.Item(1)
            txt_harga.Text = dr.Item(2)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        Formutama.Show()
        Me.Hide()
    End Sub

    Private Sub txt_bayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_bayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txt_bayar.Text) < Val(Label6.Text) Then
                MsgBox("Pembayaran Kurang!")
            ElseIf Val(txt_bayar.Text) = Val(Label6.Text) Then
                txt_kembalian.Text = 0
            ElseIf Val(txt_bayar.Text) > Val(Label6.Text) Then
                txt_kembalian.Text = Val(txt_bayar.Text) - Val(Label6.Text)
            End If
        End If
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        cmd = New OracleCommand("insert into tbl_transaksi values ('" & txt_nota.Text & "','" & labeltgl.Text & "','" & comb_idcust.Text & "','" & txt_nmcust.Text & "','" & txt_namamkn.Text & "','" & txt_harga.Text & "','" & txt_jumlah.Text & "','" & Label6.Text & "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        Call munculdata()
        Call kondisiawal()
    End Sub

    Private Sub btninput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninput.Click
        Label6.Text = Val(txt_harga.Text) * Val(txt_jumlah.Text)
    End Sub

    Private Sub btn_ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubah.Click
        cmd = New OracleCommand("update tbl_transaksi set tanggal='" & labeltgl.Text & "'," & _
"id_cust='" & comb_idcust.Text & "',nama='" & txt_nmcust.Text & "',makanan='" & txt_namamkn.Text & "',harga='" & txt_harga.Text & "',jumlah='" & txt_jumlah.Text & "',total='" & Label6.Text & "'where nota='" & txt_nota.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diubah")
        Call munculdata()
        Call kondisiawal()
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        cmd = New OracleCommand("delete tbl_transaksi where nota='" & txt_nota.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus")
        Call munculdata()
        Call kondisiawal()
    End Sub
End Class

