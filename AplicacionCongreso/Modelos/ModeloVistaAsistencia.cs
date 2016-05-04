using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCongreso.Modelos
{
    class ModeloVistaAsistencia
    {
        public string lname { get; set; }
        public string fname { get; set; }
        public string event_id { get; set; }
        public string evento { get; set; }
        public int participanteID { get; set; }


        public ModeloVistaAsistencia() { } //este es un constructor vacio que sirve en caso de querer crear objetos sin valores

        public ModeloVistaAsistencia(string apellido, string nombre, string codigoEvento, string nomEvento,int participante)
        {
            this.lname = apellido;
            this.fname = nombre;
            this.event_id = codigoEvento;
            this.evento = nomEvento;
            this.participanteID = participante;
        }
    }
}
