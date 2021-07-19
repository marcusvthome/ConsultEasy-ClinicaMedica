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
    public partial class FormExibeConsulta : Form
    {
        private Consulta consultaAtual;

        public FormExibeConsulta(Consulta consulta)
        {
            consultaAtual = consulta;
            InitializeComponent();
        }

        private void FormExibeConsulta_Load(object sender, EventArgs e)
        {
            if (consultaAtual != null)
            {
                txtNomeMedico.Text = consultaAtual.Medico.Nome;
                txtData.Text = consultaAtual.Data.ToShortDateString();
                txtHora.Text = consultaAtual.Horario.ToShortTimeString();
                txtDataNascimento.Text = consultaAtual.Paciente.DataNascimento.ToShortDateString();
                txtNomePaciente.Text = consultaAtual.Paciente.Nome;
                txtTelefone.Text = consultaAtual.Paciente.Telefone;
                txtProfissao.Text = consultaAtual.Paciente.Profissao;
                txtAnotacoes.Text = consultaAtual.Anotacoes;
            }

            if (consultaAtual.Status == StatusConsulta.Consultando)
            {
                txtAnotacoes.ReadOnly = false;
            }
        }

        private void btnIniciarConsulta_Click(object sender, EventArgs e)
        {
            if (consultaAtual.Status != StatusConsulta.Finalizado)
            {
                txtAnotacoes.ReadOnly = false;
                consultaAtual.Status = StatusConsulta.Consultando;
                consultaAtual.HorarioInicio = DateTime.Now;

                ConsultaController.Atualizar(consultaAtual);
            }
            else
            {
                MessageBox.Show("Essa consulta não pode ser iniciada pois já foi realizada!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEncerrarConsulta_Click(object sender, EventArgs e)
        {
            consultaAtual.Status = StatusConsulta.Finalizado;
            consultaAtual.Anotacoes = txtAnotacoes.Text;
            consultaAtual.HorarioFim = DateTime.Now;

            ConsultaController.Atualizar(consultaAtual);
            Close();
        }

        private void FormExibeConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
