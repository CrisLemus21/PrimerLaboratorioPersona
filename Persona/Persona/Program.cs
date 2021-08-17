using Persona.Entidades;
using Persona.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona clspersona = new ClsPersona();
            NClsPersona nclspersona = new NClsPersona();

            clspersona.Primernombre = "Martin";

            Console.WriteLine(nclspersona.Hablar(clspersona));
            Console.ReadLine(); 
     

        }
    }
}
