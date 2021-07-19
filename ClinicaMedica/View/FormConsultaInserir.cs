using ClinicaMedica.Controller;
using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.View
{
    public partial class FormConsultaInserir : Form
    {
        public FormConsultaInserir()
        {
            InitializeComponent();
        }

        private void FormConsultaInserir_Load(object sender, EventArgs e)
        {
            dateTimePickerData.Value = DateTime.Now.Date;
            dateTimePickerHora.Value = DateTime.Now;

            List<Paciente> pacientes = PacienteController.Listar();

            comboBoxPaciente.DataSource = pacientes;

            List<Medico> medicos = MedicoController.Listar();

            comboBoxMedico.DataSource = medicos;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool erro = false;

            if (comboBoxPaciente == null)
            {
                erro = true;
                errorProvider1.SetError(comboBoxPaciente, "Campo obrigatório");
            }

            if (comboBoxMedico == null)
            {
                erro = true;
                errorProvider1.SetError(comboBoxMedico, "Campo obrigatório");
            }

            if (erro == false)
            {
                bool erro2 = false;

                Consulta consulta = new Consulta();
                consulta.Paciente = (Paciente)comboBoxPaciente.SelectedItem;
                consulta.Medico = (Medico)comboBoxMedico.SelectedItem;

                if(dateTimePickerData.Value.Date >= DateTime.Today)
                {
                    consulta.Data = dateTimePickerData.Value;
                }
                else
                {
                    MessageBox.Show("Não é possível agendar uma consulta para uma data passada!");
                    erro2 = true;
                }
                //se a data de hoje e horario < horario agora nao atribui
                if (dateTimePickerData.Value.Date == DateTime.Today && dateTimePickerHora.Value.Hour < DateTime.Now.Hour && dateTimePickerHora.Value.Minute < DateTime.Now.Minute)
                {
                    MessageBox.Show("Não é possível agendar uma consulta para um horário passado!");
                    erro2 = true;
                }
                else
                { 
                    consulta.Horario = dateTimePickerHora.Value;
                    consulta.Horario = consulta.Horario.AddSeconds(-(consulta.Horario.Second));
                }
                
                consulta.Status = StatusConsulta.Agendado;

                consulta.HorarioConsulta = consulta.Horario.ToShortTimeString();

                List<Consulta> consultas = ConsultaController.Listar();

                foreach (Consulta item in consultas)
                {
                    if (consulta.Medico.ID == item.MedicoId)
                    {
                        if (consulta.Data.Date == item.Data.Date)
                        {
                            if (consulta.Horario == item.Horario)
                            {
                                MessageBox.Show("Já possui uma consulta agendada para este horário!");
                                erro2 = true;
                                break;
                            } //se o horario for igual
                            
                            //se 22:35 > 22:15 e 22:35 < 22:35
                            else if (consulta.Horario > item.Horario.AddMinutes(-(consulta.Medico.TempoMedio.Minute)) && consulta.Horario < item.Horario)
                            {
                                MessageBox.Show("Já possui uma consulta agendada para este horário! Tente " + consulta.Medico.TempoMedio.Minute + " minutos antes, ou " + consulta.Medico.TempoMedio.Minute + " minutos depois deste horário!");
                                erro2 = true;
                                break;
                            }

                            //se 23:05 > 22:55 e 23:05 < 23:05 (22:55 + 10) )
                            //se 23:15 > 23:05 e 23:15 < 23:15 (23:05 + 10) )
                            //se 22:35 > 22:45 e 22:35 < 22:55
                            //se 22:35 > 22:25 e 22:35 < 22:35
                            else if (consulta.Horario > item.Horario && consulta.Horario < item.Horario.AddMinutes(consulta.Medico.TempoMedio.Minute))
                            {
                                MessageBox.Show("Já possui uma consulta agendada para este horário! Tente " + consulta.Medico.TempoMedio.Minute + " minutos antes, ou " + consulta.Medico.TempoMedio.Minute + " minutos depois deste horário!");
                                erro2 = true;
                                break;
                            } 
                        }
                    }
                    
                }

                if(erro2 == false)
                {
                    ConsultaController.Salvar(consulta);
                    MessageBox.Show("A consulta foi agendada com sucesso!");
                    Close();
                }
                
            }
        }

        private void FormConsultaInserir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
    }
}