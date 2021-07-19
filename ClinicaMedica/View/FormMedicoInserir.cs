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
    public partial class FormMedicoInserir : Form
    {
        public FormMedicoInserir()
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

            if (txtEspecialidade.Text.Trim() == "")
            {
                erro = true;
                errorProvider1.SetError(txtEspecialidade, "Campo obrigatório");
            }

            if (txtCRM.Text.Trim() == "")
            {
                erro = true;
                errorProvider1.SetError(txtCRM, "Campo obrigatório");
            }

            if (dateTimePicker1 == null)
            {
                erro = true;
                errorProvider1.SetError(dateTimePicker1, "Campo obrigatório");
            }

            if (erro == false)
            {
                Medico medico = new Medico();
                medico.Nome = txtNome.Text.Trim();
                medico.CRM = int.Parse(txtCRM.Text);
                medico.TempoMedio = dateTimePicker1.Value;
                medico.Especialidade = txtEspecialidade.Text.Trim();

                try
                {
                    MedicoController.Inserir(medico);
                    MessageBox.Show("O médico " + medico.Nome + " foi cadastrado com sucesso!");
                    Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao inserir os dados");
                }
            }
        }

        private void FormMedicoInserir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
