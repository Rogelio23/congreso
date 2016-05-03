using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplicacionCongreso.Controlador
{
    class ControladorVista
    {
        /// <summary>
        /// Llena los datos de la vista para poder usarlos
        /// </summary>
        /// <returns></returns>
        public static List<Modelos.ModeloVistaAsistencia> FillVistaAsistencia()
        {
            List<Modelos.ModeloVistaAsistencia> lista = new List<Modelos.ModeloVistaAsistencia>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM vistaAsitentesCongreso where event_id=2;"), ConectionString.ObtenerConexion());
            MySqlDataReader datos = comando.ExecuteReader();
            //todos los datos de la consulta select son arrojados dentro de un objeto tipo MySQLcommand
            //con el while son introducidos dentro de una lista que servira para rellenar el datagridview
            while (datos.Read())
            {
                
                Modelos.ModeloVistaAsistencia vista = new Modelos.ModeloVistaAsistencia();
                
                vista.lname = datos.GetString(0);
                vista.fname = datos.GetString(1);
                vista.event_id = datos.GetString(2);
                //vista.evento = datos.GetString(3);
                try
                {
                    vista.evento = datos.GetString(3);
                }
                catch (Exception)
                {

                    vista.evento = "_";
                }
                lista.Add(vista);
                                
            }
            return lista;
        }
    }
}
//SELECT * FROM  vistaAsitentesCongreso WHERE event_id='2'