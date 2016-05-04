using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCongreso.Modelos
{
    class ModeloReporteAsistencia
    {
        public String nombreAsistente { get; set; }
        public List<String> eventos { get; set; }

        public ModeloReporteAsistencia(){
            this.eventos = new List<string>();
        }

        public ModeloReporteAsistencia(String nombreAsistente, String eventosConcatenadosPorComa)
        {
            String [] eventos = eventosConcatenadosPorComa.Split((",").ToCharArray());
            this.eventos = new List<string>();
            foreach (String evento in eventos)
            {
                this.eventos.Add(evento);
            }
            this.nombreAsistente = nombreAsistente;
        }
    }
}
