namespace AplicacionCongreso
{
    partial class frmasistencia
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
            this.dgvParticipante = new System.Windows.Forms.DataGridView();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.tbParticipante = new System.Windows.Forms.TextBox();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.participanteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreParticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoParticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbLectora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLectora = new System.Windows.Forms.Button();
            this.lblEvento = new System.Windows.Forms.Label();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipante
            // 
            this.dgvParticipante.AllowUserToAddRows = false;
            this.dgvParticipante.AllowUserToDeleteRows = false;
            this.dgvParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipante.Location = new System.Drawing.Point(12, 119);
            this.dgvParticipante.Name = "dgvParticipante";
            this.dgvParticipante.ReadOnly = true;
            this.dgvParticipante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipante.Size = new System.Drawing.Size(369, 263);
            this.dgvParticipante.TabIndex = 1;
            this.dgvParticipante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipante_CellContentClick);
            // 
            // lblParticipante
            // 
            this.lblParticipante.AutoSize = true;
            this.lblParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipante.Location = new System.Drawing.Point(18, 15);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Size = new System.Drawing.Size(112, 24);
            this.lblParticipante.TabIndex = 2;
            this.lblParticipante.Text = "Participante:";
            // 
            // tbParticipante
            // 
            this.tbParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParticipante.Location = new System.Drawing.Point(143, 16);
            this.tbParticipante.Name = "tbParticipante";
            this.tbParticipante.Size = new System.Drawing.Size(274, 29);
            this.tbParticipante.TabIndex = 3;
            this.tbParticipante.TextChanged += new System.EventHandler(this.tbParticipante_TextChanged);
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.AllowUserToDeleteRows = false;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.participanteID,
            this.nombreParticipante,
            this.apellidoParticipante});
            this.dgvAsistencia.Location = new System.Drawing.Point(468, 119);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.ReadOnly = true;
            this.dgvAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistencia.Size = new System.Drawing.Size(369, 263);
            this.dgvAsistencia.TabIndex = 4;
            // 
            // participanteID
            // 
            this.participanteID.HeaderText = "ParticipanteID";
            this.participanteID.Name = "participanteID";
            this.participanteID.ReadOnly = true;
            // 
            // nombreParticipante
            // 
            this.nombreParticipante.HeaderText = "Nombre:";
            this.nombreParticipante.Name = "nombreParticipante";
            this.nombreParticipante.ReadOnly = true;
            // 
            // apellidoParticipante
            // 
            this.apellidoParticipante.HeaderText = "Apellido:";
            this.apellidoParticipante.Name = "apellidoParticipante";
            this.apellidoParticipante.ReadOnly = true;
            // 
            // tbLectora
            // 
            this.tbLectora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLectora.Location = new System.Drawing.Point(143, 397);
            this.tbLectora.Name = "tbLectora";
            this.tbLectora.Size = new System.Drawing.Size(274, 29);
            this.tbLectora.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Participante:";
            // 
            // btnLectora
            // 
            this.btnLectora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLectora.Location = new System.Drawing.Point(441, 397);
            this.btnLectora.Name = "btnLectora";
            this.btnLectora.Size = new System.Drawing.Size(141, 36);
            this.btnLectora.TabIndex = 7;
            this.btnLectora.Text = "Leer";
            this.btnLectora.UseVisualStyleBackColor = true;
            this.btnLectora.Click += new System.EventHandler(this.btnLectora_Click);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(18, 74);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(74, 24);
            this.lblEvento.TabIndex = 8;
            this.lblEvento.Text = "Evento:";
            // 
            // cbEvento
            // 
            this.cbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Items.AddRange(new object[] {
            "Evento1",
            "Evento2",
            "Evento3",
            "Evento4",
            "Evento5"});
            this.cbEvento.Location = new System.Drawing.Point(98, 71);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(321, 32);
            this.cbEvento.TabIndex = 9;
            // 
            // frmasistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 486);
            this.Controls.Add(this.cbEvento);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.btnLectora);
            this.Controls.Add(this.tbLectora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.tbParticipante);
            this.Controls.Add(this.lblParticipante);
            this.Controls.Add(this.dgvParticipante);
            this.Name = "frmasistencia";
            this.Text = "frmasistencia";
            this.Load += new System.EventHandler(this.frmasistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipante;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.TextBox tbParticipante;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.TextBox tbLectora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLectora;
        private System.Windows.Forms.DataGridViewTextBoxColumn participanteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoParticipante;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.ComboBox cbEvento;

    }
}