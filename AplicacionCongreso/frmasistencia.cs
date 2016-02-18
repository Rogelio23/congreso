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
    public partial class frmasistencia : Form
    {
        public frmasistencia()
        {
            InitializeComponent();
        }

        private void frmasistencia_Load(object sender, EventArgs e)
        {
            dgvParticipante.DataSource = Controlador.ControladorParticipante.FillParticipante();
        }

        private void btnLectora_Click(object sender, EventArgs e)
        {
            tbParticipante.Text = tbLectora.Text;
        }

        private void tbParticipante_TextChanged(object sender, EventArgs e)
        {
            
            

            int participanteID = int.Parse(tbLectora.Text);
            foreach (DataGridViewRow renglon in dgvParticipante.Rows)
            {


                if ((int)renglon.Cells[0].Value == participanteID)
                {
                    
                        dgvAsistencia.AllowUserToAddRows = true;
                        DataGridViewRow row = (DataGridViewRow)dgvAsistencia.Rows[0].Clone();
                        row.Cells[0].Value = renglon.Cells[0].Value;
                        row.Cells[1].Value = renglon.Cells[2].Value;
                        row.Cells[2].Value = renglon.Cells[1].Value;
                        dgvAsistencia.Rows.Add(row);
                        dgvAsistencia.AllowUserToAddRows = false;
                        break;  
               

                }
            }

        }

        private void dgvParticipante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
