using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCongreso.Modelos
{
    public class ModeloAsistencia
    {
        public int asistenciaID { get; set; }
        public string evento { get; set; }
        public int participante { get; set; }
        public string congreso { get; set; }


        public ModeloAsistencia() { } //este es un constructor vacio que sirve en caso de querer crear objetos sin valores

        public ModeloAsistencia(int asistencia, string eventoasistido, int codParticipante, string congresoAsistido)
        {
            this.asistenciaID = asistencia;
            this.evento = eventoasistido;
            this.participante = codParticipante;
            this.congreso = congresoAsistido;
        }

    }
}
