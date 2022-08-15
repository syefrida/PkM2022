Public Class FirstPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dateTimeLabel.Text = DateTime.Now.ToString()
    End Sub

End Class