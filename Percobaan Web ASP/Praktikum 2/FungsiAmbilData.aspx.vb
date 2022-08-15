Public Class FungsiAmbilData
    Inherits System.Web.UI.Page
    Function Tambah(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Tambah(5, 2).ToString
    End Sub

End Class