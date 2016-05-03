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
    public partial class frmResultadosAsistencia : Form
    {
        public frmResultadosAsistencia()
        {
            InitializeComponent();
        }

        private void frmResultadosAsistencia_Load(object sender, EventArgs e)
        {
            //dgvParticipante.DataSource = Controlador.ControladorParticipante.FillParticipante();
            dgvAsistencia.DataSource = Controlador.ControladorVista.FillVistaAsistencia();
            lblCantidad.Text = dgvAsistencia.RowCount.ToString();
        }

        private void dgvAsistencia_Validating(object sender, CancelEventArgs e)
        {
            DataGridViewRow row = dgvAsistencia.CurrentRow as DataGridViewRow;

            if (row.Cells[0].Value == DBNull.Value)
            {

                dgvAsistencia.CancelEdit();
                e.Cancel = true;

            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            Herramientas.ExportarDataGridViewExcel(dgvAsistencia);
        }

        private void cbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbEvento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEvento.Text) == false)
            {
                dgvAsistencia.DataSource = Controlador.ControladorVista.FillVistaAsistenciaConEvento(cbEvento.Text);
                lblCantidad.Text = dgvAsistencia.RowCount.ToString();
            }
            else
            {
                dgvAsistencia.DataSource = Controlador.ControladorVista.FillVistaAsistencia();
                lblCantidad.Text = dgvAsistencia.RowCount.ToString();
            }
        }
    }
}
