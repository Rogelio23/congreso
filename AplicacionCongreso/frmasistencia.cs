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
        }

        private void btnLectora_Click(object sender, EventArgs e)
        {
            tbParticipante.Text = tbLectora.Text;
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

        private void tbLectora_TextChanged(object sender, EventArgs e)
        {
            tbParticipante.Text = tbLectora.Text;
            tbLectora.Text = "";
        }
    }
}
