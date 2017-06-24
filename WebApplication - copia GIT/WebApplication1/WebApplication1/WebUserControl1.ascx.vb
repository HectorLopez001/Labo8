Public Class WebUserControl1
    Inherits System.Web.UI.UserControl

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        LabelProfesoresLogueados.Text = Application("numeroProfesores")
        ListBoxProfesores.Items.Clear()
        For i As Integer = 0 To ModuloListas.getContadorProfesores - 1
            ListBoxProfesores.Items.Add(ModuloListas.getProfesoresIndice(i))
        Next

        LabelAlumnosLogueados.Text = Application("numeroAlumnos")
        ListBoxAlumnos.Items.Clear()
        For i As Integer = 0 To ModuloListas.getContadorAlumnos - 1
            ListBoxAlumnos.Items.Add(ModuloListas.getAlumnosIndice(i))
        Next
    End Sub

End Class