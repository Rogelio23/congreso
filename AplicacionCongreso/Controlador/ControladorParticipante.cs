using System;
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
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Participante (participanteID, nombreParticipante, apellidoMaterno,tel,correo,pagado) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}')",
               participante.ID, participante.fname, participante.lname, participante.phone, participante.email, 1), ConectionString.ObtenerConexion());
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
            MySqlCommand comando = new MySqlCommand(string.Format("Delete from Participante where participanteID={0}", participanteid), ConectionString.ObtenerConexion());
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
                Modelos.ModeloParticipante participante = new Modelos.ModeloParticipante();
                participante.ID = datos.GetInt32(0);
                participante.lname = datos.GetString(1);
                participante.fname = datos.GetString(2);
                participante.address = datos.GetString(3);
                participante.city = datos.GetString(4);
                

                lista.Add(participante);
            }
            return lista;
        }
        //public static Modelos.ModeloParticipante ObtenerParticipante(int id)
        //{
        //    Modelos.ModeloParticipante participante = new Modelos.ModeloParticipante();
        //    MySqlCommand comando = new MySqlCommand(string.Format("SELECT *FROM wp_evr_attendee WHERE ID={0}", id), ConectionString.ObtenerConexion());
        //    MySqlDataReader datos = comando.ExecuteReader();
        //    while (datos.Read())
        //    {
        //        participante.ID = datos.GetInt32(0);
        //        participante.fname = datos.GetString(1);
        //        participante.lname = datos.GetString(2);
        //        //participante.apellidoMaterno = datos.GetString(3);
        //        participante.phone = datos.GetInt32(3);
        //        participante.email = datos.GetString(4); 
        //    }
        //    ConectionString.ObtenerConexion().Close();
        //    return participante;
        //}
    }
}
