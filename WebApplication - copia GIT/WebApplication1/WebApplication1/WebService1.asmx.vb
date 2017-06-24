Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function dedicacionesMediasALumnos(ByVal asignatura As String) As DataSet

        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Server=tcp:serverhector.database.windows.net,1433; Initial Catalog=BaseDatos; Persist Security Info=False;" +
        +"User ID=hector@serverhector; Password=kukorules009*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        conexion.Open()

        Dim da As New SqlDataAdapter("SELECT (sum(EstudiantesTareas.HReales)/count(EstudiantesTareas.HReales)) as media FROM EstudiantesTareas" +
        +"INNER JOIN TareasGenericas ON TareasGenericas.Codigo = EstudiantesTareas.CodTarea WHERE TareasGenericas.CodAsig='" & asignatura & "'", conexion)
        Dim ds As New DataSet
        da.Fill(ds, "Users")

        conexion.Close()

        Return ds
    End Function

End Class