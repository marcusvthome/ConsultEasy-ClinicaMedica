using ClinicaMedica.Data;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Controller
{
    public class MedicoController
    {
        internal static void Inserir(Medico medico)
        {
            using (DataContext dc = new DataContext())
            {
                dc.TBMedico.Add(medico);
                dc.SaveChanges();
            }
        }

        internal static List<Medico> Listar()
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBMedico.OrderBy(a => a.Nome).ToList();
            }
        }
    }
}
