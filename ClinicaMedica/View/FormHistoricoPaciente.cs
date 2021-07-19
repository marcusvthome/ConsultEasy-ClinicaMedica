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
    public partial class FormHistoricoPaciente : Form
    {
        public FormHistoricoPaciente()
        {
            InitializeComponent();
        }

        private void FormHistoricoPaciente_Load(object sender, EventArgs e)
        {
            List<Paciente> pacientes = PacienteController.Listar();
            comboBoxPaciente.DataSource = pacientes;
        }

        private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consulta item = new Consulta();
            item.Paciente = (Paciente)comboBoxPaciente.SelectedItem;
            List<Consulta> lista = ConsultaController.PesquisarPaciente(item);
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                Consulta item = (Consulta)dataGridView1.SelectedRows[0].DataBoundItem;

                FormVisualizarConsulta frm = new FormVisualizarConsulta(item);
                frm.ShowDialog();
            }
        }
    }
}
