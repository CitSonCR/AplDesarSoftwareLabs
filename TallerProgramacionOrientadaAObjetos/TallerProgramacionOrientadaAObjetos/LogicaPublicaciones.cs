using System;
using System.Collections.Generic;
using System.Text;

namespace TallerProgramacionOrientadaAObjetos
{
    class LogicaPublicaciones
    {
        string IndContinuar = string.Empty;        
        string Opcion = string.Empty;
        List<Publicacion> publicaciones = new List<Publicacion>();
        List<Comentario> comentarios = new List<Comentario>();

        public void Menu()
        {            
            do
            {
                
                Console.WriteLine("--------Menu publicaciones y comentarios---------");
                Console.WriteLine("Registre sus datos: ");
                Persona persona = new Persona();
                RegistroPersona(persona);
                Usuario usuario = new Usuario(persona.Nombre, persona.PrimerApellido, persona.Edad);
                Console.WriteLine("Tipo de usuario: 1. Editor (E) | 2.Invitado (I)");
                usuario.Tipo = Console.ReadLine().ToUpper();
                RegistroPublicacionesComentarios(usuario);                
                Console.WriteLine("Desea continuar en el programa? (Y/N)");
                IndContinuar = Console.ReadLine();
                
            } while ("Y".Equals(IndContinuar.ToUpper()));
            Environment.Exit(0);
        }

        public void RegistroPersona(Persona persona)
        {
            Console.WriteLine("Nombre: ");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Primer Apellido: ");
            persona.PrimerApellido = Console.ReadLine();
            Console.WriteLine("Edad: ");
            persona.Edad = Convert.ToInt16(Console.ReadLine());
        }

        public void RegistroPublicacionesComentarios(Usuario usuario)
        {
            Publicacion publicacion = new Publicacion();
            if ("E".Equals(usuario.Tipo) || "I".Equals(usuario.Tipo))
            {
                switch (usuario.Tipo)
                {

                    case "E":
                        
                        Console.WriteLine(" A. Nueva publicación, B. Lista de publicaciones");
                        Opcion = Console.ReadLine();
                        if ("A".Equals(Opcion.ToUpper()))
                        {
                            Console.WriteLine("Texto a publicar: ");
                            string texto = Console.ReadLine();                           
                            publicacion.Identificador = publicaciones.Count + 1;
                            publicacion.Texto = texto;
                            publicacion.Fecha = DateTime.Now;
                            publicacion.Usuario = usuario;                            
                            publicaciones.Add(publicacion);
                        }
                        if ("B".Equals(Opcion.ToUpper()))
                        {
                            publicacion.MostrarPublicacion(publicaciones, comentarios);
                        }
                        break;
                    case "I":
                        Comentario comentario = new Comentario();
                        Console.WriteLine("A. Nuevo comentario, B. Lista de publicaciones");
                        Opcion = Console.ReadLine();
                        if ("A".Equals(Opcion.ToUpper()))
                        {
                            publicacion.MostrarPublicacion(publicaciones, comentarios);
                            Console.WriteLine("Digite el identificador de la publicacion a comentar: ");
                            int IndPublicacion = Convert.ToInt16(Console.ReadLine());

                            comentario.NumeroSeguimiento = comentarios.Count + 1;
                            comentario.Publicacion = ObtenerPublicacionPorId(publicaciones, IndPublicacion);
                            Console.WriteLine("Comentario: ");
                            comentario.Texto = Console.ReadLine();                            
                            comentario.Fecha = DateTime.Now;                            
                            comentario.Usuario = usuario;
                            comentarios.Add(comentario);
                        }
                        if ("B".Equals(Opcion.ToUpper()))
                        {
                            publicacion.MostrarPublicacion(publicaciones, comentarios);
                        }
                        break;
                    default:
                        break;
                }
            }
            Opcion = string.Empty;
        }

        public Publicacion ObtenerPublicacionPorId(List<Publicacion> publicaciones, int id)
        {
            foreach (var entrada in publicaciones)
            {
                if (entrada.Identificador == id)
                    return entrada;                                    
            }
            return null;
        }
    }
}
