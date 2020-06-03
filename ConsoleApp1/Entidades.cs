using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Personaje
    {
        private int velocidad, destreza, fuerza, nivel, armadura, edad, salud;
        private string nombre, apodo, tipo;
        private DateTime fechaNac;
        //Características
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        //Datos
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Personaje()
        {
            Random rnd = new Random(Environment.TickCount);
            DateTime hoy = DateTime.Today;
            int opcion;
            string fecha;
            do
            {
                Console.WriteLine("Ingrese el tipo del personaje.");
                mostrarTipos();
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion < 1 || opcion > 7);
            do
            {
                Console.WriteLine("Ingrese el nombre del personaje. (Mínimo 3 caracteres)");
                Nombre = Console.ReadLine();
            } while (Nombre.Length < 3);
            Console.WriteLine("Ingrese el apodo del personaje. (Si no lo ingresa se tomaran los primeros 3 caracteres del nombre)");
            Apodo = Console.ReadLine();
            if (Apodo.Length == 0) Apodo = Nombre.Substring(0,3);
            do
            {
                Console.WriteLine("Ingrese la fecha de nacimiento del personaje. (dd/mm/yyyy)");
                fecha = Console.ReadLine();
            } while (!EsFecha(fecha));
            FechaNac = DateTime.Parse(fecha);
            Edad = hoy.Year - FechaNac.Year + ((hoy.Month < FechaNac.Month || (hoy.Month == FechaNac.Month && hoy.Day < FechaNac.Day)) ? -1 : 0);
            Velocidad = rnd.Next((int)Maximos.velocidad) + 1;
            Destreza = rnd.Next((int)Maximos.destreza) + 1;
            Fuerza = rnd.Next((int)Maximos.fuerza) + 1;
            Nivel = rnd.Next((int)Maximos.nivel) + 1;
            Armadura = rnd.Next((int)Maximos.armadura) + 1;
            Salud = 100;
            Tipo = Enum.GetNames(typeof(Tipos))[opcion-1];
        }

        public void mostrarDatos()
        {
            Console.WriteLine("Datos: \n" +
                                $"Nombre: {Nombre}\n" +
                                $"Apodo: {Apodo}\n" +
                                $"Tipo: {Tipo}\n" +
                                $"Fecha de nacimiento: {FechaNac.ToString("dd/mm/yyyy")}\n" +
                                $"Edad: {Edad}\n");
        }

        public void mostrarCaracteristicas()
        {
            Console.WriteLine("Características:\n" +
                                $"Nivel: {Nivel}" +
                                $"Velocidad: {Velocidad}" +
                                $"Fuerza: {Fuerza}" +
                                $"Destreza: {Destreza}" +
                                $"Armadura: {Armadura}");
        }

        private void mostrarTipos()
        {
            int i = 1;
            foreach (string s in Enum.GetNames(typeof(Tipos)))
            {
                Console.WriteLine($"{i++}. {s}");
            }
        }
        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    public enum Maximos
    {
        velocidad = 10,
        destreza = 5,
        fuerza = 10,
        nivel = 10,
        armadura = 10
    }

    public enum Tipos
    {
        //Diablo 2 expansion
        Amazona,
        Bárbaro,
        Hechicera,
        Nigromante,
        Paladín,
        Asesina,
        Druida
    }
}
