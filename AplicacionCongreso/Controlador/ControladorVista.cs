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
                vista.event_id = datos.GetString(3);
                
                
                //vista.evento = datos.GetString(3);
                try
                {
                    vista.evento = datos.GetString(2);
                }
                catch (Exception)
                {

                    vista.evento = "_";
                }
                vista.participanteID = datos.GetInt32(4);
                lista.Add(vista);
                //foreach (Modelos.ModeloVistaAsistencia mva in lista)
                //{
                    //usar linqu
                //}
                                
            }
            return lista;
        }

        public static List<Modelos.ModeloVistaAsistencia> FillVistaAsistenciaConEvento(string nomEvento)
        {
            List<Modelos.ModeloVistaAsistencia> lista = new List<Modelos.ModeloVistaAsistencia>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM vistaAsitentesCongreso where event_id=2 and evento like '%" + nomEvento + "%';"), ConectionString.ObtenerConexion());
            MySqlDataReader datos = comando.ExecuteReader();
            //todos los datos de la consulta select son arrojados dentro de un objeto tipo MySQLcommand
            //con el while son introducidos dentro de una lista que servira para rellenar el datagridview
            while (datos.Read())
            {

                Modelos.ModeloVistaAsistencia vista = new Modelos.ModeloVistaAsistencia();

                vista.lname = datos.GetString(0);
                vista.fname = datos.GetString(1);
                vista.event_id = datos.GetString(3);
                //vista.evento = datos.GetString(3);
                try
                {
                    vista.evento = datos.GetString(2);
                }
                catch (Exception)
                {

                    vista.evento = "_";
                }
                lista.Add(vista);
                vista.participanteID = datos.GetInt32(4);
            }
            return lista;
        }
        public static List<Modelos.ModeloReporteAsistencia> FillReporteAsistencia()
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
                vista.event_id = datos.GetString(3);

                try
                {
                    vista.evento = datos.GetString(2);
                }
                catch (Exception)
                {

                    vista.evento = "_";
                }
                vista.participanteID = datos.GetInt32(4);
                lista.Add(vista);
            }
            string nombreCompletomva;
            string nombreCompletomra;
         
            List<Modelos.ModeloReporteAsistencia> ResultadoVista = new List<Modelos.ModeloReporteAsistencia>();
            foreach (Modelos.ModeloVistaAsistencia mva in lista)
            {
                nombreCompletomva = mva.lname + " " + mva.fname;
                Modelos.ModeloReporteAsistencia vistaResultado = new Modelos.ModeloReporteAsistencia();
                    foreach(Modelos.ModeloReporteAsistencia mra in ResultadoVista)
                    {
                    nombreCompletomra = mra.fullName;
                    //if(nombreCompletomva=nombreCompletomra)
                    if (nombreCompletomva == nombreCompletomra) {
                           if (mra.evento == "Día 1")
                           {
                            
                            }
                        
                        break;
                        }
      
                    }
            }
            return ResultadoVista;
        }



    }
}
//SELECT * FROM  vistaAsitentesCongreso WHERE event_id='2'

