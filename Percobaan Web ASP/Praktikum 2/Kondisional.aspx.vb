Public Class Kondisional
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "Hello") And (RadioButton1.Checked = True) Then
            Response.Redirect("Array.aspx")
        Else
            Response.Redirect("Fungsi.aspx")
        End If
    End Sub
End Class