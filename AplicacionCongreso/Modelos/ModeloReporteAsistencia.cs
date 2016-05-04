using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCongreso.Modelos
{
    class ModeloReporteAsistencia
    {
        public string fullName { get; set; }
        public string event_id { get; set; }
        public int participanteID { get; set; }
        public string evento { get; set; }
        public string evento2 { get; set; }
        public string evento3 { get; set; }
        public string evento4 { get; set; }
        public string evento5 { get; set; }

        public ModeloReporteAsistencia() { } //este es un constructor vacio que sirve en caso de querer crear objetos sin valores

        public ModeloReporteAsistencia(string nombre, string codigoEvento, string nomEvento, int participante, string nomEvento2, string nomEvento3, string nomEvento4, string nomEvento5)
        {
            this.fullName = nombre;
            this.event_id = codigoEvento;
            this.participanteID = participante;
            this.evento = nomEvento;
            this.evento2 = nomEvento2;
            this.evento3 = nomEvento3;
            this.evento4 = nomEvento4;
            this.evento5 = nomEvento5;
        }
    }
}
