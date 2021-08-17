using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Entidades
{
    class ClsPersona
    {
        private String primernombre;
        private String segundonombre;
        private int edad;
        private String sexo;
        private int nacimiento;
        private int estatura;
        private int peso;
        private String colordecabello;
        private String hablar;

        public string Primernombre { get => primernombre; set => primernombre = value; }
        public string Segundonombre { get => segundonombre; set => segundonombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Nacimiento { get => nacimiento; set => nacimiento = value; }
        public int Estatutra { get => estatura; set => estatura = value; }
        public int Peso { get => peso; set => peso = value; }
        public string Colordecabello { get => colordecabello; set => colordecabello = value; }
        public string Hablar { get => hablar; set => hablar = value; }
    }
}
