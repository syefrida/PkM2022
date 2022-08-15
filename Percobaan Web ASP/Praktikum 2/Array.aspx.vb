Public Class Array
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Declare an array
        Dim drinkList(4) As String
        'Place some items in it
        drinkList(0) = "Water"
        drinkList(1) = "Juice"
        drinkList(2) = "Soda"
        drinkList(3) = "Milk"
        'Access an item in the array by its position
        drinklabel.Text = drinkList(0)
    End Sub

End Class