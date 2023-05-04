Imports System.Data.OracleClient

Public Class Formdtbahan
    Dim conn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim da As OracleDataAdapter
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

    Sub munculdata()
        Call koneksi()
        da = New OracleDataAdapter("select * from tbl_bahan order by id_bahan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_bahan")
        DataGridView1.DataSource = (ds.Tables("tbl_bahan")).DefaultView
        DataGridView1.ReadOnly = True
    End Sub

    Sub bersihkan()
        txt_namabahan.Text = ""
        txt_idbahan.Text = ""
        txt_jumlah.Text = ""
        txt_hargabhn.Text = ""
        txt_satuan.Text = ""
    End Sub

    Private Sub Formdtbahan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call munculdata()
        Call bersihkan()
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 100
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        Formutama.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_simpan.Click
        cmd = New OracleCommand("insert into tbl_bahan values ('" & txt_idbahan.Text & "','" & txt_namabahan.Text & "','" & txt_jumlah.Text & "','" & txt_hargabhn.Text & "','" & txt_satuan.Text & "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        Call munculdata()
        Call bersihkan()
    End Sub

    Dim ctr As Control

    Private Sub Btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_hapus.Click
        cmd = New OracleCommand("delete tbl_bahan where id_bahan='" & txt_idbahan.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus")
        Call munculdata()
        Call bersihkan()
    End Sub

    Private Sub btn_ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubah.Click
        cmd = New OracleCommand("update tbl_bahan set bahan='" & txt_namabahan.Text & "'," & _
"stock='" & txt_jumlah.Text & "',harga='" & txt_hargabhn.Text & "',satuan='" & txt_satuan.Text & "'where id_bahan='" & txt_idbahan.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diubah")
        Call munculdata()
        Call bersihkan()
    End Sub
End Class