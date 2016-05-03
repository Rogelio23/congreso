using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplicacionCongreso.Controlador
{
    public class ControladorAsistencia
    {
        /// <summary>
        /// Agregar asistencia de participantes recibiendo como resultado un booleano
        /// </summary>
        /// <param name="asistencia"></param>
        /// <returns></returns>
        public static bool agregarParticipante(Modelos.ModeloAsistencia asistencia)
        {

            bool resultado = false;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into AsistenciaEventos (evento, participanteID, congreso) values ('{0}','{1}','{2}')",
               asistencia.evento, asistencia.participante, asistencia.congreso), ConectionString.ObtenerConexion());
            int query = comando.ExecuteNonQuery();
            if (query != 0) { resultado = true; }
            return resultado;
        }
        /// <summary>
        /// Elimina el registro de la base de datos reciviendo un dato tipo entero y un tipo string
        /// </summary>
        /// <param name="participanteid"></param>
        /// <returns></returns>
        public static bool eliminarAsistencia(int participanteid, string nomEvento)
        {
            bool resultado = false;
            MySqlCommand comando = new MySqlCommand(string.Format("Delete from AsistenciaEventos where participanteID="+participanteid+" AND evento='"+nomEvento+"'"), ConectionString.ObtenerConexion());
            int query = comando.ExecuteNonQuery();
            if (query != 0) { resultado = true; }
            return resultado;
        }
        public static int contarAsistencia(string nomEvento)
        {
            int intCantidad = 0;
            
            MySqlCommand comando = new MySqlCommand(string.Format("select count(*) as contador from AsistenciaEventos where congreso='CongresoParamedicos' and evento='"+nomEvento+"'"), ConectionString.ObtenerConexion());
            //intCantidad = comando.ExecuteNonQuery();
            intCantidad = Convert.ToInt32(comando.ExecuteScalar());
            
            return intCantidad;
        }

    }
}
