Public Class Alumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        LabelUser.Text = Session("UserID")
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs) Handles LinkButton2.Click
        Application("numeroAlumnos") = Application("numeroAlumnos") - 1
        ModuloListas.eliminarAlumno(Session("UserID"))
        Session.Abandon()
        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("inicio.aspx")
    End Sub

End Class