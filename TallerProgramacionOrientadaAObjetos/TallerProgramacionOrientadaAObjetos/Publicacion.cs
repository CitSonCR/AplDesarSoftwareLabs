using System;
using System.Collections.Generic;
using System.Text;

namespace TallerProgramacionOrientadaAObjetos
{
    public class Publicacion 
    {
        public int Identificador { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }        
        public Usuario Usuario { get; set; }

        public Publicacion()
        {
        }

        public Publicacion(int identificador, string texto, DateTime fecha, Usuario usuario)
        {
            Identificador = identificador;
            Texto = texto;
            Fecha = fecha;
            Usuario = usuario;
        }

        public void MostrarPublicacion(List<Publicacion> publicaciones, List<Comentario> comentarios)
        {
            foreach (var entrada in publicaciones)
            {
                Console.WriteLine("-> Publicacion el " + entrada.Fecha +" Numero identificador: " + entrada.Identificador);
                Console.WriteLine(entrada.Texto);
                Console.WriteLine("Por: " + entrada.Usuario.Nombre + " " + entrada.Usuario.PrimerApellido);
                Console.WriteLine("__________________________________________________________________");
                if (comentarios.Count > 0)
                {
                    
                    foreach (var comentario in comentarios)
                    {
                        if (entrada.Identificador == comentario.Publicacion.Identificador)
                        {
                            Console.WriteLine("-> Comentario el " + comentario.Fecha);
                            Console.WriteLine(comentario.Texto);
                            Console.WriteLine("Por: " + comentario.Usuario.Nombre + " " + comentario.Usuario.PrimerApellido);
                            Console.WriteLine("__________________________________________________________________");
                        }
                    }
                    
                }
            }
        }

        
    }
}
