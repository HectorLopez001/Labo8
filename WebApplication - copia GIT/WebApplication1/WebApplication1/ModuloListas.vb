Module ModuloListas

    Dim listaAlumnos As List(Of String)
    Dim listaProfesores As List(Of String)

    Public Sub crearListas()
        listaAlumnos = New List(Of String)
        listaProfesores = New List(Of String)
    End Sub

    Public Sub añadirProfesor(ByVal email As String)
        listaProfesores.Add(email)
    End Sub

    Public Function getContadorProfesores()
        Return listaProfesores.Count
    End Function

    Public Function getProfesoresIndice(ByVal i As Integer)
        Return listaProfesores.Item(i)
    End Function

    Public Sub eliminarProfesor(ByVal email As String)
        listaProfesores.Remove(email)
    End Sub


    Public Sub añadirAlumno(ByVal email As String)
        listaAlumnos.Add(email)
    End Sub

    Public Function getContadorAlumnos()
        Return listaAlumnos.Count
    End Function

    Public Function getAlumnosIndice(ByVal i As Integer)
        Return listaAlumnos.Item(i)
    End Function

    Public Sub eliminarAlumno(ByVal email As String)
        listaAlumnos.Remove(email)
    End Sub

End Module
