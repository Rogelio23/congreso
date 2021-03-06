﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplicacionCongreso.Controlador
{
    public class ControladorParticipante
    {

        public static bool agregarParticipante(Modelos.ModeloParticipante participante)
        {

            bool resultado = false;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into wp_evr_attendee (fname, lname,phone,email, event_id, city) values ('{0}','{1}','{2}', '{3}','{4}','{5}')",
               participante.fname, participante.lname, participante.phone, participante.email, 2, participante.city), ConectionString.ObtenerConexion());
            int query = comando.ExecuteNonQuery();
            if (query != 0) { resultado = true; }
            return resultado;
        }
        /// <summary>
        /// Elimina el registro de la base de datos reciviendo un dato tipo entero
        /// </summary>
        /// <param name="participanteid"></param>
        /// <returns></returns>
        public static bool eliminarParticipante(int participanteid)
        {
            bool resultado = false;
            MySqlCommand comando = new MySqlCommand(string.Format("Delete from wp_evr_attendee participanteID="+participanteid+""), ConectionString.ObtenerConexion());
            int query = comando.ExecuteNonQuery();
            if (query != 0) { resultado = true; }
            return resultado;
        }
        /// <summary>
        /// Metodo Fill que arroja todos los campos de la tabla de participantes
        /// </summary>
        /// <returns></returns>
        public static List<Modelos.ModeloParticipante> FillParticipante()
        {
            List<Modelos.ModeloParticipante> lista = new List<Modelos.ModeloParticipante>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM  wp_evr_attendee WHERE event_id='2'"), ConectionString.ObtenerConexion());
            MySqlDataReader datos = comando.ExecuteReader();
            //todos los datos de la consulta select son arrojados dentro de un objeto tipo MySQLcommand
            //con el while son introducidos dentro de una lista que servira para rellenar el datagridview
            while (datos.Read())
            {
                //try
                //{
                    Modelos.ModeloParticipante participante = new Modelos.ModeloParticipante();
                    participante.ID = datos.GetInt32(0);
                    participante.lname = datos.GetString(1);
                    participante.fname = datos.GetString(2);
                    participante.email = datos.GetString(3);
                    participante.city = datos.GetString(4);
                    participante.state = datos.GetString(5);

                    lista.Add(participante);
                //}
                //catch (Exception)
                //{

                //   // throw;
                //}
            }
            return lista;
        }
        public static Modelos.ModeloParticipante ObtenerParticipante(int id)
        {
            Modelos.ModeloParticipante participante = new Modelos.ModeloParticipante();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT *FROM wp_evr_attendee WHERE ID={0}", id), ConectionString.ObtenerConexion());
            MySqlDataReader datos = comando.ExecuteReader();
            while (datos.Read())
            {
                //participante.ID = datos.GetInt32(0);
                participante.fname = datos.GetString(1);
                participante.lname = datos.GetString(2);
                participante.phone = datos.GetString(9);
                participante.email = datos.GetString(8);
                participante.city = datos.GetString(4);
                participante.state = datos.GetString(5);
                
            }
            ConectionString.ObtenerConexion().Close();
            return participante;
        }

        /// <summary>
        /// Metodo Fill que arroja todos los campos de la tabla de participantes
        /// </summary>
        /// <returns></returns>
        public static List<Modelos.ModeloParticipante> FillParticipanteByNombre(string xName)
        {
            List<Modelos.ModeloParticipante> lista = new List<Modelos.ModeloParticipante>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM  wp_evr_attendee WHERE event_id='2' and (lname like '%" + xName+ "%' or fname like '%" + xName + "%')"), ConectionString.ObtenerConexion());
            MySqlDataReader datos = comando.ExecuteReader();
            //todos los datos de la consulta select son arrojados dentro de un objeto tipo MySQLcommand
            //con el while son introducidos dentro de una lista que servira para rellenar el datagridview
            while (datos.Read())
            {
                Modelos.ModeloParticipante participante = new Modelos.ModeloParticipante();
                participante.ID = datos.GetInt32(0);
                participante.lname = datos.GetString(1);
                participante.fname = datos.GetString(2);
                participante.address = datos.GetString(3);
                participante.city = datos.GetString(4);
                participante.state = datos.GetString(5);


                lista.Add(participante);
            }
            return lista;
        }
        public static bool modificareParticipante(Modelos.ModeloParticipante participante)
        {

            bool resultado = false;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE wp_evr_attendee set lname='"+participante.lname+"',fname='"+participante.fname+"',city='"+participante.city+"',state='"+participante.state+"',phone='"+participante.phone+"',email='"+participante.email+ "' where id="+participante.ID+";"), ConectionString.ObtenerConexion());
            int query = comando.ExecuteNonQuery();
            if (query != 0) { resultado = true; }
            return resultado;
        }

    }
}
