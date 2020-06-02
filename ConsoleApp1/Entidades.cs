using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Personaje
    {
       public int velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }
        public int destreza
        {
            get { return destreza;  }
            set { destreza = value; }
        }

        public int fuerza
        {
            get { return fuerza; }
            set { fuerza = value; }
        }

        public int nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public int armadura
        {
            get { return armadura; }
            set { armadura = value; }
        }

    }

    //velocidad;// 1 a 10
    //destreza; //1 a 5
    //fuerza;//1 a 10
    //Nivel; //1 a 10
    //Armadura; //1 a 10
    //Datos:
    //Tipo;
    //Nombre;
    //Apodo;
    //Fecha de Nacimiento;
    //Edad; //entre 0 a 300
    //Salud
    public enum Maximos
    {
        velocidad = 10,
        destreza = 5,
        fuerza = 10,
        nivel = 10,
        armadura = 10,
    }

    public enum Datos
    {
        tipo
    }
}
