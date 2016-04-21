using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCongreso
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            dgvParticipante.DataSource = Controlador.ControladorParticipante.FillParticipante();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvParticipante.DataSource = Controlador.ControladorParticipante.FillParticipante();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvParticipante_DoubleClick(object sender, EventArgs e)
        {

            int participanteID= Herramientas.dgvValorInt(dgvParticipante, 0, 0);
            frmParticipante ventanaParticipante = new frmParticipante(participanteID);
            ventanaParticipante.ShowDialog();
        }

        private void asistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmasistencia ventanaAsistencia = new frmasistencia();
            ventanaAsistencia.ShowDialog();
        }

        private void dgvParticipante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
