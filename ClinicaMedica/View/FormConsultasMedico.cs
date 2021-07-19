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
    public partial class FormConsultasMedico : Form
    {
        public FormConsultasMedico()
        {
            InitializeComponent();
        }

        private void FormConsultasMedico_Load(object sender, EventArgs e)
        {
            List<Medico> medicos = MedicoController.Listar();
            comboBoxMedico.DataSource = medicos;

            dateTimePicker1.Value = DateTime.Now.Date;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consulta item = new Consulta();
            item.Medico = (Medico)comboBoxMedico.SelectedItem;
            DateTime dataConsulta = dateTimePicker1.Value;

            List<Consulta> lista = ConsultaController.PesquisarMedico(item, dataConsulta);
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                Consulta item = (Consulta)dataGridView1.SelectedRows[0].DataBoundItem;

                FormExibeConsulta frm = new FormExibeConsulta(item);
                frm.ShowDialog();
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Consulta item = new Consulta();
            item.Medico = (Medico)comboBoxMedico.SelectedItem;
            DateTime dataConsulta = dateTimePicker1.Value;

            List<Consulta> lista = ConsultaController.PesquisarMedico(item, dataConsulta);
            dataGridView1.DataSource = lista;
        }
    }
}
