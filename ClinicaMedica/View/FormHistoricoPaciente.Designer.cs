
namespace ClinicaMedica.View
{
    partial class FormHistoricoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoPaciente));
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anotacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPaciente.DisplayMember = "Nome";
            this.comboBoxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(12, 9);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(724, 23);
            this.comboBoxPaciente.TabIndex = 3;
            this.comboBoxPaciente.ValueMember = "Id";
            this.comboBoxPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaciente_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.HorarioConsulta,
            this.NomePaciente,
            this.NomeMedico,
            this.Status,
            this.ID,
            this.HorarioInicio,
            this.HorarioFim,
            this.PacienteId,
            this.MedicoId,
            this.Horario,
            this.Anotacoes,
            this.Medico,
            this.Paciente});
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(725, 559);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.DataPropertyName = "Data";
            this.Data.FillWeight = 20F;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // HorarioConsulta
            // 
            this.HorarioConsulta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HorarioConsulta.DataPropertyName = "HorarioConsulta";
            this.HorarioConsulta.FillWeight = 20F;
            this.HorarioConsulta.HeaderText = "Horário";
            this.HorarioConsulta.Name = "HorarioConsulta";
            this.HorarioConsulta.ReadOnly = true;
            // 
            // NomePaciente
            // 
            this.NomePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomePaciente.DataPropertyName = "NomePaciente";
            this.NomePaciente.FillWeight = 30F;
            this.NomePaciente.HeaderText = "Paciente";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            // 
            // NomeMedico
            // 
            this.NomeMedico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMedico.DataPropertyName = "NomeMedico";
            this.NomeMedico.FillWeight = 30F;
            this.NomeMedico.HeaderText = "Médico";
            this.NomeMedico.Name = "NomeMedico";
            this.NomeMedico.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 20F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "IDOff";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // HorarioInicio
            // 
            this.HorarioInicio.DataPropertyName = "HorarioInicio";
            this.HorarioInicio.HeaderText = "HorarioInicioOff";
            this.HorarioInicio.Name = "HorarioInicio";
            this.HorarioInicio.ReadOnly = true;
            this.HorarioInicio.Visible = false;
            // 
            // HorarioFim
            // 
            this.HorarioFim.DataPropertyName = "HorarioFim";
            this.HorarioFim.HeaderText = "HorarioFimOff";
            this.HorarioFim.Name = "HorarioFim";
            this.HorarioFim.ReadOnly = true;
            this.HorarioFim.Visible = false;
            // 
            // PacienteId
            // 
            this.PacienteId.DataPropertyName = "PacienteId";
            this.PacienteId.HeaderText = "PacienteIdOff";
            this.PacienteId.Name = "PacienteId";
            this.PacienteId.ReadOnly = true;
            this.PacienteId.Visible = false;
            // 
            // MedicoId
            // 
            this.MedicoId.DataPropertyName = "MedicoId";
            this.MedicoId.HeaderText = "MedicoIdOff";
            this.MedicoId.Name = "MedicoId";
            this.MedicoId.ReadOnly = true;
            this.MedicoId.Visible = false;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.FillWeight = 15F;
            this.Horario.HeaderText = "HorárioOff";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Visible = false;
            // 
            // Anotacoes
            // 
            this.Anotacoes.DataPropertyName = "Anotacoes";
            this.Anotacoes.HeaderText = "AnotacoesOff";
            this.Anotacoes.Name = "Anotacoes";
            this.Anotacoes.ReadOnly = true;
            this.Anotacoes.Visible = false;
            // 
            // Medico
            // 
            this.Medico.DataPropertyName = "Medico";
            this.Medico.HeaderText = "MedicoOff";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            this.Medico.Visible = false;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.HeaderText = "PacienteOff";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Visible = false;
            // 
            // FormHistoricoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 607);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistoricoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hitorico Paciente";
            this.Load += new System.EventHandler(this.FormHistoricoPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anotacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
    }
}