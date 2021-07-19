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
    public partial class FormTodasConsultas : Form
    {
        public FormTodasConsultas()
        {
            InitializeComponent();
        }

        private void FormTodasConsultas_Load(object sender, EventArgs e)
        {
            DateTime dataHoje = DateTime.Now.Date;
            List<Consulta> lista = ConsultaController.ListarData(dataHoje);
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                Consulta item = (Consulta)dataGridView1.SelectedRows[0].DataBoundItem;

                FormExibeConsulta frm = new FormExibeConsulta(item);
                frm.ShowDialog();
            }
        }
    }
}
