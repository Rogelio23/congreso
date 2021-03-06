﻿using System;
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
            //dgvParticipanteataSou.Drce = Controlador.ControladorParticipante.FillParticipante();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dgvParticipante.DataSource = Controlador.ControladorParticipante.FillParticipante();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmasistencia ventanaDeAsistencia = new frmasistencia();
            ventanaDeAsistencia.Show();
        }

        private void dgvParticipante_DoubleClick(object sender, EventArgs e)
        {

            //int participanteID= Herramientas.dgvValorInt(dgvParticipante, 0, 0);
            //frmParticipante ventanaParticipante = new frmParticipante();
            //ventanaParticipante.ShowDialog();
        }

        private void asistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmasistencia ventanaAsistencia = new frmasistencia();
            ventanaAsistencia.ShowDialog();
        }

        private void dgvParticipante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoParticipante_Click(object sender, EventArgs e)
        {
            frmParticipante ventanaParticipante = new frmParticipante("Nuevo");
            ventanaParticipante.ShowDialog();
        }

        private void btnModificarParticipante_Click(object sender, EventArgs e)
        {
            frmParticipante ventanaParticipante = new frmParticipante("Modificar");
            ventanaParticipante.ShowDialog();
        }

        private void btnBorrarParticipante_Click(object sender, EventArgs e)
        {
            frmParticipante ventanaParticipante = new frmParticipante("Borrar");
            ventanaParticipante.ShowDialog();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            frmImpresionTickets ventanaDeImprmirTickets = new frmImpresionTickets();
            ventanaDeImprmirTickets.Show();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            frmResultadosAsistencia ventanaVista = new frmResultadosAsistencia();
            ventanaVista.ShowDialog();
        }
    }
}
