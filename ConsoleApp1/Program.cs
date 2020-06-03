using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, jugador1, jugador2 , i;
            const int MDP = 5000;
            LinkedList<Personaje> personajesJugables = new LinkedList<Personaje>();
            do
            {
                Console.WriteLine("¿Cuántos personajes desea crear? (Al menos 2)");
                cantidad = Convert.ToInt32(Console.ReadLine());
            } while (cantidad < 2);
            for(i=0;i<cantidad;i++)
            {
                personajesJugables.AddLast(new Personaje());
            }
            while(personajesJugables.Count > 1)
            {
                i = 1;
                Console.WriteLine("Elija 2 personajes para el siguiente combate");
                foreach (Personaje pjs in personajesJugables)
                {
                    Console.WriteLine($"{i++}. {pjs.Nombre}");
                }
                Console.WriteLine("Jugador 1");
                jugador1 = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Jugador 2");
                jugador2 = Convert.ToInt32(Console.ReadLine()) - 1;
            }
        }
    }
}
