namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        Alumno a1 = new Alumno(1, "Juan", 8.5);
        Alumno a2 = new Alumno(2, "Maria", 9.0);
        Alumno a3 = new Alumno(3, "Pedro", 7.5);

        lista.Agregar(a1);
        lista.Agregar(a2);
        lista.Agregar(a3);

        Console.WriteLine("=== Lista de alumnos ===");
        foreach (Alumno a in lista.ObtenerTodos())
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("\n=== Buscar alumno ===");

        Alumno encontrado = lista.BuscarPorNombre("Juan");
        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n=== Eliminar alumno ===");
        lista.Eliminar(a2);
        foreach (Alumno a in lista.ObtenerTodos())
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("\n=== Eliminar primer elemento ===");
        lista.EliminarEnPosicion(0);
        foreach (Alumno a in lista.ObtenerTodos())
        {
            Console.WriteLine(a);
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Juan", 8.5);
        Alumno a2 = new Alumno(2, "Maria", 9.0);
        Alumno a3 = new Alumno(3, "Pedro", 7.5);

        diccionario.Agregar(a1);
        diccionario.Agregar(a2);
        diccionario.Agregar(a3);

        Console.WriteLine("=== Lista de alumnos ===");
        foreach (KeyValuePair<int, Alumno> par in diccionario.ObtenerTodos())
        {
            Console.WriteLine(par.Value);
        }

        Console.WriteLine("\n=== Buscar alumno ===");

        Alumno encontrado = diccionario.BuscarPorClave(1);
        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Alumno noExiste = diccionario.BuscarPorClave(99);
        if (noExiste != null)
        {
            Console.WriteLine(noExiste);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n=== Eliminar alumno ===");
        diccionario.Eliminar(2);
        foreach (KeyValuePair<int, Alumno> par in diccionario.ObtenerTodos())
        {
            Console.WriteLine(par.Value);
        }

    }


    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
