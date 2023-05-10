using System;
using System.Collections.Generic;
using System.Text;

namespace LabClases5.Clases
{
    internal class Juego : Jugada
    {
        private int _record;

        public Juego(int maxNumero) : base(maxNumero) 
        {

        }

        public void ComenzarJuego()
        {
            Console.WriteLine("Ingrese un numero Mámimo");
            Jugada j = new Jugada(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Iniciaste un nuevo juego");

        }

        public void PreguntarNumero()
        {
            Console.WriteLine(base.Numero);
        }
    }
}
