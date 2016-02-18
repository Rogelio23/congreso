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
    public partial class frmParticipante : Form
    {
        int participanteID = 0;
        public frmParticipante(int id)
        {
            InitializeComponent();
            participanteID = id;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbParticipanteID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Modelos.ModeloParticipante participante=new Modelos.ModeloParticipante();
            //participante.ID =int.Parse(tbParticipanteID.Text);
            //participante.fname = tbNombre.Text;
            //participante.lname = tbApellidoMaterno.Text;
            ////participante.apellidoMaterno = tbApellidoMaterno.Text;
            //participante.phone = int.Parse(tbTelefono.Text);
            //participante.email = tbCorreo.Text;

            //bool agregar= Controlador.ControladorParticipante.agregarParticipante(participante);
            //if (agregar == true)
            //{
            //    MessageBox.Show("Participante guardado exitosamente");
            //}
            //else
            //{
            //    MessageBox.Show("No se guardo el Participante");
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //int participanteID = int.Parse(tbParticipanteID.Text);
            //bool eliminar = Controlador.ControladorParticipante.eliminarParticipante(participanteID);
            //if (eliminar == true)
            //{
            //    MessageBox.Show("Participante eliminado exitosamente");
            //}
            //else
            //{
            //    MessageBox.Show("No se elimino el Participante");
            //}
        }

        private void frmParticipante_Load(object sender, EventArgs e)
        {
            //if (participanteID != 0) 
            //{
            //    Modelos.ModeloParticipante participante = new Modelos.ModeloParticipante();
            //    participante = Controlador.ControladorParticipante.ObtenerParticipante(participanteID);
            //    tbParticipanteID.Text = participante.ID.ToString();
            //    tbNombre.Text = participante.fname;
            //    tbApellidoPaterno.Text = participante.lname;
            //    //tbApellidoMaterno.Text = participante.apellidoMaterno;
            //    tbTelefono.Text = participante.phone.ToString();
            //    tbCorreo.Text = participante.email; 
            //}

        }
    }
}
