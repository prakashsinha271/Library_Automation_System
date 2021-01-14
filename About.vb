Public Class About

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "This product is licenced to : " + My.Computer.Name
        Label6.Text = "Copyright - " + Chr(169) + " 2018 PRAKASH SINHA ALL RIGHT RESERVED"
    End Sub

End Class