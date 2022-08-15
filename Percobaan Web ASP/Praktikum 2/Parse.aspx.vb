Public Class Parse
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim intX As Integer
        Dim strY As String = "35"
        intX = strY + 6
        Label1.Text = intX
    End Sub

End Class