using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DiseñoDeAplicaciones
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoSangre { get; set; }
        public List<Appointment> Appointments { get; set; }
        public int Edad
        {
            get
            {
                return Convert.ToInt16(DateTime.Now - this.FechaNacimiento);
            }     
        }


    }
}
