using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            string nuevo ;
            Console.WriteLine("ingrese el nombre");
            nuevo = Console.ReadLine();

            Console.WriteLine("ingrese el curso");
            nuevo = Console.ReadLine();

            ServicioMatriculacion matriculador = new ServicioMatriculacion();
            ServicioAlumnado alumno = new ServicioAlumnado();
            matriculador.alta(new Mensajeria());
            matriculador.especial(new Mensajeria());
            matriculador.registra(new Mensajeria());
            alumno.registra(new ServicioAlumnado());
            alumno.nuevoAlumno(new ServicioAlumnado());
        }
    }
}
