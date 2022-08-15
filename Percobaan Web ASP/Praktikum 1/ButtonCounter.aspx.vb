Public Class ButtonCounter
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim btn As Button = CType(sender, Button)
        btn.Text = (Int32.Parse(btn.Text) + 1).ToString()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim btn As Button = CType(sender, Button)
        btn.Text = (Int32.Parse(btn.Text) + 1).ToString()
    End Sub
End Class