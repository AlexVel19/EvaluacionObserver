using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ServicioMatriculacion
    {
        public void alta(Matricula nueva)
        {
            Console.WriteLine("En proceso de nueva matricula para: Alex", nueva.Curso, nueva.Alumno);
            (new Mensajeria()).enviaMensajeAlta(nueva.Alumno, nueva.Curso);
            if (nueva.PrimeraMatricula)
            {
                //Envia a servicio de alumnado el nuevo alumno que se esta ingresando
                (new ServicioAlumnado()).nuevoAlumno(nueva.Alumno);
            }
        }

        public List<NuevaMatriculaObserver> observers = new List<NuevaMatriculaObserver> ();
        public virtual void registra(NuevaMatriculaObserver observer)
        {
            //Añade el registro de la matricula a la lista de los observadores           
            observers.Add(observer);
        }
        public virtual void especial (Matricula nueva)
        {

            Console.WriteLine("\nSe creo nueva matricula para: Alex", nueva.Curso, nueva.Alumno);
            foreach (NuevaMatriculaObserver observer in observers)
            {
                observer.nueva(nueva);
            }
        }
    }
}
