Public Class Fungsi
    Inherits System.Web.UI.Page
    'Fungsi yang kita buat
    Function getName() As String
        Return "Hello Word"
    End Function

    'Kita menggunakan Page_Load handler
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = getName()
    End Sub

End Class