using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica.Model
{
    public class Consulta
    {
        public int ID { get; set; }

        public int? PacienteId { get; set; }

        public Paciente Paciente { get; set; }

        public int? MedicoId { get; set; }

        public Medico Medico { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime Horario { get; set; }

        public string Anotacoes { get; set; }

        public StatusConsulta Status { get; set; }

        [NotMapped]
        public string NomeMedico
        {
            get
            {
                if (Medico == null)
                    return "";

                return Medico.Nome;
            }

            set
            {
            }

        }

        [NotMapped]
        public string NomePaciente
        {
            get
            {
                if (Paciente == null)
                    return "";

                return Paciente.Nome;
            }
        }

        [Required]
        public string HorarioConsulta { get; set; }

        [DataType(DataType.Time)]
        public DateTime HorarioInicio { get; set; }

        [DataType(DataType.Time)]
        public DateTime HorarioFim { get; set; }

    }
}
