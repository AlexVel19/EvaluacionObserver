using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Mensajeria : Matricula, NuevaMatriculaObserver
    {
        public void nueva(Matricula nueva)
        {
            //Muestra el mensaje a los observadores que se ha matriculado un nuevo estudiante
            Console.Write("El alumno Alex"+nueva.Alumno+ " se ha matriculado en cuarto "+ nueva.Curso);

        }

        internal void enviaMensajeAlta(string alumno, string curso)
        {
            //Envia mensaje notificando que se ha matriculado
            Console.Write("Grandioso! Alex"+Alumno+" te has matriculado en cuarto"+Curso);
        }
    }
}
