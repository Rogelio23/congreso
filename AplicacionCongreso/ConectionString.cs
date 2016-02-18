using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplicacionCongreso
{
    public class ConectionString
    {
        public static MySqlConnection ObtenerConexion()
        {
            // CONEXION CON LA BASE DE DATOS ...AQUI PIDE LA DIRECCION DEL SERVIDOR, NOMBRE DE LA DB       AQUI USUARIO         Y PWD=PASSWORD 
            MySqlConnection conectar = new MySqlConnection("server=68.71.146.173; database=lumbrera_congUt; Uid=lumbrera_Rogelio; pwd=manzana123;");
            conectar.Open();
            return conectar;
        }

    }
}
