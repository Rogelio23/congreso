using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace AplicacionCongreso
{
    public partial class frmImpresionTickets : Form
    {
        string nombre;
        string apellido;
        int codigo;
        Font fuente = new Font("Arial", 11);

        public frmImpresionTickets()
        {
            InitializeComponent();
        }

        private void frmImpresionTickets_Load(object sender, EventArgs e)
        {
            dgvParticipante.DataSource = Controlador.ControladorParticipante.FillParticipante();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow renglon in dgvParticipante.Rows)
            {
                tbNombre.Text = (string)renglon.Cells[2].Value;
                tbApellido.Text = (string)renglon.Cells[1].Value;
                codigo = (int)renglon.Cells[0].Value;
                Herramientas.ImprimirCodigo(codigo, pbCodigo);
                Imprimir_Solicitud();
                
            }
        }
        public void Datos_Cliente(object obj, PrintPageEventArgs ev)
        {
            float pos_x = -4;
            float pos_y = 20;
            nombre = tbNombre.Text;
            apellido = tbApellido.Text;

            //Lo que vamos a imprimir
            //Estas 3 prmieras lineas de codigo son las que definen los datos del cliente
            ev.Graphics.DrawString("Nombre:", fuente, Brushes.Black, pos_x, pos_y, new StringFormat());
            ev.Graphics.DrawString("Apellido:", fuente, Brushes.Black, pos_x, pos_y + 15, new StringFormat());
            ev.Graphics.DrawString("Codigo:", fuente, Brushes.Black, pos_x, pos_y + 30, new StringFormat());
            //Estas ultimas 3 lineas de codigo son las que capturamos en nuestro formulario
            ev.Graphics.DrawString(nombre, fuente, Brushes.Black, pos_x + 65, pos_y, new StringFormat());
            ev.Graphics.DrawString(apellido, fuente, Brushes.Black, pos_x + 75, pos_y + 15, new StringFormat());
            ev.Graphics.DrawString(codigo.ToString(), fuente, Brushes.Black, pos_x + 80, pos_y + 30, new StringFormat());
            ev.Graphics.DrawImage(pbCodigo.Image, -8, 150, 185, 100);
            // para imprimir el codigo: (X,Y,Ancho,Alto)
            //madkmadfmasdff
        }
        public void Imprimir_Solicitud()
        {
            
            //Este método contiene dos componentes muy importantes los cuales son:

            //PrintDocument y printDialog estos métodos definen las propiedades de impresión

            //como son: numero de copias, numero de paginas y seleccionar tipo de impresora
            PrintDocument formulario = new PrintDocument();
            formulario.PrintPage += new PrintPageEventHandler(Datos_Cliente);
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = formulario;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                formulario.Print();
            }
        }
    }
}
