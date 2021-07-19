using ClinicaMedica.Data;
using ClinicaMedica.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Controller
{
    public class ConsultaController
    {
        internal static void Salvar(Consulta consulta)
        {
            using (DataContext dc = new DataContext())
            {
                consulta.PacienteId = consulta.Paciente.ID;
                consulta.Paciente = null;

                consulta.MedicoId = consulta.Medico.ID;
                consulta.Medico = null;

                dc.TBConsulta.Add(consulta);
                dc.SaveChanges();
            }
        }

        internal static List<Consulta> ListarData(DateTime dataHoje)
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBConsulta.Where(x => x.Data.Date == dataHoje.Date).Include(n => n.Paciente).Include(n => n.Medico).OrderBy(x => x.Data).OrderBy(x => x.Horario).ToList();
            }
        }

        internal static List<Consulta> Listar()
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBConsulta.Include(n => n.Paciente).Include(n => n.Medico).OrderBy(x => x.Data).OrderBy(x => x.Horario).ToList();
            }
        }

        internal static List<Consulta> PesquisarPaciente(Consulta consulta)
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBConsulta.Include(n => n.Medico).Include(n => n.Paciente).Where(x => x.Paciente.Nome.Contains(consulta.Paciente.Nome)).Where(x => x.Status == StatusConsulta.Finalizado).OrderBy(x => x.Data).OrderBy(x => x.Horario).ToList();
            }
        }

        internal static void Atualizar(Consulta consulta)
        {
            using (DataContext dc = new DataContext())
            {
                dc.TBConsulta.Update(consulta);
                dc.SaveChanges();
            }
        }

        internal static List<Consulta> PesquisarMedico(Consulta consulta, DateTime data)
        {
            using (DataContext dc = new DataContext())
            {
                return dc.TBConsulta.Where(x => x.Data.Date == data.Date).Include(n => n.Medico).Include(n => n.Paciente).Where(x => x.Medico.Nome.Contains(consulta.Medico.Nome)).ToList();
            }

        }
    }
}
