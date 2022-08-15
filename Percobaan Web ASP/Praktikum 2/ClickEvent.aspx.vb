Public Class ClickEvent
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub button_Click(sender As Object, e As EventArgs) Handles button.Click

        Label1.Text = "Hello Yacob"
    End Sub
End Class