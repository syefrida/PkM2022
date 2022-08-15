Public Class UseClass
    Inherits System.Web.UI.Page

    Protected Sub buttonClass_Click(sender As Object, e As EventArgs) Handles buttonClass.Click
        Dim tes1 As New AddClass
        buttonClass.Text = "Add Methode : " + tes1.Tambah(6, 5).ToString
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class