Imports System.Data.OracleClient

Public Class Laporan_Transaksi
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
        rptdoc = New crtransaksi
        da = New OracleDataAdapter("select * from tbl_transaksi order by nota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_transaksi")
        ds.WriteXmlSchema(Application.StartupPath & "\Laporan Transaksi.xsd")
        rptdoc.SetDataSource(ds)
        crvtransaksi.ReportSource = rptdoc
    End Sub

    Private Sub Laporan_Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        munculdata()
    End Sub
End Class