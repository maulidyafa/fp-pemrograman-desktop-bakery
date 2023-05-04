Imports System.Data.OracleClient

Public Class Formdtcustomer
    Dim conn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim da As OracleDataAdapter
    Dim ds As New DataSet
    Dim gender As String

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
        da = New OracleDataAdapter("select * from tbl_cust order by id_cust", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_cust")
        DataGridView1.DataSource = (ds.Tables("tbl_cust")).DefaultView
        DataGridView1.ReadOnly = True
    End Sub

    Sub bersihkan()
        txt_idcust.Text = ""
        txt_namacust.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txt_telp.Text = ""
        txt_alamat.Text = ""
    End Sub

    Private Sub Formdtcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call munculdata()
        Call bersihkan()
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(3).Width = 120
        DataGridView1.Columns(4).Width = 200
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        Formutama.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        If RadioButton1.Checked = True Then
            gender = RadioButton1.Text
        Else : RadioButton2.Checked = True
            gender = RadioButton2.Text
        End If
        cmd = New OracleCommand("insert into tbl_cust values ('" & txt_idcust.Text & "','" & txt_namacust.Text & "','" & gender & "','" & txt_telp.Text & "','" & txt_alamat.Text & "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        Call munculdata()
        Call bersihkan()
    End Sub

    Dim ctr As Control

    Private Sub Btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_hapus.Click
        cmd = New OracleCommand("delete tbl_cust where id_cust='" & txt_idcust.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus")
        Call munculdata()
        Call bersihkan()
    End Sub

    Private Sub btn_ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubah.Click
        If RadioButton1.Checked = True Then
            gender = RadioButton1.Text
        Else : RadioButton2.Checked = True
            gender = RadioButton2.Text
        End If
        cmd = New OracleCommand("update tbl_cust set nama='" & txt_namacust.Text & "'," & _
"gender='" & gender & "',telp='" & txt_telp.Text & "',alamat='" & txt_alamat.Text & "'where id_cust='" & txt_idcust.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diubah")
        Call munculdata()
        Call bersihkan()
    End Sub
End Class