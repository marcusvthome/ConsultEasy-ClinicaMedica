using ClinicaMedica.Data;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Controller
{
    public class PacienteController
    {
        internal static void Inserir(Paciente paciente)
        {
            using (DataContext dc = new DataContext())
            {
                dc.TBPaciente.Add(paciente);
                dc.SaveChanges();
            }
        }

        internal static List<Paciente> Listar()
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBPaciente.OrderBy(a => a.Nome).ToList();
            }
        }
    }
}
