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
        }
    }
}
