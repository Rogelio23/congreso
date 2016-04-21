namespace AplicacionCongreso
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvParticipante = new System.Windows.Forms.DataGridView();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipante)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParticipante
            // 
            this.dgvParticipante.AllowUserToAddRows = false;
            this.dgvParticipante.AllowUserToDeleteRows = false;
            this.dgvParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipante.Location = new System.Drawing.Point(52, 90);
            this.dgvParticipante.Name = "dgvParticipante";
            this.dgvParticipante.ReadOnly = true;
            this.dgvParticipante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipante.Size = new System.Drawing.Size(522, 263);
            this.dgvParticipante.TabIndex = 0;
            this.dgvParticipante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipante_CellContentClick);
            this.dgvParticipante.DoubleClick += new System.EventHandler(this.dgvParticipante_DoubleClick);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(52, 48);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(407, 26);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(483, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem1});
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // asistenciaToolStripMenuItem1
            // 
            this.asistenciaToolStripMenuItem1.Name = "asistenciaToolStripMenuItem1";
            this.asistenciaToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.asistenciaToolStripMenuItem1.Text = "Asistencia";
            this.asistenciaToolStripMenuItem1.Click += new System.EventHandler(this.asistenciaToolStripMenuItem1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 448);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.dgvParticipante);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipante)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipante;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem1;
    }
}

