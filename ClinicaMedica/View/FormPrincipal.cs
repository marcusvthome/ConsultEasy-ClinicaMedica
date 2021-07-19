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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripCadastroPaciente_Click(object sender, EventArgs e)
        {
            new FormPacienteInserir().ShowDialog();
        }

        private void toolStripCadastroMedico_Click(object sender, EventArgs e)
        {
            new FormMedicoInserir().ShowDialog();
        }

        private void toolStripAgendarConsulta_Click(object sender, EventArgs e)
        {
            new FormConsultaInserir().ShowDialog();
        }

        private void toolStripAgendaMedico_Click(object sender, EventArgs e)
        {
            new FormConsultasMedico().ShowDialog();
        }

        private void toolStripHitoricoPaciente_Click(object sender, EventArgs e)
        {
            new FormHistoricoPaciente().ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void toolStripConsultasDia_Click(object sender, EventArgs e)
        {
            new FormTodasConsultas().ShowDialog();
        }
    }
}
