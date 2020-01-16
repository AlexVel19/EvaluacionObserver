using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ServicioAlumnado
    {
        internal void nuevoAlumno(string alumno)
        {
            Console.Write("Nuevo Alumno ¡Enhorabuena Alex, te has matriculado correctamente.");
        }

        internal void registra(ServicioAlumnado servicioAlumnado)
        {
            Console.WriteLine("Nuevo Registro ¡Enhorabuena Alex, te has matriculado correctamente.");            
        }

        internal void nuevoAlumno(ServicioAlumnado servicioAlumnado)
        {
            Console.WriteLine("Nuevo notificacion Alex, te has matriculado correctamente");
        }
    }
}
