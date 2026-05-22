namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;


//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();

    public void Agregar(Alumno alumno)
    {
        _alumnos.Add(alumno.Id, alumno);
    }

    public Dictionary<int, Alumno> ObtenerTodos()
    {
        return _alumnos;
    }
    public Alumno BuscarPorClave(int clave)
    {
        if (_alumnos.ContainsKey(clave))
        {
            return _alumnos[clave];
        }
        return null;
    }

    public void Eliminar(int clave)
    {
        _alumnos.Remove(clave);
    }
}
