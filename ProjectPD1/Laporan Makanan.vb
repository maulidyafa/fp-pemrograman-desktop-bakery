Imports System.Data.OracleClient

Public Class Laporan_Makanan
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
        rptdoc = New crmakanan
        da = New OracleDataAdapter("select * from tbmakanan order by id_makanan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbmakanan")
        ds.WriteXmlSchema(Application.StartupPath & "\Laporan Makanan.xsd")
        rptdoc.SetDataSource(ds)
        crvmakanan.ReportSource = rptdoc
    End Sub

    Private Sub Laporan_Makanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        munculdata()
    End Sub
End Class