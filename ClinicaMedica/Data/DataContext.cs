using ClinicaMedica.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1401;Database=ClinicaMedica;User=sa;Password=Senh@123;MultipleActiveResultSets=true");
        }

        public DbSet<Medico> TBMedico { get; set; }

        public DbSet<Paciente> TBPaciente { get; set; }

        public DbSet<Consulta> TBConsulta { get; set; }
    }
}
