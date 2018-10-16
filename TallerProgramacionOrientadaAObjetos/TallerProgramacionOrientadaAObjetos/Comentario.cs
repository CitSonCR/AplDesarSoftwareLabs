using System;
using System.Collections.Generic;
using System.Text;

namespace TallerProgramacionOrientadaAObjetos
{
    public class Comentario
    {
        public int NumeroSeguimiento { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
        public Publicacion Publicacion { get; set; }
        public Usuario Usuario { get; set; }
        public Comentario(int numeroSeguimiento, string texto, DateTime fecha, Publicacion publicacion, Usuario usuario)
        {
            NumeroSeguimiento = numeroSeguimiento;
            Texto = texto;
            Fecha = fecha;
            Publicacion = publicacion;
            Usuario = usuario;
        }

        public Comentario()
        {
        }
    }
}
