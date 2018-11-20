using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2DiseñoDeAplicaciones;

namespace BusinessLogic
{
    interface IPatientLogic
    {
        List<Patient> GetPatients(string userName);
        List<Patient> GetPatients(string nameFilter, string userName);
        Patient GetById(int id);
        Patient EditPatient(Patient patient);
    }
}
