using System;
using System.Collections.Generic;
using System.Text;

namespace TallerProgramacionOrientadaAObjetos
{
    public class Usuario : Persona
    {
        public string Tipo { get; set; }

        public Usuario(string nombre, string primerApellido, int edad) : base(nombre, primerApellido, edad)
        {

        }


    }
}
