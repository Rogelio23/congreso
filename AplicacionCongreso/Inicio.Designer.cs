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
            this.btnAisistencia = new System.Windows.Forms.Button();
            this.btnNuevoParticipante = new System.Windows.Forms.Button();
            this.btnModificarParticipante = new System.Windows.Forms.Button();
            this.btnBorrarParticipante = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAisistencia
            // 
            this.btnAisistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAisistencia.Location = new System.Drawing.Point(132, 129);
            this.btnAisistencia.Name = "btnAisistencia";
            this.btnAisistencia.Size = new System.Drawing.Size(103, 55);
            this.btnAisistencia.TabIndex = 2;
            this.btnAisistencia.Text = "Asistencia:";
            this.btnAisistencia.UseVisualStyleBackColor = true;
            this.btnAisistencia.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevoParticipante
            // 
            this.btnNuevoParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoParticipante.Location = new System.Drawing.Point(249, 129);
            this.btnNuevoParticipante.Name = "btnNuevoParticipante";
            this.btnNuevoParticipante.Size = new System.Drawing.Size(113, 55);
            this.btnNuevoParticipante.TabIndex = 4;
            this.btnNuevoParticipante.Text = "Nuevo Participante";
            this.btnNuevoParticipante.UseVisualStyleBackColor = true;
            this.btnNuevoParticipante.Click += new System.EventHandler(this.btnNuevoParticipante_Click);
            // 
            // btnModificarParticipante
            // 
            this.btnModificarParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarParticipante.Location = new System.Drawing.Point(376, 129);
            this.btnModificarParticipante.Name = "btnModificarParticipante";
            this.btnModificarParticipante.Size = new System.Drawing.Size(103, 55);
            this.btnModificarParticipante.TabIndex = 5;
            this.btnModificarParticipante.Text = "Modificar Participante:";
            this.btnModificarParticipante.UseVisualStyleBackColor = true;
            this.btnModificarParticipante.Click += new System.EventHandler(this.btnModificarParticipante_Click);
            // 
            // btnBorrarParticipante
            // 
            this.btnBorrarParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarParticipante.Location = new System.Drawing.Point(493, 129);
            this.btnBorrarParticipante.Name = "btnBorrarParticipante";
            this.btnBorrarParticipante.Size = new System.Drawing.Size(103, 55);
            this.btnBorrarParticipante.TabIndex = 6;
            this.btnBorrarParticipante.Text = "Borrar Participante:";
            this.btnBorrarParticipante.UseVisualStyleBackColor = true;
            this.btnBorrarParticipante.Click += new System.EventHandler(this.btnBorrarParticipante_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(610, 129);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(103, 55);
            this.btnTicket.TabIndex = 7;
            this.btnTicket.Text = "Generador de Tickets";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 448);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnBorrarParticipante);
            this.Controls.Add(this.btnModificarParticipante);
            this.Controls.Add(this.btnNuevoParticipante);
            this.Controls.Add(this.btnAisistencia);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAisistencia;
        private System.Windows.Forms.Button btnNuevoParticipante;
        private System.Windows.Forms.Button btnModificarParticipante;
        private System.Windows.Forms.Button btnBorrarParticipante;
        private System.Windows.Forms.Button btnTicket;
    }
}

