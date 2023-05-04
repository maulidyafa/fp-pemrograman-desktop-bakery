Imports System.Data.OracleClient
Public Class Laporan_Bahan
    Dim conn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim da As OracleDataAdapter
    Dim ds As New DataSet
    Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument

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
        rptdoc = New crbahan
        da = New OracleDataAdapter("select * from tbl_bahan order by id_bahan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_bahan")
        ds.WriteXmlSchema(Application.StartupPath & "\Laporan Bahan Baku.xsd")
        rptdoc.SetDataSource(ds)
        crvbahan.ReportSource = rptdoc
    End Sub

    Private Sub Laporan_Bahan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        munculdata()
    End Sub
End Class