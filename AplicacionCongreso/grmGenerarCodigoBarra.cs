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
    public partial class grmGenerarCodigoBarra : Form
    {
        string Nombre;
        string Direccion;
        string Telefono;
        Font fuente = new Font("Arial", 12);// estaba en 12

        public grmGenerarCodigoBarra()
        {
            InitializeComponent();
        }

        private void btnGenerador_Click(object sender, EventArgs e)
        {

            //string codigoBarras = tbCodigo.Text;
            //Bitmap codigo = new Bitmap(codigoBarras.Length * 60, 150); //Esta parte de aqui controla lo que se muestra en el picture box
            //using (Graphics graficos=Graphics.FromImage(codigo))
            //{
            //    Font oFont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 23);

            //    PointF punto = new PointF(2f, 2f); 
            //    SolidBrush negro=new SolidBrush(Color.Black);
            //    SolidBrush blanco = new SolidBrush(Color.White);
            //    graficos.FillRectangle(blanco,0,0,codigo.Width,codigo.Height);
            //    graficos.DrawString("*" + codigoBarras + "*", oFont, negro, punto);
            //}
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    codigo.Save(ms, ImageFormat.Png);
            //    pbResultado.Image = codigo;
            //    pbResultado.Height = codigo.Height;
            //    pbResultado.Width = codigo.Width;
            //}
            Herramientas.ImprimirCodigo(int.Parse(tbCodigo.Text), pbResultado);
        }

        private void grmGenerarCodigoBarra_Load(object sender, EventArgs e)
        {

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
        //En esta función se define los datos a imprimir en este caso

//los datos de nuestros clientes y la posición de los mismos en el documento
private void Datos_Cliente(object obj, PrintPageEventArgs ev)
{
    float pos_x = 10;
    float pos_y = 20;
    Nombre = tbNombre.Text;
    Direccion = tbDireccion.Text;
    Telefono = tbTelefono.Text;

    //Lo que vamos a imprimir
    //Estas 3 prmieras lineas de codigo son las que definen los datos del cliente
    ev.Graphics.DrawString("Nombre:", fuente, Brushes.Black, pos_x, pos_y, new StringFormat());
    ev.Graphics.DrawString("Direccion:", fuente, Brushes.Black, pos_x, pos_y + 15, new StringFormat());
    ev.Graphics.DrawString("Telefono:", fuente, Brushes.Black, pos_x, pos_y + 30, new StringFormat());
    //Estas ultimas 3 lineas de codigo son las que capturamos en nuestro formulario
    ev.Graphics.DrawString(Nombre,fuente,Brushes.Black,pos_x+65,pos_y,new StringFormat());
    ev.Graphics.DrawString(Direccion, fuente, Brushes.Black, pos_x+75, pos_y+15, new StringFormat());
    ev.Graphics.DrawString(Telefono, fuente, Brushes.Black, pos_x+80, pos_y+30, new StringFormat());
    ev.Graphics.DrawImage(pbResultado.Image, -8, 150, 200, 150);
    // para imprimir el codigo: (X,Y,Ancho,Alto)
    //madkmadfmasdff
}

private void btnImprimir_Click(object sender, EventArgs e)
{
    Imprimir_Solicitud();
}

private void pbResultado_Click(object sender, EventArgs e)
{

}
    
    }
}
