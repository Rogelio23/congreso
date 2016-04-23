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
        string estado; //esta variable controla si es una alta, baja o modificacion.
        public frmParticipante(string estadoLlegada)
        {
            InitializeComponent();
            estado = estadoLlegada;
            if (estadoLlegada == "Borrar")
            {
                tbParticipanteID.Visible = true;
                lblParticipanteID.Visible = true;
                btnGuardar.Text = "Eliminar Participante";
            }
            else if(estadoLlegada=="Modificar")
            {
                tbParticipanteID.Visible = true;
                lblParticipanteID.Visible = true;
                btnGuardar.Text = "Modificar Participante";
            }

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
            if (btnGuardar.Text== "Guardar Participante")
            {
                if (validacionParticipante()==true)
                {
                    Modelos.ModeloParticipante participante = new Modelos.ModeloParticipante();
                    participante.fname = tbNombre.Text;
                    participante.lname = tbApellido.Text;
                    participante.phone = tbTelefono.Text;
                    participante.email = tbCorreo.Text;
                    participante.city = tbCiudad.Text;

                    bool agregar = Controlador.ControladorParticipante.agregarParticipante(participante);
                    if (agregar == true)
                    {
                        MessageBox.Show("Participante guardado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se guardo el Participante");
                    }  
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos");
                }
            }
            else if (btnGuardar.Text== "Modificar Participante")
            {
                if (validacionParticipante()==true)
                {
                    MessageBox.Show("Usted esta modificando"); 
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos");
                }
            }
            else
            {
                if (validacionParticipante()==true)
                {
                    //MessageBox.Show("Usted esta borrando"); 
                    Controlador.ControladorParticipante.eliminarParticipante(int.Parse(tbParticipanteID.Text));
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos");
                }
            }
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
        public bool validacionParticipante()
        {
            bool resultado = true;
            if (string.IsNullOrWhiteSpace(tbNombre.Text)&&string.IsNullOrWhiteSpace(tbApellido.Text)&&string.IsNullOrWhiteSpace(tbTelefono.Text)&&string.IsNullOrWhiteSpace(tbCorreo.Text)&&string.IsNullOrWhiteSpace(tbCiudad.Text))
            {
                resultado = false;
            }
            return resultado;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbParticipanteID_KeyDown(object sender, KeyEventArgs e)
        {
            int participanteID;
            if (e.KeyCode == Keys.Enter)
            {
                
                if (sender is TextBox)
                {
                    participanteID = int.Parse(tbParticipanteID.Text);
                    Modelos.ModeloParticipante participante = new Modelos.ModeloParticipante();
                    participante = Controlador.ControladorParticipante.ObtenerParticipante(participanteID);
                    tbNombre.Text = participante.fname;
                    tbApellido.Text = participante.lname;
                    tbTelefono.Text = participante.phone;
                    tbCorreo.Text = participante.email;
                    tbCiudad.Text = participante.city;
                }
            }
        }
    }
}
