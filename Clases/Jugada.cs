using System;
using System.Collections.Generic;
using System.Text;

namespace LabClases5.Clases
{
    internal class Jugada
    {
        private int _numero;
        private int _intento = 0;
        private string _adivino = "No Adivinado";
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
             this.Numero = rnd.Next(maxNumero);

        }

        public int Numero { get;set; }

        public int Intento { get; set;}

        public string Adivino { get;set; }

        public void Comparar(int num)
        {
            if (this.Numero == num) 
            {
                Console.WriteLine("¡Adivinaste!");
                this.Intento = 0;
                this.Adivino = "Adivinado";
            }
            else
            {
                this.Intento++;
                Console.WriteLine($"No es ese número, ya hiciste {this.Intento} intento/s");


            }
        }

        public void PreguntarMaximo()
        {
            
        }


    }
}
