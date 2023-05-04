Public Class FormAbout

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        Formutama.Show()
        Me.Hide()
    End Sub
End Class