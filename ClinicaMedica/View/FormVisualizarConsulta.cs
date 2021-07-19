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
    public partial class FormVisualizarConsulta : Form
    {
        private Consulta consultaAtual;

        public FormVisualizarConsulta(Consulta consulta)
        {
            consultaAtual = consulta;
            InitializeComponent();
        }

        private void FormVisualizarConsulta_Load(object sender, EventArgs e)
        {
            if (consultaAtual != null)
            {
                txtNomeMedico.Text = consultaAtual.Medico.Nome;
                txtData.Text = consultaAtual.Data.ToShortDateString();
                txtHoraInicio.Text = consultaAtual.HorarioInicio.ToShortTimeString();
                txtHoraFim.Text = consultaAtual.HorarioFim.ToShortTimeString();
                txtDataNascimento.Text = consultaAtual.Paciente.DataNascimento.ToShortDateString();
                txtNomePaciente.Text = consultaAtual.Paciente.Nome;
                txtTelefone.Text = consultaAtual.Paciente.Telefone;
                txtProfissao.Text = consultaAtual.Paciente.Profissao;
                txtAnotacoes.Text = consultaAtual.Anotacoes;
            }
        }

        private void FormVisualizarConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
