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
            this.lblEvento = new System.Windows.Forms.Label();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            this.tbBorrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dgvParticipante.Size = new System.Drawing.Size(405, 263);
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
            this.dgvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellContentClick);
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
            this.tbLectora.Location = new System.Drawing.Point(107, 397);
            this.tbLectora.Name = "tbLectora";
            this.tbLectora.Size = new System.Drawing.Size(274, 29);
            this.tbLectora.TabIndex = 6;
            this.tbLectora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLectora_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar:";
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
            "Día 1",
            "Día 2",
            "Día 3",
            "Taller de preparación de zona de aterrizaje para ambulancia de ala rotativa e int" +
                "eracción del personal de tierra.",
            "Taller para la implementación de programa interno de protección civil"});
            this.cbEvento.Location = new System.Drawing.Point(98, 71);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(739, 32);
            this.cbEvento.TabIndex = 9;
            this.cbEvento.SelectedIndexChanged += new System.EventHandler(this.cbEvento_SelectedIndexChanged);
            // 
            // tbBorrar
            // 
            this.tbBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBorrar.Location = new System.Drawing.Point(107, 446);
            this.tbBorrar.Name = "tbBorrar";
            this.tbBorrar.Size = new System.Drawing.Size(274, 29);
            this.tbBorrar.TabIndex = 14;
            this.tbBorrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBorrar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Borrar:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(731, 16);
            this.tbCantidad.Multiline = true;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(106, 49);
            this.tbCantidad.TabIndex = 15;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(730, 406);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(107, 76);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "25";
            this.lblCantidad.TextChanged += new System.EventHandler(this.lblCantidad_TextChanged);
            this.lblCantidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(739, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad:";
            // 
            // frmasistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbBorrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEvento);
            this.Controls.Add(this.lblEvento);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn participanteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoParticipante;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.ComboBox cbEvento;
        private System.Windows.Forms.TextBox tbBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label4;
    }
}