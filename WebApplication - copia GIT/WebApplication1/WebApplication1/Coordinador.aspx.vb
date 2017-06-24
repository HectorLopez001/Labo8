Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LabelUsuario.Text = Session("UserID")
    End Sub

    Protected Sub LinkButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles LinkButtonCerrarSesion.Click
        Application("numeroProfesores") = Application("numeroProfesores") - 1
        ModuloListas.eliminarProfesor(Session("UserID"))
        Session.Abandon()
        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("Inicio.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim horas As New WebService1

        GridView1.DataSource = horas.dedicacionesMediasALumnos(DropDownList1.SelectedValue)
        GridView1.DataBind()

    End Sub
End Class