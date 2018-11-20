using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DiseñoDeAplicaciones
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public string Symptoms { get; set; }
        public List<Test> Tests { get; set; }
        public List<Treatment> Treatment { get; set; }
    }
}
