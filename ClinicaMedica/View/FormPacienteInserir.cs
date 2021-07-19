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
    public partial class FormPacienteInserir : Form
    {
        public FormPacienteInserir()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool erro = false;

            if (txtNome.Text.Trim() == "")
            {
                erro = true;
                errorProvider1.SetError(txtNome, "Campo obrigatório");
            }

            if (dateTimePicker1.Text.Trim() == "")
            {
                erro = true;
                errorProvider1.SetError(dateTimePicker1, "Campo obrigatório");
            }

            if (txtTelefone.Text.Trim() == "")
            {
                erro = true;
                errorProvider1.SetError(txtTelefone, "Campo obrigatório");
            }

            if (txtProfissao.Text.Trim() == "")
            {
                erro = true;
                errorProvider1.SetError(txtProfissao, "Campo obrigatório");
            }

            if(erro == false)
            {
                bool erro1 = false;

                Paciente paciente = new Paciente();
                paciente.Nome = txtNome.Text.Trim();

                if (dateTimePicker1.Value.Date <= DateTime.Now)
                {
                    paciente.DataNascimento = dateTimePicker1.Value.Date;
                }
                else
                {
                    MessageBox.Show("Data de nascimento inválida!");
                    erro1 = true;
                }
                
                paciente.Telefone = txtTelefone.Text.Trim();
                paciente.Profissao = txtProfissao.Text.Trim();

                try
                {
                    if(erro1 == false)
                    {
                        PacienteController.Inserir(paciente);
                        MessageBox.Show("O paciente " + paciente.Nome + " foi cadastrado com sucesso!");
                        Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao inserir os dados");
                }
            }
        }

        private void FormPacienteInserir_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void FormPacienteInserir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
