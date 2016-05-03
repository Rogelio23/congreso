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
        bool entrarDGV = true; //esta variable se encarga de no repetir el participante en el datagridview de asistencia
        public frmasistencia()
        {
            InitializeComponent();
        }

        private void frmasistencia_Load(object sender, EventArgs e)
        {
            dgvParticipante.DataSource = Controlador.ControladorParticipante.FillParticipante();
            tbCantidad.Text = "0";
        }

        private void btnLectora_Click(object sender, EventArgs e)
        {
            //tbParticipante.Text = tbLectora2.Text;
        }

        private void tbParticipante_TextChanged(object sender, EventArgs e)
        {
            int participanteID = int.Parse(tbLectora.Text);
            foreach (DataGridViewRow renglonAsistencia in dgvAsistencia.Rows)
            {
                if ((int)renglonAsistencia.Cells[0].Value == participanteID)
                {
                    entrarDGV = false;
                    break;
                }
            }


            if (entrarDGV==true)
            {
                
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

        }

        private void dgvParticipante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cbEvento.SelectedItem.ToString())==false && dgvAsistencia.RowCount>0)
            {
                Modelos.ModeloAsistencia asistencia = new Modelos.ModeloAsistencia();
                foreach (DataGridViewRow renglon in dgvAsistencia.Rows)
                {
                    asistencia.participante = (int)renglon.Cells[0].Value;
                    asistencia.evento = cbEvento.SelectedItem.ToString();
                    asistencia.congreso = "CongresoParamedicos";
                    Controlador.ControladorAsistencia.agregarParticipante(asistencia);
                }
                MessageBox.Show("Registro de asistencia guardado correctamente");
            }
            else
            {
                MessageBox.Show("Verifique el Evento a asistir");
            }
                        
        }

        private void tbLectora2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbLectora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Enter key is down

                //Capture the text
                if (sender is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(cbEvento.Text)==false)
                    {
                        tbParticipante.Text = tbLectora.Text;
                        Modelos.ModeloAsistencia asistencia = new Modelos.ModeloAsistencia();
                        asistencia.participante = int.Parse(tbParticipante.Text);
                        asistencia.evento = cbEvento.SelectedItem.ToString();
                        asistencia.congreso = "CongresoParamedicos";
                        Controlador.ControladorAsistencia.agregarParticipante(asistencia);
                        tbLectora.Text = "";
                        lblCantidad.Text = Controlador.ControladorAsistencia.contarAsistencia(cbEvento.Text).ToString();
                        int label = int.Parse(lblCantidad.Text);
                        int texbox = int.Parse(tbCantidad.Text);
                        if (label >= texbox)
                        {
                            lblCantidad.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblCantidad.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opcion en el evento");
                        tbLectora.Text = "";
                    }
                }
            }
        }

        private void tbBorrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Enter key is down

                //Capture the text
                if (sender is TextBox)
                {
                    
                    Controlador.ControladorAsistencia.eliminarAsistencia(int.Parse(tbBorrar.Text), cbEvento.SelectedItem.ToString());
                    tbBorrar.Text = "";
                }
            }
        }

        private void cbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCantidad.Text = Controlador.ControladorAsistencia.contarAsistencia(cbEvento.Text).ToString();
            int label = int.Parse(lblCantidad.Text);
            int texbox = int.Parse(tbCantidad.Text);
            if (label >= texbox)
            {
                lblCantidad.ForeColor = Color.Red;
            }
            else
            {
                lblCantidad.ForeColor = Color.Black;
            }
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_TextChanged(object sender, EventArgs e)
        {
            if(tbCantidad.Text!="0" && lblCantidad.Text == tbCantidad.Text)
            {
                lblCantidad.ForeColor = Color.Red;
            }
        }

        private void tbBorrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
