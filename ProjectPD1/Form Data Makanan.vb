Imports System.Data.OracleClient

Public Class Formdtmakan
    Dim conn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim da As OracleDataAdapter
    Dim ds As New DataSet
    Dim toping As String

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
        da = New OracleDataAdapter("select * from tbmakanan order by id_makanan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbmakanan")
        DataGridView1.DataSource = (ds.Tables("tbmakanan")).DefaultView
        DataGridView1.ReadOnly = True
    End Sub

    Sub bersihkan()
        txt_namamkn.Text = ""
        txt_idmkn.Text = ""
        txt_jum.Text = ""
        txt_harga.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Formdtmakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call munculdata()
        Call bersihkan()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(3).Width = 70
        DataGridView1.Columns(4).Width = 120
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        Formutama.Show()
        Me.Hide()
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            toping = CheckBox1.Text
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            toping = CheckBox2.Text
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            toping = CheckBox3.Text
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            toping = CheckBox1.Text & " - " & CheckBox2.Text
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True And CheckBox2.Checked = False Then
            toping = CheckBox1.Text & " - " & CheckBox3.Text
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox1.Checked = False Then
            toping = CheckBox2.Text & " - " & CheckBox3.Text
        Else : CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True
            toping = CheckBox1.Text & " - " & CheckBox2.Text & " - " & CheckBox3.Text
        End If
        cmd = New OracleCommand("insert into tbmakanan values ('" & txt_idmkn.Text & "','" & txt_namamkn.Text & "','" & txt_harga.Text & "','" & txt_jum.Text & "','" & toping & "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        Call munculdata()
        Call bersihkan()
    End Sub

    Dim ctr As Control
   
    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        cmd = New OracleCommand("delete tbmakanan where id_makanan='" & txt_idmkn.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus")
        Call munculdata()
        Call bersihkan()
    End Sub

    Private Sub btn_ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubah.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            toping = CheckBox1.Text
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            toping = CheckBox2.Text
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            toping = CheckBox3.Text
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            toping = CheckBox1.Text & " - " & CheckBox2.Text
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True And CheckBox2.Checked = False Then
            toping = CheckBox1.Text & " - " & CheckBox3.Text
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox1.Checked = False Then
            toping = CheckBox2.Text & " - " & CheckBox3.Text
        Else : CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True
            toping = CheckBox1.Text & " - " & CheckBox2.Text & " - " & CheckBox3.Text
        End If
        cmd = New OracleCommand("update tbmakanan set makanan='" & txt_namamkn.Text & "'," & _
"harga='" & txt_harga.Text & "',stock='" & txt_jum.Text & "',topping='" & toping & "'where id_makanan='" & txt_idmkn.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Diubah")
        Call munculdata()
        Call bersihkan()
    End Sub
End Class