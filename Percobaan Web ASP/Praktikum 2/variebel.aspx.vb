Public Class variebel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim carType As String = "BMW"
        Label1.Text = carType
    End Sub

End Class