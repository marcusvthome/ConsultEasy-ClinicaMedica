
namespace ClinicaMedica.View
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCadastroPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCadastroMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAgendarConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAgendaMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHitoricoPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripConsultasDia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuCadastro,
            this.toolStripMenuConsulta,
            this.toolStripAgenda,
            this.toolStripSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuCadastro
            // 
            this.toolStripMenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCadastroPaciente,
            this.toolStripCadastroMedico});
            this.toolStripMenuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuCadastro.Image")));
            this.toolStripMenuCadastro.Name = "toolStripMenuCadastro";
            this.toolStripMenuCadastro.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuCadastro.Text = "Cadastro";
            // 
            // toolStripCadastroPaciente
            // 
            this.toolStripCadastroPaciente.Image = global::ClinicaMedica.Properties.Resources.cadastropaciente;
            this.toolStripCadastroPaciente.Name = "toolStripCadastroPaciente";
            this.toolStripCadastroPaciente.Size = new System.Drawing.Size(169, 22);
            this.toolStripCadastroPaciente.Text = "Cadastro Paciente";
            this.toolStripCadastroPaciente.Click += new System.EventHandler(this.toolStripCadastroPaciente_Click);
            // 
            // toolStripCadastroMedico
            // 
            this.toolStripCadastroMedico.Image = global::ClinicaMedica.Properties.Resources.cadastromedico;
            this.toolStripCadastroMedico.Name = "toolStripCadastroMedico";
            this.toolStripCadastroMedico.Size = new System.Drawing.Size(169, 22);
            this.toolStripCadastroMedico.Text = "Cadastro Médico";
            this.toolStripCadastroMedico.Click += new System.EventHandler(this.toolStripCadastroMedico_Click);
            // 
            // toolStripMenuConsulta
            // 
            this.toolStripMenuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAgendarConsulta});
            this.toolStripMenuConsulta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuConsulta.Image")));
            this.toolStripMenuConsulta.Name = "toolStripMenuConsulta";
            this.toolStripMenuConsulta.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuConsulta.Text = "Consulta";
            // 
            // toolStripAgendarConsulta
            // 
            this.toolStripAgendarConsulta.Image = global::ClinicaMedica.Properties.Resources.agendarconsulta;
            this.toolStripAgendarConsulta.Name = "toolStripAgendarConsulta";
            this.toolStripAgendarConsulta.Size = new System.Drawing.Size(169, 22);
            this.toolStripAgendarConsulta.Text = "Agendar Consulta";
            this.toolStripAgendarConsulta.Click += new System.EventHandler(this.toolStripAgendarConsulta_Click);
            // 
            // toolStripAgenda
            // 
            this.toolStripAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAgendaMedico,
            this.toolStripHitoricoPaciente,
            this.toolStripConsultasDia});
            this.toolStripAgenda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAgenda.Image")));
            this.toolStripAgenda.Name = "toolStripAgenda";
            this.toolStripAgenda.Size = new System.Drawing.Size(76, 20);
            this.toolStripAgenda.Text = "Agenda";
            // 
            // toolStripAgendaMedico
            // 
            this.toolStripAgendaMedico.Image = global::ClinicaMedica.Properties.Resources.agendamedico;
            this.toolStripAgendaMedico.Name = "toolStripAgendaMedico";
            this.toolStripAgendaMedico.Size = new System.Drawing.Size(170, 22);
            this.toolStripAgendaMedico.Text = "Agenda Médico";
            this.toolStripAgendaMedico.Click += new System.EventHandler(this.toolStripAgendaMedico_Click);
            // 
            // toolStripHitoricoPaciente
            // 
            this.toolStripHitoricoPaciente.Image = global::ClinicaMedica.Properties.Resources.agendapaciente;
            this.toolStripHitoricoPaciente.Name = "toolStripHitoricoPaciente";
            this.toolStripHitoricoPaciente.Size = new System.Drawing.Size(170, 22);
            this.toolStripHitoricoPaciente.Text = "Histórico Paciente";
            this.toolStripHitoricoPaciente.Click += new System.EventHandler(this.toolStripHitoricoPaciente_Click);
            // 
            // toolStripSair
            // 
            this.toolStripSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSair.Image")));
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(54, 20);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // toolStripConsultasDia
            // 
            this.toolStripConsultasDia.Image = global::ClinicaMedica.Properties.Resources.consulta;
            this.toolStripConsultasDia.Name = "toolStripConsultasDia";
            this.toolStripConsultasDia.Size = new System.Drawing.Size(170, 22);
            this.toolStripConsultasDia.Text = "Consultas do Dia";
            this.toolStripConsultasDia.Click += new System.EventHandler(this.toolStripConsultasDia_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaMedica.Properties.Resources.marcadagua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "ConsultEasy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem toolStripCadastroPaciente;
        private System.Windows.Forms.ToolStripMenuItem toolStripCadastroMedico;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuConsulta;
        private System.Windows.Forms.ToolStripMenuItem toolStripAgendarConsulta;
        private System.Windows.Forms.ToolStripMenuItem toolStripAgenda;
        private System.Windows.Forms.ToolStripMenuItem toolStripSair;
        private System.Windows.Forms.ToolStripMenuItem toolStripAgendaMedico;
        private System.Windows.Forms.ToolStripMenuItem toolStripHitoricoPaciente;
        private System.Windows.Forms.ToolStripMenuItem toolStripConsultasDia;
    }
}