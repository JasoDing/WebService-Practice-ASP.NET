
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Dim ws As New WebService
        Dim x = ws.HelloWorld()
        lb1.Text = x
    End Sub

    Private Sub lb1_Load(sender As Object, e As EventArgs) Handles lb1.Load
        lb1.Text = " HELLO there !"
    End Sub
End Class
