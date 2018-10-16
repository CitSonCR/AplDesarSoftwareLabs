using System;
using System.Collections.Generic;
using System.Text;

namespace TallerProgramacionOrientadaAObjetos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string primerApellido, int edad)
        {
            Nombre = nombre;
            PrimerApellido = primerApellido;
            Edad = edad;
        }

        public Persona()
        {
        }
    }
}
