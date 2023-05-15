using System;
using System.Collections.Generic;
using System.Text;

namespace LabClases5.Clases
{
    internal class Juego : Jugada
    {
        private int _record;
        private Jugada _jugada;

        public Juego(int maxNumero) : base(maxNumero) 
        {
            
        }

        public Jugada ComenzarJuego()
        {
            while (this.Continuar())
            {
                _jugada = new Jugada(this.PreguntarMaximo());
                Console.WriteLine("Iniciaste un nuevo juego");
                _jugada.Comparar(this.PreguntarNumero());
                this.CompararRecord();
                this.Continuar();
            }
            Console.WriteLine("Adios");
            Console.ReadKey();
        }

        public int PreguntarNumero()
        {
            Console.WriteLine("Elija un número");
            int i = Int32.Parse(Console.ReadLine());

            return i;
        }

        public void CompararRecord()
        {
            if (_jugada.Intento == _record)
            {
                Console.WriteLine("Igualaste el record");
            }
            if (_jugada.Intento > _record)
            {
                Console.WriteLine("Nuevo record de Intentos");
                _jugada.Intento = _record;
            } 
            else
            {
                Console.WriteLine("No superaste el record de intentos");
            }
        }

        public int PreguntarMaximo()
        {
            Console.WriteLine("Ingrese un numero Máximo");
            int max = Int32.Parse(Console.ReadLine());
            return max
        }

        public bool Continuar()
        {
            Console.WriteLine("¿Desea continuar jugando? Ingrese S o N");
            string rta = Console.ReadLine();
            rta.ToUpper();
            if (rta == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
