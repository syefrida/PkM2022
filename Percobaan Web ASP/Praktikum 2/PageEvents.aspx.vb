Public Class PageEvents
    Inherits System.Web.UI.Page

    Private Sub PageEvents_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Label1.Text = "1.Page_Init<br/>"
    End Sub
    Private Sub PageEvents_Load(sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text += "2.Page_Load<br/>"
    End Sub
    Private Sub PageEvents_PreRender(sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        Label1.Text += "3.Page_PreRender<br/>"
    End Sub
    Private Sub PageEvents_Unload(sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Label1.Text += "4.Page_UnLoad<br/>"
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class