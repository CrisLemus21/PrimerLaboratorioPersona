using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
        public String Hablar(ClsPersona p)
        {
            return "La persona " + p.Primernombre + " está hablando ";
        }

        public String Caminar(ClsPersona p)
        {
            return "La persona de cabello " + p.Colordecabello + " está caminando";
        }

        public String Reir(ClsPersona p)
        {
            return p.Segundonombre + "se está riendo a carcajadas";
        }

        public String Observar(ClsPersona p)
        {
            return p.Primernombre + " está observando que creció 2 centímetros, ahora mide: " + p.Estatutra + "centímetros";
        }
    }
}
